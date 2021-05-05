using System;
using NUnit.Framework;

// Change to OneHour.Linq to run real tests
using System.Linq;
//using OneHour.Linq;

namespace OneHourLinq.Tests
{
    [TestFixture]
    public class SequenceEqual
    {
        [Test]
        public void EmptySequencesAreEqual()
        {
            Assert.IsTrue((new int[0]).SequenceEqual(new int[0]));
        }

        [Test]
        public void FirstSequenceLongerThanSecond()
        {
            Assert.IsFalse(new[] {1, 2}.SequenceEqual(new[] {1}));
        }

        [Test]
        public void SecondSequenceLongerThanFirst()
        {
            Assert.IsFalse(new[] {1}.SequenceEqual(new[] {1, 2}));
        }

        [Test]
        public void ElementsDifferMidSequence()
        {
            Assert.IsFalse(new[] {1, 2, 3}.SequenceEqual(new[] {1, 4, 3}));
        }

        [Test]
        public void SequencesGenuinelyAreEqual()
        {
            Assert.IsTrue(new[] {1, 2, 3}.SequenceEqual(new[] { 1, 2, 3}));
        }
    }
}
