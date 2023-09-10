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
    public static partial class
                                        IEnumerableExtensionsKurtosis
    {
        //==============================================================================================================
        /// <summary>
        /// Kurtosis of the Type1 (unbiased under normality)
        /// 
        /// Used in older books.
        /// </summary>
        /// <returns>Kurtosis of type1.</returns>
        /// <param name="x">x data</param>
        /// <param name="kurtosis_type">x data</param>
        /// <see href="https://www.rdocumentation.org/packages/SciencesPo/versions/1.4.1/topics/Kurtosis"/>
        /// <see href="https://docs.scipy.org/doc/scipy-0.7.x/reference/generated/scipy.stats.kurtosis.html"/>
        public static
            double
                                        Kurtosis
                                        (
                                            this IEnumerable<byte> x,
                                            int kurtosis_type = 1
                                        )
        {
            double s = double.NaN;

            switch (kurtosis_type)
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
                    throw new InvalidOperationException($"Kurtosis type not supported = {kurtosis_type}");
            }

            return s;
        }

        public static
            double
                                        Kurtosis
                                        (
                                            this IEnumerable<short> x,
                                            int kurtosis_type = 1
                                        )
        {
            double s = double.NaN;

            switch (kurtosis_type)
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
                    throw new InvalidOperationException($"Kurtosis type not supported = {kurtosis_type}");
            }

            return s;
        }

        public static
            double
                                        Kurtosis
                                        (
                                            this IEnumerable<ushort> x,
                                            int kurtosis_type = 1
                                        )
        {
            double s = double.NaN;

            switch (kurtosis_type)
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
                    throw new InvalidOperationException($"Kurtosis type not supported = {kurtosis_type}");
            }

            return s;
        }

        public static
            double
                                        Kurtosis
                                        (
                                            this IEnumerable<int> x,
                                            int kurtosis_type = 1
                                        )
        {
            double s = double.NaN;

            switch (kurtosis_type)
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
                    throw new InvalidOperationException($"Kurtosis type not supported = {kurtosis_type}");
            }

            return s;
        }

        public static
            double
                                        Kurtosis
                                        (
                                            this IEnumerable<uint> x,
                                            int kurtosis_type = 1
                                        )
        {
            double s = double.NaN;

            switch (kurtosis_type)
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
                    throw new InvalidOperationException($"Kurtosis type not supported = {kurtosis_type}");
            }

            return s;
        }

        public static
            double
                                        Kurtosis
                                        (
                                            this IEnumerable<long> x,
                                            int kurtosis_type = 1
                                        )
        {
            double s = double.NaN;

            switch (kurtosis_type)
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
                    throw new InvalidOperationException($"Kurtosis type not supported = {kurtosis_type}");
            }

            return s;
        }

        public static
            double
                                        Kurtosis
                                        (
                                            this IEnumerable<ulong> x,
                                            int kurtosis_type = 1
                                        )
        {
            double s = double.NaN;

            switch (kurtosis_type)
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
                    throw new InvalidOperationException($"Kurtosis type not supported = {kurtosis_type}");
            }

            return s;
        }

        public static
            double
                                        Kurtosis
                                        (
                                            this IEnumerable<float> x,
                                            int kurtosis_type = 1
                                        )
        {
            double s = double.NaN;

            switch (kurtosis_type)
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
                    throw new InvalidOperationException($"Kurtosis type not supported = {kurtosis_type}");
            }

            return s;
        }

        public static
            double
                                        Kurtosis
                                        (
                                            this IEnumerable<double> x,
                                            int kurtosis_type = 1
                                        )
        {
            double s = double.NaN;

            switch (kurtosis_type)
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
                    throw new InvalidOperationException($"Kurtosis type not supported = {kurtosis_type}");
            }

            return s;
        }

        public static
            decimal
                                        Kurtosis
                                        (
                                            this IEnumerable<decimal> x,
                                            int kurtosis_type = 1
                                        )
        {
            decimal? s = null;

            switch (kurtosis_type)
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
                    throw new InvalidOperationException($"Kurtosis type not supported = {kurtosis_type}");
            }

            return s.Value;
        }
        //==============================================================================================================
    }
}
