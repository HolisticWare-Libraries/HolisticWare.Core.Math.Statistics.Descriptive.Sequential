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
    public partial class Tests20180119Dataset03
    {
    
        Dictionary<int, (uint FrequencyAbsolute, double FrequencyRelative, uint FrequencyCumulative)> fc
            = new Dictionary<int, (uint FrequencyAbsolute, double FrequencyRelative, uint FrequencyCumulative)>
                                {
                                    { 180, ( 9, 0.15, 9) },
                                    { 175, ( 8, 0.133333333333333, 17) },
                                    { 195, ( 6, 0.1, 23) },
                                    { 160, ( 5, 0.0833333333333333, 28) },
                                    { 170, ( 5, 0.0833333333333333, 33) },
                                    { 190, ( 5, 0.0833333333333333, 38) },
                                    { 150, ( 4, 0.0666666666666667, 42) },
                                    { 165, ( 4, 0.0666666666666667, 46) },
                                    { 205, ( 4, 0.0666666666666667, 50) },
                                    { 155, ( 3, 0.05, 53) },
                                    { 185, ( 3, 0.05, 56) },
                                    { 200, ( 2, 0.0333333333333333, 58) },
                                    { 135, ( 1, 0.0166666666666667, 59) },
                                    { 210, ( 1, 0.0166666666666667, 60) },
                                };


        [Benchmark]
        public 
            IEnumerable<KeyValuePair<int, (uint FrequencyAbsolute, double FrequencyRelative, uint FrequencyCumulative)>> 
                Array_Frequencies
                    (
                    )
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
            IEnumerable<KeyValuePair<int, (uint FrequencyAbsolute, double FrequencyRelative, uint FrequencyCumulative)>> f;
            f = Array_Frequencies();

            sw.Stop();
            Console.WriteLine($"Array<double>.Frequencies()");
            Console.WriteLine($"          frequencies        = {f}");
            Console.WriteLine($"          size               = {data_array.Count()}");
            Console.WriteLine($"          elapsed[ticks]     = {sw.ElapsedTicks}");
            Console.WriteLine($"          elapsed[ms]        = {sw.Elapsed.TotalMilliseconds}");
            sw.Reset();
            //----------------------------------------------------------------------------------------------------
            // Assert
            #if NUNIT && !NUNIT_LITE
            //CollectionAssert.AreEquivalent
                                     //(
                                     //    fc.ToList(),
                                     //    f
                                     //);
            Assert.AreEqual(fc.Count(), f.Count());
            for (int i = 0; i < fc.Count(); i++)
            {
                Assert.AreEqual
                            (
                                f.ElementAt(i).Key, 
                                fc.ElementAt(i).Key 
                            );
                Assert.AreEqual
                            (
                                f.ElementAt(i).Value.FrequencyAbsolute, 
                                fc.ElementAt(i).Value.FrequencyAbsolute
                            );
                Assert.AreEqual
                            (
                                f.ElementAt(i).Value.FrequencyRelative,
                                fc.ElementAt(i).Value.FrequencyRelative,
                                0.000001
                            );
                Assert.AreEqual
                            (
                                f.ElementAt(i).Value.FrequencyCumulative,
                                fc.ElementAt(i).Value.FrequencyCumulative
                            );
            }
            #elif XUNIT
            //Assert.Equal
            //(
            //    fc.ToList(),
            //    f.ToArray()
            //);
            Assert.Equal(fc.Count(), f.Count());
            for (int i = 0; i < fc.Count(); i++)
            {
                Assert.Equal
                            (
                                f.ElementAt(i).Key,
                                fc.ElementAt(i).Key
                            );
                Assert.Equal
                            (
                                f.ElementAt(i).Value.FrequencyAbsolute,
                                fc.ElementAt(i).Value.FrequencyAbsolute
                            );
                Assert.Equal
                            (
                                f.ElementAt(i).Value.FrequencyRelative,
                                fc.ElementAt(i).Value.FrequencyRelative,
                                5
                            );
                Assert.Equal
                            (
                                f.ElementAt(i).Value.FrequencyCumulative,
                                fc.ElementAt(i).Value.FrequencyCumulative
                            );
            }
            #elif MSTEST
            Assert.AreEqual(fc.Count(), f.Count());
            for (int i = 0; i < fc.Count(); i++)
            {
                Assert.AreEqual
                            (
                                f.ElementAt(i).Key, 
                                fc.ElementAt(i).Key
                            );
                Assert.AreEqual
                            (
                                f.ElementAt(i).Value.FrequencyAbsolute, 
                                fc.ElementAt(i).Value.FrequencyAbsolute
                            );
                Assert.AreEqual
                            (
                                f.ElementAt(i).Value.FrequencyRelative,
                                fc.ElementAt(i).Value.FrequencyRelative,
                                0.000001
                            );
                Assert.AreEqual
                            (
                                f.ElementAt(i).Value.FrequencyCumulative,
                                fc.ElementAt(i).Value.FrequencyCumulative
                            );
            }
            #endif
            //====================================================================================================

            return;
        }

        [Benchmark]
        public 
            IEnumerable<KeyValuePair<int, (uint FrequencyAbsolute, double FrequencyRelative, uint FrequencyCumulative)>> 
                ArraySegment_Frequencies
                    (
                    )
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
            IEnumerable<KeyValuePair<int, (uint FrequencyAbsolute, double FrequencyRelative, uint FrequencyCumulative)>> f;
            f = ArraySegment_Frequencies();

            sw.Stop();
            Console.WriteLine($"          frequencies        = {f}");
            Console.WriteLine($"          size               = {data.Count()}");
            Console.WriteLine($"          elapsed[ticks]     = {sw.ElapsedTicks}");
            Console.WriteLine($"          elapsed[ms]        = {sw.Elapsed.TotalMilliseconds}");
            sw.Reset();
            //----------------------------------------------------------------------------------------------------
            // Assert
            #if NUNIT && !NUNIT_LITE
            //CollectionAssert.AreEquivalent
            //(
            //    fc.ToList(),
            //    f
            //);
            Assert.AreEqual(fc.Count(), f.Count());
            for (int i = 0; i < fc.Count(); i++)
            {
                Assert.AreEqual
                            (
                                f.ElementAt(i).Key,
                                fc.ElementAt(i).Key
                            );
                Assert.AreEqual
                            (
                                f.ElementAt(i).Value.FrequencyAbsolute,
                                fc.ElementAt(i).Value.FrequencyAbsolute
                            );
                Assert.AreEqual
                            (
                                f.ElementAt(i).Value.FrequencyRelative,
                                fc.ElementAt(i).Value.FrequencyRelative,
                                0.000001
                            );
                Assert.AreEqual
                            (
                                f.ElementAt(i).Value.FrequencyCumulative,
                                fc.ElementAt(i).Value.FrequencyCumulative
                            );
            }
            #elif XUNIT
            //Assert.Equal
            //(
            //    fc.ToList(),
            //    f.ToArray()
            //);
            Assert.Equal(fc.Count(), f.Count());
            for (int i = 0; i < fc.Count(); i++)
            {
                Assert.Equal
                            (
                                f.ElementAt(i).Key,
                                fc.ElementAt(i).Key
                            );
                Assert.Equal
                            (
                                f.ElementAt(i).Value.FrequencyAbsolute,
                                fc.ElementAt(i).Value.FrequencyAbsolute
                            );
                Assert.Equal
                            (
                                f.ElementAt(i).Value.FrequencyRelative,
                                fc.ElementAt(i).Value.FrequencyRelative,
                                5
                            );
                Assert.Equal
                            (
                                f.ElementAt(i).Value.FrequencyCumulative,
                                fc.ElementAt(i).Value.FrequencyCumulative
                            );
            }
            #elif MSTEST
            Assert.AreEqual(fc.Count(), f.Count());
            for (int i = 0; i < fc.Count(); i++)
            {
                Assert.AreEqual
                            (
                                f.ElementAt(i).Key, 
                                fc.ElementAt(i).Key
                            );
                Assert.AreEqual
                            (
                                f.ElementAt(i).Value.FrequencyAbsolute, 
                                fc.ElementAt(i).Value.FrequencyAbsolute
                            );
                Assert.AreEqual
                            (
                                f.ElementAt(i).Value.FrequencyRelative,
                                fc.ElementAt(i).Value.FrequencyRelative,
                                0.000001
                            );
                Assert.AreEqual
                            (
                                f.ElementAt(i).Value.FrequencyCumulative,
                                fc.ElementAt(i).Value.FrequencyCumulative
                            );
            }
            #endif
            //====================================================================================================

            return;
        }

        [Benchmark]
        public 
            IEnumerable<KeyValuePair<int, (uint FrequencyAbsolute, double FrequencyRelative, uint FrequencyCumulative)>> 
                List_Frequencies
                    (
                    )
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
            IEnumerable<KeyValuePair<int, (uint FrequencyAbsolute, double FrequencyRelative, uint FrequencyCumulative)>> f;
            f = List_Frequencies();

            Console.WriteLine($"          frequencies        = {f}");
            Console.WriteLine($"          size               = {data.Count()}");
            Console.WriteLine($"          elapsed[ticks]     = {sw.ElapsedTicks}");
            Console.WriteLine($"          elapsed[ms]        = {sw.Elapsed.TotalMilliseconds}");
            sw.Reset();

            //----------------------------------------------------------------------------------------------------
            // Assert
