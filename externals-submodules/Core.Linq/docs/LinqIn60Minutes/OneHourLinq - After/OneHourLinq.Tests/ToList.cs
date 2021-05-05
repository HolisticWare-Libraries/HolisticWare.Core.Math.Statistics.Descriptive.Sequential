using System.Collections.Generic;
using NUnit.Framework;

// Change to OneHour.Linq to run real tests
//using System.Linq;
using OneHour.Linq;

namespace OneHourLinq.Tests
{
    [TestFixture]
    public class ToList
    {
        [Test]
        public void EmptyList()
        {
            List<int> list = new int[0].ToList();

            Assert.AreEqual(0, list.Count);
        }

        [Test]
        public void NonEmptyList()
        {
            var source = new[] { 5, 10, 2 };
            List<int> list = source.ToList();

            Assert.IsTrue(list.SequenceEqual(source));
        }
    }
}
