using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Core.Math.Statistics.Descriptive.Sequential
{
    public static partial class IEnumerableExtensionsStudenttStatisticIndependent
    {
        //==============================================================================================================
        public async static Task<double> StudenttStatisticIndependentAsync(this IEnumerable<byte> x, IEnumerable<byte> y)
        {
            double statistics =
                await Task
                            //.Run
                            .Factory.StartNew
                                (
                                    () => x.StudenttStatisticIndependent(y)
                                )
                            .ConfigureAwait(false);

            return statistics;
        }

        public async static Task<double> StudenttStatisticIndependentAsync(this IEnumerable<short> x, IEnumerable<short> y)
        {
            double statistics =
                await Task
                            //.Run
                            .Factory.StartNew
                                (
                                    () => x.StudenttStatisticIndependent(y)
                                )
                            .ConfigureAwait(false);

            return statistics;
        }

        public async static Task<double> StudenttStatisticIndependentAsync(this IEnumerable<ushort> x, IEnumerable<ushort> y)
        {
            double statistics =
                await Task
                            //.Run
                            .Factory.StartNew
                                (
                                    () => x.StudenttStatisticIndependent(y)
                                )
                            .ConfigureAwait(false);

            return statistics;
        }

        public async static Task<double> StudenttStatisticIndependentAsync(this IEnumerable<int> x, IEnumerable<int> y)
        {
            double statistics =
                await Task
                            //.Run
                            .Factory.StartNew
                                (
                                    () => x.StudenttStatisticIndependent(y)
                                )
                            .ConfigureAwait(false);

            return statistics;
        }

        public async static Task<double> StudenttStatisticIndependentAsync(this IEnumerable<uint> x, IEnumerable<uint> y)
        {
            double statistics =
                await Task
                            //.Run
                            .Factory.StartNew
                                (
                                    () => x.StudenttStatisticIndependent(y)
                                )
                            .ConfigureAwait(false);

            return statistics;
        }

        public async static Task<double> StudenttStatisticIndependentAsync(this IEnumerable<long> x, IEnumerable<long> y)
        {
            double statistics =
                await Task
                            //.Run
                            .Factory.StartNew
                                (
                                    () => x.StudenttStatisticIndependent(y)
                                )
                            .ConfigureAwait(false);

            return statistics;
        }

        public async static Task<double> StudenttStatisticIndependentAsync(this IEnumerable<ulong> x, IEnumerable<ulong> y)
        {
            double statistics =
                await Task
                            //.Run
                            .Factory.StartNew
                                (
                                    () => x.StudenttStatisticIndependent(y)
                                )
                            .ConfigureAwait(false);

            return statistics;
        }

        public async static Task<double> StudenttStatisticIndependentAsync(this IEnumerable<float> x, IEnumerable<float> y)
        {
            double statistics =
                await Task
                            //.Run
                            .Factory.StartNew
                                (
                                    () => x.StudenttStatisticIndependent(y)
                                )
                            .ConfigureAwait(false);

            return statistics;
        }

        public async static Task<double> StudenttStatisticIndependentAsync(this IEnumerable<double> x, IEnumerable<double> y)
        {
            double statistics =
                await Task
                            //.Run
                            .Factory.StartNew
                                (
                                    () => x.StudenttStatisticIndependent(y)
                                )
                            .ConfigureAwait(false);

            return statistics;
        }

        public async static Task<decimal> StudenttStatisticIndependentAsync(this IEnumerable<decimal> x, IEnumerable<decimal> y)
        {
            decimal statistics =
                await Task
                            //.Run
                            .Factory.StartNew
                                (
                                    () => x.StudenttStatisticIndependent(y)
                                )
                            .ConfigureAwait(false);

            return statistics;
        }
        //==============================================================================================================
    }
}
