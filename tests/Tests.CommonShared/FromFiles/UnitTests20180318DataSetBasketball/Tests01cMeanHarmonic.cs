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

using Core.Math.Statistics.Descriptive.Sequential;

namespace UnitTests.Core.Math.Statistics.Descriptive.Sequential.Sync
{
    public partial class UnitTests20180318DataSetBasketball
    {

        [Test()]
        public void MeanHarmonic_Points2Success()
        {
            data_2pts_success =
                                    from row in BasketballTeamDataTable
                                    select row.Points2Success
                                        ;

            double mean_2s_a = data_2pts_success.MeanHarmonic();

            // Assert
            #if NUNIT
            Assert.AreEqual(mean_2s_a, 22.30, 0.01);
            #elif XUNIT
            Assert.Equal(22.30, mean_2s_a, 2);
            #elif MSTEST
            Assert.AreEqual(mean_2s_a, 22.30, 0.01);
            #endif

            return;
        }

        //double mean_2_a;

        [Test()]
        public void MeanHarmonic_Points3Success()
        {
            data_3pts_success =
                                    from row in BasketballTeamDataTable
                                    select row.Points3Success
                                        ;

            double mean_a_3pts_success = data_3pts_success.MeanHarmonic();

            // Assert
            #if NUNIT
            Assert.AreEqual(mean_a_3pts_success, 6.68, 0.01);
            #elif XUNIT
            Assert.Equal(6.68, mean_a_3pts_success, 2);
            #elif MSTEST
            Assert.AreEqual(mean_a_3pts_success, 6.68, 0.01);
            #endif


            return;
        }


        [Test()]
        public void MeanHarmonic_Points2Fail()
        {
            data_2pts_fail =
                                from row in BasketballTeamDataTable
                                select row.Points2Fail
                                    ;

            double mean_2f_a = data_2pts_fail.MeanHarmonic();

            // Assert
            #if NUNIT
            Assert.AreEqual(mean_2f_a, 21.54, 0.01);
            #elif XUNIT
            Assert.Equal(21.54, mean_2f_a, 2);
            #elif MSTEST
            Assert.AreEqual(mean_2f_a, 21.54, 0.01);
            #endif


            return;
        }


        [Test()]
        public void MeanHarmonic_Points3Fail()
        {
            data_3pts_fail =
                                from row in BasketballTeamDataTable
                                select row.Points3Fail
                                    ;

            double mean_3f_a = data_3pts_fail.MeanHarmonic();

            // Assert
            #if NUNIT
            Assert.AreEqual(mean_3f_a, 11.73, 0.01);
            #elif XUNIT
            Assert.Equal(11.73, mean_3f_a, 2);
            #elif MSTEST
            Assert.AreEqual(mean_3f_a, 11.73, 0.01);
            #endif

            return;
        }


        [Test()]
        public void MeanHarmonic_FreeThrowFail()
        {
            data_free_throw_fail =
                                from row in BasketballTeamDataTable
                                select row.FreeThrowFail
                                    ;

            double mean_ftf_a = data_free_throw_fail.MeanHarmonic();

            // Assert
            #if NUNIT
            Assert.AreEqual(mean_ftf_a, 6.11, 0.01);
            #elif XUNIT
            Assert.Equal(6.11, mean_ftf_a, 2);
            #elif MSTEST
            Assert.AreEqual(mean_ftf_a, 6.11, 0.01);
            #endif

            return;
        }


        [Test()]
        public void MeanHarmonic_FreeThrowSuccess()
        {
            data_free_throw_success =
                                from row in BasketballTeamDataTable
                                select row.FreeThrowSuccess
                                    ;

            double mean_fts_a = data_free_throw_success.MeanHarmonic();

            // Assert
            #if NUNIT
            Assert.AreEqual(mean_fts_a, 15.73, 0.01);
            #elif XUNIT
            Assert.Equal(15.73, mean_fts_a, 2);
            #elif MSTEST
            Assert.AreEqual(mean_fts_a, 15.73, 0.01);
            #endif

            return;
        }


