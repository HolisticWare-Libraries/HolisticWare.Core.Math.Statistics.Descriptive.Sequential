using System;
using System.Collections.Generic;
using System.Linq;

using Core.Math.Statistics.Descriptive;

namespace Core.Math.Statistics.Descriptive
{
    public static partial class IEnumerableExtensionsStandardDeviationSample
    {
        //==============================================================================================================
        public static double StandardDeviationSampleAsync
                                                (
                                                    this IEnumerable<byte> x
                                                )
        {
            return System.Math.Sqrt(x.VarianceSample());
        }

        public static double StandardDeviationSampleAsync
                                                (
                                                    this IEnumerable<short> x
                                                )
        {
            return System.Math.Sqrt(x.VarianceSample());
        }

        public static double StandardDeviationSampleAsync
                                                (
                                                    this IEnumerable<ushort> x
                                                )
        {
            return System.Math.Sqrt(x.VarianceSample());
        }

        public static double StandardDeviationSampleAsync
                                                (
                                                    this IEnumerable<int> x
                                                )
        {
            return System.Math.Sqrt(x.VarianceSample());
        }

        public static double StandardDeviationSampleAsync
                                                (
                                                    this IEnumerable<uint> x
                                                )
        {
            return System.Math.Sqrt(x.VarianceSample());
        }

        public static double StandardDeviationSampleAsync
                                                (
                                                    this IEnumerable<long> x
                                                )
        {
            return System.Math.Sqrt(x.VarianceSample());
        }

        public static double StandardDeviationSampleAsync
                                                (
                                                    this IEnumerable<ulong> x
                                                )
        {
            return System.Math.Sqrt(x.VarianceSample());
        }

        public static double StandardDeviationSampleAsync
                                                (
                                                    this IEnumerable<float> x
                                                )
        {
            return System.Math.Sqrt(x.VarianceSample());
        }

        public static double StandardDeviationSampleAsync
                                                (
                                                    this IEnumerable<double> x
                                                )
        {
            return System.Math.Sqrt(x.VarianceSample());
        }

        public static decimal StandardDeviationSampleAsync
                                                (
                                                    this IEnumerable<decimal> x
                                                )
        {
            return (decimal) System.Math.Sqrt((double)x.VarianceSample());
        }
        //==============================================================================================================

    }
}
