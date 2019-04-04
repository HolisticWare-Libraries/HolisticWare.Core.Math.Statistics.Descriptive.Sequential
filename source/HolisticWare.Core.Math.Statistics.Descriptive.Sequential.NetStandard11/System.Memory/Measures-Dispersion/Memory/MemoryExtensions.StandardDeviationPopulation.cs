using System;
using System.Collections.Generic;
using System.Linq;

using Core.Math.Statistics.Descriptive.Sequential;

namespace Core.Math.Statistics.Descriptive.Sequential
{
    public static partial class MemoryExtensionsStandardDeviationPopulation
    {
        //==============================================================================================================
        public static double StandardDeviationPopulation
                                                (
                                                    this Memory<byte> x
                                                )
        {
            return System.Math.Sqrt(x.VariancePopulation());
        }

        public static double StandardDeviationPopulation
                                                (
                                                    this Memory<short> x
                                                )
        {
            return System.Math.Sqrt(x.VariancePopulation());
        }

        public static double StandardDeviationPopulation
                                                (
                                                    this Memory<ushort> x
                                                )
        {
            return System.Math.Sqrt(x.VariancePopulation());
        }

        public static double StandardDeviationPopulation
                                                (
                                                    this Memory<int> x
                                                )
        {
            return System.Math.Sqrt(x.VariancePopulation());
        }

        public static double StandardDeviationPopulation
                                                (
                                                    this Memory<uint> x
                                                )
        {
            return System.Math.Sqrt(x.VariancePopulation());
        }

        public static double StandardDeviationPopulation
                                                (
                                                    this Memory<long> x
                                                )
        {
            return System.Math.Sqrt(x.VariancePopulation());
        }

        public static double StandardDeviationPopulation
                                                (
                                                    this Memory<ulong> x
                                                )
        {
            return System.Math.Sqrt(x.VariancePopulation());
        }

        public static double StandardDeviationPopulation
                                                (
                                                    this Memory<float> x
                                                )
        {
            return System.Math.Sqrt(x.VariancePopulation());
        }

        public static double StandardDeviationPopulation
                                                (
                                                    this Memory<double> x
                                                )
        {
            return System.Math.Sqrt(x.VariancePopulation());
        }

        public static decimal StandardDeviationPopulation
                                                (
                                                    this Memory<decimal> x
                                                )
        {
            return (decimal) System.Math.Sqrt((double)x.VariancePopulation());
        }
        //==============================================================================================================

    }
}
