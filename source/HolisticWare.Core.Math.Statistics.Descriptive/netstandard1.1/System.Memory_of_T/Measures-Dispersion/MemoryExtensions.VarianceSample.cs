using System;
using System.Linq;

using Core.LINQ.Memory;

namespace Core.Math.Statistics.Descriptive
{
    public static partial class MemoryExtensionsVarianceSample
    {
        //==============================================================================================================
        public static double VarianceSample
                                        (
                                            this Memory<byte> x
                                        )
        {
            double mean = x.Select(x_i => (int)x_i).Average();
            double sum_suquares = 0;

            long n = x.LongCount();

            for (int i = 0; i < n; i++)
            {
                double delta = x.ElementAt(i) - mean;

                sum_suquares += delta * delta;
            }

            return sum_suquares / (n - 1);
        }

        public static double VarianceSample
                                        (
                                            this Memory<short> x
                                        )
        {
            double mean = x.Select(x_i => (int)x_i).Average();
            double sum_suquares = 0;

            long n = x.LongCount();

            for (int i = 0; i < n; i++)
            {
                double delta = x.ElementAt(i) - mean;

                sum_suquares += delta * delta;
            }

            return sum_suquares / (n - 1);
        }

        public static double VarianceSample
                                        (
                                            this Memory<ushort> x
                                        )
        {
            double mean = x.Select(x_i => (int)x_i).Average();
            double sum_suquares = 0;

            long n = x.LongCount();

            for (int i = 0; i < n; i++)
            {
                double delta = x.ElementAt(i) - mean;

                sum_suquares += delta * delta;
            }

            return sum_suquares / (n - 1);
        }

        public static double VarianceSample
                                        (
                                            this Memory<int> x
                                        )
        {
            double mean = x.Average();
            double sum_suquares = 0;

            long n = x.LongCount();

            for (int i = 0; i < n; i++)
            {
                double delta = x.ElementAt(i) - mean;

                sum_suquares += delta * delta;
            }

            return sum_suquares / (n - 1);
        }

        public static double VarianceSample
                                        (
                                            this Memory<uint> x
                                        )
        {
            double mean = x.Select(x_i => (long)x_i).Average();
            double sum_suquares = 0;

            long n = x.LongCount();

            for (int i = 0; i < n; i++)
            {
                double delta = x.ElementAt(i) - mean;

                sum_suquares += delta * delta;
            }

            return sum_suquares / (n - 1);
        }

        public static double VarianceSample
                                        (
                                            this Memory<long> x
                                        )
        {
            double mean = x.Average();
            double sum_suquares = 0;

            long n = x.LongCount();

            for (int i = 0; i < n; i++)
            {
                double delta = x.ElementAt(i) - mean;

                sum_suquares += delta * delta;
            }

            return sum_suquares / (n - 1);
        }

        public static double VarianceSample
                                        (
                                            this Memory<ulong> x
                                        )
        {
            double mean = x.Select(x_i => (double)x_i).Average();
            double sum_suquares = 0;

            long n = x.LongCount();

            for (int i = 0; i < n; i++)
            {
                double delta = x.ElementAt(i) - mean;

                sum_suquares += delta * delta;
            }

            return sum_suquares / (n - 1);
        }

        public static double VarianceSample
                                        (
                                            this Memory<float> x
                                        )
        {
            double mean = x.Average();
            double sum_suquares = 0;

            long n = x.LongCount();

            for (int i = 0; i < n; i++)
            {
                double delta = x.ElementAt(i) - mean;

                sum_suquares += delta * delta;
            }

            return sum_suquares / (n - 1);
        }

        public static double VarianceSample
                                        (
                                            this Memory<double> x
                                        )
        {
            double mean = x.Average();
            double sum_suquares = 0;

            long n = x.LongCount();

            for (int i = 0; i < n; i++)
            {
                double delta = x.ElementAt(i) - mean;

                sum_suquares += delta * delta;
            }

            return sum_suquares / (n - 1);
        }

        public static decimal VarianceSample
                                        (
                                            this Memory<decimal> x
                                        )
        {
            decimal mean = x.Average();
            decimal sum_suquares = 0;

            long n = x.LongCount();

            for (int i = 0; i < n; i++)
            {
                decimal delta = x.ElementAt(i) - mean;

                sum_suquares += delta * delta;
            }

            return sum_suquares / (n - 1);
        }
        //==============================================================================================================

    }
}

