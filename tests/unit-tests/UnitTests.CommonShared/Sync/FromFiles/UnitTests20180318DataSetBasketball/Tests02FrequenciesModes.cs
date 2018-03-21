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
using Test = Xunit.FactAttribute;
#elif NUNIT
using NUnit.Framework;
using Fact=NUnit.Framework.TestAttribute;
#elif MSTEST
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Test = Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute;
using Fact = Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute;
#endif


using Core.Math.Statistics.Descriptive.Sequential;

namespace UnitTests.Core.Math.Statistics.Descriptive.Sequential.Sync
{
    public partial class UnitTests20180318DataSetBasketball
    {
        [Test()]
        public void Mode_Points2Success()
        {
            data_2pts_success =
                                from row in basketball_team_data_table
                                select row.Points2Success
                                    ;

            List<int> modes = data_2pts_success.Modes();

            return;
        }


        [Test()]
        public void Mode_Points3Success()
        {
            data_3pts_success =
                                from row in basketball_team_data_table
                                select row.Points3Success
                                    ;

            List<int> modes = data_3pts_success.Modes();

            return;
        }


        [Test()]
        public void Mode_Points2Fail()
        {
            data_2pts_fail =
                                from row in basketball_team_data_table
                                select row.Points2Fail
                                    ;

            List<int> modes = data_2pts_fail.Modes();

            return;
        }


        [Test()]
        public void Mode_Points3Fail()
        {
            data_3pts_fail =
                                from row in basketball_team_data_table
                                select row.Points3Fail
                                    ;

            List<int> modes = data_3pts_fail.Modes();

            return;
        }
    }
}
