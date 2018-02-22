using System;
using System.Collections.Generic;
using System.Linq;

using Core.Math.Statistics.Descriptive.Sequential;

namespace Core.Math.Statistics.Descriptive.Sequential
{
    /// <summary>
    /// Correlation
    /// </summary>
    public static partial class IEnumerableExtensionsMeanHarmonic
    {
        //==============================================================================================================
        public static double MeanHarmonic(this IEnumerable<byte> x)
        {
            int n = x.Count();
            double sum = 0.0;

            for (int i = 0; i < n; i++)
            {
                byte x_i = x.ElementAt(i);
                sum += 1.0 / x_i;
            }

            return n / sum;
        }

        public static double MeanHarmonic(this IEnumerable<ushort> x)
        {
            int n = x.Count();
            double sum = 0.0;

            for(int i = 0; i < n; i++)
            {
                ushort x_i = x.ElementAt(i);
                sum += 1.0 / x_i;
            }

            return n / sum;
        }

        public static double MeanHarmonic(this IEnumerable<short> x)
        {
            int n = x.Count();
            double sum = 0.0;

            for (int i = 0; i < n; i++)
            {
                short x_i = x.ElementAt(i);
                sum += 1.0 / x_i;
            }

            return n / sum;
        }

        public static double MeanHarmonic(this IEnumerable<int> x)
        {
            int n = x.Count();
            double sum = 0.0;

            for (int i = 0; i < n; i++)
            {
                int x_i = x.ElementAt(i);
                sum += 1.0 / x_i;
            }

            return n / sum;
        }

        public static double MeanHarmonic(this IEnumerable<uint> x)
        {
            int n = x.Count();
            double sum = 0.0;

            for (int i = 0; i < n; i++)
            {
                uint x_i = x.ElementAt(i);
                sum += 1.0 / x_i;
            }

            return n / sum;
        }

        public static double MeanHarmonic(this IEnumerable<long> x)
        {
            int n = x.Count();
            double sum = 0.0;

            for (int i = 0; i < n; i++)
            {
                long x_i = x.ElementAt(i);
                sum += 1.0 / x_i;
            }

            return n / sum;
        }

        public static double MeanHarmonic(this IEnumerable<ulong> x)
        {
            int n = x.Count();
            double sum = 0.0;

            for (int i = 0; i < n; i++)
            {
                ulong x_i = x.ElementAt(i);
                sum += 1.0 / x_i;
            }

            return n / sum;
        }

        public static double MeanHarmonic(this IEnumerable<float> x)
        {
            int n = x.Count();
            double sum = 0.0;

            for (int i = 0; i < n; i++)
            {
                float x_i = x.ElementAt(i);
                sum += 1.0 / x_i;
            }

            return n / sum;
        }

        public static double MeanHarmonic(this IEnumerable<double> x)
        {
            int n = x.Count();
            double sum = 0.0;

            for (int i = 0; i < n; i++)
            {
                double x_i = x.ElementAt(i);
                sum += 1.0 / x_i;
            }

            return n / sum;
        }

        public static decimal MeanHarmonic(this IEnumerable<decimal> x)
        {
            int n = x.Count();
            decimal sum = 0.0M;

            for (int i = 0; i < n; i++)
            {
                decimal x_i = x.ElementAt(i);
                sum += 1.0M / x_i;
            }

            return n / sum;
        }
        //==============================================================================================================

    }
}
