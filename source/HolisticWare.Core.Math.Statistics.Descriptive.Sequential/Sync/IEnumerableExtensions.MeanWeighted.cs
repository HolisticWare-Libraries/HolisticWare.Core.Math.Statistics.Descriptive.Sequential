using System;
using System.Collections.Generic;
using System.Linq;

using Core.Math.Statistics.Descriptive.Sequential;

namespace Core.Math.Statistics.Descriptive.Sequential
{
    /// <summary>
    /// Correlation
    /// </summary>
    public static partial class IEnumerableExtensionsMeanWeighted
    {
        //==============================================================================================================
        public static double MeanWeighted(this IEnumerable<byte> x, IEnumerable<double> w)
        {
            int n = x.Count();

            if (n != w.Count())
            {
                throw new ArgumentException($"Weight Collection {w} must have the same number of elements!");
            }

            double sum = 0.0;
            double sum_w = 0.0;

            for (int i = 0; i < n; i++)
            {
                byte x_i = x.ElementAt(i);
                double w_i = w.ElementAt(i);
                sum += x_i * w_i;
                sum_w += w_i;
            }

            return sum / sum_w;
        }

        public static double MeanWeighted(this IEnumerable<short> x, IEnumerable<double> w)
        {
            int n = x.Count();

            if (n != w.Count())
            {
                throw new ArgumentException($"Weight Collection {w} must have the same number of elements!");
            }

            double sum = 0.0;
            double sum_w = 0.0;

            for (int i = 0; i < n; i++)
            {
                short x_i = x.ElementAt(i);
                double w_i = w.ElementAt(i);
                sum += x_i * w_i;
                sum_w += w_i;
            }

            return sum / sum_w;
        }

        public static double MeanWeighted(this IEnumerable<ushort> x, IEnumerable<double> w)
        {
            int n = x.Count();

            if (n != w.Count())
            {
                throw new ArgumentException($"Weight Collection {w} must have the same number of elements!");
            }

            double sum = 0.0;
            double sum_w = 0.0;

            for (int i = 0; i < n; i++)
            {
                ushort x_i = x.ElementAt(i);
                double w_i = w.ElementAt(i);
                sum += x_i * w_i;
                sum_w += w_i;
            }

            return sum / sum_w;
        }

        public static double MeanWeighted(this IEnumerable<int> x, IEnumerable<double> w)
        {
            int n = x.Count();

            if (n != w.Count())
            {
                throw new ArgumentException($"Weight Collection {w} must have the same number of elements!");
            }

            double sum = 0.0;
            double sum_w = 0.0;

            for (int i = 0; i < n; i++)
            {
                int x_i = x.ElementAt(i);
                double w_i = w.ElementAt(i);
                sum += x_i * w_i;
                sum_w += w_i;
            }

            return sum / sum_w;
        }

        public static double MeanWeighted(this IEnumerable<uint> x, IEnumerable<double> w)
        {
            int n = x.Count();

            if (n != w.Count())
            {
                throw new ArgumentException($"Weight Collection {w} must have the same number of elements!");
            }

            double sum = 0.0;
            double sum_w = 0.0;

            for (int i = 0; i < n; i++)
            {
                uint x_i = x.ElementAt(i);
                double w_i = w.ElementAt(i);
                sum += x_i * w_i;
                sum_w += w_i;
            }

            return sum / sum_w;
        }

        public static double MeanWeighted(this IEnumerable<long> x, IEnumerable<double> w)
        {
            int n = x.Count();

            if (n != w.Count())
            {
                throw new ArgumentException($"Weight Collection {w} must have the same number of elements!");
            }

            double sum = 0.0;
            double sum_w = 0.0;

            for (int i = 0; i < n; i++)
            {
                long x_i = x.ElementAt(i);
                double w_i = w.ElementAt(i);
                sum += x_i * w_i;
                sum_w += w_i;
            }

            return sum / sum_w;
        }

        public static double MeanWeighted(this IEnumerable<ulong> x, IEnumerable<double> w)
        {
            int n = x.Count();

            if (n != w.Count())
            {
                throw new ArgumentException($"Weight Collection {w} must have the same number of elements!");
            }

            double sum = 0.0;
            double sum_w = 0.0;

            for (int i = 0; i < n; i++)
            {
                ulong x_i = x.ElementAt(i);
                double w_i = w.ElementAt(i);
                sum += x_i * w_i;
                sum_w += w_i;
            }

            return sum / sum_w;
        }

        public static double MeanWeighted(this IEnumerable<float> x, IEnumerable<double> w)
        {
            int n = x.Count();

            if (n != w.Count())
            {
                throw new ArgumentException($"Weight Collection {w} must have the same number of elements!");
            }

            double sum = 0.0;
            double sum_w = 0.0;

            for (int i = 0; i < n; i++)
            {
                float x_i = x.ElementAt(i);
                double w_i = w.ElementAt(i);
                sum += x_i * w_i;
                sum_w += w_i;
            }

            return sum / sum_w;
        }

        public static double MeanWeighted(this IEnumerable<double> x, IEnumerable<double> w)
        {
            int n = x.Count();

            if (n != w.Count())
            {
                throw new ArgumentException($"Weight Collection {w} must have the same number of elements!");
            }

            double sum = 0.0;
            double sum_w = 0.0;

            for (int i = 0; i < n; i++)
            {
                double x_i = x.ElementAt(i);
                double w_i = w.ElementAt(i);
                sum += x_i * w_i;
                sum_w += w_i;
            }

            return sum / sum_w;
        }

        public static decimal MeanWeighted(this IEnumerable<decimal> x, IEnumerable<double> w)
        {
            int n = x.Count();

            if (n != w.Count())
            {
                throw new ArgumentException($"Weight Collection {w} must have the same number of elements!");
            }

            decimal sum = 0.0M;
            decimal sum_w = 0.0M;

            for (int i = 0; i < n; i++)
            {
                decimal x_i = x.ElementAt(i);
                decimal w_i = (decimal) w.ElementAt(i);
                sum += x_i * w_i;
                sum_w += w_i;
            }

            return sum / sum_w;
        }

        //==============================================================================================================

    }
}
