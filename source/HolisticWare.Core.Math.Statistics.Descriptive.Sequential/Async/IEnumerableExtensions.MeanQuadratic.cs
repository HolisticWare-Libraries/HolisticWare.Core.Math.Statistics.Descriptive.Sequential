using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Core.Math.Statistics.Descriptive.Sequential
{
    public static partial class IEnumerableExtensionsMeanQuadratic
    {
        //==============================================================================================================
        public async static Task<double> MeanQuadraticAsync(this IEnumerable<byte> x)
        {
            double mean =
                await Task
                            .Run
                                (
                                    () => x.MeanQuadratic()
                                )
                            .ConfigureAwait(false);

            return mean;
        }

        public async static Task<double> MeanQuadraticAsync(this IEnumerable<short> x)
        {
            double mean =
                await Task
                            .Run
                                (
                                    () => x.MeanQuadratic()
                                )
                            .ConfigureAwait(false);

            return mean;
        }

        public async static Task<double> MeanQuadraticAsync(this IEnumerable<ushort> x)
        {
            double mean =
                await Task
                            .Run
                                (
                                    () => x.MeanQuadratic()
                                )
                            .ConfigureAwait(false);

            return mean;
        }

        public async static Task<double> MeanQuadraticAsync(this IEnumerable<int> x)
        {
            double mean =
                await Task
                            .Run
                                (
                                    () => x.MeanQuadratic()
                                )
                            .ConfigureAwait(false);

            return mean;
        }

        public async static Task<double> MeanQuadraticAsync(this IEnumerable<uint> x)
        {
            double mean =
                await Task
                            .Run
                                (
                                    () => x.MeanQuadratic()
                                )
                            .ConfigureAwait(false);

            return mean;
        }

        public async static Task<double> MeanQuadraticAsync(this IEnumerable<long> x)
        {
            double mean =
                await Task
                            .Run
                                (
                                    () => x.MeanQuadratic()
                                )
                            .ConfigureAwait(false);

            return mean;
        }

        public async static Task<double> MeanQuadraticAsync(this IEnumerable<ulong> x)
        {
            double mean =
                await Task
                            .Run
                                (
                                    () => x.MeanQuadratic()
                                )
                            .ConfigureAwait(false);

            return mean;
        }

        public async static Task<double> MeanQuadraticAsync(this IEnumerable<float> x)
        {
            double mean =
                await Task
                            .Run
                                (
                                    () => x.MeanQuadratic()
                                )
                            .ConfigureAwait(false);

            return mean;
        }

        public async static Task<double> MeanQuadraticAsync(this IEnumerable<double> x)
        {
            double mean =
                await Task
                            .Run
                                (
                                    () => x.MeanQuadratic()
                                )
                            .ConfigureAwait(false);

            return mean;
        }

        public async static Task<decimal> MeanQuadraticAsync(this IEnumerable<decimal> x)
        {
            decimal mean =
                await Task
                            .Run
                                (
                                    () => x.MeanQuadratic()
                                )
                            .ConfigureAwait(false);

            return mean;
        }
        //==============================================================================================================
    }
}
