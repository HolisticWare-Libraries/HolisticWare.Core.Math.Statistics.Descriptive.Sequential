using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Core.Math.Statistics.Descriptive.Sequential
{
	public static partial class IEnumerableExtensionsMomentCentral
	{
        //==============================================================================================================
        public async static Task<double> MomentCentralAsync(this IEnumerable<byte> x, int m)
        {
            double moment =
                await Task
                            .Run
                                (
                                    () => x.MomentCentral(m)
                                )
                            .ConfigureAwait(false);

            return moment;
        }

        public async static Task<double> MomentCentralAsync(this IEnumerable<short> x, int m)
        {
            double moment = 
                await Task
                            .Run
                                (
                                    () => x.MomentCentral(m)
                                )
                            .ConfigureAwait(false);

            return moment;
        }

        public async static Task<double> MomentCentralAsync(this IEnumerable<ushort> x, int m)
        {
            double moment = 
                await Task
                            .Run
                                (
                                    () => x.MomentCentral(m)
                                )
                            .ConfigureAwait(false);

            return moment;
        }

        public async static Task<double> MomentCentralAsync(this IEnumerable<int> x, int m)
        {
            double moment = 
                await Task
                            .Run
                                (
                                    () => x.MomentCentral(m)
                                )
                            .ConfigureAwait(false);

            return moment;
        }

        public async static Task<double> MomentCentralAsync(this IEnumerable<uint> x, int m)
        {
            double moment = 
                await Task
                            .Run
                                (
                                    () => x.MomentCentral(m)
                                )
                            .ConfigureAwait(false);

            return moment;
        }

        public async static Task<double> MomentCentralAsync(this IEnumerable<long> x, int m)
        {
            double moment = 
                await Task
                            .Run
                                (
                                    () => x.MomentCentral(m)
                                )
                            .ConfigureAwait(false);

            return moment;
        }

        public async static Task<double> MomentCentralAsync(this IEnumerable<ulong> x, int m)
        {
            double moment = 
                await Task
                            .Run
                                (
                                    () => x.MomentCentral(m)
                                )
                            .ConfigureAwait(false);

            return moment;
        }

        public async static Task<double> MomentCentralAsync(this IEnumerable<float> x, int m)
        {
            double moment = 
                await Task
                            .Run
                                (
                                    () => x.MomentCentral(m)
                                )
                            .ConfigureAwait(false);

            return moment;
        }

        public async static Task<double> MomentCentralAsync(this IEnumerable<double> x, int m)
        {
            double moment = 
                await Task
                            .Run
                                (
                                    () => x.MomentCentral(m)
                                )
                            .ConfigureAwait(false);

            return moment;
        }

        public async static Task<decimal> MomentCentralAsync(this IEnumerable<decimal> x, int m)
        {
            decimal moment = 
                await Task
                            .Run
                                (
                                    () => x.MomentCentral(m)
                                )
                            .ConfigureAwait(false);

            return moment;
        }
        //==============================================================================================================
	}
}
