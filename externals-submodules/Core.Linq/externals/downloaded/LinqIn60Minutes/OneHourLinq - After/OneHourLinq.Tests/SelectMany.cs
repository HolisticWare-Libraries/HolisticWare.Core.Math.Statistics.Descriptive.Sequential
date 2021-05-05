using System;
using NUnit.Framework;

// Change to OneHour.Linq to run real tests
//using System.Linq;
using OneHour.Linq;

namespace OneHourLinq.Tests
{
    [TestFixture]
    public class SelectMany
    {
        [Test]
        public void QueryExpression()
        {
            // Cartesian join
            var numbers = new[] { 1, 2, 3 };
            var letters = new[] { 'a', 'b', 'c' };

            var query = from number in numbers
                        from letter in letters
                        select number.ToString() + letter;

            query.AssertSequenceEqual("1a", "1b", "1c", "2a", "2b", "2c", "3a", "3b", "3c");
        }

        [Test]
        public void CartesianJoin()
        {
            var numbers = new[] { 1, 2, 3 };
            var letters = new[] { 'a', 'b', 'c' };

            var query = numbers.SelectMany(x => letters,
                                           (number, letter) => number.ToString() + letter);

            query.AssertSequenceEqual("1a", "1b", "1c", "2a", "2b", "2c", "3a", "3b", "3c");
        }

        [Test]
        public void NestedDependsOnOriginal()
        {
            var files = new string[] { "test.txt", "names.txt" };
            //var query = files.SelectMany(file => new LineReader(file), 
            //    (file, line) => file + ": " + line);

            var query = from file in files
                        from line in new LineReader(file)
                        select file + ": " + line;

            query.AssertSequenceEqual(
                "test.txt: first line",
                "test.txt: second line",
                "test.txt: third line",
                "names.txt: Jeff",
                "names.txt: Joel");
        }

        /*
         Real-world example
         from file in Directory.GetFiles("*.log")
         from line in new LineReader(file)
         select file+": "+line;
         
         a.log: foo, bar
         b.log: blither, wibble
         
         =>
         
         a.log: foo
         a.log: bar
         b.log: blither
         b.log: wibble
         
          
         */
    }
}
