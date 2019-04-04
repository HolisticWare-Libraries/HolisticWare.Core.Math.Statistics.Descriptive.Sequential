using System;
using System.Collections.Generic;
using System.Linq;

using Core.Math.Statistics.Descriptive.Sequential;

namespace Core.Math.Statistics.Descriptive.Sequential
{
    /// <summary>
    /// Correlation
    /// </summary>
    /// <see cref="https://ncalculators.com/statistics/weighted-mean-calculator.htm"/>
    public static partial class MemoryExtensionsMeanWeighted
    {
        //==============================================================================================================
        /// <summary>
        /// Means the weighted.
        /// </summary>
        /// <returns>The weighted.</returns>
        /// <param name="x">The x coordinate.</param>
        /// <param name="w">The width.</param>
        /// <see cref="https://ncalculators.com/statistics/weighted-mean-calculator.htm"/>
        public static double MeanWeighted
                                    (
                                        this Memory<byte> x
                                        , Memory<double> w
                                    )
        {
            return x.MeanArithmeticWeighted(w);
        }

        public static double MeanWeighted
                                    (
                                        this Memory<short> x, 
                                        Memory<double> w
                                    )
        {
            return x.MeanArithmeticWeighted(w);
        }

        public static double MeanWeighted
                                    (
                                        this Memory<ushort> x, 
                                        Memory<double> w
                                    )
        {
            return x.MeanArithmeticWeighted(w);
        }

        public static double MeanWeighted
                                    (
                                        this Memory<int> x, 
                                        Memory<double> w
                                    )
        {
            return x.MeanArithmeticWeighted(w);
        }

        public static double MeanWeighted
                                    (
                                        this Memory<uint> x, 
                                        Memory<double> w
                                    )
        {
            return x.MeanArithmeticWeighted(w);
        }

        public static double MeanWeighted
                                    (
                                        this Memory<long> x, 
                                        Memory<double> w
                                    )
        {
            return x.MeanArithmeticWeighted(w);
        }

        public static double MeanWeighted
                                    (
                                        this Memory<ulong> x, 
                                        Memory<double> w
                                    )
        {
            return x.MeanArithmeticWeighted(w);
        }

        public static double MeanWeighted
                                    (
                                        this Memory<float> x, 
                                        Memory<double> w
                                    )
        {
            return x.MeanArithmeticWeighted(w);
        }

        public static double MeanWeighted
                                    (
                                        this Memory<double> x, 
                                        Memory<double> w
                                    )
        {
            return x.MeanArithmeticWeighted(w);
        }

        public static decimal MeanWeighted
                                    (
                                        this Memory<decimal> x, 
                                        Memory<double> w
                                    )
        {
            return x.MeanArithmeticWeighted(w);
        }

        //==============================================================================================================

    }
}
