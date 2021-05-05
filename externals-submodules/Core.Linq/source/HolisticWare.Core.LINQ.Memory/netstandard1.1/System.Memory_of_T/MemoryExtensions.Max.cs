using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Core.LINQ.Memory
{
    public static partial class MemoryExtensions
    {
        public static sbyte Max(this System.Memory<sbyte> memory)
        {
            sbyte max = sbyte.MinValue;

            for(int i = 0; i < memory.Length; i++)
            {
                if (max < memory.Span[i])
                {
                    max = memory.Span[i];
                }
            }

            return max;
        }

        public static byte Max(this System.Memory<byte> memory)
        {
            byte max = byte.MinValue;

            for (int i = 0; i < memory.Length; i++)
            {
                if (max < memory.Span[i])
                {
                    max = memory.Span[i];
                }
            }

            return max;
        }

        public static ushort Max(this System.Memory<ushort> memory)
        {
            ushort max = ushort.MinValue;

            for (int i = 0; i < memory.Length; i++)
            {
                if (max < memory.Span[i])
                {
                    max = memory.Span[i];
                }
            }

            return max;
        }

        public static short Max(this System.Memory<short> memory)
        {
            short max = short.MinValue;

            for (int i = 0; i < memory.Length; i++)
            {
                if (max < memory.Span[i])
                {
                    max = memory.Span[i];
                }
            }

            return max;
        }

        public static int Max(this System.Memory<int> memory)
        {
            int max = int.MinValue;

            for (int i = 0; i < memory.Length; i++)
            {
                if (max < memory.Span[i])
                {
                    max = memory.Span[i];
                }
            }

            return max;
        }

        public static uint Max(this System.Memory<uint> memory)
        {
            uint max = uint.MinValue;

            for (int i = 0; i < memory.Length; i++)
            {
                if (max < memory.Span[i])
                {
                    max = memory.Span[i];
                }
            }

            return max;
        }

        public static long Max(this System.Memory<long> memory)
        {
            long max = long.MinValue;

            for (int i = 0; i < memory.Length; i++)
            {
                if (max < memory.Span[i])
                {
                    max = memory.Span[i];
                }
            }

            return max;
        }

        public static ulong Max(this System.Memory<ulong> memory)
        {
            ulong max = ulong.MinValue;

            for (int i = 0; i < memory.Length; i++)
            {
                if (max < memory.Span[i])
                {
                    max = memory.Span[i];
                }
            }

            return max;
        }

        public static float Max(this System.Memory<float> memory)
        {
            float max = float.MinValue;

            for (int i = 0; i < memory.Length; i++)
            {
                if (max < memory.Span[i])
                {
                    max = memory.Span[i];
                }
            }

            return max;
        }

        public static double Max(this System.Memory<double> memory)
        {
            double max = double.MinValue;

            for (int i = 0; i < memory.Length; i++)
            {
                if (max < memory.Span[i])
                {
                    max = memory.Span[i];
                }
            }

            return max;
        }

        public static decimal Max(this System.Memory<decimal> memory)
        {
            decimal max = decimal.MinValue;

            for (int i = 0; i < memory.Length; i++)
            {
                if (max < memory.Span[i])
                {
                    max = memory.Span[i];
                }
            }

            return max;
        }
    }
}
