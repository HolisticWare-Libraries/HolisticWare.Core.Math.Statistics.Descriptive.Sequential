using System;

namespace Core.Linq.Memory
{
    public static partial class MemoryExtensions
    {
        public static double Count<T>(this Memory<T> memory)
        {
            return memory.Span.Count();
        }

        public static double Count(this Memory<byte> memory)
        {
            return memory.Span.Count();
        }

        public static double Count(this Memory<short> memory)
        {
            return memory.Span.Count();
        }

        public static double Count(this Memory<ushort> memory)
        {
            return memory.Span.Count();
        }

        public static double Count(this Memory<int> memory)
        {
            return memory.Span.Count();
        }

        public static double Count(this Memory<uint> memory)
        {
            return memory.Span.Count();
        }

        public static double Count(this Memory<long> memory)
        {
            return memory.Span.Count();
        }

        public static double Count(this Memory<ulong> memory)
        {
            return memory.Span.Count();
        }

        public static double Count(this Memory<float> memory)
        {
            return memory.Span.Count();
        }

        public static double Count(this Memory<double> memory)
        {
            return memory.Span.Count();
        }

        public static decimal Count(this Memory<decimal> memory)
        {
            return memory.Span.Count();
        }
    }
}
