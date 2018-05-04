﻿// /*
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
using System.Collections.ObjectModel;

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
    public partial class Tests20180119Dataset03
    {
        Stopwatch sw = null;

        static int[] data = new[]
        {
            160, 135, 175, 170, 155, 170, 165, 150, 155, 195,
            175, 150, 180, 210, 180, 205, 180, 160, 170, 185,
            160, 195, 190, 205, 160, 185, 180, 205, 195, 180,
            160, 170, 155, 150, 195, 175, 175, 190, 185, 180,
            180, 190, 195, 175, 175, 175, 175, 150, 165, 180,
            165, 195, 200, 190, 190, 165, 170, 205, 200, 180,
        };
        static double[] weights = Enumerable.Repeat(1.0, data.Length).ToArray();

        static int[] data_array = null;
        static ArraySegment<int> data_array_segment;
        static List<int> data_list = null;
        static Stack<int> data_stack = null;
        static Queue<int> data_queue = null;
        static ObservableCollection<int> data_observable_collection = null;
        static HashSet<int> data_hash_set = null;
        static SortedSet<int> data_sorted_set = null;
        static LinkedList<int> data_linked_list = null;

        static Tests20180119Dataset03()
        {
            data_array = data.ToArray();

            return;
        }
    }
}
