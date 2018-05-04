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
using System;

using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

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

using Core.Math.Statistics.Descriptive.Sequential;

namespace UnitTests.Core.Math.Statistics.Descriptive.Sequential.Sync
{
    public partial class Tests20180119Dataset03
    {
        [Test]
        public void Array_MeanGeometricWeighted()
        {
            //====================================================================================================
            //  Arrange
            //  reading data from files

            sw = Stopwatch.StartNew();

            //----------------------------------------------------------------------------------------------------
            // Act
            int[] data = Tests20180119Dataset03.data.ToArray();
            double mean = data.MeanGeometricWeighted(weights);
            sw.Stop();
            Console.WriteLine($"Array<double>.MeanGeometricWeighted()");
            Console.WriteLine($"          mean               = {mean}");
            Console.WriteLine($"          size               = {data.Count()}");
            Console.WriteLine($"          elapsed[ticks]     = {sw.ElapsedTicks}");
            Console.WriteLine($"          elapsed[ms]        = {sw.Elapsed.TotalMilliseconds}");
            sw.Reset();
            //----------------------------------------------------------------------------------------------------
            // Assert
            #if NUNIT
            Assert.AreEqual(176.44808, mean, 0.00001);
            #elif XUNIT
            Assert.Equal(176.44808, mean, 5);
            #elif MSTEST
            Assert.AreEqual(176.44808, mean, 0.00001);
            #endif
            //====================================================================================================

            return;
        }

        [Test]
        public void ArraySegment_MeanGeometricWeighted()
        {
            //====================================================================================================
            //  Arrange
            //  reading data from files

            sw = Stopwatch.StartNew();

            //----------------------------------------------------------------------------------------------------
            // Act
            ArraySegment<int> data_array_segment = new ArraySegment<int>(data);
            double mean = data.MeanGeometricWeighted(weights);
            sw.Stop();
            Console.WriteLine($"          mean               = {mean}");
            Console.WriteLine($"          size               = {data.Count()}");
            Console.WriteLine($"          elapsed[ticks]     = {sw.ElapsedTicks}");
            Console.WriteLine($"          elapsed[ms]        = {sw.Elapsed.TotalMilliseconds}");
            sw.Reset();
            //----------------------------------------------------------------------------------------------------
            // Assert
            #if NUNIT
            Assert.AreEqual(176.44808, mean, 0.00001);
            #elif XUNIT
            Assert.Equal(176.44808, mean, 5);
            #elif MSTEST
            Assert.AreEqual(176.44808, mean, 0.00001);
            #endif
            //====================================================================================================

            return;
        }

        [Test]
        public void List_MeanGeometricWeighted()
        {
            //====================================================================================================
            //  Arrange
            //  reading data from files

            sw = Stopwatch.StartNew();

            //----------------------------------------------------------------------------------------------------
            // Act
            List<int> data_list = new List<int>(data);
            double mean = data.MeanGeometricWeighted(weights);
            sw.Stop();
            Console.WriteLine($"          mean               = {mean}");
            Console.WriteLine($"          size               = {data.Count()}");
            Console.WriteLine($"          elapsed[ticks]     = {sw.ElapsedTicks}");
            Console.WriteLine($"          elapsed[ms]        = {sw.Elapsed.TotalMilliseconds}");
            sw.Reset();
            //----------------------------------------------------------------------------------------------------
            // Assert
            #if NUNIT
            Assert.AreEqual(176.44808, mean, 0.00001);
            #elif XUNIT
            Assert.Equal(176.44808, mean, 5);
            #elif MSTEST
            Assert.AreEqual(176.44808, mean, 0.00001);
            #endif
            //====================================================================================================

            return;
        }

