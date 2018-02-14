using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Core.Math.Statistics.Descriptive.Sequential
{
    public static partial class WelchtStatistic
    {
        public async static Task<(double welch_t, double degrees_of_freedom)> CalculateAsync(IEnumerable<short> x, IEnumerable<short> y)
        {
            (double welch_t, double degrees_of_freedom) statistic =
                await Task
                            .Run
                                (
                                    () => x.WelchtStatistic(y)
                                )
                            .ConfigureAwait(false);

            return statistic;
        }
    }
}
