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
using NUnit.Framework;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;

using Core.Math.Statistics.Descriptive.Sequential;

namespace UnitTests.Core.Math.Statistics.Descriptive.Sequential.Sync
{
    public partial class UnitTests20180227DataSet001
    {
        List<int> data01 = null;

        double average = 0;
        double mean01 = 0;
        double mean02 = 0;
        double median01 = 0;

        List<double> weights = null;

        Stopwatch sw = null;

        [Test()]
        public void Average()
        {
            //====================================================================================================
            // Arrange
            data01 = new List<int> { 2, 4, 3, 5, 6, 7, 4, 4, 2, 1 };

            sw = Stopwatch.StartNew();
            //----------------------------------------------------------------------------------------------------
            // Act
            average = data01.Average();
            sw.Stop();
            Console.WriteLine($"List<int>.Average()");
            Console.WriteLine($"          average            = {average}");
            Console.WriteLine($"          size               = {data01.Count}");
            Console.WriteLine($"          elapsed[ticks]     = {sw.ElapsedTicks}");
            Console.WriteLine($"          elapsed[ms]        = {sw.Elapsed.TotalMilliseconds}");
            sw.Reset();

            //----------------------------------------------------------------------------------------------------
            // Assert
            Assert.AreEqual(3.8, average, 0.1);
            //====================================================================================================

            return;
        }

        [Test()]
        public void MeanArithmetic()
        {
            //====================================================================================================
            // Arrange
            data01 = new List<int> { 2, 4, 3, 5, 6, 7, 4, 4, 2, 1 };

            sw = Stopwatch.StartNew();
            //----------------------------------------------------------------------------------------------------
            // Act
            mean01 = data01.MeanArithmetic();
            sw.Stop();
            Console.WriteLine($"List<int>.MeanArithmetic()");
            Console.WriteLine($"          mean_arithmetic    = {mean01}");
            Console.WriteLine($"          size               = {data01.Count}");
            Console.WriteLine($"          elapsed[ticks]     = {sw.ElapsedTicks}");
            Console.WriteLine($"          elapsed[ms]        = {sw.Elapsed.TotalMilliseconds}");
            sw.Reset();

            //----------------------------------------------------------------------------------------------------
            // Assert
            Assert.AreEqual(3.8, mean01, 0.1);
            //====================================================================================================

            return;
        }

        [Test()]
        public void MeanGeometric()
        {
            //====================================================================================================
            // Arrange
            data01 = new List<int> { 2, 4, 3, 5, 6, 7, 4, 4, 2, 1 };

            sw = Stopwatch.StartNew();
            //----------------------------------------------------------------------------------------------------
            // Act
            mean01 = data01.MeanGeometric();
            sw.Stop();
            Console.WriteLine($"List<int>.MeanArithmetic()");
            Console.WriteLine($"          mean_arithmetic    = {mean01}");
            Console.WriteLine($"          size               = {data01.Count}");
            Console.WriteLine($"          elapsed[ticks]     = {sw.ElapsedTicks}");
            Console.WriteLine($"          elapsed[ms]        = {sw.Elapsed.TotalMilliseconds}");
            sw.Reset();

            //----------------------------------------------------------------------------------------------------
            // Assert
            Assert.AreEqual(3.317, mean01, 0.0001);
            //====================================================================================================

            return;
        }

        [Test()]
        public void MeanHarmonic()
        {
            //====================================================================================================
            // Arrange
            data01 = new List<int> { 2, 4, 3, 5, 6, 7, 4, 4, 2, 1 };

            sw = Stopwatch.StartNew();
            //----------------------------------------------------------------------------------------------------
            // Act
            mean01 = data01.MeanHarmonic();
            sw.Stop();
            Console.WriteLine($"List<int>.MeanHarmonic()");
            Console.WriteLine($"          mean_harmonic      = {mean01}");
            Console.WriteLine($"          size               = {data01.Count}");
            Console.WriteLine($"          elapsed[ticks]     = {sw.ElapsedTicks}");
            Console.WriteLine($"          elapsed[ms]        = {sw.Elapsed.TotalMilliseconds}");
            sw.Reset();

            //----------------------------------------------------------------------------------------------------
            // Assert
            Assert.AreEqual(2.783, mean01, 0.001);
            //====================================================================================================

            return;
        }

