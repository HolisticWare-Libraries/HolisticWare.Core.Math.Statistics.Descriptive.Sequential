using System;
using System.Collections.Generic;
using System.Linq;

using Core.Math.Statistics.Descriptive;

namespace Core.Math.Statistics.Descriptive
{
    /// <summary>
    /// Mean (Average) Cubic
    /// </summary>
    /// <see href="https://en.wikipedia.org/wiki/Average"/>
    public static partial class MemoryExtensionsMeanCubic
    {
        //==============================================================================================================
        public static double MeanCubic
                                    (
                                        this Memory<byte> x
                                    )
        {
            int n = x.Length;

            double sum = 0.0;

            for (int i = 0; i < n; i++)
            {
                byte x_i = x.Span[i];
                sum += x_i * x_i * x_i;
            }

            return System.Math.Pow(sum / n, 1.0 / 3.0);
        }

        public static double MeanCubic
                                    (
                                        this Memory<short> x
                                    )
        {
            int n = x.Length;

            double sum = 0.0;

            for (int i = 0; i < n; i++)
            {
                short x_i = x.Span[i];
                sum += x_i * x_i * x_i;
            }

            return System.Math.Pow(sum / n, 1.0 / 3.0);
        }

        public static double MeanCubic
                                    (
                                        this Memory<ushort> x
                                    )
        {
            int n = x.Length;

            double sum = 0.0;

            for (int i = 0; i < n; i++)
            {
                ushort x_i = x.Span[i];
                sum += x_i * x_i * x_i;
            }

            return System.Math.Pow(sum / n, 1.0 / 3.0);
        }

        public static double MeanCubic
                                    (
                                        this Memory<int> x
                                    )
        {
            int n = x.Length;

            double sum = 0.0;

            for (int i = 0; i < n; i++)
            {
                int x_i = x.Span[i];
                sum += x_i * x_i * x_i;
            }

            return System.Math.Pow(sum / n, 1.0 / 3.0);
        }

        public static double MeanCubic
                                    (
                                        this Memory<uint> x
                                    )
        {
            int n = x.Length;

            double sum = 0.0;

            for (int i = 0; i < n; i++)
            {
                uint x_i = x.Span[i];
                sum += x_i * x_i * x_i;
            }

            return System.Math.Pow(sum / n, 1.0 / 3.0);
        }

        public static double MeanCubic
                                    (
                                        this Memory<long> x
                                    )
        {
            int n = x.Length;

            double sum = 0.0;

            for (int i = 0; i < n; i++)
            {
                long x_i = x.Span[i];
                sum += x_i * x_i * x_i;
            }

            return System.Math.Pow(sum / n, 1.0 / 3.0);
        }

        public static double MeanCubic
                                    (
                                        this Memory<ulong> x
                                    )
        {
            int n = x.Length;

            double sum = 0.0;

            for (int i = 0; i < n; i++)
            {
                ulong x_i = x.Span[i];
                sum += x_i * x_i * x_i;
            }

            return System.Math.Pow(sum / n, 1.0 / 3.0);
        }

        public static double MeanCubic
                                    (
                                        this Memory<float> x
                                    )
        {
            int n = x.Length;

            double sum = 0.0;

            for (int i = 0; i < n; i++)
            {
                float x_i = x.Span[i];
                sum += x_i * x_i * x_i;
            }

            return System.Math.Pow(sum / n, 1.0 / 3.0);
        }

        public static double MeanCubic
                                    (
                                        this Memory<double> x
                                    )
        {
            int n = x.Length;

            double sum = 0.0;

            for (int i = 0; i < n; i++)
            {
                double x_i = x.Span[i];
                sum += x_i * x_i * x_i;
            }

            return System.Math.Pow(sum / n, 1.0 / 3.0);
        }

        public static decimal MeanCubic
                                    (
                                        this Memory<decimal> x
                                    )
        {
            int n = x.Length;

            decimal sum = 0.0m;

            for (int i = 0; i < n; i++)
            {
                decimal x_i = x.Span[i];
                sum += x_i * x_i * x_i;
            }

            return (decimal) System.Math.Pow((double)sum / n, 1.0 / 3.0);
        }

        //==============================================================================================================

    }
}
