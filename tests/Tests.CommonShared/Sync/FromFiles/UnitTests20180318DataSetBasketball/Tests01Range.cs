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
        public void Range_Points2Success()
        {
            data_2pts_success =
                                    from row in BasketballTeamDataTable
                                    select row.Points2Success
                                        ;

            (int Min, int Max, int Delta) range_2s_a = data_2pts_success.Range();

            // Assert
            #if NUNIT
            Assert.AreEqual(range_2s_a.Min, 7);
            Assert.AreEqual(range_2s_a.Max, 44);
            Assert.AreEqual(range_2s_a.Delta, 37);
            #elif XUNIT
            Assert.Equal(7, range_2s_a.Min);
            Assert.Equal(44, range_2s_a.Max);
            Assert.Equal(37, range_2s_a.Delta);
            #elif MSTEST
            Assert.AreEqual(range_2s_a.Min, 7);
            Assert.AreEqual(range_2s_a.Max, 44);
            Assert.AreEqual(range_2s_a.Delta, 37);
            #endif

            return;
        }

        //var range_2_a;

        [Test()]
        public void Range_Points3Success()
        {
            data_3pts_success =
                                    from row in BasketballTeamDataTable
                                    select row.Points3Success
                                        ;

            var range_a_3pts_success = data_3pts_success.Range();

            // Assert
            #if NUNIT
            Assert.AreEqual(range_a_3pts_success.Min, 1);
            Assert.AreEqual(range_a_3pts_success.Max, 19);
            Assert.AreEqual(range_a_3pts_success.Delta, 18);
            #elif XUNIT
            Assert.Equal(1, range_a_3pts_success.Min);
            Assert.Equal(19, range_a_3pts_success.Max);
            Assert.Equal(18, range_a_3pts_success.Delta);
            #elif MSTEST
            Assert.AreEqual(range_a_3pts_success.Min, 1);
            Assert.AreEqual(range_a_3pts_success.Max, 19);
            Assert.AreEqual(range_a_3pts_success.Delta, 18);
            #endif

            return;
        }


        [Test()]
        public void Range_Points2Fail()
        {
            data_2pts_fail =
                                from row in BasketballTeamDataTable
                                select row.Points2Fail
                                    ;

            var range_2f_a = data_2pts_fail.Range();

            // Assert
            #if NUNIT
            Assert.AreEqual(range_2f_a.Min, 7);
            Assert.AreEqual(range_2f_a.Max, 44);
            Assert.AreEqual(range_2f_a.Delta, 37);
            #elif XUNIT
            Assert.Equal(7, range_2f_a.Min);
            Assert.Equal(44, range_2f_a.Max);
            Assert.Equal(37, range_2f_a.Delta);
            #elif MSTEST
            Assert.AreEqual(range_2f_a.Min, 7);
            Assert.AreEqual(range_2f_a.Max, 44);
            Assert.AreEqual(range_2f_a.Delta, 37);
            #endif

            return;
        }


        [Test()]
        public void Range_Points3Fail()
        {
            data_3pts_fail =
                                from row in BasketballTeamDataTable
                                select row.Points3Fail
                                    ;

            var range_3f_a = data_3pts_fail.Range();

            // Assert
            #if NUNIT
            Assert.AreEqual(range_3f_a.Min, 2);
            Assert.AreEqual(range_3f_a.Max, 27);
            Assert.AreEqual(range_3f_a.Delta, 25);
            #elif XUNIT
            Assert.Equal(2, range_3f_a.Min);
            Assert.Equal(27, range_3f_a.Max);
            Assert.Equal(25, range_3f_a.Delta);
            #elif MSTEST
            Assert.AreEqual(range_3f_a.Min, 2);
            Assert.AreEqual(range_3f_a.Max, 27);
            Assert.AreEqual(range_3f_a.Delta, 25);
            #endif

            return;
        }


        [Test()]
        public void Range_FreeThrowFail()
        {
            data_free_throw_fail =
                                from row in BasketballTeamDataTable
                                select row.FreeThrowFail
                                    ;

            var range_ftf_a = data_free_throw_fail.Range();

            // Assert
            #if NUNIT
            Assert.AreEqual(range_ftf_a.Min, 0);
            Assert.AreEqual(range_ftf_a.Max, 13);
            Assert.AreEqual(range_ftf_a.Delta, 13);
            #elif XUNIT
            Assert.Equal(0, range_ftf_a.Min);
            Assert.Equal(13, range_ftf_a.Max);
            Assert.Equal(13, range_ftf_a.Delta);
            #elif MSTEST
            Assert.AreEqual(range_ftf_a.Min, 0);
            Assert.AreEqual(range_ftf_a.Max, 13);
            Assert.AreEqual(range_ftf_a.Delta, 13);
            #endif

            return;
        }


        [Test()]
        public void Range_FreeThrowSuccess()
        {
            data_free_throw_success =
                                from row in BasketballTeamDataTable
                                select row.FreeThrowSuccess
                                    ;

            var range_fts_a = data_free_throw_success.Range();

            // Assert
            #if NUNIT
            Assert.AreEqual(range_fts_a.Min, 2);
            Assert.AreEqual(range_fts_a.Max, 37);
            Assert.AreEqual(range_fts_a.Delta, 35);
            #elif XUNIT
            Assert.Equal(2, range_fts_a.Min);
            Assert.Equal(37, range_fts_a.Max);
            Assert.Equal(35, range_fts_a.Delta);
            #elif MSTEST
            Assert.AreEqual(range_fts_a.Min, 2);
            Assert.AreEqual(range_fts_a.Max, 37);
            Assert.AreEqual(range_fts_a.Delta, 35);
            #endif

            return;
        }


        [Test()]
        public void Range_JumpsOffensive()
        {
            data_jumps_offensive =
                                from row in BasketballTeamDataTable
                                select row.JumpsOffensive
                                    ;

            var range_off_a = data_jumps_offensive.Range();

            // Assert
            #if NUNIT
            Assert.AreEqual(range_off_a.Min, 2);
            Assert.AreEqual(range_off_a.Max, 25);
            Assert.AreEqual(range_off_a.Delta, 23);
            #elif XUNIT
            Assert.Equal(2, range_off_a.Min);
            Assert.Equal(25, range_off_a.Max);
            Assert.Equal(23, range_off_a.Delta);
            #elif MSTEST
            Assert.AreEqual(range_off_a.Min, 2);
            Assert.AreEqual(range_off_a.Max, 25);
            Assert.AreEqual(range_off_a.Delta, 23);
            #endif

            return;
        }

        [Test()]
        public void Range_JumpsDefensive()
        {
            data_jumps_defensive =
                                from row in BasketballTeamDataTable
                                select row.JumpsDefensive
                                    ;

            var range_def_a = data_jumps_defensive.Range();

            // Assert
#if NUNIT
            Assert.AreEqual(range_def_a.Min, 7);
            Assert.AreEqual(range_def_a.Max, 36);
            Assert.AreEqual(range_def_a.Delta, 29);
#elif XUNIT
            Assert.Equal(7, range_def_a.Min);
            Assert.Equal(36, range_def_a.Max);
            Assert.Equal(29, range_def_a.Delta);
            #elif MSTEST
            Assert.AreEqual(range_def_a.Min, 7);
            Assert.AreEqual(range_def_a.Max, 36);
            Assert.AreEqual(range_def_a.Delta, 29);
            #endif

            return;
        }

        [Test()]
        public void Range_Assistence()
        {
            data_assistence =
                                from row in BasketballTeamDataTable
                                select row.Assistence
                                    ;

            var range_assist_a = data_assistence.Range();

            // Assert
            #if NUNIT
            Assert.AreEqual(range_assist_a.Min, 2);
            Assert.AreEqual(range_assist_a.Max, 31);
            Assert.AreEqual(range_assist_a.Delta, 29);
            #elif XUNIT
            Assert.Equal(2, range_assist_a.Min);
            Assert.Equal(31, range_assist_a.Max);
            Assert.Equal(29, range_assist_a.Delta);
            #elif MSTEST
            Assert.AreEqual(range_assist_a.Min, 2);
            Assert.AreEqual(range_assist_a.Max, 31);
            Assert.AreEqual(range_assist_a.Delta, 29);
            #endif

            return;
        }

        [Test()]
        public void Range_PersonalFaults()
        {
            data_personal_faults =
                                from row in BasketballTeamDataTable
                                select row.PersonalFaults
                                    ;

            var range_pf_a = data_personal_faults.Range();

            // Assert
            #if NUNIT
            Assert.AreEqual(range_pf_a.Min, 10);
            Assert.AreEqual(range_pf_a.Max, 37);
            Assert.AreEqual(range_pf_a.Delta, 27);
            #elif XUNIT
            Assert.Equal(10, range_pf_a.Min);
            Assert.Equal(37, range_pf_a.Max);
            Assert.Equal(27, range_pf_a.Delta);
            #elif MSTEST
            Assert.AreEqual(range_pf_a.Min, 10);
            Assert.AreEqual(range_pf_a.Max, 37);
            Assert.AreEqual(range_pf_a.Delta, 27);
            #endif

            return;
        }


        [Test()]
        public void Range_BallsLost()
        {
            data_balls_lost =
                                from row in BasketballTeamDataTable
                                select row.BallsLost
                                    ;

            var range_bl_a = data_balls_lost.Range();

            // Assert
            #if NUNIT
            Assert.AreEqual(range_bl_a.Min, 4);
            Assert.AreEqual(range_bl_a.Max, 36);
            Assert.AreEqual(range_bl_a.Delta, 32);
            #elif XUNIT
            Assert.Equal(4, range_bl_a.Min);
            Assert.Equal(36, range_bl_a.Max);
            Assert.Equal(32, range_bl_a.Delta);
            #elif MSTEST
            Assert.AreEqual(range_bl_a.Min, 4);
            Assert.AreEqual(range_bl_a.Max, 36);
            Assert.AreEqual(range_bl_a.Delta, 32);
            #endif

            return;
        }


        [Test()]
        public void Range_BallsStolen()
        {
            data_balls_stolen =
                                from row in BasketballTeamDataTable
                                select row.BallsStolen
                                    ;

            var range_bs_a = data_balls_stolen.Range();

            // Assert
            #if NUNIT
            Assert.AreEqual(range_bs_a.Min, 0);
            Assert.AreEqual(range_bs_a.Max, 21);
            Assert.AreEqual(range_bs_a.Delta, 21);
            #elif XUNIT
            Assert.Equal(0, range_bs_a.Min);
            Assert.Equal(21, range_bs_a.Max);
            Assert.Equal(21, range_bs_a.Delta);
            #elif MSTEST
            Assert.AreEqual(range_bs_a.Min, 0);
            Assert.AreEqual(range_bs_a.Max, 21);
            Assert.AreEqual(range_bs_a.Delta, 21);
            #endif

            return;
        }


        [Test()]
        public void Range_Blocks()
        {
            data_blocks =
                                from row in BasketballTeamDataTable
                                select row.Blocks
                                    ;

            var range_block_a = data_blocks.Range();

            // Assert
            #if NUNIT
            Assert.AreEqual(range_block_a.Min, 0);
            Assert.AreEqual(range_block_a.Max, 9);
            Assert.AreEqual(range_block_a.Delta, 9);
            #elif XUNIT
            Assert.Equal(0, range_block_a.Min);
            Assert.Equal(9, range_block_a.Max);
            Assert.Equal(9, range_block_a.Delta);
            #elif MSTEST
            Assert.AreEqual(range_block_a.Min, 0);
            Assert.AreEqual(range_block_a.Max, 9);
            Assert.AreEqual(range_block_a.Delta, 9);
            #endif

            return;
        }
    }
}
