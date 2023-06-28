﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Core.Math.Statistics.Descriptive
{
    public static partial class IEnumerableExtensionsVariancePopulation
    {
        //==============================================================================================================
        public static double VariancePopulationAsync
                                            (
                                                this IEnumerable<byte> x
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

        public static double VariancePopulationAsync
                                            (
                                                this IEnumerable<short> x
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

        public static double VariancePopulationAsync
                                            (
                                                this IEnumerable<ushort> x
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

        public static double VariancePopulationAsync
                                            (
                                                this IEnumerable<int> x
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

        public static double VariancePopulationAsync
                                            (
                                                this IEnumerable<uint> x
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

        public static double VariancePopulationAsync
                                            (
                                                this IEnumerable<long> x
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

        public static double VariancePopulationAsync
                                            (
                                                this IEnumerable<ulong> x
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

        public static double VariancePopulationAsync
                                            (
                                                this IEnumerable<float> x
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

        public static double VariancePopulationAsync
                                            (
                                                this IEnumerable<double> x
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

        public static decimal VariancePopulationAsync
                                            (
                                                this IEnumerable<decimal> x
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
