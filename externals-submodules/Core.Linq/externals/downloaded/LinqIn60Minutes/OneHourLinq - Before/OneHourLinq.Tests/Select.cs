using System;
using System.Collections.Generic;
using NUnit.Framework;

// Change to OneHour.Linq to run real tests
using System.Linq;
//using OneHour.Linq;

namespace OneHourLinq.Tests
{
    [TestFixture]
    public class Select
    {
        [Test]
        public void QueryExpression()
        {
            var source = new[] {1, 2, 3, 4, 5};
            var query = from number in source
                        select number.ToString();

            query.AssertSequenceEqual("1", "2", "3", "4", "5");
        }

        [Test]
        public void NoOpProjection()
        {
            var source = new[] { 1, 2, 3, 4, 5 };
            var query = source.Select(x => x);

            query.AssertSequenceEqual(source);
        }

        [Test]
        public void ProjectionWithSameType()
        {
            var source = new[] { 1, 2, 3, 4, 5 };
            var query = source.Select(x => x*2);

            query.AssertSequenceEqual(2, 4, 6, 8, 10);
        }

        [Test]
        public void ProjectionToDifferentType()
        {
            var source = new[] { 1, 2, 3, 4, 5 };
            var query = source.Select(x => x.ToString());

            query.AssertSequenceEqual("1", "2", "3", "4", "5");
        }

        [Test]
        [ExpectedException(typeof(ArgumentNullException))]
        public void NullSourceThrowsException()
        {
            Enumerable.Select((IEnumerable<string>)null, x => x);
        }
    }
}
