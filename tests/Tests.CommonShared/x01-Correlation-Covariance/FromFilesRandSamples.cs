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

using Core.Math.Statistics.Descriptive.Sequential;

namespace UnitTests.Core.Math.Statistics.Descriptive.Sequential.Sync
{
    [TestClass] // for MSTest - NUnit [TestFixture] and XUnit not needed
    public partial class FromFilesRandSamples
    {
        Stopwatch sw = null;
        List<RandSamp1Data> data01 = null;
        List<double> data02 = null;

        [Test]
        public void Correlation_01_02()
        {
            //====================================================================================================
            //  Arrange
            //  reading data from files
            data01 = UnitTests20180318DataSetRand50Samp01.RandSamp1DataTable;
            data02 = UnitTests20180318DataSetRand50Samp02.Data;

            sw = Stopwatch.StartNew();

            //----------------------------------------------------------------------------------------------------
            // Act
            double correlation_data01_data02 = (data01.Select(i => i.rVAR1)).Correlation(data02);
            sw.Stop();
            Console.WriteLine($"List<double>.Correlation(List<double>)");
            Console.WriteLine($"          correlation        = {correlation_data01_data02}");
            Console.WriteLine($"          size               = {data01.Count()} x {data02.Count()}");
            Console.WriteLine($"          elapsed[ticks]     = {sw.ElapsedTicks}");
            Console.WriteLine($"          elapsed[ms]        = {sw.Elapsed.TotalMilliseconds}");
            sw.Reset();

            //----------------------------------------------------------------------------------------------------
            // Assert
            #if NUNIT
            Assert.AreEqual(0.1871, correlation_data01_data02, 0.0001);
            #elif XUNIT
            Assert.Equal(0.1871, (double)correlation_data01_data02, 4);
            #elif MSTEST
            Assert.AreEqual(0.1871, correlation_data01_data02, 0.0001);
            #endif
            //====================================================================================================

            return;
        }

        [Test]
        public void Correlation_02_01()
        {
            //====================================================================================================
            //  Arrange
            //  reading data from files
            data01 = UnitTests20180318DataSetRand50Samp01.RandSamp1DataTable;
            data02 = UnitTests20180318DataSetRand50Samp02.Data;

            sw = Stopwatch.StartNew();

            //----------------------------------------------------------------------------------------------------
            // Act
            double correlation_data02_data01 = data02.Correlation(data01.Select(i => i.rVAR1));
            sw.Stop();
            Console.WriteLine($"List<double>.Correlation(List<double>)");
            Console.WriteLine($"          correlation        = {correlation_data02_data01}");
            Console.WriteLine($"          size               = {data01.Count()} x {data02.Count()}");
            Console.WriteLine($"          elapsed[ticks]     = {sw.ElapsedTicks}");
            Console.WriteLine($"          elapsed[ms]        = {sw.Elapsed.TotalMilliseconds}");
            sw.Reset();

            //----------------------------------------------------------------------------------------------------
            // Act
            double correlation_data01_data02 = (data01.Select(i => i.rVAR1)).Correlation(data02);
            sw.Stop();
            Console.WriteLine($"List<double>.Correlation(List<double>)");
            Console.WriteLine($"          correlation        = {correlation_data02_data01}");
            Console.WriteLine($"          size               = {data01.Count()} x {data02.Count()}");
            Console.WriteLine($"          elapsed[ticks]     = {sw.ElapsedTicks}");
            Console.WriteLine($"          elapsed[ms]        = {sw.Elapsed.TotalMilliseconds}");
            sw.Reset();

            //----------------------------------------------------------------------------------------------------
            // Act
            double correlation_data01_data01_01 = (data01.Select(i => i.rVAR1)).Correlation((data01.Select(i => i.rVAR1)));
            sw.Stop();
            Console.WriteLine($"List<double>.Correlation(List<double>)");
            Console.WriteLine($"          correlation        = {correlation_data02_data01}");
            Console.WriteLine($"          size               = {data01.Count()} x {data02.Count()}");
            Console.WriteLine($"          elapsed[ticks]     = {sw.ElapsedTicks}");
            Console.WriteLine($"          elapsed[ms]        = {sw.Elapsed.TotalMilliseconds}");
            sw.Reset();
            //----------------------------------------------------------------------------------------------------
            // Assert
            #if NUNIT
            Assert.AreEqual(0.1871, correlation_data01_data02, 0.0001);
            #elif XUNIT
            Assert.Equal(0.1871, (double)correlation_data01_data02, 4);
            #elif MSTEST
            Assert.AreEqual(0.1871, correlation_data01_data02, 0.0001);
            #endif
            //====================================================================================================

            #if NUNIT
            Assert.AreEqual
                        (
                            correlation_data01_data02,
                            correlation_data02_data01,
                            0.00001
                        );
            #elif XUNIT
            Assert.Equal
                        (
                            correlation_data01_data02,
                            correlation_data02_data01,
                            5
                        );
            #elif MSTEST
            Assert.AreEqual
                        (
                            correlation_data01_data02,
                            correlation_data02_data01,
                            0.00001
                        );
            #endif

            return;
        }


