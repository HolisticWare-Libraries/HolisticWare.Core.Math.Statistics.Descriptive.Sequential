using System;
using System.Collections.Generic;
using System.Linq;

using Core.Math.Statistics.Descriptive.Sequential;

namespace Core.Math.Statistics.Descriptive.Sequential
{
    /// <summary>
    /// Correlation
    /// </summary>
    public static partial class IEnumerableExtensionsFrequencyDistibution
    {
        //==============================================================================================================
        public static 
            Memory<KeyValuePair<T, (uint FrequencyAbsolute, double FrequencyRelative, uint FrequencyCummulative)>> 
                FrequencyDistribution<T>
                                    (
                                        this Memory<T> x
                                    )
        {
            Dictionary<T, (uint FrequencyAbsolute, double FrequencyRelative, uint FrequencyCummulative)> frequencies;

            frequencies = x.FrequencyCounter();

            Memory<KeyValuePair<T, (uint FrequencyAbsolute, double FrequencyRelative, uint FrequencyCummulative)>> frequencies_sorted;

            frequencies_sorted =
                                from pair in frequencies
                                    orderby pair.Key ascending
                                    select pair
                                    ;

            int n = frequencies_sorted.Count();
            int i = 0;

            uint absolute = frequencies_sorted.ElementAt(i).Value.FrequencyAbsolute;
            double relative = frequencies_sorted.ElementAt(i).Value.FrequencyRelative;
            uint cumulative = frequencies_sorted.ElementAt(i).Value.FrequencyAbsolute;

            uint sum = cumulative;

            KeyValuePair<T, (uint FrequencyAbsolute, double FrequencyRelative, uint FrequencyCumulative)> kvp;
            kvp = new KeyValuePair<T, (uint FrequencyAbsolute, double FrequencyRelative, uint FrequencyCumulative)>
                        (
                            frequencies_sorted.ElementAt(i).Key,
                            (FrequencyAbsolute: absolute, FrequencyRelative: relative, FrequencyCumulative: sum)
                        );

            yield return kvp;

            for (i = 1; i < n; i++)
            {
                absolute = frequencies_sorted.ElementAt(i).Value.FrequencyAbsolute;
                relative = frequencies_sorted.ElementAt(i).Value.FrequencyRelative;
                sum += absolute;

                kvp = new KeyValuePair<T, (uint FrequencyAbsolute, double FrequencyRelative, uint FrequencyCumulative)>
                            (
                                frequencies_sorted.ElementAt(i).Key,
                                (FrequencyAbsolute: absolute, FrequencyRelative: relative, FrequencyCumulative: sum)
                            );
                yield return kvp;
            }
        }

        public static
            Memory<KeyValuePair<byte, (uint FrequencyAbsolute, double FrequencyRelative, uint FrequencyCummulative)>>
                FrequencyDistribution
                                    (
                                        this Memory<byte> x
                                    )
        {
            Dictionary<byte, (uint FrequencyAbsolute, double FrequencyRelative, uint FrequencyCummulative)> frequencies;

            frequencies = x.FrequencyCounter();

            Memory<KeyValuePair<byte, (uint FrequencyAbsolute, double FrequencyRelative, uint FrequencyCummulative)>> frequencies_sorted;

            frequencies_sorted =
                                from pair in frequencies
                                orderby pair.Key ascending
                                select pair
                                    ;

            int n = frequencies_sorted.Count();
            int i = 0;

            uint absolute = frequencies_sorted.ElementAt(i).Value.FrequencyAbsolute;
            double relative = frequencies_sorted.ElementAt(i).Value.FrequencyRelative;
            uint cumulative = frequencies_sorted.ElementAt(i).Value.FrequencyAbsolute;

            uint sum = cumulative;

            KeyValuePair<byte, (uint FrequencyAbsolute, double FrequencyRelative, uint FrequencyCumulative)> kvp;
            kvp = new KeyValuePair<byte, (uint FrequencyAbsolute, double FrequencyRelative, uint FrequencyCumulative)>
                        (
                            frequencies_sorted.ElementAt(i).Key,
                            (FrequencyAbsolute: absolute, FrequencyRelative: relative, FrequencyCumulative: sum)
                        );

            yield return kvp;

            for (i = 1; i < n; i++)
            {
                absolute = frequencies_sorted.ElementAt(i).Value.FrequencyAbsolute;
                relative = frequencies_sorted.ElementAt(i).Value.FrequencyRelative;
                sum += absolute;

                kvp = new KeyValuePair<byte, (uint FrequencyAbsolute, double FrequencyRelative, uint FrequencyCumulative)>
                            (
                                frequencies_sorted.ElementAt(i).Key,
                                (FrequencyAbsolute: absolute, FrequencyRelative: relative, FrequencyCumulative: sum)
                            );
                yield return kvp;
            }
        }

