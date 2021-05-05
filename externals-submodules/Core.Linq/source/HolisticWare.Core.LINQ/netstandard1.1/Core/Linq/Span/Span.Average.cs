using System;

namespace Core.Linq.Memory
{
    public static partial class SpanExtensions

    {
        public static double Average(this Span<byte> span)
        {
            double sum = 0.0;
            int length = span.Length;

            for (int i = 0; i < length; i++)
            {
                sum += span[i];
            }

            return sum / length;
        }

        public static double Average(this Span<short> span)
        {
            double sum = 0.0;
            int length = span.Length;

            for (int i = 0; i < length; i++)
            {
                sum += span[i];
            }

            return sum / length;
        }

        public static double Average(this Span<ushort> span)
        {
            double sum = 0.0;
            int length = span.Length;

            for (int i = 0; i < length; i++)
            {
                sum += span[i];
            }

            return sum / length;
        }

        public static double Average(this Span<int> span)
        {
            double sum = 0.0;
            int length = span.Length;

            for (int i = 0; i < length; i++)
            {
                sum += span[i];
            }

            return sum / length;
        }

        public static double Average(this Span<uint> span)
        {
            double sum = 0.0;
            int length = span.Length;

            for (int i = 0; i < length; i++)
            {
                sum += span[i];
            }

            return sum / length;
        }

        public static double Average(this Span<long> span)
        {
            double sum = 0.0;
            int length = span.Length;

            for (int i = 0; i < length; i++)
            {
                sum += span[i];
            }

            return sum / length;
        }

        public static double Average(this Span<ulong> span)
        {
            double sum = 0.0;
            int length = span.Length;

            for (int i = 0; i < length; i++)
            {
                sum += span[i];
            }

            return sum / length;
        }

        public static double Average(this Span<float> span)
        {
            double sum = 0.0;
            int length = span.Length;

            for (int i = 0; i < length; i++)
            {
                sum += span[i];
            }

            return sum / length;
        }

        public static double Average(this Span<double> span)
        {
            double sum = 0.0;
            int length = span.Length;

            for (int i = 0; i < length; i++)
            {
                sum += span[i];
            }

            return sum / length;
        }

        public static decimal Average(this Span<decimal> span)
        {
            decimal sum = 0.0M;
            int length = span.Length;

            for (int i = 0; i < length; i++)
            {
                sum += span[i];
            }

            return sum / length;
        }

    }
}
