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
    public static partial class IEnumerableExtensionsMeanArithmeticGeneralizedWeighted
    {
        //==============================================================================================================
        public static double MeanArithmeticGeneralizedWeighted
                                        (
                                            this IEnumerable<byte> x,
                                            IEnumerable<double> w,
                                            double power
                                        )
        {
            int n = x.Count();

            double sum = 0.0;
            double sum_w = 0.0;

            for (int i = 0; i < n; i++)
            {
                byte x_i = x.ElementAt(i);
                double w_i = w.ElementAt(i);
                sum += w_i * System.Math.Pow(x_i, power);
                sum_w += w_i;
            }

            return System.Math.Pow(sum / sum_w, 1.0 / power);
        }

        public static double MeanArithmeticGeneralizedWeighted
                                        (
                                            this IEnumerable<short> x,
                                            IEnumerable<double> w,
                                            double power
                                        )
        {
            int n = x.Count();

            double sum = 0.0;
            double sum_w = 0.0;

            for (int i = 0; i < n; i++)
            {
                short x_i = x.ElementAt(i);
                double w_i = w.ElementAt(i);
                sum += w_i * System.Math.Pow(x_i, power);
                sum_w += w_i;
            }

            return System.Math.Pow(sum / sum_w, 1.0 / power);
        }

        public static double MeanArithmeticGeneralizedWeighted
                                        (
                                            this IEnumerable<ushort> x,
                                            IEnumerable<double> w,
                                            double power
                                        )
        {
            int n = x.Count();

            double sum = 0.0;
            double sum_w = 0.0;

            for (int i = 0; i < n; i++)
            {
                ushort x_i = x.ElementAt(i);
                double w_i = w.ElementAt(i);
                sum += w_i * System.Math.Pow(x_i, power);
                sum_w += w_i;
            }

            return System.Math.Pow(sum / sum_w, 1.0 / power);
        }

        public static double MeanArithmeticGeneralizedWeighted
                                        (
                                            this IEnumerable<int> x,
                                            IEnumerable<double> w,
                                            double power
                                        )
        {
            int n = x.Count();

            double sum = 0.0;
            double sum_w = 0.0;

            for (int i = 0; i < n; i++)
            {
                int x_i = x.ElementAt(i);
                double w_i = w.ElementAt(i);
                sum += w_i * System.Math.Pow(x_i, power);
                sum_w += w_i;
            }

            return System.Math.Pow(sum / sum_w, 1.0 / power);
        }

        public static double MeanArithmeticGeneralizedWeighted
                                        (
                                            this IEnumerable<uint> x,
                                            IEnumerable<double> w,
                                            double power
                                        )
        {
            int n = x.Count();

            double sum = 0.0;
            double sum_w = 0.0;

            for (int i = 0; i < n; i++)
            {
                uint x_i = x.ElementAt(i);
                double w_i = w.ElementAt(i);
                sum += w_i * System.Math.Pow(x_i, power);
                sum_w += w_i;
            }

            return System.Math.Pow(sum / sum_w, 1.0 / power);
        }

        public static double MeanArithmeticGeneralizedWeighted
                                        (
                                            this IEnumerable<long> x,
                                            IEnumerable<double> w,
                                            double power
                                        )
        {
            int n = x.Count();

            double sum = 0.0;
            double sum_w = 0.0;

            for (int i = 0; i < n; i++)
            {
                long x_i = x.ElementAt(i);
                double w_i = w.ElementAt(i);
                sum += w_i * System.Math.Pow(x_i, power);
                sum_w += w_i;
            }

            return System.Math.Pow(sum / sum_w, 1.0 / power);
        }

        public static double MeanArithmeticGeneralizedWeighted
                                        (
                                            this IEnumerable<ulong> x,
                                            IEnumerable<double> w,
                                            double power
                                        )
        {
            int n = x.Count();

            double sum = 0.0;
            double sum_w = 0.0;

            for (int i = 0; i < n; i++)
            {
                ulong x_i = x.ElementAt(i);
                double w_i = w.ElementAt(i);
                sum += w_i * System.Math.Pow(x_i, power);
                sum_w += w_i;
            }

            return System.Math.Pow(sum / sum_w, 1.0 / power);
        }

        public static double MeanArithmeticGeneralizedWeighted
                                        (
                                            this IEnumerable<float> x,
                                            IEnumerable<double> w,
                                            double power
                                        )
        {
            int n = x.Count();

            double sum = 0.0;
            double sum_w = 0.0;

            for (int i = 0; i < n; i++)
            {
                float x_i = x.ElementAt(i);
                double w_i = w.ElementAt(i);
                sum += w_i * System.Math.Pow(x_i, power);
                sum_w += w_i;
            }

            return System.Math.Pow(sum / sum_w, 1.0 / power);
        }

        public static double MeanArithmeticGeneralizedWeighted
                                        (
                                            this IEnumerable<double> x,
                                            IEnumerable<double> w,
                                            double power
                                        )
        {
            int n = x.Count();

            double sum = 0.0;
            double sum_w = 0.0;

            for (int i = 0; i < n; i++)
            {
                double x_i = x.ElementAt(i);
                double w_i = w.ElementAt(i);
                sum += w_i * System.Math.Pow(x_i, power);
                sum_w += w_i;
            }

            return System.Math.Pow(sum / sum_w, 1.0 / power);
        }

        public static decimal MeanArithmeticGeneralizedWeighted
                                        (
                                            this IEnumerable<decimal> x,
                                            IEnumerable<double> w,
                                            double power
                                        )
        {
            int n = x.Count();

            double sum = 0.0;
            double sum_w = 0.0;

            for (int i = 0; i < n; i++)
            {
                decimal x_i = x.ElementAt(i);
                double w_i = w.ElementAt(i);
                sum += w_i * System.Math.Pow((double) x_i, power);
                sum_w += w_i;
            }

            return (decimal) System.Math.Pow(sum / sum_w, 1.0 / power);
        }

        //==============================================================================================================

    }
}
