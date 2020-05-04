using System;
using System.Collections.Generic;
using System.Linq;

using Core.Math.Statistics.Descriptive.Sequential;

namespace Core.Math.Statistics.Descriptive.Sequential
{
    /// <summary>
    /// Correlation
    /// </summary>
    /// <see href="https://en.wikipedia.org/wiki/Correlation_and_dependence"/> 
    /// <see href="http://www.mathsisfun.com/data/correlation.html"/>
    public static partial class Correlation
    {
        //==============================================================================================================
        public static double Calculate
                                    (
                                        Memory<byte> x, 
                                        Memory<byte> y
                                    )
        {
            return x.Correlation(y);
        }

        public static double Calculate
                                    (
                                        Memory<short> x, 
                                        Memory<short> y
                                    )
        {
            return x.Correlation(y);
        }

        public static double Calculate
                                    (
                                        Memory<ushort> x, 
                                        Memory<ushort> y
                                    )
        {
            return x.Correlation(y);
        }

        public static double Calculate
                                    (
                                        Memory<int> x, 
                                        Memory<int> y
                                    )
        {
            return x.Correlation(y);
        }

        public static double Calculate
                                    (
                                        Memory<uint> x, 
                                        Memory<uint> y
                                    )
        {
            return x.Correlation(y);
        }

        public static double Calculate
                                    (
                                        Memory<long> x, 
                                        Memory<long> y
                                    )
        {
            return x.Correlation(y);
        }

        public static double Calculate
                                    (
                                        Memory<ulong> x, 
                                        Memory<ulong> y
                                    )
        {
            return x.Correlation(y);
        }

        public static double Calculate
                                    (
                                        Memory<float> x, 
                                        Memory<float> y
                                    )
        {
            return x.Correlation(y);
        }

        public static double Calculate
                                    (
                                        Memory<double> x, 
                                        Memory<double> y
                                    )
        {
            return x.Correlation(y);
        }

        public static decimal Calculate
                                    (
                                        Memory<decimal> x, 
                                        Memory<decimal> y
                                    )
        {
            return x.Correlation(y);
        }
        //--------------------------------------------------------------------------------------------------------------
        public static double CalculateOptimized
                                    (
                                        Memory<short> x, 
                                        Memory<short> y
                                    )
        {
            return x.CorrelationOptimized(y);
        }

        public static double CalculateOptimized
                                    (
                                        Memory<ushort> x, 
                                        Memory<ushort> y
                                    )
        {
            return x.CorrelationOptimized(y);
        }

        public static double CalculateOptimized
                                    (
                                        Memory<int> x, 
                                        Memory<int> y
                                    )
        {
            return x.CorrelationOptimized(y);
        }

        public static double CalculateOptimized
                                    (
                                        Memory<uint> x, 
                                        Memory<uint> y
                                    )
        {
            return x.CorrelationOptimized(y);
        }

        public static double CalculateOptimized
                                    (
                                        Memory<long> x, 
                                        Memory<long> y
                                    )
        {
            return x.CorrelationOptimized(y);
        }

        public static double CalculateOptimized
                                    (
                                        Memory<ulong> x, 
                                        Memory<ulong> y
                                    )
        {
            return x.CorrelationOptimized(y);
        }

        public static double CalculateOptimized
                                    (
                                        Memory<float> x, 
                                        Memory<float> y
                                    )
        {
            return x.CorrelationOptimized(y);
        }

        public static double CalculateOptimized
                                    (
                                        Memory<double> x, 
                                        Memory<double> y
                                    )
        {
            return x.CorrelationOptimized(y);
        }

        public static decimal CalculateOptimized
                                    (
                                        Memory<decimal> x, 
                                        Memory<decimal> y
                                    )
        {
            return x.CorrelationOptimized(y);
        }
        //==============================================================================================================

    }
}
