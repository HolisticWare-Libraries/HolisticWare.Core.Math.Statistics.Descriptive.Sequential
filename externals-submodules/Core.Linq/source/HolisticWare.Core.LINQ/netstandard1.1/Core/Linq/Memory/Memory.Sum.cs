using System;

namespace Core.Linq.Memory
{
    public static partial class MemoryExtensions
    {
        public static double Sum(this Memory<byte> memory)
        {
            return memory.Span.Sum();
        }

        public static double Sum(this Memory<short> memory)
        {
            return memory.Span.Sum();
        }

        public static double Sum(this Memory<ushort> memory)
        {
            return memory.Span.Sum();
        }

        public static double Sum(this Memory<int> memory)
        {
            return memory.Span.Sum();
        }

        public static double Sum(this Memory<uint> memory)
        {
            return memory.Span.Sum();
        }

        public static double Sum(this Memory<long> memory)
        {
            return memory.Span.Sum();
        }

        public static double Sum(this Memory<ulong> memory)
        {
            return memory.Span.Sum();
        }

        public static double Sum(this Memory<float> memory)
        {
            return memory.Span.Sum();
        }

        public static double Sum(this Memory<double> memory)
        {
            return memory.Span.Sum();
        }

        public static decimal Sum(this Memory<decimal> memory)
        {
            return memory.Span.Sum();
        }
    }
}
