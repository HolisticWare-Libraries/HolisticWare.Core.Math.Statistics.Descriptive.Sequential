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
using System;

using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;
using System.Threading.Tasks;

#if XUNIT
using Xunit;
// NUnit aliases
using Test = Xunit.FactAttribute;
// XUnit aliases
using TestClass = HolisticWare.Core.Testing.UnitTestsCompatibilityAliasAttribute;
#elif NUNIT
using NUnit.Framework;
// MSTest aliases
using TestInitialize = NUnit.Framework.SetUpAttribute;
using TestProperty = NUnit.Framework.PropertyAttribute;
using TestClass = NUnit.Framework.TestFixtureAttribute;
using TestMethod = NUnit.Framework.TestAttribute;
using TestCleanup = NUnit.Framework.TearDownAttribute;
using TestContext = System.Object;
// XUnit aliases
using Fact=NUnit.Framework.TestAttribute;
#elif MSTEST
using Microsoft.VisualStudio.TestTools.UnitTesting;
// NUnit aliases
using Test = Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute;
// XUnit aliases
using Fact = Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute;
#endif

using Core.Math.Statistics.Descriptive.Sequential;

namespace UnitTests.Core.Math.Statistics.Descriptive.Sequential.Sync
{
    public partial class UnitTests20180318DataSetBasketball
    {

        [Test()]
        public void StandardDeviation_Points2Success()
        {
            data_2pts_success =
                                    from row in BasketballTeamDataTable
                                    select row.Points2Success
                                        ;

            double standard_deviation_2s = data_2pts_success.StandardDeviationSample();

            // Assert
            #if NUNIT
            Assert.AreEqual(standard_deviation_2s, 6.872, 0.001);
            #elif XUNIT
            Assert.Equal(6.872, standard_deviation_2s, 3);
            #elif MSTEST
            Assert.AreEqual(standard_deviation_2s, 6.872, 0.001);
            #endif

            return;
        }

        [Test()]
        public void StandardDeviation_Points3Success()
        {
            data_3pts_success =
                                    from row in BasketballTeamDataTable
                                    select row.Points3Success
                                        ;

            double standard_deviation_3pts_success = data_3pts_success.StandardDeviationSample();

            // Assert
            #if NUNIT
            Assert.AreEqual(standard_deviation_3pts_success, 3.462, 0.001);
            #elif XUNIT
            Assert.Equal(3.462, standard_deviation_3pts_success, 3);
            #elif MSTEST
            Assert.AreEqual(standard_deviation_3pts_success, 3.462, 0.001);
            #endif


            return;
        }


        [Test()]
        public void StandardDeviation_Points2Fail()
        {
            data_2pts_fail =
                                from row in BasketballTeamDataTable
                                select row.Points2Fail
                                    ;

            double standard_deviation_2f = data_2pts_fail.StandardDeviationSample();

            // Assert
            #if NUNIT
            Assert.AreEqual(standard_deviation_2f, 6.553, 0.001);
            #elif XUNIT
            Assert.Equal(6.553, standard_deviation_2f, 3);
            #elif MSTEST
            Assert.AreEqual(standard_deviation_2f, 6.553, 0.001);
            #endif


            return;
        }


        [Test()]
        public void StandardDeviation_Points3Fail()
        {
            data_3pts_fail =
                                from row in BasketballTeamDataTable
                                select row.Points3Fail
                                    ;

            double standard_deviation_3f = data_3pts_fail.StandardDeviationSample();

            // Assert
            #if NUNIT
            Assert.AreEqual(standard_deviation_3f, 4.583, 0.001);
            #elif XUNIT
            Assert.Equal(4.583, standard_deviation_3f, 3);
            #elif MSTEST
            Assert.AreEqual(standard_deviation_3f, 4.583, 0.001);
            #endif

            return;
        }


        [Test()]
        public void StandardDeviation_FreeThrowFail()
        {
            data_free_throw_fail =
                                from row in BasketballTeamDataTable
                                select row.FreeThrowFail
                                    ;

            double standard_deviation_ftf = data_free_throw_fail.StandardDeviationSample();

            // Assert
            #if NUNIT
            Assert.AreEqual(standard_deviation_ftf, 3.215, 0.001);
            #elif XUNIT
            Assert.Equal(3.215, standard_deviation_ftf, 3);
            #elif MSTEST
            Assert.AreEqual(standard_deviation_ftf, 3.215, 0.001);
            #endif

            return;
        }


