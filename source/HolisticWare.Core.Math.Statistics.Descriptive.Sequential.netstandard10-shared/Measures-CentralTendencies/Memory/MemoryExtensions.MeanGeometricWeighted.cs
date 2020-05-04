using System;
using System.Collections.Generic;
using System.Linq;

using Core.Math.Statistics.Descriptive.Sequential;

namespace Core.Math.Statistics.Descriptive.Sequential
{
    /// <summary>
    /// Correlation
    /// </summary>
    public static partial class MemoryExtensionsMeanGeometricWeighted
    {
        //==============================================================================================================
        public static double MeanGeometricWeighted
                                    (
                                        this Memory<byte> x
                                        , Memory<double> w
                                    )
        {
            int n = x.Length;

            if (n != w.Length)
            {
                throw new ArgumentException($"Weight Collection {w} must have the same number of elements!");
            }

            double sum = 0.0;
            double sum_w = 0.0;

            for (int i = 0; i < n; i++)
            {
                byte x_i = x.Span[i];
                double w_i = w.Span[i];
                sum += System.Math.Log(x_i) * w_i;
                sum_w += w_i;
            }

            return System.Math.Exp(sum / sum_w);
        }

        public static double MeanGeometricWeighted
                                    (
                                        this Memory<short> x,
                                        Memory<double> w
                                    )
        {
            int n = x.Length;

            if (n != w.Length)
            {
                throw new ArgumentException($"Weight Collection {w} must have the same number of elements!");
            }

            double sum = 0.0;
            double sum_w = 0.0;

            for (int i = 0; i < n; i++)
            {
                short x_i = x.Span[i];
                double w_i = w.Span[i];
                sum += System.Math.Log(x_i) * w_i;
                sum_w += w_i;
            }

            return System.Math.Exp(sum / sum_w);
        }

        public static double MeanGeometricWeighted
                                    (
                                        this Memory<ushort> x,
                                        Memory<double> w
                                    )
        {
            int n = x.Length;

            if (n != w.Length)
            {
                throw new ArgumentException($"Weight Collection {w} must have the same number of elements!");
            }

            double sum = 0.0;
            double sum_w = 0.0;

            for (int i = 0; i < n; i++)
            {
                ushort x_i = x.Span[i];
                double w_i = w.Span[i];
                sum += System.Math.Log(x_i) * w_i;
                sum_w += w_i;
            }

            return System.Math.Exp(sum / sum_w);
        }

        public static double MeanGeometricWeighted
                                    (
                                        this Memory<int> x,
                                        Memory<double> w
                                    )
        {
            int n = x.Length;

            if (n != w.Length)
            {
                throw new ArgumentException($"Weight Collection {w} must have the same number of elements!");
            }

            double sum = 0.0;
            double sum_w = 0.0;

            for (int i = 0; i < n; i++)
            {
                int x_i = x.Span[i];
                double w_i = w.Span[i];
                sum += System.Math.Log(x_i) * w_i;
                sum_w += w_i;
            }

            return System.Math.Exp(sum / sum_w);
        }

        public static double MeanGeometricWeighted
                                    (
                                        this Memory<uint> x,
                                        Memory<double> w
                                    )
        {
            int n = x.Length;

            if (n != w.Length)
            {
                throw new ArgumentException($"Weight Collection {w} must have the same number of elements!");
            }

            double sum = 0.0;
            double sum_w = 0.0;

            for (int i = 0; i < n; i++)
            {
                uint x_i = x.Span[i];
                double w_i = w.Span[i];
                sum += System.Math.Log(x_i) * w_i;
                sum_w += w_i;
            }

            return System.Math.Exp(sum / sum_w);
        }

        public static double MeanGeometricWeighted
                                    (
                                        this Memory<long> x,
                                        Memory<double> w
                                    )
        {
            int n = x.Length;

            if (n != w.Length)
            {
                throw new ArgumentException($"Weight Collection {w} must have the same number of elements!");
            }

            double sum = 0.0;
            double sum_w = 0.0;

            for (int i = 0; i < n; i++)
            {
                long x_i = x.Span[i];
                double w_i = w.Span[i];
                sum += System.Math.Log(x_i) * w_i;
                sum_w += w_i;
            }

            return System.Math.Exp(sum / sum_w);
        }

        public static double MeanGeometricWeighted
                                    (
                                        this Memory<ulong> x,
                                        Memory<double> w
                                    )
        {
            int n = x.Length;

            if (n != w.Length)
            {
                throw new ArgumentException($"Weight Collection {w} must have the same number of elements!");
            }

            double sum = 0.0;
            double sum_w = 0.0;

            for (int i = 0; i < n; i++)
            {
                ulong x_i = x.Span[i];
                double w_i = w.Span[i];
                sum += System.Math.Log(x_i) * w_i;
                sum_w += w_i;
            }

            return System.Math.Exp(sum / sum_w);
        }

        public static double MeanGeometricWeighted
                                    (
                                        this Memory<float> x,
                                        Memory<double> w
                                    )
        {
            int n = x.Length;

            if (n != w.Length)
            {
                throw new ArgumentException($"Weight Collection {w} must have the same number of elements!");
            }

            double sum = 0.0;
            double sum_w = 0.0;

            for (int i = 0; i < n; i++)
            {
                float x_i = x.Span[i];
                double w_i = w.Span[i];
                sum += System.Math.Log(x_i) * w_i;
                sum_w += w_i;
            }

            return System.Math.Exp(sum / sum_w);
        }

        public static double MeanGeometricWeighted
                                    (
                                        this Memory<double> x,
                                        Memory<double> w
                                    )
        {
            int n = x.Length;

            if (n != w.Length)
            {
                throw new ArgumentException($"Weight Collection {w} must have the same number of elements!");
            }

            double sum = 0.0;
            double sum_w = 0.0;

            for (int i = 0; i < n; i++)
            {
                double x_i = x.Span[i];
                double w_i = w.Span[i];
                sum += System.Math.Log(x_i) * w_i;
                sum_w += w_i;
            }

            return System.Math.Exp(sum / sum_w);
        }

        public static decimal MeanGeometricWeighted
                                    (
                                        this Memory<decimal> x,
                                        Memory<double> w
                                    )
        {
            int n = x.Length;

            if (n != w.Length)
            {
                throw new ArgumentException($"Weight Collection {w} must have the same number of elements!");
            }

            decimal sum = 0.0M;
            decimal sum_w = 0.0M;

            for (int i = 0; i < n; i++)
            {
                decimal x_i = x.Span[i];
                double w_i = w.Span[i];
                sum += (decimal)(System.Math.Log((double)x_i) * w_i);
                sum_w += (decimal)w_i;
            }

            return (decimal) System.Math.Exp((double)(sum / sum_w));
        }

        //==============================================================================================================

    }
}
