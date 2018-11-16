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
using System.Collections.ObjectModel;

using Core.Math.Statistics.Descriptive.Sequential;

namespace UnitTests.Core.Math.Statistics.Descriptive.Sequential.Sync.MedianWeighted.Wikipedia
{
    public partial class Tests20180525MedianWeightedWikipedia01
    {
        static double[] w21 = new double[] { 0.15, 0.1, 0.2, 0.3, 0.25 };
        static double[] w21_r = Enumerable.Reverse(w21).ToArray();

        [Benchmark]
        public
            (
                int IndexLower,
                int IndexUpper,
                double ValueLower,
                double ValueUpper,
                double Median
            )
            Array_MedianWeighted()
        {
            return data_array.MedianWeighted(w21);
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
            (
                int IndexLower,
                int IndexUpper,
                double ValueLower,
                double ValueUpper,
                double Median
            )
                median_weighted = Array_MedianWeighted();

            sw.Stop();
            Console.WriteLine($"Array<double>.MedianWeighted()");
            Console.WriteLine($"          median_weighted               = {median_weighted}");
            Console.WriteLine($"          size               = {data_array.Count()}");
            Console.WriteLine($"          elapsed[ticks]     = {sw.ElapsedTicks}");
            Console.WriteLine($"          elapsed[ms]        = {sw.Elapsed.TotalMilliseconds}");
            sw.Reset();
            double median = data_array.Median();
            //----------------------------------------------------------------------------------------------------
            // Assert
            #if NUNIT
            Assert.AreEqual(2, median_weighted.IndexLower);
            Assert.AreEqual(4, median_weighted.IndexUpper);
            Assert.AreEqual(3.0, median_weighted.ValueLower, 0.01);
            Assert.AreEqual(5.0, median_weighted.ValueUpper, 0.01);
            Assert.AreEqual(4.0, median_weighted.Median, 0.01);
            #elif XUNIT
            Assert.Equal(2, median_weighted.IndexLower);
            Assert.Equal(4, median_weighted.IndexUpper);
            Assert.Equal(3.0, median_weighted.ValueLower, 2);
            Assert.Equal(5.0, median_weighted.ValueUpper, 2);
            Assert.Equal(4.0, median_weighted.Median, 2);
            #elif MSTEST
            Assert.AreEqual(2, median_weighted.IndexLower);
            Assert.AreEqual(4, median_weighted.IndexUpper);
            Assert.AreEqual(3.0, median_weighted.ValueLower, 0.01);
            Assert.AreEqual(5.0, median_weighted.ValueUpper, 0.01);
            Assert.AreEqual(4.0, median_weighted.Median, 0.01);
            #endif
            //====================================================================================================

            return;
        }

        [Benchmark]
        public
            (
                int IndexLower,
                int IndexUpper,
                double ValueLower,
                double ValueUpper,
                double Median
            )
            ArraySegment_MedianWeighted()
        {
            return data_array_segment.MedianWeighted(w21);
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
            (
                int IndexLower,
                int IndexUpper,
                double ValueLower,
                double ValueUpper,
                double Median
            )
                median_weighted = ArraySegment_MedianWeighted();

            sw.Stop();
            Console.WriteLine($"          median_weighted               = {median_weighted}");
            Console.WriteLine($"          size               = {data.Count()}");
            Console.WriteLine($"          elapsed[ticks]     = {sw.ElapsedTicks}");
            Console.WriteLine($"          elapsed[ms]        = {sw.Elapsed.TotalMilliseconds}");
            sw.Reset();
            double median = data_array_segment.Median();
            //----------------------------------------------------------------------------------------------------
            // Assert
            #if NUNIT
            Assert.AreEqual(2, median_weighted.IndexLower);
            Assert.AreEqual(4, median_weighted.IndexUpper);
            Assert.AreEqual(3.0, median_weighted.ValueLower, 0.01);
            Assert.AreEqual(5.0, median_weighted.ValueUpper, 0.01);
            Assert.AreEqual(4.0, median_weighted.Median, 0.01);
            #elif XUNIT
            Assert.Equal(2, median_weighted.IndexLower);
            Assert.Equal(4, median_weighted.IndexUpper);
            Assert.Equal(3.0, median_weighted.ValueLower, 2);
            Assert.Equal(5.0, median_weighted.ValueUpper, 2);
            Assert.Equal(4.0, median_weighted.Median, 2);
            #elif MSTEST
            Assert.AreEqual(2, median_weighted.IndexLower);
            Assert.AreEqual(4, median_weighted.IndexUpper);
            Assert.AreEqual(3.0, median_weighted.ValueLower, 0.01);
            Assert.AreEqual(5.0, median_weighted.ValueUpper, 0.01);
            Assert.AreEqual(4.0, median_weighted.Median, 0.01);
            #endif
            //====================================================================================================

            return;
        }

