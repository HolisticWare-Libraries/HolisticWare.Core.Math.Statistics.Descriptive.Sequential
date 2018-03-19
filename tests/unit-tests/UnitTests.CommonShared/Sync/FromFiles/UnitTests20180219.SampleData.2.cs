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
using System;

using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;
using System.Threading.Tasks;
using System.IO;

#if XUNIT
using Xunit;
using Test = Xunit.FactAttribute;
using OneTimeSetUp = System.ObsoleteAttribute;
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

namespace UnitTests.HolisticWare.Core.Math.Statistics
{
    public partial class UnitTests20180219
    {
        List<double> data01 = null;

        [OneTimeSetUp]
        public void LoadDataFromFile2()
		{
            string directory_test =
                                    #if NUNIT
                                    TestContext.CurrentContext.TestDirectory
                                    #elif XUNIT
                                    System.Reflection.Assembly.GetExecutingAssembly().CodeBase
                                    #elif MSTEST
                                    System.Reflection.Assembly.GetExecutingAssembly().CodeBase
                                    #endif
                                    ;

            string path_data = null;
            string text = null;
            string[] lines = null;

            //------------------------------------------------------------------
            path_data = System.IO.Path.Combine
                                    (
                                        new string[]
                                            {
                                                directory_test, 
                                                $@"Xtras-SampleData", 
                                                $@"Rand_Samp1_50.csv",
                                            }
                                    );
            using (StreamReader reader = new StreamReader(path_data))
            {
                text = reader.ReadToEnd();
            }
            lines = text.Split
                            (
                                new string[] { Environment.NewLine },
                                StringSplitOptions.RemoveEmptyEntries
                            );

            data01 = new List<double>();
            foreach(string s in lines)
            {
                double data_item = Double.Parse(s);
                data01.Add(data_item);
            }
            //------------------------------------------------------------------

			return;
		}

        [Test]
        public void Averages_data01()
        {
            //====================================================================================================
            //  Arrange
            //  reading data from files

            sw = Stopwatch.StartNew();

            //----------------------------------------------------------------------------------------------------
            // Act
            double mean_arithmetic = data01.MeanArithmetic();
            sw.Stop();
            Console.WriteLine($"List<double>.MeanArithmetic()");
            Console.WriteLine($"          mean_arithmetic    = {mean_arithmetic}");
            Console.WriteLine($"          size               = {data01.Count()}");
            Console.WriteLine($"          elapsed[ticks]     = {sw.ElapsedTicks}");
            Console.WriteLine($"          elapsed[ms]        = {sw.Elapsed.TotalMilliseconds}");
            sw.Reset();
            //----------------------------------------------------------------------------------------------------
            // Assert
            #if NUNIT
            Assert.AreEqual(180.88139, mean_arithmetic, 0.00001);
            #elif XUNIT
            Assert.Equal(180.88139, mean_arithmetic, 5);
            #elif MSTEST
            #endif
            //====================================================================================================

            //====================================================================================================
            //  Arrange
            //  reading data from files

            sw = Stopwatch.StartNew();

            //----------------------------------------------------------------------------------------------------
            // Act
            double mean_geometric = data01.MeanGeometric();
            sw.Stop();
            Console.WriteLine($"List<double>.MeanGeometric()");
            Console.WriteLine($"          mean_geometric     = {mean_geometric}");
            Console.WriteLine($"          size               = {data01.Count()}");
            Console.WriteLine($"          elapsed[ticks]     = {sw.ElapsedTicks}");
            Console.WriteLine($"          elapsed[ms]        = {sw.Elapsed.TotalMilliseconds}");
            sw.Reset();

            //----------------------------------------------------------------------------------------------------
            // Assert
            #if NUNIT
            Assert.That(!Double.IsInfinity(mean_geometric));
            Assert.AreEqual(179.77969, mean_geometric, 0.00001);
            #elif XUNIT
            Assert.True(!Double.IsInfinity(mean_geometric));
            Assert.Equal(179.77969, mean_geometric, 5);
            #elif MSTEST
            #endif
            //====================================================================================================

            // System.OverflowException : Arithmetic operation resulted in an overflow.

            #if NUNIT
            Assert.Throws<System.OverflowException>
                    (
                        () =>
                        {
                            // TODO: System.InvalidCastException : Specified cast is not valid.
                            decimal mean_deomatric_decimal = (data01.Select(x_i => (decimal)x_i)).MeanGeometric();
                        }
                    );
            #elif XUNIT
            Assert.Throws<System.OverflowException>
                    (
                        () =>
                        {
                            // TODO: System.InvalidCastException : Specified cast is not valid.
                            decimal mean_deomatric_decimal = (data01.Select(x_i => (decimal)x_i)).MeanGeometric();
                        }
                    );
            #elif MSTEST
            #endif
            return;
        }