        [Test()]
        public void StandardDeviation_FreeThrowSuccess()
        {
            data_free_throw_success =
                                from row in BasketballTeamDataTable
                                select row.FreeThrowSuccess
                                    ;

            double standard_deviation_fts = data_free_throw_success.StandardDeviationSample();

            // Assert
            #if NUNIT
            Assert.AreEqual(standard_deviation_fts, 7.528, 0.001);
            #elif XUNIT
            Assert.Equal(7.528, standard_deviation_fts, 3);
            #elif MSTEST
            Assert.AreEqual(standard_deviation_fts, 7.528, 0.001);
            #endif

            return;
        }


        [Test()]
        public void StandardDeviation_JumpsOffensive()
        {
            data_jumps_offensive =
                                from row in BasketballTeamDataTable
                                select row.JumpsOffensive
                                    ;

            double standard_deviation_off = data_jumps_offensive.StandardDeviationSample();

            // Assert
            #if NUNIT
            Assert.AreEqual(standard_deviation_off, 4.365, 0.001);
            #elif XUNIT
            Assert.Equal(4.365, standard_deviation_off, 3);
            #elif MSTEST
            Assert.AreEqual(standard_deviation_off, 4.365, 0.001);
            #endif

            return;
        }

        [Test()]
        public void StandardDeviation_JumpsDefensive()
        {
            data_jumps_defensive =
                                from row in BasketballTeamDataTable
                                select row.JumpsDefensive
                                    ;

            double standard_deviation_def = data_jumps_defensive.StandardDeviationSample();

            // Assert
            #if NUNIT
            Assert.AreEqual(standard_deviation_def, 5.994, 0.001);
            #elif XUNIT
            Assert.Equal(5.994, standard_deviation_def, 3);
            #elif MSTEST
            Assert.AreEqual(standard_deviation_def, 5.994, 0.001);
            #endif

            return;
        }

        [Test()]
        public void StandardDeviation_Assistence()
        {
            data_assistence =
                                from row in BasketballTeamDataTable
                                select row.Assistence
                                    ;

            double standard_deviation_assist = data_assistence.StandardDeviationSample();

            // Assert
            #if NUNIT
            Assert.AreEqual(standard_deviation_assist, 5.583, 0.001);
            #elif XUNIT
            Assert.Equal(5.583, standard_deviation_assist, 3);
            #elif MSTEST
            Assert.AreEqual(standard_deviation_assist, 5.583, 0.001);
            #endif

            return;
        }

        [Test()]
        public void StandardDeviation_PersonalFaults()
        {
            data_personal_faults =
                                from row in BasketballTeamDataTable
                                select row.PersonalFaults
                                    ;

            double standard_deviation_pf = data_personal_faults.StandardDeviationSample();

            // Assert
            #if NUNIT
            Assert.AreEqual(standard_deviation_pf, 5.274, 0.001);
            #elif XUNIT
            Assert.Equal(5.274, standard_deviation_pf, 3);
            #elif MSTEST
            Assert.AreEqual(standard_deviation_pf, 5.274, 0.001);
            #endif

            return;
        }


        [Test()]
        public void StandardDeviation_BallsLost()
        {
            data_balls_lost =
                                from row in BasketballTeamDataTable
                                select row.BallsLost
                                    ;

            double standard_deviation_bl = data_balls_lost.StandardDeviationSample();

            // Assert
            #if NUNIT
            Assert.AreEqual(standard_deviation_bl, 4.973, 0.001);
            #elif XUNIT
            Assert.Equal(4.973, standard_deviation_bl, 3);
            #elif MSTEST
            Assert.AreEqual(standard_deviation_bl, 4.973, 0.001);
            #endif

            return;
        }


        [Test()]
        public void StandardDeviation_BallsStolen()
        {
            data_balls_stolen =
                                from row in BasketballTeamDataTable
                                select row.BallsStolen
                                    ;

            double standard_deviation_bs = data_balls_stolen.StandardDeviationSample();

            // Assert
            #if NUNIT
            Assert.AreEqual(standard_deviation_bs, 3.387, 0.001);
            #elif XUNIT
            Assert.Equal(3.387, standard_deviation_bs, 3);
            #elif MSTEST
            Assert.AreEqual(standard_deviation_bs, 3.387, 0.001);
            #endif

            return;
        }


        [Test()]
        public void StandardDeviation_Blocks()
        {
            data_blocks =
                                from row in BasketballTeamDataTable
                                select row.Blocks
                                    ;

            double standard_deviation_block = data_blocks.StandardDeviationSample();

            // Assert
            #if NUNIT
            Assert.AreEqual(standard_deviation_block, 2.374, 0.001);
            #elif XUNIT
            Assert.Equal(2.374, standard_deviation_block, 3);
            #elif MSTEST
            Assert.AreEqual(standard_deviation_block, 2.374, 0.001);
            #endif

            return;
        }

    }
}
