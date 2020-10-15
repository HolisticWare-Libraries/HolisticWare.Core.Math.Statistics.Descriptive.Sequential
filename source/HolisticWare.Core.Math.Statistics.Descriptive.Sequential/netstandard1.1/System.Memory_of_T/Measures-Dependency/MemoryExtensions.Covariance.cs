using System;
using System.Collections.Generic;
using System.Linq;

using Core.LINQ.Memory;

namespace Core.Math.Statistics.Descriptive
{
    /// <summary>
    /// Covariance
    /// </summary>
    public static partial class MemoryExtensionsCovariance
    {
        //==============================================================================================================
        public static double Covariance
                                    (
                                        this Memory<byte> x, 
                                        Memory<byte> y
                                    )
        {
            long sum_x = 0;
            long sum_y = 0;
            long sum_product_xy = 0;

            int n = x.Count();

            for (int i = 0; i < n; i++)
            {
                byte x_i = x.ElementAt(i);
                byte y_i = y.ElementAt(i);
                sum_x += x_i;
                sum_y += y_i;
                sum_product_xy += x_i * y_i;
            }

            return (sum_product_xy - sum_x * sum_y / n) / (n - 1);
        }

        public static double Covariance
                                    (
                                        this Memory<short> x, 
                                        Memory<short> y
                                    )
        {
            long sum_x = 0;
            long sum_y = 0;
            long sum_product_xy = 0;

            int n = x.Count();

            for (int i = 0; i < n; i++)
            {
                short x_i = x.ElementAt(i);
                short y_i = y.ElementAt(i);
                sum_x += x_i;
                sum_y += y_i;
                sum_product_xy += x_i * y_i;
            }

            return (sum_product_xy - sum_x * sum_y / n) / (n - 1);
        }

        public static double Covariance
                                    (
                                        this Memory<ushort> x, 
                                        Memory<ushort> y
                                    )
        {
            long sum_x = 0;
            long sum_y = 0;
            long sum_product_xy = 0;

            int n = x.Count();

            for (int i = 0; i < n; i++)
            {
                ushort x_i = x.ElementAt(i);
                ushort y_i = y.ElementAt(i);
                sum_x += x_i;
                sum_y += y_i;
                sum_product_xy += x_i * y_i;
            }

            return (sum_product_xy - sum_x * sum_y / n) / (n - 1);
        }

        public static double Covariance
                                    (
                                        this Memory<int> x, 
                                        Memory<int> y
                                    )
        {
            long sum_x = 0;
            long sum_y = 0;
            long sum_product_xy = 0;

            int n = x.Count();

            for (int i = 0; i < n; i++)
            {
                int x_i = x.ElementAt(i);
                int y_i = y.ElementAt(i);
                sum_x += x_i;
                sum_y += y_i;
                sum_product_xy += x_i * y_i;
            }

            return (sum_product_xy - sum_x * sum_y / n) / (n - 1);
        }

        public static double Covariance
                                    (
                                        this Memory<uint> x, 
                                        Memory<uint> y
                                    )
        {
            long sum_x = 0;
            long sum_y = 0;
            long sum_product_xy = 0;

            int n = x.Count();

            for (int i = 0; i < n; i++)
            {
                uint x_i = x.ElementAt(i);
                uint y_i = y.ElementAt(i);
                sum_x += x_i;
                sum_y += y_i;
                sum_product_xy += x_i * y_i;
            }

            return (sum_product_xy - sum_x * sum_y / n) / (n - 1);
        }

        public static double Covariance
                                    (
                                        this Memory<long> x, 
                                        Memory<long> y
                                    )
        {
            double sum_x = 0;
            double sum_y = 0;
            double sum_product_xy = 0;

            int n = x.Count();

            for (int i = 0; i < n; i++)
            {
                long x_i = x.ElementAt(i);
                long y_i = y.ElementAt(i);
                sum_x += x_i;
                sum_y += y_i;
                sum_product_xy += x_i * y_i;
            }

            return (sum_product_xy - sum_x * sum_y / n) / (n - 1);
        }

        public static double Covariance
                                    (
                                        this Memory<ulong> x, 
                                        Memory<ulong> y
                                    )
        {
            double sum_x = 0;
            double sum_y = 0;
            double sum_product_xy = 0;

            int n = x.Count();

            for (int i = 0; i < n; i++)
            {
                ulong x_i = x.ElementAt(i);
                ulong y_i = y.ElementAt(i);
                sum_x += x_i;
                sum_y += y_i;
                sum_product_xy += x_i * y_i;
            }

            return (sum_product_xy - sum_x * sum_y / n) / (n - 1);
        }

        public static double Covariance
                                    (
                                        this Memory<float> x, 
                                        Memory<float> y
                                    )
        {
            double sum_x = 0;
            double sum_y = 0;
            double sum_product_xy = 0;

            int n = x.Count();

            for (int i = 0; i < n; i++)
            {
                float x_i = x.ElementAt(i);
                float y_i = y.ElementAt(i);
                sum_x += x_i;
                sum_y += y_i;
                sum_product_xy += x_i * y_i;
            }

            return (sum_product_xy - sum_x * sum_y / n) / (n - 1);
        }

        public static double Covariance
                                    (
                                        this Memory<double> x, 
                                        Memory<double> y
                                    )
        {
            double sum_x = 0;
            double sum_y = 0;
            double sum_product_xy = 0;

            int n = x.Count();

            for (int i = 0; i < n; i++)
            {
                double x_i = x.ElementAt(i);
                double y_i = y.ElementAt(i);
                sum_x += x_i;
                sum_y += y_i;
                sum_product_xy += x_i * y_i;
            }

            return (sum_product_xy - sum_x * sum_y / n) / (n - 1);
        }

        public static decimal Covariance
                                    (
                                        this Memory<decimal> x, 
                                        Memory<decimal> y
                                    )
        {
            decimal sum_x = 0;
            decimal sum_y = 0;
            decimal sum_product_xy = 0;

            int n = x.Count();

            for (int i = 0; i < n; i++)
            {
                decimal x_i = x.ElementAt(i);
                decimal y_i = y.ElementAt(i);
                sum_x += x_i;
                sum_y += y_i;
                sum_product_xy += x_i * y_i;
            }

            return (sum_product_xy - sum_x * sum_y / n) / (n - 1);
        }
        //==============================================================================================================

    }
}