        [Test]
        public void StandardDeviation_data01()
        {
            //====================================================================================================
            //  Arrange
            //  reading data from files

            sw = Stopwatch.StartNew();

            //----------------------------------------------------------------------------------------------------
            // Act
            double standard_deviation_s = data01.StandardDeviationSample();
            sw.Stop();
            Console.WriteLine($"List<double>.StandardDeviationSample()");
            Console.WriteLine($"          standard_deviation = {standard_deviation_s}");
            Console.WriteLine($"          size               = {data01.Count()}");
            Console.WriteLine($"          elapsed[ticks]     = {sw.ElapsedTicks}");
            Console.WriteLine($"          elapsed[ms]        = {sw.Elapsed.TotalMilliseconds}");
            sw.Reset();

            //----------------------------------------------------------------------------------------------------
            // Assert
            #if NUNIT
            Assert.AreEqual(19.74941, standard_deviation_s, 0.00001);
            #elif XUNIT
            Assert.Equal(19.74941, standard_deviation_s, 5);
            #elif MSTEST
            #endif
            //====================================================================================================

            //====================================================================================================
            //  Arrange
            //  reading data from files

            sw = Stopwatch.StartNew();

            //----------------------------------------------------------------------------------------------------
            // Act
            double standard_deviation_p = data01.StandardDeviationPopulation();
            sw.Stop();
            Console.WriteLine($"List<double>.StandardDeviationPopulation()");
            Console.WriteLine($"          standard_deviation = {standard_deviation_p}");
            Console.WriteLine($"          size               = {data01.Count()}");
            Console.WriteLine($"          elapsed[ticks]     = {sw.ElapsedTicks}");
            Console.WriteLine($"          elapsed[ms]        = {sw.Elapsed.TotalMilliseconds}");
            sw.Reset();

            //----------------------------------------------------------------------------------------------------
            // Assert
            #if NUNIT
            Assert.AreEqual(19.55092, standard_deviation_p, 0.0001);
            #elif XUNIT
            Assert.Equal(19.55092, standard_deviation_p, 4);
            #elif MSTEST
            #endif
            //====================================================================================================
        }

        [Test]
        public void Variance_data01()
        {
            //====================================================================================================
            //  Arrange
            //  reading data from files

            sw = Stopwatch.StartNew();

            //----------------------------------------------------------------------------------------------------
            // Act
            double variance_s = data01.VarianceSample();
            sw.Stop();
            Console.WriteLine($"List<double>.VarianceSample()");
            Console.WriteLine($"          variance           = {variance_s}");
            Console.WriteLine($"          size               = {data01.Count()}");
            Console.WriteLine($"          elapsed[ticks]     = {sw.ElapsedTicks}");
            Console.WriteLine($"          elapsed[ms]        = {sw.Elapsed.TotalMilliseconds}");
            sw.Reset();

            //----------------------------------------------------------------------------------------------------
            // Assert
            #if NUNIT
            Assert.AreEqual(390.03934, variance_s, 0.01);
            #elif XUNIT
            Assert.Equal(390.03934, variance_s, 2);
            #elif MSTEST
            #endif
            //====================================================================================================

            //====================================================================================================
            //  Arrange
            //  reading data from files

            sw = Stopwatch.StartNew();

            //----------------------------------------------------------------------------------------------------
            // Act
            double variance_p = data01.VariancePopulation();
            sw.Stop();
            Console.WriteLine($"List<double>.VariancePopulation()");
            Console.WriteLine($"          variance           = {variance_p}");
            Console.WriteLine($"          size               = {data01.Count()}");
            Console.WriteLine($"          elapsed[ticks]     = {sw.ElapsedTicks}");
            Console.WriteLine($"          elapsed[ms]        = {sw.Elapsed.TotalMilliseconds}");
            sw.Reset();

            //----------------------------------------------------------------------------------------------------
            // Assert
            #if NUNIT
            Assert.AreEqual(382.23856, variance_p, 0.0001);
            #elif XUNIT
            Assert.Equal(382.23856, variance_p, 4);
            #elif MSTEST
            #endif
            //====================================================================================================

            return;
        }

    }
}
