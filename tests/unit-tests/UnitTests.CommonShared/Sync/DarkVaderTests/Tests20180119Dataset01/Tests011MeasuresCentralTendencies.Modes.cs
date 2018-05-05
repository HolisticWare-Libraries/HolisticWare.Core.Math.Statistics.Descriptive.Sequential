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
using Fact=NUnit.Framework.TestAttribute;
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
    public partial class Tests20180119Dataset01
    {
        [Benchmark]
        public List<int> Array_Modes()
        {
            return data_array.Modes();
        }

        [Test]
        public void Array_Modes_Test()
        {
            Console.WriteLine($"Array_Modes_Test");
            //====================================================================================================
            //  Arrange
            //  reading data from files

            sw = Stopwatch.StartNew();

            //----------------------------------------------------------------------------------------------------
            // Act
            //      extracted to atomic Benchmark method
            List<int> modes = Array_Modes();

            sw.Stop();
            Console.WriteLine($"Array<double>.Modes()");
            Console.WriteLine($"          mean               = {modes}");
            Console.WriteLine($"          size               = {data_array.Count()}");
            Console.WriteLine($"          elapsed[ticks]     = {sw.ElapsedTicks}");
            Console.WriteLine($"          elapsed[ms]        = {sw.Elapsed.TotalMilliseconds}");
            sw.Reset();
            //----------------------------------------------------------------------------------------------------
            // Assert
            #if NUNIT
            Assert.AreEqual
                        (
                            new List<int> { 3 },
                            modes
                        );
            #elif XUNIT
            Assert.Equal
                        (
                            new List<int> { 3 },
                            modes
                        );
            #elif MSTEST
            CollectionAssert.AreEqual
                        (
                            new List<int> { 3 },
                            modes
                        );
            #endif
            //====================================================================================================

            return;
        }

        [Benchmark]
        public List<int> ArraySegment_Modes()
        {
            return data_array_segment.Modes();
        }

        [Test]
        public void ArraySegment_Modes_Test()
        {
            //====================================================================================================
            //  Arrange
            //  reading data from files

            sw = Stopwatch.StartNew();

            //----------------------------------------------------------------------------------------------------
            // Act
            //      extracted to atomic Benchmark method
            List<int> modes = ArraySegment_Modes();

            sw.Stop();
            Console.WriteLine($"          mean               = {modes}");
            Console.WriteLine($"          size               = {data.Count()}");
            Console.WriteLine($"          elapsed[ticks]     = {sw.ElapsedTicks}");
            Console.WriteLine($"          elapsed[ms]        = {sw.Elapsed.TotalMilliseconds}");
            sw.Reset();
            //----------------------------------------------------------------------------------------------------
            // Assert
            #if NUNIT
            Assert.AreEqual
                        (
                            new List<int> { 3 },
                            modes
                        );
            #elif XUNIT
            Assert.Equal
                        (
                            new List<int> { 3 },
                            modes
                        );
            #elif MSTEST
            CollectionAssert.AreEqual
                        (
                            new List<int> { 3 },
                            modes
                        );
            #endif
            //====================================================================================================

            return;
        }

        [Benchmark]
        public List<int> List_Modes()
        {
            return data_list.Modes();
        }

        [Test]
        public void List_Modes_Test()
        {
            //====================================================================================================
            //  Arrange
            //  reading data from files

            sw = Stopwatch.StartNew();

            //----------------------------------------------------------------------------------------------------
            // Act
            //      extracted to atomic Benchmark method
            List<int> modes = List_Modes();

            Console.WriteLine($"          mean               = {modes}");
            Console.WriteLine($"          size               = {data.Count()}");
            Console.WriteLine($"          elapsed[ticks]     = {sw.ElapsedTicks}");
            Console.WriteLine($"          elapsed[ms]        = {sw.Elapsed.TotalMilliseconds}");
            sw.Reset();
            //----------------------------------------------------------------------------------------------------
            // Assert
            #if NUNIT
            Assert.AreEqual
                        (
                            new List<int> { 3 },
                            modes
                        );
            #elif XUNIT
            Assert.Equal
                        (
                            new List<int> { 3 },
                            modes
                        );
            #elif MSTEST
            CollectionAssert.AreEqual
                        (
                            new List<int> { 3 },
                            modes
                        );
            #endif
            //====================================================================================================

            return;
        }

        [Benchmark]
        public List<int> Queue_Modes()
        {
            return data_queue.Modes();
        }

        [Test]
        public void Queue_Modes_Test()
        {
            //====================================================================================================
            //  Arrange

            sw = Stopwatch.StartNew();

            //----------------------------------------------------------------------------------------------------
            // Act
            //      extracted to atomic Benchmark method
            List<int> modes = Queue_Modes();

            sw.Stop();
            Console.WriteLine($"          mean               = {modes}");
            Console.WriteLine($"          size               = {data.Count()}");
            Console.WriteLine($"          elapsed[ticks]     = {sw.ElapsedTicks}");
            Console.WriteLine($"          elapsed[ms]        = {sw.Elapsed.TotalMilliseconds}");
            sw.Reset();
            //----------------------------------------------------------------------------------------------------
            // Assert
            #if NUNIT
            Assert.AreEqual
                        (
                            new List<int> { 3 },
                            modes
                        );
            #elif XUNIT
            Assert.Equal
                        (
                            new List<int> { 3 },
                            modes
                        );
            #elif MSTEST
            CollectionAssert.AreEqual
                        (
                            new List<int> { 3 },
                            modes
                        );
            #endif
            //====================================================================================================

            return;
        }

        [Benchmark]
        public List<int> Stack_Modes()
        {
            return data_stack.Modes();
        }

        [Test]
        public void Stack_Modes_Test()
        {
            //====================================================================================================
            //  Arrange
            //  reading data from files

            sw = Stopwatch.StartNew();

            //----------------------------------------------------------------------------------------------------
            // Act
            //      extracted to atomic Benchmark method
            List<int> modes = Stack_Modes();

            sw.Stop();
            Console.WriteLine($"          mean               = {modes}");
            Console.WriteLine($"          size               = {data.Count()}");
            Console.WriteLine($"          elapsed[ticks]     = {sw.ElapsedTicks}");
            Console.WriteLine($"          elapsed[ms]        = {sw.Elapsed.TotalMilliseconds}");
            sw.Reset();
            //----------------------------------------------------------------------------------------------------
            // Assert
            #if NUNIT
            Assert.AreEqual
                        (
                            new List<int> { 3 },
                            modes
                        );
            #elif XUNIT
            Assert.Equal
                        (
                            new List<int> { 3 },
                            modes
                        );
            #elif MSTEST
            CollectionAssert.AreEqual
                        (
                            new List<int> { 3 },
                            modes
                        );
            #endif
            //====================================================================================================

            return;
        }

        [Benchmark]
        public List<int> LinkedList_Modes()
        {
            return data_linked_list.Modes();
        }

        [Test]
        public void LinkedList_Modes_Test()
        {
            //====================================================================================================
            //  Arrange
            //  reading data from files

            sw = Stopwatch.StartNew();

            //----------------------------------------------------------------------------------------------------
            // Act
            //      extracted to atomic Benchmark method
            List<int> modes = LinkedList_Modes();

            sw.Stop();
            Console.WriteLine($"          mean               = {modes}");
            Console.WriteLine($"          size               = {data.Count()}");
            Console.WriteLine($"          elapsed[ticks]     = {sw.ElapsedTicks}");
            Console.WriteLine($"          elapsed[ms]        = {sw.Elapsed.TotalMilliseconds}");
            sw.Reset();
            //----------------------------------------------------------------------------------------------------
            // Assert
            #if NUNIT
            Assert.AreEqual
                        (
                            new List<int> { 3 },
                            modes
                        );
            #elif XUNIT
            Assert.Equal
                        (
                            new List<int> { 3 },
                            modes
                        );
            #elif MSTEST
            CollectionAssert.AreEqual
                        (
                            new List<int> { 3 },
                            modes
                        );
            #endif
            //====================================================================================================

            return;
        }

        [Benchmark]
        public List<int> ObservableCollection_Modes()
        {
            return data_observable_collection.Modes();
        }

        [Test]
        public void ObservableCollection_Modes_Test()
        {
            //====================================================================================================
            //  Arrange
            //  reading data from files

            sw = Stopwatch.StartNew();

            //----------------------------------------------------------------------------------------------------
            // Act
            //      extracted to atomic Benchmark method
            List<int> modes = ObservableCollection_Modes();

            sw.Stop();
            Console.WriteLine($"          mean               = {modes}");
            Console.WriteLine($"          size               = {data.Count()}");
            Console.WriteLine($"          elapsed[ticks]     = {sw.ElapsedTicks}");
            Console.WriteLine($"          elapsed[ms]        = {sw.Elapsed.TotalMilliseconds}");
            sw.Reset();
            //----------------------------------------------------------------------------------------------------
            // Assert
            #if NUNIT
            Assert.AreEqual
                        (
                            new List<int> { 3 },
                            modes
                        );
            #elif XUNIT
            Assert.Equal
                        (
                            new List<int> { 3 },
                            modes
                        );
            #elif MSTEST
            CollectionAssert.AreEqual
                        (
                            new List<int> { 3 },
                            modes
                        );
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
        public void Span_Modes()
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
            double mean = data.Modes();
            sw.Stop();
            Console.WriteLine($"          mean               = {modes}");
            Console.WriteLine($"          size               = {data.Count()}");
            Console.WriteLine($"          elapsed[ticks]     = {sw.ElapsedTicks}");
            Console.WriteLine($"          elapsed[ms]        = {sw.Elapsed.TotalMilliseconds}");
            sw.Reset();
            //----------------------------------------------------------------------------------------------------
            // Assert
            #if NUNIT
            Assert.AreEqual(3.00, mean, 0.00001);
            #elif XUNIT
            Assert.Equal(3.00, mean, 5);
            #elif MSTEST
            Assert.AreEqual(3.00, mean, 0.00001);
            #endif
            //====================================================================================================

            return;
        }

        [Test]
        public void Span_Modes()
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
            double mean = data.Modes();
            sw.Stop();
            Console.WriteLine($"          mean               = {modes}");
            Console.WriteLine($"          size               = {data.Count()}");
            Console.WriteLine($"          elapsed[ticks]     = {sw.ElapsedTicks}");
            Console.WriteLine($"          elapsed[ms]        = {sw.Elapsed.TotalMilliseconds}");
            sw.Reset();
            //----------------------------------------------------------------------------------------------------
            // Assert
            #if NUNIT
            Assert.AreEqual(3.00, mean, 0.00001);
            #elif XUNIT
            Assert.Equal(3.00, mean, 5);
            #elif MSTEST
            Assert.AreEqual(3.00, mean, 0.00001);
            #endif
            //====================================================================================================

            return;
        }
        */
    }
}
