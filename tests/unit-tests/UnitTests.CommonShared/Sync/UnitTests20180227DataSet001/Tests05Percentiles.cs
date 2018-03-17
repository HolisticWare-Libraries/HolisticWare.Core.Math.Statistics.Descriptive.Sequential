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
#endif

using Core.Math.Statistics.Descriptive.Sequential;

namespace UnitTests.Core.Math.Statistics.Descriptive.Sequential.Sync
{
    public partial class UnitTests20180227DataSet001
    {
        (int min, double interpolated, int max) percentile_int_01;

        [Test()]
        public void Percentiles01()
        {
            //====================================================================================================
            // Arrange
            data01 = new List<int> { 2, 3, 5, 9 };

            sw = Stopwatch.StartNew();
            //----------------------------------------------------------------------------------------------------
            // Act
            percentile_int_01 = data01.Percentile(50);
            sw.Stop();
            Console.WriteLine($"List<int>.Percentile(50)");
            Console.WriteLine($"          percentile_int_01  = {percentile_int_01}");
            Console.WriteLine($"          size               = {data01.Count()}");
            Console.WriteLine($"          elapsed[ticks]     = {sw.ElapsedTicks}");
            Console.WriteLine($"          elapsed[ms]        = {sw.Elapsed.TotalMilliseconds}");
            sw.Reset();

            //----------------------------------------------------------------------------------------------------
            // Assert
            #if NUNIT
            Assert.AreEqual(3, percentile_int_01.min);
            Assert.AreEqual(5, percentile_int_01.max);
            Assert.AreEqual(4, percentile_int_01.interpolated);
            #elif XUNIT
            Assert.Equal(3, percentile_int_01.min);
            Assert.Equal(5, percentile_int_01.max);
            Assert.Equal(4, percentile_int_01.interpolated);
            #elif MSTEST
            #endif
            //====================================================================================================

            return;
        }

        [Test()]
        public void Percentiles02()
        {
            //====================================================================================================
            // Arrange
            data01 = new List<int> { 2, 3, 5, 9, 11 };

            sw = Stopwatch.StartNew();
            //----------------------------------------------------------------------------------------------------
            // Act
            percentile_int_01 = data01.Percentile(50);
            sw.Stop();
            Console.WriteLine($"List<int>.Percentile(50)");
            Console.WriteLine($"          percentile_int_01  = {percentile_int_01}");
            Console.WriteLine($"          size               = {data01.Count()}");
            Console.WriteLine($"          elapsed[ticks]     = {sw.ElapsedTicks}");
            Console.WriteLine($"          elapsed[ms]        = {sw.Elapsed.TotalMilliseconds}");
            sw.Reset();

            //----------------------------------------------------------------------------------------------------
            // Assert
            #if NUNIT
            Assert.AreEqual(5, percentile_int_01.min);
            Assert.AreEqual(5, percentile_int_01.max);
            Assert.AreEqual(5, percentile_int_01.interpolated);
            Assert.AreEqual(5, data01.Median());
            #elif XUNIT
            Assert.Equal(5, percentile_int_01.min);
            Assert.Equal(5, percentile_int_01.max);
            Assert.Equal(5, percentile_int_01.interpolated);
            Assert.Equal(5, data01.Median());
            #elif MSTEST
            #endif
            //====================================================================================================

            return;
        }

        [Test()]
        public void Percentiles03()
        {
            //====================================================================================================
            // Arrange
            data01 = new List<int> { 3, 5, 7, 9, 12, 21, 25, 30 };

            sw = Stopwatch.StartNew();
            //----------------------------------------------------------------------------------------------------
            // Act
            percentile_int_01 = data01.Percentile(25);
            sw.Stop();
            Console.WriteLine($"List<int>.Percentile(25)");
            Console.WriteLine($"          percentile_int_01  = {percentile_int_01}");
            Console.WriteLine($"          size               = {data01.Count()}");
            Console.WriteLine($"          elapsed[ticks]     = {sw.ElapsedTicks}");
            Console.WriteLine($"          elapsed[ms]        = {sw.Elapsed.TotalMilliseconds}");
            sw.Reset();

            //----------------------------------------------------------------------------------------------------
            // Assert
            #if NUNIT
            Assert.AreEqual(5, percentile_int_01.min);
            Assert.AreEqual(7, percentile_int_01.max);
            Assert.AreEqual(5.5, percentile_int_01.interpolated);
            #elif XUNIT
            Assert.Equal(5, percentile_int_01.min);
            Assert.Equal(7, percentile_int_01.max);
            Assert.Equal(5.5, percentile_int_01.interpolated);
            #elif MSTEST
            #endif
            //====================================================================================================

            return;
        }
    }
}