        [Benchmark]
        public
            (
                int IndexLower,
                int IndexUpper,
                double ValueLower,
                double ValueUpper,
                double Median
            )
            List_MedianWeighted()
        {
            return data_list.MedianWeighted(w21);
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
            (
                int IndexLower,
                int IndexUpper,
                double ValueLower,
                double ValueUpper,
                double Median
            )
                median_weighted = List_MedianWeighted();

            Console.WriteLine($"          median_weighted               = {median_weighted}");
            Console.WriteLine($"          size               = {data.Count()}");
            Console.WriteLine($"          elapsed[ticks]     = {sw.ElapsedTicks}");
            Console.WriteLine($"          elapsed[ms]        = {sw.Elapsed.TotalMilliseconds}");
            sw.Reset();
            double median = data_list.Median();
            //----------------------------------------------------------------------------------------------------
            // Assert
            #if NUNIT
            Assert.AreEqual(2, median_weighted.IndexLower);
            Assert.AreEqual(4, median_weighted.IndexUpper);
            Assert.AreEqual(3.0, median_weighted.ValueLower, 0.01);
            Assert.AreEqual(5.0, median_weighted.ValueUpper, 0.01);
            Assert.AreEqual(4.0, median_weighted.Median, 0.01);
            #elif XUNIT
            Assert.Equal(2, median_weighted.IndexLower);
            Assert.Equal(4, median_weighted.IndexUpper);
            Assert.Equal(3.0, median_weighted.ValueLower, 2);
            Assert.Equal(5.0, median_weighted.ValueUpper, 2);
            Assert.Equal(4.0, median_weighted.Median, 2);
            #elif MSTEST
            Assert.AreEqual(2, median_weighted.IndexLower);
            Assert.AreEqual(4, median_weighted.IndexUpper);
            Assert.AreEqual(3.0, median_weighted.ValueLower, 0.01);
            Assert.AreEqual(5.0, median_weighted.ValueUpper, 0.01);
            Assert.AreEqual(4.0, median_weighted.Median, 0.01);
            #endif
            //====================================================================================================

            return;
        }

        [Benchmark]
        public
            (
                int IndexLower,
                int IndexUpper,
                double ValueLower,
                double ValueUpper,
                double Median
            )
            Queue_MedianWeighted()
        {
            return data_queue.MedianWeighted(w21);
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
            (
                int IndexLower,
                int IndexUpper,
                double ValueLower,
                double ValueUpper,
                double Median
            )
                median_weighted = Queue_MedianWeighted();

            sw.Stop();
            Console.WriteLine($"          median_weighted               = {median_weighted}");
            Console.WriteLine($"          size               = {data.Count()}");
            Console.WriteLine($"          elapsed[ticks]     = {sw.ElapsedTicks}");
            Console.WriteLine($"          elapsed[ms]        = {sw.Elapsed.TotalMilliseconds}");
            sw.Reset();
            double median = data_queue.Median();
            //----------------------------------------------------------------------------------------------------
            // Assert
            #if NUNIT
            Assert.AreEqual(2, median_weighted.IndexLower);
            Assert.AreEqual(4, median_weighted.IndexUpper);
            Assert.AreEqual(3.0, median_weighted.ValueLower, 0.01);
            Assert.AreEqual(5.0, median_weighted.ValueUpper, 0.01);
            Assert.AreEqual(4.0, median_weighted.Median, 0.01);
            #elif XUNIT
            Assert.Equal(2, median_weighted.IndexLower);
            Assert.Equal(4, median_weighted.IndexUpper);
            Assert.Equal(3.0, median_weighted.ValueLower, 2);
            Assert.Equal(5.0, median_weighted.ValueUpper, 2);
            Assert.Equal(4.0, median_weighted.Median, 2);
            #elif MSTEST
            Assert.AreEqual(2, median_weighted.IndexLower);
            Assert.AreEqual(4, median_weighted.IndexUpper);
            Assert.AreEqual(3.0, median_weighted.ValueLower, 0.01);
            Assert.AreEqual(5.0, median_weighted.ValueUpper, 0.01);
            Assert.AreEqual(4.0, median_weighted.Median, 0.01);
            #endif
            //====================================================================================================

            return;
        }

