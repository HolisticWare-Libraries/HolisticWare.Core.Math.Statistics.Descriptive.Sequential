using NUnit.Framework;

// Change to OneHour.Linq to run real tests
//using System.Linq;
using OneHour.Linq;

namespace OneHourLinq.Tests
{
    [TestFixture]
    public class ThenBy
    {
        [Test]
        public void QueryExpressionNumberAscendingLetterDescending()
        {
            var query = from pair in OrderBy.Sample
                        orderby pair.Number, pair.Letter descending
                        select pair;

            query.AssertSequenceEqual(new LetterAndNumber[] { "H1", "D1", "H2", "D3", "B3", "C5", "B5" });
        }

        [Test]
        public void OrderByLetterAscendingThenNumberAscending()
        {
            var query = OrderBy.Sample.OrderBy(x => x.Letter).ThenBy(x => x.Number);

            query.AssertSequenceEqual((new LetterAndNumber[] { "B3", "B5", "C5", "D1", "D3", "H1", "H2" }));
        }

        [Test]
        public void OrderByLetterAscendingThenNumberDescending()
        {
            var query = OrderBy.Sample.OrderBy(x => x.Letter).ThenByDescending(x => x.Number);

            query.AssertSequenceEqual((new LetterAndNumber[] { "B5", "B3", "C5", "D3", "D1", "H2", "H1" }));
        }

        [Test]
        public void OrderByLetterDescendingThenNumberAscending()
        {
            var query = OrderBy.Sample.OrderByDescending(x => x.Letter).ThenBy(x => x.Number);

            query.AssertSequenceEqual((new LetterAndNumber[] { "H1", "H2", "D1", "D3", "C5", "B3", "B5" }));
        }

        [Test]
        public void OrderByLetterDescendingThenNumberDescending()
        {
            var query = OrderBy.Sample.OrderByDescending(x => x.Letter).ThenByDescending(x => x.Number);

            query.AssertSequenceEqual((new LetterAndNumber[] { "H2", "H1", "D3", "D1", "C5", "B5", "B3" }));
        }
    }
}
