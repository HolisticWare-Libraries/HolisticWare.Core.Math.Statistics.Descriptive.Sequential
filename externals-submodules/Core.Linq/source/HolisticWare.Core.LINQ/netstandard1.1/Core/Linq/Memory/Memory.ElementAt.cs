using System;

namespace Core.Linq.Memory
{
    public static partial class MemoryExtensions
    {
        public static double ElementAt(this Memory<byte> memory, int index)
        {
            return memory.Span.ElementAt(index);
        }

        public static double ElementAt(this Memory<short> memory, int index)
        {
            return memory.Span.ElementAt(index);
        }

        public static double ElementAt(this Memory<ushort> memory, int index)
        {
            return memory.Span.ElementAt(index);
        }

        public static double ElementAt(this Memory<int> memory, int index)
        {
            return memory.Span.ElementAt(index);
        }

        public static double ElementAt(this Memory<uint> memory, int index)
        {
            return memory.Span.ElementAt(index);
        }

        public static double ElementAt(this Memory<long> memory, int index)
        {
            return memory.Span.ElementAt(index);
        }

        public static double ElementAt(this Memory<ulong> memory, int index)
        {
            return memory.Span.ElementAt(index);
        }

        public static double ElementAt(this Memory<float> memory, int index)
        {
            return memory.Span.ElementAt(index);
        }

        public static double ElementAt(this Memory<double> memory, int index)
        {
            return memory.Span.ElementAt(index);
        }

        public static decimal ElementAt(this Memory<decimal> memory, int index)
        {
            return memory.Span.ElementAt(index);
        }
    }
}
