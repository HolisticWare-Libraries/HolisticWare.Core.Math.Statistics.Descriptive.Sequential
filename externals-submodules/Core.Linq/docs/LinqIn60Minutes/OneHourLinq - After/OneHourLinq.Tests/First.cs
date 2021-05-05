using System;
using NUnit.Framework;

// Change to OneHour.Linq to run real tests
//using System.Linq;
using OneHour.Linq;

namespace OneHourLinq.Tests
{
    [TestFixture]
    public class First
    {
        [Test]
        public void FirstWithElementPresent()
        {
            var numbers = new[] { 3, 5, 7 };
            Assert.AreEqual(3, numbers.First());
        }

        [Test]
        public void FirstOrDefaultWithElementPresent()
        {
            var numbers = new[] { 3, 5, 7 };
            Assert.AreEqual(3, numbers.FirstOrDefault());
        }

        [Test]
        [ExpectedException(typeof(InvalidOperationException))]
        public void FirstWithNoElementPresent()
        {
            new int[0].First();
        }

        [Test]
        public void FirstOrDefaultNoWithElementPresent()
        {
            Assert.AreEqual(0, new int[0].FirstOrDefault());
        }
    }
}
