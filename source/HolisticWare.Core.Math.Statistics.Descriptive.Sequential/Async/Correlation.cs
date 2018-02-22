using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Core.Math.Statistics.Descriptive.Sequential
{
    public static partial class Correlation
    {
        public async static Task<double> CalculateAsync(IEnumerable<byte> x, IEnumerable<byte> y)
        {
            double correlation =
                await Task
                            .Run
                                (
                                    () => x.Correlation(y)
                                )
                            .ConfigureAwait(false);

            return correlation;
        }

        public async static Task<double> CalculateAsync(IEnumerable<short> x, IEnumerable<short> y)
        {
            double correlation =
                await Task
                            .Run
                                (
                                    () => x.Correlation(y)
                                )
                            .ConfigureAwait(false);

            return correlation;
        }

        public async static Task<double> CalculateAsync(IEnumerable<ushort> x, IEnumerable<ushort> y)
        {
            double correlation =
                await Task
                            .Run
                                (
                                    () => x.Correlation(y)
                                )
                            .ConfigureAwait(false);

            return correlation;
        }

        public async static Task<double> CalculateAsync(IEnumerable<int> x, IEnumerable<int> y)
        {
            double correlation =
                await Task
                            .Run
                                (
                                    () => x.Correlation(y)
                                )
                            .ConfigureAwait(false);

            return correlation;
        }

        public async static Task<double> CalculateAsync(IEnumerable<uint> x, IEnumerable<uint> y)
        {
            double correlation =
                await Task
                            .Run
                                (
                                    () => x.Correlation(y)
                                )
                            .ConfigureAwait(false);

            return correlation;
        }

        public async static Task<double> CalculateAsync(IEnumerable<long> x, IEnumerable<long> y)
        {
            double correlation =
                await Task
                            .Run
                                (
                                    () => x.Correlation(y)
                                )
                            .ConfigureAwait(false);

            return correlation;
        }

        public async static Task<double> CalculateAsync(IEnumerable<ulong> x, IEnumerable<ulong> y)
        {
            double correlation =
                await Task
                            .Run
                                (
                                    () => x.Correlation(y)
                                )
                            .ConfigureAwait(false);

            return correlation;
        }

        public async static Task<double> CalculateAsync(IEnumerable<float> x, IEnumerable<float> y)
        {
            double correlation =
                await Task
                            .Run
                                (
                                    () => x.Correlation(y)
                                )
                            .ConfigureAwait(false);

            return correlation;
        }

        public async static Task<double> CalculateAsync(IEnumerable<double> x, IEnumerable<double> y)
        {
            double correlation =
                await Task
                            .Run
                                (
                                    () => x.Correlation(y)
                                )
                            .ConfigureAwait(false);

            return correlation;
        }

        public async static Task<decimal> CalculateAsync(IEnumerable<decimal> x, IEnumerable<decimal> y)
        {
            decimal correlation =
                await Task
                            .Run
                                (
                                    () => x.Correlation(y)
                                )
                            .ConfigureAwait(false);

            return correlation;
        }
    }
}
