using System;
using System.Collections.Generic;
using System.Linq;

using Core.Math.Statistics;

namespace Core.Math.Statistics.Descriptive
{
    /// <summary>
    /// Correlation
    /// </summary>
    public static partial class Covariance
    {
        //==============================================================================================================
        public static double CalculateAsync
                                    (
                                        IEnumerable<byte> x, 
                                        IEnumerable<byte> y
                                    )
        {
            return x.Covariance(y);
        }

        public static double CalculateAsync
                                    (
                                        IEnumerable<short> x, 
                                        IEnumerable<short> y
                                    )
        {
            return x.Covariance(y);
        }

        public static double CalculateAsync
                                    (
                                        IEnumerable<ushort> x, 
                                        IEnumerable<ushort> y
                                    )
        {
            return x.Covariance(y);
        }

        public static double CalculateAsync
                                    (
                                        IEnumerable<int> x, 
                                        IEnumerable<int> y
                                    )
        {
            return x.Covariance(y);
        }

        public static double CalculateAsync
                                    (
                                        IEnumerable<uint> x, 
                                        IEnumerable<uint> y
                                    )
        {
            return x.Covariance(y);
        }

        public static double CalculateAsync
                                    (
                                        IEnumerable<long> x, 
                                        IEnumerable<long> y
                                    )
        {
            return x.Covariance(y);
        }

        public static double CalculateAsync
                                    (
                                        IEnumerable<ulong> x, 
                                        IEnumerable<ulong> y
                                    )
        {
            return x.Covariance(y);
        }

        public static double CalculateAsync
                                    (
                                        IEnumerable<float> x, 
                                        IEnumerable<float> y
                                    )
        {
            return x.Covariance(y);
        }

        public static double CalculateAsync
                                    (
                                        IEnumerable<double> x, 
                                        IEnumerable<double> y
                                    )
        {
            return x.Covariance(y);
        }

        public static decimal CalculateAsync
                                    (
                                        IEnumerable<decimal> x, 
                                        IEnumerable<decimal> y
                                    )
        {
            return x.Covariance(y);
        }
        //==============================================================================================================

    }
}
