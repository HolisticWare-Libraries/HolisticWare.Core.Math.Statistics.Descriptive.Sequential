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
using BenchmarkDotNet.Attributes;

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
using Fact = NUnit.Framework.TestAttribute;
#elif MSTEST
using Microsoft.VisualStudio.TestTools.UnitTesting;
// NUnit aliases
using Test = Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute;
using OneTimeSetUp = Microsoft.VisualStudio.TestTools.UnitTesting.ClassInitializeAttribute;
// XUnit aliases
using Fact = Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute;
#endif

using System;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;
using System.Collections.ObjectModel;

using Core.Math.Statistics.Descriptive.Sequential;

namespace UnitTests.Core.Math.Statistics.Descriptive.Sequential.Sync
{
    public partial class Tests20180119Dataset03
    {
        [Benchmark]
        public (double min, double max) Array_Range()
        {
            return data_array.Range();
        }

        [Test]
        public void Array_Range_Test()
        {
            Console.WriteLine($"Array_Range_Test");
            //====================================================================================================
            //  Arrange
            //  reading data from files

            sw = Stopwatch.StartNew();

            //----------------------------------------------------------------------------------------------------
            // Act
            //      extracted to atomic Benchmark method
            (double min, double max) range = Array_Range();

            sw.Stop();
            Console.WriteLine($"Array<double>.Range()");
            Console.WriteLine($"          range              = {range}");
            Console.WriteLine($"          size               = {data_array.Count()}");
            Console.WriteLine($"          elapsed[ticks]     = {sw.ElapsedTicks}");
            Console.WriteLine($"          elapsed[ms]        = {sw.Elapsed.TotalMilliseconds}");
            sw.Reset();
            //----------------------------------------------------------------------------------------------------
            // Assert
            #if NUNIT
            Assert.AreEqual(135.0, range.min, 0.00001);
            Assert.AreEqual(210.0, range.max, 0.00001);
            #elif XUNIT
            Assert.Equal(135.0, range.max, 5);
            Assert.Equal(210.0, range.min, 5);
            #elif MSTEST
            Assert.AreEqual(135.0, range.max, 0.00001);
            Assert.AreEqual(210.0, range.min, 0.00001);
            #endif
            //====================================================================================================

            return;
        }

        [Benchmark]
        public (double min, double max) ArraySegment_Range()
        {
            return data_array_segment.Range();
        }

        [Test]
        public void ArraySegment_Range_Test()
        {
            //====================================================================================================
            //  Arrange
            //  reading data from files

            sw = Stopwatch.StartNew();

            //----------------------------------------------------------------------------------------------------
            // Act
            //      extracted to atomic Benchmark method
            (double min, double max) range = ArraySegment_Range();

            sw.Stop();
            Console.WriteLine($"          range              = {range}");
            Console.WriteLine($"          size               = {data.Count()}");
            Console.WriteLine($"          elapsed[ticks]     = {sw.ElapsedTicks}");
            Console.WriteLine($"          elapsed[ms]        = {sw.Elapsed.TotalMilliseconds}");
            sw.Reset();
            //----------------------------------------------------------------------------------------------------
            // Assert
            #if NUNIT
            Assert.AreEqual(135.0, range.min, 0.00001);
            Assert.AreEqual(210.0, range.max, 0.00001);
            #elif XUNIT
            Assert.Equal(135.0, range.max, 5);
            Assert.Equal(210.0, range.min, 5);
            #elif MSTEST
            Assert.AreEqual(135.0, range.max, 0.00001);
            Assert.AreEqual(210.0, range.min, 0.00001);
            #endif
            //====================================================================================================

            return;
        }

        [Benchmark]
        public (double min, double max) List_Range()
        {
            return data_list.Range();
        }

