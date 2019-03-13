using System;
using System.Collections.Generic;
using System.Linq;

using Core.Math.Statistics.Descriptive.Sequential;

namespace Core.Math.Statistics.Descriptive.Sequential
{
    /// <summary>
    /// Correlation
    /// </summary>
    public static partial class IEnumerableExtensionsRange
    {
        //==============================================================================================================
        public static (byte Min, byte Max, byte Delta) Range
                                                (
                                                    this IEnumerable<byte> x
                                                )
        {
            byte min = x.Min();
            byte max = x.Max();
			byte delta = (byte) (max - min);

			return (Min: min, Max: max, Delta: delta);
        }

        public static (short Min, short Max, short Delta) Range
                                                (
                                                    this IEnumerable<short> x
                                                )
        {
            short min = x.Min();
            short max = x.Max();
			short delta = (short) (max - min);

            return (Min: min, Max: max, Delta: delta);
        }

        public static (ushort Min, ushort Max, ushort Delta) Range
                                                (
                                                    this IEnumerable<ushort> x
                                                )
        {
            ushort min = x.Min();
            ushort max = x.Max();
			ushort delta = (ushort)(max - min);

            return (Min: min, Max: max, Delta: delta);
        }

        public static (int Min, int Max, int Delta) Range
                                                (
                                                    this IEnumerable<int> x
                                                )
        {
            int min = x.Min();
            int max = x.Max();
			int delta = max - min;

            return (Min: min, Max: max, Delta: delta);
        }

        public static (uint Min, uint Max, uint Delta) Range
                                                (
                                                    this IEnumerable<uint> x
                                                )
        {
            uint min = x.Min();
            uint max = x.Max();
			uint delta = (uint)(max - min);

            return (Min: min, Max: max, Delta: delta);
        }

        public static (long Min, long Max, long Delta) Range
                                                (
                                                    this IEnumerable<long> x
                                                )
        {
            long min = x.Min();
            long max = x.Max();
			long delta = (long)(max - min);

            return (Min: min, Max: max, Delta: delta);
        }

        public static (ulong Min, ulong Max, ulong Delta) Range
                                                (
                                                    this IEnumerable<ulong> x
                                                )
        {
            ulong min = x.Min();
            ulong max = x.Max();
			ulong delta = (ulong)(max - min);

            return (Min: min, Max: max, Delta: delta);
        }

        public static (float Min, float Max, float Delta) Range
                                                (
                                                    this IEnumerable<float> x
                                                )
        {
            float min = x.Min();
            float max = x.Max();
			float delta = (float)(max - min);

            return (Min: min, Max: max, Delta: delta);
        }

        public static (double Min, double Max, double Delta) Range
                                                (
                                                    this IEnumerable<double> x
                                                )
        {
            double min = x.Min();
            double max = x.Max();
			double delta = max - min;

            return (Min: min, Max: max, Delta: delta);
        }

        public static (decimal Min, decimal Max, decimal Delta) Range
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
