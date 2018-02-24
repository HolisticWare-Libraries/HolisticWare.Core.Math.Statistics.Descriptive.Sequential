using System;
using System.Collections.Generic;
using System.Linq;

using Core.Math.Statistics.Descriptive.Sequential;

namespace Core.Math.Statistics.Descriptive.Sequential
{
    /// <summary>
    /// Mean (Average) Arithmetic
    /// </summary>
    /// <see cref="https://en.wikipedia.org/wiki/Average"/>
    public static partial class IEnumerableExtensionsMeanArithmetic
    {
        //==============================================================================================================
        public static double MeanArithmetic(this IEnumerable<byte> x)
        {
            return x.Cast<int>().Average();
        }

        public static double MeanArithmetic(this IEnumerable<ushort> x)
        {
            return x.Cast<int>().Average();
        }

        public static double MeanArithmetic(this IEnumerable<short> x)
        {
            return x.Cast<int>().Average();
        }

        public static double MeanArithmetic(this IEnumerable<int> x)
        {
            return x.Average();
        }

        public static double MeanArithmetic(this IEnumerable<uint> x)
        {
            return x.Cast<long>().Average();
        }

        public static double MeanArithmetic(this IEnumerable<long> x)
        {
            return x.Average();
        }

        public static double MeanArithmetic(this IEnumerable<ulong> x)
        {
            return x.Cast<double>().Average();
        }

        public static double MeanArithmetic(this IEnumerable<float> x)
        {
            return x.Average();
        }
         
        public static double MeanArithmetic(this IEnumerable<double> x)
        {
            return x.Average();
        }

        public static decimal MeanArithmetic(this IEnumerable<decimal> x)
        {
            return x.Average();
        }
        //==============================================================================================================

    }
}
