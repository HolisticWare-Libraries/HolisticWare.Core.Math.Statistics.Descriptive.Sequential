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
    public static partial class
                                        IEnumerableExtensionsMeanGeometricNaive
    {
        //==============================================================================================================
        public static
            double
                                        MeanGeometricNaive
                                        (
                                            this IEnumerable<byte> x
                                        )
        {
            int n = x.Count();

            double sum = 1.0;

            for (int i = 0; i < n; i++)
            {
                byte x_i = x.ElementAt(i);
                sum += System.Math.Log(x_i);
            }

            return System.Math.Exp(sum / n);
        }

        public static
            double
                                        MeanGeometricNaive
                                        (
                                            this IEnumerable<ushort> x
                                        )
        {
            int n = x.Count();

            double sum = 1.0;

            for(int i = 0; i < n; i++)
            {
                ushort x_i = x.ElementAt(i);
                sum += System.Math.Log(x_i);
            }

            return System.Math.Exp(sum / n);
        }

        public static
            double
                                        MeanGeometricNaive
                                        (
                                            this IEnumerable<short> x
                                        )
        {
            int n = x.Count();

            double sum = 1.0;

            for (int i = 0; i < n; i++)
            {

                short x_i = x.ElementAt(i);
                sum += System.Math.Log(x_i);
            }

            return System.Math.Exp(sum / n);
        }

        public static
            double
                                        MeanGeometricNaive
                                        (
                                            this IEnumerable<int> x
                                        )
        {
            int n = x.Count();

            double sum = 1.0;

            for (int i = 0; i < n; i++)
            {
                int x_i = x.ElementAt(i);
                sum += System.Math.Log(x_i);
            }

            return System.Math.Exp(sum / n);
        }

        public static
            double
                                        MeanGeometricNaive
                                        (
                                            this IEnumerable<uint> x
                                        )
        {
            int n = x.Count();

            double sum = 1.0;

            for (int i = 0; i < n; i++)
            {
                uint x_i = x.ElementAt(i);
                sum += System.Math.Log(x_i);
            }

            return System.Math.Exp(sum / n);
        }

        public static
            double
                                        MeanGeometricNaive
                                        (
                                            this IEnumerable<long> x
                                        )
        {
            int n = x.Count();

            double sum = 1.0;

            for (int i = 0; i < n; i++)
            {
                long x_i = x.ElementAt(i);
                sum += System.Math.Log(x_i);
            }

            return System.Math.Exp(sum / n);
        }

        public static
            double
                                        MeanGeometricNaive
                                        (
                                            this IEnumerable<ulong> x
                                        )
        {
            int n = x.Count();

            double sum = 1.0;

            for (int i = 0; i < n; i++)
            {
                ulong x_i = x.ElementAt(i);
                sum += System.Math.Log(x_i);
            }

            return System.Math.Exp(sum / n);
        }

        public static
            double
                                        MeanGeometricNaive
                                        (
                                            this IEnumerable<float> x
                                        )
        {
            int n = x.Count();

            double sum = 1.0;

            for (int i = 0; i < n; i++)
            {
                float x_i = x.ElementAt(i);
                sum += System.Math.Log(x_i);
            }

            return System.Math.Exp(sum / n);
        }

        public static
            double
                                        MeanGeometricNaive
                                        (
                                            this IEnumerable<double> x
                                        )
        {
            int n = x.Count();

            double sum = 1.0;

            for (int i = 0; i < n; i++)
            {
                double x_i = x.ElementAt(i);
                sum += System.Math.Log(x_i);
            }

            return System.Math.Exp(sum / n);
        }

        public static
            decimal
                                        MeanGeometricNaive
                                        (
                                            this IEnumerable<decimal> x
                                        )
        {
            int n = x.Count();

            decimal sum = 1.0M;

            for (int i = 0; i < n; i++)
            {
                decimal x_i = x.ElementAt(i);
                sum += (decimal) System.Math.Log((double)x_i);
            }

            return (decimal) System.Math.Pow((double)sum, 1.0 / n);
        }
        //==============================================================================================================

    }
}
