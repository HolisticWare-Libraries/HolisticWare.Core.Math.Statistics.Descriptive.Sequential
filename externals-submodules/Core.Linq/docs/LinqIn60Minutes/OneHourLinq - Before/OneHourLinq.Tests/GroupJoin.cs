using System;
using NUnit.Framework;

// Change to OneHour.Linq to run real tests
using System.Linq;
//using OneHour.Linq;

namespace OneHourLinq.Tests
{
    [TestFixture]
    public class GroupJoin
    {
        [Test]
        public void QueryExpressionMatchingMultiples()
        {
            int[] numbers = new int[] { 6, 7, 8, 9, 10 };

            var results = new[]
            {
                new { Name = "Jon", Score = 8 },
                new { Name = "Holly", Score = 7 },
                new { Name = "Tom", Score = 8 },
                new { Name = "Will", Score = 9 },
                new { Name = "Robin", Score = 9 }
            };
            var query = from number in numbers
                        join result in results
                        on number equals result.Score into resultsForScore
                        select number + ": " + ", ".InsertBetween(resultsForScore.Select(result => result.Name));

            query.AssertSequenceEqual("6: ", "7: Holly", "8: Jon, Tom", "9: Will, Robin", "10: ");
        }

        [Test]
        public void MethodCallMatchingMultiples()
        {
            int[] numbers = new[] { 6, 7, 8, 9, 10 };

            var results = new[]
            {
                new { Name = "Jon", Score = 8 },
                new { Name = "Holly", Score = 7 },
                new { Name = "Tom", Score = 8 },
                new { Name = "Will", Score = 9 },
                new { Name = "Robin", Score = 9 }
            };

            var query = numbers.GroupJoin(results,
                                          number => number,
                                          result => result.Score,
                                          (number, resultsForScore) => number + ": " + 
                                              ", ".InsertBetween(resultsForScore.Select(result => result.Name)));


            query.AssertSequenceEqual("6: ", "7: Holly", "8: Jon, Tom", "9: Will, Robin", "10: ");
        }
    }
}
