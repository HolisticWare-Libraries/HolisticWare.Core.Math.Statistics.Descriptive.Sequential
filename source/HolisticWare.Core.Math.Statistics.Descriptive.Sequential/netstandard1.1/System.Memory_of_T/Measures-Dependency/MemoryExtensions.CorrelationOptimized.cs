using System;
using System.Collections.Generic;
using System.Linq;

using Core.LINQ.Memory;
using Core.Math.Statistics.Descriptive;


namespace Core.Math.Statistics.Descriptive
{
    /// <summary>
    /// Correlation Optimized version
    /// </summary>
    /// <see href="https://en.wikipedia.org/wiki/Correlation_and_dependence"/> 
    /// <see href="http://www.mathsisfun.com/data/correlation.html"/>
    public static partial class MemoryExtensionsCorrelationOptimized
    {
        //==============================================================================================================
        public static double CorrelationOptimized
                                            (
                                                this Memory<byte> x, 
                                                Memory<byte> y
                                            )
        {
            int n = x.Count();

            double sum_x = 0.0;
            double sum_y = 0.0;
            double sum_x_pow_2 = 0.0;
            double sum_y_pow_2 = 0.0;
            double sum_product_x_y = 0.0;

            for (int i = 0; i < n; i++)
            {
                short x_i = x.ElementAt(i);
                short y_i = y.ElementAt(i);

                sum_x += x_i;
                sum_y += y_i;
                sum_x_pow_2 += x_i * x_i;
                sum_y_pow_2 += y_i * y_i;
                sum_product_x_y += x_i * y_i;
            }

            double tmp_x = n * sum_x_pow_2 - sum_x * sum_x;
            double tmp_y = n * sum_y_pow_2 - sum_y * sum_y;
            double denominator = System.Math.Sqrt(tmp_x) * System.Math.Sqrt(tmp_y);

            if (System.Math.Abs(denominator) < Double.Epsilon)
            {
                return 0.0;
            }

            double correlation =
                (n * sum_product_x_y - sum_x * sum_y)
                /
                denominator
                ;

            return correlation;
        }

        public static double CorrelationOptimized
                                            (
                                                this Memory<short> x, 
                                                Memory<short> y
                                            )
        {
            int n = x.Count();

            double sum_x = 0.0;
            double sum_y = 0.0;
            double sum_x_pow_2 = 0.0;
            double sum_y_pow_2 = 0.0;
            double sum_product_x_y = 0.0;

            for (int i = 0; i < n; i++)
            {
                short x_i = x.ElementAt(i);
                short y_i = y.ElementAt(i);

                sum_x += x_i;
                sum_y += y_i;
                sum_x_pow_2 += x_i * x_i;
                sum_y_pow_2 += y_i * y_i;
                sum_product_x_y += x_i * y_i;
            }

            double tmp_x = n * sum_x_pow_2 - sum_x * sum_x;
            double tmp_y = n * sum_y_pow_2 - sum_y * sum_y;
            double denominator = System.Math.Sqrt(tmp_x) * System.Math.Sqrt(tmp_y);

            if (System.Math.Abs(denominator) < Double.Epsilon)
            {
                return 0.0;
            }

            double correlation =
                (n * sum_product_x_y - sum_x * sum_y)
                /
                denominator
                ;

            return correlation;
        }

        public static double CorrelationOptimized
                                            (
                                                this Memory<ushort> x, 
                                                Memory<ushort> y
                                            )
        {
            int n = x.Count();

            double sum_x = 0.0;
            double sum_y = 0.0;
            double sum_x_pow_2 = 0.0;
            double sum_y_pow_2 = 0.0;
            double sum_product_x_y = 0.0;

            for (int i = 0; i < n; i++)
            {
                ushort x_i = x.ElementAt(i);
                ushort y_i = y.ElementAt(i);

                sum_x += x_i;
                sum_y += y_i;
                sum_x_pow_2 += x_i * x_i;
                sum_y_pow_2 += y_i * y_i;
                sum_product_x_y += x_i * y_i;
            }

            double tmp_x = n * sum_x_pow_2 - sum_x * sum_x;
            double tmp_y = n * sum_y_pow_2 - sum_y * sum_y;
            double denominator = System.Math.Sqrt(tmp_x) * System.Math.Sqrt(tmp_y);

            if (System.Math.Abs(denominator) < Double.Epsilon)
            {
                return 0.0;
            }

            double correlation =
                (n * sum_product_x_y - sum_x * sum_y)
                /
                denominator
                ;

            return correlation;
        }

