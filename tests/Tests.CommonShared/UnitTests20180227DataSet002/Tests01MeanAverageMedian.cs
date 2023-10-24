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
using System.Collections.ObjectModel;

using Core.Math.Statistics.Descriptive;

namespace UnitTests.Core.Math.Statistics.Descriptive.Sequential.Sync
{
    public partial class UnitTests20180227DataSet002
    {
        List<double> w_1 = null;

        double average = 0;
        double mean01 = 0;
        double mean02 = 0;

        [Test()]
        public void Average()
        {
            //====================================================================================================
            // Arrange

            sw = Stopwatch.StartNew();
            //----------------------------------------------------------------------------------------------------
            // Act
            average = data_list.Average();
            sw.Stop();
            Console.WriteLine($"List<int>.Average()");
            Console.WriteLine($"          average            = {average}");
            Console.WriteLine($"          size               = {data_list.Count()}");
            Console.WriteLine($"          elapsed[ticks]     = {sw.ElapsedTicks}");
            Console.WriteLine($"          elapsed[ms]        = {sw.Elapsed.TotalMilliseconds}");
            sw.Reset();

            //----------------------------------------------------------------------------------------------------
            // Assert
            #if NUNIT
            Assert.AreEqual(28.563, average, 0.001);
            #elif XUNIT
            Assert.Equal(28.5625, average, 4);
            #elif MSTEST
            #endif
            //====================================================================================================

            return;
        }

        [Test()]
        public void MeanArithmetic()
        {
            //====================================================================================================
            // Arrange

            sw = Stopwatch.StartNew();
            //----------------------------------------------------------------------------------------------------
            // Act
            mean01 = data_list.MeanArithmetic();
            sw.Stop();
            Console.WriteLine($"List<int>.MeanArithmetic()");
            Console.WriteLine($"          mean_arithmetic    = {mean01}");
            Console.WriteLine($"          size               = {data_list.Count()}");
            Console.WriteLine($"          elapsed[ticks]     = {sw.ElapsedTicks}");
            Console.WriteLine($"          elapsed[ms]        = {sw.Elapsed.TotalMilliseconds}");
            sw.Reset();

            //----------------------------------------------------------------------------------------------------
            // Assert
            #if NUNIT
            Assert.AreEqual(28.563, mean01, 0.001);
            #elif XUNIT
            Assert.Equal(28.562, mean01, 3);
            Assert.Equal(28.5625, mean01, 4);
            #elif MSTEST
            #endif
            //====================================================================================================

            return;
        }

        [Test()]
        public void MeanGeometric()
        {
            //====================================================================================================
            // Arrange

            sw = Stopwatch.StartNew();
            //----------------------------------------------------------------------------------------------------
            // Act
            mean01 = data_list.MeanGeometric();
            sw.Stop();
            Console.WriteLine($"List<int>.MeanArithmetic()");
            Console.WriteLine($"          mean_arithmetic    = {mean01}");
            Console.WriteLine($"          size               = {data_list.Count()}");
            Console.WriteLine($"          elapsed[ticks]     = {sw.ElapsedTicks}");
            Console.WriteLine($"          elapsed[ms]        = {sw.Elapsed.TotalMilliseconds}");
            sw.Reset();

            //----------------------------------------------------------------------------------------------------
            // Assert
            #if NUNIT
            Assert.AreEqual(28.209, mean01, 0.001);
            #elif XUNIT
            Assert.Equal(28.209, mean01, 3);
            #elif MSTEST
            #endif
            //====================================================================================================

            return;
        }

        [Test()]
        public void MeanHarmonic()
        {
            //====================================================================================================
            // Arrange

            sw = Stopwatch.StartNew();
            //----------------------------------------------------------------------------------------------------
            // Act
            mean01 = data_list.MeanHarmonic();
            sw.Stop();
            Console.WriteLine($"List<int>.MeanHarmonic()");
            Console.WriteLine($"          mean_harmonic      = {mean01}");
            Console.WriteLine($"          size               = {data_list.Count()}");
            Console.WriteLine($"          elapsed[ticks]     = {sw.ElapsedTicks}");
            Console.WriteLine($"          elapsed[ms]        = {sw.Elapsed.TotalMilliseconds}");
            sw.Reset();

            //----------------------------------------------------------------------------------------------------
            // Assert
            #if NUNIT
            Assert.AreEqual(27.851, mean01, 0.001);
            #elif XUNIT
            Assert.Equal(27.851, mean01, 3);
            #elif MSTEST
            #endif
            //====================================================================================================

            return;
        }

