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
using System.IO;

using Core.Math.Statistics.Descriptive.Sequential;

namespace UnitTests.HolisticWare.Core.Math.Statistics
{
    public partial class UnitTests20180215
    {
        Stopwatch sw = null;
        List<double> data01 = null;
        List<double> data02 = null;

        [OneTimeSetUp]
        public void LoadDataFromFile()
		{
            string directory_test = TestContext.CurrentContext.TestDirectory;

            string path_data = null;
            string text = null;
            string[] lines = null;

            //------------------------------------------------------------------
            path_data = System.IO.Path.Combine
                                    (
                                        new string[]
                                            {
                                                directory_test, 
                                                $@"Xtras-BigData", 
                                                $@"Rand_Samp_BigData_01.csv",
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

            //------------------------------------------------------------------
            path_data = System.IO.Path.Combine
                                    (
                                        new string[]
                                            {
                                                directory_test,
                                                $@"Xtras-BigData",
                                                $@"Rand_Samp_BigData_02.csv",
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

            data02 = new List<double>();
            foreach (string s in lines)
            {
                double data_item = Double.Parse(s);
                data02.Add(data_item);
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
            Console.WriteLine($"List<int>.Average() size={data01.Count} elapsed[ticks]={sw.ElapsedTicks}");
            sw.Reset();

            //----------------------------------------------------------------------------------------------------
            // Assert
            Assert.AreEqual(177.24999, mean_arithmetic, 0.00001);
            //====================================================================================================

            //====================================================================================================
            //  Arrange
            //  reading data from files

            sw = Stopwatch.StartNew();

            //----------------------------------------------------------------------------------------------------
            // Act
            double mean_geometric = data01.MeanGeometric();
            sw.Stop();
            Console.WriteLine($"List<int>.Average() size={data01.Count} elapsed[ticks]={sw.ElapsedTicks}");
            sw.Reset();

            //----------------------------------------------------------------------------------------------------
            // Assert
            Assert.That(Double.IsInfinity(mean_geometric));
            //====================================================================================================

            // TODO: System.InvalidCastException : Specified cast is not valid.
            //decimal mean_deomatric_decimal = (data01.Cast<decimal>()).MeanGeometric();

            return;
        }

        [Test]
        public void Averages_data02()
        {
            //====================================================================================================
            //  Arrange
            //  reading data from files

            sw = Stopwatch.StartNew();

            //----------------------------------------------------------------------------------------------------
            // Act
            double mean_arithmetic = data02.MeanArithmetic();
            sw.Stop();
            Console.WriteLine($"List<int>.Average() size={data02.Count} elapsed[ticks]={sw.ElapsedTicks}");
            sw.Reset();

            //----------------------------------------------------------------------------------------------------
            // Assert
            Assert.AreEqual(177.249978, mean_arithmetic, 0.000001);
            //====================================================================================================

            //====================================================================================================
            //  Arrange
            //  reading data from files

            sw = Stopwatch.StartNew();

            //----------------------------------------------------------------------------------------------------
            // Act
            double mean_geometric = data02.MeanGeometric();
            sw.Stop();
            Console.WriteLine($"List<int>.Average() size={data02.Count} elapsed[ticks]={sw.ElapsedTicks}");
            sw.Reset();

            //----------------------------------------------------------------------------------------------------
            // Assert
            Assert.That(Double.IsInfinity(mean_geometric));
            //====================================================================================================

            // TODO: System.InvalidCastException : Specified cast is not valid.
            //decimal mean_deomatric_decimal = (data02.Cast<decimal>()).MeanGeometric();

            return;
        }
    }
}
