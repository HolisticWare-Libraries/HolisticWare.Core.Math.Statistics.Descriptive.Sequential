using System;
using System.Collections.Generic;
using System.Linq;

namespace Core.Math.Statistics.Descriptive.Sequential
{
    /// <summary>
    /// Kurtosis Sample Excess
    /// Excel KURT()
    /// </summary>
    /// <see cref="https://en.wikipedia.org/wiki/Kurtosis"/>
    /// <see cref="https://brownmath.com/stat/shape.htm"/>
    /// <see cref="https://cran.r-project.org/web/packages/e1071/e1071.pdf"/>
   public static partial class IEnumerableExtensionsKurtosisSampleExcess
    {
        //==============================================================================================================
        public static double KurtosisSampleExcess
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

        public static double KurtosisSampleExcess
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

        public static double KurtosisSampleExcess
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

        public static double KurtosisSampleExcess
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

        public static double KurtosisSampleExcess
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

        public static double KurtosisSampleExcess
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

        public static double KurtosisSampleExcess
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

        public static double KurtosisSampleExcess
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

        public static double KurtosisSampleExcess
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

        public static decimal KurtosisSampleExcess
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
