using System;
using System.Collections.Generic;
using System.Linq;

namespace Core.Math.Statistics.Descriptive
{
    /// <summary>
    /// F-Statistics / F test
    /// A value you get when you run an ANOVA test or a regression analysis to 
    /// find out if the means between two populations are significantly 
    /// </summary>
    /// <see href="https://en.wikipedia.org/wiki/F-test"/>
    public static partial class IEnumerableExtensionsFStatistic
    {
        //==============================================================================================================
        public static double FStatisticAsync
                                    (
                                        this IEnumerable<byte> x, 
                                        IEnumerable<byte> y
                                    )
        {
            return x.VarianceSample() / y.VarianceSample();
        }

        public static double FStatisticAsync
                                    (
                                        this IEnumerable<short> x, 
                                        IEnumerable<short> y
                                    )
        {
            return x.VarianceSample() / y.VarianceSample();
        }

        public static double FStatisticAsync
                                    (
                                        this IEnumerable<ushort> x, 
                                        IEnumerable<ushort> y
                                    )
        {
            return x.VarianceSample() / y.VarianceSample();
        }

        public static double FStatisticAsync
                                    (
                                        this IEnumerable<int> x, 
                                        IEnumerable<int> y
                                    )
        {
            return x.VarianceSample() / y.VarianceSample();
        }

        public static double FStatisticAsync
                                    (
                                        this IEnumerable<uint> x, 
                                        IEnumerable<uint> y
                                    )
        {
            return x.VarianceSample() / y.VarianceSample();
        }

        public static double FStatisticAsync
                                    (
                                        this IEnumerable<long> x, 
                                        IEnumerable<long> y
                                    )
        {
            return x.VarianceSample() / y.VarianceSample();
        }

        public static double FStatisticAsync
                                    (
                                        this IEnumerable<ulong> x, 
                                        IEnumerable<ulong> y
                                    )
        {
            return x.VarianceSample() / y.VarianceSample();
        }

        public static double FStatisticAsync
                                    (
                                        this IEnumerable<float> x, 
                                        IEnumerable<float> y
                                    )
        {
            return x.VarianceSample() / y.VarianceSample();
        }

        public static double FStatisticAsync
                                    (
                                        this IEnumerable<double> x, 
                                        IEnumerable<double> y
                                    )
        {
            return x.VarianceSample() / y.VarianceSample();
        }

        public static decimal FStatisticAsync
                                    (
                                        this IEnumerable<decimal> x, 
                                        IEnumerable<decimal> y
                                    )
        {
            return x.VarianceSample() / y.VarianceSample();
        }
        //==============================================================================================================
    }
}