        public static
            Memory<KeyValuePair<ushort, (uint FrequencyAbsolute, double FrequencyRelative, uint FrequencyCummulative)>>
                FrequencyDistribution
                                    (
                                        this Memory<ushort> x
                                    )
        {
            Dictionary<ushort, (uint FrequencyAbsolute, double FrequencyRelative, uint FrequencyCummulative)> frequencies;

            frequencies = x.FrequencyCounter();

            Memory<KeyValuePair<ushort, (uint FrequencyAbsolute, double FrequencyRelative, uint FrequencyCummulative)>> frequencies_sorted;

            frequencies_sorted =
                                from pair in frequencies
                                orderby pair.Key ascending
                                select pair
                                    ;

            int n = frequencies_sorted.Count();
            int i = 0;

            uint absolute = frequencies_sorted.ElementAt(i).Value.FrequencyAbsolute;
            double relative = frequencies_sorted.ElementAt(i).Value.FrequencyRelative;
            uint cumulative = frequencies_sorted.ElementAt(i).Value.FrequencyAbsolute;

            uint sum = cumulative;

            KeyValuePair<ushort, (uint FrequencyAbsolute, double FrequencyRelative, uint FrequencyCumulative)> kvp;
            kvp = new KeyValuePair<ushort, (uint FrequencyAbsolute, double FrequencyRelative, uint FrequencyCumulative)>
                        (
                            frequencies_sorted.ElementAt(i).Key,
                            (FrequencyAbsolute: absolute, FrequencyRelative: relative, FrequencyCumulative: sum)
                        );

            yield return kvp;

            for (i = 1; i < n; i++)
            {
                absolute = frequencies_sorted.ElementAt(i).Value.FrequencyAbsolute;
                relative = frequencies_sorted.ElementAt(i).Value.FrequencyRelative;
                sum += absolute;

                kvp = new KeyValuePair<ushort, (uint FrequencyAbsolute, double FrequencyRelative, uint FrequencyCumulative)>
                            (
                                frequencies_sorted.ElementAt(i).Key,
                                (FrequencyAbsolute: absolute, FrequencyRelative: relative, FrequencyCumulative: sum)
                            );
                yield return kvp;
            }
        }

        public static
            Memory<KeyValuePair<short, (uint FrequencyAbsolute, double FrequencyRelative, uint FrequencyCummulative)>>
                FrequencyDistribution
                                    (
                                        this Memory<short> x
                                    )
        {
            Dictionary<short, (uint FrequencyAbsolute, double FrequencyRelative, uint FrequencyCummulative)> frequencies;

            frequencies = x.FrequencyCounter();

            Memory<KeyValuePair<short, (uint FrequencyAbsolute, double FrequencyRelative, uint FrequencyCummulative)>> frequencies_sorted;

            frequencies_sorted =
                                from pair in frequencies
                                orderby pair.Key ascending
                                select pair
                                    ;

            int n = frequencies_sorted.Count();
            int i = 0;

            uint absolute = frequencies_sorted.ElementAt(i).Value.FrequencyAbsolute;
            double relative = frequencies_sorted.ElementAt(i).Value.FrequencyRelative;
            uint cumulative = frequencies_sorted.ElementAt(i).Value.FrequencyAbsolute;

            uint sum = cumulative;

            KeyValuePair<short, (uint FrequencyAbsolute, double FrequencyRelative, uint FrequencyCumulative)> kvp;
            kvp = new KeyValuePair<short, (uint FrequencyAbsolute, double FrequencyRelative, uint FrequencyCumulative)>
                        (
                            frequencies_sorted.ElementAt(i).Key,
                            (FrequencyAbsolute: absolute, FrequencyRelative: relative, FrequencyCumulative: sum)
                        );

            yield return kvp;

            for (i = 1; i < n; i++)
            {
                absolute = frequencies_sorted.ElementAt(i).Value.FrequencyAbsolute;
                relative = frequencies_sorted.ElementAt(i).Value.FrequencyRelative;
                sum += absolute;

                kvp = new KeyValuePair<short, (uint FrequencyAbsolute, double FrequencyRelative, uint FrequencyCumulative)>
                            (
                                frequencies_sorted.ElementAt(i).Key,
                                (FrequencyAbsolute: absolute, FrequencyRelative: relative, FrequencyCumulative: sum)
                            );
                yield return kvp;
            }
        }

