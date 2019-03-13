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

using Core.Math.Statistics.Descriptive.Sequential;

namespace UnitTests.Core.Math.Statistics.Descriptive.Sequential.Sync
{
    public partial class Tests20180119Dataset02
    {
        [Benchmark]
        public double Array_MeanArithmeticWeighted()
        {
            return data_array.MeanArithmeticWeighted(weights);
        }

        [Test]
        public void Array_MeanArithmeticWeighted_Test()
        {
            Console.WriteLine($"Array_MeanArithmeticWeighted_Test");
            //====================================================================================================
            //  Arrange
            //  reading data from files

            sw = Stopwatch.StartNew();

            //----------------------------------------------------------------------------------------------------
            // Act
            //      extracted to atomic Benchmark method
            double mean = Array_MeanArithmeticWeighted();

            sw.Stop();
            Console.WriteLine($"Array<double>.MeanArithmeticWeighted()");
            Console.WriteLine($"          mean               = {mean}");
            Console.WriteLine($"          size               = {data_array.Count()}");
            Console.WriteLine($"          elapsed[ticks]     = {sw.ElapsedTicks}");
            Console.WriteLine($"          elapsed[ms]        = {sw.Elapsed.TotalMilliseconds}");
            sw.Reset();
            //----------------------------------------------------------------------------------------------------
            // Assert
            #if NUNIT
            Assert.AreEqual(15.93, mean, 0.00001);
            #elif XUNIT
            Assert.Equal(15.93, mean, 5);
            #elif MSTEST
            Assert.AreEqual(15.93, mean, 0.00001);
            #endif
            //====================================================================================================

            return;
        }

        [Benchmark]
        public double ArraySegment_MeanArithmeticWeighted()
        {
            return data_array_segment.MeanArithmeticWeighted(weights);
        }

        [Test]
        public void ArraySegment_MeanArithmeticWeighted_Test()
        {
            //====================================================================================================
            //  Arrange
            //  reading data from files

            sw = Stopwatch.StartNew();

            //----------------------------------------------------------------------------------------------------
            // Act
            //      extracted to atomic Benchmark method
            double mean = ArraySegment_MeanArithmeticWeighted();

            sw.Stop();
            Console.WriteLine($"          mean               = {mean}");
            Console.WriteLine($"          size               = {data.Count()}");
            Console.WriteLine($"          elapsed[ticks]     = {sw.ElapsedTicks}");
            Console.WriteLine($"          elapsed[ms]        = {sw.Elapsed.TotalMilliseconds}");
            sw.Reset();
            //----------------------------------------------------------------------------------------------------
            // Assert
            #if NUNIT
            Assert.AreEqual(15.93, mean, 0.00001);
            #elif XUNIT
            Assert.Equal(15.93, mean, 5);
            #elif MSTEST
            Assert.AreEqual(15.93, mean, 0.00001);
            #endif
            //====================================================================================================

            return;
        }

        [Benchmark]
        public double List_MeanArithmeticWeighted()
        {
            return data_list.MeanArithmeticWeighted(weights);
        }

        [Test]
        public void List_MeanArithmeticWeighted_Test()
        {
            //====================================================================================================
            //  Arrange
            //  reading data from files

            sw = Stopwatch.StartNew();

            //----------------------------------------------------------------------------------------------------
            // Act
            //      extracted to atomic Benchmark method
            double mean = List_MeanArithmeticWeighted();

            Console.WriteLine($"          mean               = {mean}");
            Console.WriteLine($"          size               = {data.Count()}");
            Console.WriteLine($"          elapsed[ticks]     = {sw.ElapsedTicks}");
            Console.WriteLine($"          elapsed[ms]        = {sw.Elapsed.TotalMilliseconds}");
            sw.Reset();
            //----------------------------------------------------------------------------------------------------
            // Assert
            #if NUNIT
            Assert.AreEqual(15.93, mean, 0.00001);
            #elif XUNIT
            Assert.Equal(15.93, mean, 5);
            #elif MSTEST
            Assert.AreEqual(15.93, mean, 0.00001);
            #endif
            //====================================================================================================

            return;
        }

        [Benchmark]
        public double Queue_MeanArithmeticWeighted()
        {
            return data_queue.MeanArithmeticWeighted(weights);
        }

        [Test]
        public void Queue_MeanArithmeticWeighted_Test()
        {
            //====================================================================================================
            //  Arrange

            sw = Stopwatch.StartNew();

            //----------------------------------------------------------------------------------------------------
            // Act
            //      extracted to atomic Benchmark method
            double mean = Queue_MeanArithmeticWeighted();

            sw.Stop();
            Console.WriteLine($"          mean               = {mean}");
            Console.WriteLine($"          size               = {data.Count()}");
            Console.WriteLine($"          elapsed[ticks]     = {sw.ElapsedTicks}");
            Console.WriteLine($"          elapsed[ms]        = {sw.Elapsed.TotalMilliseconds}");
            sw.Reset();
            //----------------------------------------------------------------------------------------------------
            // Assert
            #if NUNIT
            Assert.AreEqual(15.93, mean, 0.00001);
            #elif XUNIT
            Assert.Equal(15.93, mean, 5);
            #elif MSTEST
            Assert.AreEqual(15.93, mean, 0.00001);
            #endif
            //====================================================================================================

            return;
        }

