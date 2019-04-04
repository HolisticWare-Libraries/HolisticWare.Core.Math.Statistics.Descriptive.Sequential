using System;
using System.Collections.Generic;
using System.Linq;

using Core.Math.Statistics.Descriptive.Sequential;

namespace Core.Math.Statistics.Descriptive.Sequential
{
    /// <summary>
    /// Mean (Average) Geometric
    /// </summary>
    /// <see cref="https://en.wikipedia.org/wiki/Average"/>
    public static partial class MemoryExtensionsMeanGeometricNaive
    {
        //==============================================================================================================
        public static double MeanGeometricNaive
                                        (
                                            this Memory<byte> x
                                        )
        {
            int n = x.Length;

            double sum = 1.0;

            for (int i = 0; i < n; i++)
            {
                byte x_i = x.Span[i];
                sum += System.Math.Log(x_i);
            }

            return System.Math.Exp(sum / n);
        }

        public static double MeanGeometricNaive
                                        (
                                            this Memory<ushort> x
                                        )
        {
            int n = x.Length;

            double sum = 1.0;

            for(int i = 0; i < n; i++)
            {
                ushort x_i = x.Span[i];
                sum += System.Math.Log(x_i);
            }

            return System.Math.Exp(sum / n);
        }

        public static double MeanGeometricNaive
                                        (
                                            this Memory<short> x
                                        )
        {
            int n = x.Length;

            double sum = 1.0;

            for (int i = 0; i < n; i++)
            {

                short x_i = x.Span[i];
                sum += System.Math.Log(x_i);
            }

            return System.Math.Exp(sum / n);
        }

        public static double MeanGeometricNaive
                                        (
                                            this Memory<int> x
                                        )
        {
            int n = x.Length;

            double sum = 1.0;

            for (int i = 0; i < n; i++)
            {
                int x_i = x.Span[i];
                sum += System.Math.Log(x_i);
            }

            return System.Math.Exp(sum / n);
        }

        public static double MeanGeometricNaive
                                        (
                                            this Memory<uint> x
                                        )
        {
            int n = x.Length;

            double sum = 1.0;

            for (int i = 0; i < n; i++)
            {
                uint x_i = x.Span[i];
                sum += System.Math.Log(x_i);
            }

            return System.Math.Exp(sum / n);
        }

        public static double MeanGeometricNaive
                                        (
                                            this Memory<long> x
                                        )
        {
            int n = x.Length;

            double sum = 1.0;

            for (int i = 0; i < n; i++)
            {
                long x_i = x.Span[i];
                sum += System.Math.Log(x_i);
            }

            return System.Math.Exp(sum / n);
        }

        public static double MeanGeometricNaive
                                        (
                                            this Memory<ulong> x
                                        )
        {
            int n = x.Length;

            double sum = 1.0;

            for (int i = 0; i < n; i++)
            {
                ulong x_i = x.Span[i];
                sum += System.Math.Log(x_i);
            }

            return System.Math.Exp(sum / n);
        }

        public static double MeanGeometricNaive
                                        (
                                            this Memory<float> x
                                        )
        {
            int n = x.Length;

            double sum = 1.0;

            for (int i = 0; i < n; i++)
            {
                float x_i = x.Span[i];
                sum += System.Math.Log(x_i);
            }

            return System.Math.Exp(sum / n);
        }

        public static double MeanGeometricNaive
                                        (
                                            this Memory<double> x
                                        )
        {
            int n = x.Length;

            double sum = 1.0;

            for (int i = 0; i < n; i++)
            {
                double x_i = x.Span[i];
                sum += System.Math.Log(x_i);
            }

            return System.Math.Exp(sum / n);
        }

        public static decimal MeanGeometricNaive(this Memory<decimal> x)
        {
            int n = x.Length;

            decimal sum = 1.0M;

            for (int i = 0; i < n; i++)
            {
                decimal x_i = x.Span[i];
                sum += (decimal) System.Math.Log((double)x_i);
            }

            return (decimal) System.Math.Pow((double)sum, 1.0 / n);
        }
        //==============================================================================================================

    }
}
