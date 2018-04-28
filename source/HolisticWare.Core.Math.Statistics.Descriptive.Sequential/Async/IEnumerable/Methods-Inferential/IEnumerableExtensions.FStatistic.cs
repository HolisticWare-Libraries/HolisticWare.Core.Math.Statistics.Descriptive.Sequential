using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Core.Math.Statistics.Descriptive.Sequential
{
	public static partial class IEnumerableExtensionsFStatistic
	{
        //==============================================================================================================
        public async static Task<double> FStatisticAsync(this IEnumerable<byte> x, IEnumerable<byte> y)
        {
            double correlation =
                await Task
                            .Run
                                (
                                    () => x.FStatistic(y)
                                )
                            .ConfigureAwait(false);

            return correlation;
        }

        public async static Task<double> FStatisticAsync(this IEnumerable<short> x, IEnumerable<short> y)
        {
            double correlation = 
                await Task
                            .Run
                                (
                                    () => x.FStatistic(y)
                                )
                            .ConfigureAwait(false);

            return correlation;
        }

        public async static Task<double> FStatisticAsync(this IEnumerable<ushort> x, IEnumerable<ushort> y)
        {
            double correlation = 
                await Task
                            .Run
                                (
                                    () => x.FStatistic(y)
                                )
                            .ConfigureAwait(false);

            return correlation;
        }

        public async static Task<double> FStatisticAsync(this IEnumerable<int> x, IEnumerable<int> y)
        {
            double correlation = 
                await Task
                            .Run
                                (
                                    () => x.FStatistic(y)
                                )
                            .ConfigureAwait(false);

            return correlation;
        }

        public async static Task<double> FStatisticAsync(this IEnumerable<uint> x, IEnumerable<uint> y)
        {
            double correlation = 
                await Task
                            .Run
                                (
                                    () => x.FStatistic(y)
                                )
                            .ConfigureAwait(false);

            return correlation;
        }

        public async static Task<double> FStatisticAsync(this IEnumerable<long> x, IEnumerable<long> y)
        {
            double correlation = 
                await Task
                            .Run
                                (
                                    () => x.FStatistic(y)
                                )
                            .ConfigureAwait(false);

            return correlation;
        }

        public async static Task<double> FStatisticAsync(this IEnumerable<ulong> x, IEnumerable<ulong> y)
        {
            double correlation = 
                await Task
                            .Run
                                (
                                    () => x.FStatistic(y)
                                )
                            .ConfigureAwait(false);

            return correlation;
        }

        public async static Task<double> FStatisticAsync(this IEnumerable<float> x, IEnumerable<float> y)
        {
            double correlation = 
                await Task
                            .Run
                                (
                                    () => x.FStatistic(y)
                                )
                            .ConfigureAwait(false);

            return correlation;
        }

        public async static Task<double> FStatisticAsync(this IEnumerable<double> x, IEnumerable<double> y)
        {
            double correlation = 
                await Task
                            .Run
                                (
                                    () => x.FStatistic(y)
                                )
                            .ConfigureAwait(false);

            return correlation;
        }

        public async static Task<decimal> FStatisticAsync(this IEnumerable<decimal> x, IEnumerable<decimal> y)
        {
            decimal correlation = 
                await Task
                            .Run
                                (
                                    () => x.FStatistic(y)
                                )
                            .ConfigureAwait(false);

            return correlation;
        }
        //==============================================================================================================
	}
}
