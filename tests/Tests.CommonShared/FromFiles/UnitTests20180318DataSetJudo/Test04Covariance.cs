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

namespace UnitTests.Core.Math.Statistics.Descriptive.Sequential.Sync {
    public partial class UnitTests20180318DataSetJudo {

        [Test()]
        public void Covariance_ONT_OUZ() {

            data_ont =
                                    from row in JudoDataTable
                                    select row.ONT
                                        ;

            data_ouz =
                                    from row in JudoDataTable
                                    select row.OUZ
                                        ;


            double covariance_ONT_OUZ = data_ont.Covariance(data_ouz);

            // Assert
            #if NUNIT
            Assert.AreEqual(covariance_ONT_OUZ, 1.248, 0.001);
            #elif XUNIT
            Assert.Equal(1.248, covariance_ONT_OUZ, 3);
            #elif MSTEST
            Assert.AreEqual(covariance_ONT_OUZ, 1.248, 0.001);
            #endif

            return;
        }

        [Test()]
        public void Covariance_ONT_NEB() {

            data_ont =
                                    from row in JudoDataTable
                                    select row.ONT
                                        ;

            data_neb =
                                    from row in JudoDataTable
                                    select row.NEB
                                        ;


            double covariance_ONT_NEB = data_ont.Covariance(data_neb);

            // Assert
            #if NUNIT
            Assert.AreEqual(covariance_ONT_NEB, -3.927, 0.001);
            #elif XUNIT
            Assert.Equal(-3.927, covariance_ONT_NEB, 3);
            #elif MSTEST
            Assert.AreEqual(covariance_ONT_NEB, -3.927, 0.001);
            #endif

            return;
        }


        [Test()]
        public void Covariance_ONT_SKL() {

            data_ont =
                                    from row in JudoDataTable
                                    select row.ONT
                                        ;

            data_skl =
                                    from row in JudoDataTable
                                    select row.SKL
                                        ;


            double covariance_ONT_SKL = data_ont.Covariance(data_skl);

            // Assert
            #if NUNIT
            Assert.AreEqual(covariance_ONT_SKL, -10.649, 0.001);
            #elif XUNIT
            Assert.Equal(-10.649, covariance_ONT_SKL, 3);
            #elif MSTEST
            Assert.AreEqual(covariance_ONT_SKL, -10.649, 0.001);
            #endif

            return;
        }


        [Test()]
        public void Covariance_ONT_TRB() {

            data_ont =
                                    from row in JudoDataTable
                                    select row.ONT
                                        ;

            data_trb =
                                    from row in JudoDataTable
                                    select row.TRB
                                        ;


            double covariance_ONT_TRB = data_ont.Covariance(data_trb);

            // Assert
            #if NUNIT
            Assert.AreEqual(covariance_ONT_TRB, -14.515, 0.001);
            #elif XUNIT
            Assert.Equal(-14.515, covariance_ONT_TRB, 3);
            #elif MSTEST
            Assert.AreEqual(covariance_ONT_TRB, -14.515, 0.001);
            #endif

            return;
        }
    }
}