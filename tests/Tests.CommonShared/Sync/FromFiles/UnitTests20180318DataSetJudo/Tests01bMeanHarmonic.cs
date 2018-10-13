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
        public void MeanHarmonic_ONT()
        {
            data_ont =
                                    from row in JudoDataTable
                                    select row.ONT
                                        ;

            double mean_ONT_h = data_ont.MeanHarmonic();

            // Assert
            #if NUNIT
            Assert.AreEqual(mean_ONT_h, 15.29, 0.01);
            #elif XUNIT
            Assert.Equal(15.29, mean_ONT_h, 2);
            #elif MSTEST
            Assert.AreEqual(mean_ONT_h, 15.29, 0.01);
            #endif

            return;
        }


        [Test()]
        public void MeanHarmonic_OUZ()
        {
            data_ouz =
                                    from row in JudoDataTable
                                    select row.OUZ
                                        ;

            double mean_OUZ_h = data_ouz.MeanHarmonic();

            // Assert
            #if NUNIT
            Assert.AreEqual(mean_OUZ_h, 3.82, 0.01);
            #elif XUNIT
            Assert.Equal(3.82, mean_OUZ_h, 2);
            #elif MSTEST
            Assert.AreEqual(mean_OUZ_h, 3.82, 0.01);
            #endif


            return;
        }


        [Test()]
        public void MeanHarmonic_NEB()
        {
            data_neb =
                                from row in JudoDataTable
                                select row.NEB
                                    ;

            double mean_NEB_h = data_neb.MeanHarmonic();

            // Assert
            #if NUNIT
            Assert.AreEqual(mean_NEB_h, 8.65, 0.01);
            #elif XUNIT
            Assert.Equal(8.65, mean_NEB_h, 2);
            #elif MSTEST
            Assert.AreEqual(mean_NEB_h, 8.65, 0.01);
            #endif


            return;
        }


        [Test()]
        public void MeanHarmonic_SKL()
        {
            data_skl =
                                from row in JudoDataTable
                                select row.SKL
                                    ;

            double mean_SKL_h = data_skl.MeanHarmonic();

            // Assert
            #if NUNIT
            Assert.AreEqual(mean_SKL_h, 8.67, 0.01);
            #elif XUNIT
            Assert.Equal(8.67, mean_SKL_h, 2);
            #elif MSTEST
            Assert.AreEqual(mean_SKL_h, 8.67, 0.01);
            #endif

            return;
        }


        [Test()]
        public void MeanHarmonic_TRB()
        {
            data_trb =
                                from row in JudoDataTable
                                select row.TRB
                                    ;

            double mean_TRB_h = data_trb.MeanHarmonic();

            // Assert
            #if NUNIT
            Assert.AreEqual(mean_TRB_h, 27.97, 0.01);
            #elif XUNIT
            Assert.Equal(27.97, mean_TRB_h, 2);
            #elif MSTEST
            Assert.AreEqual(mean_TRB_h, 27.97, 0.01);
            #endif

            return;
        }


        [Test()]
        public void MeanHarmonic_CUC()
        {
            data_cuc =
                                from row in JudoDataTable
                                select row.CUC
                                    ;

            double mean_CUC_h = data_cuc.MeanHarmonic();

            // Assert
            #if NUNIT
            Assert.AreEqual(mean_CUC_h, 166.05, 0.01);
            #elif XUNIT
            Assert.Equal(166.05, mean_CUC_h, 2);
            #elif MSTEST
            Assert.AreEqual(mean_CUC_h, 166.05, 0.01);
            #endif

            return;
        }


        [Test()]
        public void MeanHarmonic_SDM()
        {
            data_sdm =
                                from row in JudoDataTable
                                select row.SDM
                                    ;

            double mean_SDM_h = data_sdm.MeanHarmonic();

            // Assert
            #if NUNIT
            Assert.AreEqual(mean_SDM_h, 175.63, 0.01);
            #elif XUNIT
            Assert.Equal(175.63, mean_SDM_h, 2);
            #elif MSTEST
            Assert.AreEqual(mean_SDM_h, 175.63, 0.01);
            #endif

            return;
        }

        [Test()]
        public void MeanHarmonic_BML()
        {
            data_bml =
                                from row in JudoDataTable
                                select row.BML
                                    ;

            double mean_BML_h = data_bml.MeanHarmonic();

            // Assert
            #if NUNIT
            Assert.AreEqual(mean_BML_h, 512.91, 0.01);
            #elif XUNIT
            Assert.Equal(512.91, mean_BML_h, 2);
            #elif MSTEST
            Assert.AreEqual(mean_BML_h, 512.91, 0.01);
            #endif

            return;
        }
    }
}
