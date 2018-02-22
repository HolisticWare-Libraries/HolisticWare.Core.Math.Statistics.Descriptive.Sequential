using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Core.Math.Statistics.Descriptive.Sequential
{
	public static partial class IEnumerableExtensionsStandardDeviationPopulation
	{
        public async static Task<double> StandardDeviationPopulationAsync(this IEnumerable<byte> x)
        {
            double standard_deviation =
                await Task
                            .Run
                                (
                                    () => x.StandardDeviationPopulation()
                                )
                            .ConfigureAwait(false);

            return standard_deviation;
        }

        public async static Task<double> StandardDeviationPopulationAsync(this IEnumerable<short> x)
        {
            double standard_deviation = 
                await Task
                            .Run
                                (
                                    () => x.StandardDeviationPopulation()
                                )
                            .ConfigureAwait(false);

            return standard_deviation;
        }

        public async static Task<double> StandardDeviationPopulationAsync(this IEnumerable<ushort> x)
        {
            double standard_deviation = 
                await Task
                            .Run
                                (
                                    () => x.StandardDeviationPopulation()
                                )
                            .ConfigureAwait(false);

            return standard_deviation;
        }

        public async static Task<double> StandardDeviationPopulationAsync(this IEnumerable<int> x)
        {
            double standard_deviation = 
                await Task
                            .Run
                                (
                                    () => x.StandardDeviationPopulation()
                                )
                            .ConfigureAwait(false);

            return standard_deviation;
        }

        public async static Task<double> StandardDeviationPopulationAsync(this IEnumerable<uint> x)
        {
            double standard_deviation = 
                await Task
                            .Run
                                (
                                    () => x.StandardDeviationPopulation()
                                )
                            .ConfigureAwait(false);

            return standard_deviation;
        }

        public async static Task<double> StandardDeviationPopulationAsync(this IEnumerable<long> x)
        {
            double standard_deviation = 
                await Task
                            .Run
                                (
                                    () => x.StandardDeviationPopulation()
                                )
                            .ConfigureAwait(false);

            return standard_deviation;
        }

        public async static Task<double> StandardDeviationPopulationAsync(this IEnumerable<ulong> x)
        {
            double standard_deviation = 
                await Task
                            .Run
                                (
                                    () => x.StandardDeviationPopulation()
                                )
                            .ConfigureAwait(false);

            return standard_deviation;
        }

        public async static Task<double> StandardDeviationPopulationAsync(this IEnumerable<float> x)
        {
            double standard_deviation = 
                await Task
                            .Run
                                (
                                    () => x.StandardDeviationPopulation()
                                )
                            .ConfigureAwait(false);

            return standard_deviation;
        }

        public async static Task<double> StandardDeviationPopulationAsync(this IEnumerable<double> x)
        {
            double standard_deviation = 
                await Task
                            .Run
                                (
                                    () => x.StandardDeviationPopulation()
                                )
                            .ConfigureAwait(false);

            return standard_deviation;
        }

        public async static Task<decimal> StandardDeviationPopulationAsync(this IEnumerable<decimal> x)
        {
            decimal standard_deviation = 
                await Task
                            .Run
                                (
                                    () => x.StandardDeviationPopulation()
                                )
                            .ConfigureAwait(false);

            return standard_deviation;
        }
	}
}
