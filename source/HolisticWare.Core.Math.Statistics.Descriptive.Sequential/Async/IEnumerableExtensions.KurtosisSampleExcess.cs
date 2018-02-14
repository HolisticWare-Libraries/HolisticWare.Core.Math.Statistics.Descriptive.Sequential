using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Core.Math.Statistics.Descriptive.Sequential
{
	public static partial class IEnumerableExtensionsKurtosisSampleExcess
	{
        public async static Task<double> KurtosisSampleExcessAsync(this IEnumerable<short> x, IEnumerable<short> y)
        {
            double kurtosis = 
                await Task
                            .Run
                                (
                                    () => x.KurtosisSampleExcess()
                                )
                            .ConfigureAwait(false);

            return kurtosis;
        }

        public async static Task<double> KurtosisSampleExcessAsync(this IEnumerable<ushort> x, IEnumerable<ushort> y)
        {
            double kurtosis = 
                await Task
                            .Run
                                (
                                    () => x.KurtosisSampleExcess()
                                )
                            .ConfigureAwait(false);

            return kurtosis;
        }

        public async static Task<double> KurtosisSampleExcessAsync(this IEnumerable<int> x, IEnumerable<int> y)
        {
            double kurtosis = 
                await Task
                            .Run
                                (
                                    () => x.KurtosisSampleExcess()
                                )
                            .ConfigureAwait(false);

            return kurtosis;
        }

        public async static Task<double> KurtosisSampleExcessAsync(this IEnumerable<uint> x, IEnumerable<uint> y)
        {
            double kurtosis = 
                await Task
                            .Run
                                (
                                    () => x.KurtosisSampleExcess()
                                )
                            .ConfigureAwait(false);

            return kurtosis;
        }

        public async static Task<double> KurtosisSampleExcessAsync(this IEnumerable<long> x, IEnumerable<long> y)
        {
            double kurtosis = 
                await Task
                            .Run
                                (
                                    () => x.KurtosisSampleExcess()
                                )
                            .ConfigureAwait(false);

            return kurtosis;
        }

        public async static Task<double> KurtosisSampleExcessAsync(this IEnumerable<ulong> x, IEnumerable<ulong> y)
        {
            double kurtosis = 
                await Task
                            .Run
                                (
                                    () => x.KurtosisSampleExcess()
                                )
                            .ConfigureAwait(false);

            return kurtosis;
        }

        public async static Task<double> KurtosisSampleExcessAsync(this IEnumerable<float> x, IEnumerable<float> y)
        {
            double kurtosis = 
                await Task
                            .Run
                                (
                                    () => x.KurtosisSampleExcess()
                                )
                            .ConfigureAwait(false);

            return kurtosis;
        }

        public async static Task<double> KurtosisSampleExcessAsync(this IEnumerable<double> x, IEnumerable<double> y)
        {
            double kurtosis = 
                await Task
                            .Run
                                (
                                    () => x.KurtosisSampleExcess()
                                )
                            .ConfigureAwait(false);

            return kurtosis;
        }

        public async static Task<decimal> KurtosisSampleExcessAsync(this IEnumerable<decimal> x, IEnumerable<decimal> y)
        {
            decimal kurtosis = 
                await Task
                            .Run
                                (
                                    () => x.KurtosisSampleExcess()
                                )
                            .ConfigureAwait(false);

            return kurtosis;
        }
	}
}
