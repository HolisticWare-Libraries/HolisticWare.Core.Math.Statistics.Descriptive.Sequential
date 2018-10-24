using System;
using System.Collections.Generic;
using System.Linq;

using Core.Math.Statistics.Descriptive.Sequential;

namespace Core.Math.Statistics.Descriptive.Sequential
{
    /// <summary>
    /// </summary>
    public static partial class IEnumerableExtensionsFrequencyCounter
    {
        //==============================================================================================================
        public static
            Dictionary<T, (uint FrequencyAbsolute, double FrequencyRelative, uint FrequencyCumulative)> 
                FrequencyCounter<T>
                                (
                                    this IEnumerable<T> x
                                )
        {
            long n = x.LongCount();

            Dictionary<T, (uint FrequencyAbsolute, double FrequencyRelative, uint FrequencyCumulative)> frequencies;

            frequencies  = new Dictionary<T, (uint FrequencyAbsolute, double FrequencyRelative, uint FrequencyCumulative)>((int)n);

            for (int i = 0; i < n; i++)
            {
                T x_i = x.ElementAt(i);
                if (frequencies.ContainsKey(x_i))
                {
                    uint f_absolute = frequencies[x_i].FrequencyAbsolute + 1;
                    double f_relative = (double)f_absolute / (double)n;
                    uint f_cumulative = 0;
                    frequencies[x_i] = (FrequencyAbsolute: f_absolute, FrequencyRelative: f_relative, FrequencyCumulative: f_cumulative);
                }
                else
                {
                    uint f_absolute = 1;
                    double f_relative = (double) f_absolute / (double) n;
                    uint f_cumulative = 0;
                    frequencies.Add
                                (
                                    x_i, 
                                    (FrequencyAbsolute: f_absolute, FrequencyRelative: f_relative, FrequencyCumulative: f_cumulative)
                                );
                }
            }

            return frequencies;
        }

        public static
            Dictionary<byte, (uint FrequencyAbsolute, double FrequencyRelative, uint FrequencyCumulative)>
                FrequencyCounter
                                (
                                    this IEnumerable<byte> x
                                )
        {
            long n = x.LongCount();

            Dictionary<byte, (uint FrequencyAbsolute, double FrequencyRelative, uint FrequencyCumulative)> frequencies;

            frequencies = new Dictionary<byte, (uint FrequencyAbsolute, double FrequencyRelative, uint FrequencyCumulative)>((int)n);

            for (int i = 0; i < n; i++)
            {
                byte x_i = x.ElementAt(i);
                if (frequencies.ContainsKey(x_i))
                {
                    uint f_absolute = frequencies[x_i].FrequencyAbsolute + 1;
                    double f_relative = (double)f_absolute / (double)n;
                    uint f_cumulative = 0;
                    frequencies[x_i] = (FrequencyAbsolute: f_absolute, FrequencyRelative: f_relative, FrequencyCumulative: f_cumulative);
                }
                else
                {
                    uint f_absolute = 1;
                    double f_relative = (double)f_absolute / (double)n;
                    uint f_cumulative = 0;
                    frequencies.Add
                                (
                                    x_i,
                                    (FrequencyAbsolute: f_absolute, FrequencyRelative: f_relative, FrequencyCumulative: f_cumulative)
                                );
                }
            }

            return frequencies;
        }

        public static
            Dictionary<ushort, (uint FrequencyAbsolute, double FrequencyRelative, uint FrequencyCumulative)>
                FrequencyCounter
                                (
                                    this IEnumerable<ushort> x
                                )
        {
            long n = x.LongCount();

            Dictionary<ushort, (uint FrequencyAbsolute, double FrequencyRelative, uint FrequencyCumulative)> frequencies;

            frequencies = new Dictionary<ushort, (uint FrequencyAbsolute, double FrequencyRelative, uint FrequencyCumulative)>((int)n);

            for (int i = 0; i < n; i++)
            {
                ushort x_i = x.ElementAt(i);
                if (frequencies.ContainsKey(x_i))
                {
                    uint f_absolute = frequencies[x_i].FrequencyAbsolute + 1;
                    double f_relative = (double)f_absolute / (double)n;
                    uint f_cumulative = 0;
                    frequencies[x_i] = (FrequencyAbsolute: f_absolute, FrequencyRelative: f_relative, FrequencyCumulative: f_cumulative);
                }
                else
                {
                    uint f_absolute = 1;
                    double f_relative = (double)f_absolute / (double)n;
                    uint f_cumulative = 0;
                    frequencies.Add
                                (
                                    x_i,
                                    (FrequencyAbsolute: f_absolute, FrequencyRelative: f_relative, FrequencyCumulative: f_cumulative)
                                );
                }
            }

            return frequencies;
        }

