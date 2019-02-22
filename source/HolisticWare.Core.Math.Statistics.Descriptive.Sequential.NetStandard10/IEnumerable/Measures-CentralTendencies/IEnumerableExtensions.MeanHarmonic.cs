using System;
using System.Collections.Generic;
using System.Linq;

using Core.Math.Statistics.Descriptive.Sequential;

namespace Core.Math.Statistics.Descriptive.Sequential
{
    /// <summary>
    /// Mean (Average) Harmonic
    /// </summary>
    /// <see cref="https://en.wikipedia.org/wiki/Average"/>
    /// https://www.hackmath.net/en/calculator/harmonic-mean
    /// http://www.alcula.com/calculators/statistics/harmonic-mean/
    /// https://ncalculators.com/statistics/harmonic-mean-calculator.htm
    public static partial class IEnumerableExtensionsMeanHarmonic
    {
        //==============================================================================================================
        public static double MeanHarmonic
                                    (
                                        this IEnumerable<byte> x
                                    )
        {
            int n = x.Count();
            double sum = 0.0;

            for (int i = 0; i < n; i++) 
            {
                double x_i = x.ElementAt(i);
                sum += 1.0 / x_i;
            }

            return ((double)n) / sum;
        }

        public static double MeanHarmonic
                                    (
                                        this IEnumerable<ushort> x
                                    )
        {
            int n = x.Count();
            double sum = 0.0;

            for (int i = 0; i < n; i++) 
            {
                double x_i = x.ElementAt(i);
                sum += 1.0 / x_i;
            }

            return ((double)n) / sum;
        }

        public static double MeanHarmonic
                                    (
                                        this IEnumerable<short> x
                                    )
        {
            int n = x.Count();
            double sum = 0.0;

            for (int i = 0; i < n; i++) 
            {
                double x_i = x.ElementAt(i);
                sum += 1.0 / x_i;
            }

            return ((double)n) / sum;
        }

        public static double MeanHarmonic
                                    (
                                        this IEnumerable<int> x
                                    )
        {
            int n = x.Count();
            double sum = 0.0;

            for (int i = 0; i < n; i++)
            {
                double x_i = x.ElementAt(i);
                sum += 1.0 / x_i;
            }

            return ((double)n) / sum;
        }

        public static double MeanHarmonic
                                    (
                                        this IEnumerable<uint> x
                                    )
        {
            int n = x.Count();
            double sum = 0.0;

            for (int i = 0; i < n; i++) 
            {
                double x_i = x.ElementAt(i);
                sum += 1.0 / x_i;
            }

            return ((double)n) / sum;
        }

        public static double MeanHarmonic
                                    (
                                        this IEnumerable<long> x
                                    )
        {
            int n = x.Count();
            double sum = 0.0;

            for (int i = 0; i < n; i++) 
            {
                double x_i = x.ElementAt(i);
                sum += 1.0 / x_i;
            }

            return ((double)n) / sum;
        }

        public static double MeanHarmonic
                                    (
                                        this IEnumerable<ulong> x
                                    )
        {
            int n = x.Count();
            double sum = 0.0;

            for (int i = 0; i < n; i++) 
            {
                double x_i = x.ElementAt(i);
                sum += 1.0 / x_i;
            }

            return ((double)n) / sum;
        }

        public static double MeanHarmonic
                                    (
                                        this IEnumerable<float> x
                                    )
        {
            int n = x.Count();
            double sum = 0.0;

            for (int i = 0; i < n; i++) 
            {
                double x_i = x.ElementAt(i);
                sum += 1.0 / x_i;
            }

            return ((double)n) / sum;
        }

        public static double MeanHarmonic
                                    (
                                        this IEnumerable<double> x
                                    )
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

        public static decimal MeanHarmonic
                                    (
                                        this IEnumerable<decimal> x
                                    )
        {
            int n = x.Count();
            decimal sum = 0.0M;

            for (int i = 0; i < n; i++)
            {
                decimal x_i = x.ElementAt(i);
                sum += 1.0M / x_i;
            }

            return ((decimal) n) / sum;
        }
        //==============================================================================================================

    }
}
