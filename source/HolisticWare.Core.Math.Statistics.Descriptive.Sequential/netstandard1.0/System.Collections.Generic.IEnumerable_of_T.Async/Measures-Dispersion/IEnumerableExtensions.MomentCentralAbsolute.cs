﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Core.Math.Statistics.Descriptive
{
    public static partial class IEnumerableExtensionsMomentCentralAbsolute
    {
        //==============================================================================================================
        public static double MomentCentralAbsoluteAsync
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

        public static double MomentCentralAbsoluteAsync
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

        public static double MomentCentralAbsoluteAsync
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

        public static double MomentCentralAbsoluteAsync
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

        public static double MomentCentralAbsoluteAsync
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

        public static double MomentCentralAbsoluteAsync
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

        public static double MomentCentralAbsoluteAsync
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

        public static double MomentCentralAbsoluteAsync
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

        public static double MomentCentralAbsoluteAsync
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

        public static decimal MomentCentralAbsoluteAsync
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
