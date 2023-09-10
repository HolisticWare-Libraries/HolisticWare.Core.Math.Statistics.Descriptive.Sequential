using System;
using System.Collections.Generic;
using System.Linq;

using Core.Math.Statistics.Descriptive;

namespace Core.Math.Statistics.Descriptive
{
    /// <summary>
    /// Correlation
    /// </summary>
    /// <see href="https://en.wikipedia.org/wiki/Percentile"/>
    /// <see href="https://www.emathhelp.net/calculators/probability-statistics/percentile-calculator"/>
    /// <see href="https://www.emathhelp.net/calculators/probability-statistics/percentile-class-rank-calculator"/> 
    public static partial class IEnumerableExtensionsPercentiles
    {
        //==============================================================================================================
        public static
            double
                                        PercentileRank
                                        (
                                            this IEnumerable<int> x, 
                                            double p
                                        )
        {
            if (p < 0.0 || p > 1.0)
            {
                throw new ArgumentOutOfRangeException($"Percentile must be in the range [0, 1] the value was {p}");
            }
            int n = x.Count();

            return p / 100 * (n + 1);
        }
        //==============================================================================================================

    }
}
