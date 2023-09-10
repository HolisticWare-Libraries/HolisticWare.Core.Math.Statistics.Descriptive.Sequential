using System;
using System.Collections.Generic;
using System.Linq;

using Core.Math.Statistics.Descriptive;

namespace Core.Math.Statistics.Descriptive
{
    /// <summary>
    /// Correlation
    /// </summary>
    /// <see href="https://en.wikipedia.org/wiki/Correlation_and_dependence"/> 
    /// <see href="http://www.mathsisfun.com/data/correlation.html"/>
    public static partial class
                                        Correlation
    {
        //==============================================================================================================
        public static
            double
                                        Calculate
                                        (
                                            IEnumerable<byte> x, 
                                            IEnumerable<byte> y
                                        )
        {
            return x.Correlation(y);
        }

        public static
            double
                                        Calculate
                                        (
                                            IEnumerable<short> x, 
                                            IEnumerable<short> y
                                        )
        {
            return x.Correlation(y);
        }

        public static
            double
                                        Calculate
                                        (
                                            IEnumerable<ushort> x, 
                                            IEnumerable<ushort> y
                                        )
        {
            return x.Correlation(y);
        }

        public static
            double
                                        Calculate
                                        (
                                            IEnumerable<int> x, 
                                            IEnumerable<int> y
                                        )
        {
            return x.Correlation(y);
        }

        public static
            double
                                        Calculate
                                        (
                                            IEnumerable<uint> x, 
                                            IEnumerable<uint> y
                                        )
        {
            return x.Correlation(y);
        }

        public static
            double
                                        Calculate
                                        (
                                            IEnumerable<long> x, 
                                            IEnumerable<long> y
                                        )
        {
            return x.Correlation(y);
        }

        public static
            double
                                        Calculate
                                        (
                                            IEnumerable<ulong> x, 
                                            IEnumerable<ulong> y
                                        )
        {
            return x.Correlation(y);
        }

        public static
            double
                                        Calculate
                                        (
                                            IEnumerable<float> x, 
                                            IEnumerable<float> y
                                        )
        {
            return x.Correlation(y);
        }

        public static
            double
                                        Calculate
                                        (
                                            IEnumerable<double> x, 
                                            IEnumerable<double> y
                                        )
        {
            return x.Correlation(y);
        }

        public static
            decimal
                                        Calculate
                                        (
                                            IEnumerable<decimal> x, 
                                            IEnumerable<decimal> y
                                        )
        {
            return x.Correlation(y);
        }
        //--------------------------------------------------------------------------------------------------------------
        public static
            double
                                        CalculateOptimized
                                        (
                                            IEnumerable<short> x, 
                                            IEnumerable<short> y
                                        )
        {
            return x.CorrelationOptimized(y);
        }

        public static
            double
                                        CalculateOptimized
                                        (
                                            IEnumerable<ushort> x, 
                                            IEnumerable<ushort> y
                                        )
        {
            return x.CorrelationOptimized(y);
        }

        public static
            double
                                        CalculateOptimized
                                        (
                                            IEnumerable<int> x, 
                                            IEnumerable<int> y
                                        )
        {
            return x.CorrelationOptimized(y);
        }

        public static
            double
                                        CalculateOptimized
                                        (
                                            IEnumerable<uint> x, 
                                            IEnumerable<uint> y
                                        )
        {
            return x.CorrelationOptimized(y);
        }

        public static
            double
                                        CalculateOptimized
                                        (
                                            IEnumerable<long> x, 
                                            IEnumerable<long> y
                                        )
        {
            return x.CorrelationOptimized(y);
        }

        public static
            double
                                        CalculateOptimized
                                        (
                                            IEnumerable<ulong> x, 
                                            IEnumerable<ulong> y
                                        )
        {
            return x.CorrelationOptimized(y);
        }

        public static
            double
                                        CalculateOptimized
                                        (
                                            IEnumerable<float> x, 
                                            IEnumerable<float> y
                                        )
        {
            return x.CorrelationOptimized(y);
        }

        public static
            double
                                        CalculateOptimized
                                        (
                                            IEnumerable<double> x, 
                                            IEnumerable<double> y
                                        )
        {
            return x.CorrelationOptimized(y);
        }

        public static
            decimal
                                        CalculateOptimized
                                        (
                                            IEnumerable<decimal> x, 
                                            IEnumerable<decimal> y
                                        )
        {
            return x.CorrelationOptimized(y);
        }
        //==============================================================================================================

    }
}
