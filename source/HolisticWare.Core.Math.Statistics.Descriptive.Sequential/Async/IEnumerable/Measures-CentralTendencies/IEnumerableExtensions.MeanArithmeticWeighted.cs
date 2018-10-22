using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Core.Math.Statistics.Descriptive.Sequential
{
    public static partial class IEnumerableExtensionsMeanArithmeticWeighted
    {
        //==============================================================================================================
        public async static
            Task<double>
                MeanArithmeticWeightedAsync
                                        (
                                            this IEnumerable<byte> x,
                                            IEnumerable<double> w
                                        )
        {
            double mean =
                await Task
                            //.Run
                            .Factory.StartNew
                                (
                                    () => x.MeanArithmeticWeighted(w)
                                )
                            .ConfigureAwait(false);

            return mean;
        }

        public async static
            Task<double>
                MeanArithmeticWeightedAsync
                                        (
                                            this IEnumerable<short> x,
                                            IEnumerable<double> w
                                        )
        {
            double mean =
                await Task
                            //.Run
                            .Factory.StartNew
                                (
                                    () => x.MeanArithmeticWeighted(w)
                                )
                            .ConfigureAwait(false);

            return mean;
        }

        public async static
            Task<double>
                MeanArithmeticWeightedAsync
                                        (
                                            this IEnumerable<ushort> x,
                                            IEnumerable<double> w
                                        )
        {
            double mean =
                await Task
                            //.Run
                            .Factory.StartNew
                                (
                                    () => x.MeanArithmeticWeighted(w)
                                )
                            .ConfigureAwait(false);

            return mean;
        }

        public async static
            Task<double>
                MeanArithmeticWeightedAsync
                                        (
                                            this IEnumerable<int> x,
                                            IEnumerable<double> w
                                        )
        {
            double mean =
                await Task
                            //.Run
                            .Factory.StartNew
                                (
                                    () => x.MeanArithmeticWeighted(w)
                                )
                            .ConfigureAwait(false);

            return mean;
        }

        public async static
            Task<double>
                MeanArithmeticWeightedAsync
                                        (
                                            this IEnumerable<uint> x,
                                            IEnumerable<double> w
                                        )
        {
            double mean =
                await Task
                            //.Run
                            .Factory.StartNew
                                (
                                    () => x.MeanArithmeticWeighted(w)
                                )
                            .ConfigureAwait(false);

            return mean;
        }

        public async static
            Task<double>
                MeanArithmeticWeightedAsync
                                        (
                                            this IEnumerable<long> x,
                                            IEnumerable<double> w
                                        )
        {
            double mean =
                await Task
                            //.Run
                            .Factory.StartNew
                                (
                                    () => x.MeanArithmeticWeighted(w)
                                )
                            .ConfigureAwait(false);

            return mean;
        }

        public async static
            Task<double>
                MeanArithmeticWeightedAsync
                                        (
                                            this IEnumerable<ulong> x,
                                            IEnumerable<double> w
                                        )
        {
            double mean =
                await Task
                            //.Run
                            .Factory.StartNew
                                (
                                    () => x.MeanArithmeticWeighted(w)
                                )
                            .ConfigureAwait(false);

            return mean;
        }

        public async static
            Task<double>
                MeanArithmeticWeightedAsync
                                        (
                                            this IEnumerable<float> x,
                                            IEnumerable<double> w
                                        )
        {
            double mean =
                await Task
                            //.Run
                            .Factory.StartNew
                                (
                                    () => x.MeanArithmeticWeighted(w)
                                )
                            .ConfigureAwait(false);

            return mean;
        }

        public async static
            Task<double>
                MeanArithmeticWeightedAsync
                                        (
                                            this IEnumerable<double> x,
                                            IEnumerable<double> w
                                        )
        {
            double mean =
                await Task
                            //.Run
                            .Factory.StartNew
                                (
                                    () => x.MeanArithmeticWeighted(w)
                                )
                            .ConfigureAwait(false);

            return mean;
        }

        public async static
            Task<decimal>
                MeanArithmeticWeightedAsync
                                        (
                                            this IEnumerable<decimal> x,
                                            IEnumerable<double> w
                                        )
        {
            decimal mean =
                await Task
                            //.Run
                            .Factory.StartNew
                                (
                                    () => x.MeanArithmeticWeighted(w)
                                )
                            .ConfigureAwait(false);

            return mean;
        }

        //==============================================================================================================
    }
}
