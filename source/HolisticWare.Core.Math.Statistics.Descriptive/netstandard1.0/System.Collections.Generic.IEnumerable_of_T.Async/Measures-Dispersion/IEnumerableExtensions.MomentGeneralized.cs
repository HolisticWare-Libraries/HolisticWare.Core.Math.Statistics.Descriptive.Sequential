using System;
using System.Collections.Generic;
using System.Linq;

namespace Core.Math.Statistics.Descriptive
{
    public static partial class IEnumerableExtensionsMoment
    {
        //==============================================================================================================
        public static double MomentGeneralizedAsync
                                (
                                    this IEnumerable<byte> x, 
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

        public static double MomentGeneralizedAsync
                                (
                                    this IEnumerable<short> x, 
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

        public static double MomentGeneralizedAsync
                                (
                                    this IEnumerable<ushort> x, 
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

        public static double MomentGeneralizedAsync
                                (
                                    this IEnumerable<int> x, 
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

        public static double MomentGeneralizedAsync
                                (
                                    this IEnumerable<uint> x, 
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

        public static double MomentGeneralizedAsync
                                (
                                    this IEnumerable<long> x, 
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

        public static double MomentGeneralizedAsync
                                (
                                    this IEnumerable<ulong> x, 
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

        public static double MomentGeneralizedAsync
                                (
                                    this IEnumerable<float> x, 
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

        public static double MomentGeneralizedAsync
                                (
                                    this IEnumerable<double> x, 
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

        public static decimal MomentGeneralizedAsync
                                (
                                    this IEnumerable<decimal> x, 
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
