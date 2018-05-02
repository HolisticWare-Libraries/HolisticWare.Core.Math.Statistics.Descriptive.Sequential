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
        public void Array_Frequencies()
        {
            //====================================================================================================
            //  Arrange
            //  reading data from files

            sw = Stopwatch.StartNew();

            //----------------------------------------------------------------------------------------------------
            // Act
            double[] data = data01.ToArray();
            IEnumerable<KeyValuePair<double, uint>> frequencies = data.Frequencies();
            sw.Stop();
            Console.WriteLine($"Array<double>.Frequencies()");
            Console.WriteLine($"          frequencies        = {frequencies}");
            Console.WriteLine($"          size               = {data.Count()}");
            Console.WriteLine($"          elapsed[ticks]     = {sw.ElapsedTicks}");
            Console.WriteLine($"          elapsed[ms]        = {sw.Elapsed.TotalMilliseconds}");
            sw.Reset();
            //----------------------------------------------------------------------------------------------------
            // Assert
            #if NUNIT
            CollectionAssert.AreEquivalent
                        (
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
                                }.ToList(),
                            frequencies
                        );
#elif XUNIT
            Assert.Equal
                        (
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
                                }.ToList(),
                                frequencies.ToArray()
                        );
#elif MSTEST
            CollectionAssert.AreEquivalent
                        (
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
                                }.ToList(),
                                frequencies.ToArray()
                        );
