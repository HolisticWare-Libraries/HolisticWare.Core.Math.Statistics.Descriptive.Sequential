using System.Collections.Generic;
using NUnit.Framework;

// Change to OneHour.Linq to run real tests
using System.Linq;
//using OneHour.Linq;

namespace OneHourLinq.Tests
{
    [TestFixture]
    public class Empty
    {
        [Test]
        public void EmptyInt32()
        {
            IEnumerable<int> emptySequence = Enumerable.Empty<int>();
            emptySequence.AssertSequenceEqual();
        }

        [Test]
        public void EmptyString()
        {
            IEnumerable<string> emptySequence = Enumerable.Empty<string>();
            emptySequence.AssertSequenceEqual(); 
        }
    }
}
