using System;

namespace Core.Linq.Memory
{
    public static partial class SpanExtensions
    {
        public static bool Any(this Span<byte> span)
        {
            return span.Length > 0;
        }

        public static bool Any(this Span<byte> span, Func<byte, bool> predicate)
        {
            if (predicate == null)
            {
                throw new ArgumentNullException("Predicate cannot be null!");
            }

            int n = span.Length;
            for (int i = 0; i < n; i++)
            {
                if (predicate(span[i]))
                {
                    return true;
                }
            }

            return false;
        }

        public static bool Any(this Span<short> span)
        {
            return span.Length > 0;
        }

        public static bool Any(this Span<short> span, Func<short, bool> predicate)
        {
            if (predicate == null)
            {
                throw new ArgumentNullException("Predicate cannot be null!");
            }

            int n = span.Length;
            for (int i = 0; i < n; i++)
            {
                if (predicate(span[i]))
                {
                    return true;
                }
            }

            return false;
        }

        public static bool Any(this Span<ushort> span)
        {
            return span.Length > 0;
        }

        public static bool Any(this Span<ushort> span, Func<ushort, bool> predicate)
        {
            if (predicate == null)
            {
                throw new ArgumentNullException("Predicate cannot be null!");
            }

            int n = span.Length;
            for (int i = 0; i < n; i++)
            {
                if (predicate(span[i]))
                {
                    return true;
                }
            }

            return false;
        }

        public static bool Any(this Span<int> span)
        {
            return span.Length > 0;
        }

        public static bool Any(this Span<int> span, Func<int, bool> predicate)
        {
            if (predicate == null)
            {
                throw new ArgumentNullException("Predicate cannot be null!");
            }

            int n = span.Length;
            for (int i = 0; i < n; i++)
            {
                if (predicate(span[i]))
                {
                    return true;
                }
            }

            return false;
        }

        public static bool Any(this Span<uint> span)
        {
            return span.Length > 0;
        }

        public static bool Any(this Span<uint> span, Func<uint, bool> predicate)
        {
            if (predicate == null)
            {
                throw new ArgumentNullException("Predicate cannot be null!");
            }

            int n = span.Length;
            for (int i = 0; i < n; i++)
            {
                if (predicate(span[i]))
                {
                    return true;
                }
            }

            return false;
        }

        public static bool Any(this Span<long> span)
        {
            return span.Length > 0;
        }

        public static bool Any(this Span<long> span, Func<long, bool> predicate)
        {
            if (predicate == null)
            {
                throw new ArgumentNullException("Predicate cannot be null!");
            }

            int n = span.Length;
            for (int i = 0; i < n; i++)
            {
                if (predicate(span[i]))
                {
                    return true;
                }
            }

            return false;
        }

        public static bool Any(this Span<ulong> span)
        {
            return span.Length > 0;
        }

        public static bool Any(this Span<ulong> span, Func<ulong, bool> predicate)
        {
            if (predicate == null)
            {
                throw new ArgumentNullException("Predicate cannot be null!");
            }

            int n = span.Length;
            for (int i = 0; i < n; i++)
            {
                if (predicate(span[i]))
                {
                    return true;
                }
            }

            return false;
        }

        public static bool Any(this Span<float> span)
        {
            return span.Length > 0;
        }

        public static bool Any(this Span<float> span, Func<float, bool> predicate)
        {
            if (predicate == null)
            {
                throw new ArgumentNullException("Predicate cannot be null!");
            }

            int n = span.Length;
            for (int i = 0; i < n; i++)
            {
                if (predicate(span[i]))
                {
                    return true;
                }
            }

            return false;
        }

        public static bool Any(this Span<double> span)
        {
            return span.Length > 0;
        }

        public static bool Any(this Span<double> span, Func<double, bool> predicate)
        {
            if (predicate == null)
            {
                throw new ArgumentNullException("Predicate cannot be null!");
            }

            int n = span.Length;
            for (int i = 0; i < n; i++)
            {
                if (predicate(span[i]))
                {
                    return true;
                }
            }

            return false;
        }

        public static bool Any(this Span<decimal> span)
        {
            return span.Length > 0;
        }

        public static bool Any(this Span<decimal> span, Func<decimal, bool> predicate)
        {
            if (predicate == null)
            {
                throw new ArgumentNullException("Predicate cannot be null!");
            }

            int n = span.Length;
            for (int i = 0; i < n; i++)
            {
                if (predicate(span[i]))
                {
                    return true;
                }
            }

            return false;
        }
    }
}
