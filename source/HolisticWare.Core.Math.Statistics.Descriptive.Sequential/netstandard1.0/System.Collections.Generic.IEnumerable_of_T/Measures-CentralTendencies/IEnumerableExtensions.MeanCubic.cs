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
    public static partial class
                                        IEnumerableExtensionsMeanCubic
    {
        //==============================================================================================================
        public static
            double
                                        MeanCubic
                                        (
                                            this IEnumerable<byte> x
                                        )
        {
            int n = x.Count();

            double sum = 0.0;

            for (int i = 0; i < n; i++)
            {
                byte x_i = x.ElementAt(i);
                sum += x_i * x_i * x_i;
            }

            return System.Math.Pow(sum / n, 1.0 / 3.0);
        }

        public static
            double
                                        MeanCubic
                                        (
                                            this IEnumerable<short> x
                                        )
        {
            int n = x.Count();

            double sum = 0.0;

            for (int i = 0; i < n; i++)
            {
                short x_i = x.ElementAt(i);
                sum += x_i * x_i * x_i;
            }

            return System.Math.Pow(sum / n, 1.0 / 3.0);
        }

        public static
            double
                                        MeanCubic
                                        (
                                            this IEnumerable<ushort> x
                                        )
        {
            int n = x.Count();

            double sum = 0.0;

            for (int i = 0; i < n; i++)
            {
                ushort x_i = x.ElementAt(i);
                sum += x_i * x_i * x_i;
            }

            return System.Math.Pow(sum / n, 1.0 / 3.0);
        }

        public static
            double
                                        MeanCubic
                                        (
                                            this IEnumerable<int> x
                                        )
        {
            int n = x.Count();

            double sum = 0.0;

            for (int i = 0; i < n; i++)
            {
                int x_i = x.ElementAt(i);
                sum += x_i * x_i * x_i;
            }

            return System.Math.Pow(sum / n, 1.0 / 3.0);
        }

        public static
            double
                                        MeanCubic
                                        (
                                            this IEnumerable<uint> x
                                        )
        {
            int n = x.Count();

            double sum = 0.0;

            for (int i = 0; i < n; i++)
            {
                uint x_i = x.ElementAt(i);
                sum += x_i * x_i * x_i;
            }

            return System.Math.Pow(sum / n, 1.0 / 3.0);
        }

        public static
            double
                                        MeanCubic
                                        (
                                            this IEnumerable<long> x
                                        )
        {
            int n = x.Count();

            double sum = 0.0;

            for (int i = 0; i < n; i++)
            {
                long x_i = x.ElementAt(i);
                sum += x_i * x_i * x_i;
            }

            return System.Math.Pow(sum / n, 1.0 / 3.0);
        }

        public static
            double
                                        MeanCubic
                                        (
                                            this IEnumerable<ulong> x
                                        )
        {
            int n = x.Count();

            double sum = 0.0;

            for (int i = 0; i < n; i++)
            {
                ulong x_i = x.ElementAt(i);
                sum += x_i * x_i * x_i;
            }

            return System.Math.Pow(sum / n, 1.0 / 3.0);
        }

        public static
            double
                                        MeanCubic
                                        (
                                            this IEnumerable<float> x
                                        )
        {
            int n = x.Count();

            double sum = 0.0;

            for (int i = 0; i < n; i++)
            {
                float x_i = x.ElementAt(i);
                sum += x_i * x_i * x_i;
            }

            return System.Math.Pow(sum / n, 1.0 / 3.0);
        }

        public static
            double
                                        MeanCubic
                                        (
                                            this IEnumerable<double> x
                                        )
        {
            int n = x.Count();

            double sum = 0.0;

            for (int i = 0; i < n; i++)
            {
                double x_i = x.ElementAt(i);
                sum += x_i * x_i * x_i;
            }

            return System.Math.Pow(sum / n, 1.0 / 3.0);
        }

        public static
            decimal
                                        MeanCubic
                                        (
                                            this IEnumerable<decimal> x
                                        )
        {
            int n = x.Count();

            decimal sum = 0.0m;

            for (int i = 0; i < n; i++)
            {
                decimal x_i = x.ElementAt(i);
                sum += x_i * x_i * x_i;
            }

            return (decimal) System.Math.Pow((double)sum / n, 1.0 / 3.0);
        }
        //==============================================================================================================

    }
}
