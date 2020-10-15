using System;
using System.Collections.Generic;
using System.Linq;

using Core.LINQ.Memory;

namespace Core.Math.Statistics.Descriptive
{
    public static partial class MemoryExtensionsMomentRawAbsolute
    {
        //==============================================================================================================
        public static double MomentRawAbsolute
                                        (
                                            this Memory<byte> x, 
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

        public static double MomentRawAbsolute
                                        (
                                            this Memory<short> x, 
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

        public static double MomentRawAbsolute
                                        (
                                            this Memory<ushort> x, 
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

        public static double MomentRawAbsolute
                                        (
                                            this Memory<int> x, 
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

        public static double MomentRawAbsolute
                                        (
                                            this Memory<uint> x, 
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

        public static double MomentRawAbsolute
                                        (
                                            this Memory<long> x, 
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

        public static double MomentRawAbsolute
                                        (
                                            this Memory<ulong> x, 
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

        public static double MomentRawAbsolute
                                        (
                                            this Memory<float> x, 
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

        public static double MomentRawAbsolute
                                        (
                                            this Memory<double> x, 
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

        public static decimal MomentRawAbsolute
                                        (
                                            this Memory<decimal> x, 
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