        [Benchmark]
        public
            (
                int IndexLower,
                int IndexUpper,
                double ValueLower,
                double ValueUpper,
                double Median
            )
                Stack_MedianWeighted()
        {
            return data_stack.MedianWeighted(w21);
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
            (
                int IndexLower,
                int IndexUpper,
                double ValueLower,
                double ValueUpper,
                double Median
            )
                median_weighted = Stack_MedianWeighted();

            sw.Stop();
            Console.WriteLine($"          median_weighted               = {median_weighted}");
            Console.WriteLine($"          size               = {data.Count()}");
            Console.WriteLine($"          elapsed[ticks]     = {sw.ElapsedTicks}");
            Console.WriteLine($"          elapsed[ms]        = {sw.Elapsed.TotalMilliseconds}");
            sw.Reset();
            double median = data_stack.Median();
            //----------------------------------------------------------------------------------------------------
            // Assert
            //#if NUNIT
            //Assert.AreEqual(2, median_weighted.IndexLower);
            //Assert.AreEqual(4, median_weighted.IndexUpper);
            //Assert.AreEqual(5.0, median_weighted.ValueLower, 0.01);
            //Assert.AreEqual(3.0, median_weighted.ValueUpper, 0.01);
            //Assert.AreEqual(4.0, median_weighted.Median, 0.01);
            //#elif XUNIT
            //Assert.Equal(2, median_weighted.IndexLower);
            //Assert.Equal(4, median_weighted.IndexUpper);
            //Assert.Equal(5.0, median_weighted.ValueLower, 2);
            //Assert.Equal(3.0, median_weighted.ValueUpper, 2);
            //Assert.Equal(4.0, median_weighted.Median, 2);
            //#elif MSTEST
            //Assert.AreEqual(2, median_weighted.IndexLower);
            //Assert.AreEqual(4, median_weighted.IndexUpper);
            //Assert.AreEqual(5.0, median_weighted.ValueLower, 0.01);
            //Assert.AreEqual(3.0, median_weighted.ValueUpper, 0.01);
            //Assert.AreEqual(4.0, median_weighted.Median, 0.01);
            //#endif
            //====================================================================================================

            return;
        }

        [Benchmark]
        public
            (
                int IndexLower,
                int IndexUpper,
                double ValueLower,
                double ValueUpper,
                double Median
            )
            LinkedList_MedianWeighted()
        {
            return data_linked_list.MedianWeighted(w21);
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
            (
                int IndexLower,
                int IndexUpper,
                double ValueLower,
                double ValueUpper,
                double Median
            )
                median_weighted = LinkedList_MedianWeighted();

            sw.Stop();
            Console.WriteLine($"          median_weighted               = {median_weighted}");
            Console.WriteLine($"          size               = {data.Count()}");
            Console.WriteLine($"          elapsed[ticks]     = {sw.ElapsedTicks}");
            Console.WriteLine($"          elapsed[ms]        = {sw.Elapsed.TotalMilliseconds}");
            sw.Reset();
            double median = data_linked_list.Median();
            //----------------------------------------------------------------------------------------------------
            // Assert
            #if NUNIT
            Assert.AreEqual(2, median_weighted.IndexLower);
            Assert.AreEqual(4, median_weighted.IndexUpper);
            Assert.AreEqual(3.0, median_weighted.ValueLower, 0.01);
            Assert.AreEqual(5.0, median_weighted.ValueUpper, 0.01);
            Assert.AreEqual(4.0, median_weighted.Median, 0.01);
            #elif XUNIT
            Assert.Equal(2, median_weighted.IndexLower);
            Assert.Equal(4, median_weighted.IndexUpper);
            Assert.Equal(3.0, median_weighted.ValueLower, 2);
            Assert.Equal(5.0, median_weighted.ValueUpper, 2);
            Assert.Equal(4.0, median_weighted.Median, 2);
            #elif MSTEST
            Assert.AreEqual(2, median_weighted.IndexLower);
            Assert.AreEqual(4, median_weighted.IndexUpper);
            Assert.AreEqual(3.0, median_weighted.ValueLower, 0.01);
            Assert.AreEqual(5.0, median_weighted.ValueUpper, 0.01);
            Assert.AreEqual(4.0, median_weighted.Median, 0.01);
            #endif
            //====================================================================================================

            return;
        }