#endif
            //====================================================================================================

            return;
        }

        [Test]
        public void ArraySegment_Frequencies()
        {
            //====================================================================================================
            //  Arrange
            //  reading data from files

            sw = Stopwatch.StartNew();

            //----------------------------------------------------------------------------------------------------
            // Act
            ArraySegment<double>data = new ArraySegment<double>(data01);
            IEnumerable<KeyValuePair<double, uint>> frequencies = data.Frequencies();
            sw.Stop();
            Console.WriteLine($"          frequencies        = {frequencies}");
            Console.WriteLine($"          size               = {data.Count()}");
            Console.WriteLine($"          elapsed[ticks]     = {sw.ElapsedTicks}");
            Console.WriteLine($"          elapsed[ms]        = {sw.Elapsed.TotalMilliseconds}");
            sw.Reset();
            //----------------------------------------------------------------------------------------------------
            // Assert
            #if NUNIT
            CollectionAssert.AreEquivalent
                        (
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
                                }.ToList(),
                            frequencies
                        );
            #elif XUNIT
            Assert.Equal
                        (
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
                                }.ToList(),
                                frequencies.ToArray()
                        );
            #elif MSTEST
            CollectionAssert.AreEquivalent
                        (
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
                                }.ToList(),
                                frequencies.ToArray()
                        );
            #endif
            //====================================================================================================

            return;
        }

        [Test]
        public void List_Frequencies()
        {
            //====================================================================================================
            //  Arrange
            //  reading data from files

            sw = Stopwatch.StartNew();

            //----------------------------------------------------------------------------------------------------
            // Act
            List<double>data = new List<double>(data01);
            IEnumerable<KeyValuePair<double, uint>> frequencies = data.Frequencies();
            sw.Stop();
            Console.WriteLine($"          frequencies        = {frequencies}");
            Console.WriteLine($"          size               = {data.Count()}");
            Console.WriteLine($"          elapsed[ticks]     = {sw.ElapsedTicks}");
            Console.WriteLine($"          elapsed[ms]        = {sw.Elapsed.TotalMilliseconds}");
            sw.Reset();
            //----------------------------------------------------------------------------------------------------
            // Assert
            #if NUNIT
            CollectionAssert.AreEquivalent
                        (
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
                                }.ToList(),
                            frequencies
                        );
            #elif XUNIT
            Assert.Equal
                        (
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
                                }.ToList(),
                                frequencies.ToArray()
                        );
            #elif MSTEST
            CollectionAssert.AreEquivalent
                        (
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
                                }.ToList(),
                                frequencies.ToArray()
                        );
            #endif
            //====================================================================================================

            return;
        }

        [Test]
        public void Queue_Frequencies()
        {
            //====================================================================================================
            //  Arrange
            //  reading data from files

            sw = Stopwatch.StartNew();

            //----------------------------------------------------------------------------------------------------
            // Act
            Queue<double>data = new Queue<double>(data01);
            IEnumerable<KeyValuePair<double, uint>> frequencies = data.Frequencies();
            sw.Stop();
            Console.WriteLine($"          frequencies        = {frequencies}");
            Console.WriteLine($"          size               = {data.Count()}");
            Console.WriteLine($"          elapsed[ticks]     = {sw.ElapsedTicks}");
            Console.WriteLine($"          elapsed[ms]        = {sw.Elapsed.TotalMilliseconds}");
            sw.Reset();
            //----------------------------------------------------------------------------------------------------
            // Assert
            #if NUNIT
            CollectionAssert.AreEquivalent
                        (
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
                                }.ToList(),
                            frequencies
                        );
            #elif XUNIT
            Assert.Equal
                        (
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
                                }.ToList(),
                                frequencies.ToArray()
                        );
            #elif MSTEST
            CollectionAssert.AreEquivalent
                        (
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
                                }.ToList(),
                                frequencies.ToArray()
                        );
            #endif
            //====================================================================================================

            return;
        }

        [Test]
        public void Stack_Frequencies()
        {
            //====================================================================================================
            //  Arrange
            //  reading data from files

            sw = Stopwatch.StartNew();

            //----------------------------------------------------------------------------------------------------
            // Act
            Stack<double>data = new Stack<double>(data01);
            IEnumerable<KeyValuePair<double, uint>> frequencies = data.Frequencies();
            sw.Stop();
            Console.WriteLine($"          frequencies        = {frequencies}");
            Console.WriteLine($"          size               = {data.Count()}");
            Console.WriteLine($"          elapsed[ticks]     = {sw.ElapsedTicks}");
            Console.WriteLine($"          elapsed[ms]        = {sw.Elapsed.TotalMilliseconds}");
            sw.Reset();
            //----------------------------------------------------------------------------------------------------
            // Assert
            #if NUNIT
            CollectionAssert.AreEquivalent
                        (
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
                                }.ToList(),
                            frequencies
                        );
            #elif XUNIT
            Assert.Equal
                        (
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
                                }.ToList(),
                                frequencies.ToArray()
                        );
            #elif MSTEST
            CollectionAssert.AreEquivalent
                        (
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
                                }.ToList(),
                                frequencies.ToArray()
                        );
            #endif
            //====================================================================================================

            return;
        }

        [Test]
        public void LinkedList_Frequencies()
        {
            //====================================================================================================
            //  Arrange
            //  reading data from files

            sw = Stopwatch.StartNew();

            //----------------------------------------------------------------------------------------------------
            // Act
            LinkedList<double>data = new LinkedList<double>(data01);
            IEnumerable<KeyValuePair<double, uint>> frequencies = data.Frequencies();
            sw.Stop();
            Console.WriteLine($"          frequencies        = {frequencies}");
            Console.WriteLine($"          size               = {data.Count()}");
            Console.WriteLine($"          elapsed[ticks]     = {sw.ElapsedTicks}");
            Console.WriteLine($"          elapsed[ms]        = {sw.Elapsed.TotalMilliseconds}");
            sw.Reset();
            //----------------------------------------------------------------------------------------------------
            // Assert
            #if NUNIT
            CollectionAssert.AreEquivalent
                        (
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
                                }.ToList(),
                            frequencies
                        );
            #elif XUNIT
            Assert.Equal
                        (
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
                                }.ToList(),
                                frequencies.ToArray()
                        );
            #elif MSTEST
            CollectionAssert.AreEquivalent
                        (
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
                                }.ToList(),
                                frequencies.ToArray()
                        );
            #endif
            //====================================================================================================

            return;
        }

        [Test]
        public void ObservableCollection_Frequencies()
        {
            //====================================================================================================
            //  Arrange
            //  reading data from files

            sw = Stopwatch.StartNew();

            //----------------------------------------------------------------------------------------------------
            // Act
            ObservableCollection<double>data = new ObservableCollection<double>(data01);
            IEnumerable<KeyValuePair<double, uint>> frequencies = data.Frequencies();
            sw.Stop();
            Console.WriteLine($"          frequencies        = {frequencies}");
            Console.WriteLine($"          size               = {data.Count()}");
            Console.WriteLine($"          elapsed[ticks]     = {sw.ElapsedTicks}");
            Console.WriteLine($"          elapsed[ms]        = {sw.Elapsed.TotalMilliseconds}");
            sw.Reset();
            //----------------------------------------------------------------------------------------------------
            // Assert
            #if NUNIT
            CollectionAssert.AreEquivalent
                        (
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
                                }.ToList(),
                            frequencies
                        );
            #elif XUNIT
            Assert.Equal
                        (
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
                                }.ToList(),
                                frequencies.ToArray()
                        );
            #elif MSTEST
            CollectionAssert.AreEquivalent
                        (
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
                                }.ToList(),
                                frequencies.ToArray()
                        );
            #endif
            //====================================================================================================

            return;
        }

        [Test]
        public void HashSet_Frequencies()
        {
            //====================================================================================================
            //  Arrange
            //  reading data from files

            sw = Stopwatch.StartNew();

            //----------------------------------------------------------------------------------------------------
            // Act
            HashSet<double>data = new HashSet<double>(data01);
            IEnumerable<KeyValuePair<double, uint>> frequencies = data.Frequencies();
            sw.Stop();
            Console.WriteLine($"          frequencies        = {frequencies}");
            Console.WriteLine($"          size               = {data.Count()}");
            Console.WriteLine($"          elapsed[ticks]     = {sw.ElapsedTicks}");
            Console.WriteLine($"          elapsed[ms]        = {sw.Elapsed.TotalMilliseconds}");
            sw.Reset();
            //----------------------------------------------------------------------------------------------------
            // Assert
            //====================================================================================================

            return;
        }

        [Test]
        public void SortedSet_Frequencies()
        {
            //====================================================================================================
            //  Arrange
            //  reading data from files

            sw = Stopwatch.StartNew();

            //----------------------------------------------------------------------------------------------------
            // Act
            SortedSet<double>data = new SortedSet<double>(data01);
            IEnumerable<KeyValuePair<double, uint>> frequencies = data.Frequencies();
            sw.Stop();
            Console.WriteLine($"          frequencies        = {frequencies}");
            Console.WriteLine($"          size               = {data.Count()}");
            Console.WriteLine($"          elapsed[ticks]     = {sw.ElapsedTicks}");
            Console.WriteLine($"          elapsed[ms]        = {sw.Elapsed.TotalMilliseconds}");
            sw.Reset();
            //----------------------------------------------------------------------------------------------------
            // Assert
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
            Span<double>data = 
                            new Span<double>(data01);
                            //data01.AsSpan().Slice(start: 0)
                            ;
            double mean = data.Frequencies();
            sw.Stop();
            Console.WriteLine($"          mean               = {mean}");
            Console.WriteLine($"          size               = {data.Count()}");
            Console.WriteLine($"          elapsed[ticks]     = {sw.ElapsedTicks}");
            Console.WriteLine($"          elapsed[ms]        = {sw.Elapsed.TotalMilliseconds}");
            sw.Reset();
            //----------------------------------------------------------------------------------------------------
            // Assert
            #if NUNIT
            Assert.AreEqual(3.00, mean, 0.00001);
            #elif XUNIT
            Assert.Equal(3.00, mean, 5);
            #elif MSTEST
            Assert.AreEqual(3.00, mean, 0.00001);
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
            Memory<double>data =
                            new Memory<double>(data01);
                            //data01.AsSpan().Slice(start: 0)
                            ;
            double mean = data.Frequencies();
            sw.Stop();
            Console.WriteLine($"          mean               = {mean}");
            Console.WriteLine($"          size               = {data.Count()}");
            Console.WriteLine($"          elapsed[ticks]     = {sw.ElapsedTicks}");
            Console.WriteLine($"          elapsed[ms]        = {sw.Elapsed.TotalMilliseconds}");
            sw.Reset();
            //----------------------------------------------------------------------------------------------------
            // Assert
            #if NUNIT
            Assert.AreEqual(3.00, mean, 0.00001);
            #elif XUNIT
            Assert.Equal(3.00, mean, 5);
            #elif MSTEST
            Assert.AreEqual(3.00, mean, 0.00001);
            #endif
            //====================================================================================================

            return;
        }
        */
    }
}
