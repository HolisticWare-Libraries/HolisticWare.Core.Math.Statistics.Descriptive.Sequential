using System;
using System.Collections.Generic;
using System.Linq;

namespace Core.Math.Statistics.Descriptive.Sequential
{
    /// <summary>
    /// Kurtosis
    /// Sharpness of the peak of a frequency-distribution curve.
    /// </summary>
    /// <see cref="https://en.wikipedia.org/wiki/Kurtosis"/>
    /// <see cref="http://www.itl.nist.gov/div898/handbook/eda/section3/eda35b.htm"/>
    /// <see cref="https://cran.r-project.org/web/packages/e1071/e1071.pdf"/>
    public static partial class IEnumerableExtensionsKurtosis
    {
        //==============================================================================================================
        public static double Kurtosis
                                    (
                                        this IEnumerable<byte> x,
                                        int type = 3
                                    )
        {
            double s = double.NaN;

            switch (type)
            {
                case 1:
                    s = x.KurtosisType1();
                    break;
                case 2:
                    s = x.KurtosisType2();
                    break;
                case 3:
                    s = x.KurtosisType3();
                    break;
                default:
                    throw new InvalidOperationException($"Kurtosis type not supported = {type}");
            }

            return s;
        }

        public static double Kurtosis
                                    (
                                        this IEnumerable<short> x,
                                        int type = 3
                                    )
        {
            double s = double.NaN;

            switch (type)
            {
                case 1:
                    s = x.KurtosisType1();
                    break;
                case 2:
                    s = x.KurtosisType2();
                    break;
                case 3:
                    s = x.KurtosisType3();
                    break;
                default:
                    throw new InvalidOperationException($"Kurtosis type not supported = {type}");
            }

            return s;
        }

        public static double Kurtosis
                                    (
                                        this IEnumerable<ushort> x,
                                        int type = 3
                                    )
        {
            double s = double.NaN;

            switch (type)
            {
                case 1:
                    s = x.KurtosisType1();
                    break;
                case 2:
                    s = x.KurtosisType2();
                    break;
                case 3:
                    s = x.KurtosisType3();
                    break;
                default:
                    throw new InvalidOperationException($"Kurtosis type not supported = {type}");
            }

            return s;
        }

        public static double Kurtosis
                                    (
                                        this IEnumerable<int> x,
                                        int type = 3
                                    )
        {
            double s = double.NaN;

            switch (type)
            {
                case 1:
                    s = x.KurtosisType1();
                    break;
                case 2:
                    s = x.KurtosisType2();
                    break;
                case 3:
                    s = x.KurtosisType3();
                    break;
                default:
                    throw new InvalidOperationException($"Kurtosis type not supported = {type}");
            }

            return s;
        }

        public static double Kurtosis
                                    (
                                        this IEnumerable<uint> x,
                                        int type = 3
                                    )
        {
            double s = double.NaN;

            switch (type)
            {
                case 1:
                    s = x.KurtosisType1();
                    break;
                case 2:
                    s = x.KurtosisType2();
                    break;
                case 3:
                    s = x.KurtosisType3();
                    break;
                default:
                    throw new InvalidOperationException($"Kurtosis type not supported = {type}");
            }

            return s;
        }

        public static double Kurtosis
                                    (
                                        this IEnumerable<long> x,
                                        int type = 3
                                    )
        {
            double s = double.NaN;

            switch (type)
            {
                case 1:
                    s = x.KurtosisType1();
                    break;
                case 2:
                    s = x.KurtosisType2();
                    break;
                case 3:
                    s = x.KurtosisType3();
                    break;
                default:
                    throw new InvalidOperationException($"Kurtosis type not supported = {type}");
            }

            return s;
        }

        public static double Kurtosis
                                    (
                                        this IEnumerable<ulong> x,
                                        int type = 3
                                    )
        {
            double s = double.NaN;

            switch (type)
            {
                case 1:
                    s = x.KurtosisType1();
                    break;
                case 2:
                    s = x.KurtosisType2();
                    break;
                case 3:
                    s = x.KurtosisType3();
                    break;
                default:
                    throw new InvalidOperationException($"Kurtosis type not supported = {type}");
            }

            return s;
        }

        public static double Kurtosis
                                    (
                                        this IEnumerable<float> x,
                                        int type = 3
                                    )
        {
            double s = double.NaN;

            switch (type)
            {
                case 1:
                    s = x.KurtosisType1();
                    break;
                case 2:
                    s = x.KurtosisType2();
                    break;
                case 3:
                    s = x.KurtosisType3();
                    break;
                default:
                    throw new InvalidOperationException($"Kurtosis type not supported = {type}");
            }

            return s;
        }

        public static double Kurtosis
                                    (
                                        this IEnumerable<double> x,
                                        int type = 3
                                    )
        {
            double s = double.NaN;

            switch (type)
            {
                case 1:
                    s = x.KurtosisType1();
                    break;
                case 2:
                    s = x.KurtosisType2();
                    break;
                case 3:
                    s = x.KurtosisType3();
                    break;
                default:
                    throw new InvalidOperationException($"Kurtosis type not supported = {type}");
            }

            return s;
        }

        public static decimal Kurtosis
                                    (
                                        this IEnumerable<decimal> x,
                                        int type = 3
                                    )
        {
            decimal? s = null;

            switch (type)
            {
                case 1:
                    s = x.KurtosisType1();
                    break;
                case 2:
                    s = x.KurtosisType2();
                    break;
                case 3:
                    s = x.KurtosisType3();
                    break;
                default:
                    throw new InvalidOperationException($"Kurtosis type not supported = {type}");
            }

            return s.Value;
        }
        //==============================================================================================================
    }
}
