using System;
using System.Collections.Generic;
using System.Linq;

namespace Core.Math.Statistics.Descriptive.Sequential
{
    /// <summary>
    /// Median Weighted
    /// </summary>
    /// <see cref="https://en.wikipedia.org/wiki/Weighted_median"/>
    /// <see cref="https://www.easycalculation.com/statistics/weighted-mean-calculator.php"/>
    /// <see cref="http://mathworld.wolfram.com/PowerMean.html"/> 
    public static partial class IEnumerableExtensionsMedianWeighted
    {
        //==============================================================================================================
        public static int MedianWeighted
                                    (
                                        this IEnumerable<int> x, 
                                        IEnumerable<double> weights
                                    )
        {
            int n = x.Count();
            int n_2 = weights.ToArray().Count();

            if ( n != n_2)
            {
                throw new InvalidOperationException("Number of elements must match");
            }

            double sum_weights = weights.Sum();
            double sum_percentage_weights = 0.0;
            double[] percentges_weight = new double[n];

            int index = -1;

            for (int i = 0; i < weights.Count(); i++)
            {
                double percentage_weight = weights.ElementAt(i) / sum_weights;
                percentges_weight[i] = percentage_weight;
                sum_percentage_weights += percentage_weight;

                if (sum_percentage_weights >= 0.5)
                {
                    index = i;
                    break;
                }
            }

            return x.ElementAt(index);
        }
        //==============================================================================================================

    }
}
