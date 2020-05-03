using System;
using System.Collections.Generic;
using System.Linq;

namespace Core.Memory
{
    /// <summary>
    /// Normalize
    /// </summary>
    /// <see href="https://www.statisticshowto.com/normalized/"/>
    /// <see href="https://medium.com/@swethalakshmanan14/how-when-and-why-should-you-normalize-standardize-rescale-your-data-3f083def38ff"/>
    /// <see href="https://en.wikipedia.org/wiki/Normalization_(statistics)"/>
    /// @TODO: Normalizing, Scaling, Rescaling
    /// @TODO: move to Core.Data
    public static partial class MemoryExtensionsNormalize
    {
        //==============================================================================================================
        public static IEnumerable<double> Normalize
                                                (
                                                    this Memory<byte> x,
                                                    double? value = null
                                                )
        {
            int n = x.Length;
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
                yield return x.Span[i] / sum;
            }
        }

        public static IEnumerable<double> Normalize
                                                (
                                                    this Memory<sbyte> x,
                                                    double? value = null
                                                ) {
            int n = x.Length;
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
                yield return x.Span[i] / sum;
            }
        }

        public static IEnumerable<double> Normalize
                                            (
                                                this Memory<ushort> x,
                                                double? value = null
                                            )
        {
            int n = x.Length;
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
                yield return x.Span[i] / sum;
            }
        }

        public static IEnumerable<double> Normalize
                                            (
                                                this Memory<short> x,
                                                double? value = null
                                            )
        {
            int n = x.Length;
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
                yield return x.Span[i] / sum;
            }
        }

        public static IEnumerable<double> Normalize
                                            (
                                                this Memory<int> x,
                                                double? value = null
                                            )
        {
            int n = x.Length;
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
                yield return x.Span[i] / sum;
            }
        }

        public static IEnumerable<double> Normalize
                                            (
                                                this Memory<uint> x,
                                                double? value = null
                                            )
        {
            int n = x.Length;
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
                yield return x.Span[i] / sum;
            }
        }

        public static IEnumerable<double> Normalize
                                            (
                                                this Memory<long> x,
                                                double? value = null
                                            )
        {
            int n = x.Length;
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
                yield return x.Span[i] / sum;
            }
        }

        public static IEnumerable<double> Normalize
                                            (
                                                this Memory<ulong> x,
                                                double? value = null
                                            )
        {
            int n = x.Length;
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
                yield return x.Span[i] / sum;
            }
        }

        public static IEnumerable<double> Normalize
                                            (
                                                this Memory<float> x,
                                                double? value = null
                                            )
        {
            int n = x.Length;
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
                yield return x.Span[i] / sum;
            }
        }
         
        public static IEnumerable<double> Normalize
                                            (
                                                this Memory<double> x,
                                                double? value = null
                                            )
        {
            int n = x.Length;
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
                yield return x.Span[i] / sum;
            }
        }

        public static IEnumerable<decimal> Normalize
                                            (
                                                this Memory<decimal> x,
                                                decimal? value = null
                                            )
        {
            int n = x.Length;
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
                yield return x.Span[i] / sum;
            }
        }
        //==============================================================================================================

    }
}
