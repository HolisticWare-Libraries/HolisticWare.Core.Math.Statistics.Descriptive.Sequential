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
using Benchmark = HolisticWare.Core.Testing.BenchmarkTests.Benchmark;
using ShortRunJob = HolisticWare.Core.Testing.BenchmarkTests.ShortRunJob;
#endif

using System;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;
using System.Collections.ObjectModel;
using Core.Math.Statistics.Descriptive;

namespace UnitTests.Core.Math.Statistics.Descriptive.Sequential.Sync
{
    public partial class Tests20180119Dataset01
    {
        [Benchmark]
        public double Array_MeanCubic()
        {
            return data_array.MeanCubic();
        }

        [Test]
        public void Array_MeanCubic_Test()
        {
            Console.WriteLine($"Array_MeanCubic_Test");
            //====================================================================================================
            //  Arrange
            //  reading data from files

            sw = Stopwatch.StartNew();

            //----------------------------------------------------------------------------------------------------
            // Act
            //      extracted to atomic Benchmark method
            double mean = Array_MeanCubic();

            sw.Stop();
            Console.WriteLine($"Array<double>.MeanCubic()");
            Console.WriteLine($"          mean               = {mean}");
            Console.WriteLine($"          size               = {data_array.Count()}");
            Console.WriteLine($"          elapsed[ticks]     = {sw.ElapsedTicks}");
            Console.WriteLine($"          elapsed[ms]        = {sw.Elapsed.TotalMilliseconds}");
            sw.Reset();
            //----------------------------------------------------------------------------------------------------
            // Assert
            #if NUNIT
            Assert.AreEqual(3.35607, mean, 0.001);
            #elif XUNIT
            Assert.Equal(3.35607, mean, 3);
            #elif MSTEST
            Assert.AreEqual(3.35607, mean, 0.001);
            #endif
            //====================================================================================================

            return;
        }

        [Benchmark]
        public double ArraySegment_MeanCubic()
        {
            return data_array_segment.MeanCubic();
        }

        [Test]
        public void ArraySegment_MeanCubic_Test()
        {
            //====================================================================================================
            //  Arrange
            //  reading data from files

            sw = Stopwatch.StartNew();

            //----------------------------------------------------------------------------------------------------
            // Act
            //      extracted to atomic Benchmark method
            double mean = ArraySegment_MeanCubic();

            sw.Stop();
            Console.WriteLine($"          mean               = {mean}");
            Console.WriteLine($"          size               = {data.Count()}");
            Console.WriteLine($"          elapsed[ticks]     = {sw.ElapsedTicks}");
            Console.WriteLine($"          elapsed[ms]        = {sw.Elapsed.TotalMilliseconds}");
            sw.Reset();
            //----------------------------------------------------------------------------------------------------
            // Assert
            #if NUNIT
            Assert.AreEqual(3.35607, mean, 0.001);
            #elif XUNIT
            Assert.Equal(3.35607, mean, 3);
            #elif MSTEST
            Assert.AreEqual(3.35607, mean, 0.001);
            #endif
            //====================================================================================================

            return;
        }

        [Benchmark]
        public double List_MeanCubic()
        {
            return data_list.MeanCubic();
        }

        [Test]
        public void List_MeanCubic_Test()
        {
            //====================================================================================================
            //  Arrange
            //  reading data from files

            sw = Stopwatch.StartNew();

            //----------------------------------------------------------------------------------------------------
            // Act
            //      extracted to atomic Benchmark method
            double mean = List_MeanCubic();

            Console.WriteLine($"          mean               = {mean}");
            Console.WriteLine($"          size               = {data.Count()}");
            Console.WriteLine($"          elapsed[ticks]     = {sw.ElapsedTicks}");
            Console.WriteLine($"          elapsed[ms]        = {sw.Elapsed.TotalMilliseconds}");
            sw.Reset();
            //----------------------------------------------------------------------------------------------------
            // Assert
            #if NUNIT
            Assert.AreEqual(3.35607, mean, 0.001);
            #elif XUNIT
            Assert.Equal(3.35607, mean, 3);
            #elif MSTEST
            Assert.AreEqual(3.35607, mean, 0.001);
            #endif
            //====================================================================================================

            return;
        }