        [Test]
        public void Queue_MeanGeometricWeighted()
        {
            //====================================================================================================
            //  Arrange
            //  reading data from files

            sw = Stopwatch.StartNew();

            //----------------------------------------------------------------------------------------------------
            // Act
            data_queue = new Queue<int>(data);
            double mean = data.MeanGeometricWeighted(weights);
            sw.Stop();
            Console.WriteLine($"          mean               = {mean}");
            Console.WriteLine($"          size               = {data.Count()}");
            Console.WriteLine($"          elapsed[ticks]     = {sw.ElapsedTicks}");
            Console.WriteLine($"          elapsed[ms]        = {sw.Elapsed.TotalMilliseconds}");
            sw.Reset();
            //----------------------------------------------------------------------------------------------------
            // Assert
            #if NUNIT
            Assert.AreEqual(176.44808, mean, 0.00001);
            #elif XUNIT
            Assert.Equal(176.44808, mean, 5);
            #elif MSTEST
            Assert.AreEqual(176.44808, mean, 0.00001);
            #endif
            //====================================================================================================

            return;
        }

        [Test]
        public void Stack_MeanGeometricWeighted()
        {
            //====================================================================================================
            //  Arrange
            //  reading data from files

            sw = Stopwatch.StartNew();

            //----------------------------------------------------------------------------------------------------
            // Act
            data_stack = new Stack<int>(data);
            double mean = data.MeanGeometricWeighted(weights);
            sw.Stop();
            Console.WriteLine($"          mean               = {mean}");
            Console.WriteLine($"          size               = {data.Count()}");
            Console.WriteLine($"          elapsed[ticks]     = {sw.ElapsedTicks}");
            Console.WriteLine($"          elapsed[ms]        = {sw.Elapsed.TotalMilliseconds}");
            sw.Reset();
            //----------------------------------------------------------------------------------------------------
            // Assert
            #if NUNIT
            Assert.AreEqual(176.44808, mean, 0.00001);
            #elif XUNIT
            Assert.Equal(176.44808, mean, 5);
            #elif MSTEST
            Assert.AreEqual(176.44808, mean, 0.00001);
            #endif
            //====================================================================================================

            return;
        }

        [Test]
            public void LinkedList_MeanGeometricWeighted()
        {
            //====================================================================================================
            //  Arrange
            //  reading data from files

            sw = Stopwatch.StartNew();

            //----------------------------------------------------------------------------------------------------
            // Act
            LinkedList<int> data_list = new LinkedList<int>(data);
            double mean = data.MeanGeometricWeighted(weights);
            sw.Stop();
            Console.WriteLine($"          mean               = {mean}");
            Console.WriteLine($"          size               = {data.Count()}");
            Console.WriteLine($"          elapsed[ticks]     = {sw.ElapsedTicks}");
            Console.WriteLine($"          elapsed[ms]        = {sw.Elapsed.TotalMilliseconds}");
            sw.Reset();
            //----------------------------------------------------------------------------------------------------
            // Assert
            #if NUNIT
            Assert.AreEqual(176.44808, mean, 0.00001);
            #elif XUNIT
            Assert.Equal(176.44808, mean, 5);
            #elif MSTEST
            Assert.AreEqual(176.44808, mean, 0.00001);
            #endif
            //====================================================================================================

            return;
        }

        [Test]
        public void ObservableCollection_MeanGeometricWeighted()
        {
            //====================================================================================================
            //  Arrange
            //  reading data from files

            sw = Stopwatch.StartNew();

            //----------------------------------------------------------------------------------------------------
            // Act
            data_observable_collection =  new ObservableCollection<int>(data);
            double mean = data.MeanGeometricWeighted(weights);
            sw.Stop();
            Console.WriteLine($"          mean               = {mean}");
            Console.WriteLine($"          size               = {data.Count()}");
            Console.WriteLine($"          elapsed[ticks]     = {sw.ElapsedTicks}");
            Console.WriteLine($"          elapsed[ms]        = {sw.Elapsed.TotalMilliseconds}");
            sw.Reset();
            //----------------------------------------------------------------------------------------------------
            // Assert
            #if NUNIT
            Assert.AreEqual(176.44808, mean, 0.00001);
            #elif XUNIT
            Assert.Equal(176.44808, mean, 5);
            #elif MSTEST
            Assert.AreEqual(176.44808, mean, 0.00001);
            #endif
            //====================================================================================================

            return;
        }

