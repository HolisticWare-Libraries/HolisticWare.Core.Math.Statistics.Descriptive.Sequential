using System;
using System.Linq;

using Core.LINQ.Memory;

namespace Core.Math.Statistics.Descriptive
{
    /// <summary>
    /// 
    /// </summary>
    public static partial class MemoryExtensionsMedianLow
    {
        //==============================================================================================================
        public static double MedianLow
                                (
                                    this Memory<byte> x
                                )
        {
            int n = x.Length;
            System.Linq.IOrderedEnumerable<byte> x_ordered = x.ToArray().OrderBy(x_i => x_i);
            int n2 = n / 2 - 1;

            if (n % 2 == 1)
            {
                return x_ordered.ElementAt((n + 1) / 2 - 1);
            }

            return x_ordered.ElementAt(n2);
        }

        public static double MedianLow
                                (
                                    this Memory<short> x
                                )
        {
            int n = x.Length;
            System.Linq.IOrderedEnumerable<short> x_ordered = x.ToArray().OrderBy(x_i => x_i);
            int n2 = n / 2 - 1;

            if (n % 2 == 1)
            {
                return x_ordered.ElementAt((n + 1) / 2 - 1);
            }

            return x_ordered.ElementAt(n2);
        }

        public static double MedianLow
                                (
                                    this Memory<ushort> x
                                )
        {
            int n = x.Length;
            System.Linq.IOrderedEnumerable<ushort> x_ordered = x.ToArray().OrderBy(x_i => x_i);
            int n2 = n / 2 - 1;

            if (n % 2 == 1)
            {
                return x_ordered.ElementAt((n + 1) / 2 - 1);
            }

            return x_ordered.ElementAt(n2);
        }

        public static double MedianLow
                                (
                                    this Memory<int> x
                                )
        {
            int n = x.Length;
            System.Linq.IOrderedEnumerable<int> x_ordered = x.ToArray().OrderBy(x_i => x_i);
            int n2 = n / 2 - 1;

            if (n % 2 == 1)
            {
                return x_ordered.ElementAt((n + 1) / 2 - 1);
            }

            return x_ordered.ElementAt(n2);
        }

        public static double MedianLow
                                (
                                    this Memory<uint> x
                                )
        {
            int n = x.Length;
            System.Linq.IOrderedEnumerable<uint> x_ordered = x.ToArray().OrderBy(x_i => x_i);
            int n2 = n / 2 - 1;

            if (n % 2 == 1)
            {
                return x_ordered.ElementAt((n + 1) / 2 - 1);
            }

            return x_ordered.ElementAt(n2);
        }

        public static double MedianLow
                                (
                                    this Memory<long> x
                                )
        {
            int n = x.Length;
            System.Linq.IOrderedEnumerable<long> x_ordered = x.ToArray().OrderBy(x_i => x_i);
            int n2 = n / 2 - 1;

            if (n % 2 == 1)
            {
                return x_ordered.ElementAt((n + 1) / 2 - 1);
            }

            return x_ordered.ElementAt(n2);
        }

        public static double MedianLow
                                (
                                    this Memory<ulong> x
                                )
        {
            int n = x.Length;
            System.Linq.IOrderedEnumerable<ulong> x_ordered = x.ToArray().OrderBy(x_i => x_i);
            int n2 = n / 2 - 1;

            if (n % 2 == 1)
            {
                return x_ordered.ElementAt((n + 1) / 2 - 1);
            }

            return x_ordered.ElementAt(n2);
        }

        public static double MedianLow
                                (
                                    this Memory<float> x
                                )
        {
            int n = x.Length;
            System.Linq.IOrderedEnumerable<float> x_ordered = x.ToArray().OrderBy(x_i => x_i);
            int n2 = n / 2 - 1;

            if (n % 2 == 1)
            {
                return x_ordered.ElementAt((n + 1) / 2 - 1);
            }

            return x_ordered.ElementAt(n2);
        }

        public static double MedianLow
                                (
                                    this Memory<double> x
                                )
        {
            int n = x.Length;
            System.Linq.IOrderedEnumerable<double> x_ordered = x.ToArray().OrderBy(x_i => x_i);
            int n2 = n / 2 - 1;

            if (n % 2 == 1)
            {
                return x_ordered.ElementAt((n + 1) / 2 - 1);
            }

            return x_ordered.ElementAt(n2);
        }

        public static decimal MedianLow
                                (
                                    this Memory<decimal> x
                                )
        {
            int n = x.Length;
            System.Linq.IOrderedEnumerable<decimal> x_ordered = x.ToArray().OrderBy(x_i => x_i);
            int n2 = n / 2 - 1;

            if (n % 2 == 1)
            {
                return x_ordered.ElementAt((n + 1) / 2 - 1);
            }

            return x_ordered.ElementAt(n2);
        }
        //==============================================================================================================

    }
}