        [Benchmark]
        public double Stack_MeanArithmeticWeighted()
        {
            return data_stack.MeanArithmeticWeighted(weights);
        }

        [Test]
        public void Stack_MeanArithmeticWeighted_Test()
        {
            //====================================================================================================
            //  Arrange
            //  reading data from files

            sw = Stopwatch.StartNew();

            //----------------------------------------------------------------------------------------------------
            // Act
            //      extracted to atomic Benchmark method
            double mean = Stack_MeanArithmeticWeighted();

            sw.Stop();
            Console.WriteLine($"          mean               = {mean}");
            Console.WriteLine($"          size               = {data.Count()}");
            Console.WriteLine($"          elapsed[ticks]     = {sw.ElapsedTicks}");
            Console.WriteLine($"          elapsed[ms]        = {sw.Elapsed.TotalMilliseconds}");
            sw.Reset();
            //----------------------------------------------------------------------------------------------------
            // Assert
            #if NUNIT
            Assert.AreEqual(15.93, mean, 0.00001);
            #elif XUNIT
            Assert.Equal(15.93, mean, 5);
            #elif MSTEST
            Assert.AreEqual(15.93, mean, 0.00001);
            #endif
            //====================================================================================================

            return;
        }

        [Benchmark]
        public double LinkedList_MeanArithmeticWeighted()
        {
            return data_linked_list.MeanArithmeticWeighted(weights);
        }

        [Test]
        public void LinkedList_MeanArithmeticWeighted_Test()
        {
            //====================================================================================================
            //  Arrange
            //  reading data from files

            sw = Stopwatch.StartNew();

            //----------------------------------------------------------------------------------------------------
            // Act
            //      extracted to atomic Benchmark method
            double mean = LinkedList_MeanArithmeticWeighted();

            sw.Stop();
            Console.WriteLine($"          mean               = {mean}");
            Console.WriteLine($"          size               = {data.Count()}");
            Console.WriteLine($"          elapsed[ticks]     = {sw.ElapsedTicks}");
            Console.WriteLine($"          elapsed[ms]        = {sw.Elapsed.TotalMilliseconds}");
            sw.Reset();
            //----------------------------------------------------------------------------------------------------
            // Assert
            #if NUNIT
            Assert.AreEqual(15.93, mean, 0.00001);
            #elif XUNIT
            Assert.Equal(15.93, mean, 5);
            #elif MSTEST
            Assert.AreEqual(15.93, mean, 0.00001);
            #endif
            //====================================================================================================

            return;
        }

        [Benchmark]
        public double ObservableCollection_MeanArithmeticWeighted()
        {
            return data_observable_collection.MeanArithmeticWeighted(weights);
        }

        [Test]
        public void ObservableCollection_MeanArithmeticWeighted_Test()
        {
            //====================================================================================================
            //  Arrange
            //  reading data from files

            sw = Stopwatch.StartNew();

            //----------------------------------------------------------------------------------------------------
            // Act
            //      extracted to atomic Benchmark method
            double mean = ObservableCollection_MeanArithmeticWeighted();

            sw.Stop();
            Console.WriteLine($"          mean               = {mean}");
            Console.WriteLine($"          size               = {data.Count()}");
            Console.WriteLine($"          elapsed[ticks]     = {sw.ElapsedTicks}");
            Console.WriteLine($"          elapsed[ms]        = {sw.Elapsed.TotalMilliseconds}");
            sw.Reset();
            //----------------------------------------------------------------------------------------------------
            // Assert
            #if NUNIT
            Assert.AreEqual(15.93, mean, 0.00001);
            #elif XUNIT
            Assert.Equal(15.93, mean, 5);
            #elif MSTEST
            Assert.AreEqual(15.93, mean, 0.00001);
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
        public void Span_MeanArithmeticWeighted()
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
            double mean = data.MeanArithmeticWeighted();
            sw.Stop();
            Console.WriteLine($"          mean               = {mean}");
            Console.WriteLine($"          size               = {data.Count()}");
            Console.WriteLine($"          elapsed[ticks]     = {sw.ElapsedTicks}");
            Console.WriteLine($"          elapsed[ms]        = {sw.Elapsed.TotalMilliseconds}");
            sw.Reset();
            //----------------------------------------------------------------------------------------------------
            // Assert
            #if NUNIT
            Assert.AreEqual(15.93, mean, 0.00001);
            #elif XUNIT
            Assert.Equal(15.93, mean, 5);
            #elif MSTEST
            Assert.AreEqual(15.93, mean, 0.00001);
            #endif
            //====================================================================================================

            return;
        }

        [Test]
        public void Span_MeanArithmeticWeighted()
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
            double mean = data.MeanArithmeticWeighted();
            sw.Stop();
            Console.WriteLine($"          mean               = {mean}");
            Console.WriteLine($"          size               = {data.Count()}");
            Console.WriteLine($"          elapsed[ticks]     = {sw.ElapsedTicks}");
            Console.WriteLine($"          elapsed[ms]        = {sw.Elapsed.TotalMilliseconds}");
            sw.Reset();
            //----------------------------------------------------------------------------------------------------
            // Assert
            #if NUNIT
            Assert.AreEqual(15.93, mean, 0.00001);
            #elif XUNIT
            Assert.Equal(15.93, mean, 5);
            #elif MSTEST
            Assert.AreEqual(15.93, mean, 0.00001);
            #endif
            //====================================================================================================

            return;
        }
        */
    }
}