        public static
            Memory<KeyValuePair<int, (uint FrequencyAbsolute, double FrequencyRelative, uint FrequencyCummulative)>>
                FrequencyDistribution
                                    (
                                        this Memory<int> x
                                    )
        {
            Dictionary<int, (uint FrequencyAbsolute, double FrequencyRelative, uint FrequencyCummulative)> frequencies;

            frequencies = x.FrequencyCounter();

            Memory<KeyValuePair<int, (uint FrequencyAbsolute, double FrequencyRelative, uint FrequencyCummulative)>> frequencies_sorted;

            frequencies_sorted =
                                from pair in frequencies
                                orderby pair.Key ascending
                                select pair
                                    ;

            int n = frequencies_sorted.Count();
            int i = 0;

            uint absolute = frequencies_sorted.ElementAt(i).Value.FrequencyAbsolute;
            double relative = frequencies_sorted.ElementAt(i).Value.FrequencyRelative;
            uint cumulative = frequencies_sorted.ElementAt(i).Value.FrequencyAbsolute;

            uint sum = cumulative;

            KeyValuePair<int, (uint FrequencyAbsolute, double FrequencyRelative, uint FrequencyCumulative)> kvp;
            kvp = new KeyValuePair<int, (uint FrequencyAbsolute, double FrequencyRelative, uint FrequencyCumulative)>
                        (
                            frequencies_sorted.ElementAt(i).Key,
                            (FrequencyAbsolute: absolute, FrequencyRelative: relative, FrequencyCumulative: sum)
                        );

            yield return kvp;

            for (i = 1; i < n; i++)
            {
                absolute = frequencies_sorted.ElementAt(i).Value.FrequencyAbsolute;
                relative = frequencies_sorted.ElementAt(i).Value.FrequencyRelative;
                sum += absolute;

                kvp = new KeyValuePair<int, (uint FrequencyAbsolute, double FrequencyRelative, uint FrequencyCumulative)>
                            (
                                frequencies_sorted.ElementAt(i).Key,
                                (FrequencyAbsolute: absolute, FrequencyRelative: relative, FrequencyCumulative: sum)
                            );
                yield return kvp;
            }
        }

