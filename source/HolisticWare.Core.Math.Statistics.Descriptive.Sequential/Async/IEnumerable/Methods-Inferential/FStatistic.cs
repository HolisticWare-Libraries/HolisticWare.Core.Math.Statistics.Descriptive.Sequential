using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Core.Math.Statistics.Descriptive.Sequential
{
    public static partial class FStatistic
    {
        //==============================================================================================================
        public async static Task<double> CalculateAsync(IEnumerable<byte> x, IEnumerable<byte> y)
        {
            double statistic =
                await Task
                            //.Run
                            .Factory.StartNew
                                (
                                    () => x.FStatistic(y)
                                )
                            .ConfigureAwait(false);

            return statistic;
        }

        public async static Task<double> CalculateAsync(IEnumerable<short> x, IEnumerable<short> y)
        {
            double statistic =
                await Task
                            //.Run
                            .Factory.StartNew
                                (
                                    () => x.FStatistic(y)
                                )
                            .ConfigureAwait(false);

            return statistic;
        }

        public async static Task<double> CalculateAsync(IEnumerable<ushort> x, IEnumerable<ushort> y)
        {
            double statistic =
                await Task
                            //.Run
                            .Factory.StartNew
                                (
                                    () => x.FStatistic(y)
                                )
                            .ConfigureAwait(false);

            return statistic;
        }

        public async static Task<double> CalculateAsync(IEnumerable<int> x, IEnumerable<int> y)
        {
            double statistic =
                await Task
                            //.Run
                            .Factory.StartNew
                                (
                                    () => x.FStatistic(y)
                                )
                            .ConfigureAwait(false);

            return statistic;
        }

        public async static Task<double> CalculateAsync(IEnumerable<uint> x, IEnumerable<uint> y)
        {
            double statistic =
                await Task
                            //.Run
                            .Factory.StartNew
                                (
                                    () => x.FStatistic(y)
                                )
                            .ConfigureAwait(false);

            return statistic;
        }

        public async static Task<double> CalculateAsync(IEnumerable<long> x, IEnumerable<long> y)
        {
            double statistic =
                await Task
                            //.Run
                            .Factory.StartNew
                                (
                                    () => x.FStatistic(y)
                                )
                            .ConfigureAwait(false);

            return statistic;
        }

        public async static Task<double> CalculateAsync(IEnumerable<ulong> x, IEnumerable<ulong> y)
        {
            double statistic =
                await Task
                            //.Run
                            .Factory.StartNew
                                (
                                    () => x.FStatistic(y)
                                )
                            .ConfigureAwait(false);

            return statistic;
        }

        public async static Task<double> CalculateAsync(IEnumerable<float> x, IEnumerable<float> y)
        {
            double statistic =
                await Task
                            //.Run
                            .Factory.StartNew
                                (
                                    () => x.FStatistic(y)
                                )
                            .ConfigureAwait(false);

            return statistic;
        }

        public async static Task<double> CalculateAsync(IEnumerable<double> x, IEnumerable<double> y)
        {
            double statistic =
                await Task
                            //.Run
                            .Factory.StartNew
                                (
                                    () => x.FStatistic(y)
                                )
                            .ConfigureAwait(false);

            return statistic;
        }

        public async static Task<decimal> CalculateAsync(IEnumerable<decimal> x, IEnumerable<decimal> y)
        {
            decimal statistic =
                await Task
                            //.Run
                            .Factory.StartNew
                                (
                                    () => x.FStatistic(y)
                                )
                            .ConfigureAwait(false);

            return statistic;
        }
        //==============================================================================================================
    }
}
