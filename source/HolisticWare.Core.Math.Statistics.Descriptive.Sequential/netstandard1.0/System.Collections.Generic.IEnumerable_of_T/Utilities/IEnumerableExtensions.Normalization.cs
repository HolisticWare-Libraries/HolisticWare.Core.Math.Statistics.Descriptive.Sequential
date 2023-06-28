using System;
using System.Collections.Generic;
using System.Linq;

using Core.Math.Statistics.Descriptive;

namespace Core.Math.Statistics.Descriptive
{
    /// <summary>
    /// Mean (Average) Arithmetic
    /// </summary>
    /// <see href="https://en.wikipedia.org/wiki/Average"/>
    public static partial class IEnumerableExtensionsMeanArithmetic
    {
        //==============================================================================================================
        public static
            IEnumerable<double>
                                        Normalize
                                        (
                                            this IEnumerable<byte> x,
                                            double? value = null
                                        )
        {
            int n = x.Count();
            double sum;

            if (value.HasValue)
            {
                sum = value.Value;
            }
            else
            {
                sum = x.Select( x_i => (double)x_i).Sum();
            }

            for (int i = 0; i < n; i++)
            {
                yield return x.ElementAt(i) / sum;
            }
        }

        public static
            IEnumerable<double>
                                        Normalize
                                        (
                                            this IEnumerable<ushort> x,
                                            double? value = null
                                        )
        {
            int n = x.Count();
            double sum;

            if (value.HasValue)
            {
                sum = value.Value;
            }
            else
            {
                sum = x.Select(x_i => (double)x_i).Sum();
            }

            for (int i = 0; i < n; i++)
            {
                yield return x.ElementAt(i) / sum;
            }
        }

        public static
            IEnumerable<double>
                                        Normalize
                                        (
                                            this IEnumerable<short> x,
                                            double? value = null
                                        )
        {
            int n = x.Count();
            double sum;

            if (value.HasValue)
            {
                sum = value.Value;
            }
            else
            {
                sum = x.Select(x_i => (double)x_i).Sum();
            }

            for (int i = 0; i < n; i++)
            {
                yield return x.ElementAt(i) / sum;
            }
        }

        public static
            IEnumerable<double>
                                        Normalize
                                        (
                                            this IEnumerable<int> x,
                                            double? value = null
                                        )
        {
            int n = x.Count();
            double sum;

            if (value.HasValue)
            {
                sum = value.Value;
            }
            else
            {
                sum = x.Sum();
            }

            for (int i = 0; i < n; i++)
            {
                yield return x.ElementAt(i) / sum;
            }
        }

        public static
            IEnumerable<double>
                                        Normalize
                                        (
                                            this IEnumerable<uint> x,
                                            double? value = null
                                        )
        {
            int n = x.Count();
            double sum;

            if (value.HasValue)
            {
                sum = value.Value;
            }
            else
            {
                sum = x.Select(x_i => (double)x_i).Sum();
            }

            for (int i = 0; i < n; i++)
            {
                yield return x.ElementAt(i) / sum;
            }
        }

        public static
            IEnumerable<double>
                                        Normalize
                                        (
                                            this IEnumerable<long> x,
                                            double? value = null
                                        )
        {
            int n = x.Count();
            double sum;

            if (value.HasValue)
            {
                sum = value.Value;
            }
            else
            {
                sum = x.Select(x_i => (double)x_i).Sum();
            }

            for (int i = 0; i < n; i++)
            {
                yield return x.ElementAt(i) / sum;
            }
        }

        public static
            IEnumerable<double>
                                        Normalize
                                        (
                                            this IEnumerable<ulong> x,
                                            double? value = null
                                        )
        {
            int n = x.Count();
            double sum;

            if (value.HasValue)
            {
                sum = value.Value;
            }
            else
            {
                sum = x.Select(x_i => (double)x_i).Sum();
            }

            for (int i = 0; i < n; i++)
            {
                yield return x.ElementAt(i) / sum;
            }
        }

        public static
            IEnumerable<double>
                                        Normalize
                                        (
                                            this IEnumerable<float> x,
                                            double? value = null
                                        )
        {
            int n = x.Count();
            double sum;

            if (value.HasValue)
            {
                sum = value.Value;
            }
            else
            {
                sum = x.Sum();
            }

            for (int i = 0; i < n; i++)
            {
                yield return x.ElementAt(i) / sum;
            }
        }
         
        public static
            IEnumerable<double>
                                        Normalize
                                        (
                                            this IEnumerable<double> x,
                                            double? value = null
                                        )
        {
            int n = x.Count();
            double sum;

            if (value.HasValue)
            {
                sum = value.Value;
            }
            else
            {
                sum = x.Sum();
            }

            for (int i = 0; i < n; i++)
            {
                yield return x.ElementAt(i) / sum;
            }
        }

        public static
            IEnumerable<decimal>
                                        Normalize
                                        (
                                            this IEnumerable<decimal> x,
                                            decimal? value = null
                                        )
        {
            int n = x.Count();
            decimal sum;

            if (value.HasValue)
            {
                sum = value.Value;
            }
            else
            {
                sum = x.Sum();
            }

            for (int i = 0; i < n; i++)
            {
                yield return x.ElementAt(i) / sum;
            }
        }
        //==============================================================================================================

    }
}
