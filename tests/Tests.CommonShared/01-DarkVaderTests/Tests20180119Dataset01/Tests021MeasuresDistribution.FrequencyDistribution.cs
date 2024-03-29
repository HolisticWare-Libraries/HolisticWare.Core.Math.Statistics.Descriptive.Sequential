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
        Dictionary<int, (uint FrequencyAbsolute, double FrequencyRelative, uint FrequencyCumulative)> fcd = 
                    new Dictionary<int, (uint FrequencyAbsolute, double FrequencyRelative, uint FrequencyCumulative)>
                                        {
                                            { 1, ( 1, 0.1, 1 ) },
                                            { 2, ( 2, 0.2, 3 ) },
                                            { 3, ( 4, 0.4, 7 ) },
                                            { 4, ( 2, 0.2, 9 ) },
                                            { 5, ( 1, 0.1, 10 ) },
                                        };

        [Benchmark]
        public 
            IEnumerable<KeyValuePair<int, (uint FrequencyAbsolute, double FrequencyRelative, uint FrequencyCumulative)>> 
                Array_FrequencyDistribution
                    (
                    )
        {
            return data_array.FrequencyDistribution();
        }

        [Test]
        public void Array_FrequencyDistribution_Test()
        {
            Console.WriteLine($"Array_FrequencyDistribution_Test");
            //====================================================================================================
            //  Arrange
            //  reading data from files

            sw = Stopwatch.StartNew();

            //----------------------------------------------------------------------------------------------------
            // Act
            //      extracted to atomic Benchmark method
            IEnumerable<KeyValuePair<int, (uint FrequencyAbsolute, double FrequencyRelative, uint FrequencyCumulative)>> fd;
            fd = Array_FrequencyDistribution();

            sw.Stop();
            Console.WriteLine($"Array<double>.FrequencyDistribution()");
            Console.WriteLine($"          fd               = {fd}");
            Console.WriteLine($"          size               = {data_array.Count()}");
            Console.WriteLine($"          elapsed[ticks]     = {sw.ElapsedTicks}");
            Console.WriteLine($"          elapsed[ms]        = {sw.Elapsed.TotalMilliseconds}");
            sw.Reset();

            //----------------------------------------------------------------------------------------------------
            // Assert
            #if NUNIT && !NUNIT_LITE
            CollectionAssert.AreEquivalent
                        (
                            fcd.ToList(),
                            fd
                        );
            #elif XUNIT
            Assert.Equal
                        (
                            fcd.ToList(),
                            fd
                        );
            #elif MSTEST
            CollectionAssert.AreEquivalent
                        (
                            fcd.ToList(),
                            fd.ToArray()
                        );
            #endif
            //====================================================================================================

            return;
        }

        [Benchmark]
        public 
            IEnumerable<KeyValuePair<int, (uint FrequencyAbsolute, double FrequencyRelative, uint FrequencyCumulative)>> 
                ArraySegment_FrequencyDistribution
                    (
                    )
        {
            return data_array_segment.FrequencyDistribution();
        }

        [Test]
        public void ArraySegment_FrequencyDistribution_Test()
        {
            //====================================================================================================
            //  Arrange
            //  reading data from files

            sw = Stopwatch.StartNew();

            //----------------------------------------------------------------------------------------------------
            // Act
            //      extracted to atomic Benchmark method
            IEnumerable<KeyValuePair<int, (uint FrequencyAbsolute, double FrequencyRelative, uint FrequencyCumulative)>> fd;
            fd = ArraySegment_FrequencyDistribution();

            sw.Stop();
            Console.WriteLine($"          fd               = {fd}");
            Console.WriteLine($"          size               = {data.Count()}");
            Console.WriteLine($"          elapsed[ticks]     = {sw.ElapsedTicks}");
            Console.WriteLine($"          elapsed[ms]        = {sw.Elapsed.TotalMilliseconds}");
            sw.Reset();
            //----------------------------------------------------------------------------------------------------
            // Assert
            #if NUNIT && !NUNIT_LITE
            CollectionAssert.AreEquivalent
                        (
                            fcd.ToList(),
                            fd
                        );
            #elif XUNIT
            Assert.Equal
                        (
                            fcd.ToList(),
                            fd
                        );
            #elif MSTEST
            CollectionAssert.AreEquivalent
                        (
                            fcd.ToList(),
                            fd.ToArray()
                        );
            #endif
            //====================================================================================================

            return;
        }

        [Benchmark]
        public 
            IEnumerable<KeyValuePair<int, (uint FrequencyAbsolute, double FrequencyRelative, uint FrequencyCumulative)>> 
                List_FrequencyDistribution
                    (
                    )
        {
            return data_list.FrequencyDistribution();
        }

        [Test]
        public void List_FrequencyDistribution_Test()
        {
            //====================================================================================================
            //  Arrange
            //  reading data from files

            sw = Stopwatch.StartNew();

            //----------------------------------------------------------------------------------------------------
            // Act
            //      extracted to atomic Benchmark method
            IEnumerable<KeyValuePair<int, (uint FrequencyAbsolute, double FrequencyRelative, uint FrequencyCumulative)>> fd;
            fd = List_FrequencyDistribution();

            Console.WriteLine($"          fd               = {fd}");
            Console.WriteLine($"          size               = {data.Count()}");
            Console.WriteLine($"          elapsed[ticks]     = {sw.ElapsedTicks}");
            Console.WriteLine($"          elapsed[ms]        = {sw.Elapsed.TotalMilliseconds}");
            sw.Reset();
            //----------------------------------------------------------------------------------------------------
            // Assert
            #if NUNIT && !NUNIT_LITE
            CollectionAssert.AreEquivalent
                        (
                            fcd.ToList(),
                            fd
                        );
            #elif XUNIT
            Assert.Equal
                        (
                            fcd.ToList(),
                            fd
                        );
            #elif MSTEST
            CollectionAssert.AreEquivalent
                        (
                            fcd.ToList(),
                            fd.ToArray()
                        );
            #endif
            //====================================================================================================

            return;
        }

        [Benchmark]
        public 
            IEnumerable<KeyValuePair<int, (uint FrequencyAbsolute, double FrequencyRelative, uint FrequencyCumulative)>> 
                Queue_FrequencyDistribution
                    (
                    )
        {
            return data_queue.FrequencyDistribution();
        }

        [Test]
        public void Queue_FrequencyDistribution_Test()
        {
            //====================================================================================================
            //  Arrange

            sw = Stopwatch.StartNew();

            //----------------------------------------------------------------------------------------------------
            // Act
            //      extracted to atomic Benchmark method
            IEnumerable<KeyValuePair<int, (uint FrequencyAbsolute, double FrequencyRelative, uint FrequencyCumulative)>> fd;
            fd = Queue_FrequencyDistribution();

            sw.Stop();
            Console.WriteLine($"          fd               = {fd}");
            Console.WriteLine($"          size               = {data.Count()}");
            Console.WriteLine($"          elapsed[ticks]     = {sw.ElapsedTicks}");
            Console.WriteLine($"          elapsed[ms]        = {sw.Elapsed.TotalMilliseconds}");
            sw.Reset();
            //----------------------------------------------------------------------------------------------------
            // Assert
            #if NUNIT && !NUNIT_LITE
            CollectionAssert.AreEquivalent
                        (
                            fcd.ToList(),
                            fd
                        );
            #elif XUNIT
            Assert.Equal
                        (
                            fcd.ToList(),
                            fd
                        );
            #elif MSTEST
            CollectionAssert.AreEquivalent
                        (
                            fcd.ToList(),
                            fd.ToArray()
                        );
            #endif
            //====================================================================================================

            return;
        }

        [Benchmark]
        public 
            IEnumerable<KeyValuePair<int, (uint FrequencyAbsolute, double FrequencyRelative, uint FrequencyCumulative)>> 
                Stack_FrequencyDistribution
                    (
                    )
        {
            return data_stack.FrequencyDistribution();
        }

        [Test]
        public void Stack_FrequencyDistribution_Test()
        {
            //====================================================================================================
            //  Arrange
            //  reading data from files

            sw = Stopwatch.StartNew();

            //----------------------------------------------------------------------------------------------------
            // Act
            //      extracted to atomic Benchmark method
            IEnumerable<KeyValuePair<int, (uint FrequencyAbsolute, double FrequencyRelative, uint FrequencyCumulative)>> fd;
            fd = Stack_FrequencyDistribution();

            sw.Stop();
            Console.WriteLine($"          fd               = {fd}");
            Console.WriteLine($"          size               = {data.Count()}");
            Console.WriteLine($"          elapsed[ticks]     = {sw.ElapsedTicks}");
            Console.WriteLine($"          elapsed[ms]        = {sw.Elapsed.TotalMilliseconds}");
            sw.Reset();
            //----------------------------------------------------------------------------------------------------
            // Assert
            #if NUNIT && !NUNIT_LITE
            CollectionAssert.AreEquivalent
                        (
                            fcd.ToList(),
                            fd
                        );
            #elif XUNIT
            Assert.Equal
                        (
                            fcd.ToList(),
                            fd
                        );
            #elif MSTEST
            CollectionAssert.AreEquivalent
                        (
                            fcd.ToList(),
                            fd.ToArray()
                        );
            #endif
            //====================================================================================================

            return;
        }

        [Benchmark]
        public 
            IEnumerable<KeyValuePair<int, (uint FrequencyAbsolute, double FrequencyRelative, uint FrequencyCumulative)>> 
                LinkedList_FrequencyDistribution
                    (
                    )
        {
            return data_linked_list.FrequencyDistribution();
        }

        [Test]
        public void LinkedList_FrequencyDistribution_Test()
        {
            //====================================================================================================
            //  Arrange
            //  reading data from files

            sw = Stopwatch.StartNew();

            //----------------------------------------------------------------------------------------------------
            // Act
            //      extracted to atomic Benchmark method
            IEnumerable<KeyValuePair<int, (uint FrequencyAbsolute, double FrequencyRelative, uint FrequencyCumulative)>> fd;
            fd = LinkedList_FrequencyDistribution();

            sw.Stop();
            Console.WriteLine($"          fd               = {fd}");
            Console.WriteLine($"          size               = {data.Count()}");
            Console.WriteLine($"          elapsed[ticks]     = {sw.ElapsedTicks}");
            Console.WriteLine($"          elapsed[ms]        = {sw.Elapsed.TotalMilliseconds}");
            sw.Reset();
            //----------------------------------------------------------------------------------------------------
            // Assert
            #if NUNIT && !NUNIT_LITE
            CollectionAssert.AreEquivalent
                        (
                            fcd.ToList(),
                            fd
                        );
            #elif XUNIT
            Assert.Equal
                        (
                            fcd.ToList(),
                            fd
                        );
            #elif MSTEST
            CollectionAssert.AreEquivalent
                        (
                            fcd.ToList(),
                            fd.ToArray()
                        );
            #endif
            //====================================================================================================

            return;
        }

        [Benchmark]
        public
            IEnumerable<KeyValuePair<int, (uint FrequencyAbsolute, double FrequencyRelative, uint FrequencyCumulative)>> 
                ObservableCollection_FrequencyDistribution
                    (
                    )
        {
            return data_observable_collection.FrequencyDistribution();
        }

        [Test]
        public void ObservableCollection_FrequencyDistribution_Test()
        {
            //====================================================================================================
            //  Arrange
            //  reading data from files

            sw = Stopwatch.StartNew();

            //----------------------------------------------------------------------------------------------------
            // Act
            //      extracted to atomic Benchmark method
            IEnumerable<KeyValuePair<int, (uint FrequencyAbsolute, double FrequencyRelative, uint FrequencyCumulative)>> fd;
            fd = ObservableCollection_FrequencyDistribution();

            sw.Stop();
            Console.WriteLine($"          fd               = {fd}");
            Console.WriteLine($"          size               = {data.Count()}");
            Console.WriteLine($"          elapsed[ticks]     = {sw.ElapsedTicks}");
            Console.WriteLine($"          elapsed[ms]        = {sw.Elapsed.TotalMilliseconds}");
            sw.Reset();
            //----------------------------------------------------------------------------------------------------
            // Assert
            #if NUNIT && !NUNIT_LITE
            CollectionAssert.AreEquivalent
                        (
                            fcd.ToList(),
                            fd
                        );
            #elif XUNIT
            Assert.Equal
                        (
                            fcd.ToList(),
                            fd
                        );
            #elif MSTEST
            CollectionAssert.AreEquivalent
                        (
                            fcd.ToList(),
                            fd.ToArray()
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
        public void Span_FrequencyDistribution()
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
            double fd = data.FrequencyDistribution();
            sw.Stop();
            Console.WriteLine($"          fd               = {fd}");
            Console.WriteLine($"          size               = {data.Count()}");
            Console.WriteLine($"          elapsed[ticks]     = {sw.ElapsedTicks}");
            Console.WriteLine($"          elapsed[ms]        = {sw.Elapsed.TotalMilliseconds}");
            sw.Reset();
            //----------------------------------------------------------------------------------------------------
            // Assert
            #if NUNIT
            Assert.AreEqual(3.00, fd, 0.00001);
            #elif XUNIT
            Assert.Equal(3.00, fd, 5);
            #elif MSTEST
            Assert.AreEqual(3.00, fd, 0.00001);
            #endif
            //====================================================================================================

            return;
        }

        [Test]
        public void Span_FrequencyDistribution()
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
            double fd = data.FrequencyDistribution();
            sw.Stop();
            Console.WriteLine($"          fd               = {fd}");
            Console.WriteLine($"          size               = {data.Count()}");
            Console.WriteLine($"          elapsed[ticks]     = {sw.ElapsedTicks}");
            Console.WriteLine($"          elapsed[ms]        = {sw.Elapsed.TotalMilliseconds}");
            sw.Reset();
            //----------------------------------------------------------------------------------------------------
            // Assert
            #if NUNIT
            Assert.AreEqual(3.00, fd, 0.00001);
            #elif XUNIT
            Assert.Equal(3.00, fd, 5);
            #elif MSTEST
            Assert.AreEqual(3.00, fd, 0.00001);
            #endif
            //====================================================================================================

            return;
        }
        */
    }
}
