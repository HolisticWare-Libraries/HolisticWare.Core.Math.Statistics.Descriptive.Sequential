using System;
using System.Linq;

using Core.LINQ.Memory;

namespace Core.Math.Statistics.Descriptive
{
    public static partial class MemoryExtensionsSkewnessType2
    {
        //==============================================================================================================
        /// <summary>
        /// Skewnesses of the Type2 (unbiased under normality)
        /// 
        /// Used in some R packages, SAS and SPSS.
        /// </summary>
        /// <returns>skewnwss of type1.</returns>
        /// <param name="x">x data</param>
        /// <see href="https://en.wikipedia.org/wiki/Skewness"/>
        /// <see href="https://www.rdocumentation.org/packages/e1071/versions/1.6-8/topics/skewness"/>
        /// <see href="http://www.itl.nist.gov/div898/handbook/eda/section3/eda35b.htm"/>
        /// <see href="https://cran.r-project.org/web/packages/e1071/e1071.pdf"/>
        public static double SkewnessType2
                                    (
                                        this Memory<byte> x
                                    )
        {
            int n = x.Count();

            return x.SkewnessType1() * System.Math.Sqrt(n * (n - 1)) / (n - 2);
        }

        public static double SkewnessType2
                                    (
                                        this Memory<short> x
                                    )
        {
            int n = x.Count();

            return x.SkewnessType1() * System.Math.Sqrt(n * (n - 1)) / (n - 2);
        }

        public static double SkewnessType2
                                    (
                                        this Memory<ushort> x
                                    )
        {
            int n = x.Count();

            return x.SkewnessType1() * System.Math.Sqrt(n * (n - 1)) / (n - 2);
        }

        public static double SkewnessType2
                                    (
                                        this Memory<int> x
                                    )
        {
            int n = x.Count();

            return x.SkewnessType1() * System.Math.Sqrt(n * (n - 1)) / (n - 2);
        }

        public static double SkewnessType2
                                    (
                                        this Memory<uint> x
                                    )
        {
            int n = x.Count();

            return x.SkewnessType1() * System.Math.Sqrt(n * (n - 1)) / (n - 2);
        }

        public static double SkewnessType2
                                    (
                                        this Memory<long> x
                                    )
        {
            int n = x.Count();

            return x.SkewnessType1() * System.Math.Sqrt(n * (n - 1)) / (n - 2);
        }

        public static double SkewnessType2
                                    (
                                        this Memory<ulong> x
                                    )
        {
            int n = x.Count();

            return x.SkewnessType1() * System.Math.Sqrt(n * (n - 1)) / (n - 2);
        }

        public static double SkewnessType2
                                    (
                                        this Memory<float> x
                                    )
        {
            int n = x.Count();

            return x.SkewnessType1() * System.Math.Sqrt(n * (n - 1)) / (n - 2);
        }

        public static double SkewnessType2
                                    (
                                        this Memory<double> x
                                    )
        {
            int n = x.Count();

            return x.SkewnessType1() * System.Math.Sqrt(n * (n - 1)) / (n - 2);
        }

        public static decimal SkewnessType2
                                    (
                                        this Memory<decimal> x
                                    )
        {
            int n = x.Count();

            return x.SkewnessType1() * (decimal) System.Math.Sqrt(n * (n - 1)) / (decimal) (n - 2);
        }
        //==============================================================================================================
    
    }
}