        public static double CorrelationOptimized
                                            (
                                                this Memory<int> x, 
                                                Memory<int> y
                                            )
        {
            int n = x.Count();

            double sum_x = 0.0;
            double sum_y = 0.0;
            double sum_x_pow_2 = 0.0;
            double sum_y_pow_2 = 0.0;
            double sum_product_x_y = 0.0;

            for (int i = 0; i < n; i++)
            {
                int x_i = x.ElementAt(i);
                int y_i = y.ElementAt(i);

                sum_x += x_i;
                sum_y += y_i;
                sum_x_pow_2 += x_i * x_i;
                sum_y_pow_2 += y_i * y_i;
                sum_product_x_y += x_i * y_i;
            }

            double tmp_x = n * sum_x_pow_2 - sum_x * sum_x;
            double tmp_y = n * sum_y_pow_2 - sum_y * sum_y;
            double denominator = System.Math.Sqrt(tmp_x) * System.Math.Sqrt(tmp_y);

            if (System.Math.Abs(denominator) < Double.Epsilon)
            {
                return 0.0;
            }

            double correlation =
                (n * sum_product_x_y - sum_x * sum_y)
                /
                denominator
                ;

            return correlation;
        }

        public static double CorrelationOptimized
                                            (
                                                this Memory<uint> x, 
                                                Memory<uint> y
                                            )
        {
            int n = x.Count();

            double sum_x = 0.0;
            double sum_y = 0.0;
            double sum_x_pow_2 = 0.0;
            double sum_y_pow_2 = 0.0;
            double sum_product_x_y = 0.0;

            for (int i = 0; i < n; i++)
            {
                uint x_i = x.ElementAt(i);
                uint y_i = y.ElementAt(i);

                sum_x += x_i;
                sum_y += y_i;
                sum_x_pow_2 += x_i * x_i;
                sum_y_pow_2 += y_i * y_i;
                sum_product_x_y += x_i * y_i;
            }

            double tmp_x = n * sum_x_pow_2 - sum_x * sum_x;
            double tmp_y = n * sum_y_pow_2 - sum_y * sum_y;
            double denominator = System.Math.Sqrt(tmp_x) * System.Math.Sqrt(tmp_y);

            if (System.Math.Abs(denominator) < Double.Epsilon)
            {
                return 0.0;
            }

            double correlation =
                (n * sum_product_x_y - sum_x * sum_y)
                /
                denominator
                ;

            return correlation;
        }

        public static double CorrelationOptimized
                                            (
                                                this Memory<long> x, 
                                                Memory<long> y
                                            )
        {
            int n = x.Count();

            double sum_x = 0.0;
            double sum_y = 0.0;
            double sum_x_pow_2 = 0.0;
            double sum_y_pow_2 = 0.0;
            double sum_product_x_y = 0.0;

            for (int i = 0; i < n; i++)
            {
                long x_i = x.ElementAt(i);
                long y_i = y.ElementAt(i);

                sum_x += x_i;
                sum_y += y_i;
                sum_x_pow_2 += x_i * x_i;
                sum_y_pow_2 += y_i * y_i;
                sum_product_x_y += x_i * y_i;
            }

            double tmp_x = n * sum_x_pow_2 - sum_x * sum_x;
            double tmp_y = n * sum_y_pow_2 - sum_y * sum_y;
            double denominator = System.Math.Sqrt(tmp_x) * System.Math.Sqrt(tmp_y);

            if (System.Math.Abs(denominator) < Double.Epsilon)
            {
                return 0.0;
            }

            double correlation =
                (n * sum_product_x_y - sum_x * sum_y)
                /
                denominator
                ;

            return correlation;
        }

