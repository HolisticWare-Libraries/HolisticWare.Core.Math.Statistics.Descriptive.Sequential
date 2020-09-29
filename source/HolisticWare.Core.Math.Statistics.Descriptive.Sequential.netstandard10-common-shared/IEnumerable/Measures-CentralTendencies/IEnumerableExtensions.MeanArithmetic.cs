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
    /// <see href="https://en.wikipedia.org/wiki/Average"/>
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
            return x.Select(x_i => (int)x_i).Average();
        }

        #if METHODIMPL_OPTIONS_AGRESSIVE_INLINING
        [MethodImpl(MethodImplOptions.AggressiveInlining)]  
        #endif
        public static double MeanArithmetic
                                    (
                                        this IEnumerable<ushort> x
                                    )
        {
            return x.Select(x_i => (int)x_i).Average();
        }

        #if METHODIMPL_OPTIONS_AGRESSIVE_INLINING
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        #endif
        public static double MeanArithmetic
                                    (
                                        this IEnumerable<short> x
                                    )
        {
            return x.Select(x_i => (int)x_i).Average();
        }

        #if METHODIMPL_OPTIONS_AGRESSIVE_INLINING
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        #endif
        public static double MeanArithmetic
                                    (
                                        this IEnumerable<int> x
                                    )
        {
            return x.Average();
        }

        #if METHODIMPL_OPTIONS_AGRESSIVE_INLINING
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        #endif
        public static double MeanArithmetic
                                    (
                                        this IEnumerable<uint> x
                                    )        
        {
            return x.Select(x_i => (long)x_i).Average();
        }

        #if METHODIMPL_OPTIONS_AGRESSIVE_INLINING
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        #endif
        public static double MeanArithmetic
                                    (
                                        this IEnumerable<long> x
                                    )
        {
            return x.Average();
        }

        #if METHODIMPL_OPTIONS_AGRESSIVE_INLINING
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        #endif
        public static double MeanArithmetic
                                    (
                                        this IEnumerable<ulong> x
                                    )
        {
            return x.Select(x_i => (double)x_i).Average();
        }

        #if METHODIMPL_OPTIONS_AGRESSIVE_INLINING
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        #endif
        public static double MeanArithmetic
                                    (
                                        this IEnumerable<float> x
                                    )
        {
            return x.Average();
        }

        #if METHODIMPL_OPTIONS_AGRESSIVE_INLINING
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        #endif
        public static double MeanArithmetic
                                    (
                                        this IEnumerable<double> x
                                    )
        {
            return x.Average();
        }

        #if METHODIMPL_OPTIONS_AGRESSIVE_INLINING
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        #endif
        public static decimal MeanArithmetic
                                    (
                                        this IEnumerable<decimal> x
                                    )
        {
            return x.Average();
        }
        //==============================================================================================================
    }
}
