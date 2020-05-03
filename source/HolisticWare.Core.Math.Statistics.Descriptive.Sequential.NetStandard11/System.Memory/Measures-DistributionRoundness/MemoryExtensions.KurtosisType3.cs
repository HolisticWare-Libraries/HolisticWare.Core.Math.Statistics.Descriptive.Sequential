using System;
using System.Collections.Generic;
using System.Linq;

namespace Core.Math.Statistics.Descriptive.Sequential
{
    /// <summary>
    /// KurtosisType3
    /// Sharpness of the peak of a frequency-distribution curve.
    /// </summary>
    /// <see href="https://en.wikipedia.org/wiki/Kurtosis"/>
    /// <see href="http://www.itl.nist.gov/div898/handbook/eda/section3/eda35b.htm"/>
    /// <see href="https://cran.r-project.org/web/packages/e1071/e1071.pdf"/>
    public static partial class IEnumerableExtensionsKurtosisType3
    {
        //==============================================================================================================
        /// <summary>
        /// KurtosisType3
        /// Sharpness of the peak of a frequency-distribution curve.
        /// Kurtosis of the Type3
        /// 
        /// must have at least 4 observations in your vector to apply this function.
        /// </summary>
        /// <returns>Kurtosis of type3.</returns>
        /// <param name="x">x data</param>
        /// <see href="https://www.rdocumentation.org/packages/SciencesPo/versions/1.4.1/topics/Kurtosis"/>
        /// <see href="https://docs.scipy.org/doc/scipy-0.7.x/reference/generated/scipy.stats.kurtosis.html"/>
        public static double KurtosisType3
                                    (
                                        this Memory<byte> x
                                    )
        {
            double g_2 = x.KurtosisType1();
            int n = x.Count();

            return (g_2 + 3.0) * (1.0 - 1.0 / n) * (1.0 - 1.0 / n) - 3.0;
        }

        public static double KurtosisType3
                                    (
                                        this Memory<short> x
                                    )
        {
            double g_2 = x.KurtosisType1();
            int n = x.Count();

            return (g_2 + 3.0) * (1.0 - 1.0 / n) * (1.0 - 1.0 / n) - 3.0;
        }

        public static double KurtosisType3
                                    (
                                        this Memory<ushort> x
                                    )
        {
            double g_2 = x.KurtosisType1();
            int n = x.Count();

            return (g_2 + 3.0) * (1.0 - 1.0 / n) * (1.0 - 1.0 / n) - 3.0;
        }

        public static double KurtosisType3
                                    (
                                        this Memory<int> x
                                    )
        {
            double g_2 = x.KurtosisType1();
            int n = x.Count();

            return (g_2 + 3.0) * (1.0 - 1.0 / n) * (1.0 - 1.0 / n) - 3.0;
        }

        public static double KurtosisType3
                                    (
                                        this Memory<uint> x
                                    )
        {
            double g_2 = x.KurtosisType1();
            int n = x.Count();

            return (g_2 + 3.0) * (1.0 - 1.0 / n) * (1.0 - 1.0 / n) - 3.0;
        }

        public static double KurtosisType3
                                    (
                                        this Memory<long> x
                                    )
        {
            double g_2 = x.KurtosisType1();
            int n = x.Count();

            return (g_2 + 3.0) * (1.0 - 1.0 / n) * (1.0 - 1.0 / n) - 3.0;
        }

        public static double KurtosisType3
                                    (
                                        this Memory<ulong> x
                                    )
        {
            double g_2 = x.KurtosisType1();
            int n = x.Count();

            return (g_2 + 3.0) * (1.0 - 1.0 / n) * (1.0 - 1.0 / n) - 3.0;
        }

        public static double KurtosisType3
                                    (
                                        this Memory<float> x
                                    )
        {
            double g_2 = x.KurtosisType1();
            int n = x.Count();

            return (g_2 + 3.0) * (1.0 - 1.0 / n) * (1.0 - 1.0 / n) - 3.0;
        }

        public static double KurtosisType3
                                    (
                                        this Memory<double> x
                                    )
        {
            double g_2 = x.KurtosisType1();
            int n = x.Count();

            return (g_2 + 3.0) * (1.0 - 1.0 / n) * (1.0 - 1.0 / n) - 3.0;
        }

        public static decimal KurtosisType3
                                    (
                                        this Memory<decimal> x
                                    )
        {
            decimal g_2 = x.KurtosisType1();
            int n = x.Count();

            return (g_2 + 3.0m) * (1.0m - 1.0m / n) * (1.0m - 1.0m / n) - 3.0m;
        }
        //==============================================================================================================
    }
}
