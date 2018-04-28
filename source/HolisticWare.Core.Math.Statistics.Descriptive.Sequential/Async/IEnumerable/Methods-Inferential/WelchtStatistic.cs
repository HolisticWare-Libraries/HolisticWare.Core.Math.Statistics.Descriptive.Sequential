using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Core.Math.Statistics.Descriptive.Sequential
{
    public static partial class WelchtStatistic
    {
        //==============================================================================================================
        public async static Task<(double welch_t, double degrees_of_freedom)> CalculateAsync(IEnumerable<byte> x, IEnumerable<byte> y)
        {
            (double welch_t, double degrees_of_freedom) statistic =
                await Task
                            .Run
                                (
                                    () => x.WelchtStatistic(y)
                                )
                            .ConfigureAwait(false);

            return statistic;
        }

        public async static Task<(double welch_t, double degrees_of_freedom)> CalculateAsync(IEnumerable<short> x, IEnumerable<short> y)
        {
            (double welch_t, double degrees_of_freedom) statistic =
                await Task
                            .Run
                                (
                                    () => x.WelchtStatistic(y)
                                )
                            .ConfigureAwait(false);

            return statistic;
        }

        public async static Task<(double welch_t, double degrees_of_freedom)> CalculateAsync(IEnumerable<ushort> x, IEnumerable<ushort> y)
        {
            (double welch_t, double degrees_of_freedom) statistic =
                await Task
                            .Run
                                (
                                    () => x.WelchtStatistic(y)
                                )
                            .ConfigureAwait(false);

            return statistic;
        }

        public async static Task<(double welch_t, double degrees_of_freedom)> CalculateAsync(IEnumerable<int> x, IEnumerable<int> y)
        {
            (double welch_t, double degrees_of_freedom) statistic =
                await Task
                            .Run
                                (
                                    () => x.WelchtStatistic(y)
                                )
                            .ConfigureAwait(false);

            return statistic;
        }

        public async static Task<(double welch_t, double degrees_of_freedom)> CalculateAsync(IEnumerable<uint> x, IEnumerable<uint> y)
        {
            (double welch_t, double degrees_of_freedom) statistic =
                await Task
                            .Run
                                (
                                    () => x.WelchtStatistic(y)
                                )
                            .ConfigureAwait(false);

            return statistic;
        }

        public async static Task<(double welch_t, double degrees_of_freedom)> CalculateAsync(IEnumerable<long> x, IEnumerable<long> y)
        {
            (double welch_t, double degrees_of_freedom) statistic =
                await Task
                            .Run
                                (
                                    () => x.WelchtStatistic(y)
                                )
                            .ConfigureAwait(false);

            return statistic;
        }

        public async static Task<(double welch_t, double degrees_of_freedom)> CalculateAsync(IEnumerable<ulong> x, IEnumerable<ulong> y)
        {
            (double welch_t, double degrees_of_freedom) statistic =
                await Task
                            .Run
                                (
                                    () => x.WelchtStatistic(y)
                                )
                            .ConfigureAwait(false);

            return statistic;
        }

        public async static Task<(double welch_t, double degrees_of_freedom)> CalculateAsync(IEnumerable<float> x, IEnumerable<float> y)
        {
            (double welch_t, double degrees_of_freedom) statistic =
                await Task
                            .Run
                                (
                                    () => x.WelchtStatistic(y)
                                )
                            .ConfigureAwait(false);

            return statistic;
        }

        public async static Task<(double welch_t, double degrees_of_freedom)> CalculateAsync(IEnumerable<double> x, IEnumerable<double> y)
        {
            (double welch_t, double degrees_of_freedom) statistic =
                await Task
                            .Run
                                (
                                    () => x.WelchtStatistic(y)
                                )
                            .ConfigureAwait(false);

            return statistic;
        }

        public async static Task<(decimal welch_t, decimal degrees_of_freedom)> CalculateAsync(IEnumerable<decimal> x, IEnumerable<decimal> y)
        {
            (decimal welch_t, decimal degrees_of_freedom) statistic =
                await Task
                            .Run
                                (
                                    () => x.WelchtStatistic(y)
                                )
                            .ConfigureAwait(false);

            return statistic;
        }

        //==============================================================================================================
    }
}
