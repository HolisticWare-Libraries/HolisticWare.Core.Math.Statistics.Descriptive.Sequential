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
    public static partial class Correlation
    {
        //==============================================================================================================
        public static double CalculateAsync
                                    (
                                        IEnumerable<byte> x, 
                                        IEnumerable<byte> y
                                    )
        {
            return x.Correlation(y);
        }

        public static double CalculateAsync
                                    (
                                        IEnumerable<short> x, 
                                        IEnumerable<short> y
                                    )
        {
            return x.Correlation(y);
        }

        public static double CalculateAsync
                                    (
                                        IEnumerable<ushort> x, 
                                        IEnumerable<ushort> y
                                    )
        {
            return x.Correlation(y);
        }

        public static double CalculateAsync
                                    (
                                        IEnumerable<int> x, 
                                        IEnumerable<int> y
                                    )
        {
            return x.Correlation(y);
        }

        public static double CalculateAsync
                                    (
                                        IEnumerable<uint> x, 
                                        IEnumerable<uint> y
                                    )
        {
            return x.Correlation(y);
        }

        public static double CalculateAsync
                                    (
                                        IEnumerable<long> x, 
                                        IEnumerable<long> y
                                    )
        {
            return x.Correlation(y);
        }

        public static double CalculateAsync
                                    (
                                        IEnumerable<ulong> x, 
                                        IEnumerable<ulong> y
                                    )
        {
            return x.Correlation(y);
        }

        public static double CalculateAsync
                                    (
                                        IEnumerable<float> x, 
                                        IEnumerable<float> y
                                    )
        {
            return x.Correlation(y);
        }

        public static double CalculateAsync
                                    (
                                        IEnumerable<double> x, 
                                        IEnumerable<double> y
                                    )
        {
            return x.Correlation(y);
        }

        public static decimal CalculateAsync
                                    (
                                        IEnumerable<decimal> x, 
                                        IEnumerable<decimal> y
                                    )
        {
            return x.Correlation(y);
        }
        //--------------------------------------------------------------------------------------------------------------
        public static double CalculateAsyncOptimized
                                    (
                                        IEnumerable<short> x, 
                                        IEnumerable<short> y
                                    )
        {
            return x.CorrelationOptimized(y);
        }

        public static double CalculateAsyncOptimized
                                    (
                                        IEnumerable<ushort> x, 
                                        IEnumerable<ushort> y
                                    )
        {
            return x.CorrelationOptimized(y);
        }

        public static double CalculateAsyncOptimized
                                    (
                                        IEnumerable<int> x, 
                                        IEnumerable<int> y
                                    )
        {
            return x.CorrelationOptimized(y);
        }

        public static double CalculateAsyncOptimized
                                    (
                                        IEnumerable<uint> x, 
                                        IEnumerable<uint> y
                                    )
        {
            return x.CorrelationOptimized(y);
        }

        public static double CalculateAsyncOptimized
                                    (
                                        IEnumerable<long> x, 
                                        IEnumerable<long> y
                                    )
        {
            return x.CorrelationOptimized(y);
        }

        public static double CalculateAsyncOptimized
                                    (
                                        IEnumerable<ulong> x, 
                                        IEnumerable<ulong> y
                                    )
        {
            return x.CorrelationOptimized(y);
        }

        public static double CalculateAsyncOptimized
                                    (
                                        IEnumerable<float> x, 
                                        IEnumerable<float> y
                                    )
        {
            return x.CorrelationOptimized(y);
        }

        public static double CalculateAsyncOptimized
                                    (
                                        IEnumerable<double> x, 
                                        IEnumerable<double> y
                                    )
        {
            return x.CorrelationOptimized(y);
        }

        public static decimal CalculateAsyncOptimized
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
