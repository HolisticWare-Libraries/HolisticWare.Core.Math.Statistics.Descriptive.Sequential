using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Core.Math.Statistics.Descriptive.Sequential
{
	public static partial class IEnumerableExtensionsFrequencies
	{
        public async static Task<IEnumerable<KeyValuePair<short, uint>>> FrequenciesAsync(this IEnumerable<short> x)
        {
            IEnumerable<KeyValuePair<short, uint>> frequencies = 
                await Task
                            .Run
                                (
                                    () => x.Frequencies()
                                )
                            .ConfigureAwait(false);

            return frequencies;
        }

        public async static Task<IEnumerable<KeyValuePair<ushort, uint>>> FrequenciesAsync(this IEnumerable<ushort> x)
        {
            IEnumerable<KeyValuePair<ushort, uint>> frequencies = 
                await Task
                            .Run
                                (
                                    () => x.Frequencies()
                                )
                            .ConfigureAwait(false);

            return frequencies;
        }

        public async static Task<IEnumerable<KeyValuePair<int, uint>>> FrequenciesAsync(this IEnumerable<int> x)
        {
            IEnumerable<KeyValuePair<int, uint>> frequencies = 
                await Task
                            .Run
                                (
                                    () => x.Frequencies()
                                )
                            .ConfigureAwait(false);

            return frequencies;
        }

        public async static Task<IEnumerable<KeyValuePair<uint, uint>>> FrequenciesAsync(this IEnumerable<uint> x)
        {
            IEnumerable<KeyValuePair<uint, uint>> frequencies = 
                await Task
                            .Run
                                (
                                    () => x.Frequencies()
                                )
                            .ConfigureAwait(false);

            return frequencies;
        }

        public async static Task<IEnumerable<KeyValuePair<long, uint>>> FrequenciesAsync(this IEnumerable<long> x)
        {
            IEnumerable<KeyValuePair<long, uint>> frequencies = 
                await Task
                            .Run
                                (
                                    () => x.Frequencies()
                                )
                            .ConfigureAwait(false);

            return frequencies;
        }

        public async static Task<IEnumerable<KeyValuePair<ulong, uint>>> FrequenciesAsync(this IEnumerable<ulong> x)
        {
            IEnumerable<KeyValuePair<ulong, uint>> frequencies = 
                await Task
                            .Run
                                (
                                    () => x.Frequencies()
                                )
                            .ConfigureAwait(false);

            return frequencies;
        }

        public async static Task<IEnumerable<KeyValuePair<float, uint>>> FrequenciesAsync(this IEnumerable<float> x)
        {
            IEnumerable<KeyValuePair<float, uint>> frequencies = 
                await Task
                            .Run
                                (
                                    () => x.Frequencies()
                                )
                            .ConfigureAwait(false);

            return frequencies;
        }

        public async static Task<IEnumerable<KeyValuePair<double, uint>>> FrequenciesAsync(this IEnumerable<double> x)
        {
            IEnumerable<KeyValuePair<double, uint>> frequencies = 
                await Task
                            .Run
                                (
                                    () => x.Frequencies()
                                )
                            .ConfigureAwait(false);

            return frequencies;
        }

        public async static Task<IEnumerable<KeyValuePair<decimal, uint>>> FrequenciesAsync(this IEnumerable<decimal> x)
        {
            IEnumerable<KeyValuePair<decimal, uint>> frequencies = 
                await Task
                            .Run
                                (
                                    () => x.Frequencies()
                                )
                            .ConfigureAwait(false);

            return frequencies;
        }
	}
}
