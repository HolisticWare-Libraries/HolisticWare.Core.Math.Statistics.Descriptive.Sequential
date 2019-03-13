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
        Dictionary<int, uint> frequencies_cumulative_calculated =
            new Dictionary<int, uint>
                    {
                    };


        [Benchmark]
        public IEnumerable<KeyValuePair<int, uint>> Array_FrequenciesCumulative()
        {
            return data_array.FrequenciesCumulative();
        }

        [Test]
        public void Array_FrequenciesCumulative_Test()
        {
            Console.WriteLine($"Array_FrequenciesCumulative_Test");
            //====================================================================================================
            //  Arrange
            //  reading data from files

            sw = Stopwatch.StartNew();

            //----------------------------------------------------------------------------------------------------
            // Act
            //      extracted to atomic Benchmark method
            IEnumerable<KeyValuePair<int, uint>> frequencies = Array_FrequenciesCumulative();

            sw.Stop();
            Console.WriteLine($"Array<double>.FrequenciesCumulative()");
            Console.WriteLine($"          frequencies        = {frequencies}");
            Console.WriteLine($"          size               = {data_array.Count()}");
            Console.WriteLine($"          elapsed[ticks]     = {sw.ElapsedTicks}");
            Console.WriteLine($"          elapsed[ms]        = {sw.Elapsed.TotalMilliseconds}");
            sw.Reset();
            //----------------------------------------------------------------------------------------------------
            // Assert
            // Assert
            #if NUNIT && !NUNIT_LITE            CollectionAssert.AreEquivalent                        (
                            frequencies_cumulative_calculated.ToList(),
                            frequencies
                        );
            #elif XUNIT
            Assert.Equal
                        (
                            frequencies_cumulative_calculated.ToList(),
                            frequencies
                        );
            #elif MSTEST
            CollectionAssert.AreEquivalent
                        (
                            frequencies_cumulative_calculated.ToList(),
                            frequencies.ToArray()
                        );
            #endif
            //====================================================================================================

            return;
        }

        [Benchmark]
        public IEnumerable<KeyValuePair<int, uint>> ArraySegment_FrequenciesCumulative()
        {
            return data_array_segment.FrequenciesCumulative();
        }

        [Test]
        public void ArraySegment_FrequenciesCumulative_Test()
        {
            //====================================================================================================
            //  Arrange
            //  reading data from files

            sw = Stopwatch.StartNew();

            //----------------------------------------------------------------------------------------------------
            // Act
            //      extracted to atomic Benchmark method
            IEnumerable<KeyValuePair<int, uint>> frequencies = ArraySegment_FrequenciesCumulative();

            sw.Stop();
            Console.WriteLine($"          frequencies        = {frequencies}");
            Console.WriteLine($"          size               = {data.Count()}");
            Console.WriteLine($"          elapsed[ticks]     = {sw.ElapsedTicks}");
            Console.WriteLine($"          elapsed[ms]        = {sw.Elapsed.TotalMilliseconds}");
            sw.Reset();
            //----------------------------------------------------------------------------------------------------
            // Assert
            #if NUNIT && !NUNIT_LITE            CollectionAssert.AreEquivalent                        (
                            frequencies_cumulative_calculated.ToList(),
                            frequencies
                        );
            #elif XUNIT
            Assert.Equal
                        (
                            frequencies_cumulative_calculated.ToList(),
                            frequencies
                        );
            #elif MSTEST
            CollectionAssert.AreEquivalent
                        (
                            frequencies_cumulative_calculated.ToList(),
                            frequencies.ToArray()
                        );
            #endif
            //====================================================================================================

            return;
        }

        [Benchmark]
        public IEnumerable<KeyValuePair<int, uint>> List_FrequenciesCumulative()
        {
            return data_list.FrequenciesCumulative();
        }

        [Test]
        public void List_FrequenciesCumulative_Test()
        {
            //====================================================================================================
            //  Arrange
            //  reading data from files

            sw = Stopwatch.StartNew();

            //----------------------------------------------------------------------------------------------------
            // Act
            //      extracted to atomic Benchmark method
            IEnumerable<KeyValuePair<int, uint>> frequencies = List_FrequenciesCumulative();

            Console.WriteLine($"          frequencies        = {frequencies}");
            Console.WriteLine($"          size               = {data.Count()}");
            Console.WriteLine($"          elapsed[ticks]     = {sw.ElapsedTicks}");
            Console.WriteLine($"          elapsed[ms]        = {sw.Elapsed.TotalMilliseconds}");
            sw.Reset();
            //----------------------------------------------------------------------------------------------------
            // Assert
            #if NUNIT && !NUNIT_LITE            CollectionAssert.AreEquivalent                        (
                            frequencies_cumulative_calculated.ToList(),
                            frequencies
                        );
            #elif XUNIT
            Assert.Equal
                        (
                            frequencies_cumulative_calculated.ToList(),
                            frequencies
                        );
            #elif MSTEST
            CollectionAssert.AreEquivalent
                        (
                            frequencies_cumulative_calculated.ToList(),
                            frequencies.ToArray()
                        );
            #endif
            //====================================================================================================

            return;
        }

        [Benchmark]
        public IEnumerable<KeyValuePair<int, uint>> Queue_FrequenciesCumulative()
        {
            return data_queue.FrequenciesCumulative();
        }

        [Test]
        public void Queue_FrequenciesCumulative_Test()
        {
            //====================================================================================================
            //  Arrange

            sw = Stopwatch.StartNew();

            //----------------------------------------------------------------------------------------------------
            // Act
            //      extracted to atomic Benchmark method
            IEnumerable<KeyValuePair<int, uint>> frequencies = Queue_FrequenciesCumulative();

            sw.Stop();
            Console.WriteLine($"          frequencies        = {frequencies}");
            Console.WriteLine($"          size               = {data.Count()}");
            Console.WriteLine($"          elapsed[ticks]     = {sw.ElapsedTicks}");
            Console.WriteLine($"          elapsed[ms]        = {sw.Elapsed.TotalMilliseconds}");
            sw.Reset();
            //----------------------------------------------------------------------------------------------------
            // Assert
            #if NUNIT && !NUNIT_LITE            CollectionAssert.AreEquivalent                        (
                            frequencies_cumulative_calculated.ToList(),
                            frequencies
                        );
            #elif XUNIT
            Assert.Equal
                        (
                            frequencies_cumulative_calculated.ToList(),
                            frequencies
                        );
            #elif MSTEST
            CollectionAssert.AreEquivalent
                        (
                            frequencies_cumulative_calculated.ToList(),
                            frequencies.ToArray()
                        );
            #endif
            //====================================================================================================

            return;
        }

        [Benchmark]
        public IEnumerable<KeyValuePair<int, uint>> Stack_FrequenciesCumulative()
        {
            return data_stack.FrequenciesCumulative();
        }

        [Test]
        public void Stack_FrequenciesCumulative_Test()
        {
            //====================================================================================================
            //  Arrange
            //  reading data from files

            sw = Stopwatch.StartNew();

            //----------------------------------------------------------------------------------------------------
            // Act
            //      extracted to atomic Benchmark method
            IEnumerable<KeyValuePair<int, uint>> frequencies = Stack_FrequenciesCumulative();

            sw.Stop();
            Console.WriteLine($"          frequencies        = {frequencies}");
            Console.WriteLine($"          size               = {data.Count()}");
            Console.WriteLine($"          elapsed[ticks]     = {sw.ElapsedTicks}");
            Console.WriteLine($"          elapsed[ms]        = {sw.Elapsed.TotalMilliseconds}");
            sw.Reset();
            //----------------------------------------------------------------------------------------------------
            // Assert
            #if NUNIT && !NUNIT_LITE            CollectionAssert.AreEquivalent                        (
                            frequencies_cumulative_calculated.ToList(),
                            frequencies
                        );
            #elif XUNIT
            Assert.Equal
                        (
                            frequencies_cumulative_calculated.ToList(),
                            frequencies
                        );
            #elif MSTEST
            CollectionAssert.AreEquivalent
                        (
                            frequencies_cumulative_calculated.ToList(),
                            frequencies.ToArray()
                        );
            #endif
            //====================================================================================================

            return;
        }

        [Benchmark]
        public IEnumerable<KeyValuePair<int, uint>> LinkedList_FrequenciesCumulative()
        {
            return data_linked_list.FrequenciesCumulative();
        }

        [Test]
        public void LinkedList_FrequenciesCumulative_Test()
        {
            //====================================================================================================
            //  Arrange
            //  reading data from files

            sw = Stopwatch.StartNew();

            //----------------------------------------------------------------------------------------------------
            // Act
            //      extracted to atomic Benchmark method
            IEnumerable<KeyValuePair<int, uint>> frequencies = LinkedList_FrequenciesCumulative();

            sw.Stop();
            Console.WriteLine($"          frequencies        = {frequencies}");
            Console.WriteLine($"          size               = {data.Count()}");
            Console.WriteLine($"          elapsed[ticks]     = {sw.ElapsedTicks}");
            Console.WriteLine($"          elapsed[ms]        = {sw.Elapsed.TotalMilliseconds}");
            sw.Reset();
            //----------------------------------------------------------------------------------------------------
            // Assert
            // Assert
            #if NUNIT && !NUNIT_LITE            CollectionAssert.AreEquivalent                        (
                            frequencies_cumulative_calculated.ToList(),
                            frequencies
                        );
            #elif XUNIT
            Assert.Equal
                        (
                            frequencies_cumulative_calculated.ToList(),
                            frequencies
                        );
            #elif MSTEST
            CollectionAssert.AreEquivalent
                        (
                            frequencies_cumulative_calculated.ToList(),
                            frequencies.ToArray()
                        );
            #endif
            //====================================================================================================

            return;
        }

        [Benchmark]
        public IEnumerable<KeyValuePair<int, uint>> ObservableCollection_FrequenciesCumulative()
        {
            return data_observable_collection.FrequenciesCumulative();
        }

        [Test]
        public void ObservableCollection_FrequenciesCumulative_Test()
        {
            //====================================================================================================
            //  Arrange
            //  reading data from files

            sw = Stopwatch.StartNew();

            //----------------------------------------------------------------------------------------------------
            // Act
            //      extracted to atomic Benchmark method
            IEnumerable<KeyValuePair<int, uint>> frequencies = ObservableCollection_FrequenciesCumulative();

            sw.Stop();
            Console.WriteLine($"          frequencies        = {frequencies}");
            Console.WriteLine($"          size               = {data.Count()}");
            Console.WriteLine($"          elapsed[ticks]     = {sw.ElapsedTicks}");
            Console.WriteLine($"          elapsed[ms]        = {sw.Elapsed.TotalMilliseconds}");
            sw.Reset();
            //----------------------------------------------------------------------------------------------------
            // Assert
            #if NUNIT && !NUNIT_LITE            CollectionAssert.AreEquivalent                        (
                            frequencies_cumulative_calculated.ToList(),
                            frequencies
                        );
            #elif XUNIT
            Assert.Equal
                        (
                            frequencies_cumulative_calculated.ToList(),
                            frequencies
                        );
            #elif MSTEST
            CollectionAssert.AreEquivalent
                        (
                            frequencies_cumulative_calculated.ToList(),
                            frequencies.ToArray()
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
        public void Span_FrequenciesCumulative()
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
            double frequencies = data.FrequenciesCumulative();
            sw.Stop();
            Console.WriteLine($"          frequencies               = {frequencies}");
            Console.WriteLine($"          size               = {data.Count()}");
            Console.WriteLine($"          elapsed[ticks]     = {sw.ElapsedTicks}");
            Console.WriteLine($"          elapsed[ms]        = {sw.Elapsed.TotalMilliseconds}");
            sw.Reset();
            //----------------------------------------------------------------------------------------------------
            // Assert
            #if NUNIT
            Assert.AreEqual(3.00, frequencies, 0.00001);
            #elif XUNIT
            Assert.Equal(3.00, frequencies, 5);
            #elif MSTEST
            Assert.AreEqual(3.00, frequencies, 0.00001);
            #endif
            //====================================================================================================

            return;
        }

        [Test]
        public void Span_FrequenciesCumulative()
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
            double frequencies = data.FrequenciesCumulative();
            sw.Stop();
            Console.WriteLine($"          frequencies               = {frequencies}");
            Console.WriteLine($"          size               = {data.Count()}");
            Console.WriteLine($"          elapsed[ticks]     = {sw.ElapsedTicks}");
            Console.WriteLine($"          elapsed[ms]        = {sw.Elapsed.TotalMilliseconds}");
            sw.Reset();
            //----------------------------------------------------------------------------------------------------
            // Assert
            #if NUNIT
            Assert.AreEqual(3.00, frequencies, 0.00001);
            #elif XUNIT
            Assert.Equal(3.00, frequencies, 5);
            #elif MSTEST
            Assert.AreEqual(3.00, frequencies, 0.00001);
            #endif
            //====================================================================================================

            return;
        }
        */
    }
}
