using System;
using System.Collections.Generic;
using System.Linq;

using Core.Math.Statistics;

namespace Core.Math.Statistics.Descriptive
{
    /// <summary>
    /// Correlation
    /// </summary>
    public static partial class WelchtStatistic
    {
        //==============================================================================================================
        public static
            (double welch_t, double degrees_of_freedom)
                                        CalculateAsync
                                        (
                                            IEnumerable<byte> x, 
                                            IEnumerable<byte> y
                                        )
        {
            return x.WelchtStatistic(y);
        }

        public static
            (double welch_t, double degrees_of_freedom)
                                        CalculateAsync
                                        (
                                            IEnumerable<short> x, 
                                            IEnumerable<short> y
                                        )
        {
            return x.WelchtStatistic(y);
        }

        public static
            (double welch_t, double degrees_of_freedom)
                                        CalculateAsync
                                        (
                                            IEnumerable<ushort> x, 
                                            IEnumerable<ushort> y
                                        )
        {
            return x.WelchtStatistic(y);
        }

        public static
            (double welch_t, double degrees_of_freedom)
                                        CalculateAsync
                                        (
                                            IEnumerable<int> x, 
                                            IEnumerable<int> y
                                        )
        {
            return x.WelchtStatistic(y);
        }

        public static
            (double welch_t, double degrees_of_freedom)
                                        CalculateAsync
                                        (
                                            IEnumerable<uint> x, 
                                            IEnumerable<uint> y
                                        )
        {
            return x.WelchtStatistic(y);
        }

        public static
            (double welch_t, double degrees_of_freedom)
                                        CalculateAsync
                                        (
                                            IEnumerable<long> x, 
                                            IEnumerable<long> y
                                        )
        {
            return x.WelchtStatistic(y);
        }

        public static
            (double welch_t, double degrees_of_freedom)
                                        CalculateAsync
                                        (
                                            IEnumerable<ulong> x, 
                                            IEnumerable<ulong> y
                                        )
        {
            return x.WelchtStatistic(y);
        }

        public static
            (double welch_t, double degrees_of_freedom)
                                        CalculateAsync
                                        (
                                            IEnumerable<float> x, 
                                            IEnumerable<float> y
                                        )
        {
            return x.WelchtStatistic(y);
        }

        public static
            (double welch_t, double degrees_of_freedom)
                                        CalculateAsync
                                        (
                                            IEnumerable<double> x, 
                                            IEnumerable<double> y
                                        )
        {
            return x.WelchtStatistic(y);
        }

        public static
            (decimal welch_t, decimal degrees_of_freedom)
                                        CalculateAsync
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