        [Benchmark]
        public double Queue_MeanCubic()
        {
            return data_queue.MeanCubic();
        }

        [Test]
        public void Queue_MeanCubic_Test()
        {
            //====================================================================================================
            //  Arrange

            sw = Stopwatch.StartNew();

            //----------------------------------------------------------------------------------------------------
            // Act
            //      extracted to atomic Benchmark method
            double mean = Queue_MeanCubic();

            sw.Stop();
            Console.WriteLine($"          mean               = {mean}");
            Console.WriteLine($"          size               = {data.Count()}");
            Console.WriteLine($"          elapsed[ticks]     = {sw.ElapsedTicks}");
            Console.WriteLine($"          elapsed[ms]        = {sw.Elapsed.TotalMilliseconds}");
            sw.Reset();
            //----------------------------------------------------------------------------------------------------
            // Assert
            #if NUNIT
            Assert.AreEqual(3.35607, mean, 0.001);
            #elif XUNIT
            Assert.Equal(3.35607, mean, 3);
            #elif MSTEST
            Assert.AreEqual(3.35607, mean, 0.001);
            #endif
            //====================================================================================================

            return;
        }

        [Benchmark]
        public double Stack_MeanCubic()
        {
            return data_stack.MeanCubic();
        }

        [Test]
        public void Stack_MeanCubic_Test()
        {
            //====================================================================================================
            //  Arrange
            //  reading data from files

            sw = Stopwatch.StartNew();

            //----------------------------------------------------------------------------------------------------
            // Act
            //      extracted to atomic Benchmark method
            double mean = Stack_MeanCubic();

            sw.Stop();
            Console.WriteLine($"          mean               = {mean}");
            Console.WriteLine($"          size               = {data.Count()}");
            Console.WriteLine($"          elapsed[ticks]     = {sw.ElapsedTicks}");
            Console.WriteLine($"          elapsed[ms]        = {sw.Elapsed.TotalMilliseconds}");
            sw.Reset();
            //----------------------------------------------------------------------------------------------------
            // Assert
            #if NUNIT
            Assert.AreEqual(3.35607, mean, 0.001);
            #elif XUNIT
            Assert.Equal(3.35607, mean, 3);
            #elif MSTEST
            Assert.AreEqual(3.35607, mean, 0.001);
            #endif
            //====================================================================================================

            return;
        }

        [Benchmark]
        public double LinkedList_MeanCubic()
        {
            return data_linked_list.MeanCubic();
        }

        [Test]
        public void LinkedList_MeanCubic_Test()
        {
            //====================================================================================================
            //  Arrange
            //  reading data from files

            sw = Stopwatch.StartNew();

            //----------------------------------------------------------------------------------------------------
            // Act
            //      extracted to atomic Benchmark method
            double mean = LinkedList_MeanCubic();

            sw.Stop();
            Console.WriteLine($"          mean               = {mean}");
            Console.WriteLine($"          size               = {data.Count()}");
            Console.WriteLine($"          elapsed[ticks]     = {sw.ElapsedTicks}");
            Console.WriteLine($"          elapsed[ms]        = {sw.Elapsed.TotalMilliseconds}");
            sw.Reset();
            //----------------------------------------------------------------------------------------------------
            // Assert
            #if NUNIT
            Assert.AreEqual(3.35607, mean, 0.001);
            #elif XUNIT
            Assert.Equal(3.35607, mean, 3);
            #elif MSTEST
            Assert.AreEqual(3.35607, mean, 0.001);
            #endif
            //====================================================================================================

            return;
        }

        [Benchmark]
        public double ObservableCollection_MeanCubic()
        {
            return data_observable_collection.MeanCubic();
        }

