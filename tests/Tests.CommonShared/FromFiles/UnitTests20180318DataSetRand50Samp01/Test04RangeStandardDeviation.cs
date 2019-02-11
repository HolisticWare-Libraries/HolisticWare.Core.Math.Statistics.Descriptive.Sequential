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

#if XUNIT
using Xunit;
// NUnit aliases
using Test = Xunit.FactAttribute;
using OneTimeSetUp = HolisticWare.Core.Testing.UnitTests.UnitTestsCompatibilityAliasAttribute;
// XUnit aliases
using TestClass = HolisticWare.Core.Testing.UnitTests.UnitTestsCompatibilityAliasAttribute;
using TestContext = HolisticWare.Core.Testing.UnitTests.TestContext;
#elif NUNIT
using NUnit.Framework;
// MSTest aliases
using TestInitialize = NUnit.Framework.SetUpAttribute;
using TestProperty = NUnit.Framework.PropertyAttribute;
using TestClass = HolisticWare.Core.Testing.UnitTests.UnitTestsCompatibilityAliasAttribute;
using TestMethod = NUnit.Framework.TestAttribute;
using TestCleanup = NUnit.Framework.TearDownAttribute;
// XUnit aliases
using Fact = NUnit.Framework.TestAttribute;
#elif MSTEST
using Microsoft.VisualStudio.TestTools.UnitTesting;
// NUnit aliases
using Test = Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute;
using OneTimeSetUp = Microsoft.VisualStudio.TestTools.UnitTesting.ClassInitializeAttribute;
// XUnit aliases
using Fact = Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute;
#endif

#if BENCHMARKDOTNET
using BenchmarkDotNet.Running;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Attributes.Jobs;
#else
using Benchmark = HolisticWare.Core.Testing.BenchmarkTests.Benchmark;
using ShortRunJob = HolisticWare.Core.Testing.BenchmarkTests.ShortRunJob;
#endif

using System;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;
using System.Threading.Tasks;
using System.IO;
using System.Reflection;
using System.Collections.ObjectModel;

using Core.Math.Statistics.Descriptive.Sequential;

namespace UnitTests.Core.Math.Statistics.Descriptive.Sequential.Sync 
{
    public partial class UnitTests20180318DataSetRand50Samp01 
    
        {

        [Test()]
        public void Range_rVAR1() 
        
        {

            data_rVAR1 =
                                    from row in RandSamp1DataTable
                                    select row.rVAR1
                                        ;


            (double Min, double Max, double Delta) range_rVAR1 = data_rVAR1.Range();

            // Assert
            #if NUNIT
            Assert.AreEqual(range_rVAR1.Min, 126.11);
            Assert.AreEqual(range_rVAR1.Max, 220.07);
            Assert.AreEqual(range_rVAR1.Delta, 93.96);
            #elif XUNIT
            Assert.Equal(126.11, range_rVAR1.Min);
            Assert.Equal(220.07, range_rVAR1.Max);
            Assert.Equal(93.96, range_rVAR1.Delta);
            #elif MSTEST
            Assert.AreEqual(range_rVAR1.Min, 126.11);
            Assert.AreEqual(range_rVAR1.Max, 220.07);
            Assert.AreEqual(range_rVAR1.Delta, 93.96);
            #endif

            return;
        }


        [Test()]
        public void StandardDeviationSample_rVAR1() 
        
        {

            data_rVAR1 =
                                    from row in RandSamp1DataTable
                                    select row.rVAR1
                                        ;


            double standard_deviation_sample_rVAR1 = data_rVAR1.StandardDeviationSample();

            // Assert
            #if NUNIT
            Assert.AreEqual(standard_deviation_sample_rVAR1, 19.74941, 0.00001);
            #elif XUNIT
            Assert.Equal(19.74941, standard_deviation_sample_rVAR1, 5);
            #elif MSTEST
            Assert.AreEqual(standard_deviation_sample_rVAR1, 19.74941, 0.00001);
            #endif

            return;
        }


        [Test()]
        public void StandardDeviationPopulation_rVAR1() 
        
        {

            data_rVAR1 =
                                    from row in RandSamp1DataTable
                                    select row.rVAR1
                                        ;


            double standard_deviation_population_rVAR1 = data_rVAR1.StandardDeviationPopulation();

            // Assert
            #if NUNIT
            Assert.AreEqual(standard_deviation_population_rVAR1, 19.55092, 0.00001);
            #elif XUNIT
            Assert.Equal(19.55092, standard_deviation_population_rVAR1, 5);
            #elif MSTEST
            Assert.AreEqual(standard_deviation_population_rVAR1, 19.55092, 0.00001);
            #endif

            return;
        }
    }
}