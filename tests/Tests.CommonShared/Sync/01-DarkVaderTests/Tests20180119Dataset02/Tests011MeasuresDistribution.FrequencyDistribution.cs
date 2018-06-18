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
        Dictionary<double, uint> frequencies_calculated =
            new Dictionary<double, uint>
                                {
                                    { 18.2, 3 },
                                    { 14.7, 3 },
                                    { 13.5, 2 },
                                    { 16.4, 2 },
                                    { 13.4, 2 },
                                    { 18.6, 2 },
                                    { 12.9, 2 },
                                    { 16.2, 2 },
                                    { 15, 2 },
                                    { 11.9, 1 },
                                    { 13.6, 1 },
                                    { 28.9, 1 },
                                    { 16.5, 1 },
                                    { 24, 1 },
                                    { 14.5, 1 },
                                    { 19.8, 1 },
                                    { 22.9, 1 },
                                    { 19.5, 1 },
                                    { 14.3, 1 },
                                    { 11.3, 1 },
                                    { 10.5, 1 },
                                    { 13, 1 },
                                    { 11.6, 1 },
                                    { 16.8, 1 },
                                    { 12.1, 1 },
                                    { 16.9, 1 },
                                    { 19.3, 1 },
                                    { 15.5, 1 },
                                    { 13.8, 1 },
                                    { 17.1, 1 },
                                    { 17, 1 },
                                    { 11.7, 1 },
                                    { 11.8, 1 },
                                    { 12.7, 1 },
                                    { 12.2, 1 },
                                    { 16.1, 1 },
                                    { 17.6, 1 },
                                    { 15.1, 1 },
                                    { 13.3, 1 },
                                    { 15.9, 1 },
                                    { 13.7, 1 },
                                    { 16, 1 },
                                    { 15.2, 1 },
                                    { 18, 1 },
                                    { 17.5, 1 },
                                    { 19.4, 1 },
                                    { 17.4, 1 },
                                    { 15.3, 1 },
                                    { 25.4, 1 },
                                };

        [Benchmark]
        public IEnumerable<KeyValuePair<double, uint>> Array_FrequencyDistribution()
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
            IEnumerable<KeyValuePair<double, uint>> frequency_distribution = Array_FrequencyDistribution();

            sw.Stop();
            Console.WriteLine($"Array<double>.FrequencyDistribution()");
            Console.WriteLine($"          frequency_distribution               = {frequency_distribution}");
            Console.WriteLine($"          size               = {data_array.Count()}");
            Console.WriteLine($"          elapsed[ticks]     = {sw.ElapsedTicks}");
            Console.WriteLine($"          elapsed[ms]        = {sw.Elapsed.TotalMilliseconds}");
            sw.Reset();
            //----------------------------------------------------------------------------------------------------
            // Assert
            #if NUNIT && !NUNIT_LITE            CollectionAssert.AreEquivalent                        (
                            frequencies_calculated.OrderByDescending(x => x.Value).ThenByDescending(x => x.Key),
                            frequency_distribution.OrderByDescending(x => x.Value).ThenByDescending(x => x.Key)
                        );
            #elif XUNIT
            Assert.Equal
                        (
                            frequencies_calculated.OrderByDescending(x => x.Value).ThenByDescending(x => x.Key),
                            frequency_distribution.OrderByDescending(x => x.Value).ThenByDescending(x => x.Key)
                        );
            #elif MSTEST
            CollectionAssert.AreEquivalent
                        (
                            frequencies_calculated.OrderByDescending(x => x.Value).ThenByDescending(x => x.Key).ToArray(),
                            frequency_distribution.OrderByDescending(x => x.Value).ThenByDescending(x => x.Key).ToArray()
                        );
            #endif
            //====================================================================================================

            return;
        }

        [Benchmark]
        public IEnumerable<KeyValuePair<double, uint>> ArraySegment_FrequencyDistribution()
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
            IEnumerable<KeyValuePair<double, uint>> frequency_distribution = ArraySegment_FrequencyDistribution();

            sw.Stop();
            Console.WriteLine($"          frequency_distribution               = {frequency_distribution}");
            Console.WriteLine($"          size               = {data.Count()}");
            Console.WriteLine($"          elapsed[ticks]     = {sw.ElapsedTicks}");
            Console.WriteLine($"          elapsed[ms]        = {sw.Elapsed.TotalMilliseconds}");
            sw.Reset();
            //----------------------------------------------------------------------------------------------------
            // Assert
            #if NUNIT && !NUNIT_LITE            CollectionAssert.AreEquivalent                        (
                            frequencies_calculated.OrderByDescending(x => x.Value).ThenByDescending(x => x.Key),
                            frequency_distribution.OrderByDescending(x => x.Value).ThenByDescending(x => x.Key)
                        );
            #elif XUNIT
            Assert.Equal
                        (
                            frequencies_calculated.OrderByDescending(x => x.Value).ThenByDescending(x => x.Key),
                            frequency_distribution.OrderByDescending(x => x.Value).ThenByDescending(x => x.Key)
                        );
            #elif MSTEST
            CollectionAssert.AreEquivalent
                        (
                            frequencies_calculated.OrderByDescending(x => x.Value).ThenByDescending(x => x.Key).ToArray(),
                            frequency_distribution.OrderByDescending(x => x.Value).ThenByDescending(x => x.Key).ToArray()
                        );
            #endif
            //====================================================================================================

            return;
        }

        [Benchmark]
        public IEnumerable<KeyValuePair<double, uint>> List_FrequencyDistribution()
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
            IEnumerable<KeyValuePair<double, uint>> frequency_distribution = List_FrequencyDistribution();

            Console.WriteLine($"          frequency_distribution               = {frequency_distribution}");
            Console.WriteLine($"          size               = {data.Count()}");
            Console.WriteLine($"          elapsed[ticks]     = {sw.ElapsedTicks}");
            Console.WriteLine($"          elapsed[ms]        = {sw.Elapsed.TotalMilliseconds}");
            sw.Reset();
            //----------------------------------------------------------------------------------------------------
            // Assert
            #if NUNIT && !NUNIT_LITE            CollectionAssert.AreEquivalent                        (
                            frequencies_calculated.OrderByDescending(x => x.Value).ThenByDescending(x => x.Key),
                            frequency_distribution.OrderByDescending(x => x.Value).ThenByDescending(x => x.Key)
                        );
            #elif XUNIT
            Assert.Equal
                        (
                            frequencies_calculated.OrderByDescending(x => x.Value).ThenByDescending(x => x.Key),
                            frequency_distribution.OrderByDescending(x => x.Value).ThenByDescending(x => x.Key)
                        );
            #elif MSTEST
            CollectionAssert.AreEquivalent
                        (
                            frequencies_calculated.OrderByDescending(x => x.Value).ThenByDescending(x => x.Key).ToArray(),
                            frequency_distribution.OrderByDescending(x => x.Value).ThenByDescending(x => x.Key).ToArray()
                        );
            #endif
            //====================================================================================================

            return;
        }

        [Benchmark]
        public IEnumerable<KeyValuePair<double, uint>> Queue_FrequencyDistribution()
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
            IEnumerable<KeyValuePair<double, uint>> frequency_distribution = Queue_FrequencyDistribution();

            sw.Stop();
            Console.WriteLine($"          frequency_distribution               = {frequency_distribution}");
            Console.WriteLine($"          size               = {data.Count()}");
            Console.WriteLine($"          elapsed[ticks]     = {sw.ElapsedTicks}");
            Console.WriteLine($"          elapsed[ms]        = {sw.Elapsed.TotalMilliseconds}");
            sw.Reset();
            //----------------------------------------------------------------------------------------------------
            // Assert
            #if NUNIT && !NUNIT_LITE            CollectionAssert.AreEquivalent                        (
                            frequencies_calculated.OrderByDescending(x => x.Value).ThenByDescending(x => x.Key),
                            frequency_distribution.OrderByDescending(x => x.Value).ThenByDescending(x => x.Key)
                        );
            #elif XUNIT
            Assert.Equal
                        (
                            frequencies_calculated.OrderByDescending(x => x.Value).ThenByDescending(x => x.Key),
                            frequency_distribution.OrderByDescending(x => x.Value).ThenByDescending(x => x.Key)
                        );
            #elif MSTEST
            CollectionAssert.AreEquivalent
                        (
                            frequencies_calculated.OrderByDescending(x => x.Value).ThenByDescending(x => x.Key).ToArray(),
                            frequency_distribution.OrderByDescending(x => x.Value).ThenByDescending(x => x.Key).ToArray()
                        );
            #endif
            //====================================================================================================

            return;
        }

        [Benchmark]
        public IEnumerable<KeyValuePair<double, uint>> Stack_FrequencyDistribution()
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
            IEnumerable<KeyValuePair<double, uint>> frequency_distribution = Stack_FrequencyDistribution();

            sw.Stop();
            Console.WriteLine($"          frequency_distribution               = {frequency_distribution}");
            Console.WriteLine($"          size               = {data.Count()}");
            Console.WriteLine($"          elapsed[ticks]     = {sw.ElapsedTicks}");
            Console.WriteLine($"          elapsed[ms]        = {sw.Elapsed.TotalMilliseconds}");
            sw.Reset();
            //----------------------------------------------------------------------------------------------------
            // Assert
            #if NUNIT && !NUNIT_LITE            CollectionAssert.AreEquivalent                        (
                            frequencies_calculated.OrderByDescending(x => x.Value).ThenByDescending(x => x.Key),
                            frequency_distribution.OrderByDescending(x => x.Value).ThenByDescending(x => x.Key)
                        );
            #elif XUNIT
            Assert.Equal
                        (
                            frequencies_calculated.OrderByDescending(x => x.Value).ThenByDescending(x => x.Key),
                            frequency_distribution.OrderByDescending(x => x.Value).ThenByDescending(x => x.Key)
                        );
            #elif MSTEST
            CollectionAssert.AreEquivalent
                        (
                            frequencies_calculated.OrderByDescending(x => x.Value).ThenByDescending(x => x.Key).ToArray(),
                            frequency_distribution.OrderByDescending(x => x.Value).ThenByDescending(x => x.Key).ToArray()
                        );
            #endif
            //====================================================================================================

            return;
        }

        [Benchmark]
        public IEnumerable<KeyValuePair<double, uint>> LinkedList_FrequencyDistribution()
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
            IEnumerable<KeyValuePair<double, uint>> frequency_distribution = LinkedList_FrequencyDistribution();

            sw.Stop();
            Console.WriteLine($"          frequency_distribution               = {frequency_distribution}");
            Console.WriteLine($"          size               = {data.Count()}");
            Console.WriteLine($"          elapsed[ticks]     = {sw.ElapsedTicks}");
            Console.WriteLine($"          elapsed[ms]        = {sw.Elapsed.TotalMilliseconds}");
            sw.Reset();
            //----------------------------------------------------------------------------------------------------
            // Assert
            #if NUNIT && !NUNIT_LITE
            CollectionAssert.AreEquivalent
                        (
                            frequencies_calculated.OrderByDescending(x => x.Value).ThenByDescending(x => x.Key),
                            frequency_distribution.OrderByDescending(x => x.Value).ThenByDescending(x => x.Key)
                        );
            #elif XUNIT
            Assert.Equal
                        (
                            frequencies_calculated.OrderByDescending(x => x.Value).ThenByDescending(x => x.Key),
                            frequency_distribution.OrderByDescending(x => x.Value).ThenByDescending(x => x.Key)
                        );
            #elif MSTEST
            CollectionAssert.AreEquivalent
                        (
                            frequencies_calculated.OrderByDescending(x => x.Value).ThenByDescending(x => x.Key).ToArray(),
                            frequency_distribution.OrderByDescending(x => x.Value).ThenByDescending(x => x.Key).ToArray()
                        );
            #endif
            //====================================================================================================

            return;
        }

        [Benchmark]
        public IEnumerable<KeyValuePair<double, uint>> ObservableCollection_FrequencyDistribution()
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
            IEnumerable<KeyValuePair<double, uint>> frequency_distribution = ObservableCollection_FrequencyDistribution();

            sw.Stop();
            Console.WriteLine($"          frequency_distribution               = {frequency_distribution}");
            Console.WriteLine($"          size               = {data.Count()}");
            Console.WriteLine($"          elapsed[ticks]     = {sw.ElapsedTicks}");
            Console.WriteLine($"          elapsed[ms]        = {sw.Elapsed.TotalMilliseconds}");
            sw.Reset();
            //----------------------------------------------------------------------------------------------------
            // Assert
            #if NUNIT && !NUNIT_LITE
            CollectionAssert.AreEquivalent
                        (
                            frequencies_calculated.OrderByDescending(x => x.Value).ThenByDescending(x => x.Key),
                            frequency_distribution.OrderByDescending(x => x.Value).ThenByDescending(x => x.Key)
                        );
            #elif XUNIT
            Assert.Equal
                        (
                            frequencies_calculated.OrderByDescending(x => x.Value).ThenByDescending(x => x.Key),
                            frequency_distribution.OrderByDescending(x => x.Value).ThenByDescending(x => x.Key)
                        );
            #elif MSTEST
            CollectionAssert.AreEquivalent
                        (
                            frequencies_calculated.OrderByDescending(x => x.Value).ThenByDescending(x => x.Key).ToArray(),
                            frequency_distribution.OrderByDescending(x => x.Value).ThenByDescending(x => x.Key).ToArray()
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
            Span<double> data = 
                            new Span<double>(data01);
                            //data01.AsSpan().Slice(start: 0)
                            ;
            double frequency_distribution = data.FrequencyDistribution();
            sw.Stop();
            Console.WriteLine($"          frequency_distribution               = {frequency_distribution}");
            Console.WriteLine($"          size               = {data.Count()}");
            Console.WriteLine($"          elapsed[ticks]     = {sw.ElapsedTicks}");
            Console.WriteLine($"          elapsed[ms]        = {sw.Elapsed.TotalMilliseconds}");
            sw.Reset();
            //----------------------------------------------------------------------------------------------------
            // Assert
            #if NUNIT
            Assert.AreEqual(3.00, frequency_distribution, 0.00001);
            #elif XUNIT
            Assert.Equal(3.00, frequency_distribution, 5);
            #elif MSTEST
            Assert.AreEqual(3.00, frequency_distribution, 0.00001);
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
            Memory<double> data =
                            new Memory<double>(data01);
                            //data01.AsSpan().Slice(start: 0)
                            ;
            double frequency_distribution = data.FrequencyDistribution();
            sw.Stop();
            Console.WriteLine($"          frequency_distribution               = {frequency_distribution}");
            Console.WriteLine($"          size               = {data.Count()}");
            Console.WriteLine($"          elapsed[ticks]     = {sw.ElapsedTicks}");
            Console.WriteLine($"          elapsed[ms]        = {sw.Elapsed.TotalMilliseconds}");
            sw.Reset();
            //----------------------------------------------------------------------------------------------------
            // Assert
            #if NUNIT
            Assert.AreEqual(3.00, frequency_distribution, 0.00001);
            #elif XUNIT
            Assert.Equal(3.00, frequency_distribution, 5);
            #elif MSTEST
            Assert.AreEqual(3.00, frequency_distribution, 0.00001);
            #endif
            //====================================================================================================

            return;
        }
        */
    }
}
