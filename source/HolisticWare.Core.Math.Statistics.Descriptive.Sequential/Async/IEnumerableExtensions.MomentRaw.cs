using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Core.Math.Statistics.Descriptive.Sequential
{
	public static partial class IEnumerableExtensionsMomentRaw
	{
        //==============================================================================================================
        public async static Task<double> MomentRawAsync(this IEnumerable<byte> x, int m)
        {
            double moment =
                await Task
                            .Run
                                (
                                    () => x.MomentRaw(m)
                                )
                            .ConfigureAwait(false);

            return moment;
        }

        public async static Task<double> MomentRawAsync(this IEnumerable<short> x, int m)
        {
            double moment = 
                await Task
                            .Run
                                (
                                    () => x.MomentRaw(m)
                                )
                            .ConfigureAwait(false);

            return moment;
        }

        public async static Task<double> MomentRawAsync(this IEnumerable<ushort> x, int m)
        {
            double moment = 
                await Task
                            .Run
                                (
                                    () => x.MomentRaw(m)
                                )
                            .ConfigureAwait(false);

            return moment;
        }

        public async static Task<double> MomentRawAsync(this IEnumerable<int> x, int m)
        {
            double moment = 
                await Task
                            .Run
                                (
                                    () => x.MomentRaw(m)
                                )
                            .ConfigureAwait(false);

            return moment;
        }

        public async static Task<double> MomentRawAsync(this IEnumerable<uint> x, int m)
        {
            double moment = 
                await Task
                            .Run
                                (
                                    () => x.MomentRaw(m)
                                )
                            .ConfigureAwait(false);

            return moment;
        }

        public async static Task<double> MomentRawAsync(this IEnumerable<long> x, int m)
        {
            double moment = 
                await Task
                            .Run
                                (
                                    () => x.MomentRaw(m)
                                )
                            .ConfigureAwait(false);

            return moment;
        }

        public async static Task<double> MomentRawAsync(this IEnumerable<ulong> x, int m)
        {
            double moment = 
                await Task
                            .Run
                                (
                                    () => x.MomentRaw(m)
                                )
                            .ConfigureAwait(false);

            return moment;
        }

        public async static Task<double> MomentRawAsync(this IEnumerable<float> x, int m)
        {
            double moment = 
                await Task
                            .Run
                                (
                                    () => x.MomentRaw(m)
                                )
                            .ConfigureAwait(false);

            return moment;
        }

        public async static Task<double> MomentRawAsync(this IEnumerable<double> x, int m)
        {
            double moment = 
                await Task
                            .Run
                                (
                                    () => x.MomentRaw(m)
                                )
                            .ConfigureAwait(false);

            return moment;
        }

        public async static Task<decimal> MomentRawAsync(this IEnumerable<decimal> x, int m)
        {
            decimal moment = 
                await Task
                            .Run
                                (
                                    () => x.MomentRaw(m)
                                )
                            .ConfigureAwait(false);

            return moment;
        }
        //==============================================================================================================
	}
}
