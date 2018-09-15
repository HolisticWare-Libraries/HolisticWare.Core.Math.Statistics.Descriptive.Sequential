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

namespace UnitTests.Core.Math.Statistics.Descriptive.Sequential.Sync
{
    public partial class Tests20180119Dataset02
    {
        Dictionary<double, (uint FrequencyAbsolute, double FrequencyRelative, uint FrequencyCumulative)> frequencies_calculated =
            new Dictionary<double, (uint FrequencyAbsolute, double FrequencyRelative, uint FrequencyCumulative)>
                                {
                                    { 18.2, ( 3, 0.1, 2) },
                                    { 14.7, ( 3, 0.1, 2) },
                                    { 13.5, ( 2, 0.1, 2) },
                                    { 16.4, ( 2, 0.1, 2) },
                                    { 13.4, ( 2, 0.1, 2) },
                                    { 18.6, ( 2, 0.1, 2) },
                                    { 12.9, ( 2, 0.1, 2) },
                                    { 16.2, ( 2, 0.1, 2) },
                                    { 15, ( 2, 0.1, 2) },
                                    { 11.9, ( 1, 0.1, 2) },
                                    { 13.6, ( 1, 0.1, 2) },
                                    { 28.9, ( 1, 0.1, 2) },
                                    { 16.5, ( 1, 0.1, 2) },
                                    { 24, ( 1, 0.1, 2) },
                                    { 14.5, ( 1, 0.1, 2) },
                                    { 19.8, ( 1, 0.1, 2) },
                                    { 22.9, ( 1, 0.1, 2) },
                                    { 19.5, ( 1, 0.1, 2) },
                                    { 14.3, ( 1, 0.1, 2) },
                                    { 11.3, ( 1, 0.1, 2) },
                                    { 10.5, ( 1, 0.1, 2) },
                                    { 13, ( 1, 0.1, 2) },
                                    { 11.6, ( 1, 0.1, 2) },
                                    { 16.8, ( 1, 0.1, 2) },
                                    { 12.1, ( 1, 0.1, 2) },
                                    { 16.9, ( 1, 0.1, 2) },
                                    { 19.3, ( 1, 0.1, 2) },
                                    { 15.5, ( 1, 0.1, 2) },
                                    { 13.8, ( 1, 0.1, 2) },
                                    { 17.1, ( 1, 0.1, 2) },
                                    { 17, ( 1, 0.1, 2) },
                                    { 11.7, ( 1, 0.1, 2) },
                                    { 11.8, ( 1, 0.1, 2) },
                                    { 12.7, ( 1, 0.1, 2) },
                                    { 12.2, ( 1, 0.1, 2) },
                                    { 16.1, ( 1, 0.1, 2) },
                                    { 17.6, ( 1, 0.1, 2) },
                                    { 15.1, ( 1, 0.1, 2) },
                                    { 13.3, ( 1, 0.1, 2) },
                                    { 15.9, ( 1, 0.1, 2) },
                                    { 13.7, ( 1, 0.1, 2) },
                                    { 16, ( 1, 0.1, 2) },
                                    { 15.2, ( 1, 0.1, 2) },
                                    { 18, ( 1, 0.1, 2) },
                                    { 17.5, ( 1, 0.1, 2) },
                                    { 19.4, ( 1, 0.1, 2) },
                                    { 17.4, ( 1, 0.1, 2) },
                                    { 15.3, ( 1, 0.1, 2) },
                                    { 25.4, ( 1, 0.1, 2) },
                                };

        [Benchmark]
        public IEnumerable<KeyValuePair<double, (uint FrequencyAbsolute, double FrequencyRelative, uint FrequencyCumulative)>> Array_Frequencies()
        {
            return data_array.Frequencies();
        }

