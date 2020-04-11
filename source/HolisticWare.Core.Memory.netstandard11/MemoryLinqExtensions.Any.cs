using System;

namespace Core.Memory
{
    public static partial class MemoryLinqExtensions
    {
        public static bool Any(this System.Memory<sbyte> x, Func<sbyte, bool> func)
        {
            bool any = false;

            for (int i = 0; i < x.Length; i++) 
            {
                if(func(x.Span[i]))
                {
                    return true;
                }
            }

            return any;
        }

        public static bool Any(this System.Memory<byte> x, Func<byte, bool> func)
        {
            bool any = false;

            for (int i = 0; i < x.Length; i++)
            {
                if (func(x.Span[i]))
                {
                    return true;
                }
            }

            return any;
        }

        public static bool Any(this System.Memory<short> x, Func<short, bool> func)
        {
            bool any = false;

            for (int i = 0; i < x.Length; i++)
            {
                if (func(x.Span[i]))
                {
                    return true;
                }
            }

            return any;
        }

        public static bool Any(this System.Memory<ushort> x, Func<ushort, bool> func)
        {
            bool any = false;

            for (int i = 0; i < x.Length; i++)
            {
                if (func(x.Span[i]))
                {
                    return true;
                }
            }

            return any;
        }

        public static bool Any(this System.Memory<int> x, Func<int, bool> func)
        {
            bool any = false;

            for (int i = 0; i < x.Length; i++)
            {
                if (func(x.Span[i]))
                {
                    return true;
                }
            }

            return any;
        }

        public static bool Any(this System.Memory<uint> x, Func<uint, bool> func)
        {
            bool any = false;

            for (int i = 0; i < x.Length; i++)
            {
                if (func(x.Span[i]))
                {
                    return true;
                }
            }

            return any;
        }

        public static bool Any(this System.Memory<long> x, Func<long, bool> func)
        {
            bool any = false;

            for (int i = 0; i < x.Length; i++)
            {
                if (func(x.Span[i]))
                {
                    return true;
                }
            }

            return any;
        }

        public static bool Any(this System.Memory<ulong> x, Func<ulong, bool> func)
        {
            bool any = false;

            for (int i = 0; i < x.Length; i++)
            {
                if (func(x.Span[i]))
                {
                    return true;
                }
            }

            return any;
        }

        public static bool Any(this System.Memory<float> x, Func<float, bool> func)
        {
            bool any = false;

            for (int i = 0; i < x.Length; i++)
            {
                if (func(x.Span[i]))
                {
                    return true;
                }
            }

            return any;
        }

        public static bool Any(this System.Memory<double> x, Func<double, bool> func)
        {
            bool any = false;

            for (int i = 0; i < x.Length; i++)
            {
                if (func(x.Span[i]))
                {
                    return true;
                }
            }

            return any;
        }

        public static bool Any(this System.Memory<decimal> x, Func<decimal, bool> func)
        {
            bool any = false;

            for (int i = 0; i < x.Length; i++)
            {
                if (func(x.Span[i]))
                {
                    return true;
                }
            }

            return any;
        }
    }
}
