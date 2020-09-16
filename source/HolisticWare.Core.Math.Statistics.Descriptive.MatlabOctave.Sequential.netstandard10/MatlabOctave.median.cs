using System;
using System.Collections.Generic;

using Core.Math.Statistics.Descriptive.Sequential;

namespace Core.Math.Statistics.Descriptive.MatlabOctave.Sequential
{
    public partial class MatlabOctave
    {
        public static double median(IEnumerable<byte> x, string opt)
        {
            return x.Median();    
        }
    }
}
