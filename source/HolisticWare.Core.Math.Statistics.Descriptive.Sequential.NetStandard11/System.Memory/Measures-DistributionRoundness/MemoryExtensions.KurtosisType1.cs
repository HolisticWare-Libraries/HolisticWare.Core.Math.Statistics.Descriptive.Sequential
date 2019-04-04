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
        /// <summary>
        /// KurtosisType1
        /// Sharpness of the peak of a frequency-distribution curve.
        /// Kurtosis of the Type1
        /// 
        /// Used in older books.
        /// </summary>
        /// <returns>Kurtosis of type1.</returns>
        /// <param name="x">x data</param>
        /// <see cref="https://www.rdocumentation.org/packages/SciencesPo/versions/1.4.1/topics/Kurtosis"/>
        /// <see cref="https://docs.scipy.org/doc/scipy-0.7.x/reference/generated/scipy.stats.kurtosis.html"/>
        public static double KurtosisType1
                                    (
                                        this Memory<byte> x
                                    )
        {
            double m2 = x.Moment(2);
            double m4 = x.Moment(4);

            return m4 / (m2 * m2) - 3.0;
        }

        public static double KurtosisType1
                                    (
                                        this Memory<short> x
                                    )
        {
            double m2 = x.Moment(2);
            double m4 = x.Moment(4);

            return m4 / (m2 * m2) - 3.0;
        }

        public static double KurtosisType1
                                    (
                                        this Memory<ushort> x
                                    )
        {
            double m2 = x.Moment(2);
            double m4 = x.Moment(4);

            return m4 / (m2 * m2) - 3.0;
        }

        public static double KurtosisType1
                                    (
                                        this Memory<int> x
                                    )
        {
            double m2 = x.Moment(2);
            double m4 = x.Moment(4);

            return m4 / (m2 * m2) - 3.0;
        }

        public static double KurtosisType1
                                    (
                                        this Memory<uint> x
                                    )
        {
            double m2 = x.Moment(2);
            double m4 = x.Moment(4);

            return m4 / (m2 * m2) - 3.0;
        }

        public static double KurtosisType1
                                    (
                                        this Memory<long> x
                                    )
        {
            double m2 = x.Moment(2);
            double m4 = x.Moment(4);

            return m4 / (m2 * m2) - 3.0;
        }

        public static double KurtosisType1
                                    (
                                        this Memory<ulong> x
                                    )
        {
            double m2 = x.Moment(2);
            double m4 = x.Moment(4);

            return m4 / (m2 * m2) - 3.0;
        }

        public static double KurtosisType1
                                    (
                                        this Memory<float> x
                                    )
        {
            double m2 = x.Moment(2);
            double m4 = x.Moment(4);

            return m4 / (m2 * m2) - 3.0;
        }

        public static double KurtosisType1
                                    (
                                        this Memory<double> x
                                    )
        {
            double m2 = x.Moment(2);
            double m4 = x.Moment(4);

            return m4 / (m2 * m2) - 3.0;
        }

        public static decimal KurtosisType1
                                    (
                                        this Memory<decimal> x
                                    )
        {
            decimal m2 = x.Moment(2);
            decimal m4 = x.Moment(4);

            return m4 / (m2 * m2) - 3.0m;
        }
        //==============================================================================================================
    }
}
