using System;
using System.Collections.Generic;
using System.Linq;

using Core.Math.Statistics.Descriptive.Sequential;

namespace Core.Math.Statistics.Descriptive.Sequential
{
    /// <summary>
    /// Mean (Average) Generalized
    /// </summary>
    /// <see cref="https://en.wikipedia.org/wiki/Average"/>
    /// <see cref="https://en.wikipedia.org/wiki/Generalized_mean"/>
    public static partial class IEnumerableExtensionsMeanGeneralized
    {
        //==============================================================================================================
        public static double MeanGeneralized(this IEnumerable<byte> x, double power)
        {
            int n = x.Count();

            double sum = 0.0;

            for (int i = 0; i < n; i++)
            {
                byte x_i = x.ElementAt(i);
                sum += System.Math.Pow(x_i, power);
            }

            return System.Math.Pow(sum / n, 1.0 / power);
        }

        public static double MeanGeneralized(this IEnumerable<short> x, double power)
        {
            int n = x.Count();

            double sum = 0.0;

            for (int i = 0; i < n; i++)
            {
                short x_i = x.ElementAt(i);
                sum += System.Math.Pow(x_i, power);
            }

            return System.Math.Pow(sum / n, 1.0 / power);
        }

        public static double MeanGeneralized(this IEnumerable<ushort> x, double power)
        {
            int n = x.Count();

            double sum = 0.0;

            for (int i = 0; i < n; i++)
            {
                ushort x_i = x.ElementAt(i);
                sum += System.Math.Pow(x_i, power);
            }

            return System.Math.Pow(sum / n, 1.0 / power);
        }

        public static double MeanGeneralized(this IEnumerable<int> x, double power)
        {
            int n = x.Count();

            double sum = 0.0;

            for (int i = 0; i < n; i++)
            {
                int x_i = x.ElementAt(i);
                sum += System.Math.Pow(x_i, power);
            }

            return System.Math.Pow(sum / n, 1.0 / power);
        }

        public static double MeanGeneralized(this IEnumerable<uint> x, double power)
        {
            int n = x.Count();

            double sum = 0.0;

            for (int i = 0; i < n; i++)
            {
                uint x_i = x.ElementAt(i);
                sum += System.Math.Pow(x_i, power);
            }

            return System.Math.Pow(sum / n, 1.0 / power);
        }

        public static double MeanGeneralized(this IEnumerable<long> x, double power)
        {
            int n = x.Count();

            double sum = 0.0;

            for (int i = 0; i < n; i++)
            {
                long x_i = x.ElementAt(i);
                sum += System.Math.Pow(x_i, power);
            }

            return System.Math.Pow(sum / n, 1.0 / power);
        }

        public static double MeanGeneralized(this IEnumerable<ulong> x, double power)
        {
            int n = x.Count();

            double sum = 0.0;

            for (int i = 0; i < n; i++)
            {
                ulong x_i = x.ElementAt(i);
                sum += System.Math.Pow(x_i, power);
            }

            return System.Math.Pow(sum / n, 1.0 / power);
        }

        public static double MeanGeneralized(this IEnumerable<float> x, double power)
        {
            int n = x.Count();

            double sum = 0.0;

            for (int i = 0; i < n; i++)
            {
                float x_i = x.ElementAt(i);
                sum += System.Math.Pow(x_i, power);
            }

            return System.Math.Pow(sum / n, 1.0 / power);
        }

        public static double MeanGeneralized(this IEnumerable<double> x, double power)
        {
            int n = x.Count();

            double sum = 0.0;

            for (int i = 0; i < n; i++)
            {
                double x_i = x.ElementAt(i);
                sum += System.Math.Pow(x_i, power);
            }

            return System.Math.Pow(sum / n, 1.0 / power);
        }

        public static decimal MeanGeneralized(this IEnumerable<decimal> x, double power)
        {
            int n = x.Count();

            decimal sum = 0.0M;

            for (int i = 0; i < n; i++)
            {
                decimal x_i = x.ElementAt(i);
                sum += (decimal) System.Math.Pow((double)x_i, power);
            }

            return (decimal) System.Math.Pow( (double) sum / n, 1.0 / power);
        }

        //==============================================================================================================

    }
}
