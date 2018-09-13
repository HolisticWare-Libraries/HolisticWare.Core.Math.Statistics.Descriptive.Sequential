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
#elif NUNIT
using NUnit.Framework;
// MSTest aliases
using TestInitialize = NUnit.Framework.SetUpAttribute;
using TestProperty = NUnit.Framework.PropertyAttribute;
using TestClass = NUnit.Framework.TestFixtureAttribute;
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

using Core.Math.Statistics.Descriptive.Sequential;

namespace UnitTests.Core.Math.Statistics.Descriptive.Sequential.Sync
{
    public partial class UnitTests20180318DataSetJudo
    {
        [Test()]
        public void MeanArithmetic_ONT()
        {
            data_ONT =
                                    from row in JudoDataTable
                                    select row.ONT
                                        ;

            double mean_ONT_a = data_ONT.MeanArithmetic();

            // Assert
            #if NUNIT
            Assert.AreEqual(mean_ONT_a, 15.93, 0.01);
            #elif XUNIT
            Assert.Equal(15.93, mean_ONT_a, 2);
            #elif MSTEST
            Assert.AreEqual(mean_ONT_a, 15.93, 0.01);
            #endif

            return;
        }


        [Test()]
        public void MeanArithmetic_OUZ()
        {
            data_OUZ =
                                    from row in JudoDataTable
                                    select row.OUZ
                                        ;

            double mean_OUZ_a = data_OUZ.MeanArithmetic();

            // Assert
            #if NUNIT
            Assert.AreEqual(mean_OUZ_a, 3.90, 0.01);
            #elif XUNIT
            Assert.Equal(3.90, mean_OUZ_a, 2);
            #elif MSTEST
            Assert.AreEqual(mean_OUZ_a, 3.90, 0.01);
            #endif

            return;
        }


        [Test()]
        public void MeanArithmetic_NEB()
        {
            data_NEB =
                                    from row in JudoDataTable
                                    select row.NEB
                                        ;

            double mean_NEB_a = data_NEB.MeanArithmetic();

            // Assert
            #if NUNIT
            Assert.AreEqual(mean_NEB_a, 10.10, 0.01);
            #elif XUNIT
            Assert.Equal(10.10, mean_NEB_a, 2);
            #elif MSTEST
            Assert.AreEqual(mean_NEB_a, 10.10, 0.01);
            #endif

            return;
        }


        [Test()]
        public void MeanArithmetic_SKL()
        {
            data_SKL =
                                    from row in JudoDataTable
                                    select row.SKL
                                        ;

            double mean_SKL_a = data_SKL.MeanArithmetic();

            // Assert
            #if NUNIT
            Assert.AreEqual(mean_SKL_a, 16.57, 0.01);
            #elif XUNIT
            Assert.Equal(16.57, mean_SKL_a, 2);
            #elif MSTEST
            Assert.AreEqual(mean_SKL_a, 16.57, 0.01);
            #endif

            return;
        }


        [Test()]
        public void MeanArithmetic_TRB()
        {
            data_TRB =
                                    from row in JudoDataTable
                                    select row.TRB
                                        ;

            double mean_TRB_a = data_TRB.MeanArithmetic();

            // Assert
            #if NUNIT
            Assert.AreEqual(mean_TRB_a, 35.38, 0.01);
            #elif XUNIT
            Assert.Equal(35.38, mean_TRB_a, 2);
            #elif MSTEST
            Assert.AreEqual(mean_TRB_a, 35.38, 0.01);
            #endif

            return;
        }


        [Test()]
        public void MeanArithmetic_CUC()
        {
            data_CUC =
                                    from row in JudoDataTable
                                    select row.CUC
                                        ;

            double mean_CUC_a = data_CUC.MeanArithmetic();

            // Assert
            #if NUNIT
            Assert.AreEqual(mean_CUC_a, 210.40, 0.01);
            #elif XUNIT
            Assert.Equal(210.40, mean_CUC_a, 2);
            #elif MSTEST
            Assert.AreEqual(mean_CUC_a, 210.40, 0.01);
            #endif

            return;
        }


        [Test()]
        public void MeanArithmetic_SDM()
        {
            data_SDM =
                                    from row in JudoDataTable
                                    select row.SDM
                                        ;

            double mean_SDM_a = data_SDM.MeanArithmetic();

            // Assert
            #if NUNIT
            Assert.AreEqual(mean_SDM_a, 177.30, 0.01);
            #elif XUNIT
            Assert.Equal(177.33, mean_SDM_a, 2);
            #elif MSTEST
            Assert.AreEqual(mean_SDM_a, 177.30, 0.01);
            #endif

            return;
        }


        [Test()]
        public void MeanArithmetic_BML()
        {
            data_BML =
                                    from row in JudoDataTable
                                    select row.BML
                                        ;

            double mean_BML_a = data_BML.MeanArithmetic();

            // Assert
            #if NUNIT
            Assert.AreEqual(mean_BML_a, 530.20, 0.01);
            #elif XUNIT
            Assert.Equal(530.20, mean_BML_a, 2);
            #elif MSTEST
            Assert.AreEqual(mean_BML_a, 530.20, 0.01);
            #endif

            return;
        }
    }
}
