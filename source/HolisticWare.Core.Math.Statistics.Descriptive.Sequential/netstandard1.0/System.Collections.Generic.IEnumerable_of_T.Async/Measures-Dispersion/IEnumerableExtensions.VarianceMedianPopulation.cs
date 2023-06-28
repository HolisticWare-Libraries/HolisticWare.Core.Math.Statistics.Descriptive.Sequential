﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Core.Math.Statistics.Descriptive
{
    public static partial class IEnumerableExtensionsVarianceMedianPopulation
    {
        //==============================================================================================================
        public static double VarianceMedianPopulationAsync
                                            (
                                                this IEnumerable<byte> x
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

        public static double VarianceMedianPopulationAsync
                                            (
                                                this IEnumerable<short> x
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

        public static double VarianceMedianPopulationAsync
                                            (
                                                this IEnumerable<ushort> x
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

        public static double VarianceMedianPopulationAsync
                                            (
                                                this IEnumerable<int> x
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

        public static double VarianceMedianPopulationAsync
                                            (
                                                this IEnumerable<uint> x
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

        public static double VarianceMedianPopulationAsync
                                            (
                                                this IEnumerable<long> x
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

        public static double VarianceMedianPopulationAsync
                                            (
                                                this IEnumerable<ulong> x
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

        public static double VarianceMedianPopulationAsync
                                            (
                                                this IEnumerable<float> x
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

        public static double VarianceMedianPopulationAsync
                                            (
                                                this IEnumerable<double> x
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

        public static decimal VarianceMedianPopulationAsync
                                            (
                                                this IEnumerable<decimal> x
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
