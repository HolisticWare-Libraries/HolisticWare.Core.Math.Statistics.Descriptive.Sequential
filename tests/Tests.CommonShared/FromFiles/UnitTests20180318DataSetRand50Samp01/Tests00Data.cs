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
using TestContext = HolisticWare.Core.Testing.UnitTests.TestContext;
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
using HolisticWare.Core.SampleData;

namespace UnitTests.Core.Math.Statistics.Descriptive.Sequential.Sync
{
    [TestClass] // for MSTest - NUnit [TestFixture] and XUnit not needed
    public partial class UnitTests20180318DataSetRand50Samp01
    {
        IEnumerable<double> data_rVAR1;

        private static List<RandSamp1Data> rand_samp1_data_table = null;

        public static List<RandSamp1Data> RandSamp1DataTable
        {
            get
            {
                if (rand_samp1_data_table == null)
                {
                    LoadDataFromFile();   
                }

                return rand_samp1_data_table;
            }
        }
        
        Stopwatch sw = null;

        //[OneTimeSetUp]
        private static void LoadDataFromFile()
        {
            #if NUNIT
            string directory_test = TestContext.CurrentContext.TestDirectory;
            #elif XUNIT
            string directory_test = Environment.CurrentDirectory;
            #elif MSTEST
            string directory_test = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            #endif

            string path_data = null;
            string text = null;
            string[] lines = null;

            //------------------------------------------------------------------
            path_data = System.IO.Path.Combine
                                    (
                                        new string[]
                                            {
                                                directory_test,
                                                $@"Xtras-SampleData",
                                                $@"Rand_Samp1_50.csv",
                                            }
                                    );
            using (StreamReader reader = new StreamReader(path_data))
            {
                text = reader.ReadToEnd();
            }
            lines = text.Split
                            (
                                new string[] { Environment.NewLine },
                                StringSplitOptions.RemoveEmptyEntries
                            );
            rand_samp1_data_table = new List<RandSamp1Data>();
            int n = lines.Count();
            for (int i = 0; i < n; i++) 
            {
                string s1 = lines[i].Replace("\r", "");

                string[] s_parts = s1.Split(new string[] { "," }, StringSplitOptions.None);

                    RandSamp1Data bg = new RandSamp1Data() 

                    {
                        rVAR1 = double.Parse(s_parts[0].Replace(",000", "")),
                    };

                    rand_samp1_data_table.Add(bg);
            }
            //------------------------------------------------------------------

            return;
        }
    }
}
