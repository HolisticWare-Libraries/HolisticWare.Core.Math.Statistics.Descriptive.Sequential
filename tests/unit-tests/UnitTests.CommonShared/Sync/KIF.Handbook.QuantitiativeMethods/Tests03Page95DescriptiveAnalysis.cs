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
// NUnit aliases
using Test = Xunit.FactAttribute;
using OneTimeSetUp = HolisticWare.Core.Testing.UnitTestsCompatibilityAliasAttribute;
// XUnit aliases
using TestClass = HolisticWare.Core.Testing.UnitTestsCompatibilityAliasAttribute;
#elif NUNIT
using NUnit.Framework;
// MSTest aliases
using TestInitialize = NUnit.Framework.SetUpAttribute;
using TestProperty = NUnit.Framework.PropertyAttribute;
using TestClass = NUnit.Framework.TestFixtureAttribute;
using TestMethod = NUnit.Framework.TestAttribute;
using TestCleanup = NUnit.Framework.TearDownAttribute;
// XUnit aliases
using Fact=NUnit.Framework.TestAttribute;
#elif MSTEST
using Microsoft.VisualStudio.TestTools.UnitTesting;
// NUnit aliases
using Test = Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute;
using OneTimeSetUp = Microsoft.VisualStudio.TestTools.UnitTesting.ClassInitializeAttribute;
// XUnit aliases
using Fact = Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute;
#endif

using Core.Math.Statistics.Descriptive.Sequential;

namespace UnitTests.Core.Math.Statistics.Descriptive.Sequential.Sync
{
    [TestClass] // for MSTest - NUnit [TestFixture] and XUnit not needed
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
            Assert.Equal(58.7787, x1_average, 4);
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
            Assert.Equal(17.64, x1_standard_deviation, 2);
            Assert.Equal(17.6391, x1_standard_deviation, 4);
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
            Assert.Equal(33.65, x1_min, 2);
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
            Assert.Equal(93.51, x1_max, 2);
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
            Assert.Equal(63.779, x21_average, 3);
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
            Assert.Equal(17.6391, x21_standard_deviation, 4);
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
            Assert.Equal(38.65, x21_min, 2);
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
            Assert.Equal(98.51, x21_max, 2);
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
            Assert.Equal(5.0, d1_average, 2);
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
            Assert.Equal(5.0, d1_min, 2);
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
            Assert.Equal(5.0, d1_max, 2);
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
            Assert.Equal(0.0, d1_standard_deviation_sample, 2);
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
            Assert.Equal(0.0, d1_standard_deviation_population, 2);
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
            Assert.Equal(1.0, correlation_x1_x2_01, 2);
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
            Assert.Equal(1.0, correlation_x1_x2_02, 2);
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
            Assert.Equal(0.0, correlation_x1_d1_01, 2);
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
            Assert.Equal(0.0, correlation_x1_d1_02, 2);
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
            Assert.Equal(63.87, x22_average, 2);
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
            Assert.Equal(39.51, x22_min, 2);
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
            Assert.Equal(94.31, x22_max, 2);
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
            Assert.Equal(15.67, x22_standard_deviation, 2);
            #elif MSTEST
            #endif

