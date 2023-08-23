using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Math.Statistics.Descriptive
{
    /// <summary>
    /// Correlation
    /// </summary>
    /// <see href="https://ncalculators.com/statistics/weighted-mean-calculator.htm"/>
    public static partial class
                                        IEnumerableExtensionsMeanWeighted
    {
        //==============================================================================================================
        /// <summary>
        /// Means the weighted.
        /// </summary>
        /// <returns>The weighted.</returns>
        /// <param name="x">The x coordinate.</param>
        /// <param name="w">The width.</param>
        /// <see href="https://ncalculators.com/statistics/weighted-mean-calculator.htm"/>
        public static double MeanWeightedAsync
                                    (
                                        this IEnumerable<byte> x
                                        , IEnumerable<double> w
                                    )
        {
            return x.MeanArithmeticWeighted(w);
        }

        public static double MeanWeightedAsync
                                    (
                                        this IEnumerable<short> x,
                                        IEnumerable<double> w
                                    )
        {
            return x.MeanArithmeticWeighted(w);
        }

        public static double MeanWeightedAsync
                                    (
                                        this IEnumerable<ushort> x,
                                        IEnumerable<double> w
                                    )
        {
            return x.MeanArithmeticWeighted(w);
        }

        public static double MeanWeightedAsync
                                    (
                                        this IEnumerable<int> x,
                                        IEnumerable<double> w
                                    )
        {
            return x.MeanArithmeticWeighted(w);
        }

        public static double MeanWeightedAsync
                                    (
                                        this IEnumerable<uint> x,
                                        IEnumerable<double> w
                                    )
        {
            return x.MeanArithmeticWeighted(w);
        }

        public static double MeanWeightedAsync
                                    (
                                        this IEnumerable<long> x,
                                        IEnumerable<double> w
                                    )
        {
            return x.MeanArithmeticWeighted(w);
        }

        public static double MeanWeightedAsync
                                    (
                                        this IEnumerable<ulong> x,
                                        IEnumerable<double> w
                                    )
        {
            return x.MeanArithmeticWeighted(w);
        }

        public static double MeanWeightedAsync
                                    (
                                        this IEnumerable<float> x,
                                        IEnumerable<double> w
                                    )
        {
            return x.MeanArithmeticWeighted(w);
        }

        public static double MeanWeightedAsync
                                    (
                                        this IEnumerable<double> x,
                                        IEnumerable<double> w
                                    )
        {
            return x.MeanArithmeticWeighted(w);
        }

        public static decimal MeanWeightedAsync
                                    (
                                        this IEnumerable<decimal> x,
                                        IEnumerable<double> w
                                    )
        {
            return x.MeanArithmeticWeighted(w);
        }

        //==============================================================================================================

    }
}
