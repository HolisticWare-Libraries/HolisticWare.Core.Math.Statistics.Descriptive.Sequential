using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Core.Math.Statistics.Descriptive.Sequential
{
	public static partial class IEnumerableExtensionsSkewness
	{
        public async static Task<double> SkewnessAsync(this IEnumerable<byte> x)
        {
            double skewness =
                await Task
                            .Run
                                (
                                    () => x.Skewness()
                                )
                            .ConfigureAwait(false);

            return skewness;
        }

        public async static Task<double> SkewnessAsync(this IEnumerable<short> x)
        {
            double skewness = 
                await Task
                            .Run
                                (
                                    () => x.Skewness()
                                )
                            .ConfigureAwait(false);

            return skewness;
        }

        public async static Task<double> SkewnessAsync(this IEnumerable<ushort> x)
        {
            double skewness = 
                await Task
                            .Run
                                (
                                    () => x.Skewness()
                                )
                            .ConfigureAwait(false);

            return skewness;
        }

        public async static Task<double> SkewnessAsync(this IEnumerable<int> x)
        {
            double skewness = 
                await Task
                            .Run
                                (
                                    () => x.Skewness()
                                )
                            .ConfigureAwait(false);

            return skewness;
        }

        public async static Task<double> SkewnessAsync(this IEnumerable<uint> x)
        {
            double skewness = 
                await Task
                            .Run
                                (
                                    () => x.Skewness()
                                )
                            .ConfigureAwait(false);

            return skewness;
        }

        public async static Task<double> SkewnessAsync(this IEnumerable<long> x)
        {
            double skewness = 
                await Task
                            .Run
                                (
                                    () => x.Skewness()
                                )
                            .ConfigureAwait(false);

            return skewness;
        }

        public async static Task<double> SkewnessAsync(this IEnumerable<ulong> x)
        {
            double skewness = 
                await Task
                            .Run
                                (
                                    () => x.Skewness()
                                )
                            .ConfigureAwait(false);

            return skewness;
        }

        public async static Task<double> SkewnessAsync(this IEnumerable<float> x)
        {
            double skewness = 
                await Task
                            .Run
                                (
                                    () => x.Skewness()
                                )
                            .ConfigureAwait(false);

            return skewness;
        }

        public async static Task<double> SkewnessAsync(this IEnumerable<double> x)
        {
            double skewness = 
                await Task
                            .Run
                                (
                                    () => x.Skewness()
                                )
                            .ConfigureAwait(false);

            return skewness;
        }

        public async static Task<decimal> SkewnessAsync(this IEnumerable<decimal> x)
        {
            decimal skewness = 
                await Task
                            .Run
                                (
                                    () => x.Skewness()
                                )
                            .ConfigureAwait(false);

            return skewness;
        }
	}
}