            return;
        }

        [Test()]
        public void Data_d2_MeanArithmetic_Average()
        {
            // Act
            double d2_mean_arithmetic = d2.MeanArithmetic();
            double d2_average = d2.Average();

            // Assert
            #if NUNIT
            Assert.AreEqual(d2_mean_arithmetic, 5.087, 0.001);
            Assert.AreEqual(d2_average, 5.087, 0.001);
            Assert.AreEqual(d2_average, d2_mean_arithmetic, 0.001);
            #elif XUNIT
            Assert.Equal(5.087, d2_mean_arithmetic, 3);
            Assert.Equal(5.087, d2_average, 3);
            Assert.Equal(d2_mean_arithmetic, d2_average, 3);
            #elif MSTEST
            Assert.AreEqual(d2_mean_arithmetic, 5.087, 0.001);
            Assert.AreEqual(d2_average, 5.087, 0.001);
            Assert.AreEqual(d2_average, d2_mean_arithmetic, 0.001);
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
            Assert.Equal(0.8, d2_min, 2);
            #elif MSTEST
            Assert.AreEqual(d2_min, 0.8, 0.01);
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
            Assert.Equal(9.68, d2_max, 2);
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
            Assert.Equal(3.01, d2_standard_deviation, 2);
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
            Assert.Equal(0.99, correlation_x1_x2_01, 2);
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
            Assert.Equal(0.99, correlation_x1_x2_02, 2);
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
            Assert.Equal(-0.7, correlation_x1_d2_01, 2);
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
            Assert.Equal(-0.7, correlation_x1_d2_02, 2);
            #elif MSTEST
            #endif

            return;
        }

        [Test()]
        public void Data_x23_MeanArithmetic_Average()
        {
            // Act
            double x23_mean_arithmetic = x23.MeanArithmetic();
            double x23_average = x23.Average();
            
            // Assert
            #if NUNIT
            Assert.AreEqual(x23_mean_arithmetic, 64.3266, 0.0001);
            Assert.AreEqual(x23_average, 64.3266, 0.0001);
            #elif XUNIT
            Assert.Equal(64.32667, x23_mean_arithmetic, 5);
            Assert.Equal(64.32667, x23_average, 5);
            #elif MSTEST
            #endif

            return;
        }

        [Test()]
         public void Data_x23_StandardDeviationSample()
        {
            // Act
            double x23_standard_deviation = x23.StandardDeviationSample();

            // Assert
            #if NUNIT
            Assert.AreEqual(x23_standard_deviation, 17.73, 0.01);
            #elif XUNIT
            Assert.Equal(17.74, x23_standard_deviation, 2);
            Assert.Equal(17.73996, x23_standard_deviation, 5);
            #elif MSTEST
            #endif

            return;
        }

        [Test()]
        public void Data_x23_Min()
        {
            // Act
            double x23_min = x23.Min();

            // Assert
            #if NUNIT
            Assert.AreEqual(x23_min, 33.95, 0.01);
            #elif XUNIT
            Assert.Equal(33.95, x23_min, 2);
            #elif MSTEST
            #endif
            
            return;
        }

        [Test()]
        public void Data_x23_Max()
        {

            // Act
            double x23_max = x23.Max();

            // Assert
            #if NUNIT
            Assert.AreEqual(x23_max, 94.62, 0.01);
            #elif XUNIT
            Assert.Equal(94.62, x23_max, 2);
            #elif MSTEST
            #endif

            return;
        }

        [Test()]
        public void Data_d3_MeanArithmetic_Average()
        {
            // Act
            double d3_average = d3.Average();

            // Assert
            #if NUNIT
            Assert.AreEqual(d3_average, 5.548, 0.001);
            #elif XUNIT
            Assert.Equal(5.548, d3_average, 3);
            #elif MSTEST
            Assert.AreEqual(d3_average, 5.548, 0.001);
            #endif

            return;
        }

        [Test()]
        public void Data_d3_Min()
        {
            // Act
            double d3_min = d3.Min();
            
            // Assert
            #if NUNIT
            Assert.AreEqual(d3_min, 0.3, 0.01);
            #elif XUNIT
            Assert.Equal(0.3, d3_min, 2);
            #elif MSTEST
            Assert.AreEqual(d3_min, 0.3, 0.01);
            #endif
            
            return;
        }

        [Test()]
        public void Data_d3_Max()
        {

            // Act
            double d3_max = d3.Max();

            // Assert
            #if NUNIT
            Assert.AreEqual(d3_max, 11.56, 0.01);
            #elif XUNIT
            Assert.Equal(11.56, d3_max, 2);
            #elif MSTEST
            #endif

            return;
        }

        [Test()]
        public void Data_d3_StandardDeviation()
        {
            // Act
            double d3_standard_deviation = d3.StandardDeviationSample();

            // Assert
            #if NUNIT
            Assert.AreEqual(d3_standard_deviation, 3.79, 0.01);
            #elif XUNIT
            Assert.Equal(3.7956, d3_standard_deviation, 4);
            #elif MSTEST
            #endif

            return;
        }

        [Test()]
            public void Data_x1_x23_Correlation()
        {
            // Act
            double correlation_x1_x2_01 = x1.Correlation(x23);

            // Assert
            #if NUNIT
            Assert.AreEqual(correlation_x1_x2_01, 0.98, 0.01);
            #elif XUNIT
            Assert.Equal(0.98, correlation_x1_x2_01, 2);
            #elif MSTEST
            #endif


            return;
        }

        [Test()]
        public void Data_x1_x23_CorrelationOptimized()
        {
            // Act
            double correlation_x1_x2_02 = x1.CorrelationOptimized(x23);

            // Assert
            #if NUNIT
            Assert.AreEqual(correlation_x1_x2_02, 0.98, 0.01);
            #elif XUNIT
            Assert.Equal(0.98, correlation_x1_x2_02, 2);
            #elif MSTEST
            #endif

            return;
        }

        [Test()]
        public void Data_x1_d3_Correlation()
        {

            // Act
            double correlation_x1_d3_01 = x1.Correlation(d3);

            // Assert
            #if NUNIT
            Assert.AreEqual(correlation_x1_d3_01, -0.1, 0.1);
            #elif XUNIT
            Assert.Equal(-0.1, correlation_x1_d3_01, 1);
            #elif MSTEST
            #endif

            return;
        }

        [Test()]
        public void Data_x1_d3_CorrelationOptimized()
        {

            // Act
            double correlation_x1_d3_02 = x1.CorrelationOptimized(d3);

            // Assert
            #if NUNIT
            Assert.AreEqual(correlation_x1_d3_02, -0.1, 0.1);
            #elif XUNIT
            Assert.Equal(-0.1, correlation_x1_d3_02, 1);
            #elif MSTEST
            #endif


            return;
        }

    }
}
