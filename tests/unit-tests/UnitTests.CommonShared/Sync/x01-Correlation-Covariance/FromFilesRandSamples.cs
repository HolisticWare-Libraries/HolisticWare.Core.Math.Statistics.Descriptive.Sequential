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
using System.IO;
using UnitTests.CommonShared.Sync.FromFiles.UnitTests20180318DataSetBasketball;

#if XUNIT
using Xunit;
using Test = Xunit.FactAttribute;
using OneTimeSetUp = System.ObsoleteAttribute;
#elif NUNIT
using NUnit.Framework;
using Fact=NUnit.Framework.TestAttribute;
#elif MSTEST
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OneTimeSetUp = Microsoft.VisualStudio.TestTools.UnitTesting.ClassInitializeAttribute;
using Test = Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute;
using Fact = Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute;
#endif

using Core.Math.Statistics.Descriptive.Sequential;

namespace UnitTests.Core.Math.Statistics.Descriptive.Sequential.Sync
{
    public partial class FromFilesRandSamples
    {
        Stopwatch sw = null;
        List<double> data01 = null;
        List<double> data02 = null;

        double? correlation_data01_data02_01 = null;
        double? correlation_data02_data01_01 = null;

        [Test]
        public void Correlation_01_02()
        {
            //====================================================================================================
            //  Arrange
            //  reading data from files
            data01 = UnitTests20180318DataSetRand50Samp01.Data;
            data02 = UnitTests20180318DataSetRand50Samp02.Data;

            sw = Stopwatch.StartNew();

            //----------------------------------------------------------------------------------------------------
            // Act
            correlation_data01_data02_01 = data01.Correlation(data02);
            sw.Stop();
            Console.WriteLine($"List<double>.Correlation(List<double>)");
            Console.WriteLine($"          correlation        = {correlation_data01_data02_01}");
            Console.WriteLine($"          size               = {data01.Count()} x {data02.Count()}");
            Console.WriteLine($"          elapsed[ticks]     = {sw.ElapsedTicks}");
            Console.WriteLine($"          elapsed[ms]        = {sw.Elapsed.TotalMilliseconds}");
            sw.Reset();

            //----------------------------------------------------------------------------------------------------
            // Assert
            #if NUNIT
            Assert.AreEqual(0.1882, correlation_data01_data02_01, 0.0001);
            #elif XUNIT
            Assert.Equal(0.1882, (double)correlation_data01_data02_01, 4);
            #elif MSTEST
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

            sw = Stopwatch.StartNew();

            //----------------------------------------------------------------------------------------------------
            // Act
            correlation_data02_data01_01 = data02.Correlation(data01);
            sw.Stop();
            Console.WriteLine($"List<double>.Correlation(List<double>)");
            Console.WriteLine($"          correlation        = {correlation_data02_data01_01}");
            Console.WriteLine($"          size               = {data01.Count()} x {data02.Count()}");
            Console.WriteLine($"          elapsed[ticks]     = {sw.ElapsedTicks}");
            Console.WriteLine($"          elapsed[ms]        = {sw.Elapsed.TotalMilliseconds}");
            sw.Reset();

            //----------------------------------------------------------------------------------------------------
            // Assert
            #if NUNIT
            Assert.AreEqual(0.1882, correlation_data02_data01_01, 0.0001);
            #elif XUNIT
            Assert.Equal(0.1882, (double)correlation_data02_data01_01, 4);
            #elif MSTEST
            #endif
            //====================================================================================================

            #if NUNIT
            Assert.AreEqual
                        (
                            (double)correlation_data01_data02_01,
                            (double)correlation_data02_data01_01,
                            0.00001
                        );
            #elif XUNIT
            Assert.Equal
                        (
                            (double)correlation_data01_data02_01,
                            (double)correlation_data02_data01_01,
                            5
                        );
            #elif MSTEST
            Assert.AreEqual
                        (
                            (double)correlation_data01_data02_01,
                            (double)correlation_data02_data01_01,
                            0.00001
                        );
            #endif

            return;
        }
    }
}
