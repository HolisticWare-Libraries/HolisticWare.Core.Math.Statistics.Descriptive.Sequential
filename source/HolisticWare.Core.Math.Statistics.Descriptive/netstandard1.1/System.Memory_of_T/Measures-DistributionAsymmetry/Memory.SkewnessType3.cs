using System;
using System.Linq;

using Core.LINQ.Memory;

namespace Core.Math.Statistics.Descriptive
{
    public static partial class MemoryExtensionsSkewnessType3
    {
        //==============================================================================================================
        /// <summary>
        /// Skewnesses of the Type3 (unbiased under normality)
        /// 
        /// Used in some R packages, MINITAB and BMDP
        /// </summary>
        /// <returns>skewnwss of type1.</returns>
        /// <param name="x">x data</param>
        /// <see href="https://en.wikipedia.org/wiki/Skewness"/>
        /// <see href="https://www.rdocumentation.org/packages/e1071/versions/1.6-8/topics/skewness"/>
        /// <see href="http://www.itl.nist.gov/div898/handbook/eda/section3/eda35b.htm"/>
        /// <see href="https://cran.r-project.org/web/packages/e1071/e1071.pdf"/>
        public static double SkewnessType3
                                    (
                                        this Memory<byte> x
                                    )
        {
            int n = x.Count();

            return x.SkewnessType1() * System.Math.Pow((n - 1) / n, 3.0 / 2.0);
        }

        public static double SkewnessType3
                                    (
                                        this Memory<short> x
                                    )
        {
            int n = x.Count();

            return x.SkewnessType1() * System.Math.Pow((n - 1) / n, 3.0 / 2.0);
        }

        public static double SkewnessType3
                                    (
                                        this Memory<ushort> x
                                    )
        {
            int n = x.Count();

            return x.SkewnessType1() * System.Math.Pow((n - 1) / n, 3.0 / 2.0);
        }

        public static double SkewnessType3
                                    (
                                        this Memory<int> x
                                    )
        {
            int n = x.Count();

            return x.SkewnessType1() * System.Math.Pow((n - 1) / n, 3.0 / 2.0);
        }

        public static double SkewnessType3
                                    (
                                        this Memory<uint> x
                                    )
        {
            int n = x.Count();

            return x.SkewnessType1() * System.Math.Pow((n - 1) / n, 3.0 / 2.0);
        }

        public static double SkewnessType3
                                    (
                                        this Memory<long> x
                                    )
        {
            int n = x.Count();

            return x.SkewnessType1() * System.Math.Pow((n - 1) / n, 3.0 / 2.0);
        }

        public static double SkewnessType3
                                    (
                                        this Memory<ulong> x
                                    )
        {
            int n = x.Count();

            return x.SkewnessType1() * System.Math.Pow((n - 1) / n, 3.0 / 2.0);
        }

        public static double SkewnessType3
                                    (
                                        this Memory<float> x
                                    )
        {
            int n = x.Count();

            return x.SkewnessType1() * System.Math.Pow((n - 1) / n, 3.0 / 2.0);
        }

        public static double SkewnessType3
                                    (
                                        this Memory<double> x
                                    )
        {
            int n = x.Count();

            return x.SkewnessType1() * System.Math.Pow((n - 1) / n, 3.0 / 2.0);
        }

        public static decimal SkewnessType3
                                    (
                                        this Memory<decimal> x
                                    )
        {
            int n = x.Count();

            return x.SkewnessType1() * (decimal) System.Math.Pow((n - 1) / n, 3.0 / 2.0);
        }
        //==============================================================================================================
    
    }
}
