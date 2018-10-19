using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Core.Math.Statistics.Descriptive.Sequential
{
    public static partial class IEnumerableExtensionsWelchtStatistic
    {
        //==============================================================================================================
        public async static Task<(double welch_t, double degrees_of_freedom)> WelchtStatisticAsync
                                                                                (
                                                                                   this IEnumerable<byte> x,
                                                                                   IEnumerable<byte> y
                                                                                )
        {
            (double welch_t, double degrees_of_freedom) statistic =
                await Task
                            //.Run
                            .Factory.StartNew
                                (
                                    () => x.WelchtStatistic(y)
                                )
                            .ConfigureAwait(false);

            return statistic;
        }

        public async static Task<(double welch_t, double degrees_of_freedom)> WelchtStatisticAsync
                                                                                (
                                                                                   this IEnumerable<short> x,
                                                                                   IEnumerable<short> y
                                                                                )
        {
            (double welch_t, double degrees_of_freedom) statistic =
                await Task
                            //.Run
                            .Factory.StartNew
                                (
                                    () => x.WelchtStatistic(y)
                                )
                            .ConfigureAwait(false);

            return statistic;
        }

        public async static Task<(double welch_t, double degrees_of_freedom)> WelchtStatisticAsync
                                                                                (
                                                                                   this IEnumerable<ushort> x,
                                                                                   IEnumerable<ushort> y
                                                                                )
        {
            (double welch_t, double degrees_of_freedom) statistic =
                await Task
                            //.Run
                            .Factory.StartNew
                                (
                                    () => x.WelchtStatistic(y)
                                )
                            .ConfigureAwait(false);

            return statistic;
        }

        public async static Task<(double welch_t, double degrees_of_freedom)> WelchtStatisticAsync
                                                                                (
                                                                                   this IEnumerable<int> x,
                                                                                   IEnumerable<int> y
                                                                                )
        {
            (double welch_t, double degrees_of_freedom) statistic =
                await Task
                            //.Run
                            .Factory.StartNew
                                (
                                    () => x.WelchtStatistic(y)
                                )
                            .ConfigureAwait(false);

            return statistic;
        }

        public async static Task<(double welch_t, double degrees_of_freedom)> WelchtStatisticAsync
                                                                                (
                                                                                   this IEnumerable<uint> x,
                                                                                   IEnumerable<uint> y
                                                                                )
        {
            (double welch_t, double degrees_of_freedom) statistic =
                await Task
                            //.Run
                            .Factory.StartNew
                                (
                                    () => x.WelchtStatistic(y)
                                )
                            .ConfigureAwait(false);

            return statistic;
        }

        public async static Task<(double welch_t, double degrees_of_freedom)> WelchtStatisticAsync
                                                                                (
                                                                                   this IEnumerable<long> x,
                                                                                   IEnumerable<long> y
                                                                                )
        {
            (double welch_t, double degrees_of_freedom) statistic =
                await Task
                            //.Run
                            .Factory.StartNew
                                (
                                    () => x.WelchtStatistic(y)
                                )
                            .ConfigureAwait(false);

            return statistic;
        }

        public async static Task<(double welch_t, double degrees_of_freedom)> WelchtStatisticAsync
                                                                                (
                                                                                   this IEnumerable<ulong> x,
                                                                                   IEnumerable<ulong> y
                                                                                )
        {
            (double welch_t, double degrees_of_freedom) statistic =
                await Task
                            //.Run
                            .Factory.StartNew
                                (
                                    () => x.WelchtStatistic(y)
                                )
                            .ConfigureAwait(false);

            return statistic;
        }

        public async static Task<(double welch_t, double degrees_of_freedom)> WelchtStatisticAsync
                                                                                (
                                                                                   this IEnumerable<float> x,
                                                                                   IEnumerable<float> y
                                                                                )
        {
            (double welch_t, double degrees_of_freedom) statistic =
                await Task
                            //.Run
                            .Factory.StartNew
                                (
                                    () => x.WelchtStatistic(y)
                                )
                            .ConfigureAwait(false);

            return statistic;
        }

        public async static Task<(double welch_t, double degrees_of_freedom)> WelchtStatisticAsync
                                                                                (
                                                                                   this IEnumerable<double> x,
                                                                                   IEnumerable<double> y
                                                                                )
        {
            (double welch_t, double degrees_of_freedom) statistic =
                await Task
                            //.Run
                            .Factory.StartNew
                                (
                                    () => x.WelchtStatistic(y)
                                )
                            .ConfigureAwait(false);

            return statistic;
        }

        public async static Task<(decimal welch_t, decimal degrees_of_freedom)> WelchtStatisticAsync
                                                                                (
                                                                                   this IEnumerable<decimal> x,
                                                                                   IEnumerable<decimal> y
                                                                                )
        {
            (decimal welch_t, decimal degrees_of_freedom) statistic =
                await Task
                            //.Run
                            .Factory.StartNew
                                (
                                    () => x.WelchtStatistic(y)
                                )
                            .ConfigureAwait(false);

            return statistic;
        }
        //==============================================================================================================
    }
}
