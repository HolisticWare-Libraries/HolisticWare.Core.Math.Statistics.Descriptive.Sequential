using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Core.Math.Statistics.Descriptive.Sequential;

namespace Core.Math.Statistics.Descriptive.Sequential
{
    /// <summary>
    /// Mean (Average) Arithmetic
    /// </summary>
    /// <see cref="https://en.wikipedia.org/wiki/Average"/>
    public static partial class ReadOnlySpanExtensionsMeanArithmetic
    {
        //==============================================================================================================
        /// <summary>
        /// Calculates Arithmetic Mean of the IEnumerable (Collection)
        /// </summary>
        /// <returns>
        /// Arithmetic Mean as double
        /// </returns>
        /// <param name="x">
        /// Data as IEnumerable (Collection)
        /// </param>
        /// <example>
        /// double mean = (new byte[] { 1, 4, 6, 7, 9 }).MeanArithmetic();
        /// </example>
        #if METHODIMPL_OPTIONS_AGRESSIVE_INLINING
        [MethodImpl(MethodImplOptions.AggressiveInlining)]  
        #endif
        public static double MeanArithmetic
                                    (
                                        this ReadOnlySpan<byte> x
                                    )
        {
            double sum = 0.0;
            int n = x.Length;

            for (int i = 0; i < n; i++)
            {
                sum += x[i]; 
            }

            return sum / n;
        }

        #if METHODIMPL_OPTIONS_AGRESSIVE_INLINING
        [MethodImpl(MethodImplOptions.AggressiveInlining)]  
        #endif
        public static double MeanArithmetic
                                    (
                                        this ReadOnlySpan<ushort> x
                                    )
        {
            double sum = 0.0;
            int n = x.Length;

            for (int i = 0; i < n; i++)
            {
                sum += x[i];
            }

            return sum / n;
        }

        #if METHODIMPL_OPTIONS_AGRESSIVE_INLINING
        [MethodImpl(MethodImplOptions.AggressiveInlining)]  
        #endif
        public static double MeanArithmetic
                                    (
                                        this ReadOnlySpan<short> x
                                    )
        {
            double sum = 0.0;
            int n = x.Length;

            for (int i = 0; i < n; i++)
            {
                sum += x[i];
            }

            return sum / n;
        }

        #if METHODIMPL_OPTIONS_AGRESSIVE_INLINING
        [MethodImpl(MethodImplOptions.AggressiveInlining)]  
        #endif
        public static double MeanArithmetic
                                    (
                                        this ReadOnlySpan<int> x
                                    )
        {
            double sum = 0.0;
            int n = x.Length;

            for (int i = 0; i < n; i++)
            {
                sum += x[i];
            }

            return sum / n;
        }

        #if METHODIMPL_OPTIONS_AGRESSIVE_INLINING
        [MethodImpl(MethodImplOptions.AggressiveInlining)]  
        #endif
        public static double MeanArithmetic
                                    (
                                        this ReadOnlySpan<uint> x
                                    )        
        {
            double sum = 0.0;
            int n = x.Length;

            for (int i = 0; i < n; i++)
            {
                sum += x[i];
            }

            return sum / n;
        }

        #if METHODIMPL_OPTIONS_AGRESSIVE_INLINING
        [MethodImpl(MethodImplOptions.AggressiveInlining)]  
        #endif
        public static double MeanArithmetic
                                    (
                                        this ReadOnlySpan<long> x
                                    )
        {
            double sum = 0.0;
            int n = x.Length;

            for (int i = 0; i < n; i++)
            {
                sum += x[i];
            }

            return sum / n;
        }

        #if METHODIMPL_OPTIONS_AGRESSIVE_INLINING
        [MethodImpl(MethodImplOptions.AggressiveInlining)]  
        #endif
        public static double MeanArithmetic
                                    (
                                        this ReadOnlySpan<ulong> x
                                    )
        {
            double sum = 0.0;
            int n = x.Length;

            for (int i = 0; i < n; i++)
            {
                sum += x[i];
            }

            return sum / n;
        }

        #if METHODIMPL_OPTIONS_AGRESSIVE_INLINING
        [MethodImpl(MethodImplOptions.AggressiveInlining)]  
        #endif
        public static double MeanArithmetic
                                    (
                                        this ReadOnlySpan<float> x
                                    )
        {
            double sum = 0.0;
            int n = x.Length;

            for (int i = 0; i < n; i++)
            {
                sum += x[i];
            }

            return sum / n;
        }
         
        #if METHODIMPL_OPTIONS_AGRESSIVE_INLINING
        [MethodImpl(MethodImplOptions.AggressiveInlining)]  
        #endif
        public static double MeanArithmetic
                                    (
                                        this ReadOnlySpan<double> x
                                    )
        {
            double sum = 0.0;
            int n = x.Length;

            for (int i = 0; i < n; i++)
            {
                sum += x[i];
            }

            return sum / n;
        }

        #if METHODIMPL_OPTIONS_AGRESSIVE_INLINING
        [MethodImpl(MethodImplOptions.AggressiveInlining)]  
        #endif
        public static decimal MeanArithmetic
                                    (
                                        this ReadOnlySpan<decimal> x
                                    )
        {
            decimal sum = 0.0M;
            int n = x.Length;

            for (int i = 0; i < n; i++)
            {
                sum += x[i];
            }

            return sum / n;
        }
        //==============================================================================================================

    }
}
