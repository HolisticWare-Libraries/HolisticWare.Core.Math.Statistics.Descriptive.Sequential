using System;
using NUnit.Framework;

// Change to OneHour.Linq to run real tests
//using System.Linq;
using OneHour.Linq;

namespace OneHourLinq.Tests
{
    [TestFixture]
    public class Join
    {
        [Test]
        public void SimpleQueryExpression()
        {
            int[] odds = { 1, 3, 5, 7, 9, 11, 13 };
            int[] primes = { 2, 3, 5, 7, 11, 13 };

            var query = from left in odds
                        join right in primes
                        on left equals right
                        select left;

            query.AssertSequenceEqual(3, 5, 7, 11, 13);
        }

        [Test]
        public void QueryExpressionWithComplicatedJoin()
        {
            int[] evens = new[] { 2, 4, 6, 8, 10, 12, 14 };
            string[] primes = new[] { "2", "3", "5", "7", "11", "13" };

            // Select all the even numbers (x) where x-1 is a prime
            var query = from left in evens
                        join right in primes
                        on left - 1 equals int.Parse(right)
                        select left.ToString()+"/"+right;

            query.AssertSequenceEqual("4/3", "6/5", "8/7", "12/11", "14/13");
        }

        [Test]
        public void SimpleJoinCall()
        {
            int[] odds = { 1, 3, 5, 7, 9, 11, 13 };
            int[] prime = { 2, 3, 5, 7, 11, 13 };

            var query = odds.Join(prime, // inner sequence
                                 left => left, // outer key selector
                                 right => right, // inner key selector
                                 (left, right) => left // result selector
                                 );
            query.AssertSequenceEqual(3, 5, 7, 11, 13);
        }

        [Test]
        public void ComplicatedJoinCall()
        {
            int[] evens = new[] { 2, 4, 6, 8, 10, 12, 14 };
            string[] primes = new[] { "2", "3", "5", "7", "11", "13" };

            // Select all the even numbers (x) where x-1 is a prime
            var query = evens.Join(primes,
                                  left => left-1,
                                  right => int.Parse(right),
                                  (left, right) => left.ToString()+"/"+right
                                 );

            query.AssertSequenceEqual("4/3", "6/5", "8/7", "12/11", "14/13");
        }

        [Test]
        public void JoinMatchingMultiples()
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

            var query = from number in numbers
                        join result in results
                        on number equals result.Score
                        select result.Score+": "+result.Name;

            query.AssertSequenceEqual("7: Holly", "8: Jon", "8: Tom", "9: Will", "9: Robin");
        }
    }
}
