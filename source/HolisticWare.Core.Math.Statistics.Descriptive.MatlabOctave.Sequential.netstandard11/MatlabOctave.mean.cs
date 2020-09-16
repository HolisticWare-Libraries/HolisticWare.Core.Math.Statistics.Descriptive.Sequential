using System;
using System.Collections.Generic;

using Core.Math.Statistics.Descriptive.Sequential;

namespace Core.Math.Statistics.Descriptive.MatlabOctave.Sequential
{
    public static partial class MatlabOctave
    {
        public static double mean(Memory<byte> x, string option)
        {
            return x.mean(option);
        }

        public static double mean(Memory<byte> x, char option)
        {
            return x.mean(new string(new char[] { option } ));
        }
    }
}
