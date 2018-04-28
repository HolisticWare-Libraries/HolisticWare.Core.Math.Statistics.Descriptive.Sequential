using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Core.Math.Statistics.Descriptive.Sequential
{
    //==============================================================================================================
    public static partial class IEnumerableExtensionsMeanGeneralized
    {
        public async static Task<double> MeanGeneralizedAsync(this IEnumerable<byte> x, double power)
        {
            double mean =
                await Task
                            .Run
                                (
                                    () => x.MeanGeneralized(power)
                                )
                            .ConfigureAwait(false);

            return mean;
        }

        public async static Task<double> MeanGeneralizedAsync(this IEnumerable<short> x, double power)
        {
            double mean =
                await Task
                            .Run
                                (
                                    () => x.MeanGeneralized(power)
                                )
                            .ConfigureAwait(false);

            return mean;
        }

        public async static Task<double> MeanGeneralizedAsync(this IEnumerable<ushort> x, double power)
        {
            double mean =
                await Task
                            .Run
                                (
                                    () => x.MeanGeneralized(power)
                                )
                            .ConfigureAwait(false);

            return mean;
        }

        public async static Task<double> MeanGeneralizedAsync(this IEnumerable<int> x, double power)
        {
            double mean =
                await Task
                            .Run
                                (
                                    () => x.MeanGeneralized(power)
                                )
                            .ConfigureAwait(false);

            return mean;
        }

        public async static Task<double> MeanGeneralizedAsync(this IEnumerable<uint> x, double power)
        {
            double mean =
                await Task
                            .Run
                                (
                                    () => x.MeanGeneralized(power)
                                )
                            .ConfigureAwait(false);

            return mean;
        }

        public async static Task<double> MeanGeneralizedAsync(this IEnumerable<long> x, double power)
        {
            double mean =
                await Task
                            .Run
                                (
                                    () => x.MeanGeneralized(power)
                                )
                            .ConfigureAwait(false);

            return mean;
        }

        public async static Task<double> MeanGeneralizedAsync(this IEnumerable<ulong> x, double power)
        {
            double mean =
                await Task
                            .Run
                                (
                                    () => x.MeanGeneralized(power)
                                )
                            .ConfigureAwait(false);

            return mean;
        }

        public async static Task<double> MeanGeneralizedAsync(this IEnumerable<float> x, double power)
        {
            double mean =
                await Task
                            .Run
                                (
                                    () => x.MeanGeneralized(power)
                                )
                            .ConfigureAwait(false);

            return mean;
        }

        public async static Task<double> MeanGeneralizedAsync(this IEnumerable<double> x, double power)
        {
            double mean =
                await Task
                            .Run
                                (
                                    () => x.MeanGeneralized(power)
                                )
                            .ConfigureAwait(false);

            return mean;
        }

        public async static Task<decimal> MeanGeneralizedAsync(this IEnumerable<decimal> x, double power)
        {
            decimal mean =
                await Task
                            .Run
                                (
                                    () => x.MeanGeneralized(power)
                                )
                            .ConfigureAwait(false);

            return mean;
        }
        //==============================================================================================================
    }
}
