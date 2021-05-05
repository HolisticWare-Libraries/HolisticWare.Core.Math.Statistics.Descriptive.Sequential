using System.Text;
using NUnit.Framework;

// Change to OneHour.Linq to run real tests
//using System.Linq;
using OneHour.Linq;

namespace OneHourLinq.Tests
{
    [TestFixture]
    public class Aggregate
    {
        [Test]
        public void StringBuilderAggregate()
        {
            var numbers = new[] { 5, 4, 1, 6, 2 };

            string result = numbers.Aggregate(new StringBuilder(), (sb, x) => sb.Append(x), sb => sb.ToString());
            Assert.AreEqual("54162", result);
        }

        [Test]
        public void StringConcatAggregate()
        {
            var numbers = new[] { 5, 4, 1, 6, 2 };

            string result = numbers.Aggregate("x", (s, x) => s + x, s => s + "y");
            Assert.AreEqual("x54162y", result);
        }
    }
}
