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

#if XUNIT
using Xunit;
using Test = Xunit.FactAttribute;
#elif NUNIT
using NUnit.Framework;
using Fact=NUnit.Framework.TestAttribute;
#elif MSTEST
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Test = Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute;
using Fact = Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute;
using OneTimeSetUp = Microsoft.VisualStudio.TestTools.UnitTesting.ClassInitializeAttribute;
#endif

using Core.Math.Statistics.Descriptive.Sequential;

namespace UnitTests.Core.Math.Statistics.Descriptive.Sequential.Sync
{
    public partial class UnitTests20180227DataSet001
    {
        
        [Test()]
        public void Frequencies()
        {
            //====================================================================================================
            // Arrange
            // Arrange
            List<int> data01 = new List<int> { 2, 4, 3, 5, 6, 7, 4, 4, 2, 1 };

            sw = Stopwatch.StartNew();
            // Act
            IEnumerable<KeyValuePair<int, uint>> frequencies01 = data01.Frequencies();
            sw.Stop();
            Console.WriteLine($"List<int>.Frequencies()");
            Console.WriteLine($"          frequencies01      = {frequencies01}");
            Console.WriteLine($"          size               = {data01.Count()}");
            Console.WriteLine($"          elapsed[ticks]     = {sw.ElapsedTicks}");
            Console.WriteLine($"          elapsed[ms]        = {sw.Elapsed.TotalMilliseconds}");
            sw.Reset();

            #if NUNIT
            CollectionAssert.AreEquivalent
                                (
                                    frequencies01,
                                    new Dictionary<int, uint>()
                                    {
                                        { 4, 3 },
                                        { 2, 2 },
                                        { 3, 1 },
                                        { 5, 1 },
                                        { 6, 1 },
                                        { 7, 1 },
                                        { 1, 1 },
                                    }
                                );
            #elif XUNIT
            Assert.Equal
                                (
                                    frequencies01,
                                    new Dictionary<int, uint>()
                                    {
                                        { 4, 3 },
                                        { 2, 2 },
                                        { 3, 1 },
                                        { 5, 1 },
                                        { 6, 1 },
                                        { 7, 1 },
                                        { 1, 1 },
                                    }
                                );
            #elif MSTEST
            #endif
            //====================================================================================================

            return;
        }

        [Test()]
        public void Mode01()
        {
            //====================================================================================================
            // Arrange
            List<int> data01 = new List<int> { 2, 4, 3, 5, 6, 7, 4, 4, 2, 1 };

            sw = Stopwatch.StartNew();
            // Act
            List<int> modes01 = data01.Modes();
            sw.Stop();
            Console.WriteLine($"List<int>.MeanGeneralized()");
            Console.WriteLine($"          modes01               = {modes01}");
            Console.WriteLine($"          size                  = {data01.Count()}");
            Console.WriteLine($"          elapsed[ticks]        = {sw.ElapsedTicks}");
            Console.WriteLine($"          elapsed[ms]           = {sw.Elapsed.TotalMilliseconds}");
            sw.Reset();

            // Assert
            #if NUNIT
            CollectionAssert.AreEquivalent
                                    (
                                        new List<int> { 4 },
                                        modes01
                                    );
            #elif XUNIT
            Assert.Equal
                                    (
                                        new List<int> { 4 },
                                        modes01
                                    );
            #elif MSTEST
            #endif
            //====================================================================================================

            return;
        }