        [Test()]
        public void MeanHarmonic_JumpsOffensive()
        {
            data_jumps_offensive =
                                from row in BasketballTeamDataTable
                                select row.JumpsOffensive
                                    ;

            double mean_off_a = data_jumps_offensive.MeanHarmonic();

            // Assert
            #if NUNIT
            Assert.AreEqual(mean_off_a, 11.22, 0.01);
            #elif XUNIT
            Assert.Equal(11.22, mean_off_a, 2);
            #elif MSTEST
            Assert.AreEqual(mean_off_a, 11.22, 0.01);
            #endif

            return;
        }

        [Test()]
        public void MeanHarmonic_JumpsDefensive()
        {
            data_jumps_defensive =
                                from row in BasketballTeamDataTable
                                select row.JumpsDefensive
                                    ;

            double mean_def_a = data_jumps_defensive.MeanHarmonic();

            // Assert
            #if NUNIT
            Assert.AreEqual(mean_def_a, 21.77, 0.01);
            #elif XUNIT
            Assert.Equal(21.77, mean_def_a, 2);
            #elif MSTEST
            Assert.AreEqual(mean_def_a, 21.77, 0.01);
            #endif

            return;
        }

        [Test()]
        public void MeanHarmonic_Assistence()
        {
            data_assistence =
                                from row in BasketballTeamDataTable
                                select row.Assistence
                                    ;

            double mean_assist_a = data_assistence.MeanHarmonic();

            // Assert
            #if NUNIT
            Assert.AreEqual(mean_assist_a, 12.65, 0.01);
            #elif XUNIT
            Assert.Equal(12.65, mean_assist_a, 2);
            #elif MSTEST
            Assert.AreEqual(mean_assist_a, 12.65, 0.01);
            #endif

            return;
        }

        [Test()]
        public void MeanHarmonic_PersonalFaults()
        {
            data_personal_faults =
                                from row in BasketballTeamDataTable
                                select row.PersonalFaults
                                    ;

            double mean_pf_a = data_personal_faults.MeanHarmonic();

            // Assert
            #if NUNIT
            Assert.AreEqual(mean_pf_a, 20.77, 0.01);
            #elif XUNIT
            Assert.Equal(20.77, mean_pf_a, 2);
            #elif MSTEST
            Assert.AreEqual(mean_pf_a, 20.77, 0.01);
            #endif

            return;
        }


        [Test()]
        public void MeanHarmonic_BallsLost()
        {
            data_balls_lost =
                                from row in BasketballTeamDataTable
                                select row.BallsLost
                                    ;

            double mean_bl_a = data_balls_lost.MeanHarmonic();

            // Assert
            #if NUNIT
            Assert.AreEqual(mean_bl_a, 14.74, 0.01);
            #elif XUNIT
            Assert.Equal(14.74, mean_bl_a, 2);
            #elif MSTEST
            Assert.AreEqual(mean_bl_a, 14.74, 0.01);
            #endif

            return;
        }


        [Test()]
        public void MeanHarmonic_BallsStolen()
        {
            data_balls_stolen =
                                from row in BasketballTeamDataTable
                                select row.BallsStolen
                                    ;

            double mean_bs_a = data_balls_stolen.MeanHarmonic();

            // Assert
            #if NUNIT
            Assert.AreEqual(mean_bs_a, 7.08, 0.01);
            #elif XUNIT
            Assert.Equal(7.08, mean_bs_a, 2);
            #elif MSTEST
            Assert.AreEqual(mean_bs_a, 7.08, 0.01);
            #endif

            return;
        }


        [Test()]
        public void MeanHarmonic_Blocks()
        {
            data_blocks =
                                from row in BasketballTeamDataTable
                                select row.Blocks
                                    ;

            double mean_block_a = data_blocks.MeanHarmonic();

            // Assert
            #if NUNIT
            Assert.AreEqual(mean_block_a, 3.06, 0.01);
            #elif XUNIT
            Assert.Equal(3.06, mean_block_a, 2);
            #elif MSTEST
            Assert.AreEqual(mean_block_a, 3.06, 0.01);
            #endif

            return;
        }
    }
}
