using System;
using System.Collections.Generic;
using System.Linq;

namespace Core.Math.Statistics.Descriptive
{
    public static partial class IEnumerableExtensionsVarianceMedianSample
    {
        //==============================================================================================================
        public static double VarianceMedianSample
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

            return sum_suquares / (n - 1);
        }

        public static double VarianceMedianSample
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

            return sum_suquares / (n - 1);
        }

        public static double VarianceMedianSample
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

            return sum_suquares / (n - 1);
        }

        public static double VarianceMedianSample
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

            return sum_suquares / (n - 1);
        }

        public static double VarianceMedianSample
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

            return sum_suquares / (n - 1);
        }

        public static double VarianceMedianSample
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

            return sum_suquares / (n - 1);
        }

        public static double VarianceMedianSample
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

            return sum_suquares / (n - 1);
        }

        public static double VarianceMedianSample
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

            return sum_suquares / (n - 1);
        }

        public static double VarianceMedianSample
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

            return sum_suquares / (n - 1);
        }

        public static decimal VarianceMedianSample
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

            return sum_suquares / (n - 1);
        }
        //==============================================================================================================

    }
}
