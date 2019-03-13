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
                                                                            IEnumerable<byte> x, 
                                                                            IEnumerable<byte> y
                                                                        )
        {
            return x.WelchtStatistic(y);
        }

        public static (double welch_t, double degrees_of_freedom) Calculate
                                                                        (
                                                                            IEnumerable<short> x, 
                                                                            IEnumerable<short> y
                                                                        )
        {
            return x.WelchtStatistic(y);
        }

        public static (double welch_t, double degrees_of_freedom) Calculate
                                                                        (
                                                                            IEnumerable<ushort> x, 
                                                                            IEnumerable<ushort> y
                                                                        )
        {
            return x.WelchtStatistic(y);
        }

        public static (double welch_t, double degrees_of_freedom) Calculate
                                                                        (
                                                                            IEnumerable<int> x, 
                                                                            IEnumerable<int> y
                                                                        )
        {
            return x.WelchtStatistic(y);
        }

        public static (double welch_t, double degrees_of_freedom) Calculate
                                                                        (
                                                                            IEnumerable<uint> x, 
                                                                            IEnumerable<uint> y
                                                                        )
        {
            return x.WelchtStatistic(y);
        }

        public static (double welch_t, double degrees_of_freedom) Calculate
                                                                        (
                                                                            IEnumerable<long> x, 
                                                                            IEnumerable<long> y
                                                                        )
        {
            return x.WelchtStatistic(y);
        }

        public static (double welch_t, double degrees_of_freedom) Calculate
                                                                        (
                                                                            IEnumerable<ulong> x, 
                                                                            IEnumerable<ulong> y
                                                                        )
        {
            return x.WelchtStatistic(y);
        }

        public static (double welch_t, double degrees_of_freedom) Calculate
                                                                        (
                                                                            IEnumerable<float> x, 
                                                                            IEnumerable<float> y
                                                                        )
        {
            return x.WelchtStatistic(y);
        }

        public static (double welch_t, double degrees_of_freedom) Calculate
                                                                        (
                                                                            IEnumerable<double> x, 
                                                                            IEnumerable<double> y
                                                                        )
        {
            return x.WelchtStatistic(y);
        }

        public static (decimal welch_t, decimal degrees_of_freedom) Calculate
                                                                        (
                                                                            IEnumerable<decimal> x, 
                                                                            IEnumerable<decimal> y
                                                                        )
        {
            return x.WelchtStatistic(y);
        }
        //==============================================================================================================

    }
}
