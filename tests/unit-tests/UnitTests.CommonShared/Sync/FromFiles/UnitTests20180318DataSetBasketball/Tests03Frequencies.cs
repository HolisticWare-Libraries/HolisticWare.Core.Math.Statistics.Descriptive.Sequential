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
        public void Frequency_Points2Success()
        {
            data_2pts_success =
                                from row in BasketballTeamDataTable
                                    select row.Points2Success
                                    ;

            //List<int> frequency_2s = data_2pts_success.Frequencies();

            IEnumerable<KeyValuePair<int, uint>> frequency_2s = data_2pts_success.Frequencies();

            // Assert
            #if NUNIT
            CollectionAssert.AreEquivalent
                        (
                            new Dictionary<int, uint>
                                        {
                                            { 2, 1 },
                                            { 3, 1 },
                                            { 4, 1 },
                                            { 5, 5 },
                                            { 6, 6 },
                                            { 7, 6 },
                                            { 8, 4 },
                                            { 9, 5 },
                                            { 10, 6 },
                                            { 11, 8 },
                                            { 12, 8 },
                                            { 13, 4 },
                                            { 14, 6 },
                                            { 15, 4 },
                                            { 16, 6 },
                                            { 17, 5 },
                                            { 18, 6 },
                                            { 19, 8 },
                                            { 20, 7 },
                                            { 21, 6 },
                                            { 22, 2 },
                                            { 23, 2 },
                                            { 24, 5 },
                                            { 25, 3 },
                                            { 26, 2 },
                                            { 27, 2 },
                                            { 28, 2 },
                                            { 30, 2 },
                                            { 31, 1 },
                                            { 33, 1 },
                                            { 34, 1 },
                                            { 36, 1 },
                                            { 37, 1 },
                                        }
                                .ToList(),
                            frequency_2s
                        );
            #elif XUNIT
            Assert.Equal
                        (
                            new Dictionary<int, uint>
                                        {
                                            { 2, 1 },
                                            { 3, 1 },
                                            { 4, 1 },
                                            { 5, 5 },
                                            { 6, 6 },
                                            { 7, 6 },
                                            { 8, 4 },
                                            { 9, 5 },
                                            { 10, 6 },
                                            { 11, 8 },
                                            { 12, 8 },
                                            { 13, 4 },
                                            { 14, 6 },
                                            { 15, 4 },
                                            { 16, 6 },
                                            { 17, 5 },
                                            { 18, 6 },
                                            { 19, 8 },
                                            { 20, 7 },
                                            { 21, 6 },
                                            { 22, 2 },
                                            { 23, 2 },
                                            { 24, 5 },
                                            { 25, 3 },
                                            { 26, 2 },
                                            { 27, 2 },
                                            { 28, 2 },
                                            { 30, 2 },
                                            { 31, 1 },
                                            { 33, 1 },
                                            { 34, 1 },
                                            { 36, 1 },
                                            { 37, 1 },
                                        }
                                .ToList(),
                                frequency_2s.ToArray()
                        );
            #elif MSTEST
            CollectionAssert.AreEquivalent
                        (
                            new Dictionary<int, uint>
                                        {
                                            { 2, 1 },
                                            { 3, 1 },
                                            { 4, 1 },
                                            { 5, 5 },
                                            { 6, 6 },
                                            { 7, 6 },
                                            { 8, 4 },
                                            { 9, 5 },
                                            { 10, 6 },
                                            { 11, 8 },
                                            { 12, 8 },
                                            { 13, 4 },
                                            { 14, 6 },
                                            { 15, 4 },
                                            { 16, 6 },
                                            { 17, 5 },
                                            { 18, 6 },
                                            { 19, 8 },
                                            { 20, 7 },
                                            { 21, 6 },
                                            { 22, 2 },
                                            { 23, 2 },
                                            { 24, 5 },
                                            { 25, 3 },
                                            { 26, 2 },
                                            { 27, 2 },
                                            { 28, 2 },
                                            { 30, 2 },
                                            { 31, 1 },
                                            { 33, 1 },
                                            { 34, 1 },
                                            { 36, 1 },
                                            { 37, 1 },
                                        }
                                .ToList(),
                            frequency_2s.ToArray()
                        );
                #endif

                return;
        }


        [Test()]
            public void Frequency_Points3Success()
        {
            data_3pts_success =
                                from row in BasketballTeamDataTable
                                    select row.Points3Success
                                    ;

            //List<int> frequency_3s = data_3pts_success.FrequencyDistribution();

            IEnumerable<KeyValuePair<int, uint>> frequency_3s = data_3pts_success.Frequencies();

            return;
        }


        [Test()]
            public void Frequency_Points2Fail()
        {
            data_2pts_fail =
                                from row in BasketballTeamDataTable
                                    select row.Points2Fail
                                    ;

            //List<int> frequency_2f = data_3pts_fail.FrequencyDistribution();

            IEnumerable<KeyValuePair<int, uint>> frequency_2f = data_3pts_fail.Frequencies
            ();

            return;
        }


        [Test()]
            public void Frequency_Points3Fail()
        {
            data_3pts_fail =
                                from row in BasketballTeamDataTable
                                    select row.Points3Fail
                                    ;

            //List<int> frequency_3f = data_3pts_fail.FrequencyDistribution();

            IEnumerable<KeyValuePair<int, uint>> frequency_3f = data_3pts_fail.Frequencies();

            return;
        }


        [Test()]
            public void Frequency_FreeThrowFail()
        {
            data_free_throw_fail =
                                from row in BasketballTeamDataTable
                                    select row.FreeThrowFail
                                    ;

            //List<int> frequency_ftf = data_free_throw_fail.FrequencyDistribution();

            IEnumerable<KeyValuePair<int, uint>> frequency_ftf = data_free_throw_fail.Frequencies();

            return;
        }


        [Test()]
            public void Frequency_FreeThrowSuccess()
        {
            data_free_throw_success =
                                from row in BasketballTeamDataTable
                                    select row.FreeThrowSuccess
                                    ;

            //List<int> frequency_fts = data_free_throw_success.FrequencyDistribution();

            IEnumerable<KeyValuePair<int, uint>> frequency_fts = data_free_throw_success.Frequencies();

            return;
        }


        [Test()]
            public void Frequency_JumpsOffensive()
        {
            data_jumps_offensive =
                                from row in BasketballTeamDataTable
                                    select row.JumpsOffensive
                                    ;

            //List<int> frequency_off = data_jumps_offensive.FrequencyDistribution();

            IEnumerable<KeyValuePair<int, uint>> frequency_off = data_jumps_offensive.Frequencies();

            return;
        }


        [Test()]
            public void Frequency_JumpsDefensive()
        {
            data_jumps_defensive =
                                from row in BasketballTeamDataTable
                                    select row.JumpsDefensive
                                    ;

            //List<int> frequency_def = data_jumps_defensive.FrequencyDistribution();

            IEnumerable<KeyValuePair<int, uint>> frequency_def = data_jumps_defensive.Frequencies();

            return;
        }


        [Test()]
        public void Frequency_Assistance()
        {
            data_assistence =
                                from row in BasketballTeamDataTable
                                    select row.Assistence
                                    ;

            //List<int> frequency_assist = data_assistence.FrequencyDistribution();

            IEnumerable<KeyValuePair<int, uint>> frequency_assist = data_assistence.Frequencies();

            return;
        }


        [Test()]
            public void Frequency_PersonalFaults()
        {
            data_personal_faults =
                                from row in BasketballTeamDataTable
                                    select row.PersonalFaults
                                    ;

            //List<int> frequency_pf = data_personal_faults.FrequencyDistribution();

            IEnumerable<KeyValuePair<int, uint>> frequency_pf = data_personal_faults.Frequencies();

            return;
        }


        [Test()]
            public void Frequency_BallsLost()
        {
            data_balls_lost =
                                from row in BasketballTeamDataTable
                                    select row.BallsLost
                                    ;

            //List<int> frequency_bl = data_balls_lost.FrequencyDistribution();

            IEnumerable<KeyValuePair<int, uint>> frequency_bl = data_balls_lost.Frequencies();

            return;
        }


        [Test()]
            public void Frequency_BallsStolen()
        {
            data_balls_stolen =
                                from row in BasketballTeamDataTable
                                    select row.BallsStolen
                                    ;

            //List<int> frequency_bs = data_balls_stolen.FrequencyDistribution();

            IEnumerable<KeyValuePair<int, uint>> frequency_bs = data_balls_stolen.Frequencies();

            return;
        }


        [Test()]
            public void Frequency_Blocks()
        {
            data_blocks =
                                from row in BasketballTeamDataTable
                                    select row.Blocks
                                    ;

            //List<int> frequency_block = data_blocks.FrequencyDistribution();

            IEnumerable<KeyValuePair<int, uint>> frequency_block = data_blocks.Frequencies();

            return;
        }

    }
}
