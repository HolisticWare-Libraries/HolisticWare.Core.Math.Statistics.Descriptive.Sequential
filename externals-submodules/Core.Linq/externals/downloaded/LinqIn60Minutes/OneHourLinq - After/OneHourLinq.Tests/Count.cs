using NUnit.Framework;

// Change to OneHour.Linq to run real tests
//using System.Linq;
using OneHour.Linq;

namespace OneHourLinq.Tests
{
    [TestFixture]
    public class Count
    {
        [Test]
        public void EmptyCount()
        {
            Assert.AreEqual(0, new int[0].Count());
        }

        [Test]
        public void NonEmptyCount()
        {
            var source = new[] { 5, 10, 2 };

            Assert.AreEqual(3, source.Count());
        }

        [Test]
        public void NonEmptyCountNonList()
        {
            var source = new[] { 5, 10, 2 }.Select(x => x);

            Assert.AreEqual(3, source.Count());
        }
    }
}
