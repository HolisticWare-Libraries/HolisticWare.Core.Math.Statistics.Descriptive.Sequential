using System;
using System.Collections.Generic;
using System.Linq;

using Core.Math.Statistics.Descriptive;

namespace Core.Math.Statistics.Descriptive
{
    /// <summary>
    /// Mean (Average) Geometric
    /// </summary>
    /// <see href="https://en.wikipedia.org/wiki/Average"/>
    public static partial class IEnumerableExtensionsMeanGeometric
    {
        //==============================================================================================================
        public static double MeanGeometricAsync
                                        (
                                            this IEnumerable<byte> x
                                        )
        {
            int n = x.Count();

            double product = 1.0;

            for (int i = 0; i < n; i++)
            {
                byte x_i = x.ElementAt(i);
                product *= x_i;
            }

            return System.Math.Pow(product, 1.0 / n);
        }

        public static double MeanGeometricAsync
                                        (
                                            this IEnumerable<ushort> x
                                        )
        {
            int n = x.Count();

            double product = 1.0;

            for(int i = 0; i < n; i++)
            {
                ushort x_i = x.ElementAt(i);
                product *= x_i;
            }

            return System.Math.Pow(product, 1.0 / n);
        }

        public static double MeanGeometricAsync
                                        (
                                            this IEnumerable<short> x
                                        )
        {
            int n = x.Count();

            double product = 1.0;

            for (int i = 0; i < n; i++)
            {

                short x_i = x.ElementAt(i);
                product *= x_i;
            }

            return System.Math.Pow(product, 1.0 / n);
        }

        public static double MeanGeometricAsync
                                        (
                                            this IEnumerable<int> x
                                        )
        {
            int n = x.Count();

            double product = 1.0;

            for (int i = 0; i < n; i++)
            {
                int x_i = x.ElementAt(i);
                product *= x_i;
            }

            return System.Math.Pow(product, 1.0 / n);
        }

        public static double MeanGeometricAsync
                                        (
                                            this IEnumerable<uint> x
                                        )
        {
            int n = x.Count();

            double product = 1.0;

            for (int i = 0; i < n; i++)
            {
                uint x_i = x.ElementAt(i);
                product *= x_i;
            }

            return System.Math.Pow(product, 1.0 / n);
        }

        public static double MeanGeometricAsync
                                        (
                                            this IEnumerable<long> x
                                        )
        {
            int n = x.Count();

            double product = 1.0;

            for (int i = 0; i < n; i++)
            {
                long x_i = x.ElementAt(i);
                product *= x_i;
            }

            return System.Math.Pow(product, 1.0 / n);
        }

        public static double MeanGeometricAsync
                                        (
                                            this IEnumerable<ulong> x
                                        )
        {
            int n = x.Count();

            double product = 1.0;

            for (int i = 0; i < n; i++)
            {
                ulong x_i = x.ElementAt(i);
                product *= x_i;
            }

            return System.Math.Pow(product, 1.0 / n);
        }

        public static double MeanGeometricAsync
                                        (
                                            this IEnumerable<float> x
                                        )
        {
            int n = x.Count();

            double product = 1.0;

            for (int i = 0; i < n; i++)
            {
                float x_i = x.ElementAt(i);
                product *= x_i;
            }

            return System.Math.Pow(product, 1.0 / n);
        }

        public static double MeanGeometricAsync
                                        (
                                            this IEnumerable<double> x
                                        )
        {
            int n = x.Count();

            double product = 1.0;

            for (int i = 0; i < n; i++)
            {
                double x_i = x.ElementAt(i);
                product *= x_i;
            }

            return System.Math.Pow(product, 1.0 / n);
        }

        public static decimal MeanGeometricAsync(this IEnumerable<decimal> x)
        {
            int n = x.Count();

            decimal product = 1.0M;

            for (int i = 0; i < n; i++)
            {
                decimal x_i = x.ElementAt(i);
                product *= x_i;
            }

            return (decimal) System.Math.Pow((double)product, 1.0 / n);
        }
        //==============================================================================================================

    }
}
