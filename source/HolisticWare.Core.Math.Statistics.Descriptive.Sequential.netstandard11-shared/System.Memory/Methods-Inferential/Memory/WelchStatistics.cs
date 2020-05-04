using System;
using System.Collections.Generic;
using System.Linq;

using Core.Math.Statistics;

namespace Core.Math.Statistics.Descriptive.Sequential
{
    /// <summary>
    /// Correlation
    /// </summary>
    public static partial class WelchtStatistic
    {
        //==============================================================================================================
        public static (double welch_t, double degrees_of_freedom) Calculate
                                                                        (
                                                                            Memory<byte> x, 
                                                                            Memory<byte> y
                                                                        )
        {
            return x.WelchtStatistic(y);
        }

        public static (double welch_t, double degrees_of_freedom) Calculate
                                                                        (
                                                                            Memory<short> x, 
                                                                            Memory<short> y
                                                                        )
        {
            return x.WelchtStatistic(y);
        }

        public static (double welch_t, double degrees_of_freedom) Calculate
                                                                        (
                                                                            Memory<ushort> x, 
                                                                            Memory<ushort> y
                                                                        )
        {
            return x.WelchtStatistic(y);
        }

        public static (double welch_t, double degrees_of_freedom) Calculate
                                                                        (
                                                                            Memory<int> x, 
                                                                            Memory<int> y
                                                                        )
        {
            return x.WelchtStatistic(y);
        }

        public static (double welch_t, double degrees_of_freedom) Calculate
                                                                        (
                                                                            Memory<uint> x, 
                                                                            Memory<uint> y
                                                                        )
        {
            return x.WelchtStatistic(y);
        }

        public static (double welch_t, double degrees_of_freedom) Calculate
                                                                        (
                                                                            Memory<long> x, 
                                                                            Memory<long> y
                                                                        )
        {
            return x.WelchtStatistic(y);
        }

        public static (double welch_t, double degrees_of_freedom) Calculate
                                                                        (
                                                                            Memory<ulong> x, 
                                                                            Memory<ulong> y
                                                                        )
        {
            return x.WelchtStatistic(y);
        }

        public static (double welch_t, double degrees_of_freedom) Calculate
                                                                        (
                                                                            Memory<float> x, 
                                                                            Memory<float> y
                                                                        )
        {
            return x.WelchtStatistic(y);
        }

        public static (double welch_t, double degrees_of_freedom) Calculate
                                                                        (
                                                                            Memory<double> x, 
                                                                            Memory<double> y
                                                                        )
        {
            return x.WelchtStatistic(y);
        }

        public static (decimal welch_t, decimal degrees_of_freedom) Calculate
                                                                        (
                                                                            Memory<decimal> x, 
                                                                            Memory<decimal> y
                                                                        )
        {
            return x.WelchtStatistic(y);
        }
        //==============================================================================================================

    }
}
