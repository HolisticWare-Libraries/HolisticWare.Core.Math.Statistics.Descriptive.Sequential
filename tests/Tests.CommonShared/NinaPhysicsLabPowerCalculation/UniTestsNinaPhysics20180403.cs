﻿// /*
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
// NUnit aliases
using Test = Xunit.FactAttribute;
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
using TestContext = System.Object;
// XUnit aliases
using Fact=NUnit.Framework.TestAttribute;
#elif MSTEST
using Microsoft.VisualStudio.TestTools.UnitTesting;
// NUnit aliases
using Test = Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute;
// XUnit aliases
using Fact = Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute;
#endif

using Core.Math.Statistics.Descriptive;

namespace UnitTests.Core.Math.Statistics.Descriptive.Sequential.Sync
{
    [TestClass] // for MSTest - NUnit [TestFixture] and XUnit not needed
    public partial class UniTestsNinaPhysics20180403
    {
        double time_walk_mean;
        double time_run_mean;

        [Test()]
        public void Data01()
        {
            //====================================================================================================
            // Arrange
            List<double> time_walk = new List<double>
            {
                7.0,
                7.2,
                6.9,
                7.4,
                7.7,
            };

            List<double> time_run = new List<double>
            {
                3.2,
                3.5,
                3.2,
                3.6,
                3.7,
            };


            // Act
            time_walk_mean = time_walk.MeanArithmetic();
            time_run_mean = time_run.MeanArithmetic();

            // Assert
            #if NUNIT
            Assert.AreEqual(time_walk_mean, 7.24, 0.01);
            Assert.AreEqual(time_run_mean, 3.44, 0.01);
            #elif XUNIT
            Assert.Equal(7.24, time_walk_mean, 2);
            Assert.Equal(3.44, time_run_mean, 2);
            #elif MSTEST
            Assert.AreEqual(time_walk_mean, 7.24, 0.01);
            Assert.AreEqual(time_run_mean, 3.44, 0.01);
            #endif

            // Act
            time_walk_mean = time_walk.MeanGeometric();
            time_run_mean = time_run.MeanGeometric();

            // Assert
            #if NUNIT
            Assert.AreEqual(time_walk_mean, 7.23, 0.01);
            Assert.AreEqual(time_run_mean, 3.43, 0.01);
            #elif XUNIT
            Assert.Equal(7.23, time_walk_mean, 2);
            Assert.Equal(3.43, time_run_mean, 2);
            #elif MSTEST
            Assert.AreEqual(time_walk_mean, 7.23, 0.01);
            Assert.AreEqual(time_run_mean, 3.43, 0.01);
            #endif


            //====================================================================================================
            return;
        }
    }
}
