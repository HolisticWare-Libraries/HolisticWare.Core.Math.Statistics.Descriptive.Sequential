using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Core.Math.Statistics.Descriptive.Sequential
{
    public static partial class IEnumerableExtensionsMeanGeometricWeighted
    {
        //==============================================================================================================
        public async static
            Task<double>
                MeanGeometricWeightedAsync
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
                                    () => x.MeanGeometricWeighted(w)
                                )
                            .ConfigureAwait(false);

            return mean;
        }

        public async static
            Task<double>
                MeanGeometricWeightedAsync
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
                                    () => x.MeanGeometricWeighted(w)
                                )
                            .ConfigureAwait(false);

            return mean;
        }

        public async static
            Task<double>
                MeanGeometricWeightedAsync
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
                                    () => x.MeanGeometricWeighted(w)
                                )
                            .ConfigureAwait(false);

            return mean;
        }

        public async static
            Task<double>
                MeanGeometricWeightedAsync
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
                                    () => x.MeanGeometricWeighted(w)
                                )
                            .ConfigureAwait(false);

            return mean;
        }

        public async static
            Task<double>
                MeanGeometricWeightedAsync
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
                                    () => x.MeanGeometricWeighted(w)
                                )
                            .ConfigureAwait(false);

            return mean;
        }

        public async static
            Task<double>
                MeanGeometricWeightedAsync
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
                                    () => x.MeanGeometricWeighted(w)
                                )
                            .ConfigureAwait(false);

            return mean;
        }

        public async static
            Task<double>
                MeanGeometricWeightedAsync
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
                                    () => x.MeanGeometricWeighted(w)
                                )
                            .ConfigureAwait(false);

            return mean;
        }

        public async static
            Task<double>
                MeanGeometricWeightedAsync
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
                                    () => x.MeanGeometricWeighted(w)
                                )
                            .ConfigureAwait(false);

            return mean;
        }

        public async static
            Task<double>
                MeanGeometricWeightedAsync
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
                                    () => x.MeanGeometricWeighted(w)
                                )
                            .ConfigureAwait(false);

            return mean;
        }

        public async static
            Task<decimal>
                MeanGeometricWeightedAsync
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
                                    () => x.MeanGeometricWeighted(w)
                                )
                            .ConfigureAwait(false);

            return mean;
        }

        //==============================================================================================================
    }
}
