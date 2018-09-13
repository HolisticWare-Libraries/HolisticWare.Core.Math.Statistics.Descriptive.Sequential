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
                                                           .OrderBy(kvp => kvp.Key)
                                                           .OrderBy(kvp => kvp.Value)
                                                           .ToDictionary(kvp => kvp.Key, kvp => kvp.Value)
                                                           ;

            Dictionary<T, uint> frequencies_cummulative = new Dictionary<T, uint>();

            uint count_cummulative = 0;

            foreach (KeyValuePair<T, uint> kvp in frequencies)
            {
                count_cummulative += kvp.Value;
                //frequencies_cummulative.Add(kvp.Key, count_cummulative);
                yield return new KeyValuePair<T, uint>(kvp.Key, count_cummulative);
            }

            // return frequencies_cummulative;
        }

        public static IEnumerable<KeyValuePair<ushort, uint>> FrequenciesCumulative
                                                                    (
                                                                        this IEnumerable<ushort> x
                                                                    )
        {
            Dictionary<ushort, uint> frequencies = x.FrequencyCounter()
                                                           .OrderBy(kvp => kvp.Key)
                                                           .OrderBy(kvp => kvp.Value)
                                                           .ToDictionary(kvp => kvp.Key, kvp => kvp.Value)
                                                           ;

            Dictionary<ushort, uint> frequencies_cummulative = new Dictionary<ushort, uint>();

            uint count_cummulative = 0;

            foreach (KeyValuePair<ushort, uint> kvp in frequencies)
            {
                count_cummulative += kvp.Value;
                //frequencies_cummulative.Add(kvp.Key, count_cummulative);
                yield return new KeyValuePair<ushort, uint>(kvp.Key, count_cummulative);
            }

            // return frequencies_cummulative;
        }

        public static IEnumerable<KeyValuePair<short, uint>> FrequenciesCumulative
                                                                    (
                                                                        this IEnumerable<short> x
                                                                    )
        {
            Dictionary<short, uint> frequencies = x.FrequencyCounter()
                                                           .OrderBy(kvp => kvp.Key)
                                                           .OrderBy(kvp => kvp.Value)
                                                           .ToDictionary(kvp => kvp.Key, kvp => kvp.Value)
                                                           ;

            Dictionary<short, uint> frequencies_cummulative = new Dictionary<short, uint>();

            uint count_cummulative = 0;

            foreach (KeyValuePair<short, uint> kvp in frequencies)
            {
                count_cummulative += kvp.Value;
                //frequencies_cummulative.Add(kvp.Key, count_cummulative);
                yield return new KeyValuePair<short, uint>(kvp.Key, count_cummulative);
            }

            // return frequencies_cummulative;
        }

        public static IEnumerable<KeyValuePair<int, uint>> FrequenciesCumulative
                                                                    (
                                                                        this IEnumerable<int> x
                                                                    )
        {
            Dictionary<int, uint> frequencies = x.FrequencyCounter()
                                                           .OrderBy(kvp => kvp.Key)
                                                           .OrderBy(kvp => kvp.Value)
                                                           .ToDictionary(kvp => kvp.Key, kvp => kvp.Value)
                                                           ;

            Dictionary<int, uint> frequencies_cummulative = new Dictionary<int, uint>();

            uint count_cummulative = 0;

            foreach (KeyValuePair<int, uint> kvp in frequencies)
            {
                count_cummulative += kvp.Value;
                //frequencies_cummulative.Add(kvp.Key, count_cummulative);
                yield return new KeyValuePair<int, uint>(kvp.Key, count_cummulative);
            }

            // return frequencies_cummulative;
        }

        public static IEnumerable<KeyValuePair<uint, uint>> FrequenciesCumulative
                                                                    (
                                                                        this IEnumerable<uint> x
                                                                    )
        {
            Dictionary<uint, uint> frequencies = x.FrequencyCounter()
                                                           .OrderBy(kvp => kvp.Key)
                                                           .OrderBy(kvp => kvp.Value)
                                                           .ToDictionary(kvp => kvp.Key, kvp => kvp.Value)
                                                           ;

            Dictionary<uint, uint> frequencies_cummulative = new Dictionary<uint, uint>();

            uint count_cummulative = 0;

            foreach (KeyValuePair<uint, uint> kvp in frequencies)
            {
                count_cummulative += kvp.Value;
                //frequencies_cummulative.Add(kvp.Key, count_cummulative);
                yield return new KeyValuePair<uint, uint>(kvp.Key, count_cummulative);
            }

            // return frequencies_cummulative;
        }

        public static IEnumerable<KeyValuePair<long, uint>> FrequenciesCumulative
                                                                    (
                                                                        this IEnumerable<long> x
                                                                    )
        {
            Dictionary<long, uint> frequencies = x.FrequencyCounter()
                                                           .OrderBy(kvp => kvp.Key)
                                                           .OrderBy(kvp => kvp.Value)
                                                           .ToDictionary(kvp => kvp.Key, kvp => kvp.Value)
                                                           ;

            Dictionary<long, uint> frequencies_cummulative = new Dictionary<long, uint>();

            uint count_cummulative = 0;

            foreach (KeyValuePair<long, uint> kvp in frequencies)
            {
                count_cummulative += kvp.Value;
                //frequencies_cummulative.Add(kvp.Key, count_cummulative);
                yield return new KeyValuePair<long, uint>(kvp.Key, count_cummulative);
            }

            // return frequencies_cummulative;
        }

        public static IEnumerable<KeyValuePair<ulong, uint>> FrequenciesCumulative
                                                                    (
                                                                        this IEnumerable<ulong> x
                                                                    )
        {
            Dictionary<ulong, uint> frequencies = x.FrequencyCounter()
                                                           .OrderBy(kvp => kvp.Key)
                                                           .OrderBy(kvp => kvp.Value)
                                                           .ToDictionary(kvp => kvp.Key, kvp => kvp.Value)
                                                           ;

            Dictionary<ulong, uint> frequencies_cummulative = new Dictionary<ulong, uint>();

            uint count_cummulative = 0;

            foreach (KeyValuePair<ulong, uint> kvp in frequencies)
            {
                count_cummulative += kvp.Value;
                //frequencies_cummulative.Add(kvp.Key, count_cummulative);
                yield return new KeyValuePair<ulong, uint>(kvp.Key, count_cummulative);
            }

            // return frequencies_cummulative;
        }

        public static IEnumerable<KeyValuePair<float, uint>> FrequenciesCumulative
                                                                    (
                                                                        this IEnumerable<float> x
                                                                    )
        {
            Dictionary<float, uint> frequencies = x.FrequencyCounter()
                                                           .OrderBy(kvp => kvp.Key)
                                                           .OrderBy(kvp => kvp.Value)
                                                           .ToDictionary(kvp => kvp.Key, kvp => kvp.Value)
                                                           ;

            Dictionary<float, uint> frequencies_cummulative = new Dictionary<float, uint>();

            uint count_cummulative = 0;

            foreach (KeyValuePair<float, uint> kvp in frequencies)
            {
                count_cummulative += kvp.Value;
                //frequencies_cummulative.Add(kvp.Key, count_cummulative);
                yield return new KeyValuePair<float, uint>(kvp.Key, count_cummulative);
            }

            // return frequencies_cummulative;
        }


        public static IEnumerable<KeyValuePair<double, uint>> FrequenciesCumulative
                                                                    (
                                                                        this IEnumerable<double> x
                                                                    )
        {
            Dictionary<double, uint> frequencies = x.FrequencyCounter()
                                                           .OrderBy(kvp => kvp.Key)
                                                           .OrderBy(kvp => kvp.Value)
                                                           .ToDictionary(kvp => kvp.Key, kvp => kvp.Value)
                                                           ;

            Dictionary<double, uint> frequencies_cummulative = new Dictionary<double, uint>();

            uint count_cummulative = 0;

            foreach (KeyValuePair<double, uint> kvp in frequencies)
            {
                count_cummulative += kvp.Value;
                //frequencies_cummulative.Add(kvp.Key, count_cummulative);
                yield return new KeyValuePair<double, uint>(kvp.Key, count_cummulative);
            }

            // return frequencies_cummulative;
        }

        public static IEnumerable<KeyValuePair<decimal, uint>> FrequenciesCumulative
                                                                    (
                                                                        this IEnumerable<decimal> x
                                                                    )
        {
            Dictionary<decimal, uint> frequencies = x.FrequencyCounter()
                                                           .OrderBy(kvp => kvp.Key)
                                                           .OrderBy(kvp => kvp.Value)
                                                           .ToDictionary(kvp => kvp.Key, kvp => kvp.Value)
                                                           ;

            Dictionary<decimal, uint> frequencies_cummulative = new Dictionary<decimal, uint>();

            uint count_cummulative = 0;

            foreach (KeyValuePair<decimal, uint> kvp in frequencies)
            {
                count_cummulative += kvp.Value;
                //frequencies_cummulative.Add(kvp.Key, count_cummulative);
                yield return new KeyValuePair<decimal, uint>(kvp.Key, count_cummulative);
            }

            // return frequencies_cummulative;
        }
        //==============================================================================================================


    }
}
