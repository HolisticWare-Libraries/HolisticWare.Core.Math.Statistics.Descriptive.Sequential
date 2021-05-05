using System;

namespace Core.Linq.Memory
{
    public static partial class MemoryExtensions
    {
        public static double Average(this Memory<byte> memory)
        {
            return memory.Span.Average();
        }

        public static double Average(this Memory<short> memory)
        {
            return memory.Span.Average();
        }

        public static double Average(this Memory<ushort> memory)
        {
            return memory.Span.Average();
        }

        public static double Average(this Memory<int> memory)
        {
            return memory.Span.Average();
        }

        public static double Average(this Memory<uint> memory)
        {
            return memory.Span.Average();
        }

        public static double Average(this Memory<long> memory)
        {
            return memory.Span.Average();
        }

        public static double Average(this Memory<ulong> memory)
        {
            return memory.Span.Average();
        }

        public static double Average(this Memory<float> memory)
        {
            return memory.Span.Average();
        }

        public static double Average(this Memory<double> memory)
        {
            return memory.Span.Average();
        }

        public static decimal Average(this Memory<decimal> memory)
        {
            return memory.Span.Average();
        }
    }
}
