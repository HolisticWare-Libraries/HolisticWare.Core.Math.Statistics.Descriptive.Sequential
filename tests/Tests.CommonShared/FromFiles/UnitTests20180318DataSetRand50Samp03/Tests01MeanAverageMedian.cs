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

#if XUNIT
using Xunit;
// NUnit aliases
using Test = Xunit.FactAttribute;
using OneTimeSetUp = HolisticWare.Core.Testing.UnitTests.UnitTestsCompatibilityAliasAttribute;
// XUnit aliases
using TestClass = HolisticWare.Core.Testing.UnitTests.UnitTestsCompatibilityAliasAttribute;
using TestContext = HolisticWare.Core.Testing.UnitTests.TestContext;
#elif NUNIT
using NUnit.Framework;
// MSTest aliases
using TestInitialize = NUnit.Framework.SetUpAttribute;
using TestProperty = NUnit.Framework.PropertyAttribute;
using TestClass = HolisticWare.Core.Testing.UnitTests.UnitTestsCompatibilityAliasAttribute;
using TestMethod = NUnit.Framework.TestAttribute;
using TestCleanup = NUnit.Framework.TearDownAttribute;
// XUnit aliases
using Fact = NUnit.Framework.TestAttribute;
#elif MSTEST
using Microsoft.VisualStudio.TestTools.UnitTesting;
// NUnit aliases
using Test = Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute;
using OneTimeSetUp = Microsoft.VisualStudio.TestTools.UnitTesting.ClassInitializeAttribute;
// XUnit aliases
using Fact = Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute;
#endif

#if BENCHMARKDOTNET
using BenchmarkDotNet.Running;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Attributes.Jobs;
#else
using Benchmark = HolisticWare.Core.Testing.BenchmarkTests.Benchmark;
using ShortRunJob = HolisticWare.Core.Testing.BenchmarkTests.ShortRunJob;
#endif

using System;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;
using System.Threading.Tasks;
using System.IO;
using System.Reflection;

using Core.Math.Statistics.Descriptive.Sequential;

namespace UnitTests.Core.Math.Statistics.Descriptive.Sequential.Sync
{
    public partial class UnitTests20180318DataSetRand50Samp03
    {
        
        [Test]
        public void MeanArithmetic()
        {
            //====================================================================================================
            //  Arrange
            //  reading data from files

            sw = Stopwatch.StartNew();

            //----------------------------------------------------------------------------------------------------
            // Act
            double mean_arithmetic = Data.MeanArithmetic();
            sw.Stop();
            Console.WriteLine($"List<double>.MeanArithmetic()");
            Console.WriteLine($"          mean_arithmetic    = {mean_arithmetic}");
            Console.WriteLine($"          size               = {Data.Count()}");
            Console.WriteLine($"          elapsed[ticks]     = {sw.ElapsedTicks}");
            Console.WriteLine($"          elapsed[ms]        = {sw.Elapsed.TotalMilliseconds}");
            sw.Reset();
            //----------------------------------------------------------------------------------------------------
            // Assert
            #if NUNIT
            Assert.AreEqual(181.0688, mean_arithmetic, 0.00001);
            #elif XUNIT
            Assert.Equal(181.0688, mean_arithmetic, 5);
            #elif MSTEST
            Assert.AreEqual(181.0688, mean_arithmetic, 0.00001);
            #endif
            //====================================================================================================

            return;
        }

