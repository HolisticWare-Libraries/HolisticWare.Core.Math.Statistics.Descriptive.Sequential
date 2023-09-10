using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Math.Statistics.Descriptive
{
    /// <summary>
    /// Mean (Average) Geometric
    /// </summary>
    /// <see href="https://en.wikipedia.org/wiki/Average"/>
    public static partial class
                                        IEnumerableExtensionsMeanGeometric
    {
        //==============================================================================================================
        public static 
            Task<double> 
                                        MeanGeometricAsync
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
                            double result = x.MeanGeometric();
                            tcs.SetResult(result);
                        }
                    );

            return tcs.Task;
        }

        public static 
            Task<double> 
                                        MeanGeometricAsync
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
                            double result = x.MeanGeometric();
                            tcs.SetResult(result);
                        }
                    );

            return tcs.Task;
        }

        public static 
            Task<double> 
                                        MeanGeometricAsync
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
                            double result = x.MeanGeometric();
                            tcs.SetResult(result);
                        }
                    );

            return tcs.Task;
        }

        public static 
            Task<double> 
                                        MeanGeometricAsync
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
                            double result = x.MeanGeometric();
                            tcs.SetResult(result);
                        }
                    );

            return tcs.Task;
        }

        public static 
            Task<double> 
                                        MeanGeometricAsync
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
                            double result = x.MeanGeometric();
                            tcs.SetResult(result);
                        }
                    );

            return tcs.Task;
        }

        public static 
            Task<double> 
                                        MeanGeometricAsync
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
                            double result = x.MeanGeometric();
                            tcs.SetResult(result);
                        }
                    );

            return tcs.Task;
        }

        public static 
            Task<double> 
                                        MeanGeometricAsync
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
                            double result = x.MeanGeometric();
                            tcs.SetResult(result);
                        }
                    );

            return tcs.Task;
        }

        public static 
            Task<double> 
                                        MeanGeometricAsync
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
                            double result = x.MeanGeometric();
                            tcs.SetResult(result);
                        }
                    );

            return tcs.Task;
        }

        public static 
            Task<double> 
                                        MeanGeometricAsync
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
                            double result = x.MeanGeometric();
                            tcs.SetResult(result);
                        }
                    );

            return tcs.Task;
        }

        public static 
            Task<decimal> 
                                        MeanGeometricAsyn
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
                            decimal result = x.MeanGeometric();
                            tcs.SetResult(result);
                        }
                    );

            return tcs.Task;
        }
        //==============================================================================================================

    }
}
