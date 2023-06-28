using System;
using System.Collections.Generic;
using System.Linq;

namespace Core.Math.Statistics.Descriptive
{
    public static partial class IEnumerableExtensionsSkewness
    {
        //==============================================================================================================
        /// <summary>
        /// Skewnesses of the skewness_type1 (unbiased under normality)
        /// 
        /// Used in older books.
        /// </summary>
        /// <returns>skewnwss of skewness_type1.</returns>
        /// <param name="x">x data</param>
        /// <param name="skewness_type">x data</param>
        /// <seealso href="https://en.wikipedia.org/wiki/Skewness"/>
        /// <seealso href="https://www.rdocumentation.org/packages/e1071/versions/1.6-8/topics/skewness"/>
        /// <seealso href="http://www.itl.nist.gov/div898/handbook/eda/section3/eda35b.htm"/>
        /// <seealso href="https://cran.r-project.org/web/packages/e1071/e1071.pdf"/>
        public static double SkewnessAsync
                                    (
                                        this IEnumerable<byte> x,
                                        int skewness_type = 1
                                    )
        {
            double s = double.NaN;

            switch (skewness_type)
            {
                case 1:
                    s = x.SkewnessType1();
                    break;
                case 2:
                    s = x.SkewnessType2();
                    break;
                case 3:
                    s = x.SkewnessType3();
                    break;
                default:
                    throw new InvalidOperationException($"Skewness skewness_type not supported = {skewness_type}");
            }

            return s;
        }

        public static double SkewnessAsync
                                    (
                                        this IEnumerable<short> x,
                                        int skewness_type = 1
                                    )
        {
            double s = double.NaN;

            switch (skewness_type)
            {
                case 1:
                    s = x.SkewnessType1();
                    break;
                case 2:
                    s = x.SkewnessType2();
                    break;
                case 3:
                    s = x.SkewnessType3();
                    break;
                default:
                    throw new InvalidOperationException($"Skewness skewness_type not supported = {skewness_type}");
            }

            return s;
        }

        public static double SkewnessAsync
                                    (
                                        this IEnumerable<ushort> x,
                                        int skewness_type = 1
                                    )
        {
            double s = double.NaN;

            switch (skewness_type)
            {
                case 1:
                    s = x.SkewnessType1();
                    break;
                case 2:
                    s = x.SkewnessType2();
                    break;
                case 3:
                    s = x.SkewnessType3();
                    break;
                default:
                    throw new InvalidOperationException($"Skewness skewness_type not supported = {skewness_type}");
            }

            return s;
        }

        public static double SkewnessAsync
                                    (
                                        this IEnumerable<int> x,
                                        int skewness_type = 1
                                    )
        {
            double s = double.NaN;

            switch (skewness_type)
            {
                case 1:
                    s = x.SkewnessType1();
                    break;
                case 2:
                    s = x.SkewnessType2();
                    break;
                case 3:
                    s = x.SkewnessType3();
                    break;
                default:
                    throw new InvalidOperationException($"Skewness skewness_type not supported = {skewness_type}");
            }

            return s;
        }

        public static double SkewnessAsync
                                    (
                                        this IEnumerable<uint> x,
                                        int skewness_type = 1
                                    )
        {
            double s = double.NaN;

            switch (skewness_type)
            {
                case 1:
                    s = x.SkewnessType1();
                    break;
                case 2:
                    s = x.SkewnessType2();
                    break;
                case 3:
                    s = x.SkewnessType3();
                    break;
                default:
                    throw new InvalidOperationException($"Skewness skewness_type not supported = {skewness_type}");
            }

            return s;
        }

        public static double SkewnessAsync
                                    (
                                        this IEnumerable<long> x,
                                        int skewness_type = 1
                                    )
        {
            double s = double.NaN;

            switch (skewness_type)
            {
                case 1:
                    s = x.SkewnessType1();
                    break;
                case 2:
                    s = x.SkewnessType2();
                    break;
                case 3:
                    s = x.SkewnessType3();
                    break;
                default:
                    throw new InvalidOperationException($"Skewness skewness_type not supported = {skewness_type}");
            }

            return s;
        }

        public static double SkewnessAsync
                                    (
                                        this IEnumerable<ulong> x,
                                        int skewness_type = 1
                                    )
        {
            double s = double.NaN;

            switch (skewness_type)
            {
                case 1:
                    s = x.SkewnessType1();
                    break;
                case 2:
                    s = x.SkewnessType2();
                    break;
                case 3:
                    s = x.SkewnessType3();
                    break;
                default:
                    throw new InvalidOperationException($"Skewness skewness_type not supported = {skewness_type}");
            }

            return s;
        }

        public static double SkewnessAsync
                                    (
                                        this IEnumerable<float> x,
                                        int skewness_type = 1
                                    )
        {
            double s = double.NaN;

            switch (skewness_type)
            {
                case 1:
                    s = x.SkewnessType1();
                    break;
                case 2:
                    s = x.SkewnessType2();
                    break;
                case 3:
                    s = x.SkewnessType3();
                    break;
                default:
                    throw new InvalidOperationException($"Skewness skewness_type not supported = {skewness_type}");
            }

            return s;
        }

        public static double SkewnessAsync
                                    (
                                        this IEnumerable<double> x,
                                        int skewness_type = 1
                                    )
        {
            double s = double.NaN;

            switch (skewness_type)
            {
                case 1:
                    s = x.SkewnessType1();
                    break;
                case 2:
                    s = x.SkewnessType2();
                    break;
                case 3:
                    s = x.SkewnessType3();
                    break;
                default:
                    throw new InvalidOperationException($"Skewness skewness_type not supported = {skewness_type}");
            }

            return s;
        }

        public static decimal SkewnessAsync
                                    (
                                        this IEnumerable<decimal> x,
                                        int skewness_type = 1
                                    )
        {
            decimal? s = null;

            switch (skewness_type)
            {
                case 1:
                    s = x.SkewnessType1();
                    break;
                case 2:
                    s = x.SkewnessType2();
                    break;
                case 3:
                    s = x.SkewnessType3();
                    break;
                default:
                    throw new InvalidOperationException($"Skewness skewness_type not supported = {skewness_type}");
            }

            return s.Value;
        }
        //==============================================================================================================
    
    }
}
