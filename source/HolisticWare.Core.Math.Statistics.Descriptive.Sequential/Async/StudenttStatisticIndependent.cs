using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Core.Math.Statistics.Descriptive.Sequential
{
    public static partial class StudenttStatisticIndependent
    {
        public async static Task<double> CalculateAsync(IEnumerable<short> x, IEnumerable<short> y)
        {
            double correlation =
                await Task
                            .Run
                                (
                                    () => x.StudenttStatisticIndependent(y)
                                )
                            .ConfigureAwait(false);

            return correlation;
        }
    }
}