        [Test]
        public void List_Range_Test()
        {
            //====================================================================================================
            //  Arrange
            //  reading data from files

            sw = Stopwatch.StartNew();

            //----------------------------------------------------------------------------------------------------
            // Act
            //      extracted to atomic Benchmark method
            (double min, double max) range = List_Range();

            Console.WriteLine($"          range              = {range}");
            Console.WriteLine($"          size               = {data.Count()}");
            Console.WriteLine($"          elapsed[ticks]     = {sw.ElapsedTicks}");
            Console.WriteLine($"          elapsed[ms]        = {sw.Elapsed.TotalMilliseconds}");
            sw.Reset();
            //----------------------------------------------------------------------------------------------------
            // Assert
            #if NUNIT
            Assert.AreEqual(135.0, range.min, 0.00001);
            Assert.AreEqual(210.0, range.max, 0.00001);
            #elif XUNIT
            Assert.Equal(135.0, range.max, 5);
            Assert.Equal(210.0, range.min, 5);
            #elif MSTEST
            Assert.AreEqual(135.0, range.max, 0.00001);
            Assert.AreEqual(210.0, range.min, 0.00001);
            #endif
            //====================================================================================================

            return;
        }

        [Benchmark]
        public (double min, double max) Queue_Range()
        {
            return data_queue.Range();
        }

        [Test]
        public void Queue_Range_Test()
        {
            //====================================================================================================
            //  Arrange

            sw = Stopwatch.StartNew();

            //----------------------------------------------------------------------------------------------------
            // Act
            //      extracted to atomic Benchmark method
            (double min, double max) range = Queue_Range();

            sw.Stop();
            Console.WriteLine($"          range              = {range}");
            Console.WriteLine($"          size               = {data.Count()}");
            Console.WriteLine($"          elapsed[ticks]     = {sw.ElapsedTicks}");
            Console.WriteLine($"          elapsed[ms]        = {sw.Elapsed.TotalMilliseconds}");
            sw.Reset();
            //----------------------------------------------------------------------------------------------------
            // Assert
            #if NUNIT
            Assert.AreEqual(135.0, range.min, 0.00001);
            Assert.AreEqual(210.0, range.max, 0.00001);
            #elif XUNIT
            Assert.Equal(135.0, range.max, 5);
            Assert.Equal(210.0, range.min, 5);
            #elif MSTEST
            Assert.AreEqual(135.0, range.max, 0.00001);
            Assert.AreEqual(210.0, range.min, 0.00001);
            #endif
            //====================================================================================================

            return;
        }

        [Benchmark]
        public (double min, double max) Stack_Range()
        {
            return data_stack.Range();
        }

        [Test]
        public void Stack_Range_Test()
        {
            //====================================================================================================
            //  Arrange
            //  reading data from files

            sw = Stopwatch.StartNew();

            //----------------------------------------------------------------------------------------------------
            // Act
            //      extracted to atomic Benchmark method
            (double min, double max) range = Stack_Range();

            sw.Stop();
            Console.WriteLine($"          range              = {range}");
            Console.WriteLine($"          size               = {data.Count()}");
            Console.WriteLine($"          elapsed[ticks]     = {sw.ElapsedTicks}");
            Console.WriteLine($"          elapsed[ms]        = {sw.Elapsed.TotalMilliseconds}");
            sw.Reset();
            //----------------------------------------------------------------------------------------------------
            // Assert
            #if NUNIT
            Assert.AreEqual(135.0, range.min, 0.00001);
            Assert.AreEqual(210.0, range.max, 0.00001);
            #elif XUNIT
            Assert.Equal(135.0, range.max, 5);
            Assert.Equal(210.0, range.min, 5);
            #elif MSTEST
            Assert.AreEqual(135.0, range.max, 0.00001);
            Assert.AreEqual(210.0, range.min, 0.00001);
            #endif
            //====================================================================================================

            return;
        }

        [Benchmark]
        public (double min, double max) LinkedList_Range()
        {
            return data_linked_list.Range();
        }

