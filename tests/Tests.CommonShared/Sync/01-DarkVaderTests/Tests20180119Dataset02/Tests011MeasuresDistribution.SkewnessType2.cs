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
using Benchmark = HolisticWare.Core.Testing.BenchmarkTests.Benchmark;using ShortRunJob = HolisticWare.Core.Testing.BenchmarkTests.ShortRunJob;
#endif

using System;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;
using System.Collections.ObjectModel;

using Core.Math.Statistics.Descriptive.Sequential;

namespace UnitTests.Core.Math.Statistics.Descriptive.Sequential.Sync
{
    public partial class Tests20180119Dataset02
    {
        [Benchmark]
        public double Array_SkewnessType2()
        {
            return data_array.SkewnessType2();
        }

        [Test]
        public void Array_SkewnessType2_Test()
        {
            Console.WriteLine($"Array_SkewnessType2_Test");
            //====================================================================================================
            //  Arrange
            //  reading data from files

            sw = Stopwatch.StartNew();

            //----------------------------------------------------------------------------------------------------
            // Act
            //      extracted to atomic Benchmark method
            double skewness = Array_SkewnessType2();

            sw.Stop();
            Console.WriteLine($"Array<double>.SkewnessType2()");
            Console.WriteLine($"          skewness           = {skewness}");
            Console.WriteLine($"          size               = {data_array.Count()}");
            Console.WriteLine($"          elapsed[ticks]     = {sw.ElapsedTicks}");
            Console.WriteLine($"          elapsed[ms]        = {sw.Elapsed.TotalMilliseconds}");
            sw.Reset();
            double moment_3 = data_array.Moment(3);
            double moment_2 = data_array.Moment(2);
            int n = data_array.Count();
            double factor = System.Math.Sqrt(n * (n -1)) / (n - 2);
            double skewness_check = factor * moment_3 / System.Math.Pow(moment_2, 3.0 / 2.0);
            //----------------------------------------------------------------------------------------------------
            // Assert
            #if NUNIT
            Assert.AreEqual(1.359780, skewness, 0.00001);
            Assert.AreEqual(skewness_check, skewness, 0.00001);
            #elif XUNIT
            Assert.Equal(1.359780, skewness, 5);
            Assert.Equal(skewness_check, skewness, 5);
            #elif MSTEST
            Assert.AreEqual(1.359780, skewness, 0.00001);
            Assert.AreEqual(skewness_check, skewness, 0.00001);
            #endif
            //====================================================================================================

            return;
        }

        [Benchmark]
        public double ArraySegment_SkewnessType2()
        {
            return data_array_segment.SkewnessType2();
        }

        [Test]
        public void ArraySegment_SkewnessType2_Test()
        {
            //====================================================================================================
            //  Arrange
            //  reading data from files

            sw = Stopwatch.StartNew();

            //----------------------------------------------------------------------------------------------------
            // Act
            //      extracted to atomic Benchmark method
            double skewness = ArraySegment_SkewnessType2();

            sw.Stop();
            Console.WriteLine($"          skewness           = {skewness}");
            Console.WriteLine($"          size               = {data.Count()}");
            Console.WriteLine($"          elapsed[ticks]     = {sw.ElapsedTicks}");
            Console.WriteLine($"          elapsed[ms]        = {sw.Elapsed.TotalMilliseconds}");
            sw.Reset();
            double moment_3 = data_array_segment.Moment(3);
            double moment_2 = data_array_segment.Moment(2);
            int n = data_array_segment.Count();
            double factor = System.Math.Sqrt(n * (n -1)) / (n - 2);
            double skewness_check = factor * moment_3 / System.Math.Pow(moment_2, 3.0 / 2.0);
            //----------------------------------------------------------------------------------------------------
            // Assert
            #if NUNIT
            Assert.AreEqual(1.359780, skewness, 0.00001);
            Assert.AreEqual(skewness_check, skewness, 0.00001);
            #elif XUNIT
            Assert.Equal(1.359780, skewness, 5);
            Assert.Equal(skewness_check, skewness, 5);
            #elif MSTEST
            Assert.AreEqual(1.359780, skewness, 0.00001);
            Assert.AreEqual(skewness_check, skewness, 0.00001);
            #endif
            //====================================================================================================

            return;
        }

        [Benchmark]
        public double List_SkewnessType2()
        {
            return data_list.SkewnessType2();
        }

