using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Core.LINQ.Memory
{
    public static partial class MemoryExtensions
    {
        public static sbyte Min(this System.Memory<sbyte> memory)
        {
            sbyte min = sbyte.MaxValue;

            for(int i = 0; i < memory.Length; i++)
            {
                if (min > memory.Span[i])
                {
                    min = memory.Span[i];
                }
            }

            return min;
        }

        public static byte Min(this System.Memory<byte> memory)
        {
            byte min = byte.MaxValue;

            for (int i = 0; i < memory.Length; i++)
            {
                if (min > memory.Span[i])
                {
                    min = memory.Span[i];
                }
            }

            return min;
        }

        public static ushort Min(this System.Memory<ushort> memory)
        {
            ushort min = ushort.MaxValue;

            for (int i = 0; i < memory.Length; i++)
            {
                if (min > memory.Span[i])
                {
                    min = memory.Span[i];
                }
            }

            return min;
        }

        public static short Min(this System.Memory<short> memory)
        {
            short min = short.MaxValue;

            for (int i = 0; i < memory.Length; i++)
            {
                if (min > memory.Span[i])
                {
                    min = memory.Span[i];
                }
            }

            return min;
        }

        public static int Min(this System.Memory<int> memory)
        {
            int min = int.MaxValue;

            for (int i = 0; i < memory.Length; i++)
            {
                if (min > memory.Span[i])
                {
                    min = memory.Span[i];
                }
            }

            return min;
        }

        public static uint Min(this System.Memory<uint> memory)
        {
            uint min = uint.MaxValue;

            for (int i = 0; i < memory.Length; i++)
            {
                if (min > memory.Span[i])
                {
                    min = memory.Span[i];
                }
            }

            return min;
        }

        public static long Min(this System.Memory<long> memory)
        {
            long min = long.MaxValue;

            for (int i = 0; i < memory.Length; i++)
            {
                if (min > memory.Span[i])
                {
                    min = memory.Span[i];
                }
            }

            return min;
        }

        public static ulong Min(this System.Memory<ulong> memory)
        {
            ulong min = ulong.MaxValue;

            for (int i = 0; i < memory.Length; i++)
            {
                if (min > memory.Span[i])
                {
                    min = memory.Span[i];
                }
            }

            return min;
        }

        public static float Min(this System.Memory<float> memory)
        {
            float min = float.MaxValue;

            for (int i = 0; i < memory.Length; i++)
            {
                if (min > memory.Span[i])
                {
                    min = memory.Span[i];
                }
            }

            return min;
        }

        public static double Min(this System.Memory<double> memory)
        {
            double min = double.MaxValue;

            for (int i = 0; i < memory.Length; i++)
            {
                if (min > memory.Span[i])
                {
                    min = memory.Span[i];
                }
            }

            return min;
        }

        public static decimal Min(this System.Memory<decimal> memory)
        {
            decimal min = decimal.MaxValue;

            for (int i = 0; i < memory.Length; i++)
            {
                if (min > memory.Span[i])
                {
                    min = memory.Span[i];
                }
            }

            return min;
        }
    }
}