        [Test()]
        public void Mode02()
        {
            //====================================================================================================
            // Arrange
            Stack<int> data02 = new Stack<int>(new[] { 2, 4, 3, 5, 6, 7, 4, 4, 2, 1 });

            sw = Stopwatch.StartNew();
            // Act
            List<int> modes02 = data02.Modes();
            sw.Stop();
            Console.WriteLine($"List<int>.MeanGeneralized()");
            Console.WriteLine($"          modes02               = {modes02}");
            Console.WriteLine($"          size                  = {data02.Count()}");
            Console.WriteLine($"          elapsed[ticks]        = {sw.ElapsedTicks}");
            Console.WriteLine($"          elapsed[ms]           = {sw.Elapsed.TotalMilliseconds}");
            sw.Reset();

            // Assert
            #if NUNIT
            CollectionAssert.AreEquivalent
                                    (
                                        new List<int> { 4 },
                                        modes02
                                    );
            #elif XUNIT
            Assert.Equal
                                    (
                                        new List<int> { 4 },
                                        modes02
                                    );
            #elif MSTEST
            #endif
            //====================================================================================================

            return;
        }

        [Test()]
        public void Mode03()
        {
            //====================================================================================================
            // Arrange
            Queue<int> data03 = new Queue<int>(new[] { 2, 4, 3, 5, 6, 7, 4, 4, 2, 1 });

            sw = Stopwatch.StartNew();
            // Act
            List<int> modes03 = data03.Modes();
            sw.Stop();
            Console.WriteLine($"List<int>.MeanGeneralized()");
            Console.WriteLine($"          modes03               = {modes03}");
            Console.WriteLine($"          size                  = {data03.Count()}");
            Console.WriteLine($"          elapsed[ticks]        = {sw.ElapsedTicks}");
            Console.WriteLine($"          elapsed[ms]           = {sw.Elapsed.TotalMilliseconds}");
            sw.Reset();

            // Assert
            #if NUNIT
            CollectionAssert.AreEquivalent
                                    (
                                        new List<int> { 4 },
                                        modes03
                                    );
            #elif XUNIT
            Assert.Equal
                                    (
                                        new List<int> { 4 },
                                        modes03
                                    );
            #elif MSTEST
            #endif
            //====================================================================================================

            return;
        }

        [Test()]
        public void Mode04()
        {

            //====================================================================================================
            // Arrange
            int[] data04 = new[] { 2, 4, 3, 5, 6, 7, 4, 4, 2, 1 };

            sw = Stopwatch.StartNew();
            // Act
            List<int> modes04 = data04.Modes();
            sw.Stop();
            Console.WriteLine($"List<int>.MeanGeneralized()");
            Console.WriteLine($"          modes04               = {modes04}");
            Console.WriteLine($"          size                  = {data04.Count()}");
            Console.WriteLine($"          elapsed[ticks]        = {sw.ElapsedTicks}");
            Console.WriteLine($"          elapsed[ms]           = {sw.Elapsed.TotalMilliseconds}");
            sw.Reset();

            // Assert
            #if NUNIT
            CollectionAssert.AreEquivalent
                                    (
                                        new List<int> { 4 },
                                        modes04
                                    );
            #elif XUNIT
            Assert.Equal
                                    (
                                        new List<int> { 4 },
                                        modes04
                                    );
            #elif MSTEST
            CollectionAssert.AreEquivalent
                                    (
                                        new List<int> { 4 },
                                        modes04
                                    );
            #endif
            //====================================================================================================
        }

        [Test()]
        public void Mode05()
        {
            #if NETSTANDARD1_3
            //====================================================================================================
            // Arrange
            ArrayList data05 = new ArrayList { 2, 4, 3, 5, 6, 7, 4, 4, 2, 1 };

            sw = Stopwatch.StartNew();
            // Act
            List<int> modes05 = data05.Modes();
            sw.Stop();
            Console.WriteLine($"List<int>.MeanGeneralized()");
            Console.WriteLine($"          modes05               = {modes05}");
            Console.WriteLine($"          size                  = {data05.Count()}");
            Console.WriteLine($"          elapsed[ticks]        = {sw.ElapsedTicks}");
            Console.WriteLine($"          elapsed[ms]           = {sw.Elapsed.TotalMilliseconds}");
            sw.Reset();

            // Assert
            CollectionAssert.AreEquivalent
                                    (
                                        new List<int> { 4 }, 
                                        modes05
                                    );
            //====================================================================================================
            #endif

            return;
        }
    }
}
