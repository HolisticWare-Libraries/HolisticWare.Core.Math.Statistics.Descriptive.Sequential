using System;
using System.Collections.Generic;
using System.Linq;

namespace Core.Math.Statistics.Descriptive.Sequential
{
    public static partial class IEnumerableExtensionsStatistics
    {
        //==============================================================================================================
        public static StatisticsDescriptive StatisticsDescriptive
                                                            (
                                                                this IEnumerable<byte> x
                                                            )
        {
            StatisticsDescriptive statistics = new StatisticsDescriptive(x);

            return statistics;
        }

        public static StatisticsDescriptive StatisticsDescriptive
                                                            (
                                                                this IEnumerable<short> x
                                                            )
        {
            StatisticsDescriptive statistics = new StatisticsDescriptive(x);

            return statistics;
        }

        public static StatisticsDescriptive StatisticsDescriptive
                                                            (
                                                                this IEnumerable<ushort> x
                                                            )
        {
            StatisticsDescriptive statistics = new StatisticsDescriptive(x);

            return statistics;
        }

        public static StatisticsDescriptive StatisticsDescriptive
                                                            (
                                                                this IEnumerable<int> x
                                                            )
        {
            StatisticsDescriptive statistics = new StatisticsDescriptive(x);

            return statistics;
        }

        public static StatisticsDescriptive StatisticsDescriptive
                                                            (
                                                                this IEnumerable<uint> x
                                                            )
        {
            StatisticsDescriptive statistics = new StatisticsDescriptive(x);

            return statistics;
        }

        public static StatisticsDescriptive StatisticsDescriptive
                                                            (
                                                                this IEnumerable<long> x
                                                            )
        {
            StatisticsDescriptive statistics = new StatisticsDescriptive(x);

            return statistics;
        }

        public static StatisticsDescriptive StatisticsDescriptive
                                                            (
                                                                this IEnumerable<ulong> x
                                                            )
        {
            StatisticsDescriptive statistics = new StatisticsDescriptive(x);

            return statistics;
        }

        public static StatisticsDescriptive StatisticsDescriptive
                                                            (
                                                                this IEnumerable<float> x
                                                            )
        {
            StatisticsDescriptive statistics = new StatisticsDescriptive(x);

            return statistics;
        }

        public static StatisticsDescriptive StatisticsDescriptive
                                                            (
                                                                this IEnumerable<double> x
                                                            )
        {
            StatisticsDescriptive statistics = new StatisticsDescriptive(x);

            return statistics;
        }

        public static StatisticsDescriptive StatisticsDescriptive
                                                            (
                                                                this IEnumerable<decimal> x
                                                            )
        {
            StatisticsDescriptive statistics = new StatisticsDescriptive(x);

            return statistics;
        }
        //==============================================================================================================
    
    }
}
