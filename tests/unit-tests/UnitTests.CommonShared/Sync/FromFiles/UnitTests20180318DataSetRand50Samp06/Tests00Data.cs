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
using System.IO;
using System.Reflection;

#if XUNIT
using Xunit;
// NUnit aliases
using Test = Xunit.FactAttribute;
using OneTimeSetUp = HolisticWare.Core.Testing.UnitTestsCompatibilityAliasAttribute;
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
// XUnit aliases
using Fact=NUnit.Framework.TestAttribute;
#elif MSTEST
using Microsoft.VisualStudio.TestTools.UnitTesting;
// NUnit aliases
using Test = Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute;
using OneTimeSetUp = Microsoft.VisualStudio.TestTools.UnitTesting.ClassInitializeAttribute;
// XUnit aliases
using Fact = Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute;
#endif

using Core.Math.Statistics.Descriptive.Sequential;

namespace UnitTests.Core.Math.Statistics.Descriptive.Sequential.Sync
{
    [TestClass] // for MSTest - NUnit [TestFixture] and XUnit not needed
    public partial class UnitTests20180318DataSetRand50Samp06
    {
        static List<BasketballTeamData> data01 = null;

        Stopwatch sw = null;

        //[OneTimeSetUp] // for MSTest - ClassInitialize - public, static, void
        public static void LoadDataFromFile()
        {
            string directory_test =
                                    #if NUNIT
                                    TestContext.CurrentContext.TestDirectory
                                    #elif XUNIT
                                    Environment.CurrentDirectory
                                    #elif MSTEST
                                    Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)
                                    #endif
                                    ;

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
                                                $@"Rand_Samp6_50.csv",
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

            data01 = new List<BasketballTeamData>();
            int n = lines.Count();
            for (int i = 1; i < n; i++)

            {
                string s1 = lines[i].Replace("\r", "");

                string[] s_parts = s1.Split(new string[] { "." }, StringSplitOptions.None);
                BasketballTeamData bg = new BasketballTeamData()
                {
                    Points2Success = int.Parse(s_parts[0].Replace(",000", "")),
                    Points2Fail = int.Parse(s_parts[1].Replace(",000", "")),
                    Points3Success = int.Parse(s_parts[2].Replace(",000", "")),
                    Points3Fail = int.Parse(s_parts[3].Replace(",000", "")),
                    FreeThrowSuccess = int.Parse(s_parts[4].Replace(",000", "")),
                    FreeThrowFail = int.Parse(s_parts[5].Replace(",000", "")),
                    JumpsOffensive = int.Parse(s_parts[6].Replace(",000", "")),
                    JumpsDefensive = int.Parse(s_parts[7].Replace(",000", "")),
                    Assistence = int.Parse(s_parts[8].Replace(",000", "")),
                    BallsLost = int.Parse(s_parts[9].Replace(",000", "")),
                    BallsStolen = int.Parse(s_parts[10].Replace(",000", "")),
                    Blocks = int.Parse(s_parts[11].Replace(",000", "")),
                    Criteria01 = int.Parse(s_parts[12].Replace(",000", "")),
                    Criteria02 = int.Parse(s_parts[13].Replace(",000", "")),
                };

                data01.Add(bg);
            }
            //------------------------------------------------------------------

            return;
        }
    }
}
