using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Core.Math.Statistics.Descriptive.Sequential
{
    public static partial class IEnumerableExtensionsMeanGeometric
    {
        //==============================================================================================================
        public async static Task<double> MeanGeometricAsync(this IEnumerable<byte> x)
        {
            double mean =
                await Task
                            .Run
                                (
                                    () => x.MeanGeometric()
                                )
                            .ConfigureAwait(false);

            return mean;
        }

        public async static Task<double> MeanGeometricAsync(this IEnumerable<short> x)
        {
            double mean =
                await Task
                            .Run
                                (
                                    () => x.MeanGeometric()
                                )
                            .ConfigureAwait(false);

            return mean;
        }

        public async static Task<double> MeanGeometricAsync(this IEnumerable<ushort> x)
        {
            double mean =
                await Task
                            .Run
                                (
                                    () => x.MeanGeometric()
                                )
                            .ConfigureAwait(false);

            return mean;
        }

        public async static Task<double> MeanGeometricAsync(this IEnumerable<int> x)
        {
            double mean =
                await Task
                            .Run
                                (
                                    () => x.MeanGeometric()
                                )
                            .ConfigureAwait(false);

            return mean;
        }

        public async static Task<double> MeanGeometricAsync(this IEnumerable<uint> x)
        {
            double mean =
                await Task
                            .Run
                                (
                                    () => x.MeanGeometric()
                                )
                            .ConfigureAwait(false);

            return mean;
        }

        public async static Task<double> MeanGeometricAsync(this IEnumerable<long> x)
        {
            double mean =
                await Task
                            .Run
                                (
                                    () => x.MeanGeometric()
                                )
                            .ConfigureAwait(false);

            return mean;
        }

        public async static Task<double> MeanGeometricAsync(this IEnumerable<ulong> x)
        {
            double mean =
                await Task
                            .Run
                                (
                                    () => x.MeanGeometric()
                                )
                            .ConfigureAwait(false);

            return mean;
        }

        public async static Task<double> MeanGeometricAsync(this IEnumerable<float> x)
        {
            double mean =
                await Task
                            .Run
                                (
                                    () => x.MeanGeometric()
                                )
                            .ConfigureAwait(false);

            return mean;
        }

        public async static Task<double> MeanGeometricAsync(this IEnumerable<double> x)
        {
            double mean =
                await Task
                            .Run
                                (
                                    () => x.MeanGeometric()
                                )
                            .ConfigureAwait(false);

            return mean;
        }

        public async static Task<decimal> MeanGeometricAsync(this IEnumerable<decimal> x)
        {
            decimal mean =
                await Task
                            .Run
                                (
                                    () => x.MeanGeometric()
                                )
                            .ConfigureAwait(false);

            return mean;
        }
        //==============================================================================================================
    }
}
