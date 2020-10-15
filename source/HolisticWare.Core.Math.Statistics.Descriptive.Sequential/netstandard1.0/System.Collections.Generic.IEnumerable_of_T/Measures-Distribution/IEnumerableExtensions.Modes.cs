using System;
using System.Collections.Generic;
using System.Linq;

using Core.Math.Statistics.Descriptive;

namespace Core.Math.Statistics.Descriptive
{
    /// <summary>
    /// Correlation
    /// 
    /// <see 
    ///     href="https://en.wikipedia.org/wiki/Mode_(statistics)"
    ///     >
    ///     https://en.wikipedia.org/wiki/Mode_(statistics)
    /// </see>.
    /// </summary>
    public static partial class IEnumerableExtensionsFrequency
    {
        //==============================================================================================================
        public static 
            List<T> 
                Modes<T>
                    (
                        this IEnumerable<T> x
                    )
        {
            IEnumerable<KeyValuePair<T, (uint FrequencyAbsolute, double FrequencyRelative, uint FrequencyCummulative)>> frequencies;
            frequencies = x.Frequencies();

            List<T> modes = new List<T>();

            uint occurences = frequencies.FirstOrDefault().Value.FrequencyAbsolute;

            foreach (KeyValuePair<T, (uint FrequencyAbsolute, double FrequencyRelative, uint FrequencyCummulative)> kvp in frequencies)
            {
                if (occurences == kvp.Value.FrequencyAbsolute)
                {
                    modes.Add(kvp.Key);
                }
            }

            return modes;
        }

        public static 
            List<byte> 
                Modes
                    (
                        this IEnumerable<byte> x
                    )
        {
            IEnumerable<KeyValuePair<byte, (uint FrequencyAbsolute, double FrequencyRelative, uint FrequencyCummulative)>> frequencies;
            frequencies = x.Frequencies();

            List<byte> modes = new List<byte>();

            uint occurences = frequencies.FirstOrDefault().Value.FrequencyAbsolute;

            foreach (KeyValuePair<byte, (uint FrequencyAbsolute, double FrequencyRelative, uint FrequencyCummulative)> kvp in frequencies)
            {
                if (occurences == kvp.Value.FrequencyAbsolute)
                {
                    modes.Add(kvp.Key);
                }
            }

            return modes;
        }

        public static
            List<ushort>
                Modes
                    (
                        this IEnumerable<ushort> x
                    )
        {
            IEnumerable<KeyValuePair<ushort, (uint FrequencyAbsolute, double FrequencyRelative, uint FrequencyCummulative)>> frequencies;
            frequencies = x.Frequencies();

            List<ushort> modes = new List<ushort>();

            uint occurences = frequencies.FirstOrDefault().Value.FrequencyAbsolute;

            foreach (KeyValuePair<ushort, (uint FrequencyAbsolute, double FrequencyRelative, uint FrequencyCummulative)> kvp in frequencies)
            {
                if (occurences == kvp.Value.FrequencyAbsolute)
                {
                    modes.Add(kvp.Key);
                }
            }

            return modes;
        }

        public static
            List<short>
                Modes
                    (
                        this IEnumerable<short> x
                    )
        {
            IEnumerable<KeyValuePair<short, (uint FrequencyAbsolute, double FrequencyRelative, uint FrequencyCummulative)>> frequencies;
            frequencies = x.Frequencies();

            List<short> modes = new List<short>();

            uint occurences = frequencies.FirstOrDefault().Value.FrequencyAbsolute;

            foreach (KeyValuePair<short, (uint FrequencyAbsolute, double FrequencyRelative, uint FrequencyCummulative)> kvp in frequencies)
            {
                if (occurences == kvp.Value.FrequencyAbsolute)
                {
                    modes.Add(kvp.Key);
                }
            }

            return modes;
        }

        public static
            List<int>
                Modes
                    (
                        this IEnumerable<int> x
                    )
        {
            IEnumerable<KeyValuePair<int, (uint FrequencyAbsolute, double FrequencyRelative, uint FrequencyCummulative)>> frequencies;
            frequencies = x.Frequencies();

            List<int> modes = new List<int>();

            uint occurences = frequencies.FirstOrDefault().Value.FrequencyAbsolute;

            foreach (KeyValuePair<int, (uint FrequencyAbsolute, double FrequencyRelative, uint FrequencyCummulative)> kvp in frequencies)
            {
                if (occurences == kvp.Value.FrequencyAbsolute)
                {
                    modes.Add(kvp.Key);
                }
            }

            return modes;
        }

        public static
            List<uint>
                Modes
                    (
                        this IEnumerable<uint> x
                    )
        {
            IEnumerable<KeyValuePair<uint, (uint FrequencyAbsolute, double FrequencyRelative, uint FrequencyCummulative)>> frequencies;
            frequencies = x.Frequencies();

            List<uint> modes = new List<uint>();

            uint occurences = frequencies.FirstOrDefault().Value.FrequencyAbsolute;

            foreach (KeyValuePair<uint, (uint FrequencyAbsolute, double FrequencyRelative, uint FrequencyCummulative)> kvp in frequencies)
            {
                if (occurences == kvp.Value.FrequencyAbsolute)
                {
                    modes.Add(kvp.Key);
                }
            }

            return modes;
        }

