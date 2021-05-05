using System;

namespace Core.Linq.Memory
{
    public static partial class MemoryExtensions
    {
        public static double Max(this Memory<byte> memory)
        {
            return memory.Span.Max();
        }

        public static double Max(this Memory<short> memory)
        {
            return memory.Span.Max();
        }

        public static double Max(this Memory<ushort> memory)
        {
            return memory.Span.Max();
        }

        public static double Max(this Memory<int> memory)
        {
            return memory.Span.Max();
        }

        public static double Max(this Memory<uint> memory)
        {
            return memory.Span.Max();
        }

        public static double Max(this Memory<long> memory)
        {
            return memory.Span.Max();
        }

        public static double Max(this Memory<ulong> memory)
        {
            return memory.Span.Max();
        }

        public static double Max(this Memory<float> memory)
        {
            return memory.Span.Max();
        }

        public static double Max(this Memory<double> memory)
        {
            return memory.Span.Max();
        }

        public static decimal Max(this Memory<decimal> memory)
        {
            return memory.Span.Max();
        }
    }
}
