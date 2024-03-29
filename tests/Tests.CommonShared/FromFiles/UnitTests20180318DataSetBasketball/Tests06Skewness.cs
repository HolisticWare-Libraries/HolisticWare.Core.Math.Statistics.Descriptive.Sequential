﻿// /*
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

        [Test()]
        public void Skewness_Points2Success()
        {
            data_2pts_success =
                                    from row in BasketballTeamDataTable
                                    select row.Points2Success
                                        ;

            double skewness_2s = data_2pts_success.Skewness();

            // Assert
            // Skewness calculation according R library(e1071) "type 1"
            #if NUNIT
            Assert.AreEqual(skewness_2s, 0.5475344, 0.0000001);
            #elif XUNIT
            Assert.Equal(0.5475344, skewness_2s, 7);
            #elif MSTEST
            Assert.AreEqual(skewness_2s, 0.5475344, 0.0000001);
            #endif

            return;
        }

        [Test()]
        public void Skewness_Points3Success()
        {
            data_3pts_success =
                                    from row in BasketballTeamDataTable
                                    select row.Points3Success
                                        ;

            double skewness_3pts_success = data_3pts_success.Skewness();

            // Assert
            // Skewness calculation according R library(e1071) "type 1"
            #if NUNIT
            Assert.AreEqual(skewness_3pts_success, 1.222966, 0.000001);
            #elif XUNIT
            Assert.Equal(1.222966, skewness_3pts_success, 6);
            #elif MSTEST
            Assert.AreEqual(skewness_3pts_success, 1.222966, 0.000001);
            #endif


            return;
        }


        [Test()]
        public void Skewness_Points2Fail()
        {
            data_2pts_fail =
                                from row in BasketballTeamDataTable
                                select row.Points2Fail
                                    ;

            double skewness_2f = data_2pts_fail.Skewness();

            // Assert
            // Skewness calculation according R library(e1071) "type 1"
            #if NUNIT
            Assert.AreEqual(skewness_2f, 0.3093053, 0.0000001);
            #elif XUNIT
            Assert.Equal(0.3093053, skewness_2f, 7);
            #elif MSTEST
            Assert.AreEqual(skewness_2f, 0.3093053, 0.0000001);
            #endif


            return;
        }


        [Test()]
        public void Skewness_Points3Fail()
        {
            data_3pts_fail =
                                from row in BasketballTeamDataTable
                                select row.Points3Fail
                                    ;

            double skewness_3f = data_3pts_fail.Skewness();

            // Assert
            // Skewness calculation according R library(e1071) "type 1"
            #if NUNIT
            Assert.AreEqual(skewness_3f, 0.6540075, 0.0000001);
            #elif XUNIT
            Assert.Equal(0.6540075, skewness_3f, 7);
            #elif MSTEST
            Assert.AreEqual(skewness_3f, 0.6540075, 0.0000001);
            #endif

            return;
        }


        [Test()]
        public void Skewness_FreeThrowFail()
        {
            data_free_throw_fail =
                                from row in BasketballTeamDataTable
                                select row.FreeThrowFail
                                    ;

            double skewness_ftf = data_free_throw_fail.Skewness();

            // Assert
            // Skewness calculation according R library(e1071) "type 1"
            #if NUNIT
            Assert.AreEqual(skewness_ftf, 0.146377, 0.000001);
            #elif XUNIT
            Assert.Equal(0.146377, skewness_ftf, 6);
            #elif MSTEST
            Assert.AreEqual(skewness_ftf, 0.146377, 0.000001);
            #endif

            return;
        }


        [Test()]
        public void Skewness_FreeThrowSuccess()
        {
            data_free_throw_success =
                                from row in BasketballTeamDataTable
                                select row.FreeThrowSuccess
                                    ;

            double skewness_fts = data_free_throw_success.Skewness();

            // Assert
            // Skewness calculation according R library(e1071) "type 1"
            #if NUNIT
            Assert.AreEqual(skewness_fts, 0.5119433, 0.0000001);
            #elif XUNIT
            Assert.Equal(0.5119433, skewness_fts, 7);
            #elif MSTEST
            Assert.AreEqual(skewness_fts, 0.5119433, 0.0000001);
            #endif

            return;
        }


        [Test()]
        public void Skewness_JumpsOffensive()
        {
            data_jumps_offensive =
                                from row in BasketballTeamDataTable
                                select row.JumpsOffensive
                                    ;

            double skewness_off = data_jumps_offensive.Skewness();

            // Assert
            // Skewness calculation according R library(e1071) "type 1"
            #if NUNIT
            Assert.AreEqual(skewness_off, 0.5125251, 0.0000001);
            #elif XUNIT
            Assert.Equal(0.5125251, skewness_off, 7);
            #elif MSTEST
            Assert.AreEqual(skewness_off, 0.5125251, 0.0000001);
            #endif

            return;
        }

        [Test()]
        public void Skewness_JumpsDefensive()
        {
            data_jumps_defensive =
                                from row in BasketballTeamDataTable
                                select row.JumpsDefensive
                                    ;

            double skewness_def = data_jumps_defensive.Skewness();

            // Assert
            // Skewness calculation according R library(e1071) "type 1"
            #if NUNIT
            Assert.AreEqual(skewness_def, -0.1006476, 0.0000001);
            #elif XUNIT
            Assert.Equal(-0.1006476, skewness_def, 7);
            #elif MSTEST
            Assert.AreEqual(skewness_def, -0.1006476, 0.0000001);
            #endif

            return;
        }

        [Test()]
        public void Skewness_Assistence()
        {
            data_assistence =
                                from row in BasketballTeamDataTable
                                select row.Assistence
                                    ;

            double skewness_assist = data_assistence.Skewness();

            // Assert
            // Skewness calculation according R library(e1071) "type 1"
            #if NUNIT
            Assert.AreEqual(skewness_assist, 0.7273748, 0.0000001);
            #elif XUNIT
            Assert.Equal(0.7273748, skewness_assist, 7);
            #elif MSTEST
            Assert.AreEqual(skewness_assist, 0.7273748, 0.0000001);
            #endif

            return;
        }

        [Test()]
        public void Skewness_PersonalFaults()
        {
            data_personal_faults =
                                from row in BasketballTeamDataTable
                                select row.PersonalFaults
                                    ;

            double skewness_pf = data_personal_faults.Skewness();

            // Assert
            // Skewness calculation according R library(e1071) "type 1"
            #if NUNIT
            Assert.AreEqual(skewness_pf, 0.5053442, 0.0000001);
            #elif XUNIT
            Assert.Equal(0.5053442, skewness_pf, 7);
            #elif MSTEST
            Assert.AreEqual(skewness_pf, 0.5053442, 0.0000001);
            #endif

            return;
        }


        [Test()]
        public void Skewness_BallsLost()
        {
            data_balls_lost =
                                from row in BasketballTeamDataTable
                                select row.BallsLost
                                    ;

            double skewness_bl = data_balls_lost.Skewness();

            // Assert
            // Skewness calculation according R library(e1071) "type 1"
            #if NUNIT
            Assert.AreEqual(skewness_bl, 0.9926969, 0.0000001);
            #elif XUNIT
            Assert.Equal(0.9926969, skewness_bl, 7);
            #elif MSTEST
            Assert.AreEqual(skewness_bl, 0.9926969, 0.0000001);
            #endif

            return;
        }


        [Test()]
        public void Skewness_BallsStolen()
        {
            data_balls_stolen =
                                from row in BasketballTeamDataTable
                                select row.BallsStolen
                                    ;

            double skewness_bs = data_balls_stolen.Skewness();

            // Assert
            // Skewness calculation according R library(e1071) "type 1"
            #if NUNIT
            Assert.AreEqual(skewness_bs, 0.8319246, 0.0000001);
            #elif XUNIT
            Assert.Equal(0.8319246, skewness_bs, 7);
            #elif MSTEST
            Assert.AreEqual(skewness_bs, 0.8319246, 0.0000001);
            #endif

            return;
        }


        [Test()]
        public void Skewness_Blocks()
        {
            data_blocks =
                                from row in BasketballTeamDataTable
                                select row.Blocks
                                    ;

            double skewness_block = data_blocks.Skewness();

            // Assert
            // Skewness calculation according R library(e1071) "type 1"
            #if NUNIT
            Assert.AreEqual(skewness_block, 0.6844296, 0.0000001);
            #elif XUNIT
            Assert.Equal(0.6844296, skewness_block, 7);
            #elif MSTEST
            Assert.AreEqual(skewness_block, 0.6844296, 0.0000001);
            #endif

            return;
        }

    }
}