        [Test]
        public void ObservableCollection_MeanCubic_Test()
        {
            //====================================================================================================
            //  Arrange
            //  reading data from files

            sw = Stopwatch.StartNew();

            //----------------------------------------------------------------------------------------------------
            // Act
            //      extracted to atomic Benchmark method
            double mean = ObservableCollection_MeanCubic();

            sw.Stop();
            Console.WriteLine($"          mean               = {mean}");
            Console.WriteLine($"          size               = {data.Count()}");
            Console.WriteLine($"          elapsed[ticks]     = {sw.ElapsedTicks}");
            Console.WriteLine($"          elapsed[ms]        = {sw.Elapsed.TotalMilliseconds}");
            sw.Reset();
            //----------------------------------------------------------------------------------------------------
            // Assert
            #if NUNIT
            Assert.AreEqual(3.35607, mean, 0.001);
            #elif XUNIT
            Assert.Equal(3.35607, mean, 3);
            #elif MSTEST
            Assert.AreEqual(3.35607, mean, 0.001);
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
        #if !__ANDROID__ && !__IOS__
        /*
        Error CS0122: 'Span<T>' is inaccessible due to its protection level (CS0122) (UnitTests.NUnit.XamarinAndroid)
        Error CS0122: 'Span<T>' is inaccessible due to its protection level (CS0122) (UnitTests.NUnit.XamarinIOS)
        Error CS0122: 'Memory<T>' is inaccessible due to its protection level (CS0122) (UnitTests.NUnit.XamarinAndroid)
        Error CS0122: 'Memory<T>' is inaccessible due to its protection level (CS0122) (UnitTests.NUnit.XamarinIOS)
        */
        [Test]
        public void Span_MeanCubic()
        {
            //====================================================================================================
            //  Arrange
            //  reading data from files

            sw = Stopwatch.StartNew();

            //----------------------------------------------------------------------------------------------------
            // Act
            Span<int> d = 
                            new Span<int>(data);
                            //data01.AsSpan().Slice(start: 0)
                            ;
            double mean = data.MeanCubic();
            sw.Stop();
            Console.WriteLine($"          mean               = {mean}");
            Console.WriteLine($"          size               = {data.Count()}");
            Console.WriteLine($"          elapsed[ticks]     = {sw.ElapsedTicks}");
            Console.WriteLine($"          elapsed[ms]        = {sw.Elapsed.TotalMilliseconds}");
            sw.Reset();
            //----------------------------------------------------------------------------------------------------
            // Assert
            #if NUNIT
            Assert.AreEqual(3.35607, mean, 0.001);
            #elif XUNIT
            Assert.Equal(3.35607, mean, 3);
            #elif MSTEST
            Assert.AreEqual(3.35607, mean, 0.001);
            #endif
            //====================================================================================================

            return;
        }

        [Test]
        public void Memory_MeanCubic()
        {
            //====================================================================================================
            //  Arrange
            //  reading data from files

            sw = Stopwatch.StartNew();

            //----------------------------------------------------------------------------------------------------
            // Act
            Memory<int> d =
                            new Memory<int>(data);
                            //data01.AsSpan().Slice(start: 0)
                            ;
            double mean = data.MeanCubic();
            sw.Stop();
            Console.WriteLine($"          mean               = {mean}");
            Console.WriteLine($"          size               = {data.Count()}");
            Console.WriteLine($"          elapsed[ticks]     = {sw.ElapsedTicks}");
            Console.WriteLine($"          elapsed[ms]        = {sw.Elapsed.TotalMilliseconds}");
            sw.Reset();
            //----------------------------------------------------------------------------------------------------
            // Assert
            #if NUNIT
            Assert.AreEqual(3.35607, mean, 0.001);
            #elif XUNIT
            Assert.Equal(3.35607, mean, 3);
            #elif MSTEST
            Assert.AreEqual(3.35607, mean, 0.001);
            #endif
            //====================================================================================================

            return;
        }
        #endif
    }
}
