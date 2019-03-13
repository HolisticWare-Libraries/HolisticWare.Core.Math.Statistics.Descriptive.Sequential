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
    public static partial class MemoryExtensionsMeanArithmetic
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
                                        this Memory<byte> x
                                    )
        {
            double sum = 0.0;
            int n = x.Length;

            for (int i = 0; i < n; i++)
            {
                sum += x.Span[i]; 
            }

            return sum / n;
        }

        #if METHODIMPL_OPTIONS_AGRESSIVE_INLINING
        [MethodImpl(MethodImplOptions.AggressiveInlining)]  
        #endif
        public static double MeanArithmetic
                                    (
                                        this Memory<ushort> x
                                    )
        {
            double sum = 0.0;
            int n = x.Length;

            for (int i = 0; i < n; i++)
            {
                sum += x.Span[i];
            }

            return sum / n;
        }

        #if METHODIMPL_OPTIONS_AGRESSIVE_INLINING
        [MethodImpl(MethodImplOptions.AggressiveInlining)]  
        #endif
        public static double MeanArithmetic
                                    (
                                        this Memory<short> x
                                    )
        {
            double sum = 0.0;
            int n = x.Length;

            for (int i = 0; i < n; i++)
            {
                sum += x.Span[i];
            }

            return sum / n;
        }

        #if METHODIMPL_OPTIONS_AGRESSIVE_INLINING
        [MethodImpl(MethodImplOptions.AggressiveInlining)]  
        #endif
        public static double MeanArithmetic
                                    (
                                        this Memory<int> x
                                    )
        {
            double sum = 0.0;
            int n = x.Length;

            for (int i = 0; i < n; i++)
            {
                sum += x.Span[i];
            }

            return sum / n;
        }

        #if METHODIMPL_OPTIONS_AGRESSIVE_INLINING
        [MethodImpl(MethodImplOptions.AggressiveInlining)]  
        #endif
        public static double MeanArithmetic
                                    (
                                        this Memory<uint> x
                                    )        
        {
            double sum = 0.0;
            int n = x.Length;

            for (int i = 0; i < n; i++)
            {
                sum += x.Span[i];
            }

            return sum / n;
        }

        #if METHODIMPL_OPTIONS_AGRESSIVE_INLINING
        [MethodImpl(MethodImplOptions.AggressiveInlining)]  
        #endif
        public static double MeanArithmetic
                                    (
                                        this Memory<long> x
                                    )
        {
            double sum = 0.0;
            int n = x.Length;

            for (int i = 0; i < n; i++)
            {
                sum += x.Span[i];
            }

            return sum / n;
        }

        #if METHODIMPL_OPTIONS_AGRESSIVE_INLINING
        [MethodImpl(MethodImplOptions.AggressiveInlining)]  
        #endif
        public static double MeanArithmetic
                                    (
                                        this Memory<ulong> x
                                    )
        {
            double sum = 0.0;
            int n = x.Length;

            for (int i = 0; i < n; i++)
            {
                sum += x.Span[i];
            }

            return sum / n;
        }

        #if METHODIMPL_OPTIONS_AGRESSIVE_INLINING
        [MethodImpl(MethodImplOptions.AggressiveInlining)]  
        #endif
        public static double MeanArithmetic
                                    (
                                        this Memory<float> x
                                    )
        {
            double sum = 0.0;
            int n = x.Length;

            for (int i = 0; i < n; i++)
            {
                sum += x.Span[i];
            }

            return sum / n;
        }
         
        #if METHODIMPL_OPTIONS_AGRESSIVE_INLINING
        [MethodImpl(MethodImplOptions.AggressiveInlining)]  
        #endif
        public static double MeanArithmetic
                                    (
                                        this Memory<double> x
                                    )
        {
            double sum = 0.0;
            int n = x.Length;

            for (int i = 0; i < n; i++)
            {
                sum += x.Span[i];
            }

            return sum / n;
        }

        #if METHODIMPL_OPTIONS_AGRESSIVE_INLINING
        [MethodImpl(MethodImplOptions.AggressiveInlining)]  
        #endif
        public static decimal MeanArithmetic
                                    (
                                        this Memory<decimal> x
                                    )
        {
            decimal sum = 0.0M;
            int n = x.Length;

            for (int i = 0; i < n; i++)
            {
                sum += x.Span[i];
            }

            return sum / n;
        }
        //==============================================================================================================

    }
}
