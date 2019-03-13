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
using Benchmark = HolisticWare.Core.Testing.BenchmarkTests.Benchmark;using ShortRunJob = HolisticWare.Core.Testing.BenchmarkTests.ShortRunJob;
#endif

using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Linq;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace UnitTests.Core.Math.Statistics.Descriptive.Sequential.Sync.MedianWeighted.Wikipedia
{
    [TestClass] // for MSTest - NUnit [TestFixture] and XUnit not needed
    //[SimpleJob(launchCount: 1, warmupCount: 3, targetCount: 5, invocationCount: 100, id: "QuickJob")]
    [ShortRunJob]
    public partial class Tests20180525MedianWeightedWikipedia03
    {
        Stopwatch sw = null;

        static double[] data = new double[] 
        { 
            1, 2, 2.5, 3, 4
        };
        static double[] weights = Enumerable.Repeat(1.0, data.Length).ToArray();

        static double[] data_array = null;
        static ArraySegment<double> data_array_segment;
        static List<double> data_list = null;
        static Stack<double> data_stack = null;
        static Queue<double> data_queue = null;
        static ObservableCollection<double> data_observable_collection = null;
        static LinkedList<double> data_linked_list = null;

        static List<double> w1 = new List<double>() { 0.25, 0.25, 0, 0.25, 0.25 };
        static IEnumerable<double> w1_r = Enumerable.Reverse(w1);
        static IEnumerable<double> w1_rnd_double = Enumerable.Repeat((new Random()).NextDouble(), w1.Count());

        static Tests20180525MedianWeightedWikipedia03()
        {
            data_array = data.ToArray();
            data_array_segment = new ArraySegment<double>(data);
            data_list = new List<double>(data);
            data_queue = new Queue<double>(data);
            data_stack = new Stack<double>(data);
            data_linked_list = new LinkedList<double>(data);
            data_observable_collection = new ObservableCollection<double>(data);

            return;
        }

    }
}
