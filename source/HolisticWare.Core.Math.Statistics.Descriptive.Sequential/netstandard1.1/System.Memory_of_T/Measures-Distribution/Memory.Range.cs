using System;
using System.Collections.Generic;
using System.Linq;

using Core.LINQ.Memory;

namespace Core.Math.Statistics.Descriptive
{
    /// <summary>
    /// Correlation
    /// </summary>
    public static partial class IEnumerableExtensionsRange
    {
        //==============================================================================================================
        public static (byte Min, byte Max, byte Delta) Range
                                                (
                                                    this Memory<byte> x
                                                )
        {
            byte min = x.Min();
            byte max = x.Max();
			byte delta = (byte) (max - min);

			return (Min: min, Max: max, Delta: delta);
        }

        public static (short Min, short Max, short Delta) Range
                                                (
                                                    this Memory<short> x
                                                )
        {
            short min = x.Min();
            short max = x.Max();
			short delta = (short) (max - min);

            return (Min: min, Max: max, Delta: delta);
        }

        public static (ushort Min, ushort Max, ushort Delta) Range
                                                (
                                                    this Memory<ushort> x
                                                )
        {
            ushort min = x.Min();
            ushort max = x.Max();
			ushort delta = (ushort)(max - min);

            return (Min: min, Max: max, Delta: delta);
        }

        public static (int Min, int Max, int Delta) Range
                                                (
                                                    this Memory<int> x
                                                )
        {
            int min = x.Min();
            int max = x.Max();
			int delta = max - min;

            return (Min: min, Max: max, Delta: delta);
        }

        public static (uint Min, uint Max, uint Delta) Range
                                                (
                                                    this Memory<uint> x
                                                )
        {
            uint min = x.Min();
            uint max = x.Max();
			uint delta = (uint)(max - min);

            return (Min: min, Max: max, Delta: delta);
        }

        public static (long Min, long Max, long Delta) Range
                                                (
                                                    this Memory<long> x
                                                )
        {
            long min = x.Min();
            long max = x.Max();
			long delta = (long)(max - min);

            return (Min: min, Max: max, Delta: delta);
        }

        public static (ulong Min, ulong Max, ulong Delta) Range
                                                (
                                                    this Memory<ulong> x
                                                )
        {
            ulong min = x.Min();
            ulong max = x.Max();
			ulong delta = (ulong)(max - min);

            return (Min: min, Max: max, Delta: delta);
        }

        public static (float Min, float Max, float Delta) Range
                                                (
                                                    this Memory<float> x
                                                )
        {
            float min = x.Min();
            float max = x.Max();
			float delta = (float)(max - min);

            return (Min: min, Max: max, Delta: delta);
        }

        public static (double Min, double Max, double Delta) Range
                                                (
                                                    this Memory<double> x
                                                )
        {
            double min = x.Min();
            double max = x.Max();
			double delta = max - min;

            return (Min: min, Max: max, Delta: delta);
        }

        public static (decimal Min, decimal Max, decimal Delta) Range
                                                (
                                                    this Memory<decimal> x
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
