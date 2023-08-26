using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Math.Statistics.Descriptive
{
    /// <summary>
    /// Correlation
    /// </summary>
    public static partial class IEnumerableExtensionsMeanArithmeticWeighted
    {
        //==============================================================================================================
        public static
            Task<double>
                                        MeanArithmeticWeightedAsync
                                        (
                                            this IEnumerable<byte> x,
                                            IEnumerable<double> w
                                        )
        {
            TaskCompletionSource<double> tcs;
            tcs = new TaskCompletionSource<double>();
            Task.Run
                    (
                        () =>
                        {
                            double result = x.MeanArithmeticWeighted(w);
                            tcs.SetResult(result);
                        }
                    );

            return tcs.Task;
        }

        public static
            Task<double>
                                        MeanArithmeticWeightedAsync
                                        (
                                            this IEnumerable<short> x,
                                            IEnumerable<double> w
                                        )
        {
            TaskCompletionSource<double> tcs;
            tcs = new TaskCompletionSource<double>();
            Task.Run
                    (
                        () =>
                        {
                            double result = x.MeanArithmeticWeighted(w);
                            tcs.SetResult(result);
                        }
                    );

            return tcs.Task;
        }

        public static
            Task<double>
                                        MeanArithmeticWeightedAsync
                                        (
                                            this IEnumerable<ushort> x,
                                            IEnumerable<double> w
                                        )
        {
            TaskCompletionSource<double> tcs;
            tcs = new TaskCompletionSource<double>();
            Task.Run
                    (
                        () =>
                        {
                            double result = x.MeanArithmeticWeighted(w);
                            tcs.SetResult(result);
                        }
                    );

            return tcs.Task;
        }

        public static
            Task<double>
                                        MeanArithmeticWeightedAsync
                                        (
                                            this IEnumerable<int> x,
                                            IEnumerable<double> w
                                        )
        {
            TaskCompletionSource<double> tcs;
            tcs = new TaskCompletionSource<double>();
            Task.Run
                    (
                        () =>
                        {
                            double result = x.MeanArithmeticWeighted(w);
                            tcs.SetResult(result);
                        }
                    );

            return tcs.Task;
        }

        public static
            Task<double>
                                        MeanArithmeticWeightedAsync
                                        (
                                            this IEnumerable<uint> x,
                                            IEnumerable<double> w
                                        )
        {
            TaskCompletionSource<double> tcs;
            tcs = new TaskCompletionSource<double>();
            Task.Run
                    (
                        () =>
                        {
                            double result = x.MeanArithmeticWeighted(w);
                            tcs.SetResult(result);
                        }
                    );

            return tcs.Task;
        }

        public static
            Task<double>
                                        MeanArithmeticWeightedAsync
                                        (
                                            this IEnumerable<long> x,
                                            IEnumerable<double> w
                                        )
        {
            TaskCompletionSource<double> tcs;
            tcs = new TaskCompletionSource<double>();
            Task.Run
                    (
                        () =>
                        {
                            double result = x.MeanArithmeticWeighted(w);
                            tcs.SetResult(result);
                        }
                    );

            return tcs.Task;
        }

        public static
            Task<double>
                                        MeanArithmeticWeightedAsync
                                        (
                                            this IEnumerable<ulong> x,
                                            IEnumerable<double> w
                                        )
        {
            TaskCompletionSource<double> tcs;
            tcs = new TaskCompletionSource<double>();
            Task.Run
                    (
                        () =>
                        {
                            double result = x.MeanArithmeticWeighted(w);
                            tcs.SetResult(result);
                        }
                    );

            return tcs.Task;
        }

        public static
            Task<double>
                                        MeanArithmeticWeightedAsync
                                        (
                                            this IEnumerable<float> x,
                                            IEnumerable<double> w
                                        )
        {
            TaskCompletionSource<double> tcs;
            tcs = new TaskCompletionSource<double>();
            Task.Run
                    (
                        () =>
                        {
                            double result = x.MeanArithmeticWeighted(w);
                            tcs.SetResult(result);
                        }
                    );

            return tcs.Task;
        }

        public static
            Task<double>
                                        MeanArithmeticWeightedAsync
                                        (
                                            this IEnumerable<double> x,
                                            IEnumerable<double> w
                                        )
        {
            TaskCompletionSource<double> tcs;
            tcs = new TaskCompletionSource<double>();
            Task.Run
                    (
                        () =>
                        {
                            double result = x.MeanArithmeticWeighted(w);
                            tcs.SetResult(result);
                        }
                    );

            return tcs.Task;
        }

        public static
            Task<decimal>
                                        MeanArithmeticWeightedAsync
                                        (
                                            this IEnumerable<decimal> x,
                                            IEnumerable<double> w
                                        )
        {
            TaskCompletionSource<decimal> tcs;
            tcs = new TaskCompletionSource<decimal>();
            Task.Run
                    (
                        () =>
                        {
                            decimal result = x.MeanArithmeticWeighted(w);
                            tcs.SetResult(result);
                        }
                    );

            return tcs.Task;
        }

        //==============================================================================================================

    }
}
