using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Core.Math.Statistics.Descriptive;

namespace Core.Math.Statistics.Descriptive
{
    /// <summary>
    /// Mean (Average) Generalized
    /// </summary>
    /// <see href="https://en.wikipedia.org/wiki/Average"/>
    /// <see href="https://en.wikipedia.org/wiki/Generalized_mean"/>
    public static partial class
                                        IEnumerableExtensionsMeanGeneralized
    {
        //==============================================================================================================
        public static 
            Task<double> 
                                        MeanGeneralizedAsync
                                        (
                                            this IEnumerable<byte> x,
                                            double power
                                        )
        {
            TaskCompletionSource<double> tcs;
            tcs = new TaskCompletionSource<double>();
            Task.Run
                    (
                        () =>
                        {
                            double result = x.MeanGeneralized(power);
                            tcs.SetResult(result);
                        }
                    );

            return tcs.Task;
        }

        public static 
            Task<double> 
                                        MeanGeneralizedAsync
                                        (
                                            this IEnumerable<short> x,
                                            double power
                                        )
        {
            TaskCompletionSource<double> tcs;
            tcs = new TaskCompletionSource<double>();
            Task.Run
                    (
                        () =>
                        {
                            double result = x.MeanGeneralized(power);
                            tcs.SetResult(result);
                        }
                    );

            return tcs.Task;
        }

        public static 
            Task<double> 
                                        MeanGeneralizedAsync
                                        (
                                            this IEnumerable<ushort> x,
                                            double power
                                        )
        {
            TaskCompletionSource<double> tcs;
            tcs = new TaskCompletionSource<double>();
            Task.Run
                    (
                        () =>
                        {
                            double result = x.MeanGeneralized(power);
                            tcs.SetResult(result);
                        }
                    );

            return tcs.Task;
        }

        public static 
            Task<double> 
                                        MeanGeneralizedAsync
                                        (
                                            this IEnumerable<int> x,
                                            double power
                                        )
        {
            TaskCompletionSource<double> tcs;
            tcs = new TaskCompletionSource<double>();
            Task.Run
                    (
                        () =>
                        {
                            double result = x.MeanGeneralized(power);
                            tcs.SetResult(result);
                        }
                    );

            return tcs.Task;
        }

        public static 
            Task<double> 
                                        MeanGeneralizedAsync
                                        (
                                            this IEnumerable<uint> x,
                                            double power
                                        )
        {
            TaskCompletionSource<double> tcs;
            tcs = new TaskCompletionSource<double>();
            Task.Run
                    (
                        () =>
                        {
                            double result = x.MeanGeneralized(power);
                            tcs.SetResult(result);
                        }
                    );

            return tcs.Task;
        }

        public static 
            Task<double> 
                                        MeanGeneralizedAsync
                                        (
                                            this IEnumerable<long> x,
                                            double power
                                        )
        {
            TaskCompletionSource<double> tcs;
            tcs = new TaskCompletionSource<double>();
            Task.Run
                    (
                        () =>
                        {
                            double result = x.MeanGeneralized(power);
                            tcs.SetResult(result);
                        }
                    );

            return tcs.Task;
        }

        public static 
            Task<double> 
                                        MeanGeneralizedAsync
                                        (
                                            this IEnumerable<ulong> x,
                                            double power
                                        )
        {
            TaskCompletionSource<double> tcs;
            tcs = new TaskCompletionSource<double>();
            Task.Run
                    (
                        () =>
                        {
                            double result = x.MeanGeneralized(power);
                            tcs.SetResult(result);
                        }
                    );

            return tcs.Task;
        }

        public static 
            Task<double> 
                                        MeanGeneralizedAsync
                                        (
                                            this IEnumerable<float> x,
                                            double power
                                        )
        {
            TaskCompletionSource<double> tcs;
            tcs = new TaskCompletionSource<double>();
            Task.Run
                    (
                        () =>
                        {
                            double result = x.MeanGeneralized(power);
                            tcs.SetResult(result);
                        }
                    );

            return tcs.Task;
        }

        public static 
            Task<double> 
                                        MeanGeneralizedAsync
                                        (
                                            this IEnumerable<double> x,
                                            double power
                                        )
        {
            TaskCompletionSource<double> tcs;
            tcs = new TaskCompletionSource<double>();
            Task.Run
                    (
                        () =>
                        {
                            double result = x.MeanGeneralized(power);
                            tcs.SetResult(result);
                        }
                    );

            return tcs.Task;
        }

        public static 
            Task<decimal> 
             
                                        MeanGeneralizedAsync
                                        (
                                            this IEnumerable<decimal> x,
                                            double power
                                        )
        {
            TaskCompletionSource<decimal> tcs;
            tcs = new TaskCompletionSource<decimal>();
            Task.Run
                    (
                        () =>
                        {
                            decimal result = x.MeanGeneralized(power);
                            tcs.SetResult(result);
                        }
                    );

            return tcs.Task;
        }

        //==============================================================================================================

    }
}
