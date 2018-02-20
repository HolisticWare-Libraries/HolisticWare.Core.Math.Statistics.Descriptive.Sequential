using System;
using System.Collections.Generic;
using System.Linq;

using Core.Math.Statistics.Descriptive.Sequential;

namespace Core.Math.Statistics.Descriptive.Sequential
{
    /// <summary>
    /// Correlation
    /// </summary>
    public static partial class IEnumerableExtensionsMeanGeometric
    {
        //==============================================================================================================
        public static double MeanGeometric(this IEnumerable<ushort> x)
        {
            double product = 1.0;

            foreach (ushort x_i in x)
            {
                product *= x_i;
            }

            return System.Math.Pow(product, 1.0 / x.LongCount());
        }

        public static double MeanGeometric(this IEnumerable<short> x)
        {
            double product = 1.0;

            foreach (short x_i in x)
            {
                product *= x_i;
            }

            return System.Math.Pow(product, 1.0 / x.LongCount());
        }

        public static double MeanGeometric(this IEnumerable<int> x)
        {
            double product = 1.0;

            foreach (int x_i in x)
            {
                product *= x_i;
            }

            return System.Math.Pow(product, 1.0 / x.LongCount());
        }

        public static double MeanGeometric(this IEnumerable<uint> x)
        {
            double product = 1.0;

            foreach (uint x_i in x)
            {
                product *= x_i;
            }

            return System.Math.Pow(product, 1.0 / x.LongCount());
        }

        public static double MeanGeometric(this IEnumerable<long> x)
        {
            double product = 1.0;

            foreach (long x_i in x)
            {
                product *= x_i;
            }

            return System.Math.Pow(product, 1.0 / x.LongCount());
        }

        public static double MeanGeometric(this IEnumerable<ulong> x)
        {
            double product = 1.0;

            foreach (ulong x_i in x)
            {
                product *= x_i;
            }

            return System.Math.Pow(product, 1.0 / x.LongCount());
        }

        public static double MeanGeometric(this IEnumerable<float> x)
        {
            double product = 1.0;

            foreach (float x_i in x)
            {
                product *= x_i;
            }

            return System.Math.Pow(product, 1.0 / x.LongCount());
        }

        public static double MeanGeometric(this IEnumerable<double> x)
        {
            double product = 1.0;

            foreach (double x_i in x)
            {
                product *= x_i;
            }

            return System.Math.Pow(product, 1.0 / x.LongCount());
        }

        public static decimal MeanGeometric(this IEnumerable<decimal> x)
        {
            decimal product = 1.0m;

            foreach (decimal x_i in x)  // System.InvalidCastException : Specified cast is not valid.
            {
                product *= x_i;
            }

            return (decimal) System.Math.Pow((double)product, 1.0 / x.LongCount());
        }
        //==============================================================================================================

    }
}
