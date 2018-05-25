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
using Fact=NUnit.Framework.TestAttribute;
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
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;
using System.Collections.ObjectModel;

using Core.Math.Statistics.Descriptive.Sequential;

namespace UnitTests.Core.Math.Statistics.Descriptive.Sequential.Sync.MedianWeighted.Wikipedia
{
    public partial class Tests20180525MedianWeightedWikipedia01
    {
        static double[] w2 = new double[] { 0.15, 0.1, 0.2, 0.3, 0.25 };
        static double[] w2_r = Enumerable.Reverse(w2).ToArray();

        [Benchmark]
        public (int Index, double Value) Array_MedianWeighted()
        {
            return data_array.MedianWeighted(w2);
        }

        [Test]
        public void Array_MedianWeighted_Test()
        {
            Console.WriteLine($"Array_MedianWeighted_Test");
            //====================================================================================================
            //  Arrange
            //  reading data from files

            sw = Stopwatch.StartNew();

            //----------------------------------------------------------------------------------------------------
            // Act
            //      extracted to atomic Benchmark method
            (int Index, double Value) mean = Array_MedianWeighted();

            sw.Stop();
            Console.WriteLine($"Array<double>.MedianWeighted()");
            Console.WriteLine($"          mean               = {mean}");
            Console.WriteLine($"          size               = {data_array.Count()}");
            Console.WriteLine($"          elapsed[ticks]     = {sw.ElapsedTicks}");
            Console.WriteLine($"          elapsed[ms]        = {sw.Elapsed.TotalMilliseconds}");
            sw.Reset();
            //----------------------------------------------------------------------------------------------------
            // Assert
            #if NUNIT
            Assert.AreEqual(5.0, mean.Index, 0.01);
            Assert.AreEqual(5.0, mean.Value, 0.01);
            #elif XUNIT
            Assert.Equal(5.0, mean.Index, 5);
            Assert.Equal(5.0, mean.Value, 5);
            #elif MSTEST
            Assert.AreEqual(5.0, mean.Index, 0.01);
            Assert.AreEqual(5.0, mean.Value, 0.01);
            #endif
            //====================================================================================================

            return;
        }

        [Benchmark]
        public (int Index, double Value) ArraySegment_MedianWeighted()
        {
            return data_array_segment.MedianWeighted(w2);
        }

        [Test]
        public void ArraySegment_MedianWeighted_Test()
        {
            //====================================================================================================
            //  Arrange
            //  reading data from files

            sw = Stopwatch.StartNew();

            //----------------------------------------------------------------------------------------------------
            // Act
            //      extracted to atomic Benchmark method
            (int Index, double Value) mean = ArraySegment_MedianWeighted();

            sw.Stop();
            Console.WriteLine($"          mean               = {mean}");
            Console.WriteLine($"          size               = {data.Count()}");
            Console.WriteLine($"          elapsed[ticks]     = {sw.ElapsedTicks}");
            Console.WriteLine($"          elapsed[ms]        = {sw.Elapsed.TotalMilliseconds}");
            sw.Reset();
            //----------------------------------------------------------------------------------------------------
            // Assert
            #if NUNIT
            Assert.AreEqual(5.0, mean.Index, 0.01);
            Assert.AreEqual(5.0, mean.Value, 0.01);
            #elif XUNIT
            Assert.Equal(5.0, mean.Index, 5);
            Assert.Equal(5.0, mean.Value, 5);
            #elif MSTEST
            Assert.AreEqual(5.0, mean.Index, 0.01);
            Assert.AreEqual(5.0, mean.Value, 0.01);
            #endif
            //====================================================================================================

            return;
        }

        [Benchmark]
        public (int Index, double Value) List_MedianWeighted()
        {
            return data_list.MedianWeighted(w2);
        }

        [Test]
        public void List_MedianWeighted_Test()
        {
            //====================================================================================================
            //  Arrange
            //  reading data from files

            sw = Stopwatch.StartNew();

            //----------------------------------------------------------------------------------------------------
            // Act
            //      extracted to atomic Benchmark method
            (int Index, double Value) mean = List_MedianWeighted();

            Console.WriteLine($"          mean               = {mean}");
            Console.WriteLine($"          size               = {data.Count()}");
            Console.WriteLine($"          elapsed[ticks]     = {sw.ElapsedTicks}");
            Console.WriteLine($"          elapsed[ms]        = {sw.Elapsed.TotalMilliseconds}");
            sw.Reset();
            //----------------------------------------------------------------------------------------------------
            // Assert
            #if NUNIT
            Assert.AreEqual(5.0, mean.Index, 0.01);
            Assert.AreEqual(5.0, mean.Value, 0.01);
            #elif XUNIT
            Assert.Equal(5.0, mean.Index, 5);
            Assert.Equal(5.0, mean.Value, 5);
            #elif MSTEST
            Assert.AreEqual(5.0, mean.Index, 0.01);
            Assert.AreEqual(5.0, mean.Value, 0.01);
            #endif
            //====================================================================================================

            return;
        }

