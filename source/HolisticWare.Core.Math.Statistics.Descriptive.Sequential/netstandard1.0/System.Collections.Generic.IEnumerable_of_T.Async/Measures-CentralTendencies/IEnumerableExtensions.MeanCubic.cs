using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Math.Statistics.Descriptive
{
    /// <summary>
    /// Mean (Average) Cubic
    /// </summary>
    /// <see href="https://en.wikipedia.org/wiki/Average"/>
    public static partial class
                                        IEnumerableExtensionsMeanCubic
    {
        //==============================================================================================================
        public static
            Task<double>

                                        MeanCubicAsync
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
                            double result = x.MeanCubic();
                            tcs.SetResult(result);
                        }
                    );

            return tcs.Task;
        }

        public static
            Task<double>
                                        MeanCubicAsync
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
                            double result = x.MeanCubic();
                            tcs.SetResult(result);
                        }
                    );

            return tcs.Task;
        }

        public static
            Task<double>
                                        MeanCubicAsync
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
                            double result = x.MeanCubic();
                            tcs.SetResult(result);
                        }
                    );

            return tcs.Task;
        }

        public static
            Task<double>
                                        MeanCubicAsync
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
                            double result = x.MeanCubic();
                            tcs.SetResult(result);
                        }
                    );

            return tcs.Task;
        }

        public static
            Task<double>
                                        MeanCubicAsync
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
                            double result = x.MeanCubic();
                            tcs.SetResult(result);
                        }
                    );

            return tcs.Task;
        }

        public static
            Task<double>
                                        MeanCubicAsync
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
                            double result = x.MeanCubic();
                            tcs.SetResult(result);
                        }
                    );

            return tcs.Task;
        }

        public static
            Task<double>
                                        MeanCubicAsync
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
                            double result = x.MeanCubic();
                            tcs.SetResult(result);
                        }
                    );

            return tcs.Task;
        }

        public static
            Task<double>
                                        MeanCubicAsync
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
                            double result = x.MeanCubic();
                            tcs.SetResult(result);
                        }
                    );

            return tcs.Task;
        }

        public static
            Task<double>
                                        MeanCubicAsync
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
                            double result = x.MeanCubic();
                            tcs.SetResult(result);
                        }
                    );

            return tcs.Task;
        }

        public static
            Task<decimal>
                                        MeanCubicAsync
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
                            decimal result = x.MeanCubic();
                            tcs.SetResult(result);
                        }
                    );

            return tcs.Task;
        }

        //==============================================================================================================

    }
}