#if NUNIT && !NUNIT_LITE
            //CollectionAssert.AreEquivalent
            //(
            //    fc.ToList(),
            //    f
            //);
            Assert.AreEqual(fc.Count(), f.Count());
            for (int i = 0; i < fc.Count(); i++)
            {
                Assert.AreEqual
                            (
                                f.ElementAt(i).Key,
                                fc.ElementAt(i).Key
                            );
                Assert.AreEqual
                            (
                                f.ElementAt(i).Value.FrequencyAbsolute,
                                fc.ElementAt(i).Value.FrequencyAbsolute
                            );
                Assert.AreEqual
                            (
                                f.ElementAt(i).Value.FrequencyRelative,
                                fc.ElementAt(i).Value.FrequencyRelative,
                                0.000001
                            );
                Assert.AreEqual
                            (
                                f.ElementAt(i).Value.FrequencyCumulative,
                                fc.ElementAt(i).Value.FrequencyCumulative
                            );
            }
            #elif XUNIT
            //Assert.Equal
            //(
            //    fc.ToList(),
            //    f.ToArray()
            //);
            Assert.Equal(fc.Count(), f.Count());
            for (int i = 0; i < fc.Count(); i++)
            {
                Assert.Equal
                            (
                                f.ElementAt(i).Key,
                                fc.ElementAt(i).Key
                            );
                Assert.Equal
                            (
                                f.ElementAt(i).Value.FrequencyAbsolute,
                                fc.ElementAt(i).Value.FrequencyAbsolute
                            );
                Assert.Equal
                            (
                                f.ElementAt(i).Value.FrequencyRelative,
                                fc.ElementAt(i).Value.FrequencyRelative,
                                5
                            );
                Assert.Equal
                            (
                                f.ElementAt(i).Value.FrequencyCumulative,
                                fc.ElementAt(i).Value.FrequencyCumulative
                            );
            }
            #elif MSTEST
            Assert.AreEqual(fc.Count(), f.Count());
            for (int i = 0; i < fc.Count(); i++)
            {
                Assert.AreEqual
                            (
                                f.ElementAt(i).Key, 
                                fc.ElementAt(i).Key
                            );
                Assert.AreEqual
                            (
                                f.ElementAt(i).Value.FrequencyAbsolute, 
                                fc.ElementAt(i).Value.FrequencyAbsolute
                            );
                Assert.AreEqual
                            (
                                f.ElementAt(i).Value.FrequencyRelative,
                                fc.ElementAt(i).Value.FrequencyRelative,
                                0.000001
                            );
                Assert.AreEqual
                            (
                                f.ElementAt(i).Value.FrequencyCumulative,
                                fc.ElementAt(i).Value.FrequencyCumulative
                            );
            }
            #endif
            //====================================================================================================

            return;
        }

        [Benchmark]
        public 
            IEnumerable<KeyValuePair<int, (uint FrequencyAbsolute, double FrequencyRelative, uint FrequencyCumulative)>> 
                Queue_Frequencies
                    (
                    )
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
            IEnumerable<KeyValuePair<int, (uint FrequencyAbsolute, double FrequencyRelative, uint FrequencyCumulative)>> f;
            f = Queue_Frequencies();

            sw.Stop();
            Console.WriteLine($"          frequencies        = {f}");
            Console.WriteLine($"          size               = {data.Count()}");
            Console.WriteLine($"          elapsed[ticks]     = {sw.ElapsedTicks}");
            Console.WriteLine($"          elapsed[ms]        = {sw.Elapsed.TotalMilliseconds}");
            sw.Reset();

            //----------------------------------------------------------------------------------------------------
            // Assert
            #if NUNIT && !NUNIT_LITE
            //CollectionAssert.AreEquivalent
            //(
            //    fc.ToList(),
            //    f
            //);
            Assert.AreEqual(fc.Count(), f.Count());
            for (int i = 0; i < fc.Count(); i++)
            {
                Assert.AreEqual
                            (
                                f.ElementAt(i).Key,
                                fc.ElementAt(i).Key
                            );
                Assert.AreEqual
                            (
                                f.ElementAt(i).Value.FrequencyAbsolute,
                                fc.ElementAt(i).Value.FrequencyAbsolute
                            );
                Assert.AreEqual
                            (
                                f.ElementAt(i).Value.FrequencyRelative,
                                fc.ElementAt(i).Value.FrequencyRelative,
                                0.000001
                            );
                Assert.AreEqual
                            (
                                f.ElementAt(i).Value.FrequencyCumulative,
                                fc.ElementAt(i).Value.FrequencyCumulative
                            );
            }
            #elif XUNIT
            //Assert.Equal
            //(
            //    fc.ToList(),
            //    f.ToArray()
            //);
            Assert.Equal(fc.Count(), f.Count());
            for (int i = 0; i < fc.Count(); i++)
            {
                Assert.Equal
                            (
                                f.ElementAt(i).Key,
                                fc.ElementAt(i).Key
                            );
                Assert.Equal
                            (
                                f.ElementAt(i).Value.FrequencyAbsolute,
                                fc.ElementAt(i).Value.FrequencyAbsolute
                            );
                Assert.Equal
                            (
                                f.ElementAt(i).Value.FrequencyRelative,
                                fc.ElementAt(i).Value.FrequencyRelative,
                                5
                            );
                Assert.Equal
                            (
                                f.ElementAt(i).Value.FrequencyCumulative,
                                fc.ElementAt(i).Value.FrequencyCumulative
                            );
            }
            #elif MSTEST
            Assert.AreEqual(fc.Count(), f.Count());
            for (int i = 0; i < fc.Count(); i++)
            {
                Assert.AreEqual
                            (
                                f.ElementAt(i).Key, 
                                fc.ElementAt(i).Key
                            );
                Assert.AreEqual
                            (
                                f.ElementAt(i).Value.FrequencyAbsolute, 
                                fc.ElementAt(i).Value.FrequencyAbsolute
                            );
                Assert.AreEqual
                            (
                                f.ElementAt(i).Value.FrequencyRelative,
                                fc.ElementAt(i).Value.FrequencyRelative,
                                0.000001
                            );
                Assert.AreEqual
                            (
                                f.ElementAt(i).Value.FrequencyCumulative,
                                fc.ElementAt(i).Value.FrequencyCumulative
                            );
            }
            #endif
            //====================================================================================================

            return;
        }

        [Benchmark]
        public 
            IEnumerable<KeyValuePair<int, (uint FrequencyAbsolute, double FrequencyRelative, uint FrequencyCumulative)>> 
                Stack_Frequencies
                    (
                    )
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
            IEnumerable<KeyValuePair<int, (uint FrequencyAbsolute, double FrequencyRelative, uint FrequencyCumulative)>> f;
            f = Stack_Frequencies();

            sw.Stop();
            Console.WriteLine($"          frequencies        = {f}");
            Console.WriteLine($"          size               = {data.Count()}");
            Console.WriteLine($"          elapsed[ticks]     = {sw.ElapsedTicks}");
            Console.WriteLine($"          elapsed[ms]        = {sw.Elapsed.TotalMilliseconds}");
            sw.Reset();

            //----------------------------------------------------------------------------------------------------
            // Assert
            #if NUNIT && !NUNIT_LITE
            //CollectionAssert.AreEquivalent
            //(
            //    fc.ToList(),
            //    f
            //);
            Assert.AreEqual(fc.Count(), f.Count());
            for (int i = 0; i < fc.Count(); i++)
            {
                Assert.AreEqual
                            (
                                f.ElementAt(i).Key,
                                fc.ElementAt(i).Key
                            );
                Assert.AreEqual
                            (
                                f.ElementAt(i).Value.FrequencyAbsolute,
                                fc.ElementAt(i).Value.FrequencyAbsolute
                            );
                Assert.AreEqual
                            (
                                f.ElementAt(i).Value.FrequencyRelative,
                                fc.ElementAt(i).Value.FrequencyRelative,
                                0.000001
                            );
                Assert.AreEqual
                            (
                                f.ElementAt(i).Value.FrequencyCumulative,
                                fc.ElementAt(i).Value.FrequencyCumulative
                            );
            }
            #elif XUNIT
            //Assert.Equal
            //(
            //    fc.ToList(),
            //    f.ToArray()
            //);
            Assert.Equal(fc.Count(), f.Count());
            for (int i = 0; i < fc.Count(); i++)
            {
                Assert.Equal
                            (
                                f.ElementAt(i).Key,
                                fc.ElementAt(i).Key
                            );
                Assert.Equal
                            (
                                f.ElementAt(i).Value.FrequencyAbsolute,
                                fc.ElementAt(i).Value.FrequencyAbsolute
                            );
                Assert.Equal
                            (
                                f.ElementAt(i).Value.FrequencyRelative,
                                fc.ElementAt(i).Value.FrequencyRelative,
                                5
                            );
                Assert.Equal
                            (
                                f.ElementAt(i).Value.FrequencyCumulative,
                                fc.ElementAt(i).Value.FrequencyCumulative
                            );
            }
            #elif MSTEST
            Assert.AreEqual(fc.Count(), f.Count());
            for (int i = 0; i < fc.Count(); i++)
            {
                Assert.AreEqual
                            (
                                f.ElementAt(i).Key, 
                                fc.ElementAt(i).Key
                            );
                Assert.AreEqual
                            (
                                f.ElementAt(i).Value.FrequencyAbsolute, 
                                fc.ElementAt(i).Value.FrequencyAbsolute
                            );
                Assert.AreEqual
                            (
                                f.ElementAt(i).Value.FrequencyRelative,
                                fc.ElementAt(i).Value.FrequencyRelative,
                                0.000001
                            );
                Assert.AreEqual
                            (
                                f.ElementAt(i).Value.FrequencyCumulative,
                                fc.ElementAt(i).Value.FrequencyCumulative
                            );
            }
            #endif
            //====================================================================================================

            return;
        }

        [Benchmark]
        public 
            IEnumerable<KeyValuePair<int, (uint FrequencyAbsolute, double FrequencyRelative, uint FrequencyCumulative)>> 
                LinkedList_Frequencies
                    (
                    )
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
            IEnumerable<KeyValuePair<int, (uint FrequencyAbsolute, double FrequencyRelative, uint FrequencyCumulative)>> f;
            f = LinkedList_Frequencies();

            sw.Stop();
            Console.WriteLine($"          frequencies        = {f}");
            Console.WriteLine($"          size               = {data.Count()}");
            Console.WriteLine($"          elapsed[ticks]     = {sw.ElapsedTicks}");
            Console.WriteLine($"          elapsed[ms]        = {sw.Elapsed.TotalMilliseconds}");
            sw.Reset();

            //----------------------------------------------------------------------------------------------------
            // Assert
            #if NUNIT && !NUNIT_LITE
            //CollectionAssert.AreEquivalent
            //(
            //    fc.ToList(),
            //    f
            //);
            Assert.AreEqual(fc.Count(), f.Count());
            for (int i = 0; i < fc.Count(); i++)
            {
                Assert.AreEqual
                            (
                                f.ElementAt(i).Key,
                                fc.ElementAt(i).Key
                            );
                Assert.AreEqual
                            (
                                f.ElementAt(i).Value.FrequencyAbsolute,
                                fc.ElementAt(i).Value.FrequencyAbsolute
                            );
                Assert.AreEqual
                            (
                                f.ElementAt(i).Value.FrequencyRelative,
                                fc.ElementAt(i).Value.FrequencyRelative,
                                0.000001
                            );
                Assert.AreEqual
                            (
                                f.ElementAt(i).Value.FrequencyCumulative,
                                fc.ElementAt(i).Value.FrequencyCumulative
                            );
            }
            #elif XUNIT
            //Assert.Equal
            //(
            //    fc.ToList(),
            //    f.ToArray()
            //);
            Assert.Equal(fc.Count(), f.Count());
            for (int i = 0; i < fc.Count(); i++)
            {
                Assert.Equal
                            (
                                f.ElementAt(i).Key,
                                fc.ElementAt(i).Key
                            );
                Assert.Equal
                            (
                                f.ElementAt(i).Value.FrequencyAbsolute,
                                fc.ElementAt(i).Value.FrequencyAbsolute
                            );
                Assert.Equal
                            (
                                f.ElementAt(i).Value.FrequencyRelative,
                                fc.ElementAt(i).Value.FrequencyRelative,
                                5
                            );
                Assert.Equal
                            (
                                f.ElementAt(i).Value.FrequencyCumulative,
                                fc.ElementAt(i).Value.FrequencyCumulative
                            );
            }
            #elif MSTEST
            Assert.AreEqual(fc.Count(), f.Count());
            for (int i = 0; i < fc.Count(); i++)
            {
                Assert.AreEqual
                            (
                                f.ElementAt(i).Key, 
                                fc.ElementAt(i).Key
                            );
                Assert.AreEqual
                            (
                                f.ElementAt(i).Value.FrequencyAbsolute, 
                                fc.ElementAt(i).Value.FrequencyAbsolute
                            );
                Assert.AreEqual
                            (
                                f.ElementAt(i).Value.FrequencyRelative,
                                fc.ElementAt(i).Value.FrequencyRelative,
                                0.000001
                            );
                Assert.AreEqual
                            (
                                f.ElementAt(i).Value.FrequencyCumulative,
                                fc.ElementAt(i).Value.FrequencyCumulative
                            );
            }
            #endif
            //====================================================================================================

            return;
        }

        [Benchmark]
        public 
            IEnumerable<KeyValuePair<int, (uint FrequencyAbsolute, double FrequencyRelative, uint FrequencyCumulative)>> 
                ObservableCollection_Frequencies
                    (
                    )
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
            IEnumerable<KeyValuePair<int, (uint FrequencyAbsolute, double FrequencyRelative, uint FrequencyCumulative)>> f;
            f = ObservableCollection_Frequencies();

            sw.Stop();
            Console.WriteLine($"          frequencies        = {f}");
            Console.WriteLine($"          size               = {data.Count()}");
            Console.WriteLine($"          elapsed[ticks]     = {sw.ElapsedTicks}");
            Console.WriteLine($"          elapsed[ms]        = {sw.Elapsed.TotalMilliseconds}");
            sw.Reset();

            //----------------------------------------------------------------------------------------------------
            // Assert
            #if NUNIT && !NUNIT_LITE
            //CollectionAssert.AreEquivalent
            //(
            //    fc.ToList(),
            //    f
            //);
            Assert.AreEqual(fc.Count(), f.Count());
            for (int i = 0; i < fc.Count(); i++)
            {
                Assert.AreEqual
                            (
                                f.ElementAt(i).Key,
                                fc.ElementAt(i).Key
                            );
                Assert.AreEqual
                            (
                                f.ElementAt(i).Value.FrequencyAbsolute,
                                fc.ElementAt(i).Value.FrequencyAbsolute
                            );
                Assert.AreEqual
                            (
                                f.ElementAt(i).Value.FrequencyRelative,
                                fc.ElementAt(i).Value.FrequencyRelative,
                                0.000001
                            );
                Assert.AreEqual
                            (
                                f.ElementAt(i).Value.FrequencyCumulative,
                                fc.ElementAt(i).Value.FrequencyCumulative
                            );
            }
            #elif XUNIT
            //Assert.Equal
            //(
            //    fc.ToList(),
            //    f.ToArray()
            //);
            Assert.Equal(fc.Count(), f.Count());
            for (int i = 0; i < fc.Count(); i++)
            {
                Assert.Equal
                            (
                                f.ElementAt(i).Key,
                                fc.ElementAt(i).Key
                            );
                Assert.Equal
                            (
                                f.ElementAt(i).Value.FrequencyAbsolute,
                                fc.ElementAt(i).Value.FrequencyAbsolute
                            );
                Assert.Equal
                            (
                                f.ElementAt(i).Value.FrequencyRelative,
                                fc.ElementAt(i).Value.FrequencyRelative,
                                5
                            );
                Assert.Equal
                            (
                                f.ElementAt(i).Value.FrequencyCumulative,
                                fc.ElementAt(i).Value.FrequencyCumulative
                            );
            }
            #elif MSTEST
            Assert.AreEqual(fc.Count(), f.Count());
            for (int i = 0; i < fc.Count(); i++)
            {
                Assert.AreEqual
                            (
                                f.ElementAt(i).Key, 
                                fc.ElementAt(i).Key
                            );
                Assert.AreEqual
                            (
                                f.ElementAt(i).Value.FrequencyAbsolute, 
                                fc.ElementAt(i).Value.FrequencyAbsolute
                            );
                Assert.AreEqual
                            (
                                f.ElementAt(i).Value.FrequencyRelative,
                                fc.ElementAt(i).Value.FrequencyRelative,
                                0.000001
                            );
                Assert.AreEqual
                            (
                                f.ElementAt(i).Value.FrequencyCumulative,
                                fc.ElementAt(i).Value.FrequencyCumulative
                            );
            }
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
            Span<int> data = 
                            new Span<int>(data01);
                            //data01.AsSpan().Slice(start: 0)
                            ;
            double f = data.Frequencies();
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
            Memory<int> data =
                            new Memory<int>(data01);
                            //data01.AsSpan().Slice(start: 0)
                            ;
            double f = data.Frequencies();
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