        public static
            Dictionary<short, (uint FrequencyAbsolute, double FrequencyRelative, uint FrequencyCumulative)>
                FrequencyCounter
                                (
                                    this IEnumerable<short> x
                                )
        {
            long n = x.LongCount();

            Dictionary<short, (uint FrequencyAbsolute, double FrequencyRelative, uint FrequencyCumulative)> frequencies;

            frequencies = new Dictionary<short, (uint FrequencyAbsolute, double FrequencyRelative, uint FrequencyCumulative)>((int)n);

            for (int i = 0; i < n; i++)
            {
                short x_i = x.ElementAt(i);
                if (frequencies.ContainsKey(x_i))
                {
                    uint f_absolute = frequencies[x_i].FrequencyAbsolute + 1;
                    double f_relative = (double)f_absolute / (double)n;
                    uint f_cumulative = 0;
                    frequencies[x_i] = (FrequencyAbsolute: f_absolute, FrequencyRelative: f_relative, FrequencyCumulative: f_cumulative);
                }
                else
                {
                    uint f_absolute = 1;
                    double f_relative = (double)f_absolute / (double)n;
                    uint f_cumulative = 0;
                    frequencies.Add
                                (
                                    x_i,
                                    (FrequencyAbsolute: f_absolute, FrequencyRelative: f_relative, FrequencyCumulative: f_cumulative)
                                );
                }
            }

            return frequencies;
        }

        public static
            Dictionary<int, (uint FrequencyAbsolute, double FrequencyRelative, uint FrequencyCumulative)>
                FrequencyCounter
                                (
                                    this IEnumerable<int> x
                                )
        {
            long n = x.LongCount();

            Dictionary<int, (uint FrequencyAbsolute, double FrequencyRelative, uint FrequencyCumulative)> frequencies;

            frequencies = new Dictionary<int, (uint FrequencyAbsolute, double FrequencyRelative, uint FrequencyCumulative)>((int)n);

            for (int i = 0; i < n; i++)
            {
                int x_i = x.ElementAt(i);
                if (frequencies.ContainsKey(x_i))
                {
                    uint f_absolute = frequencies[x_i].FrequencyAbsolute + 1;
                    double f_relative = (double)f_absolute / (double)n;
                    uint f_cumulative = 0;
                    frequencies[x_i] = (FrequencyAbsolute: f_absolute, FrequencyRelative: f_relative, FrequencyCumulative: f_cumulative);
                }
                else
                {
                    uint f_absolute = 1;
                    double f_relative = (double)f_absolute / (double)n;
                    uint f_cumulative = 0;
                    frequencies.Add
                                (
                                    x_i,
                                    (FrequencyAbsolute: f_absolute, FrequencyRelative: f_relative, FrequencyCumulative: f_cumulative)
                                );
                }
            }

            return frequencies;
        }