        public static
            List<long>
                Modes
                    (
                        this IEnumerable<long> x
                    )
        {
            IEnumerable<KeyValuePair<long, (uint FrequencyAbsolute, double FrequencyRelative, uint FrequencyCummulative)>> frequencies;
            frequencies = x.Frequencies();

            List<long> modes = new List<long>();

            uint occurences = frequencies.FirstOrDefault().Value.FrequencyAbsolute;

            foreach (KeyValuePair<long, (uint FrequencyAbsolute, double FrequencyRelative, uint FrequencyCummulative)> kvp in frequencies)
            {
                if (occurences == kvp.Value.FrequencyAbsolute)
                {
                    modes.Add(kvp.Key);
                }
            }

            return modes;
        }

        public static
            List<ulong>
                Modes
                    (
                        this IEnumerable<ulong> x
                    )
        {
            IEnumerable<KeyValuePair<ulong, (uint FrequencyAbsolute, double FrequencyRelative, uint FrequencyCummulative)>> frequencies;
            frequencies = x.Frequencies();

            List<ulong> modes = new List<ulong>();

            uint occurences = frequencies.FirstOrDefault().Value.FrequencyAbsolute;

            foreach (KeyValuePair<ulong, (uint FrequencyAbsolute, double FrequencyRelative, uint FrequencyCummulative)> kvp in frequencies)
            {
                if (occurences == kvp.Value.FrequencyAbsolute)
                {
                    modes.Add(kvp.Key);
                }
            }

            return modes;
        }

        public static
            List<float>
                Modes
                    (
                        this IEnumerable<float> x
                    )
        {
            IEnumerable<KeyValuePair<float, (uint FrequencyAbsolute, double FrequencyRelative, uint FrequencyCummulative)>> frequencies;
            frequencies = x.Frequencies();

            List<float> modes = new List<float>();

            uint occurences = frequencies.FirstOrDefault().Value.FrequencyAbsolute;

            foreach (KeyValuePair<float, (uint FrequencyAbsolute, double FrequencyRelative, uint FrequencyCummulative)> kvp in frequencies)
            {
                if (occurences == kvp.Value.FrequencyAbsolute)
                {
                    modes.Add(kvp.Key);
                }
            }

            return modes;
        }

        public static
            List<double>
                Modes
                    (
                        this IEnumerable<double> x
                    )
        {
            IEnumerable<KeyValuePair<double, (uint FrequencyAbsolute, double FrequencyRelative, uint FrequencyCummulative)>> frequencies;
            frequencies = x.Frequencies();

            List<double> modes = new List<double>();

            uint occurences = frequencies.FirstOrDefault().Value.FrequencyAbsolute;

            foreach (KeyValuePair<double, (uint FrequencyAbsolute, double FrequencyRelative, uint FrequencyCummulative)> kvp in frequencies)
            {
                if (occurences == kvp.Value.FrequencyAbsolute)
                {
                    modes.Add(kvp.Key);
                }
            }

            return modes;
        }

        public static
            List<decimal>
                Modes
                    (
                        this IEnumerable<decimal> x
                    )
        {
            IEnumerable<KeyValuePair<decimal, (uint FrequencyAbsolute, double FrequencyRelative, uint FrequencyCummulative)>> frequencies;
            frequencies = x.Frequencies();

            List<decimal> modes = new List<decimal>();

            uint occurences = frequencies.FirstOrDefault().Value.FrequencyAbsolute;

            foreach (KeyValuePair<decimal, (uint FrequencyAbsolute, double FrequencyRelative, uint FrequencyCummulative)> kvp in frequencies)
            {
                if (occurences == kvp.Value.FrequencyAbsolute)
                {
                    modes.Add(kvp.Key);
                }
            }

            return modes;
        }
        //==============================================================================================================

        /*
        //==============================================================================================================
        #if NETSTANDARD1_3
        // [Obsolete("Performance issue (boxing)")]
        public static 
            System.Collections.ArrayList 
                Modes
                    (
                        this System.Collections.ArrayList x
                    )
        {
            IEnumerable<KeyValuePair<object, uint>> frequencies = x.Frequencies();

            System.Collections.ArrayList modes = new System.Collections.ArrayList();

            uint occurences = ((KeyValuePair<object, uint>)frequencies?.ElementAt(0)).Value;

            foreach (KeyValuePair<object, uint> kvp in frequencies)
            {
                if (occurences == kvp.Value)
                {
                    modes.Add(kvp.Key);
                }
            }

            return modes;
        }
        #endif
        //==============================================================================================================
        */
    }
}
