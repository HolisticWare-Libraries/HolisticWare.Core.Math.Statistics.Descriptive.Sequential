using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Core.Math.Statistics.Descriptive.Sequential
{
	public static partial class IEnumerableExtensionsMoment
	{
        //==============================================================================================================
        public async static Task<double> MomentAsync(this IEnumerable<byte> x, int m)
        {
            double moment =
                await Task
                            .Run
                                (
                                    () => x.Moment(m)
                                )
                            .ConfigureAwait(false);

            return moment;
        }

        public async static Task<double> MomentAsync(this IEnumerable<short> x, int m)
        {
            double moment = 
                await Task
                            .Run
                                (
                                    () => x.Moment(m)
                                )
                            .ConfigureAwait(false);

            return moment;
        }

        public async static Task<double> MomentAsync(this IEnumerable<ushort> x, int m)
        {
            double moment = 
                await Task
                            .Run
                                (
                                    () => x.Moment(m)
                                )
                            .ConfigureAwait(false);

            return moment;
        }

        public async static Task<double> MomentAsync(this IEnumerable<int> x, int m)
        {
            double moment = 
                await Task
                            .Run
                                (
                                    () => x.Moment(m)
                                )
                            .ConfigureAwait(false);

            return moment;
        }

        public async static Task<double> MomentAsync(this IEnumerable<uint> x, int m)
        {
            double moment = 
                await Task
                            .Run
                                (
                                    () => x.Moment(m)
                                )
                            .ConfigureAwait(false);

            return moment;
        }

        public async static Task<double> MomentAsync(this IEnumerable<long> x, int m)
        {
            double moment = 
                await Task
                            .Run
                                (
                                    () => x.Moment(m)
                                )
                            .ConfigureAwait(false);

            return moment;
        }

        public async static Task<double> MomentAsync(this IEnumerable<ulong> x, int m)
        {
            double moment = 
                await Task
                            .Run
                                (
                                    () => x.Moment(m)
                                )
                            .ConfigureAwait(false);

            return moment;
        }

        public async static Task<double> MomentAsync(this IEnumerable<float> x, int m)
        {
            double moment = 
                await Task
                            .Run
                                (
                                    () => x.Moment(m)
                                )
                            .ConfigureAwait(false);

            return moment;
        }

        public async static Task<double> MomentAsync(this IEnumerable<double> x, int m)
        {
            double moment = 
                await Task
                            .Run
                                (
                                    () => x.Moment(m)
                                )
                            .ConfigureAwait(false);

            return moment;
        }

        public async static Task<decimal> MomentAsync(this IEnumerable<decimal> x, int m)
        {
            decimal moment = 
                await Task
                            .Run
                                (
                                    () => x.Moment(m)
                                )
                            .ConfigureAwait(false);

            return moment;
        }
        //==============================================================================================================
	}
}