        [Test()]
        public void MeanQuadratic()
        {
            //====================================================================================================
            // Arrange
            data01 = new List<int> { 2, 4, 3, 5, 6, 7, 4, 4, 2, 1 };

            sw = Stopwatch.StartNew();
            //----------------------------------------------------------------------------------------------------
            // Act
            mean01 = data01.MeanQuadratic();
            sw.Stop();
            Console.WriteLine($"List<int>.MeanQuadratic()");
            Console.WriteLine($"          mean_quadratic     = {mean01}");
            Console.WriteLine($"          size               = {data01.Count}");
            Console.WriteLine($"          elapsed[ticks]     = {sw.ElapsedTicks}");
            Console.WriteLine($"          elapsed[ms]        = {sw.Elapsed.TotalMilliseconds}");
            sw.Reset();

            //----------------------------------------------------------------------------------------------------
            // Assert
            Assert.AreEqual(4.19523539268, mean01, 0.000001);
            //====================================================================================================

            return;
        }

        [Test()]
        public void MeanCubic()
        {
            //====================================================================================================
            // Arrange
            data01 = new List<int> { 2, 4, 3, 5, 6, 7, 4, 4, 2, 1 };

            sw = Stopwatch.StartNew();
            //----------------------------------------------------------------------------------------------------
            // Act
            mean01 = data01.MeanCubic();
            sw.Stop();
            Console.WriteLine($"List<int>.MeanCubic()");
            Console.WriteLine($"          mean_cubic         = {mean01}");
            Console.WriteLine($"          size               = {data01.Count}");
            Console.WriteLine($"          elapsed[ticks]     = {sw.ElapsedTicks}");
            Console.WriteLine($"          elapsed[ms]        = {sw.Elapsed.TotalMilliseconds}");
            sw.Reset();

            //----------------------------------------------------------------------------------------------------
            // Assert
            Assert.AreEqual(4.514, mean01, 0.001);
            //====================================================================================================

            return;
        }

        [Test()]
        public void MeanGeneralized()
        {
            //====================================================================================================
            // Arrange
            data01 = new List<int> { 2, 4, 3, 5, 6, 7, 4, 4, 2, 1 };

            sw = Stopwatch.StartNew();
            //----------------------------------------------------------------------------------------------------
            // Act
            mean01 = data01.MeanGeneralized(2.0);
            mean02 = data01.MeanGeneralized(3.0);
            sw.Stop();
            Console.WriteLine($"List<int>.MeanGeneralized()");
            Console.WriteLine($"          mean_generalized(2.0) = {mean01}");
            Console.WriteLine($"          mean_generalized(3.0) = {mean02}");
            Console.WriteLine($"          size                  = {data01.Count}");
            Console.WriteLine($"          elapsed[ticks]        = {sw.ElapsedTicks}");
            Console.WriteLine($"          elapsed[ms]           = {sw.Elapsed.TotalMilliseconds}");
            sw.Reset();

            //----------------------------------------------------------------------------------------------------
            // Assert
            Assert.AreEqual(4.19523, mean01, 0.00001);
            Assert.AreEqual(4.514, mean02, 0.001);
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
                    { 2, 4, 3, 5, 6, 7, 4, 4, 2, 1 };
            weights = new List<double>()
                    { 1, 4, 3, 4, 4, 4, 5, 3, 2, 1 };

            sw = Stopwatch.StartNew();
            //----------------------------------------------------------------------------------------------------
            // Act
            mean01 = data01.MeanWeighted(weights);
            sw.Stop();
            Console.WriteLine($"List<int>.MeanWeighted(weights)");
            Console.WriteLine($"          mean_weighted      = {mean01}");
            Console.WriteLine($"          size               = {data01.Count}");
            Console.WriteLine($"          elapsed[ticks]     = {sw.ElapsedTicks}");
            Console.WriteLine($"          elapsed[ms]        = {sw.Elapsed.TotalMilliseconds}");
            sw.Reset();

            //----------------------------------------------------------------------------------------------------
            // Assert
            Assert.AreEqual(4.3871, mean01, 0.00001);
            //====================================================================================================

            return;
        }

