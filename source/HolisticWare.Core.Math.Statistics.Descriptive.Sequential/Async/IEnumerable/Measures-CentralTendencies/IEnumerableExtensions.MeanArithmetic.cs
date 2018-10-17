using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Core.Math.Statistics.Descriptive.Sequential
{
    public static partial class IEnumerableExtensionsMeanArithmetic
    {
        //==============================================================================================================
        public async static Task<double> MeanArithmeticAsync(this IEnumerable<byte> x)
        {
            double mean =
                await Task
                            //.Run
                            .Factory.StartNew
                                (
                                    () => x.MeanArithmetic()
                                )
                            .ConfigureAwait(false);

            return mean;
        }

        public async static Task<double> MeanArithmeticTaskAsync(this IEnumerable<byte> x)
        {
            return x.MeanArithmetic();
        }

        public async static Task<double> MeanArithmeticAsync(this IEnumerable<short> x)
        {
            double mean =
                await Task
                            .Run
                                (
                                    () => x.MeanArithmetic()
                                )
                            .ConfigureAwait(false);

            return mean;
        }

        public async static Task<double> MeanArithmeticAsync(this IEnumerable<ushort> x)
        {
            double mean =
                await Task
                            .Run
                                (
                                    () => x.MeanArithmetic()
                                )
                            .ConfigureAwait(false);

            return mean;
        }

        public async static Task<double> MeanArithmeticAsync(this IEnumerable<int> x)
        {
            double mean =
                await Task
                            .Run
                                (
                                    () => x.MeanArithmetic()
                                )
                            .ConfigureAwait(false);

            return mean;
        }

        public async static Task<double> MeanArithmeticAsync(this IEnumerable<uint> x)
        {
            double mean =
                await Task
                            .Run
                                (
                                    () => x.MeanArithmetic()
                                )
                            .ConfigureAwait(false);

            return mean;
        }

        public async static Task<double> MeanArithmeticAsync(this IEnumerable<long> x)
        {
            double mean =
                await Task
                            .Run
                                (
                                    () => x.MeanArithmetic()
                                )
                            .ConfigureAwait(false);

            return mean;
        }

        public async static Task<double> MeanArithmeticAsync(this IEnumerable<ulong> x)
        {
            double mean =
                await Task
                            .Run
                                (
                                    () => x.MeanArithmetic()
                                )
                            .ConfigureAwait(false);

            return mean;
        }

        public async static Task<double> MeanArithmeticAsync(this IEnumerable<float> x)
        {
            double mean =
                await Task
                            .Run
                                (
                                    () => x.MeanArithmetic()
                                )
                            .ConfigureAwait(false);

            return mean;
        }

        public async static Task<double> MeanArithmeticAsync(this IEnumerable<double> x)
        {
            double mean =
                await Task
                            .Run
                                (
                                    () => x.MeanArithmetic()
                                )
                            .ConfigureAwait(false);

            return mean;
        }

        public async static Task<decimal> MeanArithmeticAsync(this IEnumerable<decimal> x)
        {
            decimal mean =
                await Task
                            .Run
                                (
                                    () => x.MeanArithmetic()
                                )
                            .ConfigureAwait(false);

            return mean;
        }
        //==============================================================================================================
    }
}