        [Test]
        public void Correlation_01_01()
        {
            //====================================================================================================
            //  Arrange
            //  reading data from files
            data01 = UnitTests20180318DataSetRand50Samp01.RandSamp1DataTable;

            sw = Stopwatch.StartNew();

            //----------------------------------------------------------------------------------------------------
            // Act
            double correlation_data01_data01 = (data01.Select(i => i.rVAR1)).Correlation((data01.Select(i => i.rVAR1)));
            sw.Stop();
            Console.WriteLine($"List<double>.Correlation(List<double>)");
            Console.WriteLine($"          correlation        = {correlation_data01_data01}");
            Console.WriteLine($"          size               = {data01.Count()} x {data01.Count()}");
            Console.WriteLine($"          elapsed[ticks]     = {sw.ElapsedTicks}");
            Console.WriteLine($"          elapsed[ms]        = {sw.Elapsed.TotalMilliseconds}");
            sw.Reset();

            //----------------------------------------------------------------------------------------------------
            // Assert
            #if NUNIT
            Assert.AreEqual(1.0, correlation_data01_data01, 0.0001);
            #elif XUNIT
            Assert.Equal(1.0, correlation_data01_data01, 4);
            #elif MSTEST
            Assert.AreEqual(1.0, correlation_data01_data01, 0.0001);
            #endif
            //====================================================================================================

            return;
        }
    
        [Test]
        public void Correlation_02_02()
        {
            //====================================================================================================
            //  Arrange
            //  reading data from files
            data02 = UnitTests20180318DataSetRand50Samp02.Data;

            sw = Stopwatch.StartNew();

            //----------------------------------------------------------------------------------------------------
            // Act
            double correlation_data02_data02 = data02.Correlation(data02);
            sw.Stop();
            Console.WriteLine($"List<double>.Correlation(List<double>)");
            Console.WriteLine($"          correlation        = {correlation_data02_data02}");
            Console.WriteLine($"          size               = {data02.Count()} x {data02.Count()}");
            Console.WriteLine($"          elapsed[ticks]     = {sw.ElapsedTicks}");
            Console.WriteLine($"          elapsed[ms]        = {sw.Elapsed.TotalMilliseconds}");
            sw.Reset();

            //----------------------------------------------------------------------------------------------------
            // Assert
            #if NUNIT
            Assert.AreEqual(1.0, correlation_data02_data02, 0.0001);
            #elif XUNIT
            Assert.Equal(1.0, correlation_data02_data02, 4);
            #elif MSTEST
            Assert.AreEqual(1.0, correlation_data02_data02, 0.0001);
            #endif
            //====================================================================================================

            return;
        }
    }
}
