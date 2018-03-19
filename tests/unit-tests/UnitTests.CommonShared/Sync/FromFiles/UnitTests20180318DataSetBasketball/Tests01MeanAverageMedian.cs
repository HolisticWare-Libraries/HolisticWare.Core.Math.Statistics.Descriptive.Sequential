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
#endif

using Core.Math.Statistics.Descriptive.Sequential;

namespace UnitTests.Core.Math.Statistics.Descriptive.Sequential.Sync
{
    public partial class UnitTests20180318DataSetBasketball
    {
        IEnumerable<int> data_2pts_success;
        IEnumerable<int> data_3pts_success;

        [Test()]
        public void MeanArithmetic_Points2Success()
        {
            data_2pts_success =
                                from row in data01
                                where row.Assistence == 2
                                         orderby row.BallsLost
                                    select row.Points2Success
                                    ;

            mean_2_a = data_2pts_success.MeanArithmetic();
            double mean_2_g = data_2pts_success.MeanGeometric();

            return;
        }

        double mean_2_a;

        [Test()]
        public void MeanArithmetic_Points3Success()
        {
            data_3pts_success =
                from d in data01
                select d.Points3Success
                        ;

            double mean_3_a = data_3pts_success.MeanArithmetic();
            double mean_3_g = data_3pts_success.MeanGeometric();

            double c = data_3pts_success.Correlation(data_2pts_success);

            return;
        }
    }
}
