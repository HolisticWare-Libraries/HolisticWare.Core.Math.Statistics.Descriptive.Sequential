using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Core.Math.Statistics.Descriptive.Sequential
{
    public static partial class FStatistic
    {
        public async static Task<double> CalculateAsync(IEnumerable<byte> x, IEnumerable<byte> y)
        {
            double statistic =
                await Task
                            .Run
                                (
                                    () => x.FStatistic(y)
                                )
                            .ConfigureAwait(false);

            return statistic;
        }

        public async static Task<double> CalculateAsync(IEnumerable<short> x, IEnumerable<short> y)
        {
            double statistic =
                await Task
                            .Run
                                (
                                    () => x.FStatistic(y)
                                )
                            .ConfigureAwait(false);

            return statistic;
        }
    }
}
