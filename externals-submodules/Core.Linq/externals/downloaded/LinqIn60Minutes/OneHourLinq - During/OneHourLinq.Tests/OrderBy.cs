using NUnit.Framework;

// Change to OneHour.Linq to run real tests
using System.Linq;
//using OneHour.Linq;

namespace OneHourLinq.Tests
{
    [TestFixture]
    public class OrderBy
    {
        internal static readonly LetterAndNumber[] Sample = 
        {
            "C5", "D1", "B3", "H2", "D3", "H1", "B5"
        };

        [Test]
        public void QueryExpressionNumberAscending()
        {
            var query = from pair in Sample
                        orderby pair.Number
                        select pair;

            query.AssertSequenceEqual(new LetterAndNumber[] { "D1", "H1", "H2", "B3", "D3", "C5", "B5" });
        }

        [Test]
        public void NoOpOrderByPreservesOrder()
        {
            var query = Sample.OrderBy(x => 1);

            query.AssertSequenceEqual(Sample);
        }

        [Test]
        public void OrderByWithNull()
        {
            var query = new[] { "a", null, "b" }.OrderBy(x => x);
            query.AssertSequenceEqual(null, "a", "b");
        }

        [Test]
        public void OrderByDescendingWithNull()
        {
            var query = new[] { "a", null, "b" }.OrderByDescending(x => x);
            query.AssertSequenceEqual("b", "a", null);
        }


        [Test]
        public void OrderByLetterAscending()
        {
            var query = Sample.OrderBy(x => x.Letter);

            query.AssertSequenceEqual((new LetterAndNumber[]{"B3", "B5", "C5", "D1", "D3", "H2", "H1"}));
        }

        [Test]
        public void OrderByLetterDescending()
        {
            var query = Sample.OrderByDescending(x => x.Letter);

            query.AssertSequenceEqual((new LetterAndNumber[]{"H2", "H1", "D1", "D3", "C5", "B3", "B5"}));
        }
    }
}
