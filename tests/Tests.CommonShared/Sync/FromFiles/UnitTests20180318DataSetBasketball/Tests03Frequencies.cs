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
        Dictionary<int, (uint FrequencyAbsolute, double FrequencyRelative, uint FrequencyCumulative)> frequency_2s_calculated =
            new Dictionary<int, (uint FrequencyAbsolute, double FrequencyRelative, uint FrequencyCumulative)>
                        {
                            {7, ( 1, 0.0078125, 1 ) },
                            {9, ( 1, 0.0078125, 2 ) },
                            {12, ( 5, 0.0390625, 7 ) },
                            {13, ( 3, 0.0234375, 10 ) },
                            {14, ( 4, 0.0312500, 14 ) },
                            {15, ( 2, 0.0156250, 16 ) },
                            {16, ( 10, 0.0781250, 26 ) },
                            {17, ( 4, 0.0312500, 30 ) },
                            {18, ( 15, 0.1171875, 45 ) },
                            {19, ( 5, 0.0390625, 50 ) },
                            {20, ( 8, 0.0625000, 58 ) },
                            {21, ( 10, 0.0781250, 68 ) },
                            {22, ( 5, 0.0390625, 73 ) },
                            {23, ( 5, 0.0390625, 78 ) },
                            {24, ( 9, 0.0703125, 87 ) },
                            {25, ( 3, 0.0234375, 90 ) },
                            {26, ( 7, 0.0546875, 97 ) },
                            {27, ( 2, 0.0156250, 99 ) },
                            {28, ( 3, 0.0234375, 102 ) },
                            {29, ( 6, 0.0468750, 108 ) },
                            {30, ( 1, 0.0078125, 109 ) },
                            {31, ( 3, 0.0234375, 112 ) },
                            {32, ( 3, 0.0234375, 115 ) },
                            {33, ( 2, 0.0156250, 117 ) },
                            {34, ( 8, 0.0625000, 125 ) },
                            {39, ( 1, 0.0078125, 126 ) },
                            {40, ( 1, 0.0078125, 127 ) },
                            {44, ( 1, 0.0078125, 128 ) },
                        };

        [Test()]
        public void Frequency_Points2Success()
        {
            data_2pts_success =
                                from row in BasketballTeamDataTable
                                    select row.Points2Success
                                    ;

            //List<int> frequency_2s = data_2pts_success.Frequencies();

            IEnumerable<KeyValuePair<int, (uint FrequencyAbsolute, double FrequencyRelative, uint FrequencyCumulative)>> frequency_2s; 

            frequency_2s = data_2pts_success.FrequencyDistribution();


            // Assert
            #if NUNIT && !NUNIT_LITE            CollectionAssert.AreEquivalent                        (
                            frequency_2s_calculated.ToList(),
                            frequency_2s.ToArray()
                        );
            #elif XUNIT
            Assert.Equal
                        (
                            frequency_2s_calculated.ToList(),
                            frequency_2s.ToArray()
                        );
            #elif MSTEST
            CollectionAssert.AreEquivalent
                        (
                            frequency_2s_calculated.ToList(),
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

            IEnumerable<KeyValuePair<int, (uint FrequencyAbsolute, double FrequencyRelative, uint FrequencyCumulative)>> frequency_3s;

            frequency_3s = data_3pts_success.Frequencies();

            return;
        }


        [Test()]
        public void Frequency_Points2Fail()
        {
            data_2pts_fail =
                                from row in BasketballTeamDataTable
                                select row.Points2Fail
                                    ;

            //List<int> frequency_2f = data_2pts_fail.FrequencyDistribution();

            IEnumerable<KeyValuePair<int, (uint FrequencyAbsolute, double FrequencyRelative, uint FrequencyCumulative)>> frequency_2f = data_2pts_fail.Frequencies();


            // Assert
#if NUNIT && !NUNIT_LITE            CollectionAssert.AreEquivalent                        (
                            new Dictionary<int, (uint FrequencyAbsolute, double FrequencyRelative, uint FrequencyCumulative)>()
                                        {
                                            { 28, ( 10, 0.2, 3 ) }, 
                                            { 19, ( 9, 0.2, 3 ) }, 
                                            { 22, ( 8, 0.2, 3 ) }, 
                                            { 21, ( 7, 0.2, 3 ) }, 
                                            { 25, ( 7, 0.2, 3 ) }, 
                                            { 23, ( 7, 0.2, 3 ) }, 
                                            { 20, ( 7, 0.2, 3 ) }, 
                                            { 18, ( 6, 0.2, 3 ) }, 
                                            { 31, ( 6, 0.2, 3 ) }, 
                                            { 15, ( 6, 0.2, 3 ) }, 
                                            { 16, ( 6, 0.2, 3 ) }, 
                                            { 30, ( 5, 0.2, 3 ) }, 
                                            { 24, ( 5, 0.2, 3 ) }, 
                                            { 12, ( 5, 0.2, 3 ) }, 
                                            { 26, ( 5, 0.2, 3 ) }, 
                                            { 17, ( 5, 0.2, 3 ) }, 
                                            { 11, ( 4, 0.2, 3 ) }, 
                                            { 13, ( 4, 0.2, 3 ) }, 
                                            { 27, ( 3, 0.2, 3 ) }, 
                                            { 29, ( 3, 0.2, 3 ) }, 
                                            { 14, ( 3, 0.2, 3 ) }, 
                                            { 36, ( 2, 0.2, 3 ) }, 
                                            { 9, ( 2, 0.2, 3 ) }, 
                                            { 45, ( 1, 0.2, 3 ) }, 
                                            { 33, ( 1, 0.2, 3 ) }, 
                                            { 8, ( 1, 0.2, 3 ) },             
                                        }
                                .ToList(),
                            frequency_2f
                        );
