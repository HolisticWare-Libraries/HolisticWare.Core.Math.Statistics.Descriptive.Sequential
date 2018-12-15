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
        public double Array_Moment_2()
        {
            return data_array.Moment(2);
        }

        [Test]
        public void Array_Moment_2_Test()
        {
            Console.WriteLine($"Array_Moment_2_Test");
            //====================================================================================================
            //  Arrange
            //  reading data from files

            sw = Stopwatch.StartNew();

            //----------------------------------------------------------------------------------------------------
            // Act
            //      extracted to atomic Benchmark method
            double moment = Array_Moment_2();

            sw.Stop();
            Console.WriteLine($"Array<double>.Median()");
            Console.WriteLine($"          moment               = {moment}");
            Console.WriteLine($"          size               = {data_array.Count()}");
            Console.WriteLine($"          elapsed[ticks]     = {sw.ElapsedTicks}");
            Console.WriteLine($"          elapsed[ms]        = {sw.Elapsed.TotalMilliseconds}");
            sw.Reset();
            double variance = data_array.VariancePopulation();
            //----------------------------------------------------------------------------------------------------
            // Assert
            #if NUNIT
            Assert.AreEqual(1.2, moment, 0.01);
            Assert.AreEqual(1.2, variance, 0.01);
            #elif XUNIT
            Assert.Equal(1.2, moment, 5);
            Assert.Equal(1.2, variance, 5);
            #elif MSTEST
            Assert.AreEqual(1.2, moment, 0.01);
            Assert.AreEqual(1.2, variance, 5);
            #endif
            //====================================================================================================

            return;
        }

        [Benchmark]
        public double ArraySegment_Moment_2()
        {
            return data_array_segment.Moment(2);
        }

        [Test]
        public void ArraySegment_Moment_2_Test()
        {
            //====================================================================================================
            //  Arrange
            //  reading data from files

            sw = Stopwatch.StartNew();

            //----------------------------------------------------------------------------------------------------
            // Act
            //      extracted to atomic Benchmark method
            double moment = ArraySegment_Moment_2();

            sw.Stop();
            Console.WriteLine($"          moment               = {moment}");
            Console.WriteLine($"          size               = {data.Count()}");
            Console.WriteLine($"          elapsed[ticks]     = {sw.ElapsedTicks}");
            Console.WriteLine($"          elapsed[ms]        = {sw.Elapsed.TotalMilliseconds}");
            sw.Reset();
            double variance = data_array.VariancePopulation();
            //----------------------------------------------------------------------------------------------------
            // Assert
            #if NUNIT
            Assert.AreEqual(1.2, moment, 0.01);
            Assert.AreEqual(1.2, variance, 0.01);
            #elif XUNIT
            Assert.Equal(1.2, moment, 5);
            Assert.Equal(1.2, variance, 5);
            #elif MSTEST
            Assert.AreEqual(1.2, moment, 0.01);
            Assert.AreEqual(1.2, variance, 5);
            #endif
            //====================================================================================================

            return;
        }

        [Benchmark]
        public double List_Moment_2()
        {
            return data_list.Moment(2);
        }

        [Test]
        public void List_Moment_2_Test()
        {
            //====================================================================================================
            //  Arrange
            //  reading data from files

            sw = Stopwatch.StartNew();

            //----------------------------------------------------------------------------------------------------
            // Act
            //      extracted to atomic Benchmark method
            double moment = List_Moment_2();

            Console.WriteLine($"          moment               = {moment}");
            Console.WriteLine($"          size               = {data.Count()}");
            Console.WriteLine($"          elapsed[ticks]     = {sw.ElapsedTicks}");
            Console.WriteLine($"          elapsed[ms]        = {sw.Elapsed.TotalMilliseconds}");
            sw.Reset();
            double variance = data_array.VariancePopulation();
            //----------------------------------------------------------------------------------------------------
            // Assert
            #if NUNIT
            Assert.AreEqual(1.2, moment, 0.01);
            Assert.AreEqual(1.2, variance, 0.01);
            #elif XUNIT
            Assert.Equal(1.2, moment, 5);
            Assert.Equal(1.2, variance, 5);
            #elif MSTEST
            Assert.AreEqual(1.2, moment, 0.01);
            Assert.AreEqual(1.2, variance, 5);
            #endif
            //====================================================================================================

            return;
        }

        [Benchmark]
        public double Queue_Moment_2()
        {
            return data_queue.Moment(2);
        }

        [Test]
        public void Queue_Moment_2_Test()
        {
            //====================================================================================================
            //  Arrange

            sw = Stopwatch.StartNew();

            //----------------------------------------------------------------------------------------------------
            // Act
            //      extracted to atomic Benchmark method
            double moment = Queue_Moment_2();

            sw.Stop();
            Console.WriteLine($"          moment               = {moment}");
            Console.WriteLine($"          size               = {data.Count()}");
            Console.WriteLine($"          elapsed[ticks]     = {sw.ElapsedTicks}");
            Console.WriteLine($"          elapsed[ms]        = {sw.Elapsed.TotalMilliseconds}");
            sw.Reset();
            double variance = data_array.VariancePopulation();
            //----------------------------------------------------------------------------------------------------
            // Assert
            #if NUNIT
            Assert.AreEqual(1.2, moment, 0.01);
            Assert.AreEqual(1.2, variance, 0.01);
            #elif XUNIT
            Assert.Equal(1.2, moment, 5);
            Assert.Equal(1.2, variance, 5);
            #elif MSTEST
            Assert.AreEqual(1.2, moment, 0.01);
            Assert.AreEqual(1.2, variance, 5);
            #endif
            //====================================================================================================

            return;
        }

        [Benchmark]
        public double Stack_Moment_2()
        {
            return data_stack.Moment(2);
        }

        [Test]
        public void Stack_Moment_2_Test()
        {
            //====================================================================================================
            //  Arrange
            //  reading data from files

            sw = Stopwatch.StartNew();

            //----------------------------------------------------------------------------------------------------
            // Act
            //      extracted to atomic Benchmark method
            double moment = Stack_Moment_2();

            sw.Stop();
            Console.WriteLine($"          moment               = {moment}");
            Console.WriteLine($"          size               = {data.Count()}");
            Console.WriteLine($"          elapsed[ticks]     = {sw.ElapsedTicks}");
            Console.WriteLine($"          elapsed[ms]        = {sw.Elapsed.TotalMilliseconds}");
            sw.Reset();
            double variance = data_array.VariancePopulation();
            //----------------------------------------------------------------------------------------------------
            // Assert
            #if NUNIT
            Assert.AreEqual(1.2, moment, 0.01);
            Assert.AreEqual(1.2, variance, 0.01);
            #elif XUNIT
            Assert.Equal(1.2, moment, 5);
            Assert.Equal(1.2, variance, 5);
            #elif MSTEST
            Assert.AreEqual(1.2, moment, 0.01);
            Assert.AreEqual(1.2, variance, 5);
            #endif
            //====================================================================================================

            return;
        }

        [Benchmark]
        public double LinkedList_Moment_2()
        {
            return data_linked_list.Moment(2);
        }

        [Test]
        public void LinkedList_Moment_2_Test()
        {
            //====================================================================================================
            //  Arrange
            //  reading data from files

            sw = Stopwatch.StartNew();

            //----------------------------------------------------------------------------------------------------
            // Act
            //      extracted to atomic Benchmark method
            double moment = LinkedList_Moment_2();

            sw.Stop();
            Console.WriteLine($"          moment               = {moment}");
            Console.WriteLine($"          size               = {data.Count()}");
            Console.WriteLine($"          elapsed[ticks]     = {sw.ElapsedTicks}");
            Console.WriteLine($"          elapsed[ms]        = {sw.Elapsed.TotalMilliseconds}");
            sw.Reset();
            double variance = data_array.VariancePopulation();
            //----------------------------------------------------------------------------------------------------
            // Assert
            #if NUNIT
            Assert.AreEqual(1.2, moment, 0.01);
            Assert.AreEqual(1.2, variance, 0.01);
            #elif XUNIT
            Assert.Equal(1.2, moment, 5);
            Assert.Equal(1.2, variance, 5);
            #elif MSTEST
            Assert.AreEqual(1.2, moment, 0.01);
            Assert.AreEqual(1.2, variance, 5);
            #endif
            //====================================================================================================

            return;
        }

        [Benchmark]
        public double ObservableCollection_Moment_2()
        {
            return data_observable_collection.Moment(2);
        }

        [Test]
        public void ObservableCollection_Moment_2_Test()
        {
            //====================================================================================================
            //  Arrange
            //  reading data from files

            sw = Stopwatch.StartNew();

            //----------------------------------------------------------------------------------------------------
            // Act
            //      extracted to atomic Benchmark method
            double moment = ObservableCollection_Moment_2();

            sw.Stop();
            Console.WriteLine($"          moment               = {moment}");
            Console.WriteLine($"          size               = {data.Count()}");
            Console.WriteLine($"          elapsed[ticks]     = {sw.ElapsedTicks}");
            Console.WriteLine($"          elapsed[ms]        = {sw.Elapsed.TotalMilliseconds}");
            sw.Reset();
            double variance = data_array.VariancePopulation();
            //----------------------------------------------------------------------------------------------------
            // Assert
            #if NUNIT
            Assert.AreEqual(1.2, moment, 0.01);
            Assert.AreEqual(1.2, variance, 0.01);
            #elif XUNIT
            Assert.Equal(1.2, moment, 5);
            Assert.Equal(1.2, variance, 5);
            #elif MSTEST
            Assert.AreEqual(1.2, moment, 0.01);
            Assert.AreEqual(1.2, variance, 5);
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
        public void Span_Moment_2()
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
            double moment = dataMoment(2);
            sw.Stop();
            Console.WriteLine($"          moment               = {moment}");
            Console.WriteLine($"          size               = {data.Count()}");
            Console.WriteLine($"          elapsed[ticks]     = {sw.ElapsedTicks}");
            Console.WriteLine($"          elapsed[ms]        = {sw.Elapsed.TotalMilliseconds}");
            sw.Reset();
            //----------------------------------------------------------------------------------------------------
            // Assert
            #if NUNIT
            Assert.AreEqual(1.2, moment, 0.01);
            #elif XUNIT
            Assert.Equal(1.2, moment, 5);
            #elif MSTEST
            Assert.AreEqual(1.2, moment, 0.01);
            #endif
            //====================================================================================================

            return;
        }

        [Test]
        public void Span_Moment_2()
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
            double moment = dataMoment(2);
            sw.Stop();
            Console.WriteLine($"          moment               = {moment}");
            Console.WriteLine($"          size               = {data.Count()}");
            Console.WriteLine($"          elapsed[ticks]     = {sw.ElapsedTicks}");
            Console.WriteLine($"          elapsed[ms]        = {sw.Elapsed.TotalMilliseconds}");
            sw.Reset();
            //----------------------------------------------------------------------------------------------------
            // Assert
            #if NUNIT
            Assert.AreEqual(1.2, moment, 0.01);
            #elif XUNIT
            Assert.Equal(1.2, moment, 5);
            #elif MSTEST
            Assert.AreEqual(1.2, moment, 0.01);
            #endif
            //====================================================================================================

            return;
        }
        */
    }
}
