using System;
using System.Collections.Generic;
using System.Linq;

using Core.LINQ.Memory;

namespace Core.Math.Statistics.Descriptive
{
    public static partial class MemoryExtensionsSkewnessFisherPearsonAdjusted
    {
        //==============================================================================================================
        public static double SkewnessFisherPearsonAdjusted
                                    (
                                        this Memory<byte> x
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
                                        this Memory<short> x
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
                                        this Memory<ushort> x
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
                                        this Memory<int> x
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
                                        this Memory<uint> x
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
                                        this Memory<long> x
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
                                        this Memory<ulong> x
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
                                        this Memory<float> x
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
                                        this Memory<double> x
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
                                        this Memory<decimal> x
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
