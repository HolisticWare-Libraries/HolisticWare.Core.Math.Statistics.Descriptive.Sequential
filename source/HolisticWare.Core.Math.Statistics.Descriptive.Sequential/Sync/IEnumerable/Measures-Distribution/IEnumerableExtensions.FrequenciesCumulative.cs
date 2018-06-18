using System;
using System.Collections.Generic;
using System.Linq;

using Core.Math.Statistics.Descriptive.Sequential;

namespace Core.Math.Statistics.Descriptive.Sequential
{
    /// <summary>
    /// </summary>
    public static partial class IEnumerableExtensionsFrequenciesCumulative
    {
        //==============================================================================================================
        public static IEnumerable<KeyValuePair<T, uint>> FrequenciesCumulative<T>
                                                                    (
                                                                        this IEnumerable<T> x
                                                                    )
        {
            Dictionary<T, uint> frequencies = x.FrequencyCounter()
                                                           .OrderBy(k => k.Key)
                                                           .OrderBy(Version => Version.Value)
                                                           .ToDictionary(kvp => kvp.Key, kvp => kvp.Value)
                                                           ;

            uint count_cummulative = 0;

            foreach (KeyValuePair<T, uint> kvp in frequencies)
            {
                count_cummulative += kvp.Value;
                frequencies[kvp.Key] = count_cummulative;
            }

            return frequencies;
        }

        public static IEnumerable<KeyValuePair<ushort, uint>> FrequenciesCumulative
                                                                    (
                                                                        this IEnumerable<ushort> x
                                                                    )
        {
            Dictionary<ushort, uint> frequencies = x.FrequencyCounter()
                                                           .OrderBy(k => k.Key)
                                                           .OrderBy(Version => Version.Value)
                                                           .ToDictionary(kvp => kvp.Key, kvp => kvp.Value)
                                                           ;

            uint count_cummulative = 0;

            foreach (KeyValuePair<ushort, uint> kvp in frequencies)
            {
                count_cummulative += kvp.Value;
                frequencies[kvp.Key] = count_cummulative;
            }

            return frequencies;
        }

        public static IEnumerable<KeyValuePair<short, uint>> FrequenciesCumulative
                                                                    (
                                                                        this IEnumerable<short> x
                                                                    )
        {
            Dictionary<short, uint> frequencies = x.FrequencyCounter()
                                                           .OrderBy(k => k.Key)
                                                           .OrderBy(Version => Version.Value)
                                                           .ToDictionary(kvp => kvp.Key, kvp => kvp.Value)
                                                           ;

            uint count_cummulative = 0;

            foreach (KeyValuePair<short, uint> kvp in frequencies)
            {
                count_cummulative += kvp.Value;
                frequencies[kvp.Key] = count_cummulative;
            }

            return frequencies;
        }

        public static IEnumerable<KeyValuePair<int, uint>> FrequenciesCumulative
                                                                    (
                                                                        this IEnumerable<int> x
                                                                    )
        {
            Dictionary<int, uint> frequencies = x.FrequencyCounter()
                                                           .OrderBy(k => k.Key)
                                                           .OrderBy(Version => Version.Value)
                                                           .ToDictionary(kvp => kvp.Key, kvp => kvp.Value)
                                                           ;

            uint count_cummulative = 0;

            foreach (KeyValuePair<int, uint> kvp in frequencies)
            {
                count_cummulative += kvp.Value;
                frequencies[kvp.Key] = count_cummulative;
            }

            return frequencies;
        }

        public static IEnumerable<KeyValuePair<uint, uint>> FrequenciesCumulative
                                                                    (
                                                                        this IEnumerable<uint> x
                                                                    )
        {
            Dictionary<uint, uint> frequencies = x.FrequencyCounter()
                                                           .OrderBy(k => k.Key)
                                                           .OrderBy(Version => Version.Value)
                                                           .ToDictionary(kvp => kvp.Key, kvp => kvp.Value)
                                                           ;

            uint count_cummulative = 0;

            foreach (KeyValuePair<uint, uint> kvp in frequencies)
            {
                count_cummulative += kvp.Value;
                frequencies[kvp.Key] = count_cummulative;
            }

            return frequencies;
        }