        [Test]
        public void List_SkewnessType2_Test()
        {
            //====================================================================================================
            //  Arrange
            //  reading data from files

            sw = Stopwatch.StartNew();

            //----------------------------------------------------------------------------------------------------
            // Act
            //      extracted to atomic Benchmark method
            double skewness = List_SkewnessType2();

            Console.WriteLine($"          skewness           = {skewness}");
            Console.WriteLine($"          size               = {data.Count()}");
            Console.WriteLine($"          elapsed[ticks]     = {sw.ElapsedTicks}");
            Console.WriteLine($"          elapsed[ms]        = {sw.Elapsed.TotalMilliseconds}");
            sw.Reset();
            double moment_3 = data_list.Moment(3);
            double moment_2 = data_list.Moment(2);
            int n = data_list.Count();
            double factor = System.Math.Sqrt(n * (n -1)) / (n - 2);
            double skewness_check = factor * moment_3 / System.Math.Pow(moment_2, 3.0 / 2.0);
            //----------------------------------------------------------------------------------------------------
            // Assert
            #if NUNIT
            Assert.AreEqual(1.359780, skewness, 0.00001);
            Assert.AreEqual(skewness_check, skewness, 0.00001);
            #elif XUNIT
            Assert.Equal(1.359780, skewness, 5);
            Assert.Equal(skewness_check, skewness, 5);
            #elif MSTEST
            Assert.AreEqual(1.359780, skewness, 0.00001);
            Assert.AreEqual(skewness_check, skewness, 0.00001);
            #endif
            //====================================================================================================

            return;
        }

        [Benchmark]
        public double Queue_SkewnessType2()
        {
            return data_queue.SkewnessType2();
        }

        [Test]
        public void Queue_SkewnessType2_Test()
        {
            //====================================================================================================
            //  Arrange

            sw = Stopwatch.StartNew();

            //----------------------------------------------------------------------------------------------------
            // Act
            //      extracted to atomic Benchmark method
            double skewness = Queue_SkewnessType2();

            sw.Stop();
            Console.WriteLine($"          skewness           = {skewness}");
            Console.WriteLine($"          size               = {data.Count()}");
            Console.WriteLine($"          elapsed[ticks]     = {sw.ElapsedTicks}");
            Console.WriteLine($"          elapsed[ms]        = {sw.Elapsed.TotalMilliseconds}");
            sw.Reset();
            double moment_3 = data_queue.Moment(3);
            double moment_2 = data_queue.Moment(2);
            int n = data_queue.Count();
            double factor = System.Math.Sqrt(n * (n -1)) / (n - 2);
            double skewness_check = factor * moment_3 / System.Math.Pow(moment_2, 3.0 / 2.0);
            //----------------------------------------------------------------------------------------------------
            // Assert
            #if NUNIT
            Assert.AreEqual(1.359780, skewness, 0.00001);
            Assert.AreEqual(skewness_check, skewness, 0.00001);
            #elif XUNIT
            Assert.Equal(1.359780, skewness, 5);
            Assert.Equal(skewness_check, skewness, 5);
            #elif MSTEST
            Assert.AreEqual(1.359780, skewness, 0.00001);
            Assert.AreEqual(skewness_check, skewness, 0.00001);
            #endif
            //====================================================================================================

            return;
        }

        [Benchmark]
        public double Stack_SkewnessType2()
        {
            return data_stack.SkewnessType2();
        }

        [Test]
        public void Stack_SkewnessType2_Test()
        {
            //====================================================================================================
            //  Arrange
            //  reading data from files

            sw = Stopwatch.StartNew();

            //----------------------------------------------------------------------------------------------------
            // Act
            //      extracted to atomic Benchmark method
            double skewness = Stack_SkewnessType2();

            sw.Stop();
            Console.WriteLine($"          skewness           = {skewness}");
            Console.WriteLine($"          size               = {data.Count()}");
            Console.WriteLine($"          elapsed[ticks]     = {sw.ElapsedTicks}");
            Console.WriteLine($"          elapsed[ms]        = {sw.Elapsed.TotalMilliseconds}");
            sw.Reset();
            double moment_3 = data_stack.Moment(3);
            double moment_2 = data_stack.Moment(2);
            int n = data_stack.Count();
            double factor = System.Math.Sqrt(n * (n -1)) / (n - 2);
            double skewness_check = factor * moment_3 / System.Math.Pow(moment_2, 3.0 / 2.0);
            //----------------------------------------------------------------------------------------------------
            // Assert
            #if NUNIT
            Assert.AreEqual(1.359780, skewness, 0.00001);
            Assert.AreEqual(skewness_check, skewness, 0.00001);
            #elif XUNIT
            Assert.Equal(1.359780, skewness, 5);
            Assert.Equal(skewness_check, skewness, 5);
            #elif MSTEST
            Assert.AreEqual(1.359780, skewness, 0.00001);
            Assert.AreEqual(skewness_check, skewness, 0.00001);
            #endif
            //====================================================================================================

            return;
        }

        [Benchmark]
        public double LinkedList_SkewnessType2()
        {
            return data_linked_list.SkewnessType2();
        }

