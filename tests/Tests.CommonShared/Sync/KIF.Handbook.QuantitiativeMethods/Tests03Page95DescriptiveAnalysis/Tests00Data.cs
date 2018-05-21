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
    public partial class Tests03Page95DescriptiveAnalysis
    {
        // Arrange
        List<double> x1 = new List<double>
            {
                82.61,
                93.51,
                78.46,
                55.14,
                49.65,
                45.82,
                50.21,
                51.65,
                69.45,
                57.32,
                35.62,
                47.95,
                33.65,
                52.69,
                77.95,
            };

        // Arrange
        List<double> x21 = new List<double>
            {
                87.61,
                98.51,
                83.46,
                60.14,
                54.65,
                50.82,
                55.21,
                56.65,
                74.45,
                62.32,
                40.62,
                52.95,
                38.65,
                57.69,
                82.95,
            };

        // Arrange
        List<double> x22 = new List<double>
            {
                83.98,
                94.31,
                80.62,
                56.36,
                57.47,
                51.19,
                56.54,
                60.91,
                74.45,
                67.00,
                44.56,
                53.24,
                39.51,
                57.64,
                80.21,
            };

        // Arrange
        List<double> x23 = new List<double>
            {
                85.65,
                94.62,
                83.65,
                59.84,
                52.34,
                51.26,
                61.24,
                57.95,
                80.65,
                61.53,
                37.45,
                58.31,
                33.95,
                64.25,
                82.21,
            };

        List<double> d1_list = null;

        private List<double> d1
        {
            // Arrange
            get
            {
                if (d1_list == null)
                {
                    d1_list = new List<double>();
                    for (int i = 0; i < x1.Count; i++)
                    {
                        d1_list.Add(x21[i] - x1[i]);
                    }
                }

                return d1_list;
            }
        }

        List<double> d2_list = null;

        private List<double> d2
        {
            // Arrange
            get
            {
                if (d2_list == null)
                {
                    d2_list = new List<double>();
                    for (int i = 0; i < x1.Count; i++)
                    {
                        d2_list.Add(x22[i] - x1[i]);
                    }
                }

                return d2_list;
            }
        }

        List<double> d3_list = null;

        private List<double> d3
        {
            // Arrange
            get
            {
                if (d3_list == null)
                {
                    d3_list = new List<double>();
                    for (int i = 0; i < x1.Count; i++)
                    {
                        d3_list.Add(x23[i] - x1[i]);
                    }
                }

                return d3_list;
            }
        }
    }
}
