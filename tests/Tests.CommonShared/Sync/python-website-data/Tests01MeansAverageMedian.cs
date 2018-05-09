// /*
//    Copyright (c) 2017-12
//
//    moljac
//    Test.cs
//
//    Permission is hereby granted, free of charge, to any person
//    obtaining a copy of this software and associated documentation
//    files (the "Software"), to deal in the Software without
//    restriction, including without limitation the rights to use,
//    copy, modify, merge, publish, distribute, sublicense, and/or sell
//    copies of the Software, and to permit persons to whom the
//    Software is furnished to do so, subject to the following
//    conditions:
//
//    The above copyright notice and this permission notice shall be
//    included in all copies or substantial portions of the Software.
//
//    THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
//    EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
//    OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
//    NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
//    HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
//    WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
//    FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
//    OTHER DEALINGS IN THE SOFTWARE.
// */
using System;

using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;
using System.Threading.Tasks;

#if XUNIT
using Xunit;
// NUnit aliases
using Test = Xunit.FactAttribute;
using OneTimeSetUp = HolisticWare.Core.Testing.UnitTestsCompatibilityAliasAttribute;
// XUnit aliases
using TestClass = HolisticWare.Core.Testing.UnitTestsCompatibilityAliasAttribute;
#elif NUNIT
using NUnit.Framework;
// MSTest aliases
using TestInitialize = NUnit.Framework.SetUpAttribute;
using TestProperty = NUnit.Framework.PropertyAttribute;
using TestClass = NUnit.Framework.TestFixtureAttribute;
using TestMethod = NUnit.Framework.TestAttribute;
using TestCleanup = NUnit.Framework.TearDownAttribute;
// XUnit aliases
using Fact=NUnit.Framework.TestAttribute;
#elif MSTEST
using Microsoft.VisualStudio.TestTools.UnitTesting;
// NUnit aliases
using Test = Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute;
using OneTimeSetUp = Microsoft.VisualStudio.TestTools.UnitTesting.ClassInitializeAttribute;
// XUnit aliases
using Fact = Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute;
#endif

using Core.Math.Statistics.Descriptive.Sequential;

namespace UnitTests.Core.Math.Statistics.Descriptive.Sequential.Sync
{
    public partial class UnitTestsPythonWebDocsStatistics
    {
        double mean_arithmetic;

        [Test]
        public void MeanArithmetic01()
        {
            //====================================================================================================
            // Arrange
            int[] data01 = new[] { 1, 2, 3, 4, 4 };

            sw = Stopwatch.StartNew();
            // Act
            mean_arithmetic = data01.MeanArithmetic();
            sw.Stop();
            Console.WriteLine($"int[].MeanArithmetic()");
            Console.WriteLine($"          average            = {mean_arithmetic}");
            Console.WriteLine($"          size               = {data01.Count()}");
            Console.WriteLine($"          elapsed[ticks]     = {sw.ElapsedTicks}");
            Console.WriteLine($"          elapsed[ms]        = {sw.Elapsed.TotalMilliseconds}");
            sw.Reset();

            // Assert
            #if NUNIT
            Assert.AreEqual(2.8, mean_arithmetic, 0.001);
            #elif XUNIT
            Assert.Equal(2.8, mean_arithmetic, 3);
            #elif MSTEST
            Assert.AreEqual(2.8, mean_arithmetic, 0.001);
            #endif
            //====================================================================================================

            return;
        }

        [Test]
        public void MeanArithmetic02()
        {
            //====================================================================================================
            // Arrange
            double[] data01 = new[] { -1.0, 2.5, 3.25, 5.75 };

            sw = Stopwatch.StartNew();
            // Act
            mean_arithmetic = data01.MeanArithmetic();
            sw.Stop();
            Console.WriteLine($"int[].MeanArithmetic()");
            Console.WriteLine($"          mean_arithmetic    = {mean_arithmetic}");
            Console.WriteLine($"          size               = {data01.Count()}");
            Console.WriteLine($"          elapsed[ticks]     = {sw.ElapsedTicks}");
            Console.WriteLine($"          elapsed[ms]        = {sw.Elapsed.TotalMilliseconds}");
            sw.Reset();

            // Assert
            #if NUNIT
            Assert.AreEqual(2.625, mean_arithmetic, 0.001);
            #elif XUNIT
            Assert.Equal(2.625, mean_arithmetic, 3);
            #elif MSTEST
            Assert.AreEqual(2.625, mean_arithmetic, 0.001);
            #endif
            //====================================================================================================

            return;
        }

        double mean_harmonic;

        [Test]
        public void MeanHarmonic()
        {
            //====================================================================================================
            // Arrange
            Stack<double> data01 = new Stack<double>(new[] { 2.5, 3, 10 });

            sw = Stopwatch.StartNew();
            // Act
            mean_harmonic = data01.MeanHarmonic();
            sw.Stop();
            Console.WriteLine($"int[].MeanHarmonic()");
            Console.WriteLine($"          mean_harmonic      = {mean_harmonic}");
            Console.WriteLine($"          size               = {data01.Count()}");
            Console.WriteLine($"          elapsed[ticks]     = {sw.ElapsedTicks}");
            Console.WriteLine($"          elapsed[ms]        = {sw.Elapsed.TotalMilliseconds}");
            sw.Reset();

            // Assert
            #if NUNIT
            Assert.AreEqual(3.6, mean_harmonic, 0.001);
            #elif XUNIT
            Assert.Equal(3.6, mean_harmonic, 3);
            #elif MSTEST
            Assert.AreEqual(3.6, mean_harmonic, 0.001);
            #endif
            //====================================================================================================

            return;
        }

        double median;

