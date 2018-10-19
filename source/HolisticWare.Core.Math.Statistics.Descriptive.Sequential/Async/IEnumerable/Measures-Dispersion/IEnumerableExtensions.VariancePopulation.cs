using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Core.Math.Statistics.Descriptive.Sequential
{
    public static partial class IEnumerableExtensionsVariancePopulation
    {
        //==============================================================================================================
        public async static Task<double> VariancePopulationAsync(this IEnumerable<byte> x)
        {
            double variance =
                await Task
                            //.Run
                            .Factory.StartNew
                                (
                                    () => x.VariancePopulation()
                                )
                            .ConfigureAwait(false);

            return variance;
        }

        public async static Task<double> VariancePopulationAsync(this IEnumerable<short> x)
        {
            double variance =
                await Task
                            //.Run
                            .Factory.StartNew
                                (
                                    () => x.VariancePopulation()
                                )
                            .ConfigureAwait(false);

            return variance;
        }

        public async static Task<double> VariancePopulationAsync(this IEnumerable<ushort> x)
        {
            double variance =
                await Task
                            //.Run
                            .Factory.StartNew
                                (
                                    () => x.VariancePopulation()
                                )
                            .ConfigureAwait(false);

            return variance;
        }

        public async static Task<double> VariancePopulationAsync(this IEnumerable<int> x)
        {
            double variance =
                await Task
                            //.Run
                            .Factory.StartNew
                                (
                                    () => x.VariancePopulation()
                                )
                            .ConfigureAwait(false);

            return variance;
        }

        public async static Task<double> VariancePopulationAsync(this IEnumerable<uint> x)
        {
            double variance =
                await Task
                            //.Run
                            .Factory.StartNew
                                (
                                    () => x.VariancePopulation()
                                )
                            .ConfigureAwait(false);

            return variance;
        }

        public async static Task<double> VariancePopulationAsync(this IEnumerable<long> x)
        {
            double variance =
                await Task
                            //.Run
                            .Factory.StartNew
                                (
                                    () => x.VariancePopulation()
                                )
                            .ConfigureAwait(false);

            return variance;
        }

        public async static Task<double> VariancePopulationAsync(this IEnumerable<ulong> x)
        {
            double variance =
                await Task
                            //.Run
                            .Factory.StartNew
                                (
                                    () => x.VariancePopulation()
                                )
                            .ConfigureAwait(false);

            return variance;
        }

        public async static Task<double> VariancePopulationAsync(this IEnumerable<float> x)
        {
            double variance =
                await Task
                            //.Run
                            .Factory.StartNew
                                (
                                    () => x.VariancePopulation()
                                )
                            .ConfigureAwait(false);

            return variance;
        }

        public async static Task<double> VariancePopulationAsync(this IEnumerable<double> x)
        {
            double variance =
                await Task
                            //.Run
                            .Factory.StartNew
                                (
                                    () => x.VariancePopulation()
                                )
                            .ConfigureAwait(false);

            return variance;
        }

        public async static Task<decimal> VariancePopulationAsync(this IEnumerable<decimal> x)
        {
            decimal variance =
                await Task
                            //.Run
                            .Factory.StartNew
                                (
                                    () => x.VariancePopulation()
                                )
                            .ConfigureAwait(false);

            return variance;
        }
        //==============================================================================================================
    }
}