        [Test]
        public void Array_Frequencies_Test()
        {
            Console.WriteLine($"Array_Frequencies_Test");
            //====================================================================================================
            //  Arrange
            //  reading data from files

            sw = Stopwatch.StartNew();

            //----------------------------------------------------------------------------------------------------
            // Act
            //      extracted to atomic Benchmark method
            IEnumerable<KeyValuePair<double, (uint FrequencyAbsolute, double FrequencyRelative, uint FrequencyCumulative)>> frequencies = Array_Frequencies();

            sw.Stop();
            Console.WriteLine($"Array<double>.Frequencies()");
            Console.WriteLine($"          frequencies        = {frequencies}");
            Console.WriteLine($"          size               = {data_array.Count()}");
            Console.WriteLine($"          elapsed[ticks]     = {sw.ElapsedTicks}");
            Console.WriteLine($"          elapsed[ms]        = {sw.Elapsed.TotalMilliseconds}");
            sw.Reset();

            //----------------------------------------------------------------------------------------------------
            // Assert
#if NUNIT && !NUNIT_LITE            CollectionAssert.AreEquivalent                        (
                            frequencies_calculated.ToList(),
                            frequencies
                        );
#elif XUNIT
            Assert.Equal
                        (
                            frequencies_calculated.ToList(),
                            frequencies.ToArray()
                        );
#elif MSTEST
            CollectionAssert.AreEquivalent
                        (
                            frequencies_calculated.ToList(),
                            frequencies.ToArray()
                        );
#endif
            //====================================================================================================

            return;
        }

        [Benchmark]
        public IEnumerable<KeyValuePair<double, (uint FrequencyAbsolute, double FrequencyRelative, uint FrequencyCumulative)>> ArraySegment_Frequencies()
        {
            return data_array_segment.Frequencies();
        }

        [Test]
        public void ArraySegment_Frequencies_Test()
        {
            //====================================================================================================
            //  Arrange
            //  reading data from files

            sw = Stopwatch.StartNew();

            //----------------------------------------------------------------------------------------------------
            // Act
            //      extracted to atomic Benchmark method
            IEnumerable<KeyValuePair<double, (uint FrequencyAbsolute, double FrequencyRelative, uint FrequencyCumulative)>> frequencies = ArraySegment_Frequencies();

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
                            frequencies_calculated.ToList(),
                            frequencies
                        );
#elif XUNIT
            Assert.Equal
                        (
                            frequencies_calculated.ToList(),
                            frequencies.ToArray()
                        );
#elif MSTEST
            CollectionAssert.AreEquivalent
                        (
                            frequencies_calculated.ToList(),
                            frequencies.ToArray()
                        );
#endif
            //====================================================================================================

            return;
        }

        [Benchmark]
        public IEnumerable<KeyValuePair<double, (uint FrequencyAbsolute, double FrequencyRelative, uint FrequencyCumulative)>> List_Frequencies()
        {
            return data_list.Frequencies();
        }

        [Test]
        public void List_Frequencies_Test()
        {
            //====================================================================================================
            //  Arrange
            //  reading data from files

            sw = Stopwatch.StartNew();

            //----------------------------------------------------------------------------------------------------
            // Act
            //      extracted to atomic Benchmark method
            IEnumerable<KeyValuePair<double, (uint FrequencyAbsolute, double FrequencyRelative, uint FrequencyCumulative)>> frequencies = List_Frequencies();

            Console.WriteLine($"          frequencies        = {frequencies}");
            Console.WriteLine($"          size               = {data.Count()}");
            Console.WriteLine($"          elapsed[ticks]     = {sw.ElapsedTicks}");
            Console.WriteLine($"          elapsed[ms]        = {sw.Elapsed.TotalMilliseconds}");
            sw.Reset();

            //----------------------------------------------------------------------------------------------------
            // Assert
            // Assert
#if NUNIT && !NUNIT_LITE            CollectionAssert.AreEquivalent                        (
                            frequencies_calculated.ToList(),
                            frequencies
                        );
#elif XUNIT
            Assert.Equal
                        (
                            frequencies_calculated.ToList(),
                            frequencies.ToArray()
                        );
#elif MSTEST
            CollectionAssert.AreEquivalent
                        (
                            frequencies_calculated.ToList(),
                            frequencies.ToArray()
                        );
#endif
            //====================================================================================================

            return;
        }

        [Benchmark]
        public IEnumerable<KeyValuePair<double, (uint FrequencyAbsolute, double FrequencyRelative, uint FrequencyCumulative)>> Queue_Frequencies()
        {
            return data_queue.Frequencies();
        }

        [Test]
        public void Queue_Frequencies_Test()
        {
            //====================================================================================================
            //  Arrange

            sw = Stopwatch.StartNew();

            //----------------------------------------------------------------------------------------------------
            // Act
            //      extracted to atomic Benchmark method
            IEnumerable<KeyValuePair<double, (uint FrequencyAbsolute, double FrequencyRelative, uint FrequencyCumulative)>> frequencies = Queue_Frequencies();

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
                            frequencies_calculated.ToList(),
                            frequencies
                        );