#elif XUNIT
            Assert.Equal
                        (
                            new Dictionary<int, (uint FrequencyAbsolute, double FrequencyRelative, uint FrequencyCumulative) >
                                        {
                                            { 28, ( 10, 0.2, 3 ) }, 
                                            { 19, ( 9, 0.2, 3 ) }, 
                                            { 22, ( 8, 0.2, 3 ) }, 
                                            { 21, ( 7, 0.2, 3 ) }, 
                                            { 25, ( 7, 0.2, 3 ) }, 
                                            { 23, ( 7, 0.2, 3 ) }, 
                                            { 20, ( 7, 0.2, 3 ) }, 
                                            { 18, ( 6, 0.2, 3 ) }, 
                                            { 31, ( 6, 0.2, 3 ) }, 
                                            { 15, ( 6, 0.2, 3 ) }, 
                                            { 16, ( 6, 0.2, 3 ) }, 
                                            { 30, ( 5, 0.2, 3 ) }, 
                                            { 24, ( 5, 0.2, 3 ) }, 
                                            { 12, ( 5, 0.2, 3 ) }, 
                                            { 26, ( 5, 0.2, 3 ) }, 
                                            { 17, ( 5, 0.2, 3 ) }, 
                                            { 11, ( 4 , 0.2, 3 )}, 
                                            { 13, ( 4, 0.2, 3 ) }, 
                                            { 27, ( 3, 0.2, 3 ) }, 
                                            { 29, ( 3, 0.2, 3 ) }, 
                                            { 14, ( 3, 0.2, 3 ) }, 
                                            { 36, ( 2, 0.2, 3 ) }, 
                                            { 9, ( 2, 0.2, 3 ) }, 
                                            { 45, ( 1, 0.2, 3 ) }, 
                                            { 33, ( 1, 0.2, 3 ) }, 
                                            { 8, ( 1, 0.2, 3 ) },             
                                        }
                                .ToList(),
                                frequency_2f.ToArray()
                        );
