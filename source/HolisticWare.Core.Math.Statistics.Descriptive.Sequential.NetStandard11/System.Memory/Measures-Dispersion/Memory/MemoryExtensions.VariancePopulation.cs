using System;
using System.Collections.Generic;
using System.Linq;

namespace Core.Math.Statistics.Descriptive.Sequential
{
    public static partial class MemoryExtensionsVariancePopulation
    {
        //==============================================================================================================
        public static double VariancePopulation
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

            return sum_suquares / n;
        }

        public static double VariancePopulation
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

            return sum_suquares / n;
        }

        public static double VariancePopulation
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

            return sum_suquares / n;
        }

        public static double VariancePopulation
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

            return sum_suquares / n;
        }

        public static double VariancePopulation
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

            return sum_suquares / n;
        }

        public static double VariancePopulation
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

            return sum_suquares / n;
        }

        public static double VariancePopulation
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

            return sum_suquares / n;
        }

        public static double VariancePopulation
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

            return sum_suquares / n;
        }

        public static double VariancePopulation
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

            return sum_suquares / n;
        }

        public static decimal VariancePopulation
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

            return sum_suquares / n;
        }
        //==============================================================================================================

    }
}
