using System;
using System.Linq;

using Core.LINQ.Memory;

namespace Core.Math.Statistics.Descriptive
{
    /// <summary>
    /// Median Weighted
    /// </summary>
    /// <see href="https://en.wikipedia.org/wiki/Weighted_median"/>
    /// <see href="https://www.easycalculation.com/statistics/weighted-mean-calculator.php"/>
    /// <see href="http://mathworld.wolfram.com/PowerMean.html"/> 
    /// <see href="http://elsenaju.eu/Calculator/mean-value-calculator.htm"/>
    public static partial class MemoryExtensionsMedianWeighted
    {
        /*
        //==============================================================================================================
        /// <summary>
        /// Weighted Median
        /// </summary>
        /// <returns>Weighted median Tuple</returns>
        /// <param name="x">x data</param>
        /// <param name="weights">Weights.</param>
        /// <see href="https://www.rdocumentation.org/packages/spatstat/versions/1.55-1/topics/weighted.median"/>
        public static 
                (
                    int IndexLower, 
                    int IndexUpper, 
                    double ValueLower,
                    double ValueUpper,
                    double Median
                ) 
                            MedianWeighted
                                    (
                                        this Memory<int> x, 
                                        Memory<double> weights
                                    )
        {
           
            int n_x = x.Length;
            int n_w = weights.ToArray().Length;

            if ( n_x != n_w)
            {
                throw new InvalidOperationException("Number of elements must match");
            }

            double sum_weights = weights.Sum();
            Memory<double> weights_normalized = null;

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
                sum_lower += weights_normalized.Span[i_lower];
                sum_upper += weights_normalized.Span[i_upper];

                if (sum_lower + weights_normalized.Span[i_lower + 1] <= 0.5)
                {
                    i_lower++;
                }
                else
                {
                    advance_lower = false;
                }
                if(advance_upper == true && sum_upper + weights_normalized.Span[i_upper - 1] <= 0.5)
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
            double median = double.NaN;

            if (n_x % 2 != 0 && i_lower + 1 == i_upper - 1)
            {
                index_lower = i_lower; 
                index_upper = i_upper;
                index = index_lower + 1;
                //index = index_upper - 1;
                median = x.Span[index];
            }
            else if(n_x % 2 == 0 && i_lower + 1 == i_upper)
            {
                median = (x.Span[i_lower] + x.Span[i_upper]) / 2.0;
            }
            else
            {
                throw new InvalidOperationException("MedianWeighted Exception");
            }

            //if (x.GetType().Name.Contains("Stack"))
            //{
            //    index_lower = i_upper;
            //    index_upper = i_lower;
            //}

            double value_lower = x.Span[index_lower];
            double value_upper = x.Span[index_upper];

            return 
                (
                    IndexLower: index_lower, 
                    IndexUpper: index_upper, 
                    ValueLower: value_lower,
                    ValueUpper: value_upper,
                    Median: median
                );
        }

        public static
                (
                    int IndexLower,
                    int IndexUpper,
                    double ValueLower,
                    double ValueUpper,
                    double Median
                )
                            MedianWeighted
                                    (
                                        this Memory<double> x,
                                        Memory<double> weights
                                    )
        {

            int n_x = x.Length;
            int n_w = weights.ToArray().Length;

            if (n_x != n_w)
            {
                throw new InvalidOperationException("Number of elements must match");
            }

            double sum_weights = weights.Sum();
            Memory<double> weights_normalized = null;

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
                sum_lower += weights_normalized.Span[i_lower];
                sum_upper += weights_normalized.Span[i_upper];

                if (sum_lower + weights_normalized.Span[i_lower + 1] <= 0.5)
                {
                    i_lower++;
                }
                else
                {
                    advance_lower = false;
                }
                if (advance_upper == true && sum_upper + weights_normalized.Span[i_upper - 1] <= 0.5)
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
            double median = double.NaN;

            if ((n_x % 2 != 0) && i_lower + 1 == i_upper - 1)
            {
                index_lower = i_lower;
                index_upper = i_upper;
                index = index_lower + 1;
                //index = index_upper - 1;
                median = x.Span[index];
            }
            else if ((n_x % 2 != 0) && i_lower == i_upper)
            {
                index_lower = i_lower;
                index_upper = i_upper;
                index = index_lower;
                //index = index_upper;
                median = x.Span[index];
            }
            else if (n_x % 2 == 0 && i_lower + 1 == i_upper)
            {
                median = (x.Span[i_lower] + x.Span[i_upper]) / 2.0;
            }
            else
            {
                throw new InvalidOperationException("MedianWeighted Exception");
            }

            //if (x.GetType().Name.Contains("Stack"))
            //{
            //    index_lower = i_upper;
            //    index_upper = i_lower;
            //}

            double value_lower = x.Span[index_lower];
            double value_upper = x.Span[index_upper];

            return
                (
                    IndexLower: index_lower,
                    IndexUpper: index_upper,
                    ValueLower: value_lower,
                    ValueUpper: value_upper,
                    Median: median
                );
        }
        */
        //==============================================================================================================

    }
}
