﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Core.Math.Statistics.Descriptive
{
    /// <summary>
    /// 
    /// </summary>
    public static partial class
                                        IEnumerableExtensionsMedianLow
    {
        //==============================================================================================================
        public static
            double
                                        MedianLow
                                        (
                                            this IEnumerable<byte> x
                                        )
        {
            int n = x.Count();

            IOrderedEnumerable<byte> x_ordered = x.OrderBy(x_i => x_i);
            int n2 = n / 2 - 1;

            if (n % 2 == 1)
            {
                return x_ordered.ElementAt((n + 1) / 2 - 1);
            }

            return x_ordered.ElementAt(n2);
        }

        public static
            double
                                        MedianLow
                                        (
                                            this IEnumerable<short> x
                                        )
        {
            int n = x.Count();

            IOrderedEnumerable<short> x_ordered = x.OrderBy(x_i => x_i);
            int n2 = n / 2 - 1;

            if (n % 2 == 1)
            {
                return x_ordered.ElementAt((n + 1) / 2 - 1);
            }

            return x_ordered.ElementAt(n2);
        }

        public static
            double
                                        MedianLow
                                        (
                                            this IEnumerable<ushort> x
                                        )
        {
            int n = x.Count();

            IOrderedEnumerable<ushort> x_ordered = x.OrderBy(x_i => x_i);
            int n2 = n / 2 - 1;

            if (n % 2 == 1)
            {
                return x_ordered.ElementAt((n + 1) / 2 - 1);
            }

            return x_ordered.ElementAt(n2);
        }

        public static
            double
                                        MedianLow
                                        (
                                            this IEnumerable<int> x
                                        )
        {
            int n = x.Count();

            IOrderedEnumerable<int> x_ordered = x.OrderBy(x_i => x_i);
            int n2 = n / 2 - 1;

            if (n % 2 == 1)
            {
                return x_ordered.ElementAt((n + 1) / 2 - 1);
            }

            return x_ordered.ElementAt(n2);
        }

        public static
            double
                                        MedianLow
                                        (
                                            this IEnumerable<uint> x
                                        )
        {
            int n = x.Count();

            IOrderedEnumerable<uint> x_ordered = x.OrderBy(x_i => x_i);
            int n2 = n / 2 - 1;

            if (n % 2 == 1)
            {
                return x_ordered.ElementAt((n + 1) / 2 - 1);
            }

            return x_ordered.ElementAt(n2);
        }

        public static
            double
                                        MedianLow
                                        (
                                            this IEnumerable<long> x
                                        )
        {
            int n = x.Count();

            IOrderedEnumerable<long> x_ordered = x.OrderBy(x_i => x_i);
            int n2 = n / 2 - 1;

            if (n % 2 == 1)
            {
                return x_ordered.ElementAt((n + 1) / 2 - 1);
            }

            return x_ordered.ElementAt(n2);
        }

        public static
            double
                                        MedianLow
                                        (
                                            this IEnumerable<ulong> x
                                        )
        {
            int n = x.Count();

            IOrderedEnumerable<ulong> x_ordered = x.OrderBy(x_i => x_i);
            int n2 = n / 2 - 1;

            if (n % 2 == 1)
            {
                return x_ordered.ElementAt((n + 1) / 2 - 1);
            }

            return x_ordered.ElementAt(n2);
        }

        public static
            double
                                        MedianLow
                                        (
                                            this IEnumerable<float> x
                                        )
        {
            int n = x.Count();

            IOrderedEnumerable<float> x_ordered = x.OrderBy(x_i => x_i);
            int n2 = n / 2 - 1;

            if (n % 2 == 1)
            {
                return x_ordered.ElementAt((n + 1) / 2 - 1);
            }

            return x_ordered.ElementAt(n2);
        }

        public static
            double
                                        MedianLow
                                        (
                                            this IEnumerable<double> x
                                        )
        {
            int n = x.Count();

            IOrderedEnumerable<double> x_ordered = x.OrderBy(x_i => x_i);
            int n2 = n / 2 - 1;

            if (n % 2 == 1)
            {
                return x_ordered.ElementAt((n + 1) / 2 - 1);
            }

            return x_ordered.ElementAt(n2);
        }

        public static
            decimal
                                        MedianLow
                                        (
                                            this IEnumerable<decimal> x
                                        )
        {
            int n = x.Count();
            IOrderedEnumerable<decimal> x_ordered = x.OrderBy(x_i => x_i);
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
