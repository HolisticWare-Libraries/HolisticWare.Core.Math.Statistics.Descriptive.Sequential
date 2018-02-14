using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Core.Math.Statistics.Descriptive.Sequential
{
    public static partial class IEnumerableExtensionsFrequencyCounter
	{
        public async static Task<Dictionary<short, uint>> CorrelationAsync(this IEnumerable<short> x)
        {
            Dictionary<short, uint> frequencies = 
                await Task
                            .Run
                                (
                                    () => x.FrequencyCounter()
                                )
                            .ConfigureAwait(false);

            return frequencies;
        }
	}
}
