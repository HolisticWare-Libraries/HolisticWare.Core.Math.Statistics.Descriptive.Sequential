using System;

namespace Core.LINQ.Memory
{
    public static partial class MemoryExtensions
    {
        public static sbyte Sum(this System.Memory<sbyte> m)
        {
            Span<sbyte> s = m.Span;
            sbyte sum = 0;

            for (int i = 0; i < s.Length; i++)
            {
                sum += s[i];
            }

            return sum;
        }

        public static byte Sum(this System.Memory<byte> m)
        {
            Span<byte> s = m.Span;
            byte sum = 0;

            for (int i = 0; i < s.Length; i++)
            {
                sum += s[i];
            }

            return sum;
        }

        public static short Sum(this System.Memory<short> m)
        {
            Span<short> s = m.Span;
            short sum = 0;

            for (int i = 0; i < s.Length; i++)
            {
                sum += s[i];
            }

            return sum;
        }

        public static ushort Sum(this System.Memory<ushort> m)
        {
            Span<ushort> s = m.Span;
            ushort sum = 0;

            for (int i = 0; i < s.Length; i++)
            {
                sum += s[i];
            }

            return sum;
        }

        public static int Sum(this System.Memory<int> m)
        {
            Span<int> s = m.Span;
            int sum = 0;

            for (int i = 0; i < s.Length; i++)
            {
                sum += s[i];
            }

            return sum;
        }

        public static uint Sum(this System.Memory<uint> m)
        {
            Span<uint> s = m.Span;
            uint sum = 0;

            for (int i = 0; i < s.Length; i++)
            {
                sum += s[i];
            }

            return sum;
        }

        public static long Sum(this System.Memory<long> m)
        {
            Span<long> s = m.Span;
            long sum = 0;

            for (int i = 0; i < s.Length; i++)
            {
                sum += s[i];
            }

            return sum;
        }

        public static ulong Sum(this System.Memory<ulong> m)
        {
            Span<ulong> s = m.Span;
            ulong sum = 0;

            for (int i = 0; i < s.Length; i++)
            {
                sum += s[i];
            }

            return sum;
        }

        public static float Sum(this System.Memory<float> m)
        {
            Span<float> s = m.Span;
            float sum = 0;

            for (int i = 0; i < s.Length; i++)
            {
                sum += s[i];
            }

            return sum;
        }

        public static double Sum(this System.Memory<double> m)
        {
            Span<double> s = m.Span;
            double sum = 0;

            for (int i = 0; i < s.Length; i++)
            {
                sum += s[i];
            }

            return sum;
        }

        public static decimal Sum(this System.Memory<decimal> m)
        {
            Span<decimal> s = m.Span;
            decimal sum = 0;

            for (int i = 0; i < s.Length; i++)
            {
                sum += s[i];
            }

            return sum;
        }
    }
}
