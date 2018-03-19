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
using Test = Xunit.FactAttribute;
#elif NUNIT
using NUnit.Framework;
using Fact=NUnit.Framework.TestAttribute;
#elif MSTEST
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Test = Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute;
using Fact = Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute;
using OneTimeSetUp = Microsoft.VisualStudio.TestTools.UnitTesting.ClassInitializeAttribute;
#endif

using Core.Math.Statistics.Descriptive.Sequential;

namespace UnitTests.Core.Math.Statistics.Descriptive.Sequential.Sync
{
    public partial class UnitTests20180227DataSet002
    {
        double average = 0;
        double mean01 = 0;
        double mean02 = 0;

        List<double> weights = null;

        [Test()]
        public void Average()
        {
            //====================================================================================================
            // Arrange
            data01 = new List<int> { 22, 24, 33, 25, 36, 27, 34, 24, 32, 21, 28, 29, 30, 35, 29, 28 };

            sw = Stopwatch.StartNew();
            //----------------------------------------------------------------------------------------------------
            // Act
            average = data01.Average();
            sw.Stop();
            Console.WriteLine($"List<int>.Average()");
            Console.WriteLine($"          average            = {average}");
            Console.WriteLine($"          size               = {data01.Count()}");
            Console.WriteLine($"          elapsed[ticks]     = {sw.ElapsedTicks}");
            Console.WriteLine($"          elapsed[ms]        = {sw.Elapsed.TotalMilliseconds}");
            sw.Reset();

            //----------------------------------------------------------------------------------------------------
            // Assert
            #if NUNIT
            Assert.AreEqual(28.563, average, 0.001);
            #elif XUNIT
            Assert.Equal(28.563, average, 3);
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
            data01 = new List<int> { 22, 24, 33, 25, 36, 27, 34, 24, 32, 21, 28, 29, 30, 35, 29, 28 };

            sw = Stopwatch.StartNew();
            //----------------------------------------------------------------------------------------------------
            // Act
            mean01 = data01.MeanArithmetic();
            sw.Stop();
            Console.WriteLine($"List<int>.MeanArithmetic()");
            Console.WriteLine($"          mean_arithmetic    = {mean01}");
            Console.WriteLine($"          size               = {data01.Count()}");
            Console.WriteLine($"          elapsed[ticks]     = {sw.ElapsedTicks}");
            Console.WriteLine($"          elapsed[ms]        = {sw.Elapsed.TotalMilliseconds}");
            sw.Reset();

            //----------------------------------------------------------------------------------------------------
            // Assert
            #if NUNIT
            Assert.AreEqual(28.563, mean01, 0.001);
            #elif XUNIT
            Assert.Equal(28.563, mean01, 3);
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
            data01 = new List<int> { 22, 24, 33, 25, 36, 27, 34, 24, 32, 21, 28, 29, 30, 35, 29, 28 };

            sw = Stopwatch.StartNew();
            //----------------------------------------------------------------------------------------------------
            // Act
            mean01 = data01.MeanGeometric();
            sw.Stop();
            Console.WriteLine($"List<int>.MeanArithmetic()");
            Console.WriteLine($"          mean_arithmetic    = {mean01}");
            Console.WriteLine($"          size               = {data01.Count()}");
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
            data01 = new List<int> { 22, 24, 33, 25, 36, 27, 34, 24, 32, 21, 28, 29, 30, 35, 29, 28 };

            sw = Stopwatch.StartNew();
            //----------------------------------------------------------------------------------------------------
            // Act
            mean01 = data01.MeanHarmonic();
            sw.Stop();
            Console.WriteLine($"List<int>.MeanHarmonic()");
            Console.WriteLine($"          mean_harmonic      = {mean01}");
            Console.WriteLine($"          size               = {data01.Count()}");
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
            data01 = new List<int> { 22, 24, 33, 25, 36, 27, 34, 24, 32, 21, 28, 29, 30, 35, 29, 28 };

            sw = Stopwatch.StartNew();
            //----------------------------------------------------------------------------------------------------
            // Act
            mean01 = data01.MeanQuadratic();
            sw.Stop();
            Console.WriteLine($"List<int>.MeanQuadratic()");
            Console.WriteLine($"          mean_quadratic     = {mean01}");
            Console.WriteLine($"          size               = {data01.Count()}");
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
            data01 = new List<int> { 22, 24, 33, 25, 36, 27, 34, 24, 32, 21, 28, 29, 30, 35, 29, 28 };

            sw = Stopwatch.StartNew();
            //----------------------------------------------------------------------------------------------------
            // Act
            mean01 = data01.MeanCubic();
            sw.Stop();
            Console.WriteLine($"List<int>.MeanCubic()");
            Console.WriteLine($"          mean_cubic         = {mean01}");
            Console.WriteLine($"          size               = {data01.Count()}");
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
            data01 = new List<int> { 22, 24, 33, 25, 36, 27, 34, 24, 32, 21, 28, 29, 30, 35, 29, 28 };

            sw = Stopwatch.StartNew();
            //----------------------------------------------------------------------------------------------------
            // Act
            mean01 = data01.MeanGeneralized(2.0);
            mean02 = data01.MeanGeneralized(3.0);
            sw.Stop();
            Console.WriteLine($"List<int>.MeanGeneralized()");
            Console.WriteLine($"          mean_generalized(2.0) = {mean01}");
            Console.WriteLine($"          mean_generalized(3.0) = {mean02}");
            Console.WriteLine($"          size                  = {data01.Count()}");
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
            data01 = new List<int> 
                    { 22, 24, 33, 25, 36, 27, 34, 24, 32, 21, 28, 29, 30, 35, 29, 28 };
            weights = new List<double>()
                    { 11, 14, 13, 14, 14, 14, 15, 13, 12, 11, 15, 16, 12, 18, 18, 11 };

            sw = Stopwatch.StartNew();
            //----------------------------------------------------------------------------------------------------
            // Act
            mean01 = data01.MeanWeighted(weights);
            sw.Stop();
            Console.WriteLine($"List<int>.MeanWeighted(weights)");
            Console.WriteLine($"          mean_weighted      = {mean01}");
            Console.WriteLine($"          size               = {data01.Count()}");
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