        public static double CorrelationOptimized
                                            (
                                                this Memory<ulong> x, 
                                                Memory<ulong> y
                                            )
        {
            int n = x.Count();

            double sum_x = 0.0;
            double sum_y = 0.0;
            double sum_x_pow_2 = 0.0;
            double sum_y_pow_2 = 0.0;
            double sum_product_x_y = 0.0;

            for (int i = 0; i < n; i++)
            {
                ulong x_i = x.ElementAt(i);
                ulong y_i = y.ElementAt(i);

                sum_x += x_i;
                sum_y += y_i;
                sum_x_pow_2 += x_i * x_i;
                sum_y_pow_2 += y_i * y_i;
                sum_product_x_y += x_i * y_i;
            }

            double tmp_x = n * sum_x_pow_2 - sum_x * sum_x;
            double tmp_y = n * sum_y_pow_2 - sum_y * sum_y;
            double denominator = System.Math.Sqrt(tmp_x) * System.Math.Sqrt(tmp_y);

            if (System.Math.Abs(denominator) < Double.Epsilon)
            {
                return 0.0;
            }

            double correlation =
                (n * sum_product_x_y - sum_x * sum_y)
                /
                denominator
                ;

            return correlation;
        }

        public static double CorrelationOptimized
                                            (
                                                this Memory<float> x, 
                                                Memory<float> y
                                            )
        {
            int n = x.Count();

            double sum_x = 0.0;
            double sum_y = 0.0;
            double sum_x_pow_2 = 0.0;
            double sum_y_pow_2 = 0.0;
            double sum_product_x_y = 0.0;

            for (int i = 0; i < n; i++)
            {
                float x_i = x.ElementAt(i);
                float y_i = y.ElementAt(i);

                sum_x += x_i;
                sum_y += y_i;
                sum_x_pow_2 += x_i * x_i;
                sum_y_pow_2 += y_i * y_i;
                sum_product_x_y += x_i * y_i;
            }

            double tmp_x = n * sum_x_pow_2 - sum_x * sum_x;
            double tmp_y = n * sum_y_pow_2 - sum_y * sum_y;
            double denominator = System.Math.Sqrt(tmp_x) * System.Math.Sqrt(tmp_y);

            if (System.Math.Abs(denominator) < Double.Epsilon)
            {
                return 0.0;
            }

            double correlation =
                (n * sum_product_x_y - sum_x * sum_y)
                /
                denominator
                ;

            return correlation;
        }

        public static double CorrelationOptimized
                                            (
                                                this Memory<double> x, 
                                                Memory<double> y
                                            )
        {
            int n = x.Count();

            double sum_x = 0.0;
            double sum_y = 0.0;
            double sum_x_pow_2 = 0.0;
            double sum_y_pow_2 = 0.0;
            double sum_product_x_y = 0.0;

            for (int i = 0; i < n; i++)
            {
                double x_i = x.ElementAt(i);
                double y_i = y.ElementAt(i);

                sum_x += x_i;
                sum_y += y_i;
                sum_x_pow_2 += x_i * x_i;
                sum_y_pow_2 += y_i * y_i;
                sum_product_x_y += x_i * y_i;
            }

            double tmp_x = n * sum_x_pow_2 - sum_x * sum_x;
            double tmp_y = n * sum_y_pow_2 - sum_y * sum_y;
            double denominator = System.Math.Sqrt(tmp_x) * System.Math.Sqrt(tmp_y);

            if (System.Math.Abs(denominator) < Double.Epsilon)
            {
                return 0.0;
            }

            double correlation =
                (n * sum_product_x_y - sum_x * sum_y)
                /
                denominator
                ;

            return correlation;
        }

        public static decimal CorrelationOptimized
                                            (
                                                this Memory<decimal> x, 
                                                Memory<decimal> y
                                            )
        {
            int n = x.Count();

            decimal sum_x = 0.0M;
            decimal sum_y = 0.0M;
            decimal sum_x_pow_2 = 0.0M;
            decimal sum_y_pow_2 = 0.0M;
            decimal sum_product_x_y = 0.0M;

            for (int i = 0; i < n; i++)
            {
                decimal x_i = x.ElementAt(i);
                decimal y_i = y.ElementAt(i);

                sum_x += x_i;
                sum_y += y_i;
                sum_x_pow_2 += x_i * x_i;
                sum_y_pow_2 += y_i * y_i;
                sum_product_x_y += x_i * y_i;
            }

            decimal tmp_x = n * sum_x_pow_2 - sum_x * sum_x;
            decimal tmp_y = n * sum_y_pow_2 - sum_y * sum_y;
            decimal denominator = (decimal)(System.Math.Sqrt((double)tmp_x) * System.Math.Sqrt((double)tmp_y));

            if (denominator == decimal.Zero)
            {
                return 0.0M;
            }

            decimal correlation =
                (n * sum_product_x_y - sum_x * sum_y)
                /
                denominator
                ;

            return correlation;
        }
        //==============================================================================================================

    }
}
