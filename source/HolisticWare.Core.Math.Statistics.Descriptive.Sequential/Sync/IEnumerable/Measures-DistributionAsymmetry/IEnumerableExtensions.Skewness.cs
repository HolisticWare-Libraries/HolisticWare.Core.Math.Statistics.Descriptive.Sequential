using System;
using System.Collections.Generic;
using System.Linq;

namespace Core.Math.Statistics.Descriptive.Sequential
{
    public static partial class IEnumerableExtensionsSkewness
    {
        //==============================================================================================================
        public static double Skewness
                                    (
                                        this IEnumerable<byte> x
                                    )
        {
            double x_moment_3 = x.Moment(3);
            double x_standard_deviation = x.StandardDeviationSample();

            return
                    x_moment_3
                    /
                    (x_standard_deviation * x_standard_deviation * x_standard_deviation)
                    ;
        }

        public static double Skewness
                                    (
                                        this IEnumerable<short> x
                                    )
        {
            double x_moment_3 = x.Moment(3);
            double x_standard_deviation = x.StandardDeviationSample();

            return
                    x_moment_3
                    /
                    (x_standard_deviation * x_standard_deviation * x_standard_deviation)
                    ;
        }

        public static double Skewness
                                    (
                                        this IEnumerable<ushort> x
                                    )
        {
            double x_moment_3 = x.Moment(3);
            double x_standard_deviation = x.StandardDeviationSample();

            return
                    x_moment_3
                    /
                    (x_standard_deviation * x_standard_deviation * x_standard_deviation)
                    ;
        }

        public static double Skewness
                                    (
                                        this IEnumerable<int> x
                                    )
        {
            double x_moment_3 = x.Moment(3);
            double x_standard_deviation = x.StandardDeviationSample();

            return
                    x_moment_3
                    /
                    (x_standard_deviation * x_standard_deviation * x_standard_deviation)
                    ;
        }

        public static double Skewness
                                    (
                                        this IEnumerable<uint> x
                                    )
        {
            double x_moment_3 = x.Moment(3);
            double x_standard_deviation = x.StandardDeviationSample();

            return
                    x_moment_3
                    /
                    (x_standard_deviation * x_standard_deviation * x_standard_deviation)
                    ;
        }

        public static double Skewness
                                    (
                                        this IEnumerable<long> x
                                    )
        {
            double x_moment_3 = x.Moment(3);
            double x_standard_deviation = x.StandardDeviationSample();

            return
                    x_moment_3
                    /
                    (x_standard_deviation * x_standard_deviation * x_standard_deviation)
                    ;
        }

        public static double Skewness
                                    (
                                        this IEnumerable<ulong> x
                                    )
        {
            double x_moment_3 = x.Moment(3);
            double x_standard_deviation = x.StandardDeviationSample();

            return
                    x_moment_3
                    /
                    (x_standard_deviation * x_standard_deviation * x_standard_deviation)
                    ;
        }

        public static double Skewness
                                    (
                                        this IEnumerable<float> x
                                    )
        {
            double x_moment_3 = x.Moment(3);
            double x_standard_deviation = x.StandardDeviationSample();

            return
                    x_moment_3
                    /
                    (x_standard_deviation * x_standard_deviation * x_standard_deviation)
                    ;
        }

        public static double Skewness
                                    (
                                        this IEnumerable<double> x
                                    )
        {
            double x_moment_3 = x.Moment(3);
            double x_standard_deviation = x.StandardDeviationSample();

            return
                    x_moment_3
                    /
                    (x_standard_deviation * x_standard_deviation * x_standard_deviation)
                    ;
        }

        public static decimal Skewness
                                    (
                                        this IEnumerable<decimal> x
                                    )
        {
            decimal x_moment_3 = x.Moment(3);
            decimal x_standard_deviation = x.StandardDeviationSample();

            return
                    x_moment_3
                    /
                    (x_standard_deviation * x_standard_deviation * x_standard_deviation)
                    ;
        }
        //==============================================================================================================
    
    }
}
