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
    public partial class UnitTests20180318DataSetJudo
    {
        //--------------------------------------------------------------------------------------------------------------------------
        #region     Precalculated test data - R calculated
        Dictionary<double, (uint FrequencyAbsolute, double FrequencyRelative, uint FrequencyCumulative)> frequency_distribution_ont_calculated =
            new Dictionary<double, (uint FrequencyAbsolute, double FrequencyRelative, uint FrequencyCumulative)>
                        {
                            {10.5, (1, 0.01666667, 1) },
                            {11.3, (1, 0.01666667, 2) },
                            {11.6, (1, 0.01666667, 3) },
                            {11.7, (1, 0.01666667, 4) },
                            {11.9, (1, 0.01666667, 6) },
                            {12.1, (1, 0.01666667, 7) },
                            {12.2, (1, 0.01666667, 8) },
                            {12.7, (1, 0.01666667, 9) },
                            {12.9, (2, 0.03333333, 11) },
                            {13.0, (1, 0.01666667, 12) },
                            {13.3, (1, 0.01666667, 13) },
                            {13.4, (2, 0.03333333, 15) },
                            {13.5, (2, 0.03333333, 17) },
                            {13.6, (1, 0.01666667, 18) },
                            {13.7, (1, 0.01666667, 19) },
                            {13.8, (1, 0.01666667, 20) },
                            {14.3, (1, 0.01666667, 21) },
                            {14.5, (1, 0.01666667, 22) },
                            {14.7, (3, 0.05000000, 25) },
                            {15.0, (2, 0.03333333, 27) },
                            {15.1, (1, 0.01666667, 28) },
                            {15.2, (1, 0.01666667, 29) },
                            {15.3, (1, 0.01666667, 30) },
                            {15.5, (1, 0.01666667, 31) },
                            {15.9, (1, 0.01666667, 32) },
                            {16.0, (1, 0.01666667, 33) },
                            {16.1, (1, 0.01666667, 34) },
                            {16.2, (2, 0.03333333, 36) },
                            {16.4, (2, 0.03333333, 38) },
                            {16.5, (1, 0.01666667, 39) },
                            {16.8, (1, 0.01666667, 40) },
                            {16.9, (1, 0.01666667, 41) },
                            {17.0, (1, 0.01666667, 42) },
                            {17.1, (1, 0.01666667, 43) },
                            {17.4, (1, 0.01666667, 44) },
                            {17.5, (1, 0.01666667, 45) },
                            {17.6, (1, 0.01666667, 46) },
                            {18.0, (1, 0.01666667, 47) },
                            {18.2, (3, 0.05000000, 50) },
                            {18.6, (2, 0.03333333, 52) },
                            {19.3, (1, 0.01666667, 53) },
                            {19.4, (1, 0.01666667, 54) },
                            {19.5, (1, 0.01666667, 55) },
                            {19.8, (1, 0.01666667, 56) },
                            {22.9, (1, 0.01666667, 57) },
                            {24.0, (1, 0.01666667, 58) },
                            {25.4, (1, 0.01666667, 59) },
                            {28.9, (1, 0.01666667, 60) },
                        };

        Dictionary<double, (uint FrequencyAbsolute, double FrequencyRelative, uint FrequencyCumulative)> frequency_distribution_ouz_calculated =
              new Dictionary<double, (uint FrequencyAbsolute, double FrequencyRelative, uint FrequencyCumulative)>
                          {
                            {2.9,   (1, 0.01666667,  1) },
                            {3,     (1, 0.01666667,  2) },
                            {3.1,   (1, 0.01666667,  3) },
                            {3.2,   (2, 0.03333333,  5) },
                            {3.3,   (4, 0.06666667,  9) },
                            {3.4,   (9, 0.15000000, 18) },
                            {3.5,   (1, 0.01666667, 19) },
                            {3.6,   (2, 0.03333333, 21) },
                            {3.7,   (5, 0.08333333, 26) },
                            {3.8,   (2, 0.03333333, 28) },
                            {3.9,   (4, 0.06666667, 32) },
                            {4,     (6, 0.10000000, 38) },
                            {4.1,   (3, 0.05000000, 41) },
                            {4.2,   (6, 0.10000000, 47) },
                            {4.3,   (2, 0.03333333, 49) },
                            {4.4,   (1, 0.01666667, 50) },
                            {4.5,   (1, 0.01666667, 51) },
                            {4.7,   (4, 0.06666667, 55) },
                            {4.8,   (3, 0.05000000, 58) },
                            {4.9,   (1, 0.01666667, 59) },
                            {5.4,   (1, 0.01666667, 60) },
                          };

        Dictionary<int, (uint FrequencyAbsolute, double FrequencyRelative, uint FrequencyCumulative)> frequency_distribution_neb_calculated =
              new Dictionary<int, (uint FrequencyAbsolute, double FrequencyRelative, uint FrequencyCumulative)>
                          {
                            {2,      ( 1, 0.01666667,  1) },
                            {3,      ( 1, 0.01666667,  2) },
                            {4,      ( 2, 0.03333333,  4) },
                            {6,      ( 1, 0.01666667,  5) },
                            {7,      ( 4, 0.06666667,  9) },
                            {8,      ( 6, 0.10000000, 15) },
                            {9,      (11, 0.18333333, 26) },
                            {10,     ( 9, 0.15000000, 35) },
                            {11,     ( 9, 0.15000000, 44) },
                            {12,     ( 5, 0.08333333, 49) },
                            {13,     ( 3, 0.05000000, 52) },
                            {14,     ( 3, 0.05000000, 55) },
                            {15,     ( 2, 0.03333333, 57) },
                            {17,     ( 2, 0.03333333, 59) },
                            {18,     ( 1, 0.01666667, 60) },
                          };

        Dictionary<int, (uint FrequencyAbsolute, double FrequencyRelative, uint FrequencyCumulative)> frequency_distribution_skl_calculated =
              new Dictionary<int, (uint FrequencyAbsolute, double FrequencyRelative, uint FrequencyCumulative)>
                          {
                            {1,       (2, 0.03333333,  2) },
                            {3,       (3, 0.05000000,  5) },
                            {4,       (1, 0.01666667,  6) },
                            {6,       (2, 0.03333333,  8) },
                            {7,       (2, 0.03333333, 10) },
                            {8,       (1, 0.01666667, 11) },
                            {9,       (2, 0.03333333, 13) },
                            {10,      (2, 0.03333333, 15) },
                            {11,      (2, 0.03333333, 17) },
                            {12,      (3, 0.05000000, 20) },
                            {13,      (6, 0.10000000, 26) },
                            {14,      (3, 0.05000000, 29) },
                            {15,      (2, 0.03333333, 31) },
                            {18,      (3, 0.05000000, 34) },
                            {19,      (1, 0.01666667, 35) },
                            {20,      (9, 0.15000000, 44) },
                            {22,      (3, 0.05000000, 47) },
                            {23,      (1, 0.01666667, 48) },
                            {25,      (2, 0.03333333, 50) },
                            {26,      (2, 0.03333333, 52) },
                            {30,      (2, 0.03333333, 54) },
                            {31,      (2, 0.03333333, 56) },
                            {32,      (1, 0.01666667, 57) },
                            {33,      (1, 0.01666667, 58) },
                            {34,      (2, 0.0333333 , 60) },
                          };

        Dictionary<int, (uint FrequencyAbsolute, double FrequencyRelative, uint FrequencyCumulative)> frequency_distribution_trb_calculated =
              new Dictionary<int, (uint FrequencyAbsolute, double FrequencyRelative, uint FrequencyCumulative)>
                          {
                            {6,     (1, 0.01666667,  1) },
                            {10,     (1, 0.01666667,  2) },
                            {14,     (1, 0.01666667,  3) },
                            {15,     (1, 0.01666667,  4) },
                            {16,     (1, 0.01666667,  5) },
                            {19,     (1, 0.01666667,  6) },
                            {20,     (5, 0.08333333, 11) },
                            {21,     (1, 0.01666667, 12) },
                            {22,     (1, 0.01666667, 13) },
                            {26,     (3, 0.05000000, 16) },
                            {27,     (3, 0.05000000, 19) },
                            {29,     (1, 0.01666667, 20) },
                            {30,     (7, 0.11666667, 27) },
                            {31,     (2, 0.03333333, 29) },
                            {33,     (2, 0.03333333, 31) },
                            {34,     (3, 0.05000000, 34) },
                            {35,     (4, 0.06666667, 38) },
                            {36,     (2, 0.03333333, 40) },
                            {38,     (1, 0.01666667, 41) },
                            {39,     (1, 0.01666667, 42) },
                            {40,     (2, 0.03333333, 44) },
                            {41,     (2, 0.03333333, 46) },
                            {42,     (2, 0.03333333, 48) },
                            {44,     (1, 0.01666667, 49) },
                            {46,     (1, 0.01666667, 50) },
                            {49,     (1, 0.01666667, 51) },
                            {50,     (2, 0.03333333, 53) },
                            {51,     (1, 0.01666667, 54) },
                            {61,     (1, 0.01666667, 55) },
                            {71,     (1, 0.01666667, 56) },
                            {75,     (1, 0.01666667, 57) },
                            {79,     (1, 0.01666667, 58) },
                            {80,     (1, 0.01666667, 59) },
                            {81,     (1, 0.01666667, 60) },
                          };

        Dictionary<int, (uint FrequencyAbsolute, double FrequencyRelative, uint FrequencyCumulative)> frequency_distribution_cuc_calculated =
              new Dictionary<int, (uint FrequencyAbsolute, double FrequencyRelative, uint FrequencyCumulative)>
                          {
                            {76,     (1, 0.01666667,  1) },
                            {77,     (1, 0.01666667,  2) },
                            {89,     (1, 0.01666667,  3) },
                            {98,     (1, 0.01666667,  4) },
                            {100,    (2, 0.03333333,  6) },
                            {101,    (1, 0.01666667,  7) },
                            {107,    (2, 0.03333333,  9) },
                            {110,    (2, 0.03333333, 11) },
                            {120,    (1, 0.01666667, 12) },
                            {122,    (1, 0.01666667, 13) },
                            {123,    (1, 0.01666667, 14) },
                            {127,    (1, 0.01666667, 15) },
                            {128,    (1, 0.01666667, 16) },
                            {130,    (3, 0.05000000, 19) },
                            {132,    (1, 0.01666667, 20) },
                            {150,    (3, 0.05000000, 23) },
                            {156,    (1, 0.01666667, 24) },
                            {160,    (1, 0.01666667, 25) },
                            {164,    (1, 0.01666667, 26) },
                            {165,    (1, 0.01666667, 27) },
                            {170,    (2, 0.03333333, 29) },
                            {180,    (1, 0.01666667, 30) },
                            {189,    (1, 0.01666667, 31) },
                            {190,    (3, 0.05000000, 34) },
                            {200,    (2, 0.03333333, 36) },
                            {204,    (1, 0.01666667, 37) },
                            {206,    (1, 0.01666667, 38) },
                            {207,    (1, 0.01666667, 39) },
                            {210,    (1, 0.01666667, 40) },
                            {220,    (1, 0.01666667, 41) },
                            {221,    (1, 0.01666667, 42) },
                            {232,    (1, 0.01666667, 43) },
                            {238,    (1, 0.01666667, 44) },
                            {240,    (2, 0.03333333, 46) },
                            {300,    (2, 0.03333333, 48) },
                            {302,    (1, 0.01666667, 49) },
                            {310,    (1, 0.01666667, 50) },
                            {320,    (1, 0.01666667, 51) },
                            {350,    (1, 0.01666667, 52) },
                            {380,    (1, 0.01666667, 53) },
                            {394,    (1, 0.01666667, 54) },
                            {400,    (1, 0.01666667, 55) },
                            {450,    (2, 0.03333333, 57) },
                            {460,    (1, 0.01666667, 58) },
                            {500,    (2, 0.03333333, 60) },
                          };

        Dictionary<int, (uint FrequencyAbsolute, double FrequencyRelative, uint FrequencyCumulative)> frequency_distribution_sdm_calculated =
              new Dictionary<int, (uint FrequencyAbsolute, double FrequencyRelative, uint FrequencyCumulative)>
                          {
                            {135,    (1, 0.01666667,  1) },
                            {150,    (4, 0.06666667,  5) },
                            {155,    (3, 0.05000000,  8) },
                            {160,    (5, 0.08333333, 13) },
                            {165,    (4, 0.06666667, 17) },
                            {170,    (5, 0.08333333, 22) },
                            {175,    (8, 0.13333333, 30) },
                            {180,    (9, 0.15000000, 39) },
                            {185,    (3, 0.05000000, 42) },
                            {190,    (5, 0.08333333, 47) },
                            {195,    (6, 0.10000000, 53) },
                            {200,    (2, 0.03333333, 55) },
                            {205,    (4, 0.06666667, 59) },
                            {210,    (1, 0.01666667, 60) },
                          };

        Dictionary<int, (uint FrequencyAbsolute, double FrequencyRelative, uint FrequencyCumulative)> frequency_distribution_bml_calculated =
              new Dictionary<int, (uint FrequencyAbsolute, double FrequencyRelative, uint FrequencyCumulative)>
                          {
                            {330,    (1, 0.01666667,  1) },
                            {340,    (2, 0.03333333,  3) },
                            {370,    (1, 0.01666667,  4) },
                            {380,    (1, 0.01666667,  5) },
                            {390,    (1, 0.01666667,  6) },
                            {420,    (1, 0.01666667,  7) },
                            {430,    (2, 0.03333333,  9) },
                            {440,    (1, 0.01666667, 10) },
                            {460,    (5, 0.08333333, 15) },
                            {470,    (2, 0.03333333, 17) },
                            {480,    (1, 0.01666667, 18) },
                            {490,    (1, 0.01666667, 19) },
                            {500,    (3, 0.05000000, 22) },
                            {510,    (4, 0.06666667, 26) },
                            {520,    (5, 0.08333333, 31) },
                            {530,    (1, 0.01666667, 32) },
                            {540,    (2, 0.03333333, 34) },
                            {550,    (1, 0.01666667, 35) },
                            {560,    (3, 0.05000000, 38) },
                            {570,    (2, 0.03333333, 40) },
                            {580,    (4, 0.06666667, 44) },
                            {590,    (1, 0.01666667, 45) },
                            {600,    (1, 0.01666667, 46) },
                            {610,    (3, 0.05000000, 49) },
                            {620,    (3, 0.05000000, 52) },
                            {630,    (1, 0.01666667, 53) },
                            {650,    (3, 0.05000000, 56) },
                            {670,    (1, 0.01666667, 57) },
                            {690,    (1, 0.01666667, 58) },
                            {730,    (1, 0.01666667, 59) },
                            {740,    (1, 0.01666667, 60) },
                          };



        #endregion  Precalculated test data - R calculated
        //--------------------------------------------------------------------------------------------------------------------------

        //--------------------------------------------------------------------------------------------------------------------------
        #region Tests (UnitTest and Benchmark) Frequency_ONT
        [Benchmark]
        public
            IEnumerable<KeyValuePair<double, (uint FrequencyAbsolute, double FrequencyRelative, uint FrequencyCumulative)>>
                Frequency_ONT()
        {
            return data_ont.FrequencyDistribution(); ;
        }

        [Test()]
        public void Frequency_ONT_Test()
        {
            data_ont =
                                from row in JudoDataTable
                                select row.ONT
                                    ;
                                          
            IEnumerable<KeyValuePair<double, (uint FrequencyAbsolute, double FrequencyRelative, uint FrequencyCumulative)>> frequency_ont;

            frequency_ont = Frequency_ONT();


            // Assert
#if NUNIT && !NUNIT_LITE            
            CollectionAssert.AreEquivalent
                        (
                            frequency_distribution_ont_calculated.ToList(),
                            frequency_ont.ToArray()
                        );
#elif XUNIT

            Assert.Equal
                        (
                            frequency_distribution_ont_calculated.ToList(),
                            frequency_ont.ToArray()
                        );
#elif MSTEST
            CollectionAssert.AreEquivalent
                        (
                            frequency_distribution_ont_calculated.ToList(),
                            frequency_ont.ToArray()
                        );
#endif

            return;
        }
        #endregion Tests (UnitTest and Benchmark) Frequency_ONT
        //--------------------------------------------------------------------------------------------------------------------------

        //--------------------------------------------------------------------------------------------------------------------------
        #region Tests (UnitTest and Benchmark) Frequency_OUZ
        [Benchmark]
        public
            IEnumerable<KeyValuePair<double, (uint FrequencyAbsolute, double FrequencyRelative, uint FrequencyCumulative)>>
                Frequency_OUZ()
        {
            return data_ouz.FrequencyDistribution(); ;
        }

        [Test()]
        public void Frequency_OUZ_Test()
        {
            data_ouz =
                                from row in JudoDataTable
                                select row.OUZ
                                    ;

            IEnumerable<KeyValuePair<double, (uint FrequencyAbsolute, double FrequencyRelative, uint FrequencyCumulative)>> frequency_ouz;

            frequency_ouz = Frequency_OUZ();


            // Assert
#if NUNIT && !NUNIT_LITE            
            CollectionAssert.AreEquivalent
                        (
                            frequency_distribution_ouz_calculated.ToList(),
                            frequency_ouz.ToArray()
                        );
#elif XUNIT

            Assert.Equal
                        (
                            frequency_distribution_ouz_calculated.ToList(),
                            frequency_ouz.ToArray()
                        );
#elif MSTEST
            CollectionAssert.AreEquivalent
                        (
                            frequency_distribution_ouz_calculated.ToList(),
                            frequency_ouz.ToArray()
                        );
#endif

            return;
        }
        #endregion Tests (UnitTest and Benchmark) Frequency_OUZ
        //--------------------------------------------------------------------------------------------------------------------------

        //--------------------------------------------------------------------------------------------------------------------------
        #region Tests (UnitTest and Benchmark) Frequency_NEB
        [Benchmark]
        public
            IEnumerable<KeyValuePair<int, (uint FrequencyAbsolute, double FrequencyRelative, uint FrequencyCumulative)>>
                Frequency_NEB()
        {
            return data_neb.FrequencyDistribution(); ;
        }

        [Test()]
        public void Frequency_NEB_Test()
        {
            data_neb =
                                from row in JudoDataTable
                                select row.NEB
                                    ;

            IEnumerable<KeyValuePair<int, (uint FrequencyAbsolute, double FrequencyRelative, uint FrequencyCumulative)>> frequency_neb;

            frequency_neb = Frequency_NEB();


            // Assert
#if NUNIT && !NUNIT_LITE            
            CollectionAssert.AreEquivalent
                        (
                            frequency_distribution_neb_calculated.ToList(),
                            frequency_neb.ToArray()
                        );
#elif XUNIT

            Assert.Equal
                        (
                            frequency_distribution_neb_calculated.ToList(),
                            frequency_neb.ToArray()
                        );
#elif MSTEST
            CollectionAssert.AreEquivalent
                        (
                            frequency_distribution_neb_calculated.ToList(),
                            frequency_neb.ToArray()
                        );
#endif

            return;
        }
        #endregion Tests (UnitTest and Benchmark) Frequency_NEB
        //--------------------------------------------------------------------------------------------------------------------------

        //--------------------------------------------------------------------------------------------------------------------------
        #region Tests (UnitTest and Benchmark) Frequency_SKL
        [Benchmark]
        public
            IEnumerable<KeyValuePair<int, (uint FrequencyAbsolute, double FrequencyRelative, uint FrequencyCumulative)>>
                Frequency_SKL()
        {
            return data_skl.FrequencyDistribution(); ;
        }

        [Test()]
        public void Frequency_SKL_Test()
        {
            data_skl =
                                from row in JudoDataTable
                                select row.SKL
                                    ;

            IEnumerable<KeyValuePair<int, (uint FrequencyAbsolute, double FrequencyRelative, uint FrequencyCumulative)>> frequency_skl;

            frequency_skl = Frequency_SKL();


            // Assert
#if NUNIT && !NUNIT_LITE            
            CollectionAssert.AreEquivalent
                        (
                            frequency_distribution_skl_calculated.ToList(),
                            frequency_skl.ToArray()
                        );
#elif XUNIT

            Assert.Equal
                        (
                            frequency_distribution_skl_calculated.ToList(),
                            frequency_skl.ToArray()
                        );
#elif MSTEST
            CollectionAssert.AreEquivalent
                        (
                            frequency_distribution_skl_calculated.ToList(),
                            frequency_skl.ToArray()
                        );
#endif

            return;
        }
        #endregion Tests (UnitTest and Benchmark) Frequency_SKL
        //--------------------------------------------------------------------------------------------------------------------------

        //--------------------------------------------------------------------------------------------------------------------------
        #region Tests (UnitTest and Benchmark) Frequency_TRB
        [Benchmark]
        public
            IEnumerable<KeyValuePair<int, (uint FrequencyAbsolute, double FrequencyRelative, uint FrequencyCumulative)>>
                Frequency_TRB()
        {
            return data_trb.FrequencyDistribution(); ;
        }

        [Test()]
        public void Frequency_TRB_Test()
        {
            data_trb =
                                from row in JudoDataTable
                                select row.TRB
                                    ;

            IEnumerable<KeyValuePair<int, (uint FrequencyAbsolute, double FrequencyRelative, uint FrequencyCumulative)>> frequency_trb;

            frequency_trb = Frequency_TRB();


            // Assert
#if NUNIT && !NUNIT_LITE            
            CollectionAssert.AreEquivalent
                        (
                            frequency_distribution_trb_calculated.ToList(),
                            frequency_trb.ToArray()
                        );
#elif XUNIT

            Assert.Equal
                        (
                            frequency_distribution_trb_calculated.ToList(),
                            frequency_trb.ToArray()
                        );
#elif MSTEST
            CollectionAssert.AreEquivalent
                        (
                            frequency_distribution_trb_calculated.ToList(),
                            frequency_trb.ToArray()
                        );
#endif

            return;
        }
        #endregion Tests (UnitTest and Benchmark) Frequency_TRB
        //--------------------------------------------------------------------------------------------------------------------------

        //--------------------------------------------------------------------------------------------------------------------------
        #region Tests (UnitTest and Benchmark) Frequency_CUC
        [Benchmark]
        public
            IEnumerable<KeyValuePair<int, (uint FrequencyAbsolute, double FrequencyRelative, uint FrequencyCumulative)>>
                Frequency_CUC()
        {
            return data_cuc.FrequencyDistribution(); ;
        }

        [Test()]
        public void Frequency_CUC_Test()
        {
            data_cuc =
                                from row in JudoDataTable
                                select row.CUC
                                    ;

            IEnumerable<KeyValuePair<int, (uint FrequencyAbsolute, double FrequencyRelative, uint FrequencyCumulative)>> frequency_cuc;

            frequency_cuc = Frequency_CUC();


            // Assert
#if NUNIT && !NUNIT_LITE            
            CollectionAssert.AreEquivalent
                        (
                            frequency_distribution_cuc_calculated.ToList(),
                            frequency_cuc.ToArray()
                        );
#elif XUNIT

            Assert.Equal
                        (
                            frequency_distribution_cuc_calculated.ToList(),
                            frequency_cuc.ToArray()
                        );
#elif MSTEST
            CollectionAssert.AreEquivalent
                        (
                            frequency_distribution_cuc_calculated.ToList(),
                            frequency_cuc.ToArray()
                        );
#endif

            return;
        }
        #endregion Tests (UnitTest and Benchmark) Frequency_CUC
        //--------------------------------------------------------------------------------------------------------------------------

        //--------------------------------------------------------------------------------------------------------------------------
        #region Tests (UnitTest and Benchmark) Frequency_SDM
        [Benchmark]
        public
            IEnumerable<KeyValuePair<int, (uint FrequencyAbsolute, double FrequencyRelative, uint FrequencyCumulative)>>
                Frequency_SDM()
        {
            return data_sdm.FrequencyDistribution(); ;
        }

        [Test()]
        public void Frequency_SDM_Test()
        {
            data_sdm =
                                from row in JudoDataTable
                                select row.SDM
                                    ;

            IEnumerable<KeyValuePair<int, (uint FrequencyAbsolute, double FrequencyRelative, uint FrequencyCumulative)>> frequency_sdm;

            frequency_sdm = Frequency_SDM();


            // Assert
#if NUNIT && !NUNIT_LITE            
            CollectionAssert.AreEquivalent
                        (
                            frequency_distribution_sdm_calculated.ToList(),
                            frequency_sdm.ToArray()
                        );
#elif XUNIT

            Assert.Equal
                        (
                            frequency_distribution_sdm_calculated.ToList(),
                            frequency_sdm.ToArray()
                        );
#elif MSTEST
            CollectionAssert.AreEquivalent
                        (
                            frequency_distribution_sdm_calculated.ToList(),
                            frequency_sdm.ToArray()
                        );
#endif

            return;
        }
        #endregion Tests (UnitTest and Benchmark) Frequency_SDM
        //--------------------------------------------------------------------------------------------------------------------------

        //--------------------------------------------------------------------------------------------------------------------------
        #region Tests (UnitTest and Benchmark) Frequency_BML
        [Benchmark]
        public
            IEnumerable<KeyValuePair<int, (uint FrequencyAbsolute, double FrequencyRelative, uint FrequencyCumulative)>>
                Frequency_BML()
        {
            return data_bml.FrequencyDistribution(); ;
        }

        [Test()]
        public void Frequency_BML_Test()
        {
            data_bml =
                                from row in JudoDataTable
                                select row.BML
                                    ;

            IEnumerable<KeyValuePair<int, (uint FrequencyAbsolute, double FrequencyRelative, uint FrequencyCumulative)>> frequency_bml;

            frequency_bml = Frequency_BML();


            // Assert
            #if NUNIT && !NUNIT_LITE            
            CollectionAssert.AreEquivalent
                        (
                            frequency_distribution_bml_calculated.ToList(),
                            frequency_bml.ToArray()
                        );
            #elif XUNIT
            Assert.Equal
                        (
                            frequency_distribution_bml_calculated.ToList(),
                            frequency_bml.ToArray()
                        );
            #elif MSTEST
            CollectionAssert.AreEquivalent
                        (
                            frequency_distribution_bml_calculated.ToList(),
                            frequency_bml.ToArray()
                        );
            #endif

            return;
        }
        #endregion Tests (UnitTest and Benchmark) Frequency_BML
        //--------------------------------------------------------------------------------------------------------------------------

    }
}
