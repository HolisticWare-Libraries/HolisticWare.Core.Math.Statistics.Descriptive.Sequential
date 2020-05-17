using System;
using System.Collections.Generic;
using System.Linq;

using Core.Math.Statistics.Descriptive.Sequential;
using Core.Memory;

namespace Core.Collections.Generic
{
    /// <summary>
    /// Normalizations
    /// </summary>
    /// <see href="https://en.wikipedia.org/wiki/Average"/>
    public static partial class MemoryExtensionsNormalize
    {
        //==============================================================================================================
        public static Memory<double> Normalize
                                    (
                                        this Memory<sbyte> x,
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

            Memory<double> result = new Memory<double>(new double[n]);
            Span<double> output_span = result.Span;
            Span<sbyte> input_span = x.Span;

            for (int i = 0; i < n; i++)
            {
                output_span[i] = input_span[i] / sum;
            }

            return result;
        }

        public static Memory<double> Normalize
                                    (
                                        this Memory<byte> x,
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

            Memory<double> result = new Memory<double>(new double[n]);
            Span<double> output_span = result.Span;
            Span<byte> input_span = x.Span;

            for (int i = 0; i < n; i++)
            {
                output_span[i] = input_span[i] / sum;
            }

            return result;
        }

        public static Memory<double> Normalize
                                    (
                                        this Memory<ushort> x,
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

            Memory<double> result = new Memory<double>(new double[n]);
            Span<double> output_span = result.Span;
            Span<ushort> input_span = x.Span;

            for (int i = 0; i < n; i++)
            {
                output_span[i] = input_span[i] / sum;
            }

            return result;
        }

        public static Memory<double> Normalize
                                    (
                                        this Memory<short> x,
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

            Memory<double> result = new Memory<double>(new double[n]);
            Span<double> output_span = result.Span;
            Span<short> input_span = x.Span;

            for (int i = 0; i < n; i++)
            {
                output_span[i] = input_span[i] / sum;
            }

            return result;
        }

        public static Memory<double> Normalize
                                    (
                                        this Memory<int> x,
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

            Memory<double> result = new Memory<double>(new double[n]);
            Span<double> output_span = result.Span;
            Span<int> input_span = x.Span;

            for (int i = 0; i < n; i++)
            {
                output_span[i] = input_span[i] / sum;
            }

            return result;
        }


        public static Memory<double> Normalize
                                    (
                                        this Memory<uint> x,
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

            Memory<double> result = new Memory<double>(new double[n]);
            Span<double> output_span = result.Span;
            Span<uint> input_span = x.Span;

            for (int i = 0; i < n; i++)
            {
                output_span[i] = input_span[i] / sum;
            }

            return result;
        }

        public static Memory<double> Normalize
                                    (
                                        this Memory<long> x,
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

            Memory<double> result = new Memory<double>(new double[n]);
            Span<double> output_span = result.Span;
            Span<long> input_span = x.Span;

            for (int i = 0; i < n; i++)
            {
                output_span[i] = input_span[i] / sum;
            }

            return result;
        }


        public static Memory<double> Normalize
                                    (
                                        this Memory<ulong> x,
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

            Memory<double> result = new Memory<double>(new double[n]);
            Span<double> output_span = result.Span;
            Span<ulong> input_span = x.Span;

            for (int i = 0; i < n; i++)
            {
                output_span[i] = input_span[i] / sum;
            }

            return result;
        }

        public static Memory<double> Normalize
                                    (
                                        this Memory<float> x,
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

            Memory<double> result = new Memory<double>(new double[n]);
            Span<double> output_span = result.Span;
            Span<float> input_span = x.Span;

            for (int i = 0; i < n; i++)
            {
                output_span[i] = input_span[i] / sum;
            }

            return result;
        }

        public static Memory<double> Normalize
                                    (
                                        this Memory<double> x,
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

            Memory<double> result = new Memory<double>(new double[n]);
            Span<double> output_span = result.Span;
            Span<double> input_span = x.Span;

            for (int i = 0; i < n; i++)
            {
                output_span[i] = input_span[i] / sum;
            }

            return result;
        }

        public static Memory<decimal> Normalize
                                    (
                                        this Memory<decimal> x,
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

            Memory<decimal> result = new Memory<decimal>(new decimal[n]);
            Span<decimal> output_span = result.Span;
            Span<decimal> input_span = x.Span;

            for (int i = 0; i < n; i++)
            {
                output_span[i] = input_span[i] / sum;
            }

            return result;
        }
        //==============================================================================================================

    }
}