        public static
            Memory<KeyValuePair<uint, (uint FrequencyAbsolute, double FrequencyRelative, uint FrequencyCummulative)>>
                FrequencyDistribution
                                    (
                                        this Memory<uint> x
                                    )
        {
            Dictionary<uint, (uint FrequencyAbsolute, double FrequencyRelative, uint FrequencyCummulative)> frequencies;

            frequencies = x.FrequencyCounter();

            Memory<KeyValuePair<uint, (uint FrequencyAbsolute, double FrequencyRelative, uint FrequencyCummulative)>> frequencies_sorted;

            frequencies_sorted =
                                from pair in frequencies
                                orderby pair.Key ascending
                                select pair
                                    ;

            int n = frequencies_sorted.Count();
            int i = 0;

            uint absolute = frequencies_sorted.ElementAt(i).Value.FrequencyAbsolute;
            double relative = frequencies_sorted.ElementAt(i).Value.FrequencyRelative;
            uint cumulative = frequencies_sorted.ElementAt(i).Value.FrequencyAbsolute;

            uint sum = cumulative;

            KeyValuePair<uint, (uint FrequencyAbsolute, double FrequencyRelative, uint FrequencyCumulative)> kvp;
            kvp = new KeyValuePair<uint, (uint FrequencyAbsolute, double FrequencyRelative, uint FrequencyCumulative)>
                        (
                            frequencies_sorted.ElementAt(i).Key,
                            (FrequencyAbsolute: absolute, FrequencyRelative: relative, FrequencyCumulative: sum)
                        );

            yield return kvp;

            for (i = 1; i < n; i++)
            {
                absolute = frequencies_sorted.ElementAt(i).Value.FrequencyAbsolute;
                relative = frequencies_sorted.ElementAt(i).Value.FrequencyRelative;
                sum += absolute;

                kvp = new KeyValuePair<uint, (uint FrequencyAbsolute, double FrequencyRelative, uint FrequencyCumulative)>
                            (
                                frequencies_sorted.ElementAt(i).Key,
                                (FrequencyAbsolute: absolute, FrequencyRelative: relative, FrequencyCumulative: sum)
                            );
                yield return kvp;
            }
        }

        public static
            Memory<KeyValuePair<long, (uint FrequencyAbsolute, double FrequencyRelative, uint FrequencyCummulative)>>
                FrequencyDistribution
                                    (
                                        this Memory<long> x
                                    )
        {
            Dictionary<long, (uint FrequencyAbsolute, double FrequencyRelative, uint FrequencyCummulative)> frequencies;

            frequencies = x.FrequencyCounter();

            Memory<KeyValuePair<long, (uint FrequencyAbsolute, double FrequencyRelative, uint FrequencyCummulative)>> frequencies_sorted;

            frequencies_sorted =
                                from pair in frequencies
                                orderby pair.Key ascending
                                select pair
                                    ;

            int n = frequencies_sorted.Count();
            int i = 0;

            uint absolute = frequencies_sorted.ElementAt(i).Value.FrequencyAbsolute;
            double relative = frequencies_sorted.ElementAt(i).Value.FrequencyRelative;
            uint cumulative = frequencies_sorted.ElementAt(i).Value.FrequencyAbsolute;

            uint sum = cumulative;

            KeyValuePair<long, (uint FrequencyAbsolute, double FrequencyRelative, uint FrequencyCumulative)> kvp;
            kvp = new KeyValuePair<long, (uint FrequencyAbsolute, double FrequencyRelative, uint FrequencyCumulative)>
                        (
                            frequencies_sorted.ElementAt(i).Key,
                            (FrequencyAbsolute: absolute, FrequencyRelative: relative, FrequencyCumulative: sum)
                        );

            yield return kvp;

            for (i = 1; i < n; i++)
            {
                absolute = frequencies_sorted.ElementAt(i).Value.FrequencyAbsolute;
                relative = frequencies_sorted.ElementAt(i).Value.FrequencyRelative;
                sum += absolute;

                kvp = new KeyValuePair<long, (uint FrequencyAbsolute, double FrequencyRelative, uint FrequencyCumulative)>
                            (
                                frequencies_sorted.ElementAt(i).Key,
                                (FrequencyAbsolute: absolute, FrequencyRelative: relative, FrequencyCumulative: sum)
                            );
                yield return kvp;
            }
        }