#elif XUNIT
            Assert.Equal
                        (
                            frequencies_calculated.ToList(),
                            frequencies.ToArray()
                        );
#elif MSTEST
            CollectionAssert.AreEquivalent
                        (
                            frequencies_calculated.ToList(),
                            frequencies.ToArray()
                        );
#endif
            //====================================================================================================

            return;
        }

        [Benchmark]
        public IEnumerable<KeyValuePair<double, (uint FrequencyAbsolute, double FrequencyRelative, uint FrequencyCumulative)>> Stack_Frequencies()
        {
            return data_stack.Frequencies();
        }

        [Test]
        public void Stack_Frequencies_Test()
        {
            //====================================================================================================
            //  Arrange
            //  reading data from files

            sw = Stopwatch.StartNew();

            //----------------------------------------------------------------------------------------------------
            // Act
            //      extracted to atomic Benchmark method
            IEnumerable<KeyValuePair<double, (uint FrequencyAbsolute, double FrequencyRelative, uint FrequencyCumulative)>> frequencies = Stack_Frequencies();

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
                            frequencies_calculated.ToList(),
                            frequencies
                        );
#elif XUNIT
            Assert.Equal
                        (
                            frequencies_calculated.ToList(),
                            frequencies.ToArray()
                        );
#elif MSTEST
            CollectionAssert.AreEquivalent
                        (
                            frequencies_calculated.ToList(),
                            frequencies.ToArray()
                        );
#endif
            //====================================================================================================

            return;
        }

        [Benchmark]
        public IEnumerable<KeyValuePair<double, (uint FrequencyAbsolute, double FrequencyRelative, uint FrequencyCumulative)>> LinkedList_Frequencies()
        {
            return data_linked_list.Frequencies();
        }

        [Test]
        public void LinkedList_Frequencies_Test()
        {
            //====================================================================================================
            //  Arrange
            //  reading data from files

            sw = Stopwatch.StartNew();

            //----------------------------------------------------------------------------------------------------
            // Act
            //      extracted to atomic Benchmark method
            IEnumerable<KeyValuePair<double, (uint FrequencyAbsolute, double FrequencyRelative, uint FrequencyCumulative)>> frequencies = LinkedList_Frequencies();

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
                            frequencies_calculated.ToList(),
                            frequencies
                        );
#elif XUNIT
            Assert.Equal
                        (
                            frequencies_calculated.ToList(),
                            frequencies.ToArray()
                        );
#elif MSTEST
            CollectionAssert.AreEquivalent
                        (
                            frequencies_calculated.ToList(),
                            frequencies.ToArray()
                        );
#endif
            //====================================================================================================

            return;
        }

        [Benchmark]
        public IEnumerable<KeyValuePair<double, (uint FrequencyAbsolute, double FrequencyRelative, uint FrequencyCumulative)>> ObservableCollection_Frequencies()
        {
            return data_observable_collection.Frequencies();
        }

        [Test]
        public void ObservableCollection_Frequencies_Test()
        {
            //====================================================================================================
            //  Arrange
            //  reading data from files

            sw = Stopwatch.StartNew();

            //----------------------------------------------------------------------------------------------------
            // Act
            //      extracted to atomic Benchmark method
            IEnumerable<KeyValuePair<double, (uint FrequencyAbsolute, double FrequencyRelative, uint FrequencyCumulative)>> frequencies = ObservableCollection_Frequencies();

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
                            frequencies_calculated.ToList(),
                            frequencies
                        );
#elif XUNIT
            Assert.Equal
                        (
                            frequencies_calculated.ToList(),
                            frequencies.ToArray()
                        );
#elif MSTEST
            CollectionAssert.AreEquivalent
                        (
                            frequencies_calculated.ToList(),
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
        public void Span_Frequencies()
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
            double frequencies = data.Frequencies();
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
        public void Span_Frequencies()
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
            double frequencies = data.Frequencies();
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