        [Test]
        public void Median01()
        {
            //====================================================================================================
            // Arrange
            Stack<int> data01 = new Stack<int>(new[] { 1, 3, 5 });

            sw = Stopwatch.StartNew();
            // Act
            median = data01.Median();
            sw.Stop();
            Console.WriteLine($"Stack<int>.Median()");
            Console.WriteLine($"          median             = {median}");
            Console.WriteLine($"          size               = {data01.Count()}");
            Console.WriteLine($"          elapsed[ticks]     = {sw.ElapsedTicks}");
            Console.WriteLine($"          elapsed[ms]        = {sw.Elapsed.TotalMilliseconds}");
            sw.Reset();

            // Assert
            #if NUNIT
            Assert.AreEqual(3, median, 0.001);
            #elif XUNIT
            Assert.Equal(3, median, 3);
            #elif MSTEST
            Assert.AreEqual(3, median, 0.001);
            #endif
            //====================================================================================================

            return;
        }

        [Test]
        public void Median02()
        {
            //====================================================================================================
            // Arrange
            Queue<int> data01 = new Queue<int>(new[] { 1, 3, 5, 7 });

            sw = Stopwatch.StartNew();
            // Act
            median = data01.Median();
            sw.Stop();
            Console.WriteLine($"Queue<int>.Median()");
            Console.WriteLine($"          median             = {median}");
            Console.WriteLine($"          size               = {data01.Count()}");
            Console.WriteLine($"          elapsed[ticks]     = {sw.ElapsedTicks}");
            Console.WriteLine($"          elapsed[ms]        = {sw.Elapsed.TotalMilliseconds}");
            sw.Reset();

            // Assert
            #if NUNIT
            Assert.AreEqual(4, median);
            #elif XUNIT
            Assert.Equal(4, median);
            #elif MSTEST
            Assert.AreEqual(4, median);
            #endif
            //====================================================================================================

            return;
        }

        [Test]
        public void MedianLow01()
        {
            //====================================================================================================
            // Arrange
            Queue<int> data01 = new Queue<int>(new[] { 1, 3, 5, 7 });

            sw = Stopwatch.StartNew();
            // Act
            median = data01.MedianLow();
            sw.Stop();
            Console.WriteLine($"Queue<int>.Median()");
            Console.WriteLine($"          median             = {median}");
            Console.WriteLine($"          size               = {data01.Count()}");
            Console.WriteLine($"          elapsed[ticks]     = {sw.ElapsedTicks}");
            Console.WriteLine($"          elapsed[ms]        = {sw.Elapsed.TotalMilliseconds}");
            sw.Reset();

            // Assert
            #if NUNIT
            Assert.AreEqual(3, median);
            #elif XUNIT
            Assert.Equal(3, median);
            #elif MSTEST
            Assert.AreEqual(3, median);
            #endif
            //====================================================================================================

            return;
        }

        [Test]
        public void MedianHigh01()
        {
            //====================================================================================================
            // Arrange
            Queue<int> data01 = new Queue<int>(new[] { 1, 3, 5, 7 });

            sw = Stopwatch.StartNew();
            // Act
            median = data01.MedianHigh();
            sw.Stop();
            Console.WriteLine($"Queue<int>.Median()");
            Console.WriteLine($"          median             = {median}");
            Console.WriteLine($"          size               = {data01.Count()}");
            Console.WriteLine($"          elapsed[ticks]     = {sw.ElapsedTicks}");
            Console.WriteLine($"          elapsed[ms]        = {sw.Elapsed.TotalMilliseconds}");
            sw.Reset();

            // Assert
            #if NUNIT
            Assert.AreEqual(5, median);
            #elif XUNIT
            Assert.Equal(5, median);
            #elif MSTEST
            Assert.AreEqual(5, median);
            #endif
            //====================================================================================================

            return;
        }

        [Test]
        public void MedianLow02()
        {
            //====================================================================================================
            // Arrange
            Queue<int> data01 = new Queue<int>(new[] { 1, 3, 5 });

            sw = Stopwatch.StartNew();
            // Act
            median = data01.MedianLow();
            sw.Stop();
            Console.WriteLine($"Queue<int>.Median()");
            Console.WriteLine($"          median             = {median}");
            Console.WriteLine($"          size               = {data01.Count()}");
            Console.WriteLine($"          elapsed[ticks]     = {sw.ElapsedTicks}");
            Console.WriteLine($"          elapsed[ms]        = {sw.Elapsed.TotalMilliseconds}");
            sw.Reset();

            // Assert
            #if NUNIT
            Assert.AreEqual(3, median);
            #elif XUNIT
            Assert.Equal(3, median);
            #elif MSTEST
            Assert.AreEqual(3, median);
            #endif
            //====================================================================================================

            return;
        }

        [Test]
        public void MedianHigh02()
        {
            //====================================================================================================
            // Arrange
            Queue<int> data01 = new Queue<int>(new[] { 1, 3, 5 });

            sw = Stopwatch.StartNew();
            // Act
            median = data01.MedianHigh();
            sw.Stop();
            Console.WriteLine($"Queue<int>.Median()");
            Console.WriteLine($"          median             = {median}");
            Console.WriteLine($"          size               = {data01.Count()}");
            Console.WriteLine($"          elapsed[ticks]     = {sw.ElapsedTicks}");
            Console.WriteLine($"          elapsed[ms]        = {sw.Elapsed.TotalMilliseconds}");
            sw.Reset();

            // Assert
            #if NUNIT
            Assert.AreEqual(3, median);
            #elif XUNIT
            Assert.Equal(3, median);
            #elif MSTEST
            Assert.AreEqual(3, median);
            #endif
            //====================================================================================================

            return;
        }

    }
}
