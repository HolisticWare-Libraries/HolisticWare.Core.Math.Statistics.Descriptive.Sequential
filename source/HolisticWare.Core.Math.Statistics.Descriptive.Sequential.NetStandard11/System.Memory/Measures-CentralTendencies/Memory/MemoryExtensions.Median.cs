using System;
using System.Collections.Generic;
using System.Linq;

namespace Core.Math.Statistics.Descriptive.Sequential
{
    /// <summary>
    /// 
    /// </summary>
    public static partial class MemoryExtensionsMedian
    {
        //==============================================================================================================
        public static double Median
                                (
                                    this Memory<byte> x
                                )
        {
            int n = x.Length;
            IOrderedEnumerable<byte> x_ordered = x.OrderBy(x_i => x_i);

            if (n % 2 == 1)
            {
                return x_ordered.ElementAt((n + 1) / 2 - 1);
            }

            int n2 = n / 2 - 1;

            return 0.5 * (x_ordered.ElementAt(n2) + x_ordered.ElementAt(n2 + 1));
        }

        public static double Median
                                (
                                    this Memory<short> x
                                )
        {
            int n = x.Length;
            IOrderedEnumerable<short> x_ordered = x.OrderBy(x_i => x_i);

            if (n % 2 == 1)
            {
                return x_ordered.ElementAt((n + 1) / 2 - 1);
            }

            int n2 = n / 2 - 1;

            return 0.5 * (x_ordered.ElementAt(n2) + x_ordered.ElementAt(n2 + 1));
        }

        public static double Median
                                (
                                    this Memory<ushort> x
                                )
        {
            int n = x.Length;
            IOrderedEnumerable<ushort> x_ordered = x.OrderBy(x_i => x_i);

            if (n % 2 == 1)
            {
                return x_ordered.ElementAt((n + 1) / 2 - 1);
            }

            int n2 = n / 2 - 1;

            return 0.5 * (x_ordered.ElementAt(n2) + x_ordered.ElementAt(n2 + 1));
        }

        public static double Median
                                (
                                    this Memory<int> x
                                )
        {
            int n = x.Length;
            IOrderedEnumerable<int> x_ordered = x.OrderBy(x_i => x_i);

            if (n % 2 == 1)
            {
                return x_ordered.ElementAt((n + 1) / 2 - 1);
            }

            int n2 = n / 2 - 1;

            return 0.5 * (x_ordered.ElementAt(n2) + x_ordered.ElementAt(n2 + 1));
        }

        public static double Median
                                (
                                    this Memory<uint> x
                                )
        {
            int n = x.Length;
            IOrderedEnumerable<uint> x_ordered = x.OrderBy(x_i => x_i);

            if (n % 2 == 1)
            {
                return x_ordered.ElementAt((n + 1) / 2 - 1);
            }

            int n2 = n / 2 - 1;

            return 0.5 * (x_ordered.ElementAt(n2) + x_ordered.ElementAt(n2 + 1));
        }

        public static double Median
                                (
                                    this Memory<long> x
                                )
        {
            int n = x.Length;
            IOrderedEnumerable<long> x_ordered = x.OrderBy(x_i => x_i);

            if (n % 2 == 1)
            {
                return x_ordered.ElementAt((n + 1) / 2 - 1);
            }

            int n2 = n / 2 - 1;

            return 0.5 * (x_ordered.ElementAt(n2) + x_ordered.ElementAt(n2 + 1));
        }

        public static double Median
                                (
                                    this Memory<ulong> x
                                )
        {
            int n = x.Length;
            IOrderedEnumerable<ulong> x_ordered = x.OrderBy(x_i => x_i);

            if (n % 2 == 1)
            {
                return x_ordered.ElementAt((n + 1) / 2 - 1);
            }

            int n2 = n / 2 - 1;

            return 0.5 * (x_ordered.ElementAt(n2) + x_ordered.ElementAt(n2 + 1));
        }

        public static double Median
                                (
                                    this Memory<float> x
                                )
        {
            int n = x.Length;
            IOrderedEnumerable<float> x_ordered = x.OrderBy(x_i => x_i);

            if (n % 2 == 1)
            {
                return x_ordered.ElementAt((n + 1) / 2 - 1);
            }

            int n2 = n / 2 - 1;

            return 0.5 * (x_ordered.ElementAt(n2) + x_ordered.ElementAt(n2 + 1));
        }

        public static double Median
                                (
                                    this Memory<double> x
                                )
        {
            int n = x.Length;
            IOrderedEnumerable<double> x_ordered = x.OrderBy(x_i => x_i);

            if (n % 2 == 1)
            {
                return x_ordered.ElementAt((n + 1) / 2 - 1);
            }

            int n2 = n / 2 - 1;

            return 0.5 * (x_ordered.ElementAt(n2) + x_ordered.ElementAt(n2 + 1));
        }

        public static decimal Median
                                (
                                    this Memory<decimal> x
                                )
        {
            int n = x.Length;
            IOrderedEnumerable<decimal> x_ordered = x.OrderBy(x_i => x_i);

            if (n % 2 == 1)
            {
                return x_ordered.ElementAt((n + 1) / 2 - 1);
            }

            int n2 = n / 2 - 1;

            return 0.5M * (x_ordered.ElementAt(n2) + x_ordered.ElementAt(n2 + 1));
        }
        //==============================================================================================================

    }
}
