using System;

namespace Core.Linq.Memory
{
    public static partial class MemoryExtensions
    {
        public static bool Any(this Memory<byte> memory)
        {
            return memory.Span.Length > 0;
        }

        public static bool Any(this Memory<byte> memory, Func<byte, bool> predicate)
        {
            if (predicate == null)
            {
                throw new ArgumentNullException("Predicate cannot be null!");
            }

            int n = memory.Length;
            for (int i = 0; i < n; i++)
            {
                if (predicate(memory.Span[i]))
                {
                    return true;
                }
            }

            return false;
        }

        public static bool Any(this Memory<short> memory)
        {
            return memory.Span.Length > 0;
        }

        public static bool Any(this Memory<short> memory, Func<short, bool> predicate)
        {
            if (predicate == null)
            {
                throw new ArgumentNullException("Predicate cannot be null!");
            }

            int n = memory.Length;
            for (int i = 0; i < n; i++)
            {
                if (predicate(memory.Span[i]))
                {
                    return true;
                }
            }

            return false;
        }

        public static bool Any(this Memory<ushort> memory)
        {
            return memory.Span.Length > 0;
        }

        public static bool Any(this Memory<ushort> memory, Func<ushort, bool> predicate)
        {
            if (predicate == null)
            {
                throw new ArgumentNullException("Predicate cannot be null!");
            }

            int n = memory.Length;
            for (int i = 0; i < n; i++)
            {
                if (predicate(memory.Span[i]))
                {
                    return true;
                }
            }

            return false;
        }

        public static bool Any(this Memory<int> memory)
        {
            return memory.Span.Length > 0;
        }

        public static bool Any(this Memory<int> memory, Func<int, bool> predicate)
        {
            if (predicate == null)
            {
                throw new ArgumentNullException("Predicate cannot be null!");
            }

            int n = memory.Length;
            for (int i = 0; i < n; i++)
            {
                if (predicate(memory.Span[i]))
                {
                    return true;
                }
            }

            return false;
        }

        public static bool Any(this Memory<uint> memory)
        {
            return memory.Span.Length > 0;
        }

        public static bool Any(this Memory<uint> memory, Func<uint, bool> predicate)
        {
            if (predicate == null)
            {
                throw new ArgumentNullException("Predicate cannot be null!");
            }

            int n = memory.Length;
            for (int i = 0; i < n; i++)
            {
                if (predicate(memory.Span[i]))
                {
                    return true;
                }
            }

            return false;
        }

        public static bool Any(this Memory<long> memory)
        {
            return memory.Span.Length > 0;
        }

        public static bool Any(this Memory<long> memory, Func<long, bool> predicate)
        {
            if (predicate == null)
            {
                throw new ArgumentNullException("Predicate cannot be null!");
            }

            int n = memory.Length;
            for (int i = 0; i < n; i++)
            {
                if (predicate(memory.Span[i]))
                {
                    return true;
                }
            }

            return false;
        }

        public static bool Any(this Memory<ulong> memory)
        {
            return memory.Span.Length > 0;
        }

        public static bool Any(this Memory<ulong> memory, Func<ulong, bool> predicate)
        {
            if (predicate == null)
            {
                throw new ArgumentNullException("Predicate cannot be null!");
            }

            int n = memory.Length;
            for (int i = 0; i < n; i++)
            {
                if (predicate(memory.Span[i]))
                {
                    return true;
                }
            }

            return false;
        }

        public static bool Any(this Memory<float> memory)
        {
            return memory.Span.Length > 0;
        }

        public static bool Any(this Memory<float> memory, Func<float, bool> predicate)
        {
            if (predicate == null)
            {
                throw new ArgumentNullException("Predicate cannot be null!");
            }

            int n = memory.Length;
            for (int i = 0; i < n; i++)
            {
                if (predicate(memory.Span[i]))
                {
                    return true;
                }
            }

            return false;
        }

        public static bool Any(this Memory<double> memory)
        {
            return memory.Span.Length > 0;
        }

        public static bool Any(this Memory<double> memory, Func<double, bool> predicate)
        {
            if (predicate == null)
            {
                throw new ArgumentNullException("Predicate cannot be null!");
            }

            int n = memory.Length;
            for (int i = 0; i < n; i++)
            {
                if (predicate(memory.Span[i]))
                {
                    return true;
                }
            }

            return false;
        }

        public static bool Any(this Memory<decimal> memory)
        {
            return memory.Span.Length > 0;
        }

        public static bool Any(this Memory<decimal> memory, Func<decimal, bool> predicate)
        {
            if (predicate == null)
            {
                throw new ArgumentNullException("Predicate cannot be null!");
            }

            int n = memory.Length;
            for (int i = 0; i < n; i++)
            {
                if (predicate(memory.Span[i]))
                {
                    return true;
                }
            }

            return false;
        }
    }
}
