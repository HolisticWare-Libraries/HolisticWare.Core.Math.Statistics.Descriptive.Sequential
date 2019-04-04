using System;
using System.Collections.Generic;
using System.Linq;

using Core.Math.Statistics.Descriptive.Sequential;

namespace Core.Math.Statistics.Descriptive.Sequential
{
    /// <summary>
    /// Mean (Average) Quadratic
    /// </summary>
    /// <see cref="https://en.wikipedia.org/wiki/Average"/>
    public static partial class MemoryExtensionsMeanQuadratic
    {
        //==============================================================================================================
        public static double MeanQuadratic
                                    (
                                        this Memory<byte> x
                                    )
        {
            int n = x.Length;

            double sum = 0.0;

            for (int i = 0; i < n; i++)
            {
                byte x_i = x.Span[i];
                sum += x_i * x_i;
            }

            return System.Math.Pow(sum / n, 1.0 / 2.0);
        }

        public static double MeanQuadratic
                                    (
                                        this Memory<short> x
                                    )
        {
            int n = x.Length;

            double sum = 0.0;

            for (int i = 0; i < n; i++)
            {
                short x_i = x.Span[i];
                sum += x_i * x_i;
            }

            return System.Math.Pow(sum / n, 1.0 / 2.0);
        }

        public static double MeanQuadratic
                                    (
                                        this Memory<ushort> x
                                    )
        {
            int n = x.Length;

            double sum = 0.0;

            for (int i = 0; i < n; i++)
            {
                ushort x_i = x.Span[i];
                sum += x_i * x_i;
            }

            return System.Math.Pow(sum / n, 1.0 / 2.0);
        }

        public static double MeanQuadratic
                                    (
                                        this Memory<int> x
                                    )
        {
            int n = x.Length;

            double sum = 0.0;

            for (int i = 0; i < n; i++)
            {
                int x_i = x.Span[i];
                sum += x_i * x_i;
            }

            return System.Math.Pow(sum / n, 1.0 / 2.0);
        }

        public static double MeanQuadratic
                                    (
                                        this Memory<uint> x
                                    )
        {
            int n = x.Length;

            double sum = 0.0;

            for (int i = 0; i < n; i++)
            {
                uint x_i = x.Span[i];
                sum += x_i * x_i;
            }

            return System.Math.Pow(sum / n, 1.0 / 2.0);
        }

        public static double MeanQuadratic
                                    (
                                        this Memory<long> x
                                    )
        {
            int n = x.Length;

            double sum = 0.0;

            for (int i = 0; i < n; i++)
            {
                long x_i = x.Span[i];
                sum += x_i * x_i;
            }

            return System.Math.Pow(sum / n, 1.0 / 2.0);
        }

        public static double MeanQuadratic
                                    (
                                        this Memory<ulong> x
                                    )
        {
            int n = x.Length;

            double sum = 0.0;

            for (int i = 0; i < n; i++)
            {
                ulong x_i = x.Span[i];
                sum += x_i * x_i;
            }

            return System.Math.Pow(sum / n, 1.0 / 2.0);
        }

        public static double MeanQuadratic
                                    (
                                        this Memory<float> x
                                    )
        {
            int n = x.Length;

            double sum = 0.0;

            for (int i = 0; i < n; i++)
            {
                float x_i = x.Span[i];
                sum += x_i * x_i;
            }

            return System.Math.Pow(sum / n, 1.0 / 2.0);
        }

        public static double MeanQuadratic
                                    (
                                        this Memory<double> x
                                    )
        {
            int n = x.Length;

            double sum = 0.0;

            for (int i = 0; i < n; i++)
            {
                double x_i = x.Span[i];
                sum += x_i * x_i;
            }

            return System.Math.Pow(sum / n, 1.0 / 2.0);
        }

        public static decimal MeanQuadratic
                                    (
                                        this Memory<decimal> x
                                    )
        {
            int n = x.Length;

            decimal sum = 0.0m;

            for (int i = 0; i < n; i++)
            {
                decimal x_i = x.Span[i];
                sum += x_i * x_i;
            }

            return (decimal)System.Math.Pow((double)sum / n, 1.0 / 2.0);
        }

        //==============================================================================================================

    }
}
