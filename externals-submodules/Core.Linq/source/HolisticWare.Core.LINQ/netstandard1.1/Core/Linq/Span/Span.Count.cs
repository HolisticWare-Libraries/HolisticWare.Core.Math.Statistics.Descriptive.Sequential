using System;

namespace Core.Linq.Memory
{
    public static partial class SpanExtensions

    {
        public static int Count<T>(this Span<T> span)
        {
            return span.Length;
        }

        public static int Count(this Span<byte> span)
        {
            return span.Length;
        }

        public static double Count(this Span<short> span)
        {
            return span.Length;
        }

        public static double Count(this Span<ushort> span)
        {
            return span.Length;
        }

        public static double Count(this Span<int> span)
        {
            return span.Length;
        }

        public static double Count(this Span<uint> span)
        {
            return span.Length;
        }

        public static double Count(this Span<long> span)
        {
            return span.Length;
        }

        public static double Count(this Span<ulong> span)
        {
            return span.Length;
        }

        public static double Count(this Span<float> span)
        {
            return span.Length;
        }

        public static double Count(this Span<double> span)
        {
            return span.Length;
        }

        public static decimal Count(this Span<decimal> span)
        {
            return span.Length;
        }

    }
}
