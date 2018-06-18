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
    public partial class Tests20180119Dataset01
    {
        [Benchmark]
        public double Array_Skewness()
        {
            return data_array.Skewness();
        }

        [Test]
        public void Array_Skewness_Test()
        {
            Console.WriteLine($"Array_Skewness_Test");
            //====================================================================================================
            //  Arrange
            //  reading data from files

            sw = Stopwatch.StartNew();

            //----------------------------------------------------------------------------------------------------
            // Act
            //      extracted to atomic Benchmark method
            double skewness = Array_Skewness();

            sw.Stop();
            Console.WriteLine($"Array<double>.Skewness()");
            Console.WriteLine($"          skewness           = {skewness}");
            Console.WriteLine($"          size               = {data_array.Count()}");
            Console.WriteLine($"          elapsed[ticks]     = {sw.ElapsedTicks}");
            Console.WriteLine($"          elapsed[ms]        = {sw.Elapsed.TotalMilliseconds}");
            sw.Reset();
            double moment_3 = data_array.Moment(3);
            double moment_2 = data_array.Moment(2);
            int n = data_array.Count();
            double factor = 1.0;
            double skewness_check = factor * moment_3 / System.Math.Pow(moment_2, 3 / 2);
            //----------------------------------------------------------------------------------------------------
            // Assert
            #if NUNIT
            Assert.AreEqual(0.0, skewness, 0.00001);
            Assert.AreEqual(skewness_check, skewness, 0.00001);
            #elif XUNIT
            Assert.Equal(0.0, skewness, 5);
            Assert.Equal(skewness_check, skewness, 5);
            #elif MSTEST
            Assert.AreEqual(0.0, skewness, 0.00001);
            Assert.AreEqual(skewness_check, skewness, 0.00001);
            #endif
            //====================================================================================================

            return;
        }

        [Benchmark]
        public double ArraySegment_Skewness()
        {
            return data_array_segment.Skewness();
        }

        [Test]
        public void ArraySegment_Skewness_Test()
        {
            //====================================================================================================
            //  Arrange
            //  reading data from files

            sw = Stopwatch.StartNew();

            //----------------------------------------------------------------------------------------------------
            // Act
            //      extracted to atomic Benchmark method
            double skewness = ArraySegment_Skewness();

            sw.Stop();
            Console.WriteLine($"          skewness           = {skewness}");
            Console.WriteLine($"          size               = {data.Count()}");
            Console.WriteLine($"          elapsed[ticks]     = {sw.ElapsedTicks}");
            Console.WriteLine($"          elapsed[ms]        = {sw.Elapsed.TotalMilliseconds}");
            sw.Reset();
            double moment_3 = data_array_segment.Moment(3);
            double moment_2 = data_array_segment.Moment(2);
            int n = data_array_segment.Count();
            double factor = 1.0;
            double skewness_check = factor * moment_3 / System.Math.Pow(moment_2, 3 / 2);
            //----------------------------------------------------------------------------------------------------
            // Assert
            #if NUNIT
            Assert.AreEqual(0.0, skewness, 0.00001);
            Assert.AreEqual(skewness_check, skewness, 0.00001);
            #elif XUNIT
            Assert.Equal(0.0, skewness, 5);
            Assert.Equal(skewness_check, skewness, 5);
            #elif MSTEST
            Assert.AreEqual(0.0, skewness, 0.00001);
            Assert.AreEqual(skewness_check, skewness, 0.00001);
            #endif
            //====================================================================================================

            return;
        }

        [Benchmark]
        public double List_Skewness()
        {
            return data_list.Skewness();
        }

        [Test]
        public void List_Skewness_Test()
        {
            //====================================================================================================
            //  Arrange
            //  reading data from files

            sw = Stopwatch.StartNew();

            //----------------------------------------------------------------------------------------------------
            // Act
            //      extracted to atomic Benchmark method
            double skewness = List_Skewness();

            Console.WriteLine($"          skewness           = {skewness}");
            Console.WriteLine($"          size               = {data.Count()}");
            Console.WriteLine($"          elapsed[ticks]     = {sw.ElapsedTicks}");
            Console.WriteLine($"          elapsed[ms]        = {sw.Elapsed.TotalMilliseconds}");
            sw.Reset();
            double moment_3 = data_list.Moment(3);
            double moment_2 = data_list.Moment(2);
            int n = data_list.Count();
            double factor = 1.0;
            double skewness_check = factor * moment_3 / System.Math.Pow(moment_2, 3 / 2);
            //----------------------------------------------------------------------------------------------------
            // Assert
            #if NUNIT
            Assert.AreEqual(0.0, skewness, 0.00001);
            Assert.AreEqual(skewness_check, skewness, 0.00001);
            #elif XUNIT
            Assert.Equal(0.0, skewness, 5);
            Assert.Equal(skewness_check, skewness, 5);
            #elif MSTEST
            Assert.AreEqual(0.0, skewness, 0.00001);
            Assert.AreEqual(skewness_check, skewness, 0.00001);
            #endif
            //====================================================================================================

            return;
        }

        [Benchmark]
        public double Queue_Skewness()
        {
            return data_queue.Skewness();
        }

        [Test]
        public void Queue_Skewness_Test()
        {
            //====================================================================================================
            //  Arrange

            sw = Stopwatch.StartNew();

            //----------------------------------------------------------------------------------------------------
            // Act
            //      extracted to atomic Benchmark method
            double skewness = Queue_Skewness();

            sw.Stop();
            Console.WriteLine($"          skewness           = {skewness}");
            Console.WriteLine($"          size               = {data.Count()}");
            Console.WriteLine($"          elapsed[ticks]     = {sw.ElapsedTicks}");
            Console.WriteLine($"          elapsed[ms]        = {sw.Elapsed.TotalMilliseconds}");
            sw.Reset();
            double moment_3 = data_queue.Moment(3);
            double moment_2 = data_queue.Moment(2);
            int n = data_queue.Count();
            double factor = 1.0;
            double skewness_check = factor * moment_3 / System.Math.Pow(moment_2, 3 / 2);
            //----------------------------------------------------------------------------------------------------
            // Assert
            #if NUNIT
            Assert.AreEqual(0.0, skewness, 0.00001);
            Assert.AreEqual(skewness_check, skewness, 0.00001);
            #elif XUNIT
            Assert.Equal(0.0, skewness, 5);
            Assert.Equal(skewness_check, skewness, 5);
            #elif MSTEST
            Assert.AreEqual(0.0, skewness, 0.00001);
            Assert.AreEqual(skewness_check, skewness, 0.00001);
            #endif
            //====================================================================================================

            return;
        }

        [Benchmark]
        public double Stack_Skewness()
        {
            return data_stack.Skewness();
        }

        [Test]
        public void Stack_Skewness_Test()
        {
            //====================================================================================================
            //  Arrange
            //  reading data from files

            sw = Stopwatch.StartNew();

            //----------------------------------------------------------------------------------------------------
            // Act
            //      extracted to atomic Benchmark method
            double skewness = Stack_Skewness();

            sw.Stop();
            Console.WriteLine($"          skewness           = {skewness}");
            Console.WriteLine($"          size               = {data.Count()}");
            Console.WriteLine($"          elapsed[ticks]     = {sw.ElapsedTicks}");
            Console.WriteLine($"          elapsed[ms]        = {sw.Elapsed.TotalMilliseconds}");
            sw.Reset();
            double moment_3 = data_stack.Moment(3);
            double moment_2 = data_stack.Moment(2);
            int n = data_stack.Count();
            double factor = 1.0;
            double skewness_check = factor * moment_3 / System.Math.Pow(moment_2, 3 / 2);
            //----------------------------------------------------------------------------------------------------
            // Assert
            #if NUNIT
            Assert.AreEqual(0.0, skewness, 0.00001);
            Assert.AreEqual(skewness_check, skewness, 0.00001);
            #elif XUNIT
            Assert.Equal(0.0, skewness, 5);
            Assert.Equal(skewness_check, skewness, 5);
            #elif MSTEST
            Assert.AreEqual(0.0, skewness, 0.00001);
            Assert.AreEqual(skewness_check, skewness, 0.00001);
            #endif
            //====================================================================================================

            return;
        }

        [Benchmark]
        public double LinkedList_Skewness()
        {
            return data_linked_list.Skewness();
        }

        [Test]
        public void LinkedList_Skewness_Test()
        {
            //====================================================================================================
            //  Arrange
            //  reading data from files

            sw = Stopwatch.StartNew();

            //----------------------------------------------------------------------------------------------------
            // Act
            //      extracted to atomic Benchmark method
            double skewness = LinkedList_Skewness();

            sw.Stop();
            Console.WriteLine($"          skewness           = {skewness}");
            Console.WriteLine($"          size               = {data.Count()}");
            Console.WriteLine($"          elapsed[ticks]     = {sw.ElapsedTicks}");
            Console.WriteLine($"          elapsed[ms]        = {sw.Elapsed.TotalMilliseconds}");
            sw.Reset();
            double moment_3 = data_linked_list.Moment(3);
            double moment_2 = data_linked_list.Moment(2);
            int n = data_linked_list.Count();
            double factor = 1.0;
            double skewness_check = factor * moment_3 / System.Math.Pow(moment_2, 3 / 2);
            //----------------------------------------------------------------------------------------------------
            // Assert
            #if NUNIT
            Assert.AreEqual(0.0, skewness, 0.00001);
            Assert.AreEqual(skewness_check, skewness, 0.00001);
            #elif XUNIT
            Assert.Equal(0.0, skewness, 5);
            Assert.Equal(skewness_check, skewness, 5);
            #elif MSTEST
            Assert.AreEqual(0.0, skewness, 0.00001);
            Assert.AreEqual(skewness_check, skewness, 0.00001);
            #endif
            //====================================================================================================

            return;
        }

        [Benchmark]
        public double ObservableCollection_Skewness()
        {
            return data_observable_collection.Skewness();
        }

        [Test]
        public void ObservableCollection_Skewness_Test()
        {
            //====================================================================================================
            //  Arrange
            //  reading data from files

            sw = Stopwatch.StartNew();

            //----------------------------------------------------------------------------------------------------
            // Act
            //      extracted to atomic Benchmark method
            double skewness = ObservableCollection_Skewness();

            sw.Stop();
            Console.WriteLine($"          skewness           = {skewness}");
            Console.WriteLine($"          size               = {data.Count()}");
            Console.WriteLine($"          elapsed[ticks]     = {sw.ElapsedTicks}");
            Console.WriteLine($"          elapsed[ms]        = {sw.Elapsed.TotalMilliseconds}");
            sw.Reset();
            double moment_3 = data_observable_collection.Moment(3);
            double moment_2 = data_observable_collection.Moment(2);
            int n = data_observable_collection.Count();
            double factor = 1.0;
            double skewness_check = factor * moment_3 / System.Math.Pow(moment_2, 3 / 2);
            //----------------------------------------------------------------------------------------------------
            // Assert
            #if NUNIT
            Assert.AreEqual(0.0, skewness, 0.00001);
            Assert.AreEqual(skewness_check, skewness, 0.00001);
            #elif XUNIT
            Assert.Equal(0.0, skewness, 5);
            Assert.Equal(skewness_check, skewness, 5);
            #elif MSTEST
            Assert.AreEqual(0.0, skewness, 0.00001);
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
        public void Span_Skewness()
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
            double skewness = data.Skewness();
            sw.Stop();
            Console.WriteLine($"          skewness           = {skewness}");
            Console.WriteLine($"          size               = {data.Count()}");
            Console.WriteLine($"          elapsed[ticks]     = {sw.ElapsedTicks}");
            Console.WriteLine($"          elapsed[ms]        = {sw.Elapsed.TotalMilliseconds}");
            sw.Reset();
            //----------------------------------------------------------------------------------------------------
            // Assert
            #if NUNIT
            Assert.AreEqual(0.0, skewness, 0.00001);
            #elif XUNIT
            Assert.Equal(0.0, skewness, 5);
            #elif MSTEST
            Assert.AreEqual(0.0, skewness, 0.00001);
            #endif
            //====================================================================================================

            return;
        }

        [Test]
        public void Span_Skewness()
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
            double skewness = data.Skewness();
            sw.Stop();
            Console.WriteLine($"          skewness           = {skewness}");
            Console.WriteLine($"          size               = {data.Count()}");
            Console.WriteLine($"          elapsed[ticks]     = {sw.ElapsedTicks}");
            Console.WriteLine($"          elapsed[ms]        = {sw.Elapsed.TotalMilliseconds}");
            sw.Reset();
            //----------------------------------------------------------------------------------------------------
            // Assert
            #if NUNIT
            Assert.AreEqual(0.0, skewness, 0.00001);
            #elif XUNIT
            Assert.Equal(0.0, skewness, 5);
            #elif MSTEST
            Assert.AreEqual(0.0, skewness, 0.00001);
            #endif
            //====================================================================================================

            return;
        }
        */
    }
}
