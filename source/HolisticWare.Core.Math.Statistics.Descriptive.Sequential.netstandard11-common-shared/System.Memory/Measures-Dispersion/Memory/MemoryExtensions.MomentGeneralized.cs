using System;
using System.Collections.Generic;
using System.Linq;

namespace Core.Math.Statistics.Descriptive.Sequential
{
    public static partial class MemoryExtensionsMoment
    {
        //==============================================================================================================
        public static double MomentGeneralized
                                (
                                    this Memory<byte> x, 
                                    int m
                                )
        {
            double average = x.Select(x_i => (int)x_i).Average();
            double sum = 0;

            int n = x.Count();

            for (int i = 0; i < n; i++)
            {
                sum += System.Math.Pow(x.ElementAt(i) - average, m);
            }

            return sum / n;
        }

        public static double MomentGeneralized
                                (
                                    this Memory<short> x, 
                                    int m
                                )
        {
            double average = x.Select(x_i => (int)x_i).Average();
            double sum = 0;

            int n = x.Count();

            for (int i = 0; i < n; i++)
            {
                sum += System.Math.Pow(x.ElementAt(i) - average, m);
            }

            return sum / n;
        }

        public static double MomentGeneralized
                                (
                                    this Memory<ushort> x, 
                                    int m
                                )
        {
            double average = x.Select(x_i => (int)x_i).Average();
            double sum = 0;

            int n = x.Count();

            for (int i = 0; i < n; i++)
            {
                sum += System.Math.Pow(x.ElementAt(i) - average, m);
            }

            return sum / n;
        }

        public static double MomentGeneralized
                                (
                                    this Memory<int> x, 
                                    int m
                                )
        {
            double average = x.Average();
            double sum = 0;

            int n = x.Count();

            for (int i = 0; i < n; i++)
            {
                sum += System.Math.Pow(x.ElementAt(i) - average, m);
            }

            return sum / n;
        }

        public static double MomentGeneralized
                                (
                                    this Memory<uint> x, 
                                    int m
                                )
        {
            double average = x.Select(x_i => (long)x_i).Average();
            double sum = 0;

            int n = x.Count();

            for (int i = 0; i < n; i++)
            {
                sum += System.Math.Pow(x.ElementAt(i) - average, m);
            }

            return sum / n;
        }

        public static double MomentGeneralized
                                (
                                    this Memory<long> x, 
                                    int m
                                )
        {
            double average = x.Average();
            double sum = 0;

            int n = x.Count();

            for (int i = 0; i < n; i++)
            {
                sum += System.Math.Pow(x.ElementAt(i) - average, m);
            }

            return sum / n;
        }

        public static double MomentGeneralized
                                (
                                    this Memory<ulong> x, 
                                    int m
                                )
        {
            double average = x.Select(x_i => (double)x_i).Average();
            double sum = 0;

            int n = x.Count();

            for (int i = 0; i < n; i++)
            {
                sum += System.Math.Pow(x.ElementAt(i) - average, m);
            }

            return sum / n;
        }

        public static double MomentGeneralized
                                (
                                    this Memory<float> x, 
                                    int m
                                )
        {
            double average = x.Average();
            double sum = 0;

            int n = x.Count();

            for (int i = 0; i < n; i++)
            {
                sum += System.Math.Pow(x.ElementAt(i) - average, m);
            }

            return sum / n;
        }

        public static double MomentGeneralized
                                (
                                    this Memory<double> x, 
                                    int m
                                )
        {
            double average = x.Average();
            double sum = 0;

            int n = x.Count();

            for (int i = 0; i < n; i++)
            {
                sum += System.Math.Pow(x.ElementAt(i) - average, m);
            }

            return sum / n;
        }

        public static decimal MomentGeneralized
                                (
                                    this Memory<decimal> x, 
                                    int m
                                )
        {
            decimal average = x.Average();
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
