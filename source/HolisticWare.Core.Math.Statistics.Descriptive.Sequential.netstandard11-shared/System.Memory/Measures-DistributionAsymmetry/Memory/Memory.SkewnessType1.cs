using System;
using System.Collections.Generic;
using System.Linq;

namespace Core.Math.Statistics.Descriptive.Sequential
{
    public static partial class IEnumerableExtensionsSkewnessType1
    {
        //==============================================================================================================
        /// <summary>
        /// Skewnesses of the Type1 (unbiased under normality)
        /// 
        /// Used in older books.
        /// </summary>
        /// <returns>skewness of type1.</returns>
        /// <param name="x">x data</param>
        /// <see href="https://en.wikipedia.org/wiki/Skewness"/>
        /// <see href="https://www.rdocumentation.org/packages/e1071/versions/1.6-8/topics/skewness"/>
        /// <see href="http://www.itl.nist.gov/div898/handbook/eda/section3/eda35b.htm"/>
        /// <see href="https://cran.r-project.org/web/packages/e1071/e1071.pdf"/>
        public static double SkewnessType1
                                    (
                                        this IEnumerable<byte> x
                                    )
        {
            double x_moment_3 = x.Moment(3);
            double x_moment_2 = x.Moment(2);
            //double x_standard_deviation = x.StandardDeviationSample();

            return
                    x_moment_3
                    /
                    //(x_standard_deviation * x_standard_deviation * x_standard_deviation)
                    System.Math.Pow(x_moment_2, 3.0 / 2.0)
                    ;
        }

        public static double SkewnessType1
                                    (
                                        this IEnumerable<short> x
                                    )
        {
            double x_moment_3 = x.Moment(3);
            double x_moment_2 = x.Moment(2);
            //double x_standard_deviation = x.StandardDeviationSample();

            return
                    x_moment_3
                    /
                    //(x_standard_deviation * x_standard_deviation * x_standard_deviation)
                    System.Math.Pow(x_moment_2, 3.0 / 2.0)
                    ;
        }

        public static double SkewnessType1
                                    (
                                        this IEnumerable<ushort> x
                                    )
        {
            double x_moment_3 = x.Moment(3);
            double x_moment_2 = x.Moment(2);
            //double x_standard_deviation = x.StandardDeviationSample();

            return
                    x_moment_3
                    /
                    //(x_standard_deviation * x_standard_deviation * x_standard_deviation)
                    System.Math.Pow(x_moment_2, 3.0 / 2.0)
                    ;
        }

        public static double SkewnessType1
                                    (
                                        this IEnumerable<int> x
                                    )
        {
            double x_moment_3 = x.Moment(3);
            double x_moment_2 = x.Moment(2);
            //double x_standard_deviation = x.StandardDeviationSample();

            return
                    x_moment_3
                    /
                    //(x_standard_deviation * x_standard_deviation * x_standard_deviation)
                    System.Math.Pow(x_moment_2, 3.0 / 2.0)
                    ;
        }

        public static double SkewnessType1
                                    (
                                        this IEnumerable<uint> x
                                    )
        {
            double x_moment_3 = x.Moment(3);
            double x_moment_2 = x.Moment(2);
            //double x_standard_deviation = x.StandardDeviationSample();

            return
                    x_moment_3
                    /
                    //(x_standard_deviation * x_standard_deviation * x_standard_deviation)
                    System.Math.Pow(x_moment_2, 3.0 / 2.0)
                    ;
        }

        public static double SkewnessType1
                                    (
                                        this IEnumerable<long> x
                                    )
        {
            double x_moment_3 = x.Moment(3);
            double x_moment_2 = x.Moment(2);
            //double x_standard_deviation = x.StandardDeviationSample();

            return
                    x_moment_3
                    /
                    //(x_standard_deviation * x_standard_deviation * x_standard_deviation)
                    System.Math.Pow(x_moment_2, 3.0 / 2.0)
                    ;
        }

        public static double SkewnessType1
                                    (
                                        this IEnumerable<ulong> x
                                    )
        {
            double x_moment_3 = x.Moment(3);
            double x_moment_2 = x.Moment(2);
            //double x_standard_deviation = x.StandardDeviationSample();

            return
                    x_moment_3
                    /
                    //(x_standard_deviation * x_standard_deviation * x_standard_deviation)
                    System.Math.Pow(x_moment_2, 3.0 / 2.0)
                    ;
        }

        public static double SkewnessType1
                                    (
                                        this IEnumerable<float> x
                                    )
        {
            double x_moment_3 = x.Moment(3);
            double x_moment_2 = x.Moment(2);
            //double x_standard_deviation = x.StandardDeviationSample();

            return
                    x_moment_3
                    /
                    //(x_standard_deviation * x_standard_deviation * x_standard_deviation)
                    System.Math.Pow(x_moment_2, 3.0 / 2.0)
                    ;
        }

        public static double SkewnessType1
                                    (
                                        this IEnumerable<double> x
                                    )
        {
            double x_moment_3 = x.Moment(3);
            double x_moment_2 = x.Moment(2);
            //double x_standard_deviation = x.StandardDeviationSample();

            return
                    x_moment_3
                    /
                    //(x_standard_deviation * x_standard_deviation * x_standard_deviation)
                    System.Math.Pow(x_moment_2, 3.0 / 2.0)
                    ;
        }

        public static decimal SkewnessType1
                                    (
                                        this IEnumerable<decimal> x
                                    )
        {
            decimal x_moment_3 = x.Moment(3);
            decimal x_moment_2 = x.Moment(2);
            //decimal x_standard_deviation = x.StandardDeviationSample();

            return
                    x_moment_3
                    /
                    //(x_standard_deviation * x_standard_deviation * x_standard_deviation)
                    (decimal) System.Math.Pow((double) x_moment_2, 3.0 / 2.0)
                    ;
        }
        //==============================================================================================================
    
    }
}