        [Benchmark]
        public (int Index, double Value) Queue_MedianWeighted()
        {
            return data_queue.MedianWeighted(w2);
        }

        [Test]
        public void Queue_MedianWeighted_Test()
        {
            //====================================================================================================
            //  Arrange

            sw = Stopwatch.StartNew();

            //----------------------------------------------------------------------------------------------------
            // Act
            //      extracted to atomic Benchmark method
            (int Index, double Value) mean = Queue_MedianWeighted();

            sw.Stop();
            Console.WriteLine($"          mean               = {mean}");
            Console.WriteLine($"          size               = {data.Count()}");
            Console.WriteLine($"          elapsed[ticks]     = {sw.ElapsedTicks}");
            Console.WriteLine($"          elapsed[ms]        = {sw.Elapsed.TotalMilliseconds}");
            sw.Reset();
            //----------------------------------------------------------------------------------------------------
            // Assert
            #if NUNIT
            Assert.AreEqual(5.0, mean.Index, 0.01);
            Assert.AreEqual(5.0, mean.Value, 0.01);
            #elif XUNIT
            Assert.Equal(5.0, mean.Index, 5);
            Assert.Equal(5.0, mean.Value, 5);
            #elif MSTEST
            Assert.AreEqual(5.0, mean.Index, 0.01);
            Assert.AreEqual(5.0, mean.Value, 0.01);
            #endif
            //====================================================================================================

            return;
        }

        [Benchmark]
        public (int Index, double Value) Stack_MedianWeighted()
        {
            return data_stack.MedianWeighted(w2_r.Select(i => (double)i));
        }

        [Test]
        public void Stack_MedianWeighted_Test()
        {
            //====================================================================================================
            //  Arrange
            //  reading data from files

            sw = Stopwatch.StartNew();

            //----------------------------------------------------------------------------------------------------
            // Act
            //      extracted to atomic Benchmark method
            (int Index, double Value) mean = Stack_MedianWeighted();

            sw.Stop();
            Console.WriteLine($"          mean               = {mean}");
            Console.WriteLine($"          size               = {data.Count()}");
            Console.WriteLine($"          elapsed[ticks]     = {sw.ElapsedTicks}");
            Console.WriteLine($"          elapsed[ms]        = {sw.Elapsed.TotalMilliseconds}");
            sw.Reset();
            //----------------------------------------------------------------------------------------------------
            // Assert
            #if NUNIT
            Assert.AreEqual(5.0, mean.Index, 0.01);
            Assert.AreEqual(5.0, mean.Value, 0.01);
            #elif XUNIT
            Assert.Equal(5.0, mean.Index, 5);
            Assert.Equal(5.0, mean.Value, 5);
            #elif MSTEST
            Assert.AreEqual(5.0, mean.Index, 0.01);
            Assert.AreEqual(5.0, mean.Value, 0.01);
            #endif
            //====================================================================================================

            return;
        }

        [Benchmark]
        public (int Index, double Value) LinkedList_MedianWeighted()
        {
            return data_linked_list.MedianWeighted(w2);
        }

        [Test]
        public void LinkedList_MedianWeighted_Test()
        {
            //====================================================================================================
            //  Arrange
            //  reading data from files

            sw = Stopwatch.StartNew();

            //----------------------------------------------------------------------------------------------------
            // Act
            //      extracted to atomic Benchmark method
            (int Index, double Value) mean = LinkedList_MedianWeighted();

            sw.Stop();
            Console.WriteLine($"          mean               = {mean}");
            Console.WriteLine($"          size               = {data.Count()}");
            Console.WriteLine($"          elapsed[ticks]     = {sw.ElapsedTicks}");
            Console.WriteLine($"          elapsed[ms]        = {sw.Elapsed.TotalMilliseconds}");
            sw.Reset();
            //----------------------------------------------------------------------------------------------------
            // Assert
            #if NUNIT
            Assert.AreEqual(5.0, mean.Index, 0.01);
            Assert.AreEqual(5.0, mean.Value, 0.01);
            #elif XUNIT
            Assert.Equal(5.0, mean.Index, 5);
            Assert.Equal(5.0, mean.Value, 5);
            #elif MSTEST
            Assert.AreEqual(5.0, mean.Index, 0.01);
            Assert.AreEqual(5.0, mean.Value, 0.01);
            #endif
            //====================================================================================================

            return;
        }

