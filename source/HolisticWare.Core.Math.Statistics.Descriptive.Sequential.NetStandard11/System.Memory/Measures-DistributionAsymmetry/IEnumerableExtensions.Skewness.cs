using System;
using System.Collections.Generic;
using System.Linq;

namespace Core.Math.Statistics.Descriptive.Sequential
{
    public static partial class IEnumerableExtensionsSkewness
    {
        //==============================================================================================================
        /// <summary>
        /// Skewnesses of the Type1 (unbiased under normality)
        /// 
        /// Used in older books.
        /// </summary>
        /// <returns>skewnwss of type1.</returns>
        /// <param name="x">x data</param>
        /// <seealso cref="https://en.wikipedia.org/wiki/Skewness"/>
        /// <seealso cref="https://www.rdocumentation.org/packages/e1071/versions/1.6-8/topics/skewness"/>
        /// <seealso cref="http://www.itl.nist.gov/div898/handbook/eda/section3/eda35b.htm"/>
        /// <seealso cref="https://cran.r-project.org/web/packages/e1071/e1071.pdf"/>
        public static double Skewness
                                    (
                                        this IEnumerable<byte> x,
                                        int type = 1
                                    )
        {
            double s = double.NaN;

            switch (type)
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
                    throw new InvalidOperationException($"Skewness type not supported = {type}");
            }

            return s;
        }

        public static double Skewness
                                    (
                                        this IEnumerable<short> x,
                                        int type = 1
                                    )
        {
            double s = double.NaN;

            switch (type)
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
                    throw new InvalidOperationException($"Skewness type not supported = {type}");
            }

            return s;
        }

        public static double Skewness
                                    (
                                        this IEnumerable<ushort> x,
                                        int type = 1
                                    )
        {
            double s = double.NaN;

            switch (type)
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
                    throw new InvalidOperationException($"Skewness type not supported = {type}");
            }

            return s;
        }

        public static double Skewness
                                    (
                                        this IEnumerable<int> x,
                                        int type = 1
                                    )
        {
            double s = double.NaN;

            switch (type)
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
                    throw new InvalidOperationException($"Skewness type not supported = {type}");
            }

            return s;
        }

        public static double Skewness
                                    (
                                        this IEnumerable<uint> x,
                                        int type = 1
                                    )
        {
            double s = double.NaN;

            switch (type)
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
                    throw new InvalidOperationException($"Skewness type not supported = {type}");
            }

            return s;
        }

        public static double Skewness
                                    (
                                        this IEnumerable<long> x,
                                        int type = 1
                                    )
        {
            double s = double.NaN;

            switch (type)
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
                    throw new InvalidOperationException($"Skewness type not supported = {type}");
            }

            return s;
        }

        public static double Skewness
                                    (
                                        this IEnumerable<ulong> x,
                                        int type = 1
                                    )
        {
            double s = double.NaN;

            switch (type)
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
                    throw new InvalidOperationException($"Skewness type not supported = {type}");
            }

            return s;
        }

        public static double Skewness
                                    (
                                        this IEnumerable<float> x,
                                        int type = 1
                                    )
        {
            double s = double.NaN;

            switch (type)
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
                    throw new InvalidOperationException($"Skewness type not supported = {type}");
            }

            return s;
        }

        public static double Skewness
                                    (
                                        this IEnumerable<double> x,
                                        int type = 1
                                    )
        {
            double s = double.NaN;

            switch (type)
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
                    throw new InvalidOperationException($"Skewness type not supported = {type}");
            }

            return s;
        }

        public static decimal Skewness
                                    (
                                        this IEnumerable<decimal> x,
                                        int type = 1
                                    )
        {
            decimal? s = null;

            switch (type)
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
                    throw new InvalidOperationException($"Skewness type not supported = {type}");
            }

            return s.Value;
        }
        //==============================================================================================================
    
    }
}