        [Test]
        public void HashSet_MeanGeometricWeighted()
        {
            //====================================================================================================
            //  Arrange
            //  reading data from files

            sw = Stopwatch.StartNew();

            //----------------------------------------------------------------------------------------------------
            // Act
            data_hash_set =  new HashSet<int>(data);
            double[] weights1 = Enumerable.Repeat(1.0, data_hash_set.Count).ToArray();
            double mean = data.MeanGeometricWeighted(weights1);
            sw.Stop();
            Console.WriteLine($"          mean               = {mean}");
            Console.WriteLine($"          size               = {data.Count()}");
            Console.WriteLine($"          elapsed[ticks]     = {sw.ElapsedTicks}");
            Console.WriteLine($"          elapsed[ms]        = {sw.Elapsed.TotalMilliseconds}");
            sw.Reset();
            //----------------------------------------------------------------------------------------------------
            // Assert
            #if NUNIT
            Assert.AreEqual(2.60517, mean, 0.00001);
            #elif XUNIT
            Assert.Equal(2.60517, mean, 5);
            #elif MSTEST
            Assert.AreEqual(2.60517, mean, 0.00001);
            #endif
            //====================================================================================================

            return;
        }

        [Test]
        public void SortedSet_MeanGeometricWeighted()
        {
            //====================================================================================================
            //  Arrange
            //  reading data from files

            sw = Stopwatch.StartNew();

            //----------------------------------------------------------------------------------------------------
            // Act
            data_sorted_set =  new SortedSet<int>(data);
            double[] weights1 = Enumerable.Repeat(1.0, data_sorted_set.Count).ToArray();
            double mean = data.MeanGeometricWeighted(weights1);
            sw.Stop();
            Console.WriteLine($"          mean               = {mean}");
            Console.WriteLine($"          size               = {data.Count()}");
            Console.WriteLine($"          elapsed[ticks]     = {sw.ElapsedTicks}");
            Console.WriteLine($"          elapsed[ms]        = {sw.Elapsed.TotalMilliseconds}");
            sw.Reset();
            //----------------------------------------------------------------------------------------------------
            // Assert
            #if NUNIT
            Assert.AreEqual(2.60517, mean, 0.00001);
            #elif XUNIT
            Assert.Equal(2.60517, mean, 5);
            #elif MSTEST
            Assert.AreEqual(2.60517, mean, 0.00001);
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
        public void Span_MeanGeometricWeighted()
        {
            //====================================================================================================
            //  Arrange
            //  reading data from files

            sw = Stopwatch.StartNew();

            //----------------------------------------------------------------------------------------------------
            // Act
            Span<int> data = data01.AsSpan().Slice(start: 20);
            Span<int> data = new Span<int>(arr, 20, arr.Length – 20);
            double mean = data.MeanGeometricWeighted(weights);
            sw.Stop();
            Console.WriteLine($"          mean               = {mean}");
            Console.WriteLine($"          size               = {data.Count()}");
            Console.WriteLine($"          elapsed[ticks]     = {sw.ElapsedTicks}");
            Console.WriteLine($"          elapsed[ms]        = {sw.Elapsed.TotalMilliseconds}");
            sw.Reset();
            //----------------------------------------------------------------------------------------------------
            // Assert
            #if NUNIT
            Assert.AreEqual(176.44808, mean, 0.00001);
            #elif XUNIT
            Assert.Equal(176.44808, mean, 5);
            #elif MSTEST
            Assert.AreEqual(176.44808, mean, 0.00001);
            #endif
            //====================================================================================================

            return;
        }
        */

    }
}
