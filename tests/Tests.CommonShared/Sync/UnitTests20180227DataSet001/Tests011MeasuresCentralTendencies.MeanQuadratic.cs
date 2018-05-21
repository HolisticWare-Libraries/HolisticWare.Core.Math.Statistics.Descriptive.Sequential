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
using TestContext = HolisticWare.Core.Testing.UnitTests.TestContext;
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
using System.Threading.Tasks;
using System.IO;
using System.Reflection;

using Core.Math.Statistics.Descriptive.Sequential;

namespace UnitTests.Core.Math.Statistics.Descriptive.Sequential.Sync
{
    public partial class UnitTests20180227DataSet001
    {
        [Benchmark]
        public double Array_MeanQuadratic()
        {
            return data_array.MeanQuadratic();
        }

        [Test]
        public void Array_MeanQuadratic_Test()
        {
            Console.WriteLine($"Array_MeanQuadratic_Test");
            //====================================================================================================
            //  Arrange
            //  reading data from files

            sw = Stopwatch.StartNew();

            //----------------------------------------------------------------------------------------------------
            // Act
            //      extracted to atomic Benchmark method
            double mean = Array_MeanQuadratic();

            sw.Stop();
            Console.WriteLine($"Array<double>.MeanQuadratic()");
            Console.WriteLine($"          mean               = {mean}");
            Console.WriteLine($"          size               = {data_array.Count()}");
            Console.WriteLine($"          elapsed[ticks]     = {sw.ElapsedTicks}");
            Console.WriteLine($"          elapsed[ms]        = {sw.Elapsed.TotalMilliseconds}");
            sw.Reset();
            //----------------------------------------------------------------------------------------------------
            // Assert
            #if NUNIT
            Assert.AreEqual(4.19523539268, mean, 0.01);
            #elif XUNIT
            Assert.Equal(4.19523539268, mean, 5);
            #elif MSTEST
            Assert.AreEqual(4.19523539268, mean, 0.01);
            #endif
            //====================================================================================================

            return;
        }

        [Benchmark]
        public double ArraySegment_MeanQuadratic()
        {
            return data_array_segment.MeanQuadratic();
        }

        [Test]
        public void ArraySegment_MeanQuadratic_Test()
        {
            //====================================================================================================
            //  Arrange
            //  reading data from files

            sw = Stopwatch.StartNew();

            //----------------------------------------------------------------------------------------------------
            // Act
            //      extracted to atomic Benchmark method
            double mean = ArraySegment_MeanQuadratic();

            sw.Stop();
            Console.WriteLine($"          mean               = {mean}");
            Console.WriteLine($"          size               = {data.Count()}");
            Console.WriteLine($"          elapsed[ticks]     = {sw.ElapsedTicks}");
            Console.WriteLine($"          elapsed[ms]        = {sw.Elapsed.TotalMilliseconds}");
            sw.Reset();
            //----------------------------------------------------------------------------------------------------
            // Assert
            #if NUNIT
            Assert.AreEqual(4.19523539268, mean, 0.01);
            #elif XUNIT
            Assert.Equal(4.19523539268, mean, 5);
            #elif MSTEST
            Assert.AreEqual(4.19523539268, mean, 0.01);
            #endif
            //====================================================================================================

            return;
        }

        [Benchmark]
        public double List_MeanQuadratic()
        {
            return data_list.MeanQuadratic();
        }

        [Test]
        public void List_MeanQuadratic_Test()
        {
            //====================================================================================================
            //  Arrange
            //  reading data from files

            sw = Stopwatch.StartNew();

            //----------------------------------------------------------------------------------------------------
            // Act
            //      extracted to atomic Benchmark method
            double mean = List_MeanQuadratic();

            Console.WriteLine($"          mean               = {mean}");
            Console.WriteLine($"          size               = {data.Count()}");
            Console.WriteLine($"          elapsed[ticks]     = {sw.ElapsedTicks}");
            Console.WriteLine($"          elapsed[ms]        = {sw.Elapsed.TotalMilliseconds}");
            sw.Reset();
            //----------------------------------------------------------------------------------------------------
            // Assert
            #if NUNIT
            Assert.AreEqual(4.19523539268, mean, 0.01);
            #elif XUNIT
            Assert.Equal(4.19523539268, mean, 5);
            #elif MSTEST
            Assert.AreEqual(4.19523539268, mean, 0.01);
            #endif
            //====================================================================================================

            return;
        }

        [Benchmark]
        public double Queue_MeanQuadratic()
        {
            return data_queue.MeanQuadratic();
        }

        [Test]
        public void Queue_MeanQuadratic_Test()
        {
            //====================================================================================================
            //  Arrange

            sw = Stopwatch.StartNew();

            //----------------------------------------------------------------------------------------------------
            // Act
            //      extracted to atomic Benchmark method
            double mean = Queue_MeanQuadratic();

            sw.Stop();
            Console.WriteLine($"          mean               = {mean}");
            Console.WriteLine($"          size               = {data.Count()}");
            Console.WriteLine($"          elapsed[ticks]     = {sw.ElapsedTicks}");
            Console.WriteLine($"          elapsed[ms]        = {sw.Elapsed.TotalMilliseconds}");
            sw.Reset();
            //----------------------------------------------------------------------------------------------------
            // Assert
            #if NUNIT
            Assert.AreEqual(4.19523539268, mean, 0.01);
            #elif XUNIT
            Assert.Equal(4.19523539268, mean, 5);
            #elif MSTEST
            Assert.AreEqual(4.19523539268, mean, 0.01);
            #endif
            //====================================================================================================

            return;
        }

