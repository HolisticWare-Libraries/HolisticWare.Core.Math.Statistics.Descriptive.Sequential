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
using OneTimeSetUp = HolisticWare.Core.Testing.UnitTests.UnitTestsCompatibilityAliasAttribute;
// XUnit aliases
using TestClass = HolisticWare.Core.Testing.UnitTests.UnitTestsCompatibilityAliasAttribute;
#elif NUNIT
using NUnit.Framework;
// MSTest aliases
using TestInitialize = NUnit.Framework.SetUpAttribute;
using TestProperty = NUnit.Framework.PropertyAttribute;
using TestClass = HolisticWare.Core.Testing.UnitTests.UnitTestsCompatibilityAliasAttribute;
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

namespace UnitTests.Core.Math.Statistics.Descriptive.Sequential.Sync {
    public partial class UnitTests20180330RandSampBig1Items100000 {
        [Test]
        public void StandardDeviationSample() 
        {
            //====================================================================================================
            //  Arrange
            //  reading data from files

            sw = Stopwatch.StartNew();

            //----------------------------------------------------------------------------------------------------
            // Act

            double standard_deviation_s = Data.StandardDeviationSample();

            sw.Stop();
            Console.WriteLine($"List<double>.StandardDeviationSample()");
            Console.WriteLine($"          standard_deviation = {standard_deviation_s}");
            Console.WriteLine($"          size               = {Data.Count()}");
            Console.WriteLine($"          elapsed[ticks]     = {sw.ElapsedTicks}");
            Console.WriteLine($"          elapsed[ms]        = {sw.Elapsed.TotalMilliseconds}");
            sw.Reset();

            //----------------------------------------------------------------------------------------------------
            // Assert
            #if NUNIT
            Assert.AreEqual(standard_deviation_s, 16.86001, 0.00001);
            #elif XUNIT
            Assert.Equal(16.86001, standard_deviation_s, 5);
            #elif MSTEST
            Assert.AreEqual(standard_deviation_s, 16.86001, 0.00001);
            #endif
            //====================================================================================================

            return;
        }

        [Test]
        public void StandardDeviationPopulation() 
        {
            //====================================================================================================
            //  Arrange
            //  reading data from files

            sw = Stopwatch.StartNew();

            //----------------------------------------------------------------------------------------------------
            // Act
            double standard_deviation_p = Data.StandardDeviationPopulation();

            sw.Stop();
            Console.WriteLine($"List<double>.StandardDeviationPopulation()");
            Console.WriteLine($"          standard_deviation = {standard_deviation_p}");
            Console.WriteLine($"          size               = {Data.Count()}");
            Console.WriteLine($"          elapsed[ticks]     = {sw.ElapsedTicks}");
            Console.WriteLine($"          elapsed[ms]        = {sw.Elapsed.TotalMilliseconds}");
            sw.Reset();

            //----------------------------------------------------------------------------------------------------
            // Assert
            #if NUNIT
            Assert.AreEqual(standard_deviation_p, 16.85992, 0.00001);
            #elif XUNIT
            Assert.Equal(16.85992, standard_deviation_p, 5);
            #elif MSTEST
            Assert.AreEqual(standard_deviation_p, 16.85992, 0.00001);
            #endif
            //====================================================================================================

            return;
        }

        [Test]
        public void VarianceSample() 
        {
            //====================================================================================================
            //  Arrange
            //  reading data from files

            sw = Stopwatch.StartNew();

            //----------------------------------------------------------------------------------------------------
            // Act
            double variance_s = Data.VarianceSample();

            sw.Stop();
            Console.WriteLine($"List<double>.VarianceSample()");
            Console.WriteLine($"          variance           = {variance_s}");
            Console.WriteLine($"          size               = {Data.Count()}");
            Console.WriteLine($"          elapsed[ticks]     = {sw.ElapsedTicks}");
            Console.WriteLine($"          elapsed[ms]        = {sw.Elapsed.TotalMilliseconds}");
            sw.Reset();

            //----------------------------------------------------------------------------------------------------
            // Assert
            #if NUNIT
            Assert.AreEqual(variance_s, 284.2599, 0.0001);
            #elif XUNIT
            Assert.Equal(284.2599, variance_s, 4);
            #elif MSTEST
            Assert.AreEqual(variance_s, 284.2599, 0.0001);
            #endif
            //====================================================================================================

            return;
        }

        [Test]
        public void VariancePopulation() 
        {
            //====================================================================================================
            //  Arrange
            //  reading data from files

            sw = Stopwatch.StartNew();

            //----------------------------------------------------------------------------------------------------
            // Act
            double variance_p = Data.VariancePopulation();

            sw.Stop();
            Console.WriteLine($"List<double>.VariancePopulation()");
            Console.WriteLine($"          variance           = {variance_p}");
            Console.WriteLine($"          size               = {Data.Count()}");
            Console.WriteLine($"          elapsed[ticks]     = {sw.ElapsedTicks}");
            Console.WriteLine($"          elapsed[ms]        = {sw.Elapsed.TotalMilliseconds}");
            sw.Reset();

            //----------------------------------------------------------------------------------------------------
            // Assert
            #if NUNIT
            Assert.AreEqual(variance_p, 284.2570, 0.0001);
            #elif XUNIT
            Assert.Equal(284.2570, variance_p, 4);
            #elif MSTEST
            Assert.AreEqual(variance_p, 284.2570, 0.0001);
            #endif
            //====================================================================================================

            return;
        }
    }
}
