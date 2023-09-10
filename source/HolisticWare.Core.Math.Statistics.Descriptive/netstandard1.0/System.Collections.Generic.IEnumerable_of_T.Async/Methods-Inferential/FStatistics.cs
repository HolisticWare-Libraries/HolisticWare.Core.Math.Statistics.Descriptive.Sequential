using System;
using System.Collections.Generic;
using System.Linq;

using Core.Math.Statistics;

namespace Core.Math.Statistics.Descriptive
{
    /// <summary>
    /// Correlation
    /// </summary>
    public static partial class FStatistic
    {
        //==============================================================================================================
        public static double CalculateAsync
                                    (
                                        IEnumerable<byte> x, 
                                        IEnumerable<byte> y
                                    )
        {
            return x.FStatistic(y);
        }

        public static double CalculateAsync
                                    (
                                        IEnumerable<short> x, 
                                        IEnumerable<short> y
                                    )
        {
            return x.FStatistic(y);
        }

        public static double CalculateAsync
                                    (
                                        IEnumerable<ushort> x, 
                                        IEnumerable<ushort> y
                                    )
        {
            return x.FStatistic(y);
        }

        public static double CalculateAsync
                                    (
                                        IEnumerable<int> x, 
                                        IEnumerable<int> y
                                    )
        {
            return x.FStatistic(y);
        }

        public static double CalculateAsync
                                    (
                                        IEnumerable<uint> x, 
                                        IEnumerable<uint> y
                                    )
        {
            return x.FStatistic(y);
        }

        public static double CalculateAsync
                                    (
                                        IEnumerable<long> x, 
                                        IEnumerable<long> y
                                    )
        {
            return x.FStatistic(y);
        }

        public static double CalculateAsync
                                    (
                                        IEnumerable<ulong> x, 
                                        IEnumerable<ulong> y
                                    )
        {
            return x.FStatistic(y);
        }
       
        public static double CalculateAsync
                                    (
                                        IEnumerable<float> x, 
                                        IEnumerable<float> y
                                    )
        {
            return x.FStatistic(y);
        }

        public static double CalculateAsync
                                    (
                                        IEnumerable<double> x, 
                                        IEnumerable<double> y
                                    )
        {
            return x.FStatistic(y);
        }

        public static decimal CalculateAsync
                                    (
                                        IEnumerable<decimal> x, 
                                        IEnumerable<decimal> y
                                    )
        {
            return x.FStatistic(y);
        }
        //==============================================================================================================

    }
}
