using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

using Core.Math.Statistics.Descriptive;

namespace Core.Math.Statistics.Descriptive
{
    /// <summary>
    /// Satistics class representing summary Descriptive Statistics for IEnumerable<typeparamref name="T"/>>
    /// </summary>
    /// <example>
    /// </example>
    public partial class
                                        StatisticsDescriptive
    {
        public
            IEnumerable<T>
                                        DataMissing<T>
                                        (
                                            IEnumerable<T?> input, 
                                            Dictionary<T?, T>? data_fixes_map = null
                                        ) 
            where T : struct
        {
            return new List<T>() { }.ToArray();
        }
        
        public
            IEnumerable<byte?>
                                        DataMissing
                                        (
                                        )
        {
            return new List<byte?>() { null };
        }

    }
}
