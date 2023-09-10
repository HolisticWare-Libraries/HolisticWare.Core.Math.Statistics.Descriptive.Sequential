using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

using Core.Math.Statistics.Descriptive;

namespace Core.Math.Statistics.Descriptive
{
    /// <summary>
    /// Mean (Average) Arithmetic
    /// </summary>
    /// <see href="https://en.wikipedia.org/wiki/Average"/>
    public static partial class
                                        IEnumerableExtensionsMeanArithmetic
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
        /// double mean = (new byte[] { 1, 4, 6, 7, 9 }).MeanArithmeticAsync();
        /// </example>
        #if METHODIMPL_OPTIONS_AGRESSIVE_INLINING
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        #endif
        public static
            Task<double>
                                        MeanArithmeticAsync
                                        (
                                            this IEnumerable<byte> x
                                        )
        {
            TaskCompletionSource<double> tcs;
            tcs = new TaskCompletionSource<double>();
            Task.Run
                    (
                        () =>
                        {
                            double result = x.MeanArithmetic();
                            tcs.SetResult(result);
                        }
                    );

            return tcs.Task;
        }

        #if METHODIMPL_OPTIONS_AGRESSIVE_INLINING
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        #endif
        public static
            Task<double>
                                        MeanArithmeticAsync
                                        (
                                            this IEnumerable<ushort> x
                                        )
        {
            TaskCompletionSource<double> tcs;
            tcs = new TaskCompletionSource<double>();
            Task.Run
                    (
                        () =>
                        {
                            double result = x.MeanArithmetic();
                            tcs.SetResult(result);
                        }
                    );

            return tcs.Task;
        }

        #if METHODIMPL_OPTIONS_AGRESSIVE_INLINING
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        #endif
        public static
            Task<double>
                                        MeanArithmeticAsync
                                        (
                                            this IEnumerable<short> x
                                        )
        {
            TaskCompletionSource<double> tcs;
            tcs = new TaskCompletionSource<double>();
            Task.Run
                    (
                        () =>
                        {
                            double result = x.MeanArithmetic();
                            tcs.SetResult(result);
                        }
                    );

            return tcs.Task;
        }

        #if METHODIMPL_OPTIONS_AGRESSIVE_INLINING
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        #endif
        public static
            Task<double>
                                        MeanArithmeticAsync
                                        (
                                            this IEnumerable<int> x
                                        )
        {
            TaskCompletionSource<double> tcs;
            tcs = new TaskCompletionSource<double>();
            Task.Run
                    (
                        () =>
                        {
                            double result = x.MeanArithmetic();
                            tcs.SetResult(result);
                        }
                    );

            return tcs.Task;
        }

        #if METHODIMPL_OPTIONS_AGRESSIVE_INLINING
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        #endif
        public static
            Task<double>
                                        MeanArithmeticAsync
                                        (
                                            this IEnumerable<uint> x
                                        )
        {
            TaskCompletionSource<double> tcs;
            tcs = new TaskCompletionSource<double>();
            Task.Run
                    (
                        () =>
                        {
                            double result = x.MeanArithmetic();
                            tcs.SetResult(result);
                        }
                    );

            return tcs.Task;
        }

        #if METHODIMPL_OPTIONS_AGRESSIVE_INLINING
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        #endif
        public static
            Task<double>
                                        MeanArithmeticAsync
                                        (
                                            this IEnumerable<long> x
                                        )
        {
            TaskCompletionSource<double> tcs;
            tcs = new TaskCompletionSource<double>();
            Task.Run
                    (
                        () =>
                        {
                            double result = x.MeanArithmetic();
                            tcs.SetResult(result);
                        }
                    );

            return tcs.Task;
        }

        #if METHODIMPL_OPTIONS_AGRESSIVE_INLINING
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        #endif
        public static
            Task<double>
                                        MeanArithmeticAsync
                                        (
                                            this IEnumerable<ulong> x
                                        )
        {
            TaskCompletionSource<double> tcs;
            tcs = new TaskCompletionSource<double>();
            Task.Run
                    (
                        () =>
                        {
                            double result = x.MeanArithmetic();
                            tcs.SetResult(result);
                        }
                    );

            return tcs.Task;
        }

        #if METHODIMPL_OPTIONS_AGRESSIVE_INLINING
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        #endif
        public static
            Task<double>
                                        MeanArithmeticAsync
                                        (
                                            this IEnumerable<float> x
                                        )
        {
            TaskCompletionSource<double> tcs;
            tcs = new TaskCompletionSource<double>();
            Task.Run
                    (
                        () =>
                        {
                            double result = x.MeanArithmetic();
                            tcs.SetResult(result);
                        }
                    );

            return tcs.Task;
        }

        #if METHODIMPL_OPTIONS_AGRESSIVE_INLINING
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        #endif
        public static
            Task<double>
                                        MeanArithmeticAsync
                                        (
                                            this IEnumerable<double> x
                                        )
        {
            TaskCompletionSource<double> tcs;
            tcs = new TaskCompletionSource<double>();
            Task.Run
                    (
                        () =>
                        {
                            double result = x.MeanArithmetic();
                            tcs.SetResult(result);
                        }
                    );

            return tcs.Task;
        }

        #if METHODIMPL_OPTIONS_AGRESSIVE_INLINING
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        #endif
        public static
            Task<decimal>
                                        MeanArithmeticAsync
                                        (
                                            this IEnumerable<decimal> x
                                        )
        {
            TaskCompletionSource<decimal> tcs;
            tcs = new TaskCompletionSource<decimal>();
            Task.Run
                    (
                        () =>
                        {
                            decimal result = x.MeanArithmetic();
                            tcs.SetResult(result);
                        }
                    );

            return tcs.Task;
        }
        //==============================================================================================================
    }
}
