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
        [Test()]
        public void Array_Modes()
        {
            //====================================================================================================
            //  Arrange
            double[] data = data01.ToArray();

            //----------------------------------------------------------------------------------------------------
            // Act
            List<double> modes01 = data01.Modes();

            //----------------------------------------------------------------------------------------------------
            // Assert
            //CollectionAssert.AreEqual         // order taken into account
            //(
            //    new List<double> { 14.7, 18.2 }, 
            //    modes01
            //);
            #if NUNIT
            CollectionAssert.AreEquivalent
                        (
                            new List<double> { 14.7, 18.2 },
                            modes01
                        );
            #elif XUNIT
            Assert.True(modes01.Contains(14.7));
            Assert.True(modes01.Contains(18.2));
            #elif MSTEST
            CollectionAssert.AreEquivalent
                        (
                            new List<double> { 14.7, 18.2 },
                            modes01
                        );
            #endif

            #if NUNIT
            Assert.That
                        (
                            new List<double> { 14.7, 18.2 },
                            Is.EquivalentTo(modes01)
                        );
            Assert.IsTrue
            (
                modes01.SequenceEqual(new List<double> { 14.7, 18.2 })
            );

            #elif XUNIT
            Assert.Equal
                        (
                            new List<double> { 18.2, 14.7, },
                            modes01
                        );
            #elif MSTEST
            CollectionAssert.AreEqual
                        (
                            new List<double> { 18.2, 14.7, },
                            modes01
                        );
            Assert.IsTrue
            (
                modes01.SequenceEqual(new List<double> { 14.7, 18.2 })
            );

            #endif

            //====================================================================================================

            return;
        }
    }
}
