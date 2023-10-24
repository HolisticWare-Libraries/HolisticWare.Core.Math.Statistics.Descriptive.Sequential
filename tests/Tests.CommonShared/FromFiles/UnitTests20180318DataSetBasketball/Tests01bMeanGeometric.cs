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

using Core.Math.Statistics.Descriptive;

namespace UnitTests.Core.Math.Statistics.Descriptive.Sequential.Sync
{
    public partial class UnitTests20180318DataSetBasketball
    {
        //IEnumerable<int> data_2pts_success;
        //IEnumerable<int> data_3pts_success;
        //IEnumerable<int> data_2pts_fail;
        //IEnumerable<int> data_3pts_fail;
        //IEnumerable<int> data_free_throw_fail;
        //IEnumerable<int> data_free_throw_success;
        //IEnumerable<int> data_jumps_offensive;
        //IEnumerable<int> data_jumps_defensive;
        //IEnumerable<int> data_assistence;
        //IEnumerable<int> data_personal_faults;
        //IEnumerable<int> data_balls_lost;
        //IEnumerable<int> data_balls_stolen;
        //IEnumerable<int> data_blocks;


        [Test()]
        public void MeanGeometric_Points2Success()
        {
            data_2pts_success =
                                    from row in BasketballTeamDataTable
                                    select row.Points2Success
                                        ;
            
            double mean_2s_g = data_2pts_success.MeanGeometric();

            // Assert
            #if NUNIT
            Assert.AreEqual(mean_2s_g, 21.25, 0.01);
            #elif XUNIT
            Assert.Equal(21.25, mean_2s_g, 2);
            #elif MSTEST
            Assert.AreEqual(mean_2s_g, 21.25, 0.01);
            #endif

            return;
        }

        //double mean_2_a;

        [Test()]
            public void MeanGeometric_Points3Success()
        {
            data_3pts_success =
                                    from row in BasketballTeamDataTable
                                    select row.Points3Success
                                        ;

            double mean_g_3pts_success = data_3pts_success.MeanGeometric();

            // Assert
            #if NUNIT
            Assert.AreEqual(mean_g_3pts_success, 5.84, 0.01);
            #elif XUNIT
            Assert.Equal(5.84, mean_g_3pts_success, 2);
            #elif MSTEST
            Assert.AreEqual(mean_g_3pts_success, 5.84, 0.01);
            #endif


            return;
        }


        [Test()]
            public void MeanGeometric_Points2Fail()
        {
            data_2pts_fail =
                                from row in BasketballTeamDataTable
                                select row.Points2Fail
                                    ;

            double mean_2f_g = data_2pts_fail.MeanGeometric();

            // Assert
            #if NUNIT
            Assert.AreEqual(mean_2f_g, 20.50, 0.01);
            #elif XUNIT
            Assert.Equal(20.50, mean_2f_g, 2);
            #elif MSTEST
            Assert.AreEqual(mean_2f_g, 20.50, 0.01);
            #endif


            return;
        }


        [Test()]
            public void MeanGeometric_Points3Fail()
        {
            data_3pts_fail =
                                from row in BasketballTeamDataTable
                                select row.Points3Fail
                                    ;

            double mean_3f_g = data_3pts_fail.MeanGeometric();

            // Assert
            #if NUNIT
            Assert.AreEqual(mean_3f_g, 10.80, 0.01);
            #elif XUNIT
            Assert.Equal(10.80, mean_3f_g, 2);
            #elif MSTEST
            Assert.AreEqual(mean_3f_g, 10.80, 0.01);
            #endif

            return;
        }


        [Test()]
            public void MeanGeometric_FreeThrowFail()
        {
            data_free_throw_fail =
                                from row in BasketballTeamDataTable
                                select row.FreeThrowFail
                                    ;

            double mean_ftf_g = data_free_throw_fail.MeanGeometric();

            // Assert
            #if NUNIT
            Assert.AreEqual(mean_ftf_g, 0.00, 0.01);
            #elif XUNIT
            Assert.Equal(0.00, mean_ftf_g, 2);
            #elif MSTEST
            Assert.AreEqual(mean_ftf_g, 0.00, 0.01);
            #endif

            return;
        }


