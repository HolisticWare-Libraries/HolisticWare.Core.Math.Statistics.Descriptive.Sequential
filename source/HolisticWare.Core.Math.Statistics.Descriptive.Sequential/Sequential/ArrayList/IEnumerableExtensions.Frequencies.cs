using System;
using System.Collections.Generic;
using System.Linq;

using Core.Math.Statistics.Descriptive.Sequential;


namespace Core.Math.Statistics.Descriptive.Sequential
{
    /// <summary>
    /// </summary>
    public static partial class IEnumerableExtensionsFrequencies
    {
        #if NETSTANDARD1_3
        [Obsolete("Performance issue (boxing)")]
        public static IEnumerable<KeyValuePair<object, uint>> Frequencies(this System.Collections.ArrayList x)
        {
            Dictionary<object, uint> frequencies = x.FrequencyCounter();

            IEnumerable<KeyValuePair<object, uint>> frequencies_sorted =
                from pair in frequencies
                orderby pair.Value descending
                select pair
                    ;

            return frequencies_sorted;
        }
        #endif
    }
}
