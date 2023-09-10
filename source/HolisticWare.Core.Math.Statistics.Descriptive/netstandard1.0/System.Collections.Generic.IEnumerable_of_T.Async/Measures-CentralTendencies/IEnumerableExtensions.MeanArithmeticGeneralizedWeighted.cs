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
    public static partial class IEnumerableExtensionsMeanArithmeticGeneralizedWeighted
    {
        //==============================================================================================================
        public static
            Task<double>
                                        MeanArithmeticGeneralizedWeightedAsync
                                        (
                                            this IEnumerable<byte> x,
                                            IEnumerable<double> w,
                                            double power
                                        )
        {
            TaskCompletionSource<double> tcs;
            tcs = new TaskCompletionSource<double>();
            Task.Run
                    (
                        () =>
                        {
                            double result = x.MeanArithmeticGeneralizedWeighted
                                                                        (
                                                                            w,
                                                                            power
                                                                        );
                            tcs.SetResult(result);
                        }
                    );

            return tcs.Task;
        }

        public static
            Task<double>
                                        MeanArithmeticGeneralizedWeightedAsync
                                        (
                                            this IEnumerable<short> x,
                                            IEnumerable<double> w,
                                            double power
                                        )
        {
            TaskCompletionSource<double> tcs;
            tcs = new TaskCompletionSource<double>();
            Task.Run
                    (
                        () =>
                        {
                            double result = x.MeanArithmeticGeneralizedWeighted
                                                                        (
                                                                            w,
                                                                            power
                                                                        );
                            tcs.SetResult(result);
                        }
                    );

            return tcs.Task;
        }

        public static
            Task<double>
                                        MeanArithmeticGeneralizedWeightedAsync
                                        (
                                            this IEnumerable<ushort> x,
                                            IEnumerable<double> w,
                                            double power
                                        )
        {
            TaskCompletionSource<double> tcs;
            tcs = new TaskCompletionSource<double>();
            Task.Run
                    (
                        () =>
                        {
                            double result = x.MeanArithmeticGeneralizedWeighted
                                                                        (
                                                                            w,
                                                                            power
                                                                        );
                            tcs.SetResult(result);
                        }
                    );

            return tcs.Task;
        }

        public static
            Task<double>
                                        MeanArithmeticGeneralizedWeightedAsync
                                        (
                                            this IEnumerable<int> x,
                                            IEnumerable<double> w,
                                            double power
                                        )
        {
            TaskCompletionSource<double> tcs;
            tcs = new TaskCompletionSource<double>();
            Task.Run
                    (
                        () =>
                        {
                            double result = x.MeanArithmeticGeneralizedWeighted
                                                                        (
                                                                            w,
                                                                            power
                                                                        );
                            tcs.SetResult(result);
                        }
                    );

            return tcs.Task;
        }

        public static
            Task<double>
                                        MeanArithmeticGeneralizedWeightedAsync
                                        (
                                            this IEnumerable<uint> x,
                                            IEnumerable<double> w,
                                            double power
                                        )
        {
            TaskCompletionSource<double> tcs;
            tcs = new TaskCompletionSource<double>();
            Task.Run
                    (
                        () =>
                        {
                            double result = x.MeanArithmeticGeneralizedWeighted
                                                                        (
                                                                            w,
                                                                            power
                                                                        );
                            tcs.SetResult(result);
                        }
                    );

            return tcs.Task;
        }

        public static
            Task<double>
                                        MeanArithmeticGeneralizedWeightedAsync
                                        (
                                            this IEnumerable<long> x,
                                            IEnumerable<double> w,
                                            double power
                                        )
        {
            TaskCompletionSource<double> tcs;
            tcs = new TaskCompletionSource<double>();
            Task.Run
                    (
                        () =>
                        {
                            double result = x.MeanArithmeticGeneralizedWeighted
                                                                        (
                                                                            w,
                                                                            power
                                                                        );
                            tcs.SetResult(result);
                        }
                    );

            return tcs.Task;
        }

        public static
            Task<double>
                                        MeanArithmeticGeneralizedWeightedAsync
                                        (
                                            this IEnumerable<ulong> x,
                                            IEnumerable<double> w,
                                            double power
                                        )
        {
            TaskCompletionSource<double> tcs;
            tcs = new TaskCompletionSource<double>();
            Task.Run
                    (
                        () =>
                        {
                            double result = x.MeanArithmeticGeneralizedWeighted
                                                                        (
                                                                            w,
                                                                            power
                                                                        );
                            tcs.SetResult(result);
                        }
                    );

            return tcs.Task;
        }

        public static
            Task<double>
                                        MeanArithmeticGeneralizedWeightedAsync
                                        (
                                            this IEnumerable<float> x,
                                            IEnumerable<double> w,
                                            double power
                                        )
        {
            TaskCompletionSource<double> tcs;
            tcs = new TaskCompletionSource<double>();
            Task.Run
                    (
                        () =>
                        {
                            double result = x.MeanArithmeticGeneralizedWeighted
                                                                        (
                                                                            w,
                                                                            power
                                                                        );
                            tcs.SetResult(result);
                        }
                    );

            return tcs.Task;
        }

        public static
            Task<double>
                                        MeanArithmeticGeneralizedWeightedAsync
                                        (
                                            this IEnumerable<double> x,
                                            IEnumerable<double> w,
                                            double power
                                        )
        {
            TaskCompletionSource<double> tcs;
            tcs = new TaskCompletionSource<double>();
            Task.Run
                    (
                        () =>
                        {
                            double result = x.MeanArithmeticGeneralizedWeighted
                                                                        (
                                                                            w,
                                                                            power
                                                                        );
                            tcs.SetResult(result);
                        }
                    );

            return tcs.Task;
        }

        public static
            Task<decimal>
                                        MeanArithmeticGeneralizedWeightedAsync
                                        (
                                            this IEnumerable<decimal> x,
                                            IEnumerable<double> w,
                                            double power
                                        )
        {
            TaskCompletionSource<decimal> tcs;
            tcs = new TaskCompletionSource<decimal>();
            Task.Run
                    (
                        () =>
                        {
                            decimal result = x.MeanArithmeticGeneralizedWeighted
                                                                        (
                                                                            w,
                                                                            power
                                                                        );
                            tcs.SetResult(result);
                        }
                    );

            return tcs.Task;
        }

        //==============================================================================================================

    }
}
