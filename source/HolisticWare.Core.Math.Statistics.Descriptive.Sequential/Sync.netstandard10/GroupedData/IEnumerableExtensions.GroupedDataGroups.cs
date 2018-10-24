using System;
using System.Collections.Generic;
using System.Linq;

namespace Core.Math.Statistics.Descriptive.Sequential
{
    /// <summary>
    /// 
    /// </summary>
    public static partial class IEnumerableExtensionsGroupedDataGroups
    {
        //==============================================================================================================
        public static Dictionary<Tuple<double, double>, uint> GroupedDataGroups
                                (
                                    this IEnumerable<byte> x
                                )
        {
            int n = x.Count();
            IOrderedEnumerable<byte> x_ordered = x.OrderBy(x_i => x_i);
            int n2 = n / 2 - 1;

            Dictionary<Tuple<double, double>, uint> grouped_data_frequencies = null;

            return grouped_data_frequencies;
        }

        //==============================================================================================================

    }
}