        [Test]
        public void LinkedList_Range_Test()
        {
            //====================================================================================================
            //  Arrange
            //  reading data from files

            sw = Stopwatch.StartNew();

            //----------------------------------------------------------------------------------------------------
            // Act
            //      extracted to atomic Benchmark method
            (double min, double max) range = LinkedList_Range();

            sw.Stop();
            Console.WriteLine($"          range              = {range}");
            Console.WriteLine($"          size               = {data.Count()}");
            Console.WriteLine($"          elapsed[ticks]     = {sw.ElapsedTicks}");
            Console.WriteLine($"          elapsed[ms]        = {sw.Elapsed.TotalMilliseconds}");
            sw.Reset();
            //----------------------------------------------------------------------------------------------------
            // Assert
            #if NUNIT
            Assert.AreEqual(135.0, range.min, 0.00001);
            Assert.AreEqual(210.0, range.max, 0.00001);
            #elif XUNIT
            Assert.Equal(135.0, range.max, 5);
            Assert.Equal(210.0, range.min, 5);
            #elif MSTEST
            Assert.AreEqual(135.0, range.max, 0.00001);
            Assert.AreEqual(210.0, range.min, 0.00001);
            #endif
            //====================================================================================================

            return;
        }

        [Benchmark]
        public (double min, double max) ObservableCollection_Range()
        {
            return data_observable_collection.Range();
        }

        [Test]
        public void ObservableCollection_Range_Test()
        {
            //====================================================================================================
            //  Arrange
            //  reading data from files

            sw = Stopwatch.StartNew();

            //----------------------------------------------------------------------------------------------------
            // Act
            //      extracted to atomic Benchmark method
            (double min, double max) range = ObservableCollection_Range();

            sw.Stop();
            Console.WriteLine($"          range              = {range}");
            Console.WriteLine($"          size               = {data.Count()}");
            Console.WriteLine($"          elapsed[ticks]     = {sw.ElapsedTicks}");
            Console.WriteLine($"          elapsed[ms]        = {sw.Elapsed.TotalMilliseconds}");
            sw.Reset();
            //----------------------------------------------------------------------------------------------------
            // Assert
            #if NUNIT
            Assert.AreEqual(135.0, range.min, 0.00001);
            Assert.AreEqual(210.0, range.max, 0.00001);
            #elif XUNIT
            Assert.Equal(135.0, range.max, 5);
            Assert.Equal(210.0, range.min, 5);
            #elif MSTEST
            Assert.AreEqual(135.0, range.max, 0.00001);
            Assert.AreEqual(210.0, range.min, 0.00001);
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
        public void Span_Range()
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
            double range = data.Range();
            sw.Stop();
            Console.WriteLine($"          range              = {range}");
            Console.WriteLine($"          size               = {data.Count()}");
            Console.WriteLine($"          elapsed[ticks]     = {sw.ElapsedTicks}");
            Console.WriteLine($"          elapsed[ms]        = {sw.Elapsed.TotalMilliseconds}");
            sw.Reset();
            //----------------------------------------------------------------------------------------------------
            // Assert
            #if NUNIT
            Assert.AreEqual(135.0, range, 0.00001);
            #elif XUNIT
            Assert.Equal(135.0, range, 5);
            #elif MSTEST
            Assert.AreEqual(135.0, range, 0.00001);
            #endif
            //====================================================================================================

            return;
        }

        [Test]
        public void Span_Range()
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
            double range = data.Range();
            sw.Stop();
            Console.WriteLine($"          range              = {range}");
            Console.WriteLine($"          size               = {data.Count()}");
            Console.WriteLine($"          elapsed[ticks]     = {sw.ElapsedTicks}");
            Console.WriteLine($"          elapsed[ms]        = {sw.Elapsed.TotalMilliseconds}");
            sw.Reset();
            //----------------------------------------------------------------------------------------------------
            // Assert
            #if NUNIT
            Assert.AreEqual(135.0, range, 0.00001);
            #elif XUNIT
            Assert.Equal(135.0, range, 5);
            #elif MSTEST
            Assert.AreEqual(135.0, range, 0.00001);
            #endif
            //====================================================================================================

            return;
        }
        */
    }
}
