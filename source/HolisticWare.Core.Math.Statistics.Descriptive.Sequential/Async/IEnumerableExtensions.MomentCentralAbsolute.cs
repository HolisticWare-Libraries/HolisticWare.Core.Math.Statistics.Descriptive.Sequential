using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Core.Math.Statistics.Descriptive.Sequential
{
	public static partial class IEnumerableExtensionsMomentCentralAbsolute
	{
        //==============================================================================================================
        public async static Task<double> MomentCentralAbsoluteAsync(this IEnumerable<byte> x, int m)
        {
            double moment =
                await Task
                            .Run
                                (
                                    () => x.MomentCentralAbsolute(m)
                                )
                            .ConfigureAwait(false);

            return moment;
        }

        public async static Task<double> MomentCentralAbsoluteAsync(this IEnumerable<short> x, int m)
        {
            double moment = 
                await Task
                            .Run
                                (
                                    () => x.MomentCentralAbsolute(m)
                                )
                            .ConfigureAwait(false);

            return moment;
        }

        public async static Task<double> MomentCentralAbsoluteAsync(this IEnumerable<ushort> x, int m)
        {
            double moment = 
                await Task
                            .Run
                                (
                                    () => x.MomentCentralAbsolute(m)
                                )
                            .ConfigureAwait(false);

            return moment;
        }

        public async static Task<double> MomentCentralAbsoluteAsync(this IEnumerable<int> x, int m)
        {
            double moment = 
                await Task
                            .Run
                                (
                                    () => x.MomentCentralAbsolute(m)
                                )
                            .ConfigureAwait(false);

            return moment;
        }

        public async static Task<double> MomentCentralAbsoluteAsync(this IEnumerable<uint> x, int m)
        {
            double moment = 
                await Task
                            .Run
                                (
                                    () => x.MomentCentralAbsolute(m)
                                )
                            .ConfigureAwait(false);

            return moment;
        }

        public async static Task<double> MomentCentralAbsoluteAsync(this IEnumerable<long> x, int m)
        {
            double moment = 
                await Task
                            .Run
                                (
                                    () => x.MomentCentralAbsolute(m)
                                )
                            .ConfigureAwait(false);

            return moment;
        }

        public async static Task<double> MomentCentralAbsoluteAsync(this IEnumerable<ulong> x, int m)
        {
            double moment = 
                await Task
                            .Run
                                (
                                    () => x.MomentCentralAbsolute(m)
                                )
                            .ConfigureAwait(false);

            return moment;
        }

        public async static Task<double> MomentCentralAbsoluteAsync(this IEnumerable<float> x, int m)
        {
            double moment = 
                await Task
                            .Run
                                (
                                    () => x.MomentCentralAbsolute(m)
                                )
                            .ConfigureAwait(false);

            return moment;
        }

        public async static Task<double> MomentCentralAbsoluteAsync(this IEnumerable<double> x, int m)
        {
            double moment = 
                await Task
                            .Run
                                (
                                    () => x.MomentCentralAbsolute(m)
                                )
                            .ConfigureAwait(false);

            return moment;
        }

        public async static Task<decimal> MomentCentralAbsoluteAsync(this IEnumerable<decimal> x, int m)
        {
            decimal moment = 
                await Task
                            .Run
                                (
                                    () => x.MomentCentralAbsolute(m)
                                )
                            .ConfigureAwait(false);

            return moment;
        }
        //==============================================================================================================
	}
}