        [Test()]
            public void MeanGeometric_FreeThrowSuccess()
        {
            data_free_throw_success =
                                from row in BasketballTeamDataTable
                                select row.FreeThrowSuccess
                                    ;

            double mean_fts_g = data_free_throw_success.MeanGeometric();

            // Assert
            #if NUNIT
            Assert.AreEqual(mean_fts_g, 13.80, 0.01);
            #elif XUNIT
            Assert.Equal(13.80, mean_fts_g, 2);
            #elif MSTEST
            Assert.AreEqual(mean_fts_g, 13.80, 0.01);
            #endif

            return;
        }


        [Test()]
            public void MeanGeometric_JumpsOffensive()
        {
            data_jumps_offensive =
                                from row in BasketballTeamDataTable
                                select row.JumpsOffensive
                                    ;

            double mean_off_g = data_jumps_offensive.MeanGeometric();

            // Assert
            #if NUNIT
            Assert.AreEqual(mean_off_g, 10.31, 0.01);
            #elif XUNIT
            Assert.Equal(10.31, mean_off_g, 2);
            #elif MSTEST
            Assert.AreEqual(mean_off_g, 10.31, 0.01);
            #endif

            return;
        }

        [Test()]
            public void MeanGeometric_JumpsDefensive()
        {
            data_jumps_defensive =
                                from row in BasketballTeamDataTable
                                select row.JumpsDefensive
                                    ;

            double mean_def_g = data_jumps_defensive.MeanGeometric();

            // Assert
            #if NUNIT
            Assert.AreEqual(mean_def_g, 20.85, 0.01);
            #elif XUNIT
            Assert.Equal(20.85, mean_def_g, 2);
            #elif MSTEST
            Assert.AreEqual(mean_def_g, 20.85, 0.01);
            #endif

            return;
        }

        [Test()]
            public void MeanGeometric_Assistence()
        {
            data_assistence =
                                from row in BasketballTeamDataTable
                                select row.Assistence
                                    ;

            double mean_assist_g = data_assistence.MeanGeometric();

            // Assert
            #if NUNIT
            Assert.AreEqual(mean_assist_g, 11.33, 0.01);
            #elif XUNIT
            Assert.Equal(11.33, mean_assist_g, 2);
            #elif MSTEST
            Assert.AreEqual(mean_assist_g, 11.33, 0.01);
            #endif

            return;
        }

        [Test()]
            public void MeanGeometric_PersonalFaults()
        {
            data_personal_faults =
                                from row in BasketballTeamDataTable
                                select row.PersonalFaults
                                    ;

            double mean_pf_g = data_personal_faults.MeanGeometric();

            // Assert
            #if NUNIT
            Assert.AreEqual(mean_pf_g, 20.11, 0.01);
            #elif XUNIT
            Assert.Equal(20.11, mean_pf_g, 2);
            #elif MSTEST
            Assert.AreEqual(mean_pf_g, 20.11, 0.01);
            #endif

            return;
        }


        [Test()]
            public void MeanGeometric_BallsLost()
        {
            data_balls_lost =
                                from row in BasketballTeamDataTable
                                select row.BallsLost
                                    ;

            double mean_bl_g = data_balls_lost.MeanGeometric();

            // Assert
            #if NUNIT
            Assert.AreEqual(mean_bl_g, 13.94, 0.01);
            #elif XUNIT
            Assert.Equal(13.94, mean_bl_g, 2);
            #elif MSTEST
            Assert.AreEqual(mean_bl_g, 13.94, 0.01);
            #endif

            return;
        }


        [Test()]
            public void MeanGeometric_BallsStolen()
        {
            data_balls_stolen =
                                from row in BasketballTeamDataTable
                                select row.BallsStolen
                                    ;

            double mean_bs_g = data_balls_stolen.MeanGeometric();

            // Assert
            #if NUNIT
            Assert.AreEqual(mean_bs_g, 0.00, 0.01);
            #elif XUNIT
            Assert.Equal(0.00, mean_bs_g, 2);
            #elif MSTEST
            Assert.AreEqual(mean_bs_g, 0.00, 0.01);
            #endif

            return;
        }


        [Test()]
            public void MeanGeometric_Blocks()
        {
            data_blocks =
                                from row in BasketballTeamDataTable
                                select row.Blocks
                                    ;

            double mean_block_g = data_blocks.MeanGeometric();

            // Assert
            #if NUNIT
            Assert.AreEqual(mean_block_g, 0.00, 0.01);
            #elif XUNIT
            Assert.Equal(0.00, mean_block_g, 2);
            #elif MSTEST
            Assert.AreEqual(mean_block_g, 0.00, 0.01);
            #endif
            return;
        }
    }
}