        [Benchmark]
        public (int Index, double Value) ObservableCollection_MedianWeighted()
        {
            return data_observable_collection.MedianWeighted(w2);
        }

        [Test]
        public void ObservableCollection_MedianWeighted_Test()
        {
            //====================================================================================================
            //  Arrange
            //  reading data from files

            sw = Stopwatch.StartNew();

            //----------------------------------------------------------------------------------------------------
            // Act
            //      extracted to atomic Benchmark method
            (int Index, double Value) mean = ObservableCollection_MedianWeighted();

            sw.Stop();
            Console.WriteLine($"          mean               = {mean}");
            Console.WriteLine($"          size               = {data.Count()}");
            Console.WriteLine($"          elapsed[ticks]     = {sw.ElapsedTicks}");
            Console.WriteLine($"          elapsed[ms]        = {sw.Elapsed.TotalMilliseconds}");
            sw.Reset();
            //----------------------------------------------------------------------------------------------------
            // Assert
            #if NUNIT
            Assert.AreEqual(5.0, mean.Index, 0.01);
            Assert.AreEqual(5.0, mean.Value, 0.01);
            #elif XUNIT
            Assert.Equal(5.0, mean.Index, 5);
            Assert.Equal(5.0, mean.Value, 5);
            #elif MSTEST
            Assert.AreEqual(5.0, mean.Index, 0.01);
            Assert.AreEqual(5.0, mean.Value, 0.01);
            #endif
            //====================================================================================================

            return;
        }


        /*
            c# 7.2
            Span<T>, 
            ReadOnlySpan<T>, 
            Memory<T> 
            ReadOnlyMemory<T>
        */
        /*
        [Test]
        public void Span_MedianWeighted()
        {
            //====================================================================================================
            //  Arrange
            //  reading data from files

            sw = Stopwatch.StartNew();

            //----------------------------------------------------------------------------------------------------
            // Act
            Span<int> data = 
                            new Span<int>(data01);
                            //data01.AsSpan().Slice(start: 0)
                            ;
            double mean = data.MedianWeighted(w2);
            sw.Stop();
            Console.WriteLine($"          mean               = {mean}");
            Console.WriteLine($"          size               = {data.Count()}");
            Console.WriteLine($"          elapsed[ticks]     = {sw.ElapsedTicks}");
            Console.WriteLine($"          elapsed[ms]        = {sw.Elapsed.TotalMilliseconds}");
            sw.Reset();
            //----------------------------------------------------------------------------------------------------
            // Assert
            #if NUNIT
            Assert.AreEqual(5.0, mean, 0.01);
            #elif XUNIT
            Assert.Equal(5.0, mean, 5);
            #elif MSTEST
            Assert.AreEqual(5.0, mean, 0.01);
            #endif
            //====================================================================================================

            return;
        }

        [Test]
        public void Span_MedianWeighted()
        {
            //====================================================================================================
            //  Arrange
            //  reading data from files

            sw = Stopwatch.StartNew();

            //----------------------------------------------------------------------------------------------------
            // Act
            Memory<int> data =
                            new Memory<int>(data01);
                            //data01.AsSpan().Slice(start: 0)
                            ;
            double mean = data.MedianWeighted(w2);
            sw.Stop();
            Console.WriteLine($"          mean               = {mean}");
            Console.WriteLine($"          size               = {data.Count()}");
            Console.WriteLine($"          elapsed[ticks]     = {sw.ElapsedTicks}");
            Console.WriteLine($"          elapsed[ms]        = {sw.Elapsed.TotalMilliseconds}");
            sw.Reset();
            //----------------------------------------------------------------------------------------------------
            // Assert
            #if NUNIT
            Assert.AreEqual(5.0, mean, 0.01);
            #elif XUNIT
            Assert.Equal(5.0, mean, 5);
            #elif MSTEST
            Assert.AreEqual(5.0, mean, 0.01);
            #endif
            //====================================================================================================

            return;
        }
        */
    }
}
