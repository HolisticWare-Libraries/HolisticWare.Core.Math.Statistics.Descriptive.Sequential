using System;
using System.Collections.Generic;
using System.Linq;

using Core.Math.Statistics.Descriptive.Sequential;

namespace Core.Math.Statistics.Descriptive.Sequential
{
    /// <summary>
    /// Correlation
    /// </summary>
    /// <see cref="https://en.wikipedia.org/wiki/Percentile"/>
    /// <see cref="https://www.emathhelp.net/calculators/probability-statistics/percentile-calculator"/>
    /// <see cref="https://www.emathhelp.net/calculators/probability-statistics/percentile-class-rank-calculator"/> 
    public static partial class IEnumerableExtensionsPercentiles
    {
        //==============================================================================================================
        public static (int lower, double interpolated, int upper) Percentile
                                                                    (
                                                                        this IEnumerable<int> x, 
                                                                        double p
                                                                    )
        {
            if (p < 0.0  || p > 1.0)
            {
                throw new ArgumentOutOfRangeException($"Percentile must be in the range [0, 1] the value was {p}");
            }

            IEnumerable<int> x_sorted = x.OrderBy(x_i => x_i);

            int n = x.Count();
            double index_percentile = p * (n + 1);

            int index_lower = (int)index_percentile;
            int index_upper = (int)(index_percentile + 1.0);
            double fraction = index_percentile - index_lower;
            int x_lower = x.ElementAt(index_lower - 1);
            int x_upper = x.ElementAt(index_upper - 1);
            double x_interpolated = fraction * (x_upper - x_lower) + x_lower;

            return (x_lower, x_interpolated, x_upper);
        }
        //==============================================================================================================
    }
}
