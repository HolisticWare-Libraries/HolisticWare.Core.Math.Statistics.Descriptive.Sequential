using System;
using System.Collections.Generic;
using System.Linq;

namespace Core.Math.Statistics.Descriptive.Sequential
{
    public static partial class IEnumerableExtensionsSkewnessFisherPearsonAdjusted
    {
        //==============================================================================================================
        public static double SkewnessFisherPearsonAdjusted
                                    (
                                        this IEnumerable<byte> x
                                    )
        {
            // NIST definition of adjusted Fisher-Pearson
            // coefficient of skewness
            double x_moment_3 = x.Moment(3);
            double x_standard_deviation = x.StandardDeviationSample();
            int n = x.Count();
            int n1 = n - 1;

            return
                (System.Math.Sqrt(n * n1) / n1) * x_moment_3
                /
                System.Math.Pow(x_standard_deviation, 3)
                      ;
        }

        public static double SkewnessFisherPearsonAdjusted
                                    (
                                        this IEnumerable<short> x
                                    )
        {
            // NIST definition of adjusted Fisher-Pearson
            // coefficient of skewness
            double x_moment_3 = x.Moment(3);
            double x_standard_deviation = x.StandardDeviationSample();
            int n = x.Count();
            int n1 = n - 1;

            return 
                (System.Math.Sqrt(n * n1) / n1) * x_moment_3 
                / 
                System.Math.Pow(x_standard_deviation, 3)
                      ;
        }

        public static double SkewnessFisherPearsonAdjusted
                                    (
                                        this IEnumerable<ushort> x
                                    )
        {
            // NIST definition of adjusted Fisher-Pearson
            // coefficient of skewness
            double x_moment_3 = x.Moment(3);
            double x_standard_deviation = x.StandardDeviationSample();
            int n = x.Count();
            int n1 = n - 1;

            return 
                (System.Math.Sqrt(n * n1) / n1) * x_moment_3 
                / 
                System.Math.Pow(x_standard_deviation, 3)
                      ;
        }

        public static double SkewSkewnessFisherPearsonAdjustedness
                                    (
                                        this IEnumerable<int> x
                                    )
        {
            // NIST definition of adjusted Fisher-Pearson
            // coefficient of skewness
            double x_moment_3 = x.Moment(3);
            double x_standard_deviation = x.StandardDeviationSample();
            int n = x.Count();
            int n1 = n - 1;

            return 
                (System.Math.Sqrt(n * n1) / n1) * x_moment_3 
                / 
                System.Math.Pow(x_standard_deviation, 3)
                      ;
        }

        public static double SkewnessFisherPearsonAdjusted
                                    (
                                        this IEnumerable<uint> x
                                    )
        {
            // NIST definition of adjusted Fisher-Pearson
            // coefficient of skewness
            double x_moment_3 = x.Moment(3);
            double x_standard_deviation = x.StandardDeviationSample();
            int n = x.Count();
            int n1 = n - 1;

            return 
                (System.Math.Sqrt(n * n1) / n1) * x_moment_3 
                / 
                System.Math.Pow(x_standard_deviation, 3)
                      ;
        }

        public static double SkewnessFisherPearsonAdjusted
                                    (
                                        this IEnumerable<long> x
                                    )
        {
            // NIST definition of adjusted Fisher-Pearson
            // coefficient of skewness
            double x_moment_3 = x.Moment(3);
            double x_standard_deviation = x.StandardDeviationSample();
            int n = x.Count();
            int n1 = n - 1;

            return 
                (System.Math.Sqrt(n * n1) / n1) * x_moment_3 
                / System.Math.Pow(x_standard_deviation, 3)
                        ;
        }

        public static double SkewnessFisherPearsonAdjusted
                                    (
                                        this IEnumerable<ulong> x
                                    )
        {
            // NIST definition of adjusted Fisher-Pearson
            // coefficient of skewness
            double x_moment_3 = x.Moment(3);
            double x_standard_deviation = x.StandardDeviationSample();
            int n = x.Count();
            int n1 = n - 1;

            return 
                (System.Math.Sqrt(n * n1) / n1) * x_moment_3 
                / 
                System.Math.Pow(x_standard_deviation, 3)
                      ;
        }

        public static double SkewnessFisherPearsonAdjusted
                                    (
                                        this IEnumerable<float> x
                                    )
        {
            // NIST definition of adjusted Fisher-Pearson
            // coefficient of skewness
            double x_moment_3 = x.Moment(3);
            double x_standard_deviation = x.StandardDeviationSample();
            int n = x.Count();
            int n1 = n - 1;

            return 
                (System.Math.Sqrt(n * n1) / n1) * x_moment_3 
                / 
                System.Math.Pow(x_standard_deviation, 3)
                      ;
        }

        public static double SkewnessFisherPearsonAdjusted
                                    (
                                        this IEnumerable<double> x
                                    )
        {
            // NIST definition of adjusted Fisher-Pearson
            // coefficient of skewness
            double x_moment_3 = x.Moment(3);
            double x_standard_deviation = x.StandardDeviationSample();
            int n = x.Count();
            int n1 = n - 1;

            return 
                (System.Math.Sqrt(n * n1) / n1) * x_moment_3 
                / 
                System.Math.Pow(x_standard_deviation, 3)
                      ;
        }

        public static decimal SkewnessFisherPearsonAdjusted
                                    (
                                        this IEnumerable<decimal> x
                                    )
        {
            // NIST definition of adjusted Fisher-Pearson
            // coefficient of skewness
            decimal x_moment_3 = x.Moment(3);
            decimal x_standard_deviation = x.StandardDeviationSample();
            int n = x.Count();
            int n1 = n - 1;

            return (decimal)
                (System.Math.Sqrt(n * n1) / n1) * x_moment_3 
                / 
                (decimal)System.Math.Pow((double)x_standard_deviation, 3)
                               ;
        }
        //==============================================================================================================
    
    }
}
