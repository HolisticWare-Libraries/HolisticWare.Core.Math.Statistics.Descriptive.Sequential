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
    public static partial class IEnumerableExtensionsMeanArithmetic
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
                                        this IEnumerable<byte> x
                                    )
        {
            ReadOnlySpan<byte> x_new = x.ToArray<byte>().AsSpan<byte>();

            double sum = 0.0;
            int n = x_new.Length;

            for (int i = 0; i < n; i++)
            {
                sum += x_new[i]; 
            }

            return sum / n;
        }

        #if METHODIMPL_OPTIONS_AGRESSIVE_INLINING
        [MethodImpl(MethodImplOptions.AggressiveInlining)]  
        #endif
        public static double MeanArithmetic
                                    (
                                        this IEnumerable<ushort> x
                                    )
        {
            ReadOnlySpan<ushort> x_new = x.ToArray<ushort>().AsSpan<ushort>();

            double sum = 0.0;
            int n = x_new.Length;

            for (int i = 0; i < n; i++)
            {
                sum += x_new[i];
            }

            return sum / n;
        }

        #if METHODIMPL_OPTIONS_AGRESSIVE_INLINING
        [MethodImpl(MethodImplOptions.AggressiveInlining)]  
        #endif
        public static double MeanArithmetic
                                    (
                                        this IEnumerable<short> x
                                    )
        {
            ReadOnlySpan<short> x_new = x.ToArray<short>().AsSpan<short>();

            double sum = 0.0;
            int n = x_new.Length;

            for (int i = 0; i < n; i++)
            {
                sum += x_new[i];
            }

            return sum / n;
        }

        #if METHODIMPL_OPTIONS_AGRESSIVE_INLINING
        [MethodImpl(MethodImplOptions.AggressiveInlining)]  
        #endif
        public static double MeanArithmetic
                                    (
                                        this IEnumerable<int> x
                                    )
        {
            ReadOnlySpan<int> x_new = x.ToArray<int>().AsSpan<int>();

            double sum = 0.0;
            int n = x_new.Length;

            for (int i = 0; i < n; i++)
            {
                sum += x_new[i];
            }

            return sum / n;
        }

        #if METHODIMPL_OPTIONS_AGRESSIVE_INLINING
        [MethodImpl(MethodImplOptions.AggressiveInlining)]  
        #endif
        public static double MeanArithmetic
                                    (
                                        this IEnumerable<uint> x
                                    )        
        {
            ReadOnlySpan<uint> x_new = x.ToArray<uint>().AsSpan<uint>();

            double sum = 0.0;
            int n = x_new.Length;

            for (int i = 0; i < n; i++)
            {
                sum += x_new[i];
            }

            return sum / n;
        }

        #if METHODIMPL_OPTIONS_AGRESSIVE_INLINING
        [MethodImpl(MethodImplOptions.AggressiveInlining)]  
        #endif
        public static double MeanArithmetic
                                    (
                                        this IEnumerable<long> x
                                    )
        {
            ReadOnlySpan<long> x_new = x.ToArray<long>().AsSpan<long>();

            double sum = 0.0;
            int n = x_new.Length;

            for (int i = 0; i < n; i++)
            {
                sum += x_new[i];
            }

            return sum / n;
        }

        #if METHODIMPL_OPTIONS_AGRESSIVE_INLINING
        [MethodImpl(MethodImplOptions.AggressiveInlining)]  
        #endif
        public static double MeanArithmetic
                                    (
                                        this IEnumerable<ulong> x
                                    )
        {
            ReadOnlySpan<ulong> x_new = x.ToArray<ulong>().AsSpan<ulong>();

            double sum = 0.0;
            int n = x_new.Length;

            for (int i = 0; i < n; i++)
            {
                sum += x_new[i];
            }

            return sum / n;
        }

        #if METHODIMPL_OPTIONS_AGRESSIVE_INLINING
        [MethodImpl(MethodImplOptions.AggressiveInlining)]  
        #endif
        public static double MeanArithmetic
                                    (
                                        this IEnumerable<float> x
                                    )
        {
            ReadOnlySpan<float> x_new = x.ToArray<float>().AsSpan<float>();

            double sum = 0.0;
            int n = x_new.Length;

            for (int i = 0; i < n; i++)
            {
                sum += x_new[i];
            }

            return sum / n;
        }
         
        #if METHODIMPL_OPTIONS_AGRESSIVE_INLINING
        [MethodImpl(MethodImplOptions.AggressiveInlining)]  
        #endif
        public static double MeanArithmetic
                                    (
                                        this IEnumerable<double> x
                                    )
        {
            ReadOnlySpan<double> x_new = x.ToArray<double>().AsSpan<double>();

            double sum = 0.0;
            int n = x_new.Length;

            for (int i = 0; i < n; i++)
            {
                sum += x_new[i];
            }

            return sum / n;
        }

        #if METHODIMPL_OPTIONS_AGRESSIVE_INLINING
        [MethodImpl(MethodImplOptions.AggressiveInlining)]  
        #endif
        public static decimal MeanArithmetic
                                    (
                                        this IEnumerable<decimal> x
                                    )
        {
            ReadOnlySpan<decimal> x_new = x.ToArray<decimal>().AsSpan<decimal>();

            decimal sum = 0.0M;
            int n = x_new.Length;

            for (int i = 0; i < n; i++)
            {
                sum += x_new[i];
            }

            return sum / n;
        }
        //==============================================================================================================

    }
}
