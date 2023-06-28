using System;
using System.Collections.Generic;
using System.Linq;

using Core.Math.Statistics.Descriptive;

namespace Core.Math.Statistics.Descriptive
{
    public static partial class IEnumerableExtensionsStandardDeviationPopulation
    {
        //==============================================================================================================
        public static double StandardDeviationPopulationAsync
                                                (
                                                    this IEnumerable<byte> x
                                                )
        {
            return System.Math.Sqrt(x.VariancePopulation());
        }

        public static double StandardDeviationPopulationAsync
                                                (
                                                    this IEnumerable<short> x
                                                )
        {
            return System.Math.Sqrt(x.VariancePopulation());
        }

        public static double StandardDeviationPopulationAsync
                                                (
                                                    this IEnumerable<ushort> x
                                                )
        {
            return System.Math.Sqrt(x.VariancePopulation());
        }

        public static double StandardDeviationPopulationAsync
                                                (
                                                    this IEnumerable<int> x
                                                )
        {
            return System.Math.Sqrt(x.VariancePopulation());
        }

        public static double StandardDeviationPopulationAsync
                                                (
                                                    this IEnumerable<uint> x
                                                )
        {
            return System.Math.Sqrt(x.VariancePopulation());
        }

        public static double StandardDeviationPopulationAsync
                                                (
                                                    this IEnumerable<long> x
                                                )
        {
            return System.Math.Sqrt(x.VariancePopulation());
        }

        public static double StandardDeviationPopulationAsync
                                                (
                                                    this IEnumerable<ulong> x
                                                )
        {
            return System.Math.Sqrt(x.VariancePopulation());
        }

        public static double StandardDeviationPopulationAsync
                                                (
                                                    this IEnumerable<float> x
                                                )
        {
            return System.Math.Sqrt(x.VariancePopulation());
        }

        public static double StandardDeviationPopulationAsync
                                                (
                                                    this IEnumerable<double> x
                                                )
        {
            return System.Math.Sqrt(x.VariancePopulation());
        }

        public static decimal StandardDeviationPopulationAsync
                                                (
                                                    this IEnumerable<decimal> x
                                                )
        {
            return (decimal) System.Math.Sqrt((double)x.VariancePopulation());
        }
        //==============================================================================================================

    }
}
