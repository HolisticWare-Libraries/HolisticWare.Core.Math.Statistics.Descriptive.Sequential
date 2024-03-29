﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Core.Math.Statistics.Descriptive
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
        public static double KurtosisType3Async
                                    (
                                        this IEnumerable<byte> x
                                    )
        {
            double g_2 = x.KurtosisType1();
            int n = x.Count();

            return (g_2 + 3.0) * (1.0 - 1.0 / n) * (1.0 - 1.0 / n) - 3.0;
        }

        public static double KurtosisType3Async
                                    (
                                        this IEnumerable<short> x
                                    )
        {
            double g_2 = x.KurtosisType1();
            int n = x.Count();

            return (g_2 + 3.0) * (1.0 - 1.0 / n) * (1.0 - 1.0 / n) - 3.0;
        }

        public static double KurtosisType3Async
                                    (
                                        this IEnumerable<ushort> x
                                    )
        {
            double g_2 = x.KurtosisType1();
            int n = x.Count();

            return (g_2 + 3.0) * (1.0 - 1.0 / n) * (1.0 - 1.0 / n) - 3.0;
        }

        public static double KurtosisType3Async
                                    (
                                        this IEnumerable<int> x
                                    )
        {
            double g_2 = x.KurtosisType1();
            int n = x.Count();

            return (g_2 + 3.0) * (1.0 - 1.0 / n) * (1.0 - 1.0 / n) - 3.0;
        }

        public static double KurtosisType3Async
                                    (
                                        this IEnumerable<uint> x
                                    )
        {
            double g_2 = x.KurtosisType1();
            int n = x.Count();

            return (g_2 + 3.0) * (1.0 - 1.0 / n) * (1.0 - 1.0 / n) - 3.0;
        }

        public static double KurtosisType3Async
                                    (
                                        this IEnumerable<long> x
                                    )
        {
            double g_2 = x.KurtosisType1();
            int n = x.Count();

            return (g_2 + 3.0) * (1.0 - 1.0 / n) * (1.0 - 1.0 / n) - 3.0;
        }

        public static double KurtosisType3Async
                                    (
                                        this IEnumerable<ulong> x
                                    )
        {
            double g_2 = x.KurtosisType1();
            int n = x.Count();

            return (g_2 + 3.0) * (1.0 - 1.0 / n) * (1.0 - 1.0 / n) - 3.0;
        }

        public static double KurtosisType3Async
                                    (
                                        this IEnumerable<float> x
                                    )
        {
            double g_2 = x.KurtosisType1();
            int n = x.Count();

            return (g_2 + 3.0) * (1.0 - 1.0 / n) * (1.0 - 1.0 / n) - 3.0;
        }

        public static double KurtosisType3Async
                                    (
                                        this IEnumerable<double> x
                                    )
        {
            double g_2 = x.KurtosisType1();
            int n = x.Count();

            return (g_2 + 3.0) * (1.0 - 1.0 / n) * (1.0 - 1.0 / n) - 3.0;
        }

        public static decimal KurtosisType3Async
                                    (
                                        this IEnumerable<decimal> x
                                    )
        {
            decimal g_2 = x.KurtosisType1();
            int n = x.Count();

            return (g_2 + 3.0m) * (1.0m - 1.0m / n) * (1.0m - 1.0m / n) - 3.0m;
        }
        //==============================================================================================================
    }
}
