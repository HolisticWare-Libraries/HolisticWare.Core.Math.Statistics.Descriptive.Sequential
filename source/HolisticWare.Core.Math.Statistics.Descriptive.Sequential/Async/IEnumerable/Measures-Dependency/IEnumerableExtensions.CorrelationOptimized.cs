using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Core.Math.Statistics.Descriptive.Sequential
{
	public static partial class IEnumerableExtensionsCorrelation
	{
        //==============================================================================================================
        public async static Task<double> CorrelationOptimizedAsync(this IEnumerable<byte> x, IEnumerable<byte> y)
        {
            double correlation =
                await Task
                            .Run
                                (
                                    () => x.CorrelationOptimized(y)
                                )
                            .ConfigureAwait(false);

            return correlation;
        }

        public async static Task<double> CorrelationOptimizedAsync(this IEnumerable<short> x, IEnumerable<short> y)
        {
            double correlation = 
                await Task
                            .Run
                                (
                                    () => x.CorrelationOptimized(y)
                                )
                            .ConfigureAwait(false);

            return correlation;
        }

        public async static Task<double> CorrelationOptimizedAsync(this IEnumerable<ushort> x, IEnumerable<ushort> y)
        {
            double correlation = 
                await Task
                            .Run
                                (
                                    () => x.CorrelationOptimized(y)
                                )
                            .ConfigureAwait(false);

            return correlation;
        }

        public async static Task<double> CorrelationOptimizedAsync(this IEnumerable<int> x, IEnumerable<int> y)
        {
            double correlation = 
                await Task
                            .Run
                                (
                                    () => x.CorrelationOptimized(y)
                                )
                            .ConfigureAwait(false);

            return correlation;
        }

        public async static Task<double> CorrelationOptimizedAsync(this IEnumerable<uint> x, IEnumerable<uint> y)
        {
            double correlation = 
                await Task
                            .Run
                                (
                                    () => x.CorrelationOptimized(y)
                                )
                            .ConfigureAwait(false);

            return correlation;
        }

        public async static Task<double> CorrelationOptimizedAsync(this IEnumerable<long> x, IEnumerable<long> y)
        {
            double correlation = 
                await Task
                            .Run
                                (
                                    () => x.CorrelationOptimized(y)
                                )
                            .ConfigureAwait(false);

            return correlation;
        }

        public async static Task<double> CorrelationOptimizedAsync(this IEnumerable<ulong> x, IEnumerable<ulong> y)
        {
            double correlation = 
                await Task
                            .Run
                                (
                                    () => x.CorrelationOptimized(y)
                                )
                            .ConfigureAwait(false);

            return correlation;
        }

        public async static Task<double> CorrelationOptimizedAsync(this IEnumerable<float> x, IEnumerable<float> y)
        {
            double correlation = 
                await Task
                            .Run
                                (
                                    () => x.CorrelationOptimized(y)
                                )
                            .ConfigureAwait(false);

            return correlation;
        }

        public async static Task<double> CorrelationOptimizedAsync(this IEnumerable<double> x, IEnumerable<double> y)
        {
            double correlation = 
                await Task
                            .Run
                                (
                                    () => x.CorrelationOptimized(y)
                                )
                            .ConfigureAwait(false);

            return correlation;
        }

        public async static Task<decimal> CorrelationOptimizedAsync(this IEnumerable<decimal> x, IEnumerable<decimal> y)
        {
            decimal correlation = 
                await Task
                            .Run
                                (
                                    () => x.CorrelationOptimized(y)
                                )
                            .ConfigureAwait(false);

            return correlation;
        }
        //==============================================================================================================
	}
}
