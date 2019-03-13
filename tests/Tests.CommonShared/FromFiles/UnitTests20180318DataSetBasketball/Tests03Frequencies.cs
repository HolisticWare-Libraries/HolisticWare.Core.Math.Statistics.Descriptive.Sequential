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
        //--------------------------------------------------------------------------------------------------------------------------
        #region     Precalculated test data - R calculated
        Dictionary<int, (uint FrequencyAbsolute, double FrequencyRelative, uint FrequencyCumulative)> frequency_distribution_2s_calculated =
            new Dictionary<int, (uint FrequencyAbsolute, double FrequencyRelative, uint FrequencyCumulative)>
                        {
                            {   7,      ( 1,    0.0078125,  1   ) },
                            {   9,      ( 1,    0.0078125,  2   ) },
                            {   12,     ( 5,    0.0390625,  7   ) },
                            {   13,     ( 3,    0.0234375,  10  ) },
                            {   14,     ( 4,    0.0312500,  14  ) },
                            {   15,     ( 2,    0.0156250,  16  ) },
                            {   16,     ( 10,   0.0781250,  26  ) },
                            {   17,     ( 4,    0.0312500,  30  ) },
                            {   18,     ( 15,   0.1171875,  45  ) },
                            {   19,     ( 5,    0.0390625,  50  ) },
                            {   20,     ( 8,    0.0625000,  58  ) },
                            {   21,     ( 10,   0.0781250,  68  ) },
                            {   22,     ( 5,    0.0390625,  73  ) },
                            {   23,     ( 5,    0.0390625,  78  ) },
                            {   24,     ( 9,    0.0703125,  87  ) },
                            {   25,     ( 3,    0.0234375,  90  ) },
                            {   26,     ( 7,    0.0546875,  97  ) },
                            {   27,     ( 2,    0.0156250,  99  ) },
                            {   28,     ( 3,    0.0234375,  102 ) },
                            {   29,     ( 6,    0.0468750,  108 ) },
                            {   30,     ( 1,    0.0078125,  109 ) },
                            {   31,     ( 3,    0.0234375,  112 ) },
                            {   32,     ( 3,    0.0234375,  115 ) },
                            {   33,     ( 2,    0.0156250,  117 ) },
                            {   34,     ( 8,    0.0625000,  125 ) },
                            {   39,     ( 1,    0.0078125,  126 ) },
                            {   40,     ( 1,    0.0078125,  127 ) },
                            {   44,     ( 1,    0.0078125,  128 ) },
                        };

        Dictionary<int, (uint FrequencyAbsolute, double FrequencyRelative, uint FrequencyCumulative)> frequency_distribution_2f_calculated =
              new Dictionary<int, (uint FrequencyAbsolute, double FrequencyRelative, uint FrequencyCumulative)>
                          {
                            { 8, ( 1, 0.0078125, 1 ) },
                            { 9, ( 2, 0.0156250, 3 ) },
                            { 11, ( 4, 0.0312500, 7 ) },
                            { 12, ( 5, 0.0390625, 12 ) },
                            { 13, ( 4, 0.0312500, 16 ) },
                            { 14, ( 3, 0.0234375, 19 ) },
                            { 15, ( 6, 0.0468750, 25 ) },
                            { 16, ( 6, 0.0468750, 31 ) },
                            { 17, ( 5, 0.0390625, 36 ) },
                            { 18, ( 6, 0.0468750, 42 ) },
                            { 19, ( 9, 0.0703125, 51 ) },
                            { 20, ( 7, 0.0546875, 58 ) },
                            { 21, ( 7, 0.0546875, 65 ) },
                            { 22, ( 8, 0.0625000, 73 ) },
                            { 23, ( 7, 0.0546875, 80 ) },
                            { 24, ( 5, 0.0390625, 85 ) },
                            { 25, ( 7, 0.0546875, 92 ) },
                            { 26, ( 5, 0.0390625, 97 ) },
                            { 27, ( 3, 0.0234375, 100 ) },
                            { 28, ( 10, 0.0781250, 110 ) },
                            { 29, ( 3, 0.0234375, 113 ) },
                            { 30, ( 5, 0.0390625, 118 ) },
                            { 31, ( 6, 0.0468750, 124 ) },
                            { 33, ( 1, 0.0078125, 125 ) },
                            { 36, ( 2, 0.0156250, 127 ) },
                            { 45, ( 1, 0.0078125, 128 ) },
                          };

        Dictionary<int, (uint FrequencyAbsolute, double FrequencyRelative, uint FrequencyCumulative)> frequency_distribution_3s_calculated =
              new Dictionary<int, (uint FrequencyAbsolute, double FrequencyRelative, uint FrequencyCumulative)>
                          {
                            { 1, ( 3, 0.0234375, 3 ) },
                            { 2, ( 4, 0.0312500, 7 ) },
                            { 3, ( 12, 0.0937500, 19 ) },
                            { 4, ( 14, 0.1093750, 33 ) },
                            { 5, ( 22, 0.1718750, 55 ) },
                            { 6, ( 19, 0.1484375, 74 ) },
                            { 7, ( 12, 0.0937500, 86 ) },
                            { 8, ( 12, 0.0937500, 98 ) },
                            { 9, ( 8, 0.0625000, 106 ) },
                            { 10, ( 7, 0.0546875, 113 ) },
                            { 11, ( 4, 0.0312500, 117 ) },
                            { 12, ( 3, 0.0234375, 120 ) },
                            { 13, ( 1, 0.0078125, 121 ) },
                            { 14, ( 3, 0.0234375, 124 ) },
                            { 15, ( 1, 0.0078125, 125 ) },
                            { 18, ( 1, 0.0078125, 126 ) },
                            { 19, ( 2, 0.0156250, 128 ) },
                          };

        Dictionary<int, (uint FrequencyAbsolute, double FrequencyRelative, uint FrequencyCumulative)> frequency_distribution_3f_calculated =
              new Dictionary<int, (uint FrequencyAbsolute, double FrequencyRelative, uint FrequencyCumulative)>
                          {
                            { 2, ( 1, 0.0078125, 1 ) },
                            { 3, ( 1, 0.0078125, 2 ) },
                            { 4, ( 2, 0.0156250, 4 ) },
                            { 5, ( 4, 0.0312500, 8 ) },
                            { 6, ( 5, 0.0390625, 13 ) },
                            { 7, ( 8, 0.0625000, 21 ) },
                            { 8, ( 11, 0.0859375, 32 ) },
                            { 9, ( 12, 0.0937500, 44 ) },
                            { 10, ( 11, 0.0859375, 55 ) },
                            { 11, ( 12, 0.0937500, 67 ) },
                            { 12, ( 13, 0.1015625, 80 ) },
                            { 13, ( 10, 0.0781250, 90 ) },
                            { 14, ( 7, 0.0546875, 97 ) },
                            { 15, ( 5, 0.0390625, 102 ) },
                            { 16, ( 5, 0.0390625, 107 ) },
                            { 17, ( 9, 0.0703125, 116 ) },
                            { 18, ( 2, 0.0156250, 118 ) },
                            { 19, ( 3, 0.0234375, 121 ) },
                            { 20, ( 1, 0.0078125, 122 ) },
                            { 21, ( 3, 0.0234375, 125 ) },
                            { 24, ( 1, 0.0078125, 126 ) },
                            { 25, ( 1, 0.0078125, 127 ) },
                            { 27, ( 1, 0.0078125, 128 ) },
                          };

        Dictionary<int, (uint FrequencyAbsolute, double FrequencyRelative, uint FrequencyCumulative)> frequency_distribution_fts_calculated =
              new Dictionary<int, (uint FrequencyAbsolute, double FrequencyRelative, uint FrequencyCumulative)>
                          {
                            {2, ( 1, 0.0078125, 1 ) },
                            {3, ( 1, 0.0078125, 2 ) },
                            {4, ( 1, 0.0078125, 3 ) },
                            {5, ( 5, 0.0390625, 8 ) },
                            {6, ( 6, 0.0468750, 14 ) },
                            {7, ( 6, 0.0468750, 20 ) },
                            {8, ( 4, 0.0312500, 24 ) },
                            {9, ( 5, 0.0390625, 29 ) },
                            {10, ( 6, 0.0468750, 35 ) },
                            {11, ( 8, 0.0625000, 43 ) },
                            {12, ( 8, 0.0625000, 51 ) },
                            {13, ( 4, 0.0312500, 55 ) },
                            {14, ( 6, 0.0468750, 61 ) },
                            {15, ( 4, 0.0312500, 65 ) },
                            {16, ( 6, 0.0468750, 71 ) },
                            {17, ( 5, 0.0390625, 76 ) },
                            {18, ( 6, 0.0468750, 82 ) },
                            {19, ( 8, 0.0625000, 90 ) },
                            {20, ( 7, 0.0546875, 97 ) },
                            {21, ( 6, 0.0468750, 103 ) },
                            {22, ( 2, 0.0156250, 105 ) },
                            {23, ( 2, 0.0156250, 107 ) },
                            {24, ( 5, 0.0390625, 112 ) },
                            {25, ( 3, 0.0234375, 115 ) },
                            {26, ( 2, 0.0156250, 117 ) },
                            {27, ( 2, 0.0156250, 119 ) },
                            {28, ( 2, 0.0156250, 121 ) },
                            {30, ( 2, 0.0156250, 123 ) },
                            {31, ( 1, 0.0078125, 124 ) },
                            {33, ( 1, 0.0078125, 125 ) },
                            {34, ( 1, 0.0078125, 126 ) },
                            {36, ( 1, 0.0078125, 127 ) },
                            {37, ( 1, 0.0078125, 128 ) },
                          };

        Dictionary<int, (uint FrequencyAbsolute, double FrequencyRelative, uint FrequencyCumulative)> frequency_distribution_ftf_calculated =
              new Dictionary<int, (uint FrequencyAbsolute, double FrequencyRelative, uint FrequencyCumulative)>
                          {
                            {0, ( 5, 0.0390625, 5 ) },
                            {1, ( 4, 0.0312500, 9 ) },
                            {2, ( 9, 0.0703125, 18 ) },
                            {3, ( 12, 0.0937500, 30 ) },
                            {4, ( 9, 0.0703125, 39 ) },
                            {5, ( 19, 0.1484375, 58 ) },
                            {6, ( 15, 0.1171875, 73 ) },
                            {7, ( 14, 0.1093750, 87 ) },
                            {8, ( 7, 0.0546875, 94 ) },
                            {9, ( 16, 0.1250000, 110 ) },
                            {10, ( 4, 0.0312500, 114 ) },
                            {11, ( 6, 0.0468750, 120 ) },
                            {12, ( 5, 0.0390625, 125 ) },
                            {13, ( 3, 0.0234375, 128 ) },
                          };

        Dictionary<int, (uint FrequencyAbsolute, double FrequencyRelative, uint FrequencyCumulative)> frequency_distribution_joff_calculated =
              new Dictionary<int, (uint FrequencyAbsolute, double FrequencyRelative, uint FrequencyCumulative)>
                          {
                            {2, ( 1, 0.0078125, 1 ) },
                            {3, ( 1, 0.0078125, 2 ) },
                            {4, ( 5, 0.0390625, 7 ) },
                            {5, ( 4, 0.0312500, 11 ) },
                            {6, ( 6, 0.0468750, 17 ) },
                            {7, ( 8, 0.0625000, 25 ) },
                            {8, ( 9, 0.0703125, 34 ) },
                            {9, ( 13, 0.1015625, 47 ) },
                            {10, ( 11, 0.0859375, 58 ) },
                            {11, ( 13, 0.1015625, 71 ) },
                            {12, ( 13, 0.1015625, 84 ) },
                            {13, ( 11, 0.0859375, 95 ) },
                            {14, ( 7, 0.0546875, 102 ) },
                            {15, ( 6, 0.0468750, 108 ) },
                            {16, ( 4, 0.0312500, 112 ) },
                            {17, ( 6, 0.0468750, 118 ) },
                            {18, ( 2, 0.0156250, 120 ) },
                            {19, ( 3, 0.0234375, 123 ) },
                            {20, ( 2, 0.0156250, 125 ) },
                            {22, ( 1, 0.0078125, 126 ) },
                            {24, ( 1, 0.0078125, 127 ) },
                            {25, ( 1, 0.0078125, 128 ) },
                          };

        Dictionary<int, (uint FrequencyAbsolute, double FrequencyRelative, uint FrequencyCumulative)> frequency_distribution_jdef_calculated =
              new Dictionary<int, (uint FrequencyAbsolute, double FrequencyRelative, uint FrequencyCumulative)>
                          {
                            {7, ( 1, 0.0078125, 1 ) },
                            {9, ( 1, 0.0078125, 2 ) },
                            {10, ( 3, 0.0234375, 5 ) },
                            {11, ( 1, 0.0078125, 6 ) },
                            {12, ( 3, 0.0234375, 9 ) },
                            {13, ( 3, 0.0234375, 12 ) },
                            {14, ( 5, 0.0390625, 17 ) },
                            {15, ( 3, 0.0234375, 20 ) },
                            {16, ( 3, 0.0234375, 23 ) },
                            {17, ( 7, 0.0546875, 30 ) },
                            {18, ( 10, 0.0781250, 40 ) },
                            {19, ( 7, 0.0546875, 47 ) },
                            {20, ( 5, 0.0390625, 52 ) },
                            {21, ( 11, 0.0859375, 63 ) },
                            {22, ( 7, 0.0546875, 70 ) },
                            {23, ( 7, 0.0546875, 77 ) },
                            {24, ( 4, 0.0312500, 81 ) },
                            {25, ( 11, 0.0859375, 92 ) },
                            {26, ( 7, 0.0546875, 99 ) },
                            {27, ( 6, 0.0468750, 105 ) },
                            {28, ( 4, 0.0312500, 109 ) },
                            {29, ( 6, 0.0468750, 115 ) },
                            {30, ( 3, 0.0234375, 118 ) },
                            {31, ( 4, 0.0312500, 122 ) },
                            {32, ( 3, 0.0234375, 125 ) },
                            {33, ( 2, 0.0156250, 127 ) },
                            {36, ( 1, 0.0078125, 128 ) },
                          };

        Dictionary<int, (uint FrequencyAbsolute, double FrequencyRelative, uint FrequencyCumulative)> frequency_distribution_asist_calculated =
              new Dictionary<int, (uint FrequencyAbsolute, double FrequencyRelative, uint FrequencyCumulative)>
                          {
                            {2, ( 2, 0.0156250, 2 ) },
                            {3, ( 3, 0.0234375, 5 ) },
                            {4, ( 3, 0.0234375, 8 ) },
                            {5, ( 3, 0.0234375, 11 ) },
                            {6, ( 2, 0.0156250, 13 ) },
                            {7, ( 7, 0.0546875, 20 ) },
                            {8, ( 5, 0.0390625, 25 ) },
                            {9, ( 12, 0.0937500, 37 ) },
                            {10, ( 9, 0.0703125, 46 ) },
                            {11, ( 14, 0.1093750, 60 ) },
                            {12, ( 11, 0.0859375, 71 ) },
                            {13, ( 7, 0.0546875, 78 ) },
                            {14, ( 10, 0.0781250, 88 ) },
                            {15, ( 6, 0.0468750, 94 ) },
                            {16, ( 9, 0.0703125, 103 ) },
                            {17, ( 6, 0.0468750, 109 ) },
                            {18, ( 2, 0.0156250, 111 ) },
                            {19, ( 2, 0.0156250, 113 ) },
                            {20, ( 5, 0.0390625, 118 ) },
                            {21, ( 1, 0.0078125, 119 ) },
                            {22, ( 2, 0.0156250, 121 ) },
                            {24, ( 1, 0.0078125, 122 ) },
                            {25, ( 1, 0.0078125, 123 ) },
                            {26, ( 2, 0.0156250, 125 ) },
                            {27, ( 1, 0.0078125, 126 ) },
                            {29, ( 1, 0.0078125, 127 ) },
                            {31, ( 1, 0.0078125, 128 ) },
                          };

        Dictionary<int, (uint FrequencyAbsolute, double FrequencyRelative, uint FrequencyCumulative)> frequency_distribution_pf_calculated =
              new Dictionary<int, (uint FrequencyAbsolute, double FrequencyRelative, uint FrequencyCumulative)>
                          {
                            {10, ( 1, 0.0078125, 1 ) },
                            {11, ( 1, 0.0078125, 2 ) },
                            {13, ( 9, 0.0703125, 11 ) },
                            {14, ( 5, 0.0390625, 16 ) },
                            {15, ( 5, 0.0390625, 21 ) },
                            {16, ( 6, 0.0468750, 27 ) },
                            {17, ( 8, 0.0625000, 35 ) },
                            {18, ( 11, 0.0859375, 46 ) },
                            {19, ( 12, 0.0937500, 58 ) },
                            {20, ( 7, 0.0546875, 65 ) },
                            {21, ( 9, 0.0703125, 74 ) },
                            {22, ( 11, 0.0859375, 85 ) },
                            {23, ( 7, 0.0546875, 92 ) },
                            {24, ( 9, 0.0703125, 101 ) },
                            {25, ( 4, 0.0312500, 105 ) },
                            {26, ( 4, 0.0312500, 109 ) },
                            {27, ( 3, 0.0234375, 112 ) },
                            {28, ( 7, 0.0546875, 119 ) },
                            {30, ( 5, 0.0390625, 124 ) },
                            {32, ( 1, 0.0078125, 125 ) },
                            {33, ( 1, 0.0078125, 126 ) },
                            {36, ( 1, 0.0078125, 127 ) },
                            {37, ( 1, 0.0078125, 128 ) },
                          };

        Dictionary<int, (uint FrequencyAbsolute, double FrequencyRelative, uint FrequencyCumulative)> frequency_distribution_balll_calculated =
              new Dictionary<int, (uint FrequencyAbsolute, double FrequencyRelative, uint FrequencyCumulative)>
                          {
                            {4, ( 1, 0.0078125, 1 ) },
                            {5, ( 1, 0.0078125, 2 ) },
                            {7, ( 2, 0.0156250, 4 ) },
                            {8, ( 4, 0.0312500, 8 ) },
                            {9, ( 6, 0.0468750, 14 ) },
                            {10, ( 12, 0.0937500, 26 ) },
                            {11, ( 9, 0.0703125, 35 ) },
                            {12, ( 10, 0.0781250, 45 ) },
                            {13, ( 12, 0.0937500, 57 ) },
                            {14, ( 10, 0.0781250, 67 ) },
                            {15, ( 9, 0.0703125, 76 ) },
                            {16, ( 10, 0.0781250, 86 ) },
                            {17, ( 9, 0.0703125, 95 ) },
                            {18, ( 13, 0.1015625, 108 ) },
                            {19, ( 2, 0.0156250, 110 ) },
                            {20, ( 3, 0.0234375, 113 ) },
                            {21, ( 5, 0.0390625, 118 ) },
                            {22, ( 2, 0.0156250, 120 ) },
                            {23, ( 1, 0.0078125, 121 ) },
                            {24, ( 3, 0.0234375, 124 ) },
                            {25, ( 1, 0.0078125, 125 ) },
                            {27, ( 1, 0.0078125, 126 ) },
                            {31, ( 1, 0.0078125, 127 ) },
                            {36, ( 1, 0.0078125, 128 ) },
                          };

        Dictionary<int, (uint FrequencyAbsolute, double FrequencyRelative, uint FrequencyCumulative)> frequency_distribution_balls_calculated =
              new Dictionary<int, (uint FrequencyAbsolute, double FrequencyRelative, uint FrequencyCumulative)>
                          {
                            {0, ( 2, 0.0156250, 2 ) },
                            {1, ( 2, 0.0156250, 4 ) },
                            {2, ( 3, 0.0234375, 7 ) },
                            {3, ( 11, 0.0859375, 18 ) },
                            {4, ( 9, 0.0703125, 27 ) },
                            {5, ( 14, 0.1093750, 41 ) },
                            {6, ( 16, 0.1250000, 57 ) },
                            {7, ( 18, 0.1406250, 75 ) },
                            {8, ( 17, 0.1328125, 92 ) },
                            {9, ( 11, 0.0859375, 103 ) },
                            {10, ( 8, 0.0625000, 111 ) },
                            {11, ( 6, 0.0468750, 117 ) },
                            {12, ( 4, 0.0312500, 121 ) },
                            {13, ( 3, 0.0234375, 124 ) },
                            {14, ( 1, 0.0078125, 125 ) },
                            {16, ( 1, 0.0078125, 126 ) },
                            {18, ( 1, 0.0078125, 127 ) },
                            {21, ( 1, 0.0078125, 128 ) },
                          };

        Dictionary<int, (uint FrequencyAbsolute, double FrequencyRelative, uint FrequencyCumulative)> frequency_distribution_block_calculated =
              new Dictionary<int, (uint FrequencyAbsolute, double FrequencyRelative, uint FrequencyCumulative)>
                          {
                            {0, ( 18, 0.1406250, 18 ) },
                            {1, ( 20, 0.1562500, 38 ) },
                            {2, ( 22, 0.1718750, 60 ) },
                            {3, ( 21, 0.1640625, 81 ) },
                            {4, ( 17, 0.1328125, 98 ) },
                            {5, ( 10, 0.0781250, 108 ) },
                            {6, ( 4, 0.0312500, 112 ) },
                            {7, ( 7, 0.0546875, 119 ) },
                            {8, ( 7, 0.0546875, 126 ) },
                            {9, ( 2, 0.0156250, 128 ) },
                          };




        #endregion  Precalculated test data - R calculated
        //--------------------------------------------------------------------------------------------------------------------------

        //--------------------------------------------------------------------------------------------------------------------------
        #region Tests (UnitTest and Benchmark) Frequency_Points2Success
        [Benchmark]
        public
            IEnumerable<KeyValuePair<int, (uint FrequencyAbsolute, double FrequencyRelative, uint FrequencyCumulative)>>
                Frequency_Points2Success()
        {
            return data_2pts_success.FrequencyDistribution(); ;
        }

        [Test()]
        public void Frequency_Points2Success_Test()
        {
            data_2pts_success =
                                from row in BasketballTeamDataTable
                                select row.Points2Success
                                    ;
                                          
            IEnumerable<KeyValuePair<int, (uint FrequencyAbsolute, double FrequencyRelative, uint FrequencyCumulative)>> frequency_2s;

            frequency_2s = Frequency_Points2Success();


            // Assert
#if NUNIT && !NUNIT_LITE            
            CollectionAssert.AreEquivalent
                        (
                            frequency_distribution_2s_calculated.ToList(),
                            frequency_2s.ToArray()
                        );
#elif XUNIT

            Assert.Equal
                        (
                            frequency_distribution_2s_calculated.ToList(),
                            frequency_2s.ToArray()
                        );
#elif MSTEST
            CollectionAssert.AreEquivalent
                        (
                            frequency_distribution_2s_calculated.ToList(),
                            frequency_2s.ToArray()
                        );
#endif

            return;
        }
        #endregion Tests (UnitTest and Benchmark) Frequency_Points2Success
        //--------------------------------------------------------------------------------------------------------------------------

        //--------------------------------------------------------------------------------------------------------------------------
        #region Tests (UnitTest and Benchmark) Frequency_Points2Fail
        [Benchmark]
        public
            IEnumerable<KeyValuePair<int, (uint FrequencyAbsolute, double FrequencyRelative, uint FrequencyCumulative)>>
                Frequency_Points2Fail()
        {
            return data_2pts_fail.FrequencyDistribution(); ;
        }

        [Test()]
        public void Frequency_Points2Fail_Test()
        {
            data_2pts_fail =
                                from row in BasketballTeamDataTable
                                select row.Points2Fail
                                    ;

            IEnumerable<KeyValuePair<int, (uint FrequencyAbsolute, double FrequencyRelative, uint FrequencyCumulative)>> frequency_2f;

            frequency_2f = Frequency_Points2Fail();


            // Assert
#if NUNIT && !NUNIT_LITE            
            CollectionAssert.AreEquivalent
                        (
                            frequency_distribution_2f_calculated.ToList(),
                            frequency_2f.ToArray()
                        );
#elif XUNIT

            Assert.Equal
                        (
                            frequency_distribution_2f_calculated.ToList(),
                            frequency_2f.ToArray()
                        );
#elif MSTEST
            CollectionAssert.AreEquivalent
                        (
                            frequency_distribution_2f_calculated.ToList(),
                            frequency_2f.ToArray()
                        );
#endif

            return;
        }
        #endregion Tests (UnitTest and Benchmark) Frequency_Points2Success
        //--------------------------------------------------------------------------------------------------------------------------

        //--------------------------------------------------------------------------------------------------------------------------
        #region Tests (UnitTest and Benchmark) Frequency_Points3Success
        [Benchmark]
        public
            IEnumerable<KeyValuePair<int, (uint FrequencyAbsolute, double FrequencyRelative, uint FrequencyCumulative)>>
                Frequency_Points3Success()
        {
            return data_3pts_success.FrequencyDistribution(); ;
        }

        [Test()]
        public void Frequency_Points3Success_Test()
        {
            data_3pts_success =
                                from row in BasketballTeamDataTable
                                select row.Points3Success
                                    ;

            IEnumerable<KeyValuePair<int, (uint FrequencyAbsolute, double FrequencyRelative, uint FrequencyCumulative)>> frequency_3s;

            frequency_3s = Frequency_Points3Success();


            // Assert
#if NUNIT && !NUNIT_LITE            
            CollectionAssert.AreEquivalent
                        (
                            frequency_distribution_3s_calculated.ToList(),
                            frequency_3s.ToArray()
                        );
#elif XUNIT

            Assert.Equal
                        (
                            frequency_distribution_3s_calculated.ToList(),
                            frequency_3s.ToArray()
                        );
#elif MSTEST
            CollectionAssert.AreEquivalent
                        (
                            frequency_distribution_3s_calculated.ToList(),
                            frequency_3s.ToArray()
                        );
#endif

            return;
        }
        #endregion Tests (UnitTest and Benchmark) Frequency_Points3Success
        //--------------------------------------------------------------------------------------------------------------------------

        //--------------------------------------------------------------------------------------------------------------------------
        #region Tests (UnitTest and Benchmark) Frequency_Points3Fail
        [Benchmark]
        public
            IEnumerable<KeyValuePair<int, (uint FrequencyAbsolute, double FrequencyRelative, uint FrequencyCumulative)>>
                Frequency_Points3Fail()
        {
            return data_3pts_fail.FrequencyDistribution(); ;
        }

        [Test()]
        public void Frequency_Points3Fail_Test()
        {
            data_3pts_fail =
                                from row in BasketballTeamDataTable
                                select row.Points3Fail
                                    ;

            IEnumerable<KeyValuePair<int, (uint FrequencyAbsolute, double FrequencyRelative, uint FrequencyCumulative)>> frequency_3f;

            frequency_3f = Frequency_Points3Fail();


            // Assert
#if NUNIT && !NUNIT_LITE            
            CollectionAssert.AreEquivalent
                        (
                            frequency_distribution_3f_calculated.ToList(),
                            frequency_3f.ToArray()
                        );
#elif XUNIT

            Assert.Equal
                        (
                            frequency_distribution_3f_calculated.ToList(),
                            frequency_3f.ToArray()
                        );
#elif MSTEST
            CollectionAssert.AreEquivalent
                        (
                            frequency_distribution_3f_calculated.ToList(),
                            frequency_3f.ToArray()
                        );
#endif

            return;
        }
        #endregion Tests (UnitTest and Benchmark) Frequency_Points3Fail
        //--------------------------------------------------------------------------------------------------------------------------

        //--------------------------------------------------------------------------------------------------------------------------
        #region Tests (UnitTest and Benchmark) Frequency_FreeThrowSuccess
        [Benchmark]
        public
            IEnumerable<KeyValuePair<int, (uint FrequencyAbsolute, double FrequencyRelative, uint FrequencyCumulative)>>
                Frequency_FreeThrowSuccess()
        {
            return data_free_throw_success.FrequencyDistribution(); ;
        }

        [Test()]
        public void Frequency_FreeThrowSuccess_Test()
        {
            data_free_throw_success =
                                from row in BasketballTeamDataTable
                                select row.FreeThrowSuccess
                                    ;

            IEnumerable<KeyValuePair<int, (uint FrequencyAbsolute, double FrequencyRelative, uint FrequencyCumulative)>> frequency_fts;

            frequency_fts = Frequency_FreeThrowSuccess();


            // Assert
#if NUNIT && !NUNIT_LITE            
            CollectionAssert.AreEquivalent
                        (
                            frequency_distribution_fts_calculated.ToList(),
                            frequency_fts.ToArray()
                        );
#elif XUNIT

            Assert.Equal
                        (
                            frequency_distribution_fts_calculated.ToList(),
                            frequency_fts.ToArray()
                        );
#elif MSTEST
            CollectionAssert.AreEquivalent
                        (
                            frequency_distribution_fts_calculated.ToList(),
                            frequency_fts.ToArray()
                        );
#endif

            return;
        }
        #endregion Tests (UnitTest and Benchmark) Frequency_FreeThrowSuccess
        //--------------------------------------------------------------------------------------------------------------------------

        //--------------------------------------------------------------------------------------------------------------------------
        #region Tests (UnitTest and Benchmark) Frequency_FreeThrowFail
        [Benchmark]
        public
            IEnumerable<KeyValuePair<int, (uint FrequencyAbsolute, double FrequencyRelative, uint FrequencyCumulative)>>
                Frequency_FreeThrowFail()
        {
            return data_free_throw_fail.FrequencyDistribution(); ;
        }

        [Test()]
        public void Frequency_FreeThrowFail_Test()
        {
            data_free_throw_fail =
                                from row in BasketballTeamDataTable
                                select row.FreeThrowFail
                                    ;

            IEnumerable<KeyValuePair<int, (uint FrequencyAbsolute, double FrequencyRelative, uint FrequencyCumulative)>> frequency_ftf;

            frequency_ftf = Frequency_FreeThrowFail();


            // Assert
#if NUNIT && !NUNIT_LITE            
            CollectionAssert.AreEquivalent
                        (
                            frequency_distribution_ftf_calculated.ToList(),
                            frequency_ftf.ToArray()
                        );
#elif XUNIT

            Assert.Equal
                        (
                            frequency_distribution_ftf_calculated.ToList(),
                            frequency_ftf.ToArray()
                        );
#elif MSTEST
            CollectionAssert.AreEquivalent
                        (
                            frequency_distribution_ftf_calculated.ToList(),
                            frequency_ftf.ToArray()
                        );
#endif

            return;
        }
        #endregion Tests (UnitTest and Benchmark) Frequency_FreeThrowFaill
        //--------------------------------------------------------------------------------------------------------------------------

        //--------------------------------------------------------------------------------------------------------------------------
        #region Tests (UnitTest and Benchmark) Frequency_JumpsOffensive
        [Benchmark]
        public
            IEnumerable<KeyValuePair<int, (uint FrequencyAbsolute, double FrequencyRelative, uint FrequencyCumulative)>>
                Frequency_JumpsOffensive()
        {
            return data_jumps_offensive.FrequencyDistribution(); ;
        }

        [Test()]
        public void Frequency_JumpsOffensive_Test()
        {
            data_jumps_offensive =
                                from row in BasketballTeamDataTable
                                select row.JumpsOffensive
                                    ;

            IEnumerable<KeyValuePair<int, (uint FrequencyAbsolute, double FrequencyRelative, uint FrequencyCumulative)>> frequency_joff;

            frequency_joff = Frequency_JumpsOffensive();


            // Assert
#if NUNIT && !NUNIT_LITE            
            CollectionAssert.AreEquivalent
                        (
                            frequency_distribution_joff_calculated.ToList(),
                            frequency_joff.ToArray()
                        );
#elif XUNIT

            Assert.Equal
                        (
                            frequency_distribution_joff_calculated.ToList(),
                            frequency_joff.ToArray()
                        );
#elif MSTEST
            CollectionAssert.AreEquivalent
                        (
                            frequency_distribution_joff_calculated.ToList(),
                            frequency_joff.ToArray()
                        );
#endif

            return;
        }
        #endregion Tests (UnitTest and Benchmark) Frequency_JumpsOffensive
        //--------------------------------------------------------------------------------------------------------------------------

        //--------------------------------------------------------------------------------------------------------------------------
        #region Tests (UnitTest and Benchmark) Frequency_JumpsDefensive
        [Benchmark]
        public
            IEnumerable<KeyValuePair<int, (uint FrequencyAbsolute, double FrequencyRelative, uint FrequencyCumulative)>>
                Frequency_JumpsDefensive()
        {
            return data_jumps_defensive.FrequencyDistribution(); ;
        }

        [Test()]
        public void Frequency_JumpsDefensive_Test()
        {
            data_jumps_defensive =
                                from row in BasketballTeamDataTable
                                select row.JumpsDefensive
                                    ;

            IEnumerable<KeyValuePair<int, (uint FrequencyAbsolute, double FrequencyRelative, uint FrequencyCumulative)>> frequency_jdef;

            frequency_jdef = Frequency_JumpsDefensive();


            // Assert
#if NUNIT && !NUNIT_LITE            
            CollectionAssert.AreEquivalent
                        (
                            frequency_distribution_jdef_calculated.ToList(),
                            frequency_jdef.ToArray()
                        );
#elif XUNIT

            Assert.Equal
                        (
                            frequency_distribution_jdef_calculated.ToList(),
                            frequency_jdef.ToArray()
                        );
#elif MSTEST
            CollectionAssert.AreEquivalent
                        (
                            frequency_distribution_jdef_calculated.ToList(),
                            frequency_jdef.ToArray()
                        );
#endif

            return;
        }
        #endregion Tests (UnitTest and Benchmark) Frequency_JumpsDefensive
        //--------------------------------------------------------------------------------------------------------------------------

        //--------------------------------------------------------------------------------------------------------------------------
        #region Tests (UnitTest and Benchmark) Frequency_Assistence
        [Benchmark]
        public
            IEnumerable<KeyValuePair<int, (uint FrequencyAbsolute, double FrequencyRelative, uint FrequencyCumulative)>>
                Frequency_Assistence()
        {
            return data_assistence.FrequencyDistribution(); ;
        }

        [Test()]
        public void Frequency_Assistence_Test()
        {
            data_assistence =
                                from row in BasketballTeamDataTable
                                select row.Assistence
                                    ;

            IEnumerable<KeyValuePair<int, (uint FrequencyAbsolute, double FrequencyRelative, uint FrequencyCumulative)>> frequency_asist;

            frequency_asist = Frequency_Assistence();


            // Assert
#if NUNIT && !NUNIT_LITE            
            CollectionAssert.AreEquivalent
                        (
                            frequency_distribution_asist_calculated.ToList(),
                            frequency_asist.ToArray()
                        );
#elif XUNIT

            Assert.Equal
                        (
                            frequency_distribution_asist_calculated.ToList(),
                            frequency_asist.ToArray()
                        );
#elif MSTEST
            CollectionAssert.AreEquivalent
                        (
                            frequency_distribution_asist_calculated.ToList(),
                            frequency_asist.ToArray()
                        );
#endif

            return;
        }
        #endregion Tests (UnitTest and Benchmark) Frequency_Assistence
        //--------------------------------------------------------------------------------------------------------------------------

        //--------------------------------------------------------------------------------------------------------------------------
        #region Tests (UnitTest and Benchmark) Frequency_PersonalFaults
        [Benchmark]
        public
            IEnumerable<KeyValuePair<int, (uint FrequencyAbsolute, double FrequencyRelative, uint FrequencyCumulative)>>
                Frequency_PersonalFaults()
        {
            return data_personal_faults.FrequencyDistribution(); ;
        }

        [Test()]
        public void Frequency_PersonalFaults_Test()
        {
            data_personal_faults =
                                from row in BasketballTeamDataTable
                                select row.PersonalFaults
                                    ;

            IEnumerable<KeyValuePair<int, (uint FrequencyAbsolute, double FrequencyRelative, uint FrequencyCumulative)>> frequency_pf;

            frequency_pf = Frequency_PersonalFaults();


            // Assert
#if NUNIT && !NUNIT_LITE            
            CollectionAssert.AreEquivalent
                        (
                            frequency_distribution_pf_calculated.ToList(),
                            frequency_pf.ToArray()
                        );
#elif XUNIT

            Assert.Equal
                        (
                            frequency_distribution_pf_calculated.ToList(),
                            frequency_pf.ToArray()
                        );
#elif MSTEST
            CollectionAssert.AreEquivalent
                        (
                            frequency_distribution_pf_calculated.ToList(),
                            frequency_pf.ToArray()
                        );
#endif

            return;
        }
        #endregion Tests (UnitTest and Benchmark) Frequency_PersonalFaults
        //--------------------------------------------------------------------------------------------------------------------------

        //--------------------------------------------------------------------------------------------------------------------------
        #region Tests (UnitTest and Benchmark) Frequency_BallsLost
        [Benchmark]
        public
            IEnumerable<KeyValuePair<int, (uint FrequencyAbsolute, double FrequencyRelative, uint FrequencyCumulative)>>
                Frequency_BallsLost()
        {
            return data_balls_lost.FrequencyDistribution(); ;
        }

        [Test()]
        public void Frequency_BallsLost_Test()
        {
            data_balls_lost =
                                from row in BasketballTeamDataTable
                                select row.BallsLost
                                    ;

            IEnumerable<KeyValuePair<int, (uint FrequencyAbsolute, double FrequencyRelative, uint FrequencyCumulative)>> frequency_balll;

            frequency_balll = Frequency_BallsLost();


            // Assert
#if NUNIT && !NUNIT_LITE            
            CollectionAssert.AreEquivalent
                        (
                            frequency_distribution_balll_calculated.ToList(),
                            frequency_balll.ToArray()
                        );
#elif XUNIT

            Assert.Equal
                        (
                            frequency_distribution_balll_calculated.ToList(),
                            frequency_balll.ToArray()
                        );
#elif MSTEST
            CollectionAssert.AreEquivalent
                        (
                            frequency_distribution_balll_calculated.ToList(),
                            frequency_balll.ToArray()
                        );
#endif

            return;
        }
        #endregion Tests (UnitTest and Benchmark) Frequency_BallsLost
        //--------------------------------------------------------------------------------------------------------------------------

        //--------------------------------------------------------------------------------------------------------------------------
        #region Tests (UnitTest and Benchmark) Frequency_BallsStolen
        [Benchmark]
        public
            IEnumerable<KeyValuePair<int, (uint FrequencyAbsolute, double FrequencyRelative, uint FrequencyCumulative)>>
                Frequency_BallsStolen()
        {
            return data_balls_stolen.FrequencyDistribution(); ;
        }

        [Test()]
        public void Frequency_BallsStolen_Test()
        {
            data_balls_stolen =
                                from row in BasketballTeamDataTable
                                select row.BallsStolen
                                    ;

            IEnumerable<KeyValuePair<int, (uint FrequencyAbsolute, double FrequencyRelative, uint FrequencyCumulative)>> frequency_balls;

            frequency_balls = Frequency_BallsStolen();


            // Assert
#if NUNIT && !NUNIT_LITE            
            CollectionAssert.AreEquivalent
                        (
                            frequency_distribution_balls_calculated.ToList(),
                            frequency_balls.ToArray()
                        );
#elif XUNIT

            Assert.Equal
                        (
                            frequency_distribution_balls_calculated.ToList(),
                            frequency_balls.ToArray()
                        );
#elif MSTEST
            CollectionAssert.AreEquivalent
                        (
                            frequency_distribution_balls_calculated.ToList(),
                            frequency_balls.ToArray()
                        );
#endif

            return;
        }
        #endregion Tests (UnitTest and Benchmark) Frequency_BallsStolen
        //--------------------------------------------------------------------------------------------------------------------------

        //--------------------------------------------------------------------------------------------------------------------------
        #region Tests (UnitTest and Benchmark) Frequency_Blocks
        [Benchmark]
        public
            IEnumerable<KeyValuePair<int, (uint FrequencyAbsolute, double FrequencyRelative, uint FrequencyCumulative)>>
                Frequency_Blocks()
        {
            return data_blocks.FrequencyDistribution(); ;
        }

        [Test()]
        public void Frequency_Blocks_Test()
        {
            data_blocks =
                                from row in BasketballTeamDataTable
                                select row.Blocks
                                    ;

            IEnumerable<KeyValuePair<int, (uint FrequencyAbsolute, double FrequencyRelative, uint FrequencyCumulative)>> frequency_block;

            frequency_block = Frequency_Blocks();


            // Assert
#if NUNIT && !NUNIT_LITE            
            CollectionAssert.AreEquivalent
                        (
                            frequency_distribution_block_calculated.ToList(),
                            frequency_block.ToArray()
                        );
#elif XUNIT

            Assert.Equal
                        (
                            frequency_distribution_block_calculated.ToList(),
                            frequency_block.ToArray()
                        );
#elif MSTEST
            CollectionAssert.AreEquivalent
                        (
                            frequency_distribution_block_calculated.ToList(),
                            frequency_block.ToArray()
                        );
#endif

            return;
        }
        #endregion Tests (UnitTest and Benchmark) Frequency_Blocks
        //--------------------------------------------------------------------------------------------------------------------------
    }
}
