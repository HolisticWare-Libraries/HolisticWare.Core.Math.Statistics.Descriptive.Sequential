using System;
using System.Collections.Generic;
using System.Linq;

namespace Core.Math.Statistics.Descriptive
{
    public static partial class MemoryExtensionsSkewness
    {
        //==============================================================================================================
        /// <summary>
        /// Skewnesses of the Type1 (unbiased under normality)
        /// 
        /// Used in older books.
        /// </summary>
        /// <returns>skewnwss of type1.</returns>
        /// <param name="x">x data</param>
        /// <seealso href="https://en.wikipedia.org/wiki/Skewness"/>
        /// <seealso href="https://www.rdocumentation.org/packages/e1071/versions/1.6-8/topics/skewness"/>
        /// <seealso href="http://www.itl.nist.gov/div898/handbook/eda/section3/eda35b.htm"/>
        /// <seealso href="https://cran.r-project.org/web/packages/e1071/e1071.pdf"/>
        public static double Skewness
                                    (
                                        this Memory<byte> x,
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
                                        this Memory<short> x,
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
                                        this Memory<ushort> x,
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
                                        this Memory<int> x,
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
                                        this Memory<uint> x,
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
                                        this Memory<long> x,
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
                                        this Memory<ulong> x,
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
                                        this Memory<float> x,
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
                                        this Memory<double> x,
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
                                        this Memory<decimal> x,
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