        public static
            Dictionary<uint, (uint FrequencyAbsolute, double FrequencyRelative, uint FrequencyCumulative)>
                FrequencyCounter
                                (
                                    this IEnumerable<uint> x
                                )
        {
            long n = x.LongCount();

            Dictionary<uint, (uint FrequencyAbsolute, double FrequencyRelative, uint FrequencyCumulative)> frequencies;

            frequencies = new Dictionary<uint, (uint FrequencyAbsolute, double FrequencyRelative, uint FrequencyCumulative)>((int)n);

            for (int i = 0; i < n; i++)
            {
                uint x_i = x.ElementAt(i);
                if (frequencies.ContainsKey(x_i))
                {
                    uint f_absolute = frequencies[x_i].FrequencyAbsolute + 1;
                    double f_relative = (double)f_absolute / (double)n;
                    uint f_cumulative = 0;
                    frequencies[x_i] = (FrequencyAbsolute: f_absolute, FrequencyRelative: f_relative, FrequencyCumulative: f_cumulative);
                }
                else
                {
                    uint f_absolute = 1;
                    double f_relative = (double)f_absolute / (double)n;
                    uint f_cumulative = 0;
                    frequencies.Add
                                (
                                    x_i,
                                    (FrequencyAbsolute: f_absolute, FrequencyRelative: f_relative, FrequencyCumulative: f_cumulative)
                                );
                }
            }

            return frequencies;
        }

        public static
            Dictionary<long, (uint FrequencyAbsolute, double FrequencyRelative, uint FrequencyCumulative)>
                FrequencyCounter
                                (
                                    this IEnumerable<long> x
                                )
        {
            long n = x.LongCount();

            Dictionary<long, (uint FrequencyAbsolute, double FrequencyRelative, uint FrequencyCumulative)> frequencies;

            frequencies = new Dictionary<long, (uint FrequencyAbsolute, double FrequencyRelative, uint FrequencyCumulative)>((int)n);

            for (int i = 0; i < n; i++)
            {
                long x_i = x.ElementAt(i);
                if (frequencies.ContainsKey(x_i))
                {
                    uint f_absolute = frequencies[x_i].FrequencyAbsolute + 1;
                    double f_relative = (double)f_absolute / (double)n;
                    uint f_cumulative = 0;
                    frequencies[x_i] = (FrequencyAbsolute: f_absolute, FrequencyRelative: f_relative, FrequencyCumulative: f_cumulative);
                }
                else
                {
                    uint f_absolute = 1;
                    double f_relative = (double)f_absolute / (double)n;
                    uint f_cumulative = 0;
                    frequencies.Add
                                (
                                    x_i,
                                    (FrequencyAbsolute: f_absolute, FrequencyRelative: f_relative, FrequencyCumulative: f_cumulative)
                                );
                }
            }

            return frequencies;
        }

        public static
            Dictionary<ulong, (uint FrequencyAbsolute, double FrequencyRelative, uint FrequencyCumulative)>
                FrequencyCounter
                                (
                                    this IEnumerable<ulong> x
                                )
        {
            long n = x.LongCount();

            Dictionary<ulong, (uint FrequencyAbsolute, double FrequencyRelative, uint FrequencyCumulative)> frequencies;

            frequencies = new Dictionary<ulong, (uint FrequencyAbsolute, double FrequencyRelative, uint FrequencyCumulative)>((int)n);

            for (int i = 0; i < n; i++)
            {
                ulong x_i = x.ElementAt(i);
                if (frequencies.ContainsKey(x_i))
                {
                    uint f_absolute = frequencies[x_i].FrequencyAbsolute + 1;
                    double f_relative = (double)f_absolute / (double)n;
                    uint f_cumulative = 0;
                    frequencies[x_i] = (FrequencyAbsolute: f_absolute, FrequencyRelative: f_relative, FrequencyCumulative: f_cumulative);
                }
                else
                {
                    uint f_absolute = 1;
                    double f_relative = (double)f_absolute / (double)n;
                    uint f_cumulative = 0;
                    frequencies.Add
                                (
                                    x_i,
                                    (FrequencyAbsolute: f_absolute, FrequencyRelative: f_relative, FrequencyCumulative: f_cumulative)
                                );
                }
            }

            return frequencies;
        }