        public static IEnumerable<KeyValuePair<long, uint>> FrequenciesCumulative
                                                                    (
                                                                        this IEnumerable<long> x
                                                                    )
        {
            Dictionary<long, uint> frequencies = x.FrequencyCounter()
                                                           .OrderBy(k => k.Key)
                                                           .OrderBy(Version => Version.Value)
                                                           .ToDictionary(kvp => kvp.Key, kvp => kvp.Value)
                                                           ;

            uint count_cummulative = 0;

            foreach (KeyValuePair<long, uint> kvp in frequencies)
            {
                count_cummulative += kvp.Value;
                frequencies[kvp.Key] = count_cummulative;
            }

            return frequencies;
        }

        public static IEnumerable<KeyValuePair<ulong, uint>> FrequenciesCumulative
                                                                    (
                                                                        this IEnumerable<ulong> x
                                                                    )
        {
            Dictionary<ulong, uint> frequencies = x.FrequencyCounter()
                                                           .OrderBy(k => k.Key)
                                                           .OrderBy(Version => Version.Value)
                                                           .ToDictionary(kvp => kvp.Key, kvp => kvp.Value)
                                                           ;

            uint count_cummulative = 0;

            foreach (KeyValuePair<ulong, uint> kvp in frequencies)
            {
                count_cummulative += kvp.Value;
                frequencies[kvp.Key] = count_cummulative;
            }

            return frequencies;
        }

        public static IEnumerable<KeyValuePair<float, uint>> FrequenciesCumulative
                                                                    (
                                                                        this IEnumerable<float> x
                                                                    )
        {
            Dictionary<float, uint> frequencies = x.FrequencyCounter()
                                                           .OrderBy(k => k.Key)
                                                           .OrderBy(Version => Version.Value)
                                                           .ToDictionary(kvp => kvp.Key, kvp => kvp.Value)
                                                           ;

            uint count_cummulative = 0;

            foreach (KeyValuePair<float, uint> kvp in frequencies)
            {
                count_cummulative += kvp.Value;
                frequencies[kvp.Key] = count_cummulative;
            }

            return frequencies;
        }


        public static IEnumerable<KeyValuePair<double, uint>> FrequenciesCumulative
                                                                    (
                                                                        this IEnumerable<double> x
                                                                    )
        {
            Dictionary<double, uint> frequencies = x.FrequencyCounter()
                                                           .OrderBy(k => k.Key)
                                                           .OrderBy(Version => Version.Value)
                                                           .ToDictionary(kvp => kvp.Key, kvp => kvp.Value)
                                                           ;

            uint count_cummulative = 0;

            foreach (KeyValuePair<double, uint> kvp in frequencies)
            {
                count_cummulative += kvp.Value;
                frequencies[kvp.Key] = count_cummulative;
            }

            return frequencies;
        }

        public static IEnumerable<KeyValuePair<decimal, uint>> FrequenciesCumulative
                                                                    (
                                                                        this IEnumerable<decimal> x
                                                                    )
        {
            Dictionary<decimal, uint> frequencies = x.FrequencyCounter()
                                                           .OrderBy(k => k.Key)
                                                           .OrderBy(Version => Version.Value)
                                                           .ToDictionary(kvp => kvp.Key, kvp => kvp.Value)
                                                           ;

            uint count_cummulative = 0;

            foreach (KeyValuePair<decimal, uint> kvp in frequencies)
            {
                count_cummulative += kvp.Value;
                frequencies[kvp.Key] = count_cummulative;
            }

            return frequencies;
        }
        //==============================================================================================================


    }
}