        public static
            Memory<KeyValuePair<ulong, (uint FrequencyAbsolute, double FrequencyRelative, uint FrequencyCummulative)>>
                FrequencyDistribution
                                    (
                                        this Memory<ulong> x
                                    )
        {
            Dictionary<ulong, (uint FrequencyAbsolute, double FrequencyRelative, uint FrequencyCummulative)> frequencies;

            frequencies = x.FrequencyCounter();

            Memory<KeyValuePair<ulong, (uint FrequencyAbsolute, double FrequencyRelative, uint FrequencyCummulative)>> frequencies_sorted;

            frequencies_sorted =
                                from pair in frequencies
                                orderby pair.Key ascending
                                select pair
                                    ;

            int n = frequencies_sorted.Count();
            int i = 0;

            uint absolute = frequencies_sorted.ElementAt(i).Value.FrequencyAbsolute;
            double relative = frequencies_sorted.ElementAt(i).Value.FrequencyRelative;
            uint cumulative = frequencies_sorted.ElementAt(i).Value.FrequencyAbsolute;

            uint sum = cumulative;

            KeyValuePair<ulong, (uint FrequencyAbsolute, double FrequencyRelative, uint FrequencyCumulative)> kvp;
            kvp = new KeyValuePair<ulong, (uint FrequencyAbsolute, double FrequencyRelative, uint FrequencyCumulative)>
                        (
                            frequencies_sorted.ElementAt(i).Key,
                            (FrequencyAbsolute: absolute, FrequencyRelative: relative, FrequencyCumulative: sum)
                        );

            yield return kvp;

            for (i = 1; i < n; i++)
            {
                absolute = frequencies_sorted.ElementAt(i).Value.FrequencyAbsolute;
                relative = frequencies_sorted.ElementAt(i).Value.FrequencyRelative;
                sum += absolute;

                kvp = new KeyValuePair<ulong, (uint FrequencyAbsolute, double FrequencyRelative, uint FrequencyCumulative)>
                            (
                                frequencies_sorted.ElementAt(i).Key,
                                (FrequencyAbsolute: absolute, FrequencyRelative: relative, FrequencyCumulative: sum)
                            );
                yield return kvp;
            }
        }

        public static
            Memory<KeyValuePair<float, (uint FrequencyAbsolute, double FrequencyRelative, uint FrequencyCummulative)>>
                FrequencyDistribution
                                    (
                                        this Memory<float> x
                                    )
        {
            Dictionary<float, (uint FrequencyAbsolute, double FrequencyRelative, uint FrequencyCummulative)> frequencies;

            frequencies = x.FrequencyCounter();

            Memory<KeyValuePair<float, (uint FrequencyAbsolute, double FrequencyRelative, uint FrequencyCummulative)>> frequencies_sorted;

            frequencies_sorted =
                                from pair in frequencies
                                orderby pair.Key ascending
                                select pair
                                    ;

            int n = frequencies_sorted.Count();
            int i = 0;

            uint absolute = frequencies_sorted.ElementAt(i).Value.FrequencyAbsolute;
            double relative = frequencies_sorted.ElementAt(i).Value.FrequencyRelative;
            uint cumulative = frequencies_sorted.ElementAt(i).Value.FrequencyAbsolute;

            uint sum = cumulative;

            KeyValuePair<float, (uint FrequencyAbsolute, double FrequencyRelative, uint FrequencyCumulative)> kvp;
            kvp = new KeyValuePair<float, (uint FrequencyAbsolute, double FrequencyRelative, uint FrequencyCumulative)>
                        (
                            frequencies_sorted.ElementAt(i).Key,
                            (FrequencyAbsolute: absolute, FrequencyRelative: relative, FrequencyCumulative: sum)
                        );

            yield return kvp;

            for (i = 1; i < n; i++)
            {
                absolute = frequencies_sorted.ElementAt(i).Value.FrequencyAbsolute;
                relative = frequencies_sorted.ElementAt(i).Value.FrequencyRelative;
                sum += absolute;

                kvp = new KeyValuePair<float, (uint FrequencyAbsolute, double FrequencyRelative, uint FrequencyCumulative)>
                            (
                                frequencies_sorted.ElementAt(i).Key,
                                (FrequencyAbsolute: absolute, FrequencyRelative: relative, FrequencyCumulative: sum)
                            );
                yield return kvp;
            }
        }