#elif MSTEST
            CollectionAssert.AreEquivalent
                        (
                            new Dictionary<int, ( uint FrequencyAbsolute, double FrequencyRelative, uint FrequencyCumulative)>
                                        {
                                            { 28, ( 10, 0.2, 3 ) }, 
                                            { 19, ( 9, 0.2, 3 ) }, 
                                            { 22, ( 8, 0.2, 3 ) }, 
                                            { 21, ( 7, 0.2, 3 ) }, 
                                            { 25, ( 7, 0.2, 3 ) }, 
                                            { 23, ( 7, 0.2, 3 ) }, 
                                            { 20, ( 7, 0.2, 3 ) }, 
                                            { 18, ( 6, 0.2, 3 ) }, 
                                            { 31, ( 6, 0.2, 3 ) }, 
                                            { 15, ( 6, 0.2, 3 ) }, 
                                            { 16, ( 6, 0.2, 3 ) }, 
                                            { 30, ( 5, 0.2, 3 ) }, 
                                            { 24, ( 5, 0.2, 3 ) }, 
                                            { 12, ( 5, 0.2, 3 ) }, 
                                            { 26, ( 5, 0.2, 3 ) }, 
                                            { 17, ( 5, 0.2, 3 ) }, 
                                            { 11, ( 4, 0.2, 3 ) }, 
                                            { 13, ( 4, 0.2, 3 ) }, 
                                            { 27, ( 3, 0.2, 3 ) }, 
                                            { 29, ( 3, 0.2, 3 ) }, 
                                            { 14, ( 3, 0.2, 3 ) }, 
                                            { 36, ( 2, 0.2, 3 ) }, 
                                            { 9, ( 2, 0.2, 3 ) }, 
                                            { 45, ( 1, 0.2, 3 ) }, 
                                            { 33, ( 1, 0.2, 3 ) }, 
                                            { 8, ( 1, 0.2, 3 ) },             
                                        }
                                .ToList(),
                            frequency_2f.ToArray()
                        );
#endif

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

            IEnumerable<KeyValuePair<int, (uint FrequencyAbsolute, double FrequencyRelative, uint FrequencyCumulative)>> frequency_3f = data_3pts_fail.Frequencies();

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

            IEnumerable<KeyValuePair<int, (uint FrequencyAbsolute, double FrequencyRelative, uint FrequencyCumulative)>> frequency_ftf = data_free_throw_fail.Frequencies();

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

            IEnumerable<KeyValuePair<int, (uint FrequencyAbsolute, double FrequencyRelative, uint FrequencyCumulative)>> frequency_fts = data_free_throw_success.Frequencies();

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

            IEnumerable<KeyValuePair<int, (uint FrequencyAbsolute, double FrequencyRelative, uint FrequencyCumulative)>> frequency_off = data_jumps_offensive.Frequencies();

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

            IEnumerable<KeyValuePair<int, (uint FrequencyAbsolute, double FrequencyRelative, uint FrequencyCumulative)>> frequency_def = data_jumps_defensive.Frequencies();

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

            IEnumerable<KeyValuePair<int, (uint FrequencyAbsolute, double FrequencyRelative, uint FrequencyCumulative)>> frequency_assist = data_assistence.Frequencies();

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

            IEnumerable<KeyValuePair<int, (uint FrequencyAbsolute, double FrequencyRelative, uint FrequencyCumulative)>> frequency_pf = data_personal_faults.Frequencies();

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

            IEnumerable<KeyValuePair<int, (uint FrequencyAbsolute, double FrequencyRelative, uint FrequencyCumulative)>> frequency_bl = data_balls_lost.Frequencies();

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

            IEnumerable<KeyValuePair<int, (uint FrequencyAbsolute, double FrequencyRelative, uint FrequencyCumulative)>> frequency_bs = data_balls_stolen.Frequencies();

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

            IEnumerable<KeyValuePair<int, (uint FrequencyAbsolute, double FrequencyRelative, uint FrequencyCumulative)>> frequency_block = data_blocks.Frequencies();

            return;
        }

    }
}
