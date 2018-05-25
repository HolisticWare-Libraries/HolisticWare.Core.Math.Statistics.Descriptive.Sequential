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
    /// <see cref="http://elsenaju.eu/Calculator/mean-value-calculator.htm"/>
    public static partial class IEnumerableExtensionsMedianWeighted
    {
        //==============================================================================================================
        public static (int Index, double Value) MedianWeighted
                                    (
                                        this IEnumerable<int> x, 
                                        IEnumerable<double> weights
                                    )
        {
           
            int n_x = x.Count();
            int n_w = weights.ToArray().Count();

            if ( n_x != n_w)
            {
                throw new InvalidOperationException("Number of elements must match");
            }

            double sum_weights = weights.Sum();
            IEnumerable<double> weights_normalized = null;

            if (System.Math.Abs(sum_weights - 1.0) >= double.Epsilon)
            {
                if (sum_weights > 1.0)
                {
                    weights_normalized = weights.Normalize();
                }
                else
                {
                    weights_normalized = weights;
                }
            }
            else
            {
                weights_normalized = weights;    
            }

            bool advance_lower = true;
            bool advance_upper = true;

            double sum_lower = 0.0;
            double sum_upper = 0.0;
            int i_lower = 0;
            int i_upper = n_w - 1;

            while (advance_lower || advance_upper)
            {
                sum_lower += weights_normalized.ElementAt(i_lower);
                sum_upper += weights_normalized.ElementAt(i_upper);

                if (sum_lower + weights_normalized.ElementAt(i_lower + 1) < 0.5)
                {
                    i_lower++;
                }
                else
                {
                    advance_lower = false;
                }
                if(advance_upper == true && sum_upper + weights_normalized.ElementAt(i_upper - 1) < 0.5)
                {
                    i_upper--;
                }
                else
                {
                    advance_upper = false;
                }

            }

            int index = -1;
            int index_lower = i_lower;
            int index_upper = i_upper;

            if (i_lower + 1 == i_upper - 1)
            {
                index = i_lower + 1; 
            }
            double median = x.ElementAt(index);

            return (Index: index, Value: median);
        }
        //==============================================================================================================

    }
}