        public static
            Memory<KeyValuePair<double, (uint FrequencyAbsolute, double FrequencyRelative, uint FrequencyCummulative)>>
                FrequencyDistribution
                                    (
                                        this Memory<double> x
                                    )
        {
            Dictionary<double, (uint FrequencyAbsolute, double FrequencyRelative, uint FrequencyCummulative)> frequencies;

            frequencies = x.FrequencyCounter();

            Memory<KeyValuePair<double, (uint FrequencyAbsolute, double FrequencyRelative, uint FrequencyCummulative)>> frequencies_sorted;

            frequencies_sorted =
                                from pair in frequencies
                                orderby pair.Key ascending, pair.Value ascending
                                select pair
                                    ;

            int n = frequencies_sorted.Count();
            int i = 0;

            uint absolute = frequencies_sorted.ElementAt(i).Value.FrequencyAbsolute;
            double relative = frequencies_sorted.ElementAt(i).Value.FrequencyRelative;
            uint cumulative = frequencies_sorted.ElementAt(i).Value.FrequencyAbsolute;

            uint sum = cumulative;

            KeyValuePair<double, (uint FrequencyAbsolute, double FrequencyRelative, uint FrequencyCumulative)> kvp;
            kvp = new KeyValuePair<double, (uint FrequencyAbsolute, double FrequencyRelative, uint FrequencyCumulative)>
                        (
                            frequencies_sorted.ElementAt(i).Key,
                            (FrequencyAbsolute: absolute, FrequencyRelative: relative, FrequencyCumulative: sum)
                        );

            yield return kvp;

            for (i = 1; i < n; i++)
            {
                absolute = frequencies_sorted.ElementAt(i).Value.FrequencyAbsolute;
                relative = frequencies_sorted.ElementAt(i).Value.FrequencyRelative;
                sum += absolute;

                kvp = new KeyValuePair<double, (uint FrequencyAbsolute, double FrequencyRelative, uint FrequencyCumulative)>
                            (
                                frequencies_sorted.ElementAt(i).Key,
                                (FrequencyAbsolute: absolute, FrequencyRelative: relative, FrequencyCumulative: sum)
                            );
                yield return kvp;
            }
        }

        public static
            Memory<KeyValuePair<decimal, (uint FrequencyAbsolute, double FrequencyRelative, uint FrequencyCummulative)>>
                FrequencyDistribution
                                    (
                                        this Memory<decimal> x
                                    )
        {
            Dictionary<decimal, (uint FrequencyAbsolute, double FrequencyRelative, uint FrequencyCummulative)> frequencies;

            frequencies = x.FrequencyCounter();

            Memory<KeyValuePair<decimal, (uint FrequencyAbsolute, double FrequencyRelative, uint FrequencyCummulative)>> frequencies_sorted;

            frequencies_sorted =
                                from pair in frequencies
                                orderby pair.Key ascending
                                select pair
                                    ;

            int n = frequencies_sorted.Count();
            int i = 0;

            uint absolute = frequencies_sorted.ElementAt(i).Value.FrequencyAbsolute;
            double relative = frequencies_sorted.ElementAt(i).Value.FrequencyRelative;
            uint cumulative = frequencies_sorted.ElementAt(i).Value.FrequencyAbsolute;

            uint sum = cumulative;

            KeyValuePair<decimal, (uint FrequencyAbsolute, double FrequencyRelative, uint FrequencyCumulative)> kvp;
            kvp = new KeyValuePair<decimal, (uint FrequencyAbsolute, double FrequencyRelative, uint FrequencyCumulative)>
                        (
                            frequencies_sorted.ElementAt(i).Key,
                            (FrequencyAbsolute: absolute, FrequencyRelative: relative, FrequencyCumulative: sum)
                        );

            yield return kvp;

            for (i = 1; i < n; i++)
            {
                absolute = frequencies_sorted.ElementAt(i).Value.FrequencyAbsolute;
                relative = frequencies_sorted.ElementAt(i).Value.FrequencyRelative;
                sum += absolute;

                kvp = new KeyValuePair<decimal, (uint FrequencyAbsolute, double FrequencyRelative, uint FrequencyCumulative)>
                            (
                                frequencies_sorted.ElementAt(i).Key,
                                (FrequencyAbsolute: absolute, FrequencyRelative: relative, FrequencyCumulative: sum)
                            );
                yield return kvp;
            }
        }
        //==============================================================================================================
    }
}
