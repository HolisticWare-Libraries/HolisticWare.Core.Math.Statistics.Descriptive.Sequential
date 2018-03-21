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
using UnitTests.CommonShared.Sync.FromFiles.UnitTests20180318DataSetBasketball;

#if XUNIT
using Xunit;
using Test = Xunit.FactAttribute;
using OneTimeSetUp = System.ObsoleteAttribute;
#elif NUNIT
using NUnit.Framework;
using Fact=NUnit.Framework.TestAttribute;
#elif MSTEST
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Test = Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute;
using Fact = Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute;
using OneTimeSetUp = Microsoft.VisualStudio.TestTools.UnitTesting.ClassInitializeAttribute;
#endif

using Core.Math.Statistics.Descriptive.Sequential;

namespace UnitTests.Core.Math.Statistics.Descriptive.Sequential.Sync
{
    public partial class UnitTests20180318DataSetRand50Samp02
    {
        private static List<double> data = null;

        public static List<double> Data
        {
            get
            {
                if (data == null)
                {
                    LoadDataFromFile();
                }

                return data;
            }
        }

        Stopwatch sw = null;

        [OneTimeSetUp]
        public static void LoadDataFromFile()
        {
            string directory_test =
                                    #if NUNIT
                                    TestContext.CurrentContext.TestDirectory
                                    #elif XUNIT
                                    Environment.CurrentDirectory
                                    #elif MSTEST
                                    System.Reflection.Assembly.GetExecutingAssembly().CodeBase
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
                                                $@"Rand_Samp2_50.csv",
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
            data = new List<double>();
            foreach (string s in lines)
            {
                double data_item = Double.Parse(s);
                data.Add(data_item);
            }
            //------------------------------------------------------------------

            return;
        }
    }
}
