using System;
using NUnit.Framework;

// Change to OneHour.Linq to run real tests
//using System.Linq;
using OneHour.Linq;

namespace OneHourLinq.Tests
{
    [TestFixture]
    public class ToLookup
    {
        [Test]
        public void NoProjection()
        {
            var jon = new { Name = "Jon", Score = 8 };
            var holly = new { Name = "Holly", Score = 7 };
            var tom = new { Name = "Tom", Score = 8 };
            var will = new { Name = "Will", Score = 9 };
            var robin = new { Name = "Robin", Score = 9 };

            var lookup = new[] { jon, holly, tom, will, robin }.ToLookup(person => person.Score);

            Assert.AreEqual(3, lookup.Count);

            lookup[7].AssertSequenceEqual(holly);
            lookup[8].AssertSequenceEqual(jon, tom);
            lookup[9].AssertSequenceEqual(will, robin);
        }

        [Test]
        public void WithProjection()
        {
            var jon = new { Name = "Jon", Score = 8 };
            var holly = new { Name = "Holly", Score = 7 };
            var tom = new { Name = "Tom", Score = 8 };
            var will = new { Name = "Will", Score = 9 };
            var robin = new { Name = "Robin", Score = 9 };

            var lookup = new[] { jon, holly, tom, will, robin }.ToLookup(person => person.Score, person => person.Name);

            Assert.AreEqual(3, lookup.Count);

            lookup[7].AssertSequenceEqual("Holly");
            lookup[8].AssertSequenceEqual("Jon", "Tom");
            lookup[9].AssertSequenceEqual("Will", "Robin");
        }
    }
}
