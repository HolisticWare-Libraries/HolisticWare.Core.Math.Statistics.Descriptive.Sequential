using System;

namespace Core.Linq.Memory
{
    public static partial class SpanExtensions

    {
        public static void Swap(this Span<byte> span, int left, int right)
        {
            byte tmp = span[left];
            span[left] = span[right];
            span[right] = tmp;

            return;
        }

        public static void Swap(this Span<short> span, int left, int right)
        {
            short tmp = span[left];
            span[left] = span[right];
            span[right] = tmp;

            return;
        }

        public static void Swap(this Span<ushort> span, int left, int right)
        {
            ushort tmp = span[left];
            span[left] = span[right];
            span[right] = tmp;

            return;
        }

        public static void Swap(this Span<int> span, int left, int right)
        {
            int tmp = span[left];
            span[left] = span[right];
            span[right] = tmp;

            return;
        }

        public static void Swap(this Span<uint> span, int left, int right)
        {
            uint tmp = span[left];
            span[left] = span[right];
            span[right] = tmp;

            return;
        }

        public static void Swap(this Span<long> span, int left, int right)
        {
            long tmp = span[left];
            span[left] = span[right];
            span[right] = tmp;

            return;
        }

        public static void Swap(this Span<ulong> span, int left, int right)
        {
            ulong tmp = span[left];
            span[left] = span[right];
            span[right] = tmp;

            return;
        }

        public static void Swap(this Span<float> span, int left, int right)
        {
            float tmp = span[left];
            span[left] = span[right];
            span[right] = tmp;

            return;
        }

        public static void Swap(this Span<double> span, int left, int right)
        {
            double tmp = span[left];
            span[left] = span[right];
            span[right] = tmp;

            return;
        }

        public static void Swap(this Span<decimal> span, int left, int right)
        {
            decimal tmp = span[left];
            span[left] = span[right];
            span[right] = tmp;

            return;
        }
    }
}
