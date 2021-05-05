using NUnit.Framework;

// Change to OneHour.Linq to run real tests
//using System.Linq;
using OneHour.Linq;

namespace OneHourLinq.Tests
{
    [TestFixture]
    public class GroupBy
    {
        [Test]
        public void QueryExpressionWithTrivialSelect()
        {
            var jon = new { Name = "Jon", Score = 8 };
            var holly = new { Name = "Holly", Score = 7 };
            var tom = new { Name = "Tom", Score = 8 };
            var will = new { Name = "Will", Score = 9 };
            var robin = new { Name = "Robin", Score = 9 };

            var results = new[] { jon, holly, tom, will, robin };

            var query = from result in results
                        group result by result.Score;

            var list = query.ToList();

            Assert.AreEqual(8, list[0].Key);
            list[0].AssertSequenceEqual(jon, tom);

            Assert.AreEqual(7, list[1].Key);
            list[1].AssertSequenceEqual(holly);

            Assert.AreEqual(9, list[2].Key);
            list[2].AssertSequenceEqual(will, robin);
        }

        [Test]
        public void QueryExpressionWithNonTrivialSelect()
        {
            var jon = new { Name = "Jon", Score = 8 };
            var holly = new { Name = "Holly", Score = 7 };
            var tom = new { Name = "Tom", Score = 8 };
            var will = new { Name = "Will", Score = 9 };
            var robin = new { Name = "Robin", Score = 9 };

            var results = new[] { jon, holly, tom, will, robin };

            var query = from result in results
                        group result.Name by result.Score;

            var list = query.ToList();

            Assert.AreEqual(8, list[0].Key);
            list[0].AssertSequenceEqual("Jon", "Tom");

            Assert.AreEqual(7, list[1].Key);
            list[1].AssertSequenceEqual("Holly");

            Assert.AreEqual(9, list[2].Key);
            list[2].AssertSequenceEqual("Will", "Robin");
        }
    }
}
