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
#endif

using Core.Math.Statistics.Descriptive.Sequential;

namespace UnitTests.Core.Math.Statistics.Descriptive.Sequential.Sync
{
    public partial class UnitTests20180318DataSetRand50Samp02
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
            Assert.AreEqual(177.6258, mean_arithmetic, 0.00001);
            #elif XUNIT
            Assert.Equal(177.6258, mean_arithmetic, 5);
            #elif MSTEST
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
            Assert.AreEqual(176.5979, mean_geometric, 0.0001);
            #elif XUNIT
            Assert.True(Double.IsInfinity(mean_geometric));
            Assert.Equal(176.5979, mean_geometric, 4);
            #elif MSTEST
            Assert.IsTrue(!Double.IsInfinity(mean_geometric));
            Assert.AreEqual(176.5979, mean_geometric, 0.0001);
            #endif
            //====================================================================================================

            return;
        }

        [Test]
        public void MeanGeometric_Exception()
        {
            #if NUNIT
            Assert.That
                    (
                        () =>
                        {
                            // TODO: System.InvalidCastException : Specified cast is not valid.
                            decimal mean_deomatric_decimal = (Data.Select(x_i => (decimal)x_i)).MeanGeometric();
                        },
                        Throws.InstanceOf(typeof(System.OverflowException))
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
    }
}
