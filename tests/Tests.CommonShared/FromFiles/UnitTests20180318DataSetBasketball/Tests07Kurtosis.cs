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
        public void Kurtosis_Points2Success()
        {
            data_2pts_success =
                                    from row in BasketballTeamDataTable
                                    select row.Points2Success
                                        ;

            double kurtosis_2s = data_2pts_success.Kurtosis();

            // Assert
            // Kurtosis calculation according R library(e1071) "type 1"

            #if NUNIT
            Assert.AreEqual(kurtosis_2s, 0.03787545, 0.00000001);
            #elif XUNIT
            Assert.Equal(0.03787545, kurtosis_2s, 8);
            #elif MSTEST
            Assert.AreEqual(kurtosis_2s, 0.03787545, 0.00000001);
            #endif

            return;
        }

        [Test()]
        public void Kurtosis_Points3Success()
        {
            data_3pts_success =
                                    from row in BasketballTeamDataTable
                                    select row.Points3Success
                                        ;

            double kurtosis_3pts_success = data_3pts_success.Kurtosis();

            // Assert
            // Kurtosis calculation according R library(e1071) "type 1"
            #if NUNIT
            Assert.AreEqual(kurtosis_3pts_success, 2.005057, 0.000001);
            #elif XUNIT
            Assert.Equal(2.005057, kurtosis_3pts_success, 6);
            #elif MSTEST
            Assert.AreEqual(kurtosis_3pts_success, 2.005057, 0.000001);
            #endif


            return;
        }


        [Test()]
        public void Kurtosis_Points2Fail()
        {
            data_2pts_fail =
                                from row in BasketballTeamDataTable
                                select row.Points2Fail
                                    ;

            double kurtosis_2f = data_2pts_fail.Kurtosis();

            // Assert
            // Kurtosis calculation according R library(e1071) "type 1"
            #if NUNIT
            Assert.AreEqual(kurtosis_2f, 0.1793478, 0.0000001);
            #elif XUNIT
            Assert.Equal(0.1793478, kurtosis_2f, 7);
            #elif MSTEST
            Assert.AreEqual(kurtosis_2f, 0.1793478, 0.0000001);
            #endif


            return;
        }


        [Test()]
        public void Kurtosis_Points3Fail()
        {
            data_3pts_fail =
                                from row in BasketballTeamDataTable
                                select row.Points3Fail
                                    ;

            double kurtosis_3f = data_3pts_fail.Kurtosis();

            // Assert
            // Kurtosis calculation according R library(e1071) "type 1"
            #if NUNIT
            Assert.AreEqual(kurtosis_3f, 0.5665306, 0.0000001);
            #elif XUNIT
            Assert.Equal(0.5665306, kurtosis_3f, 7);
            #elif MSTEST
            Assert.AreEqual(kurtosis_3f, 0.5665306, 0.0000001);
            #endif

            return;
        }


        [Test()]
        public void Kurtosis_FreeThrowFail()
        {
            data_free_throw_fail =
                                from row in BasketballTeamDataTable
                                select row.FreeThrowFail
                                    ;

            double kurtosis_ftf = data_free_throw_fail.Kurtosis();

            // Assert
            // Kurtosis calculation according R library(e1071) "type 1"
            #if NUNIT
            Assert.AreEqual(kurtosis_ftf, -0.6270205, 0.0000001);
            #elif XUNIT
            Assert.Equal(-0.6270205, kurtosis_ftf, 7);
            #elif MSTEST
            Assert.AreEqual(kurtosis_ftf, -0.6270205, 0.0000001);
            #endif

            return;
        }


        [Test()]
        public void Kurtosis_FreeThrowSuccess()
        {
            data_free_throw_success =
                                from row in BasketballTeamDataTable
                                select row.FreeThrowSuccess
                                    ;

            double kurtosis_fts = data_free_throw_success.Kurtosis();

            // Assert
            // Kurtosis calculation according R library(e1071) "type 1"
            #if NUNIT
            Assert.AreEqual(kurtosis_fts, -0.1698031, 0.0000001);
            #elif XUNIT
            Assert.Equal(-0.1698031+3, kurtosis_fts, 7);
            #elif MSTEST
            Assert.AreEqual(kurtosis_fts, -0.1698031, 0.0000001);
            #endif

            return;
        }


        [Test()]
        public void Kurtosis_JumpsOffensive()
        {
            data_jumps_offensive =
                                from row in BasketballTeamDataTable
                                select row.JumpsOffensive
                                    ;

            double kurtosis_off = data_jumps_offensive.Kurtosis();

            // Assert
            // Kurtosis calculation according R library(e1071) "type 1"
            #if NUNIT
            Assert.AreEqual(kurtosis_off, 0.3569787, 0.0000001);
            #elif XUNIT
            Assert.Equal(0.3569787, kurtosis_off, 7);
            #elif MSTEST
            Assert.AreEqual(kurtosis_off, 0.3569787, 0.0000001);
            #endif

            return;
        }

        [Test()]
        public void Kurtosis_JumpsDefensive()
        {
            data_jumps_defensive =
                                from row in BasketballTeamDataTable
                                select row.JumpsDefensive
                                    ;

            double kurtosis_def = data_jumps_defensive.Kurtosis();

            // Assert
            // Kurtosis calculation according R library(e1071) "type 1"
            #if NUNIT
            Assert.AreEqual(kurtosis_def, -0.5216579, 0.0000001);
            #elif XUNIT
            Assert.Equal(-0.5216579, kurtosis_def, 7);
            #elif MSTEST
            Assert.AreEqual(kurtosis_def, -0.5216579, 0.0000001);
            #endif

            return;
        }

        [Test()]
        public void Kurtosis_Assistence()
        {
            data_assistence =
                                from row in BasketballTeamDataTable
                                select row.Assistence
                                    ;

            double kurtosis_assist = data_assistence.Kurtosis();

            // Assert
            // Kurtosis calculation according R library(e1071) "type 1"
            #if NUNIT
            Assert.AreEqual(kurtosis_assist, 0.8276105, 0.0000001);
            #elif XUNIT
            Assert.Equal(0.8276105, kurtosis_assist, 7);
            #elif MSTEST
            Assert.AreEqual(kurtosis_assist, 0.8276105, 0.0000001);
            #endif

            return;
        }

        [Test()]
        public void Kurtosis_PersonalFaults()
        {
            data_personal_faults =
                                from row in BasketballTeamDataTable
                                select row.PersonalFaults
                                    ;

            double kurtosis_pf = data_personal_faults.Kurtosis();

            // Assert
            // Kurtosis calculation according R library(e1071) "type 1"
            #if NUNIT
            Assert.AreEqual(kurtosis_pf, 0.116669, 0.0000001);
            #elif XUNIT
            Assert.Equal(0.116669, kurtosis_pf, 7);
            #elif MSTEST
            Assert.AreEqual(kurtosis_pf, 0.116669, 0.0000001);
            #endif

            return;
        }


        [Test()]
        public void Kurtosis_BallsLost()
        {
            data_balls_lost =
                                from row in BasketballTeamDataTable
                                select row.BallsLost
                                    ;

            double kurtosis_bl = data_balls_lost.Kurtosis();

            // Assert
            // Kurtosis calculation according R library(e1071) "type 1"
            #if NUNIT
            Assert.AreEqual(kurtosis_bl, 2.257583, 0.0000001);
            #elif XUNIT
            Assert.Equal(2.257583, kurtosis_bl, 7);
            #elif MSTEST
            Assert.AreEqual(kurtosis_bl, 2.257583, 0.0000001);
            #endif

            return;
        }


        [Test()]
        public void Kurtosis_BallsStolen()
        {
            data_balls_stolen =
                                from row in BasketballTeamDataTable
                                select row.BallsStolen
                                    ;

            double kurtosis_bs = data_balls_stolen.Kurtosis();

            // Assert
            // Kurtosis calculation according R library(e1071) "type 1"
            #if NUNIT
            Assert.AreEqual(kurtosis_bs, 1.973338, 0.000001);
            #elif XUNIT
            Assert.Equal(1.973338, kurtosis_bs, 6);
            #elif MSTEST
            Assert.AreEqual(kurtosis_bs, 1.973338, 0.000001);
            #endif

            return;
        }


        [Test()]
        public void Kurtosis_Blocks()
        {
            data_blocks =
                                from row in BasketballTeamDataTable
                                select row.Blocks
                                    ;

            double kurtosis_block = data_blocks.Kurtosis();

            // Assert
            // Kurtosis calculation according R library(e1071) "type 1"
            #if NUNIT
            Assert.AreEqual(kurtosis_block, -0.3112424, 0.0000001);
            #elif XUNIT
            Assert.Equal(-0.3112424, kurtosis_block, 7);
            #elif MSTEST
            Assert.AreEqual(kurtosis_block, -0.3112424, 0.0000001);
            #endif

            return;
        }

    }
}