        [Test()]
        public void Median01()
        {
            //====================================================================================================
            // Arrange
            List<int> data01 = new List<int> { 2, 4, 3, 5, 6, 7, 4, 4, 2, 1 };

            sw = Stopwatch.StartNew();
            // Act
            median01 = data01.Median();
            sw.Stop();
            Console.WriteLine($"List<int>.Median()");
            Console.WriteLine($"          median01           = {median01}");
            Console.WriteLine($"          size               = {data01.Count}");
            Console.WriteLine($"          elapsed[ticks]     = {sw.ElapsedTicks}");
            Console.WriteLine($"          elapsed[ms]        = {sw.Elapsed.TotalMilliseconds}");
            sw.Reset();

            // Assert
            Assert.AreEqual(4.0, median01, 0.1);
            //====================================================================================================

            return;
        }

        [Test()]
        public void Median02()
        {
            //====================================================================================================
            // Arrange
            Stack<int> data02 = new Stack<int>(new[] { 2, 4, 3, 5, 6, 7, 4, 4, 2, 1 });

            sw = Stopwatch.StartNew();
            // Act
            median01 = data02.Median();
            sw.Stop();
            Console.WriteLine($"Stack<int>.Average() size={data02.Count} elapsed[ticks]={sw.ElapsedTicks}");
            sw.Reset();

            // Assert
            Assert.AreEqual(4.0, median01, 0.001);
            //====================================================================================================

            return;
        }

        [Test()]
        public void Median03()
        {
            //====================================================================================================
            // Arrange
            Queue<int> data03 = new Queue<int>(new[] { 2, 4, 3, 5, 6, 7, 4, 4, 2, 1 });

            sw = Stopwatch.StartNew();
            // Act
            median01 = data03.Median();
            sw.Stop();
            Console.WriteLine($"Queue<int>.Average() size={data03.Count} elapsed[ticks]={sw.ElapsedTicks}");
            sw.Reset();

            // Assert
            Assert.AreEqual(4.0, median01, 0.001);
            //====================================================================================================

            return;
        }

        [Test()]
        public void Median04()
        {
            //====================================================================================================
            // Arrange
            int[] data04 = new[] { 2, 4, 3, 5, 6, 7, 4, 4, 2, 1 };

            sw = Stopwatch.StartNew();
            // Act
            median01 = data04.Median();
            sw.Stop();
            Console.WriteLine($"int[].Modes() size={data04.Length} elapsed[ticks]={sw.ElapsedTicks}");
            sw.Reset();

            // Assert
            Assert.AreEqual(4.0, median01, 0.001);
            //====================================================================================================

            return;
        }

        [Test()]
        public void Median05()
        {
            #if NETSTANDARD1_3
            //====================================================================================================
            // Arrange
            ArrayList data05 = new ArrayList { 2, 4, 3, 5, 6, 7, 4, 4, 2, 1 };

            sw = Stopwatch.StartNew();
            // Act
            List<int> modes05 = data05.Modes();
            sw.Stop();
            Console.WriteLine($"ArrayList.Modes() size={data05.Count} elapsed[ticks]={sw.ElapsedTicks}");
            sw.Reset();

            // Assert
            CollectionAssert.AreEquivalent
                                    (
                                        new List<int> { 4 }, 
                                        modes05
                                    );
            //====================================================================================================
            #endif

            return;
        }

        [Test()]
        public void MedianWeighted()
        {
            //====================================================================================================
            // Arrange
            int[] data04 = new[] { 2, 4, 3, 5, 6, 7, 4, 4, 2, 1 };
            int[] weights04 = new[] { 1, 3, 4, 5, 2, 3, 2, 4, 1, 1 };

            sw = Stopwatch.StartNew();
            // Act
            median01 = data04.MedianWeighted(weights04.Select(i => (double)i));
            sw.Stop();
            Console.WriteLine($"int[].Modes() size={data04.Length} elapsed[ticks]={sw.ElapsedTicks}");
            sw.Reset();

            // Assert
            Assert.AreEqual(5.0, median01, 0.001);
            //====================================================================================================

            return;
        }

    }
}
