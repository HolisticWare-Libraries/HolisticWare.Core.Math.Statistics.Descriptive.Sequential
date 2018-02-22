using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Core.Math.Statistics.Descriptive.Sequential
{
	public static partial class IEnumerableExtensionsKurtosisExcess
	{
        public async static Task<double> KurtosisExcessAsync(this IEnumerable<byte> x, IEnumerable<byte> y)
        {
            double kurtosis =
                await Task
                            .Run
                                (
                                    () => x.KurtosisExcess()
                                )
                            .ConfigureAwait(false);

            return kurtosis;
        }

        public async static Task<double> KurtosisExcessAsync(this IEnumerable<short> x, IEnumerable<short> y)
        {
            double kurtosis = 
                await Task
                            .Run
                                (
                                    () => x.KurtosisExcess()
                                )
                            .ConfigureAwait(false);

            return kurtosis;
        }

        public async static Task<double> KurtosisExcessAsync(this IEnumerable<ushort> x, IEnumerable<ushort> y)
        {
            double kurtosis = 
                await Task
                            .Run
                                (
                                    () => x.KurtosisExcess()
                                )
                            .ConfigureAwait(false);

            return kurtosis;
        }

        public async static Task<double> KurtosisExcessAsync(this IEnumerable<int> x, IEnumerable<int> y)
        {
            double kurtosis = 
                await Task
                            .Run
                                (
                                    () => x.KurtosisExcess()
                                )
                            .ConfigureAwait(false);

            return kurtosis;
        }

        public async static Task<double> KurtosisExcessAsync(this IEnumerable<uint> x, IEnumerable<uint> y)
        {
            double kurtosis = 
                await Task
                            .Run
                                (
                                    () => x.KurtosisExcess()
                                )
                            .ConfigureAwait(false);

            return kurtosis;
        }

        public async static Task<double> KurtosisExcessAsync(this IEnumerable<long> x, IEnumerable<long> y)
        {
            double kurtosis = 
                await Task
                            .Run
                                (
                                    () => x.KurtosisExcess()
                                )
                            .ConfigureAwait(false);

            return kurtosis;
        }

        public async static Task<double> KurtosisExcessAsync(this IEnumerable<ulong> x, IEnumerable<ulong> y)
        {
            double kurtosis = 
                await Task
                            .Run
                                (
                                    () => x.KurtosisExcess()
                                )
                            .ConfigureAwait(false);

            return kurtosis;
        }

        public async static Task<double> KurtosisExcessAsync(this IEnumerable<float> x, IEnumerable<float> y)
        {
            double kurtosis = 
                await Task
                            .Run
                                (
                                    () => x.KurtosisExcess()
                                )
                            .ConfigureAwait(false);

            return kurtosis;
        }

        public async static Task<double> KurtosisExcessAsync(this IEnumerable<double> x, IEnumerable<double> y)
        {
            double kurtosis = 
                await Task
                            .Run
                                (
                                    () => x.KurtosisExcess()
                                )
                            .ConfigureAwait(false);

            return kurtosis;
        }

        public async static Task<decimal> KurtosisExcessAsync(this IEnumerable<decimal> x, IEnumerable<decimal> y)
        {
            decimal kurtosis = 
                await Task
                            .Run
                                (
                                    () => x.KurtosisExcess()
                                )
                            .ConfigureAwait(false);

            return kurtosis;
        }
	}
}