        [Benchmark]
        public
            (
                int IndexLower,
                int IndexUpper,
                double ValueLower,
                double ValueUpper,
                double Median
            )
                ObservableCollection_MedianWeighted()
        {
            return data_observable_collection.MedianWeighted(w21);
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
            (
                int IndexLower,
                int IndexUpper,
                double ValueLower,
                double ValueUpper,
                double Median
            )
                median_weighted = ObservableCollection_MedianWeighted();

            sw.Stop();
            Console.WriteLine($"          median_weighted               = {median_weighted}");
            Console.WriteLine($"          size               = {data.Count()}");
            Console.WriteLine($"          elapsed[ticks]     = {sw.ElapsedTicks}");
            Console.WriteLine($"          elapsed[ms]        = {sw.Elapsed.TotalMilliseconds}");
            sw.Reset();
            double median = data_observable_collection.Median();
            //----------------------------------------------------------------------------------------------------
            // Assert
            #if NUNIT
            Assert.AreEqual(2, median_weighted.IndexLower);
            Assert.AreEqual(4, median_weighted.IndexUpper);
            Assert.AreEqual(3.0, median_weighted.ValueLower, 0.01);
            Assert.AreEqual(5.0, median_weighted.ValueUpper, 0.01);
            Assert.AreEqual(4.0, median_weighted.Median, 0.01);
            #elif XUNIT
            Assert.Equal(2, median_weighted.IndexLower);
            Assert.Equal(4, median_weighted.IndexUpper);
            Assert.Equal(3.0, median_weighted.ValueLower, 2);
            Assert.Equal(5.0, median_weighted.ValueUpper, 2);
            Assert.Equal(4.0, median_weighted.Median, 2);
            #elif MSTEST
            Assert.AreEqual(2, median_weighted.IndexLower);
            Assert.AreEqual(4, median_weighted.IndexUpper);
            Assert.AreEqual(3.0, median_weighted.ValueLower, 0.01);
            Assert.AreEqual(5.0, median_weighted.ValueUpper, 0.01);
            Assert.AreEqual(4.0, median_weighted.Median, 0.01);
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
            double median_weighted = data.MedianWeighted(w21);
            sw.Stop();
            Console.WriteLine($"          median_weighted               = {median_weighted}");
            Console.WriteLine($"          size               = {data.Count()}");
            Console.WriteLine($"          elapsed[ticks]     = {sw.ElapsedTicks}");
            Console.WriteLine($"          elapsed[ms]        = {sw.Elapsed.TotalMilliseconds}");
            sw.Reset();
            //----------------------------------------------------------------------------------------------------
            // Assert
            #if NUNIT
            Assert.AreEqual(5.0, median_weighted, 0.01);
                        #elif XUNIT
            Assert.Equal(5.0, median_weighted, 5);
                        #elif MSTEST
            Assert.AreEqual(5.0, median_weighted, 0.01);
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
            double median_weighted = data.MedianWeighted(w21);
            sw.Stop();
            Console.WriteLine($"          median_weighted               = {median_weighted}");
            Console.WriteLine($"          size               = {data.Count()}");
            Console.WriteLine($"          elapsed[ticks]     = {sw.ElapsedTicks}");
            Console.WriteLine($"          elapsed[ms]        = {sw.Elapsed.TotalMilliseconds}");
            sw.Reset();
            //----------------------------------------------------------------------------------------------------
            // Assert
            #if NUNIT
            Assert.AreEqual(5.0, median_weighted, 0.01);
                        #elif XUNIT
            Assert.Equal(5.0, median_weighted, 5);
                        #elif MSTEST
            Assert.AreEqual(5.0, median_weighted, 0.01);
                        #endif
            //====================================================================================================

            return;
        }
        */
    }
}
