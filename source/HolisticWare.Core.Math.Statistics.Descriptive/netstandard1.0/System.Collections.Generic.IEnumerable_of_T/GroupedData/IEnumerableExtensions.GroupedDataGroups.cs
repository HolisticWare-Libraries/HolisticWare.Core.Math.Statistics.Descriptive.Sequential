﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Math.Statistics.Descriptive
{
    /// <summary>
    /// 
    /// </summary>
    public static partial class
                                        IEnumerableExtensionsGroupedDataGroups
    {
        //==============================================================================================================
        /// <summary>
        /// 
        /// </summary>
        /// <param name="x">IEnumerable<byte></param>
        /// <returns>Dictionary<Tuple<double, double>, uint></returns>
        ///
        /// 
        /// <code>
        /// Dictionary<Tuple<double, double>, uint> result = await Task.Run(() => x.GroupedDataGroups());
        /// </code>
        /// 
        /// <code>
        /// Dictionary<Tuple<double, double>, uint> result = await x.GroupedDataGroups());
        /// </code>
        public static
            Dictionary<Tuple<double, double>, uint>
                                        GroupedDataGroups
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
