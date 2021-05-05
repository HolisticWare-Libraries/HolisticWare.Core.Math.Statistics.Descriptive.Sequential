using System;
using NUnit.Framework;

// Change to OneHour.Linq to run real tests
using System.Linq;
//using OneHour.Linq;

namespace OneHourLinq.Tests
{
    [TestFixture]
    public class Where
    {
        [Test]
        public void QueryExpression()
        {
            var source = new[] { 1, 2, 3, 4, 5 };
            var query = from number in source
                        where number % 2 == 0
                        select number;

            query.AssertSequenceEqual(2, 4);
        }

        [Test]
        public void WhereFailsForAll()
        {
            var source = new[] { 1, 2, 3, 4, 5 };
            var query = source.Where(number => number > 10);

            query.AssertSequenceEqual();
        }

        [Test]
        public void WhereSucceedsForAll()
        {
            var source = new[] { 1, 2, 3, 4, 5 };
            var query = source.Where(number => number < 10);

            query.AssertSequenceEqual(source);
        }

        [Test]
        public void EvenTest()
        {
            var source = new[] { 1, 2, 3, 4, 5 };
            var query = source.Where(number => number % 2 == 0);

            query.AssertSequenceEqual(2, 4);
        }
    }
}
