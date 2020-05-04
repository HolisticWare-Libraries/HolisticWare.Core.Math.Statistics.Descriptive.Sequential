using System;
using System.Collections.Generic;
using System.Linq;

namespace Core.Math.Statistics.Descriptive.Sequential
{
    public static partial class MemoryExtensionsVarianceMedianPopulation
    {
        //==============================================================================================================
        public static double VarianceMedianPopulation
                                            (
                                                this Memory<byte> x
                                            )
        {
            double median = x.Median();
            double sum_suquares = 0;

            long n = x.LongCount();

            for (int i = 0; i < n; i++)
            {
                double delta = x.ElementAt(i) - median;

                sum_suquares += delta * delta;
            }

            return sum_suquares / n;
        }

        public static double VarianceMedianPopulation
                                            (
                                                this Memory<short> x
                                            )
        {
            double median = x.Median();
            double sum_suquares = 0;

            long n = x.LongCount();

            for (int i = 0; i < n; i++)
            {
                double delta = x.ElementAt(i) - median;

                sum_suquares += delta * delta;
            }

            return sum_suquares / n;
        }

        public static double VarianceMedianPopulation
                                            (
                                                this Memory<ushort> x
                                            )
        {
            double median = x.Median();
            double sum_suquares = 0;

            long n = x.LongCount();

            for (int i = 0; i < n; i++)
            {
                double delta = x.ElementAt(i) - median;

                sum_suquares += delta * delta;
            }

            return sum_suquares / n;
        }

        public static double VarianceMedianPopulation
                                            (
                                                this Memory<int> x
                                            )
        {
            double median = x.Median();
            double sum_suquares = 0;

            long n = x.LongCount();

            for (int i = 0; i < n; i++)
            {
                double delta = x.ElementAt(i) - median;

                sum_suquares += delta * delta;
            }

            return sum_suquares / n;
        }

        public static double VarianceMedianPopulation
                                            (
                                                this Memory<uint> x
                                            )
        {
            double median = x.Median();
            double sum_suquares = 0;

            long n = x.LongCount();

            for (int i = 0; i < n; i++)
            {
                double delta = x.ElementAt(i) - median;

                sum_suquares += delta * delta;
            }

            return sum_suquares / n;
        }

        public static double VarianceMedianPopulation
                                            (
                                                this Memory<long> x
                                            )
        {
            double median = x.Median();
            double sum_suquares = 0;

            long n = x.LongCount();

            for (int i = 0; i < n; i++)
            {
                double delta = x.ElementAt(i) - median;

                sum_suquares += delta * delta;
            }

            return sum_suquares / n;
        }

        public static double VarianceMedianPopulation
                                            (
                                                this Memory<ulong> x
                                            )
        {
            double median = x.Median();
            double sum_suquares = 0;

            long n = x.LongCount();

            for (int i = 0; i < n; i++)
            {
                double delta = x.ElementAt(i) - median;

                sum_suquares += delta * delta;
            }

            return sum_suquares / n;
        }

        public static double VarianceMedianPopulation
                                            (
                                                this Memory<float> x
                                            )
        {
            double median = x.Median();
            double sum_suquares = 0;

            long n = x.LongCount();

            for (int i = 0; i < n; i++)
            {
                double delta = x.ElementAt(i) - median;

                sum_suquares += delta * delta;
            }

            return sum_suquares / n;
        }

        public static double VarianceMedianPopulation
                                            (
                                                this Memory<double> x
                                            )
        {
            double median = x.Median();
            double sum_suquares = 0;

            long n = x.LongCount();

            for (int i = 0; i < n; i++)
            {
                double delta = x.ElementAt(i) - median;

                sum_suquares += delta * delta;
            }

            return sum_suquares / n;
        }

        public static decimal VarianceMedianPopulation
                                            (
                                                this Memory<decimal> x
                                            )
        {
            decimal median = x.Median();
            decimal sum_suquares = 0;

            long n = x.LongCount();

            for (int i = 0; i < n; i++)
            {
                decimal delta = x.ElementAt(i) - median;

                sum_suquares += delta * delta;
            }

            return sum_suquares / n;
        }
        //==============================================================================================================

    }
}
