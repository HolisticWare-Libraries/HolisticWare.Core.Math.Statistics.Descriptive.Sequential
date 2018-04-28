using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Core.Math.Statistics.Descriptive.Sequential
{
    public static partial class IEnumerableExtensionsMeanCubic
    {
        //==============================================================================================================
        public async static Task<double> MeanCubicAsync(this IEnumerable<byte> x)
        {
            double mean =
                await Task
                            .Run
                                (
                                    () => x.MeanCubic()
                                )
                            .ConfigureAwait(false);

            return mean;
        }

        public async static Task<double> MeanCubicAsync(this IEnumerable<short> x)
        {
            double mean =
                await Task
                            .Run
                                (
                                    () => x.MeanCubic()
                                )
                            .ConfigureAwait(false);

            return mean;
        }

        public async static Task<double> MeanCubicAsync(this IEnumerable<ushort> x)
        {
            double mean =
                await Task
                            .Run
                                (
                                    () => x.MeanCubic()
                                )
                            .ConfigureAwait(false);

            return mean;
        }

        public async static Task<double> MeanCubicAsync(this IEnumerable<int> x)
        {
            double mean =
                await Task
                            .Run
                                (
                                    () => x.MeanCubic()
                                )
                            .ConfigureAwait(false);

            return mean;
        }

        public async static Task<double> MeanCubicAsync(this IEnumerable<uint> x)
        {
            double mean =
                await Task
                            .Run
                                (
                                    () => x.MeanCubic()
                                )
                            .ConfigureAwait(false);

            return mean;
        }

        public async static Task<double> MeanCubicAsync(this IEnumerable<long> x)
        {
            double mean =
                await Task
                            .Run
                                (
                                    () => x.MeanCubic()
                                )
                            .ConfigureAwait(false);

            return mean;
        }

        public async static Task<double> MeanCubicAsync(this IEnumerable<ulong> x)
        {
            double mean =
                await Task
                            .Run
                                (
                                    () => x.MeanCubic()
                                )
                            .ConfigureAwait(false);

            return mean;
        }

        public async static Task<double> MeanCubicAsync(this IEnumerable<float> x)
        {
            double mean =
                await Task
                            .Run
                                (
                                    () => x.MeanCubic()
                                )
                            .ConfigureAwait(false);

            return mean;
        }

        public async static Task<double> MeanCubicAsync(this IEnumerable<double> x)
        {
            double mean =
                await Task
                            .Run
                                (
                                    () => x.MeanCubic()
                                )
                            .ConfigureAwait(false);

            return mean;
        }

        public async static Task<decimal> MeanCubicAsync(this IEnumerable<decimal> x)
        {
            decimal mean =
                await Task
                            .Run
                                (
                                    () => x.MeanCubic()
                                )
                            .ConfigureAwait(false);

            return mean;
        }
        //==============================================================================================================
    }
}
