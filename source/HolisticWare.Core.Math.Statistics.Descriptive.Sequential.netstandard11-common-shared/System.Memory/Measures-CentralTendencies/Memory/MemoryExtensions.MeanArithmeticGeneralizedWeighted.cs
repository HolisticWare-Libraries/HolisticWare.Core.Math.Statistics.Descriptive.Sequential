using System;
using System.Collections.Generic;
using System.Linq;

using Core.Math.Statistics.Descriptive.Sequential;

namespace Core.Math.Statistics.Descriptive.Sequential
{
    /// <summary>
    /// Mean (Average) Generalized
    /// </summary>
    /// <see href="https://en.wikipedia.org/wiki/Average"/>
    /// <see href="https://en.wikipedia.org/wiki/Generalized_mean"/>
    public static partial class MemoryExtensionsMeanArithmeticGeneralizedWeighted 
    {
        //==============================================================================================================
        public static double MeanArithmeticGeneralizedWeighted
                                        (
                                            this Memory<byte> x,
                                            Memory<double> w,
                                            double power
                                        )
        {
            int n = x.Length;

            double sum = 0.0;
            double sum_w = 0.0;

            for (int i = 0; i < n; i++)
            {
                byte x_i = x.Span[i];
                double w_i = w.Span[i];
                sum += w_i * System.Math.Pow(x_i, power);
                sum_w += w_i;
            }

            return System.Math.Pow(sum / sum_w, 1.0 / power);
        }

        public static double MeanArithmeticGeneralizedWeighted
                                        (
                                            this Memory<short> x,
                                            Memory<double> w,
                                            double power
                                        )
        {
            int n = x.Length;

            double sum = 0.0;
            double sum_w = 0.0;

            for (int i = 0; i < n; i++)
            {
                short x_i = x.Span[i];
                double w_i = w.Span[i];
                sum += w_i * System.Math.Pow(x_i, power);
                sum_w += w_i;
            }

            return System.Math.Pow(sum / sum_w, 1.0 / power);
        }

        public static double MeanArithmeticGeneralizedWeighted
                                        (
                                            this Memory<ushort> x,
                                            Memory<double> w,
                                            double power
                                        )
        {
            int n = x.Length;

            double sum = 0.0;
            double sum_w = 0.0;

            for (int i = 0; i < n; i++)
            {
                ushort x_i = x.Span[i];
                double w_i = w.Span[i];
                sum += w_i * System.Math.Pow(x_i, power);
                sum_w += w_i;
            }

            return System.Math.Pow(sum / sum_w, 1.0 / power);
        }

        public static double MeanArithmeticGeneralizedWeighted
                                        (
                                            this Memory<int> x,
                                            Memory<double> w,
                                            double power
                                        )
        {
            int n = x.Length;

            double sum = 0.0;
            double sum_w = 0.0;

            for (int i = 0; i < n; i++)
            {
                int x_i = x.Span[i];
                double w_i = w.Span[i];
                sum += w_i * System.Math.Pow(x_i, power);
                sum_w += w_i;
            }

            return System.Math.Pow(sum / sum_w, 1.0 / power);
        }

        public static double MeanArithmeticGeneralizedWeighted
                                        (
                                            this Memory<uint> x,
                                            Memory<double> w,
                                            double power
                                        )
        {
            int n = x.Length;

            double sum = 0.0;
            double sum_w = 0.0;

            for (int i = 0; i < n; i++)
            {
                uint x_i = x.Span[i];
                double w_i = w.Span[i];
                sum += w_i * System.Math.Pow(x_i, power);
                sum_w += w_i;
            }

            return System.Math.Pow(sum / sum_w, 1.0 / power);
        }

        public static double MeanArithmeticGeneralizedWeighted
                                        (
                                            this Memory<long> x,
                                            Memory<double> w,
                                            double power
                                        )
        {
            int n = x.Length;

            double sum = 0.0;
            double sum_w = 0.0;

            for (int i = 0; i < n; i++)
            {
                long x_i = x.Span[i];
                double w_i = w.Span[i];
                sum += w_i * System.Math.Pow(x_i, power);
                sum_w += w_i;
            }

            return System.Math.Pow(sum / sum_w, 1.0 / power);
        }

        public static double MeanArithmeticGeneralizedWeighted
                                        (
                                            this Memory<ulong> x,
                                            Memory<double> w,
                                            double power
                                        )
        {
            int n = x.Length;

            double sum = 0.0;
            double sum_w = 0.0;

            for (int i = 0; i < n; i++)
            {
                ulong x_i = x.Span[i];
                double w_i = w.Span[i];
                sum += w_i * System.Math.Pow(x_i, power);
                sum_w += w_i;
            }

            return System.Math.Pow(sum / sum_w, 1.0 / power);
        }

        public static double MeanArithmeticGeneralizedWeighted
                                        (
                                            this Memory<float> x,
                                            Memory<double> w,
                                            double power
                                        )
        {
            int n = x.Length;

            double sum = 0.0;
            double sum_w = 0.0;

            for (int i = 0; i < n; i++)
            {
                float x_i = x.Span[i];
                double w_i = w.Span[i];
                sum += w_i * System.Math.Pow(x_i, power);
                sum_w += w_i;
            }

            return System.Math.Pow(sum / sum_w, 1.0 / power);
        }

        public static double MeanArithmeticGeneralizedWeighted
                                        (
                                            this Memory<double> x,
                                            Memory<double> w,
                                            double power
                                        )
        {
            int n = x.Length;

            double sum = 0.0;
            double sum_w = 0.0;

            for (int i = 0; i < n; i++)
            {
                double x_i = x.Span[i];
                double w_i = w.Span[i];
                sum += w_i * System.Math.Pow(x_i, power);
                sum_w += w_i;
            }

            return System.Math.Pow(sum / sum_w, 1.0 / power);
        }

        public static decimal MeanArithmeticGeneralizedWeighted
                                        (
                                            this Memory<decimal> x,
                                            Memory<double> w,
                                            double power
                                        )
        {
            int n = x.Length;

            double sum = 0.0;
            double sum_w = 0.0;

            for (int i = 0; i < n; i++)
            {
                decimal x_i = x.Span[i];
                double w_i = w.Span[i];
                sum += w_i * System.Math.Pow((double) x_i, power);
                sum_w += w_i;
            }

            return (decimal) System.Math.Pow(sum / sum_w, 1.0 / power);
        }

        //==============================================================================================================

    }
}