        [Test]
        public void LinkedList_SkewnessType2_Test()
        {
            //====================================================================================================
            //  Arrange
            //  reading data from files

            sw = Stopwatch.StartNew();

            //----------------------------------------------------------------------------------------------------
            // Act
            //      extracted to atomic Benchmark method
            double skewness = LinkedList_SkewnessType2();

            sw.Stop();
            Console.WriteLine($"          skewness           = {skewness}");
            Console.WriteLine($"          size               = {data.Count()}");
            Console.WriteLine($"          elapsed[ticks]     = {sw.ElapsedTicks}");
            Console.WriteLine($"          elapsed[ms]        = {sw.Elapsed.TotalMilliseconds}");
            sw.Reset();
            double moment_3 = data_linked_list.Moment(3);
            double moment_2 = data_linked_list.Moment(2);
            int n = data_linked_list.Count();
            double factor = System.Math.Sqrt(n * (n -1)) / (n - 2);
            double skewness_check = factor * moment_3 / System.Math.Pow(moment_2, 3.0 / 2.0);
            //----------------------------------------------------------------------------------------------------
            // Assert
            #if NUNIT
            Assert.AreEqual(1.359780, skewness, 0.00001);
            Assert.AreEqual(skewness_check, skewness, 0.00001);
            #elif XUNIT
            Assert.Equal(1.359780, skewness, 5);
            Assert.Equal(skewness_check, skewness, 5);
            #elif MSTEST
            Assert.AreEqual(1.359780, skewness, 0.00001);
            Assert.AreEqual(skewness_check, skewness, 0.00001);
            #endif
            //====================================================================================================

            return;
        }

        [Benchmark]
        public double ObservableCollection_SkewnessType2()
        {
            return data_observable_collection.SkewnessType2();
        }

        [Test]
        public void ObservableCollection_SkewnessType2_Test()
        {
            //====================================================================================================
            //  Arrange
            //  reading data from files

            sw = Stopwatch.StartNew();

            //----------------------------------------------------------------------------------------------------
            // Act
            //      extracted to atomic Benchmark method
            double skewness = ObservableCollection_SkewnessType2();

            sw.Stop();
            Console.WriteLine($"          skewness           = {skewness}");
            Console.WriteLine($"          size               = {data.Count()}");
            Console.WriteLine($"          elapsed[ticks]     = {sw.ElapsedTicks}");
            Console.WriteLine($"          elapsed[ms]        = {sw.Elapsed.TotalMilliseconds}");
            sw.Reset();
            double moment_3 = data_observable_collection.Moment(3);
            double moment_2 = data_observable_collection.Moment(2);
            int n = data_observable_collection.Count();
            double factor = System.Math.Sqrt(n * (n -1)) / (n - 2);
            double skewness_check = factor * moment_3 / System.Math.Pow(moment_2, 3.0 / 2.0);
            //----------------------------------------------------------------------------------------------------
            // Assert
            #if NUNIT
            Assert.AreEqual(1.359780, skewness, 0.00001);
            Assert.AreEqual(skewness_check, skewness, 0.00001);
            #elif XUNIT
            Assert.Equal(1.359780, skewness, 5);
            Assert.Equal(skewness_check, skewness, 5);
            #elif MSTEST
            Assert.AreEqual(1.359780, skewness, 0.00001);
            Assert.AreEqual(skewness_check, skewness, 0.00001);
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
        public void Span_SkewnessType2()
        {
            //====================================================================================================
            //  Arrange
            //  reading data from files

            sw = Stopwatch.StartNew();

            //----------------------------------------------------------------------------------------------------
            // Act
            Span<double> data = 
                            new Span<double>(data01);
                            //data01.AsSpan().Slice(start: 0)
                            ;
            double skewness = data.SkewnessType2();
            sw.Stop();
            Console.WriteLine($"          skewness           = {skewness}");
            Console.WriteLine($"          size               = {data.Count()}");
            Console.WriteLine($"          elapsed[ticks]     = {sw.ElapsedTicks}");
            Console.WriteLine($"          elapsed[ms]        = {sw.Elapsed.TotalMilliseconds}");
            sw.Reset();
            //----------------------------------------------------------------------------------------------------
            // Assert
            #if NUNIT
            Assert.AreEqual(1.359780, skewness, 0.00001);
            #elif XUNIT
            Assert.Equal(1.359780, skewness, 5);
            #elif MSTEST
            Assert.AreEqual(1.359780, skewness, 0.00001);
            #endif
            //====================================================================================================

            return;
        }

        [Test]
        public void Span_SkewnessType2()
        {
            //====================================================================================================
            //  Arrange
            //  reading data from files

            sw = Stopwatch.StartNew();

            //----------------------------------------------------------------------------------------------------
            // Act
            Memory<double> data =
                            new Memory<double>(data01);
                            //data01.AsSpan().Slice(start: 0)
                            ;
            double skewness = data.SkewnessType2();
            sw.Stop();
            Console.WriteLine($"          skewness           = {skewness}");
            Console.WriteLine($"          size               = {data.Count()}");
            Console.WriteLine($"          elapsed[ticks]     = {sw.ElapsedTicks}");
            Console.WriteLine($"          elapsed[ms]        = {sw.Elapsed.TotalMilliseconds}");
            sw.Reset();
            //----------------------------------------------------------------------------------------------------
            // Assert
            #if NUNIT
            Assert.AreEqual(1.359780, skewness, 0.00001);
            #elif XUNIT
            Assert.Equal(1.359780, skewness, 5);
            #elif MSTEST
            Assert.AreEqual(1.359780, skewness, 0.00001);
            #endif
            //====================================================================================================

            return;
        }
        */
    }
}
