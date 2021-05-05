using System;
using System.Collections.Generic;
using NUnit.Framework;

// Change to OneHour.Linq to run real tests
using System.Linq;
//using OneHour.Linq;

namespace OneHourLinq.Tests
{
    [TestFixture]
    public class ToArray
    {
        [Test]
        public void EmptyList()
        {
            int[] list = new int[0].ToArray();

            Assert.AreEqual(0, list.Length);
        }

        [Test]
        public void NonEmptyList()
        {
            var source = new[] { 5, 10, 2 };
            int[] list = source.ToArray();

            Assert.IsTrue(list.SequenceEqual(source));
        }
    }
}