        [Test]
        public void MeanGeometric()
        {
            //====================================================================================================
            //  Arrange
            //  reading data from files

            sw = Stopwatch.StartNew();

            //----------------------------------------------------------------------------------------------------
            // Act
            double mean_geometric = Data.MeanGeometric();
            sw.Stop();
            Console.WriteLine($"List<double>.MeanGeometric()");
            Console.WriteLine($"          mean_geometric     = {mean_geometric}");
            Console.WriteLine($"          size               = {Data.Count()}");
            Console.WriteLine($"          elapsed[ticks]     = {sw.ElapsedTicks}");
            Console.WriteLine($"          elapsed[ms]        = {sw.Elapsed.TotalMilliseconds}");
            sw.Reset();

            //----------------------------------------------------------------------------------------------------
            // Assert
            #if NUNIT
            Assert.That(!Double.IsInfinity(mean_geometric));
            Assert.AreEqual(180.2062, mean_geometric, 0.0001);
            #elif XUNIT
            Assert.True(!Double.IsInfinity(mean_geometric));
            Assert.Equal(180.2062, mean_geometric, 4);
            #elif MSTEST
            Assert.AreEqual(180.2062, mean_geometric, 0.0001);
            #endif
            //====================================================================================================

            return;
        }

        [Test]
        public void MeanGeometric_Exception()
        {
            #if NUNIT
            // System.OverflowException : Arithmetic operation resulted in an overflow.
            Assert.Throws<System.OverflowException>
                    (
                        () =>
                        {
                            // TODO: System.InvalidCastException : Specified cast is not valid.
                            decimal mean_deomatric_decimal = (Data.Select(x_i => (decimal)x_i)).MeanGeometric();
                        }
                    );
            #elif XUNIT
            // System.OverflowException : Arithmetic operation resulted in an overflow.
            Assert.Throws<System.OverflowException>
                    (
                        () =>
                        {
                            // TODO: System.InvalidCastException : Specified cast is not valid.
                            decimal mean_deomatric_decimal = (Data.Select(x_i => (decimal)x_i)).MeanGeometric();
                        }
                    );
            #elif MSTEST
            #endif

            return;
        }

        [Test]
        public void MeanHarmonic()
        {
            //====================================================================================================
            //  Arrange
            //  reading data from files

            sw = Stopwatch.StartNew();

            //----------------------------------------------------------------------------------------------------
            // Act
            double mean = Data.MeanHarmonic();
            sw.Stop();
            Console.WriteLine($"List<double>.MeanHarmonic()");
            Console.WriteLine($"          mean               = {mean}");
            Console.WriteLine($"          size               = {Data.Count()}");
            Console.WriteLine($"          elapsed[ticks]     = {sw.ElapsedTicks}");
            Console.WriteLine($"          elapsed[ms]        = {sw.Elapsed.TotalMilliseconds}");
            sw.Reset();

            //----------------------------------------------------------------------------------------------------
            // Assert
            #if NUNIT
            Assert.AreEqual(179.3341, mean, 0.0001);
            #elif XUNIT
            Assert.Equal(179.3341, mean, 4);
            #elif MSTEST
            Assert.AreEqual(179.3341, mean, 0.0001);
            #endif
            //====================================================================================================

            return;
        }


        [Test]
        public void MeanQuadratic()
        {
            //====================================================================================================
            //  Arrange
            //  reading data from files

            sw = Stopwatch.StartNew();

            //----------------------------------------------------------------------------------------------------
            // Act
            double mean = Data.MeanQuadratic();
            sw.Stop();
            Console.WriteLine($"List<double>.MeanQuadratic()");
            Console.WriteLine($"          mean               = {mean}");
            Console.WriteLine($"          size               = {Data.Count()}");
            Console.WriteLine($"          elapsed[ticks]     = {sw.ElapsedTicks}");
            Console.WriteLine($"          elapsed[ms]        = {sw.Elapsed.TotalMilliseconds}");
            sw.Reset();

            //----------------------------------------------------------------------------------------------------
            // Assert
            #if NUNIT
            Assert.AreEqual(181.9181, mean, 0.0001);
            #elif XUNIT
            Assert.Equal(181.9181, mean, 4);
            #elif MSTEST
            Assert.AreEqual(181.9181, mean, 0.0001);
            #endif
            //====================================================================================================

            return;
        }

