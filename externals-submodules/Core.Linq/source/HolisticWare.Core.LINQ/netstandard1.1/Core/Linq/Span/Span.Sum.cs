using System;

namespace Core.Linq.Memory
{
    public static partial class SpanExtensions

    {
        public static long Sum(this Span<byte> span)
        {
            long sum = 0;
            int length = span.Length;

            for (int i = 0; i < length; i++)
            {
                sum += span[i];
            }

            return sum;
        }

        public static long Sum(this Span<short> span)
        {
            long sum = 0;
            int length = span.Length;

            for (int i = 0; i < length; i++)
            {
                sum += span[i];
            }

            return sum;
        }

        public static long Sum(this Span<ushort> span)
        {
            long sum = 0;
            int length = span.Length;

            for (int i = 0; i < length; i++)
            {
                sum += span[i];
            }

            return sum;
        }

        public static long Sum(this Span<int> span)
        {
            long sum = 0;
            int length = span.Length;

            for (int i = 0; i < length; i++)
            {
                sum += span[i];
            }

            return sum;
        }

        public static long Sum(this Span<uint> span)
        {
            long sum = 0;
            int length = span.Length;

            for (int i = 0; i < length; i++)
            {
                sum += span[i];
            }

            return sum;
        }

        public static long Sum(this Span<long> span)
        {
            long sum = 0;
            int length = span.Length;

            for (int i = 0; i < length; i++)
            {
                sum += span[i];
            }

            return sum;
        }

        public static ulong Sum(this Span<ulong> span)
        {
            ulong sum = 0;
            int length = span.Length;

            for (int i = 0; i < length; i++)
            {
                sum += span[i];
            }

            return sum;
        }

        public static double Sum(this Span<float> span)
        {
            double sum = 0.0;
            int length = span.Length;

            for (int i = 0; i < length; i++)
            {
                sum += span[i];
            }

            return sum;
        }

        public static double Sum(this Span<double> span)
        {
            double sum = 0.0;
            int length = span.Length;

            for (int i = 0; i < length; i++)
            {
                sum += span[i];
            }

            return sum;
        }

        public static decimal Sum(this Span<decimal> span)
        {
            decimal sum = 0.0M;
            int length = span.Length;

            for (int i = 0; i < length; i++)
            {
                sum += span[i];
            }

            return sum;
        }

    }
}
