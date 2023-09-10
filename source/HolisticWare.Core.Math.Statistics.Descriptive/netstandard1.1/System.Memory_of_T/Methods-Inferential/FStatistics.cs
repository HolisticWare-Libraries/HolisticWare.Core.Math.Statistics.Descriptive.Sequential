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
        public static double Calculate
                                    (
                                        Memory<byte> x, 
                                        Memory<byte> y
                                    )
        {
            return x.FStatistic(y);
        }

        public static double Calculate
                                    (
                                        Memory<short> x, 
                                        Memory<short> y
                                    )
        {
            return x.FStatistic(y);
        }

        public static double Calculate
                                    (
                                        Memory<ushort> x, 
                                        Memory<ushort> y
                                    )
        {
            return x.FStatistic(y);
        }

        public static double Calculate
                                    (
                                        Memory<int> x, 
                                        Memory<int> y
                                    )
        {
            return x.FStatistic(y);
        }

        public static double Calculate
                                    (
                                        Memory<uint> x, 
                                        Memory<uint> y
                                    )
        {
            return x.FStatistic(y);
        }

        public static double Calculate
                                    (
                                        Memory<long> x, 
                                        Memory<long> y
                                    )
        {
            return x.FStatistic(y);
        }

        public static double Calculate
                                    (
                                        Memory<ulong> x, 
                                        Memory<ulong> y
                                    )
        {
            return x.FStatistic(y);
        }
       
        public static double Calculate
                                    (
                                        Memory<float> x, 
                                        Memory<float> y
                                    )
        {
            return x.FStatistic(y);
        }

        public static double Calculate
                                    (
                                        Memory<double> x, 
                                        Memory<double> y
                                    )
        {
            return x.FStatistic(y);
        }

        public static decimal Calculate
                                    (
                                        Memory<decimal> x, 
                                        Memory<decimal> y
                                    )
        {
            return x.FStatistic(y);
        }
        //==============================================================================================================

    }
}