        [Benchmark]
        public double Stack_MeanQuadratic()
        {
            return data_stack.MeanQuadratic();
        }

        [Test]
        public void Stack_MeanQuadratic_Test()
        {
            //====================================================================================================
            //  Arrange
            //  reading data from files

            sw = Stopwatch.StartNew();

            //----------------------------------------------------------------------------------------------------
            // Act
            //      extracted to atomic Benchmark method
            double mean = Stack_MeanQuadratic();

            sw.Stop();
            Console.WriteLine($"          mean               = {mean}");
            Console.WriteLine($"          size               = {data.Count()}");
            Console.WriteLine($"          elapsed[ticks]     = {sw.ElapsedTicks}");
            Console.WriteLine($"          elapsed[ms]        = {sw.Elapsed.TotalMilliseconds}");
            sw.Reset();
            //----------------------------------------------------------------------------------------------------
            // Assert
            #if NUNIT
            Assert.AreEqual(4.19523539268, mean, 0.01);
            #elif XUNIT
            Assert.Equal(4.19523539268, mean, 5);
            #elif MSTEST
            Assert.AreEqual(4.19523539268, mean, 0.01);
            #endif
            //====================================================================================================

            return;
        }

        [Benchmark]
        public double LinkedList_MeanQuadratic()
        {
            return data_linked_list.MeanQuadratic();
        }

        [Test]
        public void LinkedList_MeanQuadratic_Test()
        {
            //====================================================================================================
            //  Arrange
            //  reading data from files

            sw = Stopwatch.StartNew();

            //----------------------------------------------------------------------------------------------------
            // Act
            //      extracted to atomic Benchmark method
            double mean = LinkedList_MeanQuadratic();

            sw.Stop();
            Console.WriteLine($"          mean               = {mean}");
            Console.WriteLine($"          size               = {data.Count()}");
            Console.WriteLine($"          elapsed[ticks]     = {sw.ElapsedTicks}");
            Console.WriteLine($"          elapsed[ms]        = {sw.Elapsed.TotalMilliseconds}");
            sw.Reset();
            //----------------------------------------------------------------------------------------------------
            // Assert
            #if NUNIT
            Assert.AreEqual(4.19523539268, mean, 0.01);
            #elif XUNIT
            Assert.Equal(4.19523539268, mean, 5);
            #elif MSTEST
            Assert.AreEqual(4.19523539268, mean, 0.01);
            #endif
            //====================================================================================================

            return;
        }

        [Benchmark]
        public double ObservableCollection_MeanQuadratic()
        {
            return data_observable_collection.MeanQuadratic();
        }

        [Test]
        public void ObservableCollection_MeanQuadratic_Test()
        {
            //====================================================================================================
            //  Arrange
            //  reading data from files

            sw = Stopwatch.StartNew();

            //----------------------------------------------------------------------------------------------------
            // Act
            //      extracted to atomic Benchmark method
            double mean = ObservableCollection_MeanQuadratic();

            sw.Stop();
            Console.WriteLine($"          mean               = {mean}");
            Console.WriteLine($"          size               = {data.Count()}");
            Console.WriteLine($"          elapsed[ticks]     = {sw.ElapsedTicks}");
            Console.WriteLine($"          elapsed[ms]        = {sw.Elapsed.TotalMilliseconds}");
            sw.Reset();
            //----------------------------------------------------------------------------------------------------
            // Assert
            #if NUNIT
            Assert.AreEqual(4.19523539268, mean, 0.01);
            #elif XUNIT
            Assert.Equal(4.19523539268, mean, 5);
            #elif MSTEST
            Assert.AreEqual(4.19523539268, mean, 0.01);
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
        public void Span_MeanQuadratic()
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
            double mean = data.MeanQuadratic();
            sw.Stop();
            Console.WriteLine($"          mean               = {mean}");
            Console.WriteLine($"          size               = {data.Count()}");
            Console.WriteLine($"          elapsed[ticks]     = {sw.ElapsedTicks}");
            Console.WriteLine($"          elapsed[ms]        = {sw.Elapsed.TotalMilliseconds}");
            sw.Reset();
            //----------------------------------------------------------------------------------------------------
            // Assert
            #if NUNIT
            Assert.AreEqual(4.19523539268, mean, 0.01);
            #elif XUNIT
            Assert.Equal(4.19523539268, mean, 5);
            #elif MSTEST
            Assert.AreEqual(4.19523539268, mean, 0.01);
            #endif
            //====================================================================================================

            return;
        }

        [Test]
        public void Span_MeanQuadratic()
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
            double mean = data.MeanQuadratic();
            sw.Stop();
            Console.WriteLine($"          mean               = {mean}");
            Console.WriteLine($"          size               = {data.Count()}");
            Console.WriteLine($"          elapsed[ticks]     = {sw.ElapsedTicks}");
            Console.WriteLine($"          elapsed[ms]        = {sw.Elapsed.TotalMilliseconds}");
            sw.Reset();
            //----------------------------------------------------------------------------------------------------
            // Assert
            #if NUNIT
            Assert.AreEqual(4.19523539268, mean, 0.01);
            #elif XUNIT
            Assert.Equal(4.19523539268, mean, 5);
            #elif MSTEST
            Assert.AreEqual(4.19523539268, mean, 0.01);
            #endif
            //====================================================================================================

            return;
        }
        */
    }
}
