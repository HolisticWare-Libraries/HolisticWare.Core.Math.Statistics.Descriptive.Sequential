using System;
using System.Collections.Generic;
using System.Linq;

using Core.Math.Statistics.Descriptive;

namespace Core.Math.Statistics.Descriptive
{
    /// <summary>
    /// Correlation
    /// </summary>
    public static partial class IEnumerableExtensionsRange
    {
        //==============================================================================================================
        public static
            (byte Min, byte Max, byte Delta)
                                        RangeAsync
                                        (
                                            this IEnumerable<byte> x
                                        )
        {
            byte min = x.Min();
            byte max = x.Max();
            byte delta = (byte)(max - min);

            return (Min: min, Max: max, Delta: delta);
        }

        public static
            (short Min, short Max, short Delta)
                                        RangeAsync
                                        (
                                            this IEnumerable<short> x
                                        )
        {
            short min = x.Min();
            short max = x.Max();
            short delta = (short)(max - min);

            return (Min: min, Max: max, Delta: delta);
        }

        public static
            (ushort Min, ushort Max, ushort Delta)
                                        RangeAsync
                                        (
                                            this IEnumerable<ushort> x
                                        )
        {
            ushort min = x.Min();
            ushort max = x.Max();
            ushort delta = (ushort)(max - min);

            return (Min: min, Max: max, Delta: delta);
        }

        public static
            (int Min, int Max, int Delta)
                                        RangeAsync
                                        (
                                            this IEnumerable<int> x
                                        )
        {
            int min = x.Min();
            int max = x.Max();
            int delta = max - min;

            return (Min: min, Max: max, Delta: delta);
        }

        public static
            (uint Min, uint Max, uint Delta)
                                        RangeAsync
                                        (
                                            this IEnumerable<uint> x
                                        )
        {
            uint min = x.Min();
            uint max = x.Max();
            uint delta = (uint)(max - min);

            return (Min: min, Max: max, Delta: delta);
        }

        public static
            (long Min, long Max, long Delta)
                                        RangeAsync
                                        (
                                            this IEnumerable<long> x
                                        )
        {
            long min = x.Min();
            long max = x.Max();
            long delta = (long)(max - min);

            return (Min: min, Max: max, Delta: delta);
        }

        public static
            (ulong Min, ulong Max, ulong Delta)
                                        RangeAsync
                                        (
                                            this IEnumerable<ulong> x
                                        )
        {
            ulong min = x.Min();
            ulong max = x.Max();
            ulong delta = (ulong)(max - min);

            return (Min: min, Max: max, Delta: delta);
        }

        public static
            (float Min, float Max, float Delta)
                                        RangeAsync
                                        (
                                            this IEnumerable<float> x
                                        )
        {
            float min = x.Min();
            float max = x.Max();
            float delta = (float)(max - min);

            return (Min: min, Max: max, Delta: delta);
        }

        public static
            (double Min, double Max, double Delta)
                                        RangeAsync
                                        (
                                            this IEnumerable<double> x
                                        )
        {
            double min = x.Min();
            double max = x.Max();
            double delta = max - min;

            return (Min: min, Max: max, Delta: delta);
        }

        public static
            (decimal Min, decimal Max, decimal Delta)
                                        RangeAsync
                                        (
                                            this IEnumerable<decimal> x
                                        )
        {
            decimal min = x.Min();
            decimal max = x.Max();
            decimal delta = (decimal)(max - min);

            return (Min: min, Max: max, Delta: delta);
        }
        //==============================================================================================================

    }
}
