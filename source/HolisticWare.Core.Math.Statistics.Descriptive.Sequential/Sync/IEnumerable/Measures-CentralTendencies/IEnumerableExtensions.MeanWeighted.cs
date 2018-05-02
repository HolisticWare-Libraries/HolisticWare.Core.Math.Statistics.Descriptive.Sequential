using System;
using System.Collections.Generic;
using System.Linq;

using Core.Math.Statistics.Descriptive.Sequential;

namespace Core.Math.Statistics.Descriptive.Sequential
{
    /// <summary>
    /// Correlation
    /// </summary>
    public static partial class IEnumerableExtensionsMeanWeighted
    {
        //==============================================================================================================
        public static double MeanWeighted
                                    (
                                        this IEnumerable<byte> x
                                        , IEnumerable<double> w
                                    )
        {
            return x.MeanArithmeticWeighted(w);
        }

        public static double MeanWeighted
                                    (
                                        this IEnumerable<short> x, 
                                        IEnumerable<double> w
                                    )
        {
            return x.MeanArithmeticWeighted(w);
        }

        public static double MeanWeighted
                                    (
                                        this IEnumerable<ushort> x, 
                                        IEnumerable<double> w
                                    )
        {
            return x.MeanArithmeticWeighted(w);
        }

        public static double MeanWeighted
                                    (
                                        this IEnumerable<int> x, 
                                        IEnumerable<double> w
                                    )
        {
            return x.MeanArithmeticWeighted(w);
        }

        public static double MeanWeighted
                                    (
                                        this IEnumerable<uint> x, 
                                        IEnumerable<double> w
                                    )
        {
            return x.MeanArithmeticWeighted(w);
        }

        public static double MeanWeighted
                                    (
                                        this IEnumerable<long> x, 
                                        IEnumerable<double> w
                                    )
        {
            return x.MeanArithmeticWeighted(w);
        }

        public static double MeanWeighted
                                    (
                                        this IEnumerable<ulong> x, 
                                        IEnumerable<double> w
                                    )
        {
            return x.MeanArithmeticWeighted(w);
        }

        public static double MeanWeighted
                                    (
                                        this IEnumerable<float> x, 
                                        IEnumerable<double> w
                                    )
        {
            return x.MeanArithmeticWeighted(w);
        }

        public static double MeanWeighted
                                    (
                                        this IEnumerable<double> x, 
                                        IEnumerable<double> w
                                    )
        {
            return x.MeanArithmeticWeighted(w);
        }

        public static decimal MeanWeighted
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
