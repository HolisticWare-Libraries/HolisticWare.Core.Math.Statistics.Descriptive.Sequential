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
        List<double> data = null;

        [OneTimeSetUp]
        public void LoadDataFromFile()
		{
            string directory_test = TestContext.CurrentContext.TestDirectory;
            string path_data = System.IO.Path.Combine
                                    (
                                        new string[]
                                            {
                                                directory_test, 
                                                $@"Xtras-BigData", 
                                                $@"Rand_Samp_data_SDM.csv",
                                            }
                                    );
            string text = null;
            using (StreamReader reader = new StreamReader(path_data))
            {
                text = reader.ReadToEnd();
            }
            string[] lines = text.Split
                                    (
                                        new string[] { Environment.NewLine },
                                        StringSplitOptions.RemoveEmptyEntries
                                    );

            data = new List<double>();
            foreach(string s in lines)
            {
                double data_item = Double.Parse(s);
                data.Add(data_item);
            }

			return;
		}

        [Test]
        public void Average()
        {
            // Act
            double mean_arithmetic = data.MeanArithmetic();

            // Act
            double mean_geometric = data.MeanGeometric();
            Assert.That(Double.IsInfinity(mean_geometric));

            decimal mean_deomatric_decimal = (data.Cast<decimal>()).MeanGeometric();

            return;
        }

    }
}
