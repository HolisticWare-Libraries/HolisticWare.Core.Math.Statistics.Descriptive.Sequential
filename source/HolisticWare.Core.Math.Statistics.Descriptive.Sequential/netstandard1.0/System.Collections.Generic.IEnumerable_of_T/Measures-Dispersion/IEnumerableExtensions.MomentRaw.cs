using System;
using System.Collections.Generic;
using System.Linq;

namespace Core.Math.Statistics.Descriptive
{
    public static partial class
                                        IEnumerableExtensionsMomentRaw
    {
        //==============================================================================================================
        public static
            double
                                        MomentRaw
                                        (
                                            this IEnumerable<byte> x, 
                                            double m
                                        )
        {
            double average = x.Select(x_i => (int)x_i).MeanArithmetic();
            double sum = 0;

            int n = x.Count();

            for (int i = 0; i < n; i++)
            {
                sum += System.Math.Pow(x.ElementAt(i) - average, m);
            }

            return sum / n;
        }

        public static
            double
                                        MomentRaw
                                        (
                                            this IEnumerable<short> x, 
                                            double m
                                        )
        {
            double average = x.Select(x_i => (int)x_i).MeanArithmetic();
            double sum = 0;

            int n = x.Count();

            for (int i = 0; i < n; i++)
            {
                sum += System.Math.Pow(x.ElementAt(i) - average, m);
            }

            return sum / n;
        }

        public static
            double
                                        MomentRaw
                                        (
                                            this IEnumerable<ushort> x, 
                                            double m
                                        )
        {
            double average = x.Select(x_i => (int)x_i).MeanArithmetic();
            double sum = 0;

            int n = x.Count();

            for (int i = 0; i < n; i++)
            {
                sum += System.Math.Pow(x.ElementAt(i) - average, m);
            }

            return sum / n;
        }

        public static
            double
                                        MomentRaw
                                        (
                                            this IEnumerable<int> x, 
                                            double m
                                        )
        {
            double average = x.MeanArithmetic();
            double sum = 0;

            int n = x.Count();

            for (int i = 0; i < n; i++)
            {
                sum += System.Math.Pow(x.ElementAt(i) - average, m);
            }

            return sum / n;
        }

        public static
            double
                                        MomentRaw
                                        (
                                            this IEnumerable<uint> x, 
                                            double m
                                        )
        {
            double average = x.Select(x_i => (long)x_i).MeanArithmetic();
            double sum = 0;

            int n = x.Count();

            for (int i = 0; i < n; i++)
            {
                sum += System.Math.Pow(x.ElementAt(i) - average, m);
            }

            return sum / n;
        }

        public static
            double
                                        MomentRaw
                                        (
                                            this IEnumerable<long> x, 
                                            double m
                                        )
        {
            double average = x.MeanArithmetic();
            double sum = 0;

            int n = x.Count();

            for (int i = 0; i < n; i++)
            {
                sum += System.Math.Pow(x.ElementAt(i) - average, m);
            }

            return sum / n;
        }

        public static
            double
                                        MomentRaw
                                        (
                                            this IEnumerable<ulong> x, 
                                            double m
                                        )
        {
            double average = x.Select(x_i => (double)x_i).MeanArithmetic();
            double sum = 0;

            int n = x.Count();

            for (int i = 0; i < n; i++)
            {
                sum += System.Math.Pow(x.ElementAt(i) - average, m);
            }

            return sum / n;
        }

        public static double MomentRaw
                                    (
                                        this IEnumerable<float> x, 
                                        double m
                                    )
        {
            double average = x.MeanArithmetic();
            double sum = 0;

            int n = x.Count();

            for (int i = 0; i < n; i++)
            {
                sum += System.Math.Pow(x.ElementAt(i) - average, m);
            }

            return sum / n;
        }

        public static
            double
                                        MomentRaw
                                        (
                                            this IEnumerable<double> x, 
                                            double m
                                        )
        {
            double average = x.MeanArithmetic();
            double sum = 0;

            int n = x.Count();

            for (int i = 0; i < n; i++)
            {
                sum += System.Math.Pow(x.ElementAt(i) - average, m);
            }

            return sum / n;
        }

        public static
            decimal
                                        MomentRaw
                                        (
                                            this IEnumerable<decimal> x, 
                                            double m
                                        )
        {
            decimal average = x.MeanArithmetic();
            decimal sum = 0;

            int n = x.Count();

            for (int i = 0; i < n; i++)
            {
                sum += (decimal)System.Math.Pow((double)x.ElementAt(i) - (double)average, m);
            }

            return sum / n;
        }
        //==============================================================================================================

    }
}
