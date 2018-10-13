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
    public partial class UnitTests20180318DataSetBasketball
    {

        [Test()]
        public void Variance_Points2Success()
        {
            data_2pts_success =
                                    from row in JudoDataTable
                                    select row.Points2Success
                                        ;

            double variance_2s = data_2pts_success.VarianceSample();

            // Assert
            #if NUNIT
            Assert.AreEqual(variance_2s, 47.218, 0.001);
            #elif XUNIT
            Assert.Equal(47.218, variance_2s, 3);
            #elif MSTEST
            Assert.AreEqual(variance_2s, 47.218, 0.001);
            #endif

            return;
        }

            [Test()]
        public void Variance_Points3Success()
        {
            data_3pts_success =
                                    from row in JudoDataTable
                                    select row.Points3Success
                                        ;

            double variance_3pts_success = data_3pts_success.VarianceSample();

            // Assert
            #if NUNIT
            Assert.AreEqual(variance_3pts_success, 11.983, 0.001);
            #elif XUNIT
            Assert.Equal(11.983, variance_3pts_success, 3);
            #elif MSTEST
            Assert.AreEqual(variance_3pts_success, 11.983, 0.001);
            #endif


            return;
        }


        [Test()]
        public void Variance_Points2Fail()
        {
            data_2pts_fail =
                                from row in JudoDataTable
                                select row.Points2Fail
                                    ;

            double variance_2f = data_2pts_fail.VarianceSample();

            // Assert
            #if NUNIT
            Assert.AreEqual(variance_2f, 42.943, 0.001);
            #elif XUNIT
            Assert.Equal(42.943, variance_2f, 3);
            #elif MSTEST
            Assert.AreEqual(variance_2f, 42.943, 0.001);
            #endif


            return;
        }


        [Test()]
        public void Variance_Points3Fail()
        {
            data_3pts_fail =
                                from row in JudoDataTable
                                select row.Points3Fail
                                    ;

            double variance_3f = data_3pts_fail.VarianceSample();

            // Assert
            #if NUNIT
            Assert.AreEqual(variance_3f, 21.003, 0.001);
            #elif XUNIT
            Assert.Equal(21.003, variance_3f, 3);
            #elif MSTEST
            Assert.AreEqual(variance_3f, 21.003, 0.001);
            #endif

            return;
        }


        [Test()]
        public void Variance_FreeThrowFail()
        {
            data_free_throw_fail =
                                from row in JudoDataTable
                                select row.FreeThrowFail
                                    ;

            double variance_ftf = data_free_throw_fail.VarianceSample();

            // Assert
            #if NUNIT
            Assert.AreEqual(variance_ftf, 10.334, 0.001);
            #elif XUNIT
            Assert.Equal(10.334, variance_ftf, 3);
            #elif MSTEST
            Assert.AreEqual(variance_ftf, 10.334, 0.001);
            #endif

            return;
        }


        [Test()]
        public void Variance_FreeThrowSuccess()
        {
            data_free_throw_success =
                                from row in JudoDataTable
                                select row.FreeThrowSuccess
                                    ;

            double variance_fts = data_free_throw_success.VarianceSample();

            // Assert
            #if NUNIT
            Assert.AreEqual(variance_fts, 56.669, 0.001);
            #elif XUNIT
            Assert.Equal(56.669, variance_fts, 3);
            #elif MSTEST
            Assert.AreEqual(variance_fts, 56.669, 0.001);
            #endif

            return;
        }


        [Test()]
        public void Variance_JumpsOffensive()
        {
            data_jumps_offensive =
                                from row in JudoDataTable
                                select row.JumpsOffensive
                                    ;

            double variance_off = data_jumps_offensive.VarianceSample();

            // Assert
            #if NUNIT
            Assert.AreEqual(variance_off, 19.054, 0.001);
            #elif XUNIT
            Assert.Equal(19.054, variance_off, 3);
            #elif MSTEST
            Assert.AreEqual(variance_off, 19.054, 0.001);
            #endif

            return;
        }

        [Test()]
        public void Variance_JumpsDefensive()
        {
            data_jumps_defensive =
                                from row in JudoDataTable
                                select row.JumpsDefensive
                                    ;

            double variance_def = data_jumps_defensive.VarianceSample();

            // Assert
            #if NUNIT
            Assert.AreEqual(variance_def, 35.929, 0.001);
            #elif XUNIT
            Assert.Equal(35.929, variance_def, 3);
            #elif MSTEST
            Assert.AreEqual(variance_def, 35.929, 0.001);
            #endif

            return;
        }

        [Test()]
        public void Variance_Assistence()
        {
            data_assistence =
                                from row in JudoDataTable
                                select row.Assistence
                                    ;

            double variance_assist = data_assistence.VarianceSample();

            // Assert
            #if NUNIT
            Assert.AreEqual(variance_assist, 31.175, 0.001);
            #elif XUNIT
            Assert.Equal(31.175, variance_assist, 3);
            #elif MSTEST
            Assert.AreEqual(variance_assist, 31.175, 0.001);
            #endif

            return;
        }

        [Test()]
        public void Variance_PersonalFaults()
        {
            data_personal_faults =
                                from row in JudoDataTable
                                select row.PersonalFaults
                                    ;

            double variance_pf = data_personal_faults.VarianceSample();

            // Assert
            #if NUNIT
            Assert.AreEqual(variance_pf, 27.819, 0.001);
            #elif XUNIT
            Assert.Equal(27.819, variance_pf, 3);
            #elif MSTEST
            Assert.AreEqual(variance_pf, 27.819, 0.001);
            #endif

            return;
        }


        [Test()]
        public void Variance_BallsLost()
        {
            data_balls_lost =
                                from row in JudoDataTable
                                select row.BallsLost
                                    ;

            double variance_bl = data_balls_lost.VarianceSample();

            // Assert
            #if NUNIT
            Assert.AreEqual(variance_bl, 24.728, 0.001);
            #elif XUNIT
            Assert.Equal(24.728, variance_bl, 3);
            #elif MSTEST
            Assert.AreEqual(variance_bl, 24.728, 0.001);
            #endif

            return;
        }


        [Test()]
        public void Variance_BallsStolen()
        {
            data_balls_stolen =
                                from row in JudoDataTable
                                select row.BallsStolen
                                    ;

            double variance_bs = data_balls_stolen.VarianceSample();

            // Assert
            #if NUNIT
            Assert.AreEqual(variance_bs, 11.474, 0.001);
            #elif XUNIT
            Assert.Equal(11.474, variance_bs, 3);
            #elif MSTEST
            Assert.AreEqual(variance_bs, 11.474, 0.001);
            #endif

            return;
        }


        [Test()]
        public void Variance_Blocks()
        {
            data_blocks =
                                from row in JudoDataTable
                                select row.Blocks
                                    ;

            double variance_block = data_blocks.VarianceSample();

            // Assert
            #if NUNIT
            Assert.AreEqual(variance_block, 5.634, 0.001);
            #elif XUNIT
            Assert.Equal(5.634, variance_block, 3);
            #elif MSTEST
            Assert.AreEqual(variance_block, 5.634, 0.001);
            #endif

            return;
        }
    }
}
