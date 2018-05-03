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

// #load "./Tests011MeasuresCentralTendencies.MeanArithmetic.cs"
// #load "./Tests011MeasuresCentralTendencies.MeanArithmeticWeighted.cs"
 
 
using System;

using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;
using System.Threading.Tasks;
using System.IO;
using System.Reflection;

using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Attributes.Jobs;
using BenchmarkDotNet.Running;

using Core.Math.Statistics.Descriptive.Sequential;

//namespace UnitTests.Core.Math.Statistics.Descriptive.Sequential.Sync
//{
    // [ClrJob(isBaseline: true), CoreJob, MonoJob, CoreRtJob]
    // [RPlotExporter, RankColumn]
    [InProcess]
    public partial class Tests20180119Dataset01
    {
        static int[] data01 = new int[] { 1, 2, 2, 3, 3, 3, 3, 4, 4, 5 };
        static double[] weights = new double[] { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, };
        Stopwatch sw = null;
    }
//}
