using System;

namespace Core.Math.Statistics.Descriptive
{
    public static partial class MemoryExtensionsStandardDeviationSample
    {
        //==============================================================================================================
        public static double StandardDeviationSample
                                                (
                                                    this Memory<byte> x
                                                )
        {
            return System.Math.Sqrt(x.VarianceSample());
        }

        public static double StandardDeviationSample
                                                (
                                                    this Memory<short> x
                                                )
        {
            return System.Math.Sqrt(x.VarianceSample());
        }

        public static double StandardDeviationSample
                                                (
                                                    this Memory<ushort> x
                                                )
        {
            return System.Math.Sqrt(x.VarianceSample());
        }

        public static double StandardDeviationSample
                                                (
                                                    this Memory<int> x
                                                )
        {
            return System.Math.Sqrt(x.VarianceSample());
        }

        public static double StandardDeviationSample
                                                (
                                                    this Memory<uint> x
                                                )
        {
            return System.Math.Sqrt(x.VarianceSample());
        }

        public static double StandardDeviationSample
                                                (
                                                    this Memory<long> x
                                                )
        {
            return System.Math.Sqrt(x.VarianceSample());
        }

        public static double StandardDeviationSample
                                                (
                                                    this Memory<ulong> x
                                                )
        {
            return System.Math.Sqrt(x.VarianceSample());
        }

        public static double StandardDeviationSample
                                                (
                                                    this Memory<float> x
                                                )
        {
            return System.Math.Sqrt(x.VarianceSample());
        }

        public static double StandardDeviationSample
                                                (
                                                    this Memory<double> x
                                                )
        {
            return System.Math.Sqrt(x.VarianceSample());
        }

        public static decimal StandardDeviationSample
                                                (
                                                    this Memory<decimal> x
                                                )
        {
            return (decimal) System.Math.Sqrt((double)x.VarianceSample());
        }
        //==============================================================================================================

    }
}
