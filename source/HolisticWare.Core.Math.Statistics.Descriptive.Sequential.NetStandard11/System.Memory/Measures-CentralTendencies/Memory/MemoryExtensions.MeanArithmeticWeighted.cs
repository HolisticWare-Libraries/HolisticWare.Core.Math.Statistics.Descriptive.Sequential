using System;
using System.Collections.Generic;
using System.Linq;

using Core.Linq;
using Core.Math.Statistics.Descriptive.Sequential;

namespace Core.Math.Statistics.Descriptive.Sequential
{
    /// <summary>
    /// Correlation
    /// </summary>
    public static partial class MemoryExtensionsMeanArithmeticWeighted 
    {
        //==============================================================================================================
        public static double MeanArithmeticWeighted
                                    (
                                        this Memory<byte> x,
                                        Memory<double> w
                                    )
        {
            int n = x.Length;

            if (n != w.Length)
            {
                throw new ArgumentException($"Weight Collection {w} must have the same number of elements!");
            }

            if (w.Any(w_i => w_i < 0))
            {
                throw new ArgumentException($"Weight Collection {w} must have non-negative elements!");
            }

            double sum = 0.0;
            double sum_w = 0.0;

            for (int i = 0; i < n; i++)
            {
                byte x_i = x.Span[i];
                double w_i = w.Span[i];
                sum += x_i * w_i;
                sum_w += w_i;
            }

            return sum / sum_w;
        }

        public static double MeanArithmeticWeighted
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

            if (w.Any(w_i => w_i < 0))
            {
                throw new ArgumentException($"Weight Collection {w} must have non-negative elements!");
            }

            double sum = 0.0;
            double sum_w = 0.0;

            for (int i = 0; i < n; i++)
            {
                short x_i = x.Span[i];
                double w_i = w.Span[i];
                sum += x_i * w_i;
                sum_w += w_i;
            }

            return sum / sum_w;
        }

        public static double MeanArithmeticWeighted
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

            if (w.Any(w_i => w_i < 0))
            {
                throw new ArgumentException($"Weight Collection {w} must have non-negative elements!");
            }

            double sum = 0.0;
            double sum_w = 0.0;

            for (int i = 0; i < n; i++)
            {
                ushort x_i = x.Span[i];
                double w_i = w.Span[i];
                sum += x_i * w_i;
                sum_w += w_i;
            }

            return sum / sum_w;
        }

        public static double MeanArithmeticWeighted
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

            if (w.Any(w_i => w_i < 0))
            {
                throw new ArgumentException($"Weight Collection {w} must have non-negative elements!");
            }

            double sum = 0.0;
            double sum_w = 0.0;

            for (int i = 0; i < n; i++)
            {
                int x_i = x.Span[i];
                double w_i = w.Span[i];
                sum += x_i * w_i;
                sum_w += w_i;
            }

            return sum / sum_w;
        }

        public static double MeanArithmeticWeighted
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

            if (w.Any(w_i => w_i < 0))
            {
                throw new ArgumentException($"Weight Collection {w} must have non-negative elements!");
            }

            double sum = 0.0;
            double sum_w = 0.0;

            for (int i = 0; i < n; i++)
            {
                uint x_i = x.Span[i];
                double w_i = w.Span[i];
                sum += x_i * w_i;
                sum_w += w_i;
            }

            return sum / sum_w;
        }

        public static double MeanArithmeticWeighted
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

            if (w.Any(w_i => w_i < 0))
            {
                throw new ArgumentException($"Weight Collection {w} must have non-negative elements!");
            }

            double sum = 0.0;
            double sum_w = 0.0;

            for (int i = 0; i < n; i++)
            {
                long x_i = x.Span[i];
                double w_i = w.Span[i];
                sum += x_i * w_i;
                sum_w += w_i;
            }

            return sum / sum_w;
        }

        public static double MeanArithmeticWeighted
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

            if (w.Any(w_i => w_i < 0))
            {
                throw new ArgumentException($"Weight Collection {w} must have non-negative elements!");
            }

            double sum = 0.0;
            double sum_w = 0.0;

            for (int i = 0; i < n; i++)
            {
                ulong x_i = x.Span[i];
                double w_i = w.Span[i];
                sum += x_i * w_i;
                sum_w += w_i;
            }

            return sum / sum_w;
        }

        public static double MeanArithmeticWeighted
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

            if (w.Any(w_i => w_i < 0))
            {
                throw new ArgumentException($"Weight Collection {w} must have non-negative elements!");
            }

            double sum = 0.0;
            double sum_w = 0.0;

            for (int i = 0; i < n; i++)
            {
                float x_i = x.Span[i];
                double w_i = w.Span[i];
                sum += x_i * w_i;
                sum_w += w_i;
            }

            return sum / sum_w;
        }

        public static double MeanArithmeticWeighted
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

            if (w.Any(w_i => w_i < 0))
            {
                throw new ArgumentException($"Weight Collection {w} must have non-negative elements!");
            }

            double sum = 0.0;
            double sum_w = 0.0;

            for (int i = 0; i < n; i++)
            {
                double x_i = x.Span[i];
                double w_i = w.Span[i];
                sum += x_i * w_i;
                sum_w += w_i;
            }

            return sum / sum_w;
        }

        public static decimal MeanArithmeticWeighted
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

            if (w.Any(w_i => w_i < 0))
            {
                throw new ArgumentException($"Weight Collection {w} must have non-negative elements!");
            }

            decimal sum = 0.0M;
            decimal sum_w = 0.0M;

            for (int i = 0; i < n; i++)
            {
                decimal x_i = x.Span[i];
                decimal w_i = (decimal)w.Span[i];
                sum += x_i * w_i;
                sum_w += w_i;
            }

            return sum / sum_w;
        }

        //==============================================================================================================

    }
}
