using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Core.Math.Statistics.Descriptive.Sequential
{
    public static partial class IEnumerableExtensionsMeanHarmonic
    {
        //==============================================================================================================
        public async static Task<double> MeanHarmonicAsync(this IEnumerable<byte> x)
        {
            double mean =
                await Task
                            .Run
                                (
                                    () => x.MeanHarmonic()
                                )
                            .ConfigureAwait(false);

            return mean;
        }

        public async static Task<double> MeanHarmonicAsync(this IEnumerable<short> x)
        {
            double mean =
                await Task
                            .Run
                                (
                                    () => x.MeanHarmonic()
                                )
                            .ConfigureAwait(false);

            return mean;
        }

        public async static Task<double> MeanHarmonicAsync(this IEnumerable<ushort> x)
        {
            double mean =
                await Task
                            .Run
                                (
                                    () => x.MeanHarmonic()
                                )
                            .ConfigureAwait(false);

            return mean;
        }

        public async static Task<double> MeanHarmonicAsync(this IEnumerable<int> x)
        {
            double mean =
                await Task
                            .Run
                                (
                                    () => x.MeanHarmonic()
                                )
                            .ConfigureAwait(false);

            return mean;
        }

        public async static Task<double> MeanHarmonicAsync(this IEnumerable<uint> x)
        {
            double mean =
                await Task
                            .Run
                                (
                                    () => x.MeanHarmonic()
                                )
                            .ConfigureAwait(false);

            return mean;
        }

        public async static Task<double> MeanHarmonicAsync(this IEnumerable<long> x)
        {
            double mean =
                await Task
                            .Run
                                (
                                    () => x.MeanHarmonic()
                                )
                            .ConfigureAwait(false);

            return mean;
        }

        public async static Task<double> MeanHarmonicAsync(this IEnumerable<ulong> x)
        {
            double mean =
                await Task
                            .Run
                                (
                                    () => x.MeanHarmonic()
                                )
                            .ConfigureAwait(false);

            return mean;
        }

        public async static Task<double> MeanHarmonicAsync(this IEnumerable<float> x)
        {
            double mean =
                await Task
                            .Run
                                (
                                    () => x.MeanHarmonic()
                                )
                            .ConfigureAwait(false);

            return mean;
        }

        public async static Task<double> MeanHarmonicAsync(this IEnumerable<double> x)
        {
            double mean =
                await Task
                            .Run
                                (
                                    () => x.MeanHarmonic()
                                )
                            .ConfigureAwait(false);

            return mean;
        }

        public async static Task<decimal> MeanHarmonicAsync(this IEnumerable<decimal> x)
        {
            decimal mean =
                await Task
                            .Run
                                (
                                    () => x.MeanHarmonic()
                                )
                            .ConfigureAwait(false);

            return mean;
        }
        //==============================================================================================================
    }
}
