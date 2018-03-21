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
    public partial class Tests03Page95DescriptiveAnalysis
    {
        [Test()]
        public void Data_x1_Mean_Average()
        {
            // Act
            double x1_average = x1.Average();
            // Assert
            #if NUNIT
            Assert.AreEqual(x1_average, 58.7787, 0.0001);
            #elif XUNIT
            Assert.Equal(x1_average, 58.7787, 4);
            #elif MSTEST
            #endif

            return;
        }

        [Test()]
        public void Data_x1_StandardDeviationSample()
        {
            // Act
            double x1_standard_deviation = x1.StandardDeviationSample();

            // Assert
            #if NUNIT
            Assert.AreEqual(x1_standard_deviation, 17.63, 0.01);
            #elif XUNIT
            Assert.Equal(x1_standard_deviation, 17.63, 2);
            #elif MSTEST
            #endif

            return;
        }

        [Test()]
        public void Data_x1_Min()
        {
            // Act
            double x1_min = x1.Min();
            // Assert
            #if NUNIT
            Assert.AreEqual(x1_min, 33.65, 0.01);
            #elif XUNIT
            Assert.Equal(x1_min, 33.65, 2);
            #elif MSTEST
            #endif

            return;
        }

        [Test()]
        public void Data_x1_Max()
        {

            // Act
            double x1_max = x1.Max();
            // Assert
            #if NUNIT
            Assert.AreEqual(x1_max, 93.51, 0.01);
            #elif XUNIT
            Assert.Equal(x1_max, 93.51, 2);
            #elif MSTEST
            #endif

            return;
        }

        [Test()]
        public void Data_x21_MeanArithmetic_Average()
        {
            // Act
            double x21_average = x21.Average();
            // Assert
            #if NUNIT
            Assert.AreEqual(x21_average, 63.77, 0.01);
            #elif XUNIT
            Assert.Equal(x21_average, 63.779, 3);
            #elif MSTEST
            #endif

            return;
        }

        [Test()]
        public void Data_x21_StandardDeviation()
        {
            // Act
            double x21_standard_deviation = x21.StandardDeviationSample();
            // Assert
            #if NUNIT
            Assert.AreEqual(x21_standard_deviation, 17.63, 0.01);
            #elif XUNIT
            Assert.Equal(x21_standard_deviation, 17.6391, 4);
            #elif MSTEST
            #endif

            return;
        }

        [Test()]
        public void Data_x21_Min()
        {
            // Act
            double x21_min = x21.Min();
            // Assert
            #if NUNIT
            Assert.AreEqual(x21_min, 38.65, 0.01);
            #elif XUNIT
            Assert.Equal(x21_min, 38.65, 2);
            #elif MSTEST
            #endif

            return;
        }

        [Test()]
        public void Data_x21_Max()
        {
            // Act
            double x21_max = x21.Max();
            // Assert
            #if NUNIT
            Assert.AreEqual(x21_max, 98.51, 0.01);
            #elif XUNIT
            Assert.Equal(x21_max, 98.51, 2);
            #elif MSTEST
            #endif

            return;
        }

        [Test()]
        public void Data_d1_MeanArithmetic_Average()
        {
            // Act
            double d1_average = d1.Average();
            // Assert
            #if NUNIT
            Assert.AreEqual(d1_average, 5.0, 0.01);
            #elif XUNIT
            Assert.Equal(d1_average, 5.0, 2);
            #elif MSTEST
            #endif

            return;
        }

        [Test()]
        public void Data_d1_Min()
        {
            // Act
            double d1_min = d1.Min();
            // Assert
            #if NUNIT
            Assert.AreEqual(d1_min, 5.0, 0.01);
            #elif XUNIT
            Assert.Equal(d1_min, 5.0, 2);
            #elif MSTEST
            #endif

            return;
        }

        [Test()]
        public void Data_d1_Max()
        {
            // Act
            double d1_max = d1.Max();
            // Assert
            #if NUNIT
            Assert.AreEqual(d1_max, 5.0, 0.01);
            #elif XUNIT
            Assert.Equal(d1_max, 5.0, 2);
            #elif MSTEST
            #endif

            //var d1_range = d1.Range();
            //Assert.AreEqual(d1_max, 93.51, 0.01);
            //Assert.AreEqual(d1_max, 93.51, 0.01);

            return;
        }

        [Test()]
        public void Data_d1_StandardDeviationSample()
        {
            // Act
            double d1_standard_deviation_sample = d1.StandardDeviationSample();
            // Assert
            #if NUNIT
            Assert.AreEqual(d1_standard_deviation_sample, 0.0, 0.01);
            #elif XUNIT
            Assert.Equal(d1_standard_deviation_sample, 0.0, 2);
            #elif MSTEST
            #endif

            return;
        }

        [Test()]
        public void Data_d1_StandardDeviationPopulation()
        {
            // Act
            double d1_standard_deviation_population = d1.StandardDeviationPopulation();
            // Assert
            #if NUNIT
            Assert.AreEqual(d1_standard_deviation_population, 0.0, 0.01);
            #elif XUNIT
            Assert.Equal(d1_standard_deviation_population, 0.0, 2);
            #elif MSTEST
            #endif

            return;
        }

        [Test()]
        public void Data_x1_x2_Correlation()
        {
            // Act
            double correlation_x1_x2_01 = x1.Correlation(x21);
            // Assert
            #if NUNIT
            Assert.AreEqual(correlation_x1_x2_01, 1.0, 0.01);
            #elif XUNIT
            Assert.Equal(correlation_x1_x2_01, 1.0, 2);
            #elif MSTEST
            #endif

            return;
        }

        [Test()]
        public void Data_x1_x2_CorrelationOptimized()
        {
            // Act
            double correlation_x1_x2_02 = x1.CorrelationOptimized(x21);
            // Assert
            #if NUNIT
            Assert.AreEqual(correlation_x1_x2_02, 1.0, 0.01);
            #elif XUNIT
            Assert.Equal(correlation_x1_x2_02, 1.0, 2);
            #elif MSTEST
            #endif

            return;
        }

        [Test()]
        public void Data_x1_d1_Correlation()
        {
            // Act
            double correlation_x1_d1_01 = x1.Correlation(d1);
            // Assert
            #if NUNIT
            Assert.AreEqual(correlation_x1_d1_01, 0.0, 0.01);
            #elif XUNIT
            Assert.Equal(correlation_x1_d1_01, 0.0, 2);
            #elif MSTEST
            #endif

            return;
        }

        [Test()]
        public void Data_x1_d1_CorrelationOptimized()
        {
            // Act
            double correlation_x1_d1_02 = x1.CorrelationOptimized(d1);
            // Assert
            #if NUNIT
            Assert.AreEqual(correlation_x1_d1_02, 0.0, 0.01);
            #elif XUNIT
            Assert.Equal(correlation_x1_d1_02, 0.0, 2);
            #elif MSTEST
            #endif

            return;
        }

        [Test()]
        public void Data_x2_Mean_Average()
        {
            // Act
            double x22_average = x22.Average();
    
            // Assert
            #if NUNIT
            Assert.AreEqual(x22_average, 63.86, 0.01);
            #elif XUNIT
            Assert.Equal(x22_average, 63.87, 2);
            #elif MSTEST
            #endif

            return;
        }

        [Test()]
        public void Data_x2_Min()
        {
            // Act
            double x22_min = x22.Min();

            // Assert
            #if NUNIT
            Assert.AreEqual(x22_min, 39.51, 0.01);
            #elif XUNIT
            Assert.Equal(x22_min, 39.51, 2);
            #elif MSTEST
            #endif

            return;
        }

        [Test()]
        public void Data_x2_Max()
        {
            // Act
            double x22_max = x22.Max();

            // Assert
            #if NUNIT
            Assert.AreEqual(x22_max, 94.31, 0.01);
            #elif XUNIT
            Assert.Equal(x22_max, 94.31, 2);
            #elif MSTEST
            #endif

            return;
        }

        [Test()]
        public void Data_x2_StandardDeviationSample()
        {
            // Act
            double x22_standard_deviation = x22.StandardDeviationSample();

            // Assert
            #if NUNIT
            Assert.AreEqual(x22_standard_deviation, 15.67, 0.01);
            #elif XUNIT
            Assert.Equal(x22_standard_deviation, 15.67, 2);
            #elif MSTEST
            #endif

            return;
        }

        [Test()]
        public void Data_d2_MeanArithmetic_Average()
        {
            // Act
            double d2_average = d2.Average();

            // Assert
            #if NUNIT
            Assert.AreEqual(d2_average, 5.08, 0.01);
            #elif XUNIT
            Assert.Equal(d2_average, 5.08, 2);
            #elif MSTEST
            #endif

            return;
        }

        [Test()]
        public void Data_d2_Min()
        {
            // Act
            double d2_min = d2.Min();

            // Assert
            #if NUNIT
            Assert.AreEqual(d2_min, 0.8, 0.01);
            #elif XUNIT
            Assert.Equal(d2_min, 0.8, 2);
            #elif MSTEST
            #endif

            return;
        }

        [Test()]
        public void Data_d2_Max()
        {
            // Act
            double d2_max = d2.Max();

            // Assert
            #if NUNIT
            Assert.AreEqual(d2_max, 9.68, 0.01);
            #elif XUNIT
            Assert.Equal(d2_max, 9.68, 2);
            #elif MSTEST
            #endif

            return;
        }

        [Test()]
        public void Data_d2_StandardDeviationSample()
        {
            // Act
            double d2_standard_deviation = d2.StandardDeviationSample();

            // Assert
            #if NUNIT
            Assert.AreEqual(d2_standard_deviation, 3.01, 0.01);
            #elif XUNIT
            Assert.Equal(d2_standard_deviation, 3.01, 2);
            #elif MSTEST
            #endif

            return;
        }

        [Test()]
        public void Data_x1_x22_Correlation()
        {
            // Act
            double correlation_x1_x2_01 = x1.Correlation(x22);
            // Assert
            #if NUNIT
            Assert.AreEqual(correlation_x1_x2_01, 0.99, 0.01);
            #elif XUNIT
            Assert.Equal(correlation_x1_x2_01, 0.99, 2);
            #elif MSTEST
            #endif

            return;
        }

        [Test()]
        public void Data_x1_x22_CorrelationOptimized()
        {

            // Act
            double correlation_x1_x2_02 = x1.CorrelationOptimized(x22);
            // Assert
            #if NUNIT
            Assert.AreEqual(correlation_x1_x2_02, 0.99, 0.01);
            #elif XUNIT
            Assert.Equal(correlation_x1_x2_02, 0.99, 2);
            #elif MSTEST
            #endif

            return;
        }

        [Test()]
        public void Data_x1_d2_Correlation()
        {
            // Act
            double correlation_x1_d2_01 = x1.Correlation(d2);
            // Assert
            #if NUNIT
            Assert.AreEqual(correlation_x1_d2_01, -0.7, 0.01);
            #elif XUNIT
            Assert.Equal(correlation_x1_d2_01, -0.7, 2);
            #elif MSTEST
            #endif

            return;
        }

        [Test()]
        public void Data_x1_d2_CorrelationOptimized()
        {
            // Act
            double correlation_x1_d2_02 = x1.CorrelationOptimized(d2);
            // Assert
            #if NUNIT
            Assert.AreEqual(correlation_x1_d2_02, -0.7, 0.01);
            #elif XUNIT
            Assert.Equal(correlation_x1_d2_02, -0.7, 2);
            #elif MSTEST
            #endif

            return;
        }

        [Test()]
        public void Data03()
        {
            // Act
            double x23_average = x23.Average();
            
            // Assert
            #if NUNIT
            Assert.AreEqual(x23_average, 64.3266, 0.0001);
            #elif XUNIT
            Assert.Equal(x23_average, 64.3466, 5);
            #elif MSTEST
            #endif

            // Act
            double x23_standard_deviation = x23.StandardDeviationSample();

            // Assert
            #if NUNIT
            Assert.AreEqual(x23_standard_deviation, 17.73, 0.01);
            #elif XUNIT
            Assert.Equal(x23_standard_deviation, 17.73, 2);
            #elif MSTEST
            #endif

            // Act
            double x23_min = x23.Min();

            // Assert
            #if NUNIT
            Assert.AreEqual(x23_min, 33.95, 0.01);
            #elif XUNIT
            Assert.Equal(x23_min, 33.95, 2);
            #elif MSTEST
            #endif

            // Act
            double x23_max = x23.Max();

            // Assert
            #if NUNIT
            Assert.AreEqual(x23_max, 94.62, 0.01);
            #elif XUNIT
            Assert.Equal(x23_max, 94.62, 2);
            #elif MSTEST
            #endif

            // Arrange
            List<double> d3 = new List<double>();
            for (int i = 0; i < x1.Count; i++)
            {
                d3.Add(x23[i] - x1[i]);
            }

            // Act
            double d3_average = d3.Average();

            // Assert
            #if NUNIT
            Assert.AreEqual(d3_average, 5.54, 0.01);
            #elif XUNIT
            Assert.Equal(d3_average, 5.54, 2);
            #elif MSTEST
            #endif

            // Act
            double d3_min = d3.Min();
            
            // Assert
            #if NUNIT
            Assert.AreEqual(d3_min, 0.3, 0.01);
            #elif XUNIT
            Assert.Equal(d3_min, 0.3, 2);
            #elif MSTEST
            #endif

            // Act
            double d3_max = d3.Max();

            // Assert
            #if NUNIT
            Assert.AreEqual(d3_max, 11.56, 0.01);
            #elif XUNIT
            Assert.Equal(d3_max, 11.56, 2);
            #elif MSTEST
            #endif

            // Act
            double d3_standard_deviation = d3.StandardDeviationSample();

            // Assert
            #if NUNIT
            Assert.AreEqual(d3_standard_deviation, 3.79, 0.01);
            #elif XUNIT
            Assert.Equal(d3_standard_deviation, 3.79, 2);
            #elif MSTEST
            #endif


            // Act
            double correlation_x1_x2_01 = x1.Correlation(x23);

            // Assert
            #if NUNIT
            Assert.AreEqual(correlation_x1_x2_01, 0.98, 0.01);
            #elif XUNIT
            Assert.Equal(correlation_x1_x2_01, 0.98, 2);
            #elif MSTEST
            #endif

            // Act
            double correlation_x1_x2_02 = x1.CorrelationOptimized(x23);

            // Assert
            #if NUNIT
            Assert.AreEqual(correlation_x1_x2_02, 0.98, 0.01);
            #elif XUNIT
            Assert.Equal(correlation_x1_x2_02, 0.98, 2);
            #elif MSTEST
            #endif

            // Act
            double correlation_x1_d3_01 = x1.Correlation(d3);

            // Assert
            #if NUNIT
            Assert.AreEqual(correlation_x1_d3_01, -0.1, 0.1);
            #elif XUNIT
            Assert.Equal(correlation_x1_d3_01, -0.1, 1);
            #elif MSTEST
            #endif

            // Act
            double correlation_x1_d3_02 = x1.CorrelationOptimized(d3);

            // Assert
            #if NUNIT
            Assert.AreEqual(correlation_x1_d3_02, -0.1, 0.1);
            #elif XUNIT
            Assert.Equal(correlation_x1_d3_02, -0.1, 1);
            #elif MSTEST
            #endif


            return;
        }

    }
}
