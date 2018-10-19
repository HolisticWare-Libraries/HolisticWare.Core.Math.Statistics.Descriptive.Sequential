using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Core.Math.Statistics.Descriptive.Sequential
{
	public static partial class IEnumerableExtensionsMomentRawAbsolute
	{
        //==============================================================================================================
        public async static Task<double> MomentRawAbsoluteAsync(this IEnumerable<byte> x, int m)
        {
            double moment =
                await Task
                            //.Run
                            .Factory.StartNew
                                (
                                    () => x.MomentRawAbsolute(m)
                                )
                            .ConfigureAwait(false);

            return moment;
        }

        public async static Task<double> MomentRawAbsoluteAsync(this IEnumerable<short> x, int m)
        {
            double moment = 
                await Task
                            //.Run
                            .Factory.StartNew
                                (
                                    () => x.MomentRawAbsolute(m)
                                )
                            .ConfigureAwait(false);

            return moment;
        }

        public async static Task<double> MomentRawAbsoluteAsync(this IEnumerable<ushort> x, int m)
        {
            double moment = 
                await Task
                            //.Run
                            .Factory.StartNew
                                (
                                    () => x.MomentRawAbsolute(m)
                                )
                            .ConfigureAwait(false);

            return moment;
        }

        public async static Task<double> MomentRawAbsoluteAsync(this IEnumerable<int> x, int m)
        {
            double moment = 
                await Task
                            //.Run
                            .Factory.StartNew
                                (
                                    () => x.MomentRawAbsolute(m)
                                )
                            .ConfigureAwait(false);

            return moment;
        }

        public async static Task<double> MomentRawAbsoluteAsync(this IEnumerable<uint> x, int m)
        {
            double moment = 
                await Task
                            //.Run
                            .Factory.StartNew
                                (
                                    () => x.MomentRawAbsolute(m)
                                )
                            .ConfigureAwait(false);

            return moment;
        }

        public async static Task<double> MomentRawAbsoluteAsync(this IEnumerable<long> x, int m)
        {
            double moment = 
                await Task
                            //.Run
                            .Factory.StartNew
                                (
                                    () => x.MomentRawAbsolute(m)
                                )
                            .ConfigureAwait(false);

            return moment;
        }

        public async static Task<double> MomentRawAbsoluteAsync(this IEnumerable<ulong> x, int m)
        {
            double moment = 
                await Task
                            //.Run
                            .Factory.StartNew
                                (
                                    () => x.MomentRawAbsolute(m)
                                )
                            .ConfigureAwait(false);

            return moment;
        }

        public async static Task<double> MomentRawAbsoluteAsync(this IEnumerable<float> x, int m)
        {
            double moment = 
                await Task
                            //.Run
                            .Factory.StartNew
                                (
                                    () => x.MomentRawAbsolute(m)
                                )
                            .ConfigureAwait(false);

            return moment;
        }

        public async static Task<double> MomentRawAbsoluteAsync(this IEnumerable<double> x, int m)
        {
            double moment = 
                await Task
                            //.Run
                            .Factory.StartNew
                                (
                                    () => x.MomentRawAbsolute(m)
                                )
                            .ConfigureAwait(false);

            return moment;
        }

        public async static Task<decimal> MomentRawAbsoluteAsync(this IEnumerable<decimal> x, int m)
        {
            decimal moment = 
                await Task
                            //.Run
                            .Factory.StartNew
                                (
                                    () => x.MomentRawAbsolute(m)
                                )
                            .ConfigureAwait(false);

            return moment;
        }
        //==============================================================================================================
	}
}