        public static
            Dictionary<float, (uint FrequencyAbsolute, double FrequencyRelative, uint FrequencyCumulative)>
                FrequencyCounter
                                (
                                    this IEnumerable<float> x
                                )
        {
            long n = x.LongCount();

            Dictionary<float, (uint FrequencyAbsolute, double FrequencyRelative, uint FrequencyCumulative)> frequencies;

            frequencies = new Dictionary<float, (uint FrequencyAbsolute, double FrequencyRelative, uint FrequencyCumulative)>((int)n);

            for (int i = 0; i < n; i++)
            {
                float x_i = x.ElementAt(i);
                if (frequencies.ContainsKey(x_i))
                {
                    uint f_absolute = frequencies[x_i].FrequencyAbsolute + 1;
                    double f_relative = (double)f_absolute / (double)n;
                    uint f_cumulative = 0;
                    frequencies[x_i] = (FrequencyAbsolute: f_absolute, FrequencyRelative: f_relative, FrequencyCumulative: f_cumulative);
                }
                else
                {
                    uint f_absolute = 1;
                    double f_relative = (double)f_absolute / (double)n;
                    uint f_cumulative = 0;
                    frequencies.Add
                                (
                                    x_i,
                                    (FrequencyAbsolute: f_absolute, FrequencyRelative: f_relative, FrequencyCumulative: f_cumulative)
                                );
                }
            }

            return frequencies;
        }

        public static
            Dictionary<double, (uint FrequencyAbsolute, double FrequencyRelative, uint FrequencyCumulative)>
                FrequencyCounter
                                (
                                    this IEnumerable<double> x
                                )
        {
            long n = x.LongCount();

            Dictionary<double, (uint FrequencyAbsolute, double FrequencyRelative, uint FrequencyCumulative)> frequencies;

            frequencies = new Dictionary<double, (uint FrequencyAbsolute, double FrequencyRelative, uint FrequencyCumulative)>((int)n);

            for (int i = 0; i < n; i++)
            {
                double x_i = x.ElementAt(i);
                if (frequencies.ContainsKey(x_i))
                {
                    uint f_absolute = frequencies[x_i].FrequencyAbsolute + 1;
                    double f_relative = (double)f_absolute / (double)n;
                    uint f_cumulative = 0;
                    frequencies[x_i] = (FrequencyAbsolute: f_absolute, FrequencyRelative: f_relative, FrequencyCumulative: f_cumulative);
                }
                else
                {
                    uint f_absolute = 1;
                    double f_relative = (double)f_absolute / (double)n;
                    uint f_cumulative = 0;
                    frequencies.Add
                                (
                                    x_i,
                                    (FrequencyAbsolute: f_absolute, FrequencyRelative: f_relative, FrequencyCumulative: f_cumulative)
                                );
                }
            }

            return frequencies;
        }

        public static
            Dictionary<decimal, (uint FrequencyAbsolute, double FrequencyRelative, uint FrequencyCumulative)>
                FrequencyCounter
                                (
                                    this IEnumerable<decimal> x
                                )
        {
            long n = x.LongCount();

            Dictionary<decimal, (uint FrequencyAbsolute, double FrequencyRelative, uint FrequencyCumulative)> frequencies;

            frequencies = new Dictionary<decimal, (uint FrequencyAbsolute, double FrequencyRelative, uint FrequencyCumulative)>((int)n);

            for (int i = 0; i < n; i++)
            {
                decimal x_i = x.ElementAt(i);
                if (frequencies.ContainsKey(x_i))
                {
                    uint f_absolute = frequencies[x_i].FrequencyAbsolute + 1;
                    double f_relative = (double)f_absolute / (double)n;
                    uint f_cumulative = 0;
                    frequencies[x_i] = (FrequencyAbsolute: f_absolute, FrequencyRelative: f_relative, FrequencyCumulative: f_cumulative);
                }
                else
                {
                    uint f_absolute = 1;
                    double f_relative = (double)f_absolute / (double)n;
                    uint f_cumulative = 0;
                    frequencies.Add
                                (
                                    x_i,
                                    (FrequencyAbsolute: f_absolute, FrequencyRelative: f_relative, FrequencyCumulative: f_cumulative)
                                );
                }
            }

            return frequencies;
        }
        //==============================================================================================================

    }
}
