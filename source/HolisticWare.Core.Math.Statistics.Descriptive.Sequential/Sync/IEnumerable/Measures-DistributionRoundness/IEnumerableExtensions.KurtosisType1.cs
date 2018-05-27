using System;
using System.Collections.Generic;
using System.Linq;

namespace Core.Math.Statistics.Descriptive.Sequential
{
    /// <summary>
    /// KurtosisType1
    /// Sharpness of the peak of a frequency-distribution curve.
    /// </summary>
    /// <see cref="https://en.wikipedia.org/wiki/Kurtosis"/>
    /// <see cref="http://www.itl.nist.gov/div898/handbook/eda/section3/eda35b.htm"/>
    /// <see cref="https://cran.r-project.org/web/packages/e1071/e1071.pdf"/>
    public static partial class IEnumerableExtensionsKurtosisType1
    {
        //==============================================================================================================
        public static double KurtosisType1
                                    (
                                        this IEnumerable<byte> x
                                    )
        {
            double m2 = x.Moment(2);
            double m4 = x.Moment(4);

            return m4 / (m2 * m2) -3.0;
        }

        public static double KurtosisType1
                                    (
                                        this IEnumerable<short> x
                                    )
        {
            double m2 = x.Moment(2);
            double m4 = x.Moment(4);

            return m4 / (m2 * m2) - 3.0;
        }

        public static double KurtosisType1
                                    (
                                        this IEnumerable<ushort> x
                                    )
        {
            double m2 = x.Moment(2);
            double m4 = x.Moment(4);

            return m4 / (m2 * m2) - 3.0;
        }

        public static double KurtosisType1
                                    (
                                        this IEnumerable<int> x
                                    )
        {
            double m2 = x.Moment(2);
            double m4 = x.Moment(4);

            return m4 / (m2 * m2) - 3.0;
        }

        public static double KurtosisType1
                                    (
                                        this IEnumerable<uint> x
                                    )
        {
            double m2 = x.Moment(2);
            double m4 = x.Moment(4);

            return m4 / (m2 * m2) - 3.0;
        }

        public static double KurtosisType1
                                    (
                                        this IEnumerable<long> x
                                    )
        {
            double m2 = x.Moment(2);
            double m4 = x.Moment(4);

            return m4 / (m2 * m2) - 3.0;
        }

        public static double KurtosisType1
                                    (
                                        this IEnumerable<ulong> x
                                    )
        {
            double m2 = x.Moment(2);
            double m4 = x.Moment(4);

            return m4 / (m2 * m2) - 3.0;
        }

        public static double KurtosisType1
                                    (
                                        this IEnumerable<float> x
                                    )
        {
            double m2 = x.Moment(2);
            double m4 = x.Moment(4);

            return m4 / (m2 * m2) - 3.0;
        }

        public static double KurtosisType1
                                    (
                                        this IEnumerable<double> x
                                    )
        {
            double m2 = x.Moment(2);
            double m4 = x.Moment(4);

            return m4 / (m2 * m2) - 3.0;
        }

        public static decimal KurtosisType1
                                    (
                                        this IEnumerable<decimal> x
                                    )
        {
            decimal m2 = x.Moment(2);
            decimal m4 = x.Moment(4);

            return m4 / (m2 * m2) - 3.0m;
        }
        //==============================================================================================================
    }
}
