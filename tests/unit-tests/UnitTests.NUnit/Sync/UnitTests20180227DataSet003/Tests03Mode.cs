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
using NUnit.Framework;
using System;

using System.Collections.Generic;
using System.Linq;
using System.Collections;
using System.Diagnostics;


using Core.Math.Statistics.Descriptive.Sequential;

namespace UnitTests.Core.Math.Statistics.Descriptive.Sequential.Sync
{
    public partial class UnitTests20180227DataSet003
    {
        [Test()]
        public void Mode01()
        {
            //====================================================================================================
            // Arrange
            List<int> data01 = new List<int> { 1, 2, 2, 3, 3, 4 };

            sw = Stopwatch.StartNew();
            // Act
            List<int> modes01 = data01.Modes();
            sw.Stop();
            Console.WriteLine($"List<int>.Modes() size={data01.Count} elapsed[ticks]={sw.ElapsedTicks}");

            // Assert
            CollectionAssert.AreEquivalent
                                    (
                                        new List<int> { 2, 3 },
                                        modes01
                                    );
            //====================================================================================================

            return;
        }

        [Test()]
        public void Mode03()
        {
            //====================================================================================================
            // Arrange
            List<int> data01 = new List<int> { 1, 2, 2, 3, 3, 4, 5, 6 };

            sw = Stopwatch.StartNew();
            // Act
            List<int> modes01 = data01.Modes();
            sw.Stop();
            Console.WriteLine($"List<int>.Modes() size={data01.Count} elapsed[ticks]={sw.ElapsedTicks}");

            // Assert
            CollectionAssert.AreEquivalent
                                    (
                                        new List<int> { 2, 3 },
                                        modes01
                                    );
            //====================================================================================================

            return;
        }
    }
}
