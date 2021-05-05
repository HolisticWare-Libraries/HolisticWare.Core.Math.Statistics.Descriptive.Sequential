using System;

namespace Core.Linq.Memory
{
    public static partial class MemoryExtensions
    {
        public static void Swap(this Memory<byte> memory, int left, int right)
        {
            byte tmp = memory.Span[left];
            memory.Span[left] = memory.Span[right];
            memory.Span[right] = tmp;

            return;
        }

        public static void Swap(this Memory<short> memory, int left, int right)
        {
            short tmp = memory.Span[left];
            memory.Span[left] = memory.Span[right];
            memory.Span[right] = tmp;

            return;
        }

        public static void Swap(this Memory<ushort> memory, int left, int right)
        {
            ushort tmp = memory.Span[left];
            memory.Span[left] = memory.Span[right];
            memory.Span[right] = tmp;

            return;
        }

        public static void Swap(this Memory<int> memory, int left, int right)
        {
            int tmp = memory.Span[left];
            memory.Span[left] = memory.Span[right];
            memory.Span[right] = tmp;

            return;
        }

        public static void Swap(this Memory<uint> memory, int left, int right)
        {
            uint tmp = memory.Span[left];
            memory.Span[left] = memory.Span[right];
            memory.Span[right] = tmp;

            return;
        }

        public static void Swap(this Memory<long> memory, int left, int right)
        {
            long tmp = memory.Span[left];
            memory.Span[left] = memory.Span[right];
            memory.Span[right] = tmp;

            return;
        }

        public static void Swap(this Memory<ulong> memory, int left, int right)
        {
            ulong tmp = memory.Span[left];
            memory.Span[left] = memory.Span[right];
            memory.Span[right] = tmp;

            return;
        }

        public static void Swap(this Memory<float> memory, int left, int right)
        {
            float tmp = memory.Span[left];
            memory.Span[left] = memory.Span[right];
            memory.Span[right] = tmp;

            return;
        }

        public static void Swap(this Memory<double> memory, int left, int right)
        {
            double tmp = memory.Span[left];
            memory.Span[left] = memory.Span[right];
            memory.Span[right] = tmp;

            return;
        }

        public static void Swap(this Memory<decimal> memory, int left, int right)
        {
            decimal tmp = memory.Span[left];
            memory.Span[left] = memory.Span[right];
            memory.Span[right] = tmp;

            return;
        }
    }
}
