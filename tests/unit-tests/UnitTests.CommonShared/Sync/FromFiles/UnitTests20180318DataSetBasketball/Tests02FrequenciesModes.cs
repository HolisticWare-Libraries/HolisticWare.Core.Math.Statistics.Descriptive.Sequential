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
        public void Mode_Points2Success()
        {
            data_2pts_success =
                                from row in basketball_team_data_table
                                select row.Points2Success
                                    ;

            List<int> modes_2s = data_2pts_success.Modes();

            return;
        }


        [Test()]
        public void Mode_Points3Success()
        {
            data_3pts_success =
                                from row in basketball_team_data_table
                                select row.Points3Success
                                    ;

            List<int> modes_3s = data_3pts_success.Modes();

            return;
        }


        [Test()]
        public void Mode_Points2Fail()
        {
            data_2pts_fail =
                                from row in basketball_team_data_table
                                select row.Points2Fail
                                    ;

            List<int> modes_2f = data_2pts_fail.Modes();

            return;
        }


        [Test()]
        public void Mode_Points3Fail()
        {
            data_3pts_fail =
                                from row in basketball_team_data_table
                                select row.Points3Fail
                                    ;

            List<int> modes_3f = data_3pts_fail.Modes();

            return;
        }


        [Test()]
        public void Mode_FreeThrowFail()
        {
            data_free_throw_fail =
                                from row in basketball_team_data_table
                                select row.FreeThrowFail
                                    ;

            List<int> modes_ftf = data_free_throw_fail.Modes();

            return;
        }


        [Test()]
        public void Mode_FreeThrowSuccess()
        {
            data_free_throw_success =
                                from row in basketball_team_data_table
                                select row.FreeThrowSuccess
                                    ;

            List<int> modes_fts = data_free_throw_success.Modes();

            return;
        }


        [Test()]
        public void Mode_JumpsOffensive()
        {
            data_jumps_offensive =
                                from row in basketball_team_data_table
                                select row.JumpsOffensive
                                    ;

            List<int> modes_off = data_jumps_offensive.Modes();

            return;
        }


        [Test()]
        public void Mode_JumpsDefensive()
        {
            data_jumps_defensive =
                                from row in basketball_team_data_table
                                select row.JumpsDefensive
                                    ;

            List<int> modes_def = data_jumps_defensive.Modes();

            return;
        }


        [Test()]
        public void Mode_Assistance()
        {
            data_assistence =
                                from row in basketball_team_data_table
                                select row.Assistence
                                    ;

            List<int> modes_assist = data_assistence.Modes();

            return;
        }


        [Test()]
        public void Mode_PersonalFaults()
        {
            data_personal_faults =
                                from row in basketball_team_data_table
                                select row.PersonalFaults
                                    ;

            List<int> modes_pf = data_personal_faults.Modes();

            return;
        }


        [Test()]
        public void Mode_BallsLost()
        {
            data_balls_lost =
                                from row in basketball_team_data_table
                                select row.BallsLost
                                    ;

            List<int> modes_bl = data_balls_lost.Modes();

            return;
        }


        [Test()]
        public void Mode_BallsStolen()
        {
            data_balls_stolen =
                                from row in basketball_team_data_table
                                select row.BallsStolen
                                    ;

            List<int> modes_bs = data_balls_stolen.Modes();

            return;
        }


        [Test()]
        public void Mode_Blocks()
        {
            data_blocks =
                                from row in basketball_team_data_table
                                select row.Blocks
                                    ;

            List<int> modes_block = data_blocks.Modes();

            return;
        }

    }
}
