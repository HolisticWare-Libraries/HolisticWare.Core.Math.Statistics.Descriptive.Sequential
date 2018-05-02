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
    public partial class Tests20180119Dataset02
    {
        [Test]
        public void Array_MeanHarmonicWeighted()
        {
            //====================================================================================================
            //  Arrange
            //  reading data from files

            sw = Stopwatch.StartNew();

            //----------------------------------------------------------------------------------------------------
            // Act
            double[] data = data01.ToArray();
            double mean = data.MeanHarmonicWeighted(weights);
            sw.Stop();
            Console.WriteLine($"Array<double>.MeanHarmonicWeighted()");
            Console.WriteLine($"          mean               = {mean}");
            Console.WriteLine($"          size               = {data.Count()}");
            Console.WriteLine($"          elapsed[ticks]     = {sw.ElapsedTicks}");
            Console.WriteLine($"          elapsed[ms]        = {sw.Elapsed.TotalMilliseconds}");
            sw.Reset();
            //----------------------------------------------------------------------------------------------------
            // Assert
            #if NUNIT
            Assert.AreEqual(15.29597, mean, 0.00001);
            #elif XUNIT
            Assert.Equal(15.29597, mean, 5);
            #elif MSTEST
            Assert.AreEqual(15.29597, mean, 0.00001);
            #endif
            //====================================================================================================

            return;
        }

        [Test]
        public void ArraySegment_MeanHarmonicWeighted()
        {
            //====================================================================================================
            //  Arrange
            //  reading data from files

            sw = Stopwatch.StartNew();

            //----------------------------------------------------------------------------------------------------
            // Act
            ArraySegment<double> data = new ArraySegment<double>(data01);
            double mean = data.MeanHarmonicWeighted(weights);
            sw.Stop();
            Console.WriteLine($"          mean               = {mean}");
            Console.WriteLine($"          size               = {data.Count()}");
            Console.WriteLine($"          elapsed[ticks]     = {sw.ElapsedTicks}");
            Console.WriteLine($"          elapsed[ms]        = {sw.Elapsed.TotalMilliseconds}");
            sw.Reset();
            //----------------------------------------------------------------------------------------------------
            // Assert
            #if NUNIT
            Assert.AreEqual(15.29597, mean, 0.00001);
            #elif XUNIT
            Assert.Equal(15.29597, mean, 5);
            #elif MSTEST
            Assert.AreEqual(15.29597, mean, 0.00001);
            #endif
            //====================================================================================================

            return;
        }

        [Test]
        public void List_MeanHarmonicWeighted()
        {
            //====================================================================================================
            //  Arrange
            //  reading data from files

            sw = Stopwatch.StartNew();

            //----------------------------------------------------------------------------------------------------
            // Act
            List<double> data = new List<double>(data01);
            double mean = data.MeanHarmonicWeighted(weights);
            sw.Stop();
            Console.WriteLine($"          mean               = {mean}");
            Console.WriteLine($"          size               = {data.Count()}");
            Console.WriteLine($"          elapsed[ticks]     = {sw.ElapsedTicks}");
            Console.WriteLine($"          elapsed[ms]        = {sw.Elapsed.TotalMilliseconds}");
            sw.Reset();
            //----------------------------------------------------------------------------------------------------
            // Assert
            #if NUNIT
            Assert.AreEqual(15.29597, mean, 0.00001);
            #elif XUNIT
            Assert.Equal(15.29597, mean, 5);
            #elif MSTEST
            Assert.AreEqual(15.29597, mean, 0.00001);
            #endif
            //====================================================================================================

            return;
        }

        [Test]
        public void Queue_MeanHarmonicWeighted()
        {
            //====================================================================================================
            //  Arrange
            //  reading data from files

            sw = Stopwatch.StartNew();

            //----------------------------------------------------------------------------------------------------
            // Act
            Queue<double> data = new Queue<double>(data01);
            double mean = data.MeanHarmonicWeighted(weights);
            sw.Stop();
            Console.WriteLine($"          mean               = {mean}");
            Console.WriteLine($"          size               = {data.Count()}");
            Console.WriteLine($"          elapsed[ticks]     = {sw.ElapsedTicks}");
            Console.WriteLine($"          elapsed[ms]        = {sw.Elapsed.TotalMilliseconds}");
            sw.Reset();
            //----------------------------------------------------------------------------------------------------
            // Assert
            #if NUNIT
            Assert.AreEqual(15.29597, mean, 0.00001);
            #elif XUNIT
            Assert.Equal(15.29597, mean, 5);
            #elif MSTEST
            Assert.AreEqual(15.29597, mean, 0.00001);
            #endif
            //====================================================================================================

            return;
        }

        [Test]
        public void Stack_MeanHarmonicWeighted()
        {
            //====================================================================================================
            //  Arrange
            //  reading data from files

            sw = Stopwatch.StartNew();

            //----------------------------------------------------------------------------------------------------
            // Act
            Stack<double> data = new Stack<double>(data01);
            double mean = data.MeanHarmonicWeighted(weights);
            sw.Stop();
            Console.WriteLine($"          mean               = {mean}");
            Console.WriteLine($"          size               = {data.Count()}");
            Console.WriteLine($"          elapsed[ticks]     = {sw.ElapsedTicks}");
            Console.WriteLine($"          elapsed[ms]        = {sw.Elapsed.TotalMilliseconds}");
            sw.Reset();
            //----------------------------------------------------------------------------------------------------
            // Assert
            #if NUNIT
            Assert.AreEqual(15.29597, mean, 0.00001);
            #elif XUNIT
            Assert.Equal(15.29597, mean, 5);
            #elif MSTEST
            Assert.AreEqual(15.29597, mean, 0.00001);
            #endif
            //====================================================================================================

            return;
        }

        [Test]
            public void LinkedList_MeanHarmonicWeighted()
        {
            //====================================================================================================
            //  Arrange
            //  reading data from files

            sw = Stopwatch.StartNew();

            //----------------------------------------------------------------------------------------------------
            // Act
            LinkedList<double> data = new LinkedList<double>(data01);
            double mean = data.MeanHarmonicWeighted(weights);
            sw.Stop();
            Console.WriteLine($"          mean               = {mean}");
            Console.WriteLine($"          size               = {data.Count()}");
            Console.WriteLine($"          elapsed[ticks]     = {sw.ElapsedTicks}");
            Console.WriteLine($"          elapsed[ms]        = {sw.Elapsed.TotalMilliseconds}");
            sw.Reset();
            //----------------------------------------------------------------------------------------------------
            // Assert
            #if NUNIT
            Assert.AreEqual(15.29597, mean, 0.00001);
            #elif XUNIT
            Assert.Equal(15.29597, mean, 5);
            #elif MSTEST
            Assert.AreEqual(15.29597, mean, 0.00001);
            #endif
            //====================================================================================================

            return;
        }

        [Test]
        public void ObservableCollection_MeanHarmonicWeighted()
        {
            //====================================================================================================
            //  Arrange
            //  reading data from files

            sw = Stopwatch.StartNew();

            //----------------------------------------------------------------------------------------------------
            // Act
            ObservableCollection<double> data = new ObservableCollection<double>(data01);
            double mean = data.MeanHarmonicWeighted(weights);
            sw.Stop();
            Console.WriteLine($"          mean               = {mean}");
            Console.WriteLine($"          size               = {data.Count()}");
            Console.WriteLine($"          elapsed[ticks]     = {sw.ElapsedTicks}");
            Console.WriteLine($"          elapsed[ms]        = {sw.Elapsed.TotalMilliseconds}");
            sw.Reset();
            //----------------------------------------------------------------------------------------------------
            // Assert
            #if NUNIT
            Assert.AreEqual(15.29597, mean, 0.00001);
            #elif XUNIT
            Assert.Equal(15.29597, mean, 5);
            #elif MSTEST
            Assert.AreEqual(15.29597, mean, 0.00001);
            #endif
            //====================================================================================================

            return;
        }

        [Test]
        public void HashSet_MeanHarmonicWeighted()
        {
            //====================================================================================================
            //  Arrange
            //  reading data from files

            sw = Stopwatch.StartNew();

            //----------------------------------------------------------------------------------------------------
            // Act
            HashSet<double> data = new HashSet<double>(data01);
            double[] weights1 = Enumerable.Repeat(1.0, data.Count).ToArray();
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
            Assert.AreEqual(2.18978, mean, 0.00001);
            #elif XUNIT
            Assert.Equal(2.18978, mean, 5);
            #elif MSTEST
            Assert.AreEqual(2.18978, mean, 0.00001);
            #endif
            //====================================================================================================

            return;
        }

        [Test]
        public void SortedSet_MeanHarmonicWeighted()
        {
            //====================================================================================================
            //  Arrange
            //  reading data from files

            sw = Stopwatch.StartNew();

            //----------------------------------------------------------------------------------------------------
            // Act
            SortedSet<double> data = new SortedSet<double>(data01);
            double[] weights1 = Enumerable.Repeat(1.0, data.Count).ToArray();
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
            Assert.AreEqual(2.18978, mean, 0.00001);
            #elif XUNIT
            Assert.Equal(2.18978, mean, 5);
            #elif MSTEST
            Assert.AreEqual(2.18978, mean, 0.00001);
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
        public void Span_MeanHarmonicWeighted()
        {
            //====================================================================================================
            //  Arrange
            //  reading data from files

            sw = Stopwatch.StartNew();

            //----------------------------------------------------------------------------------------------------
            // Act
            Span<double> data = data01.AsSpan().Slice(start: 20);
            Span<double> data = new Span<double>(arr, 20, arr.Length – 20);
            double mean = data.MeanHarmonicWeighted(weights);
            sw.Stop();
            Console.WriteLine($"          mean               = {mean}");
            Console.WriteLine($"          size               = {data.Count()}");
            Console.WriteLine($"          elapsed[ticks]     = {sw.ElapsedTicks}");
            Console.WriteLine($"          elapsed[ms]        = {sw.Elapsed.TotalMilliseconds}");
            sw.Reset();
            //----------------------------------------------------------------------------------------------------
            // Assert
            #if NUNIT
            Assert.AreEqual(15.29597, mean, 0.00001);
            #elif XUNIT
            Assert.Equal(15.29597, mean, 5);
            #elif MSTEST
            Assert.AreEqual(15.29597, mean, 0.00001);
            #endif
            //====================================================================================================

            return;
        }
        */

    }
}
