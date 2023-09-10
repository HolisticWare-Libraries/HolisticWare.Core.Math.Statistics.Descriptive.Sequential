using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Math.Statistics.Descriptive
{
    /// <summary>
    /// Mean (Average) Harmonic
    /// </summary>
    /// <see href="https://en.wikipedia.org/wiki/Average"/>
    /// https://www.hackmath.net/en/calculator/harmonic-mean
    /// http://www.alcula.com/calculators/statistics/harmonic-mean/
    /// https://ncalculators.com/statistics/harmonic-mean-calculator.htm
    public static partial class
                                        IEnumerableExtensionsMeanHarmonic
    {
        //==============================================================================================================
        public static double MeanHarmonicAsync
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

        public static double MeanHarmonicAsync
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

        public static double MeanHarmonicAsync
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

        public static double MeanHarmonicAsync
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

        public static double MeanHarmonicAsync
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

        public static double MeanHarmonicAsync
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

        public static double MeanHarmonicAsync
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

        public static double MeanHarmonicAsync
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

        public static double MeanHarmonicAsync
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

        public static decimal MeanHarmonicAsync
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
