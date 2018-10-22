using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Core.Math.Statistics.Descriptive.Sequential
{
    public static partial class IEnumerableExtensionsMeanGeometricNaive
    {
        //==============================================================================================================
        public async static
            Task<double>
                MeanGeometricNaiveAsync
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
                                    () => x.MeanGeometricNaive()
                                )
                            .ConfigureAwait(false);

            return mean;
        }

        public async static
            Task<double>
                MeanGeometricNaiveAsync
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
                                    () => x.MeanGeometricNaive()
                                )
                            .ConfigureAwait(false);

            return mean;
        }

        public async static
            Task<double>
                MeanGeometricNaiveAsync
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
                                    () => x.MeanGeometricNaive()
                                )
                            .ConfigureAwait(false);

            return mean;
        }

        public async static
            Task<double>
                MeanGeometricNaiveAsync
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
                                    () => x.MeanGeometricNaive()
                                )
                            .ConfigureAwait(false);

            return mean;
        }

        public async static
            Task<double>
                MeanGeometricNaiveAsync
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
                                    () => x.MeanGeometricNaive()
                                )
                            .ConfigureAwait(false);

            return mean;
        }

        public async static
            Task<double>
                MeanGeometricNaiveAsync
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
                                    () => x.MeanGeometricNaive()
                                )
                            .ConfigureAwait(false);

            return mean;
        }

        public async static
            Task<double>
                MeanGeometricNaiveAsync
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
                                    () => x.MeanGeometricNaive()
                                )
                            .ConfigureAwait(false);

            return mean;
        }

        public async static
            Task<double>
                MeanGeometricNaiveAsync
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
                                    () => x.MeanGeometricNaive()
                                )
                            .ConfigureAwait(false);

            return mean;
        }

        public async static
            Task<double>
                MeanGeometricNaiveAsync
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
                                    () => x.MeanGeometricNaive()
                                )
                            .ConfigureAwait(false);

            return mean;
        }

        public async static
            Task<decimal>
                MeanGeometricNaiveAsync
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
                                    () => x.MeanGeometricNaive()
                                )
                            .ConfigureAwait(false);

            return mean;
        }

        //==============================================================================================================
    }
}
