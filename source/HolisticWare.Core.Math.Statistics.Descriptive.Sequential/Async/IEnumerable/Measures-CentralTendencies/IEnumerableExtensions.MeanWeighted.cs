using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Core.Math.Statistics.Descriptive.Sequential
{
    public static partial class IEnumerableExtensionsMeanWeighted
    {
        //==============================================================================================================
        public async static Task<double> MeanWeightedAsync(this IEnumerable<byte> x, IEnumerable<double> weights)
        {
            double mean =
                await Task
                            .Run
                                (
                                    () => x.MeanWeighted(weights)
                                )
                            .ConfigureAwait(false);

            return mean;
        }

        public async static Task<double> MeanWeightedAsync(this IEnumerable<short> x, IEnumerable<double> weights)
        {
            double mean =
                await Task
                            .Run
                                (
                                    () => x.MeanWeighted(weights)
                                )
                            .ConfigureAwait(false);

            return mean;
        }

        public async static Task<double> MeanWeightedAsync(this IEnumerable<ushort> x, IEnumerable<double> weights)
        {
            double mean =
                await Task
                            .Run
                                (
                                    () => x.MeanWeighted(weights)
                                )
                            .ConfigureAwait(false);

            return mean;
        }

        public async static Task<double> MeanWeightedAsync(this IEnumerable<int> x, IEnumerable<double> weights)
        {
            double mean =
                await Task
                            .Run
                                (
                                    () => x.MeanWeighted(weights)
                                )
                            .ConfigureAwait(false);

            return mean;
        }

        public async static Task<double> MeanWeightedAsync(this IEnumerable<uint> x, IEnumerable<double> weights)
        {
            double mean =
                await Task
                            .Run
                                (
                                    () => x.MeanWeighted(weights)
                                )
                            .ConfigureAwait(false);

            return mean;
        }

        public async static Task<double> MeanWeightedAsync(this IEnumerable<long> x, IEnumerable<double> weights)
        {
            double mean =
                await Task
                            .Run
                                (
                                    () => x.MeanWeighted(weights)
                                )
                            .ConfigureAwait(false);

            return mean;
        }

        public async static Task<double> MeanWeightedAsync(this IEnumerable<ulong> x, IEnumerable<double> weights)
        {
            double mean =
                await Task
                            .Run
                                (
                                    () => x.MeanWeighted(weights)
                                )
                            .ConfigureAwait(false);

            return mean;
        }

        public async static Task<double> MeanWeightedAsync(this IEnumerable<float> x, IEnumerable<double> weights)
        {
            double mean =
                await Task
                            .Run
                                (
                                    () => x.MeanWeighted(weights)
                                )
                            .ConfigureAwait(false);

            return mean;
        }

        public async static Task<double> MeanWeightedAsync(this IEnumerable<double> x, IEnumerable<double> weights)
        {
            double mean =
                await Task
                            .Run
                                (
                                    () => x.MeanWeighted(weights)
                                )
                            .ConfigureAwait(false);

            return mean;
        }

        public async static Task<decimal> MeanWeightedAsync(this IEnumerable<decimal> x, IEnumerable<double> weights)
        {
            decimal mean =
                await Task
                            .Run
                                (
                                    () => x.MeanWeighted(weights)
                                )
                            .ConfigureAwait(false);

            return mean;
        }
        //==============================================================================================================
    }
}
