using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Core.Math.Statistics.Descriptive.Sequential
{
    public static partial class IEnumerableExtensionsVarianceSample
    {
        public async static Task<double> VarianceSampleAsync(this IEnumerable<byte> x)
        {
            double variance =
                await Task
                            .Run
                                (
                                    () => x.VarianceSample()
                                )
                            .ConfigureAwait(false);

            return variance;
        }

        public async static Task<double> VarianceSampleAsync(this IEnumerable<short> x)
        {
            double variance =
                await Task
                            .Run
                                (
                                    () => x.VarianceSample()
                                )
                            .ConfigureAwait(false);

            return variance;
        }

        public async static Task<double> VarianceSampleAsync(this IEnumerable<ushort> x)
        {
            double variance =
                await Task
                            .Run
                                (
                                    () => x.VarianceSample()
                                )
                            .ConfigureAwait(false);

            return variance;
        }

        public async static Task<double> VarianceSampleAsync(this IEnumerable<int> x)
        {
            double variance =
                await Task
                            .Run
                                (
                                    () => x.VarianceSample()
                                )
                            .ConfigureAwait(false);

            return variance;
        }

        public async static Task<double> VarianceSampleAsync(this IEnumerable<uint> x)
        {
            double variance =
                await Task
                            .Run
                                (
                                    () => x.VarianceSample()
                                )
                            .ConfigureAwait(false);

            return variance;
        }

        public async static Task<double> VarianceSampleAsync(this IEnumerable<long> x)
        {
            double variance =
                await Task
                            .Run
                                (
                                    () => x.VarianceSample()
                                )
                            .ConfigureAwait(false);

            return variance;
        }

        public async static Task<double> VarianceSampleAsync(this IEnumerable<ulong> x)
        {
            double variance =
                await Task
                            .Run
                                (
                                    () => x.VarianceSample()
                                )
                            .ConfigureAwait(false);

            return variance;
        }

        public async static Task<double> VarianceSampleAsync(this IEnumerable<float> x)
        {
            double variance =
                await Task
                            .Run
                                (
                                    () => x.VarianceSample()
                                )
                            .ConfigureAwait(false);

            return variance;
        }

        public async static Task<double> VarianceSampleAsync(this IEnumerable<double> x)
        {
            double variance =
                await Task
                            .Run
                                (
                                    () => x.VarianceSample()
                                )
                            .ConfigureAwait(false);

            return variance;
        }

        public async static Task<decimal> VarianceSampleAsync(this IEnumerable<decimal> x)
        {
            decimal variance =
                await Task
                            .Run
                                (
                                    () => x.VarianceSample()
                                )
                            .ConfigureAwait(false);

            return variance;
        }
    }
}
