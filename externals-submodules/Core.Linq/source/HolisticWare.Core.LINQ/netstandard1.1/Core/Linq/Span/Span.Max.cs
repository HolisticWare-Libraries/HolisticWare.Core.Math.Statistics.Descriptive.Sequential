using System;

namespace Core.Linq.Memory
{
    public static partial class SpanExtensions

    {
        public static byte Max(this Span<byte> span)
        {
            byte max = byte.MinValue;
            int length = span.Length;

            for (int i = 0; i < length; i++)
            {
                byte b = span[i];
                if (b > max)
                {
                    max = b;
                }
            }

            return max;
        }

        public static short Max(this Span<short> span)
        {
            short max = short.MinValue;
            int length = span.Length;

            for (int i = 0; i < length; i++)
            {
                short b = span[i];
                if (b > max)
                {
                    max = b;
                }
            }

            return max;
        }

        public static ushort Max(this Span<ushort> span)
        {
            ushort max = ushort.MinValue;
            int length = span.Length;

            for (int i = 0; i < length; i++)
            {
                ushort b = span[i];
                if (b > max)
                {
                    max = b;
                }
            }

            return max;
        }

        public static int Max(this Span<int> span)
        {
            int max = int.MinValue;
            int length = span.Length;

            for (int i = 0; i < length; i++)
            {
                int b = span[i];
                if (b > max)
                {
                    max = b;
                }
            }

            return max;
        }

        public static uint Max(this Span<uint> span)
        {
            uint max = uint.MinValue;
            int length = span.Length;

            for (int i = 0; i < length; i++)
            {
                uint b = span[i];
                if (b > max)
                {
                    max = b;
                }
            }

            return max;
        }

        public static long Max(this Span<long> span)
        {
            long max = long.MinValue;
            int length = span.Length;

            for (int i = 0; i < length; i++)
            {
                long b = span[i];
                if (b > max)
                {
                    max = b;
                }
            }

            return max;
        }

        public static ulong Max(this Span<ulong> span)
        {
            ulong max = ulong.MinValue;
            int length = span.Length;

            for (int i = 0; i < length; i++)
            {
                ulong b = span[i];
                if (b > max)
                {
                    max = b;
                }
            }

            return max;
        }

        public static float Max(this Span<float> span)
        {
            float max = float.MinValue;
            int length = span.Length;

            for (int i = 0; i < length; i++)
            {
                float b = span[i];
                if (b > max)
                {
                    max = b;
                }
            }

            return max;
        }

        public static double Max(this Span<double> span)
        {
            double max = double.MinValue;
            int length = span.Length;

            for (int i = 0; i < length; i++)
            {
                double b = span[i];
                if (b > max)
                {
                    max = b;
                }
            }

            return max;
        }

        public static decimal Max(this Span<decimal> span)
        {
            decimal max = decimal.MinValue;
            int length = span.Length;

            for (int i = 0; i < length; i++)
            {
                decimal b = span[i];
                if (b > max)
                {
                    max = b;
                }
            }

            return max;
        }

    }
}
