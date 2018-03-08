﻿// /*
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
using System.Threading.Tasks;

using Core.Math.Statistics.Descriptive.Sequential;

namespace UnitTests.Core.Math.Statistics.Descriptive.Sequential.Async
{
    public partial class Tests01MeanAverage
    {
        Stopwatch sw = null;

        [Test()]
        public void MeanAverage01()
        {
            Nito.AsyncEx.AsyncContext.Run
                    (
                        async () =>
                        {
                            //====================================================================================================
                            // Arrange
                            List<int> data01 = new List<int> { 2, 4, 3, 5, 6, 7, 4, 4, 2, 1 };

                            sw = Stopwatch.StartNew();
                            //----------------------------------------------------------------------------------------------------
                            // Act
                            double mean02 = await data01.MeanArithmeticAsync();
                            sw.Stop();
                            Console.WriteLine($"List<int>.Average() size={data01.Count()} elapsed[ticks]={sw.ElapsedTicks}");
                            sw.Reset();

                            //----------------------------------------------------------------------------------------------------
                            // Assert
                            Assert.AreEqual(3.8, mean02, 0.1);
                            //====================================================================================================
                            
                        }
                    );

            return;
        }

        [Test()]
        public async Task MeanAverage01Async()
        {
            //====================================================================================================
            // Arrange
            List<int> data01 = new List<int> { 2, 4, 3, 5, 6, 7, 4, 4, 2, 1 };

            sw = Stopwatch.StartNew();
            //----------------------------------------------------------------------------------------------------
            // Act
            double mean01 = data01.Average();
            sw.Stop();
            Console.WriteLine($"List<int>.Average() size={data01.Count()} elapsed[ticks]={sw.ElapsedTicks}");
            sw.Reset();

            //----------------------------------------------------------------------------------------------------
            // Assert
            Assert.AreEqual(3.8, mean01, 0.1);
            //====================================================================================================

            //====================================================================================================
            // Arrange
            List<int> data02 = new List<int> { 2, 4, 3, 5, 6, 7, 4, 4, 2, 1 };

            sw = Stopwatch.StartNew();
            //----------------------------------------------------------------------------------------------------
            // Act
            double mean02 = await data02.MeanArithmeticAsync();
            sw.Stop();
            Console.WriteLine($"List<int>.Average() size={data01.Count()} elapsed[ticks]={sw.ElapsedTicks}");
            sw.Reset();

            //----------------------------------------------------------------------------------------------------
            // Assert
            Assert.AreEqual(3.8, mean02, 0.1);
            //====================================================================================================

            return;
        }

        [Test()]
        public async Task MeanAverage2()
        {
            //====================================================================================================
            // Arrange
            // TODO: nullable
            //List<int?> data01 = new List<int?> { 2, 4, 3, 5, 6, 7, 4, 4, 2, 1 };
            List<int> data01 = new List<int> { 2, 4, 3, 5, 6, 7, 4, 4, 2, 1 };

            sw = Stopwatch.StartNew();
            //----------------------------------------------------------------------------------------------------
            // Act
            double mean01 = await data01.MeanArithmeticAsync();
            sw.Stop();
            Console.WriteLine($"List<int>.Average() size={data01.Count()} elapsed[ticks]={sw.ElapsedTicks}");
            sw.Reset();

            //----------------------------------------------------------------------------------------------------
            // Assert
            Assert.AreEqual(3.8, mean01, 0.1);
            //====================================================================================================

            return;
        }
    }
}
