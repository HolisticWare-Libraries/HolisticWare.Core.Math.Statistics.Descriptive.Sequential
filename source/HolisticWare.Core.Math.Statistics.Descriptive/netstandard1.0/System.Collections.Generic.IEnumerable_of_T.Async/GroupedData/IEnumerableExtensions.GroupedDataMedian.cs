using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Math.Statistics.Descriptive
{
    /// <summary>
    /// 
    /// </summary>
    public static partial class
                                        IEnumerableExtensionsGroupedDataMedian
    {
        //==============================================================================================================
        public static
            Task<double>
                                        GroupedDataMedianAsync
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
                            double result = x.GroupedDataMedian();
                            tcs.SetResult(result);
                        }
                    );

            return tcs.Task;
        }

        public static
            Task<double>
                                        GroupedDataMedianAsync
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
                            double result = x.GroupedDataMedian();
                            tcs.SetResult(result);
                        }
                    );

            return tcs.Task;
        }

        public static
            Task<double>
                                        GroupedDataMedianAsync
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
                            double result = x.GroupedDataMedian();
                            tcs.SetResult(result);
                        }
                    );

            return tcs.Task;
        }

        public static
            Task<double>
                                        GroupedDataMedianAsync
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
                            double result = x.GroupedDataMedian();
                            tcs.SetResult(result);
                        }
                    );

            return tcs.Task;
        }

        public static
            Task<double>
                                        GroupedDataMedianAsync
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
                            double result = x.GroupedDataMedian();
                            tcs.SetResult(result);
                        }
                    );

            return tcs.Task;
        }

        public static
            Task<double>
                                        GroupedDataMedianAsync
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
                            double result = x.GroupedDataMedian();
                            tcs.SetResult(result);
                        }
                    );

            return tcs.Task;
        }

        public static
            Task<double>
                                        GroupedDataMedianAsync
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
                            double result = x.GroupedDataMedian();
                            tcs.SetResult(result);
                        }
                    );

            return tcs.Task;
        }

        public static
            Task<double>
                                        GroupedDataMedianAsync
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
                            double result = x.GroupedDataMedian();
                            tcs.SetResult(result);
                        }
                    );

            return tcs.Task;
        }

        public static
            Task<double>
                                        GroupedDataMedianAsync
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
                            double result = x.GroupedDataMedian();
                            tcs.SetResult(result);
                        }
                    );

            return tcs.Task;
        }

        public static
            Task<decimal>
                                        GroupedDataMedianAsync
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
                            decimal result = x.GroupedDataMedian();
                            tcs.SetResult(result);
                        }
                    );

            return tcs.Task;
        }
        //==============================================================================================================

    }
}
