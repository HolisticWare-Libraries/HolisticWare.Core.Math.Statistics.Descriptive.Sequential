using System;
using System.Collections.Generic;
using System.Linq;

namespace Core.Math.Statistics.Descriptive
{
    /// <summary>
    /// Kurtosis Sample Excess
    /// Excel KURT()
    /// </summary>
    /// <see href="https://en.wikipedia.org/wiki/Kurtosis"/>
    /// <see href="https://brownmath.com/stat/shape.htm"/>
    /// <see href="https://cran.r-project.org/web/packages/e1071/e1071.pdf"/>
   public static partial class IEnumerableExtensionsKurtosisSampleExcess
    {
        //==============================================================================================================
        public static double KurtosisSampleExcessAsync
                                            (
                                                this IEnumerable<byte> x
                                            )
        {
            int n = x.Count();

            if (n >= 3)
            {
                return (n - 1) * ((n + 1) * x.KurtosisExcess() + 6) / ((n - 2) * (n - 3));
            }

            return 0;
        }

        public static double KurtosisSampleExcessAsync
                                            (
                                                this IEnumerable<short> x
                                            )
        {
            int n = x.Count();

            if (n >= 3)
            {
                return (n - 1) * ((n + 1) * x.KurtosisExcess() + 6) / ((n - 2) * (n - 3));
            }

            return 0;
        }

        public static double KurtosisSampleExcessAsync
                                            (
                                                this IEnumerable<ushort> x
                                            )
        {
            int n = x.Count();

            if (n >= 3)
            {
                return (n - 1) * ((n + 1) * x.KurtosisExcess() + 6) / ((n - 2) * (n - 3));
            }

            return 0;
        }

        public static double KurtosisSampleExcessAsync
                                            (
                                                this IEnumerable<int> x
                                            )
        {
            int n = x.Count();

            if (n >= 3)
            {
                return (n - 1) * ((n + 1) * x.KurtosisExcess() + 6) / ((n - 2) * (n - 3));
            }

            return 0;
        }

        public static double KurtosisSampleExcessAsync
                                            (
                                                this IEnumerable<uint> x
                                            )
        {
            int n = x.Count();

            if (n >= 3)
            {
                return (n - 1) * ((n + 1) * x.KurtosisExcess() + 6) / ((n - 2) * (n - 3));
            }

            return 0;
        }

        public static double KurtosisSampleExcessAsync
                                            (
                                                this IEnumerable<long> x
                                            )
        {
            int n = x.Count();

            if (n >= 3)
            {
                return (n - 1) * ((n + 1) * x.KurtosisExcess() + 6) / ((n - 2) * (n - 3));
            }

            return 0;
        }

        public static double KurtosisSampleExcessAsync
                                            (
                                                this IEnumerable<ulong> x
                                            )
        {
            int n = x.Count();

            if (n >= 3)
            {
                return (n - 1) * ((n + 1) * x.KurtosisExcess() + 6) / ((n - 2) * (n - 3));
            }

            return 0;
        }

        public static double KurtosisSampleExcessAsync
                                            (
                                                this IEnumerable<float> x
                                            )
        {
            int n = x.Count();

            if (n >= 3)
            {
                return (n - 1) * ((n + 1) * x.KurtosisExcess() + 6) / ((n - 2) * (n - 3));
            }

            return 0;
        }

        public static double KurtosisSampleExcessAsync
                                            (
                                                this IEnumerable<double> x
                                            )
        {
            int n = x.Count();

            if (n >= 3)
            {
                return (n - 1) * ((n + 1) * x.KurtosisExcess() + 6) / ((n - 2) * (n - 3));
            }

            return 0;
        }

        public static decimal KurtosisSampleExcessAsync
                                            (
                                                this IEnumerable<decimal> x
                                            )
        {
            int n = x.Count();

            if (n >= 3)
            {
                return (n - 1) * ((n + 1) * x.KurtosisExcess() + 6) / ((n - 2) * (n - 3));
            }

            return 0;
        }
        //==============================================================================================================

    }
}
