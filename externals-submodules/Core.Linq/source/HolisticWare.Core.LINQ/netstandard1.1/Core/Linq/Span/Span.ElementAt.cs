using System;

namespace Core.Linq.Memory
{
    public static partial class SpanExtensions

    {
        public static double ElementAt(this Span<byte> span, int index)
        {
            return span[index];
        }

        public static double ElementAt(this Span<short> span, int index)
        {
            return span[index];
        }

        public static double ElementAt(this Span<ushort> span, int index)
        {
            return span[index];
        }

        public static double ElementAt(this Span<int> span, int index)
        {
            return span[index];
        }

        public static double ElementAt(this Span<uint> span, int index)
        {
            return span[index];
        }

        public static double ElementAt(this Span<long> span, int index)
        {
            return span[index];
        }

        public static double ElementAt(this Span<ulong> span, int index)
        {
            return span[index];
        }

        public static double ElementAt(this Span<float> span, int index)
        {
            return span[index];
        }

        public static double ElementAt(this Span<double> span, int index)
        {
            return span[index];
        }

        public static decimal ElementAt(this Span<decimal> span, int index)
        {
            return span[index];
        }

    }
}
