using System;

namespace Core.Linq.Memory
{
    public static partial class SpanExtensions

    {
        public static byte Min(this Span<byte> span)
        {
            byte min = byte.MaxValue;
            int length = span.Length;

            for (int i = 0; i < length; i++)
            {
                byte b = span[i];
                if (b < min)
                {
                    min = b;
                }
            }

            return min;
        }

        public static double Min(this Span<short> span)
        {
            short min = short.MaxValue;
            int length = span.Length;

            for (int i = 0; i < length; i++)
            {
                short b = span[i];
                if (b < min)
                {
                    min = b;
                }
            }

            return min;
        }

        public static ushort Min(this Span<ushort> span)
        {
            ushort min = ushort.MaxValue;
            int length = span.Length;

            for (int i = 0; i < length; i++)
            {
                ushort b = span[i];
                if (b < min)
                {
                    min = b;
                }
            }

            return min;
        }

        public static int Min(this Span<int> span)
        {
            int min = int.MaxValue;
            int length = span.Length;

            for (int i = 0; i < length; i++)
            {
                int b = span[i];
                if (b < min)
                {
                    min = b;
                }
            }

            return min;
        }

        public static uint Min(this Span<uint> span)
        {
            uint min = uint.MaxValue;
            int length = span.Length;

            for (int i = 0; i < length; i++)
            {
                uint b = span[i];
                if (b < min)
                {
                    min = b;
                }
            }

            return min;
        }

        public static long Min(this Span<long> span)
        {
            long min = long.MaxValue;
            int length = span.Length;

            for (int i = 0; i < length; i++)
            {
                long b = span[i];
                if (b < min)
                {
                    min = b;
                }
            }

            return min;
        }

        public static ulong Min(this Span<ulong> span)
        {
            ulong min = ulong.MaxValue;
            int length = span.Length;

            for (int i = 0; i < length; i++)
            {
                ulong b = span[i];
                if (b < min)
                {
                    min = b;
                }
            }

            return min;
        }

        public static float Min(this Span<float> span)
        {
            float min = float.MaxValue;
            int length = span.Length;

            for (int i = 0; i < length; i++)
            {
                float b = span[i];
                if (b < min)
                {
                    min = b;
                }
            }

            return min;
        }

        public static double Min(this Span<double> span)
        {
            double min = double.MaxValue;
            int length = span.Length;

            for (int i = 0; i < length; i++)
            {
                double b = span[i];
                if (b < min)
                {
                    min = b;
                }
            }

            return min;
        }

        public static decimal Min(this Span<decimal> span)
        {
            decimal min = decimal.MaxValue;
            int length = span.Length;

            for (int i = 0; i < length; i++)
            {
                decimal b = span[i];
                if (b < min)
                {
                    min = b;
                }
            }

            return min;
        }

    }
}
