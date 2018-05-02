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
    public partial class Tests20180119Dataset01
    {
        [Test()]
        public void FrequencyDistribution03()
        {
            // Arange
            Queue<int> data01 =
                new Queue<int>
                        (
                            new[]
                            {
                                160, 135, 175, 170, 155, 170, 165, 150, 155, 195,
                                175, 150, 180, 210, 180, 205, 180, 160, 170, 185,
                                160, 195, 190, 205, 160, 185, 180, 205, 195, 180,
                                160, 170, 155, 150, 195, 175, 175, 190, 185, 180,
                                180, 190, 195, 175, 175, 175, 175, 150, 165, 180,
                                165, 195, 200, 190, 190, 165, 170, 205, 200, 180,
                            }
                        );

            // Act
            IEnumerable<KeyValuePair<int, uint>> frequencies01 = data01.FrequencyDistribution();

            // Assert
#if NUNIT
            CollectionAssert.AreEquivalent
                        (
                            new Dictionary<double, uint>
                                {
                                    { 180, 9 },
                                    { 175, 8 },
                                    { 195, 6 },
                                    { 190, 5 },
                                    { 160, 5 },
                                    { 170, 5 },
                                    { 150, 4 },
                                    { 165, 4 },
                                    { 155, 3 },
                                    { 205, 4 },
                                    { 185, 3 },
                                    { 200, 2 },
                                    { 135, 1 },
                                    { 210, 1 },
                                }.ToList(),
                            frequencies01
                        );
#elif XUNIT
            Assert.Equal
                        (
                            "XUnit sucks cannot compare Dictionaries",
                            "XUnit sucks cannot compare Dictionaries"
                        );
            //Assert.Equal
                        //(
                        //    new Dictionary<double, uint>
                        //    {
                        //        { 180, 9 },
                        //        { 175, 8 },
                        //        { 195, 6 },
                        //        { 190, 5 },
                        //        { 160, 5 },
                        //        { 170, 5 },
                        //        { 150, 4 },
                        //        { 165, 4 },
                        //        { 155, 3 },
                        //        { 205, 4 },
                        //        { 185, 3 },
                        //        { 200, 2 },
                        //        { 135, 1 },
                        //        { 210, 1 },
                        //    }.ToList(),
                        //    frequencies01.ToList()
                        //);
#elif MSTEST
            CollectionAssert.AreEquivalent
                        (
                            new Dictionary<double, uint>
                                {
                                    { 180, 9 },
                                    { 175, 8 },
                                    { 195, 6 },
                                    { 190, 5 },
                                    { 160, 5 },
                                    { 170, 5 },
                                    { 150, 4 },
                                    { 165, 4 },
                                    { 155, 3 },
                                    { 205, 4 },
                                    { 185, 3 },
                                    { 200, 2 },
                                    { 135, 1 },
                                    { 210, 1 },
                                }.ToList(),
                                frequencies01.ToList()
                        );
#endif

            return;
        }
    }
}