        [Test]
        public void MeanCubic()
        {
            //====================================================================================================
            //  Arrange
            //  reading data from files

            sw = Stopwatch.StartNew();

            //----------------------------------------------------------------------------------------------------
            // Act
            double mean = Data.MeanCubic();
            sw.Stop();
            Console.WriteLine($"List<double>.MeanCubic()");
            Console.WriteLine($"          mean               = {mean}");
            Console.WriteLine($"          size               = {Data.Count()}");
            Console.WriteLine($"          elapsed[ticks]     = {sw.ElapsedTicks}");
            Console.WriteLine($"          elapsed[ms]        = {sw.Elapsed.TotalMilliseconds}");
            sw.Reset();

            //----------------------------------------------------------------------------------------------------
            // Assert
            #if NUNIT
            Assert.AreEqual(182.7508, mean, 0.0001);
            #elif XUNIT
            Assert.Equal(182.7508, mean, 4);
            #elif MSTEST
            Assert.AreEqual(182.7508, mean, 0.0001);
            #endif
            //====================================================================================================

            return;
        }

        [Test]
        public void Median()
        {
            //====================================================================================================
            //  Arrange
            //  reading data from files

            sw = Stopwatch.StartNew();

            //----------------------------------------------------------------------------------------------------
            // Act
            double median = Data.Median();
            sw.Stop();
            Console.WriteLine($"List<double>.Median()");
            Console.WriteLine($"          median             = {median}");
            Console.WriteLine($"          size               = {Data.Count()}");
            Console.WriteLine($"          elapsed[ticks]     = {sw.ElapsedTicks}");
            Console.WriteLine($"          elapsed[ms]        = {sw.Elapsed.TotalMilliseconds}");
            sw.Reset();

            //----------------------------------------------------------------------------------------------------
            // Assert
            #if NUNIT
            Assert.AreEqual(182.525, median, 0.0001);
            #elif XUNIT
            Assert.Equal(182.525, median, 4);
            #elif MSTEST
            Assert.AreEqual(182.525, median, 0.0001);
            #endif
            //====================================================================================================

            return;
        }

        [Test]
        public void MedianLow()
        {
            //====================================================================================================
            //  Arrange
            //  reading data from files

            sw = Stopwatch.StartNew();

            //----------------------------------------------------------------------------------------------------
            // Act
            double median = Data.MedianLow();
            sw.Stop();
            Console.WriteLine($"List<double>.MedianLow()");
            Console.WriteLine($"          median             = {median}");
            Console.WriteLine($"          size               = {Data.Count()}");
            Console.WriteLine($"          elapsed[ticks]     = {sw.ElapsedTicks}");
            Console.WriteLine($"          elapsed[ms]        = {sw.Elapsed.TotalMilliseconds}");
            sw.Reset();

            //----------------------------------------------------------------------------------------------------
            // Assert
            #if NUNIT
            Assert.AreEqual(181.82, median, 0.0001);
            #elif XUNIT
            Assert.Equal(181.82, median, 4);
            #elif MSTEST
            Assert.AreEqual(181.82, median, 0.0001);
            #endif
            //====================================================================================================

            return;
        }

        [Test]
        public void MedianHigh()
        {
            //====================================================================================================
            //  Arrange
            //  reading data from files

            sw = Stopwatch.StartNew();

            //----------------------------------------------------------------------------------------------------
            // Act
            double median = Data.MedianHigh();
            sw.Stop();
            Console.WriteLine($"List<double>.MedianHigh()");
            Console.WriteLine($"          median             = {median}");
            Console.WriteLine($"          size               = {Data.Count()}");
            Console.WriteLine($"          elapsed[ticks]     = {sw.ElapsedTicks}");
            Console.WriteLine($"          elapsed[ms]        = {sw.Elapsed.TotalMilliseconds}");
            sw.Reset();

            //----------------------------------------------------------------------------------------------------
            // Assert
            // Assert
            #if NUNIT
            Assert.AreEqual(183.23, median, 0.0001);
            #elif XUNIT
            Assert.Equal(183.23, median, 4);
            #elif MSTEST
            Assert.AreEqual(183.23, median, 0.0001);
            #endif
            //====================================================================================================

            return;
        }
    }
}