        [Test()]
        public void MeanQuadratic()
        {
            //====================================================================================================
            // Arrange

            sw = Stopwatch.StartNew();
            //----------------------------------------------------------------------------------------------------
            // Act
            mean01 = data_list.MeanQuadratic();
            sw.Stop();
            Console.WriteLine($"List<int>.MeanQuadratic()");
            Console.WriteLine($"          mean_quadratic     = {mean01}");
            Console.WriteLine($"          size               = {data_list.Count()}");
            Console.WriteLine($"          elapsed[ticks]     = {sw.ElapsedTicks}");
            Console.WriteLine($"          elapsed[ms]        = {sw.Elapsed.TotalMilliseconds}");
            sw.Reset();

            //----------------------------------------------------------------------------------------------------
            // Assert
            #if NUNIT
            Assert.AreEqual(28.908, mean01, 0.001);
            #elif XUNIT
            Assert.Equal(28.908, mean01, 3);
            #elif MSTEST
            #endif
            //====================================================================================================

            return;
        }

        [Test()]
        public void MeanCubic()
        {
            //====================================================================================================
            // Arrange
            data_list = new List<int> { 22, 24, 33, 25, 36, 27, 34, 24, 32, 21, 28, 29, 30, 35, 29, 28 };

            sw = Stopwatch.StartNew();
            //----------------------------------------------------------------------------------------------------
            // Act
            mean01 = data_list.MeanCubic();
            sw.Stop();
            Console.WriteLine($"List<int>.MeanCubic()");
            Console.WriteLine($"          mean_cubic         = {mean01}");
            Console.WriteLine($"          size               = {data_list.Count()}");
            Console.WriteLine($"          elapsed[ticks]     = {sw.ElapsedTicks}");
            Console.WriteLine($"          elapsed[ms]        = {sw.Elapsed.TotalMilliseconds}");
            sw.Reset();

            //----------------------------------------------------------------------------------------------------
            // Assert
            #if NUNIT
            Assert.AreEqual(29.242, mean01, 0.001);
            #elif XUNIT
            Assert.Equal(29.242, mean01, 3);
            #elif MSTEST
            #endif
            //====================================================================================================

            return;
        }

        [Test()]
        public void MeanGeneralized()
        {
            //====================================================================================================
            // Arrange
            data_list = new List<int> { 22, 24, 33, 25, 36, 27, 34, 24, 32, 21, 28, 29, 30, 35, 29, 28 };

            sw = Stopwatch.StartNew();
            //----------------------------------------------------------------------------------------------------
            // Act
            mean01 = data_list.MeanGeneralized(2.0);
            mean02 = data_list.MeanGeneralized(3.0);
            sw.Stop();
            Console.WriteLine($"List<int>.MeanGeneralized()");
            Console.WriteLine($"          mean_generalized(2.0) = {mean01}");
            Console.WriteLine($"          mean_generalized(3.0) = {mean02}");
            Console.WriteLine($"          size                  = {data_list.Count()}");
            Console.WriteLine($"          elapsed[ticks]        = {sw.ElapsedTicks}");
            Console.WriteLine($"          elapsed[ms]           = {sw.Elapsed.TotalMilliseconds}");
            sw.Reset();

            //----------------------------------------------------------------------------------------------------
            // Assert
            #if NUNIT
            Assert.AreEqual(28.908, mean01, 0.001);
            Assert.AreEqual(29.242, mean02, 0.001);
            #elif XUNIT
            Assert.Equal(28.908, mean01, 3);
            Assert.Equal(29.242, mean02, 3);
            #elif MSTEST
            #endif
            //====================================================================================================

            return;
        }

        [Test()]
        public void MeanWeighted()
        {
            //  http://elsenaju.eu/Calculator/mean-value-calculator.htm
            //  https://ncalculators.com/statistics/weighted-mean-calculator.htm

            //====================================================================================================
            // Arrange
            data_list = new List<int> 
                    { 22, 24, 33, 25, 36, 27, 34, 24, 32, 21, 28, 29, 30, 35, 29, 28 };
            w1 = new List<double>()
                    { 11, 14, 13, 14, 14, 14, 15, 13, 12, 11, 15, 16, 12, 18, 18, 11 };

            sw = Stopwatch.StartNew();
            //----------------------------------------------------------------------------------------------------
            // Act
            mean01 = data_list.MeanWeighted(w1);
            sw.Stop();
            Console.WriteLine($"List<int>.MeanWeighted(weights)");
            Console.WriteLine($"          mean_weighted      = {mean01}");
            Console.WriteLine($"          size               = {data_list.Count()}");
            Console.WriteLine($"          elapsed[ticks]     = {sw.ElapsedTicks}");
            Console.WriteLine($"          elapsed[ms]        = {sw.Elapsed.TotalMilliseconds}");
            sw.Reset();

            //----------------------------------------------------------------------------------------------------
            // Assert
            #if NUNIT
            Assert.AreEqual(28.8688, mean01, 0.0001);
            #elif XUNIT
            Assert.Equal(28.8688, mean01, 4);
            #elif MSTEST
            #endif
            //====================================================================================================

            return;
        }

    }
}
