using System;
using System.Collections.Generic;
using System.Linq;

namespace Core.Math.Statistics.Descriptive
{
    /// <summary>
    /// Kurtosis
    /// Sharpness of the peak of a frequency-distribution curve.
    /// </summary>
    /// <see href="https://en.wikipedia.org/wiki/Kurtosis"/>
    /// <see href="http://www.itl.nist.gov/div898/handbook/eda/section3/eda35b.htm"/>
    /// <see href="https://cran.r-project.org/web/packages/e1071/e1071.pdf"/>
    public static partial class IEnumerableExtensionsKurtosisExcess
    {
        //==============================================================================================================
        public static double KurtosisExcessAsync
                                        (
                                            this IEnumerable<byte> x
                                        )
        {
            return x.Kurtosis() - 3.0;
        }

        public static double KurtosisExcessAsync
                                        (
                                            this IEnumerable<short> x
                                        )
        {
            return x.Kurtosis() - 3.0;
        }

        public static double KurtosisExcessAsync
                                        (
                                            this IEnumerable<ushort> x
                                        )
        {
            return x.Kurtosis() - 3.0;
        }

        public static double KurtosisExcessAsync
                                        (
                                            this IEnumerable<int> x
                                        )
        {
            return x.Kurtosis() - 3.0;
        }

        public static double KurtosisExcessAsync
                                        (
                                            this IEnumerable<uint> x
                                        )
        {
            return x.Kurtosis() - 3.0;
        }

        public static double KurtosisExcessAsync
                                        (
                                            this IEnumerable<long> x
                                        )
        {
            return x.Kurtosis() - 3.0;
        }

        public static double KurtosisExcessAsync
                                        (
                                            this IEnumerable<ulong> x
                                        )
        {
            return x.Kurtosis() - 3.0;
        }

        public static double KurtosisExcessAsync
                                        (
                                            this IEnumerable<float> x
                                        )
        {
            return x.Kurtosis() - 3.0;
        }

        public static double KurtosisExcessAsync
                                        (
                                            this IEnumerable<double> x
                                        )
        {
            return x.Kurtosis() - 3.0;
        }

        public static decimal KurtosisExcessAsync
                                        (
                                            this IEnumerable<decimal> x
                                        )
        {
            return x.Kurtosis() - 3.0M;
        }
        //==============================================================================================================

    }
}
