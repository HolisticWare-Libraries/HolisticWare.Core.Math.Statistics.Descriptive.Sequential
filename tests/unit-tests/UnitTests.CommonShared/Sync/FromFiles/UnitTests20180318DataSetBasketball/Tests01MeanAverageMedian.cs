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
        IEnumerable<int> data_2pts_success;
        IEnumerable<int> data_3pts_success;
        IEnumerable<int> data_2pts_fail;
        IEnumerable<int> data_3pts_fail;
        IEnumerable<int> data_free_throw_fail;
        IEnumerable<int> data_free_throw_success;
        IEnumerable<int> data_jumps_offensive;
        IEnumerable<int> data_jumps_defensive;
        IEnumerable<int> data_assistence;
        IEnumerable<int> data_personal_faults;
        IEnumerable<int> data_balls_lost;
        IEnumerable<int> data_balls_stolen;
        IEnumerable<int> data_blocks;


        [Test()]
        public void MeanArithmetic_Points2Success()
        {
            data_2pts_success =
                                from row in BasketballTeamDataTable
                                    select row.Points2Success
                                    ;

            double mean_2s_a = data_2pts_success.MeanArithmetic();
            double mean_2s_g = data_2pts_success.MeanGeometric();

            return;
        }

        //double mean_2_a;

        [Test()]
        public void MeanArithmetic_Points3Success()
        {
            data_3pts_success =
                from d in BasketballTeamDataTable
                select d.Points3Success
                        ;

            double mean_3s_a = data_3pts_success.MeanArithmetic();
            double mean_3s_g = data_3pts_success.MeanGeometric();

            //double c = data_3pts_success.Correlation(data_2pts_success);

            //mean_3_a++;

            return;
        }


        [Test()]
        public void MeanArithmetic_Points2Fail()
        {
            data_2pts_fail =
                                from row in BasketballTeamDataTable
                                select row.Points2Fail
                                    ;

            double mean_2f_a = data_2pts_fail.MeanArithmetic();
            double mean_2f_g = data_2pts_fail.MeanGeometric();


            return;
        }


        [Test()]
        public void MeanArithmetic_Points3Fail()
        {
            data_3pts_fail =
                                from row in BasketballTeamDataTable
                                select row.Points3Fail
                                    ;

            double mean_3f_a = data_3pts_fail.MeanArithmetic();
            double mean_3f_g = data_3pts_fail.MeanGeometric();

            return;
        }


        [Test()]
        public void MeanArithmetic_FreeThrowFail()
        {
            data_free_throw_fail =
                                from row in BasketballTeamDataTable
                                select row.FreeThrowFail
                                    ;

            double mean_ftf_a = data_free_throw_fail.MeanArithmetic();
            double mean_ftf_g = data_free_throw_fail.MeanGeometric();

            return;
        }


        [Test()]
        public void MeanArithmetic_FreeThrowSuccess()
        {
            data_free_throw_success =
                                from row in BasketballTeamDataTable
                                select row.FreeThrowSuccess
                                    ;

            double mean_fts_a = data_free_throw_success.MeanArithmetic();
            double mean_fts_g = data_free_throw_success.MeanGeometric();

            return;
        }


        [Test()]
        public void MeanArithmetic_JumpsOffensive()
        {
            data_jumps_offensive =
                                from row in BasketballTeamDataTable
                                select row.JumpsOffensive
                                    ;

            double mean_off_a = data_jumps_offensive.MeanArithmetic();
            double mean_off_g = data_jumps_offensive.MeanGeometric();

            return;
        }

        [Test()]
        public void MeanArithmetic_JumpsDefensive()
        {
            data_jumps_defensive =
                                from row in BasketballTeamDataTable
                                select row.JumpsDefensive
                                    ;

            double mean_def_a = data_jumps_defensive.MeanArithmetic();
            double mean_def_g = data_jumps_defensive.MeanGeometric();

            return;
        }

        [Test()]
        public void MeanArithmetic_Assistence()
        {
            data_assistence =
                                from row in BasketballTeamDataTable
                                select row.Assistence
                                    ;

            double mean_assist_a = data_assistence.MeanArithmetic();
            double mean_assist_g = data_assistence.MeanGeometric();

            return;
        }

        [Test()]
        public void MeanArithmetic_PersonalFaults()
        {
            data_personal_faults =
                                from row in BasketballTeamDataTable
                                select row.PersonalFaults
                                    ;

            double mean_pf_a = data_personal_faults.MeanArithmetic();
            double mean_pf_g = data_personal_faults.MeanGeometric();

            return;
        }


        [Test()]
        public void MeanArithmetic_BallsLost()
        {
            data_balls_lost =
                                from row in BasketballTeamDataTable
                                select row.BallsLost
                                    ;

            double mean_bl_a = data_balls_lost.MeanArithmetic();
            double mean_bl_g = data_balls_lost.MeanGeometric();

            return;
        }


        [Test()]
        public void MeanArithmetic_BallsStolen()
        {
            data_balls_stolen =
                                from row in BasketballTeamDataTable
                                select row.BallsStolen
                                    ;

            double mean_bs_a = data_balls_stolen.MeanArithmetic();
            double mean_bs_g = data_balls_stolen.MeanGeometric();

            return;
        }


        [Test()]
        public void MeanArithmetic_Blocks()
        {
            data_blocks =
                                from row in BasketballTeamDataTable
                                select row.Blocks
                                    ;

            double mean_block_a = data_blocks.MeanArithmetic();
            double mean_block_g = data_blocks.MeanGeometric();

            return;
        }
    }
}
