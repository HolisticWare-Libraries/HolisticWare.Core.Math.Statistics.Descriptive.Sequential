using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Core.LINQ.Memory
{
    public static partial class MemoryExtensions
    {
        public static double Average(this System.Memory<sbyte> memory)
        {
            int sum = 0;

            for(int i = 0; i < memory.Length; i++)
            {
                sum += memory.Span[i];
            }

            return sum / memory.Length;
        }

        public static double Average(this System.Memory<byte> memory)
        {
            int sum = 0;

            for (int i = 0; i < memory.Length; i++)
            {
                sum += memory.Span[i];
            }

            return sum / memory.Length;
        }

        public static double Average(this System.Memory<ushort> memory)
        {
            int sum = 0;

            for (int i = 0; i < memory.Length; i++)
            {
                sum += memory.Span[i];
            }

            return sum / memory.Length;
        }

        public static double Average(this System.Memory<short> memory)
        {
            int sum = 0;

            for (int i = 0; i < memory.Length; i++)
            {
                sum += memory.Span[i];
            }

            return sum / memory.Length;
        }

        public static double Average(this System.Memory<int> memory)
        {
            double sum = 0;

            for (int i = 0; i < memory.Length; i++)
            {
                sum += memory.Span[i];
            }

            return sum / memory.Length;
        }

        public static double Average(this System.Memory<uint> memory)
        {
            double sum = 0;

            for (int i = 0; i < memory.Length; i++)
            {
                sum += memory.Span[i];
            }

            return sum / memory.Length;
        }

        public static double Average(this System.Memory<long> memory)
        {
            double sum = 0;

            for (int i = 0; i < memory.Length; i++)
            {
                sum += memory.Span[i];
            }

            return sum / memory.Length;
        }

        public static double Average(this System.Memory<ulong> memory)
        {
            double sum = 0;

            for (int i = 0; i < memory.Length; i++)
            {
                sum += memory.Span[i];
            }

            return sum / memory.Length;
        }

        public static double Average(this System.Memory<float> memory)
        {
            float sum = 0;

            for (int i = 0; i < memory.Length; i++)
            {
                sum += memory.Span[i];
            }

            return sum / memory.Length;
        }

        public static double Average(this System.Memory<double> memory)
        {
            double sum = 0;

            for (int i = 0; i < memory.Length; i++)
            {
                sum += memory.Span[i];
            }

            return sum / memory.Length;
        }

        public static decimal Average(this System.Memory<decimal> memory)
        {
            decimal sum = 0M;

            for (int i = 0; i < memory.Length; i++)
            {
                sum += memory.Span[i];
            }

            return sum / memory.Length;
        }
    }
}
