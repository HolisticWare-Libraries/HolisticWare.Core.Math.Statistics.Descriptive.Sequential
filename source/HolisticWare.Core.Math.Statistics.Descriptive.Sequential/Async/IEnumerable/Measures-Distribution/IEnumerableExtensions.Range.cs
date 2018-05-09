using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Core.Math.Statistics.Descriptive.Sequential
{
	public static partial class IEnumerableExtensionsRange
	{
        //==============================================================================================================
		public async static Task<(byte Min, byte Max, byte Delta)> RangeAsync
                                                            (
                                                                this IEnumerable<byte> x,
                                                                IEnumerable<byte> y
                                                            )
        {
			(byte Min, byte Max, byte Delta) range =
                await Task
                            .Run
                                (
                                    () => x.Range()
                                )
                            .ConfigureAwait(false);

            return range;
        }

        public async static Task<(short Min, short Max, short Delta)> RangeAsync
		                                                    (
			                                                    this IEnumerable<short> x, 
			                                                    IEnumerable<short> y
		                                                    )
        {
            (short Min, short Max, short Delta) range =
                await Task
                            .Run
                                (
                                    () => x.Range()
                                )
                            .ConfigureAwait(false);

            return range;
        }

		public async static Task<(ushort Min, ushort Max, ushort Delta)> RangeAsync
                                                            (
                                                                this IEnumerable<ushort> x,
                                                                IEnumerable<ushort> y
                                                            )
        {
            (ushort Min, ushort Max, ushort Delta) range =
                await Task
                            .Run
                                (
                                    () => x.Range()
                                )
                            .ConfigureAwait(false);

            return range;
        }

		public async static Task<(int Min, int Max, int Delta)> RangeAsync
                                                            (
                                                                this IEnumerable<int> x,
                                                                IEnumerable<int> y
                                                            )
        {
            (int Min, int Max, int Delta) range =
                await Task
                            .Run
                                (
                                    () => x.Range()
                                )
                            .ConfigureAwait(false);

            return range;
        }
        
		public async static Task<(uint Min, uint Max, uint Delta)> RangeAsync
                                                            (
                                                                this IEnumerable<uint> x,
                                                                IEnumerable<uint> y
                                                            )
        {
            (uint Min, uint Max, uint Delta) range =
                await Task
                            .Run
                                (
                                    () => x.Range()
                                )
                            .ConfigureAwait(false);

            return range;
        }

		public async static Task<(long Min, long Max, long Delta)> RangeAsync
                                                            (
                                                                this IEnumerable<long> x,
                                                                IEnumerable<long> y
                                                            )
        {
            (long Min, long Max, long Delta) range =
                await Task
                            .Run
                                (
                                    () => x.Range()
                                )
                            .ConfigureAwait(false);

            return range;
        }
        
		public async static Task<(ulong Min, ulong Max, ulong Delta)> RangeAsync
                                                            (
                                                                this IEnumerable<ulong> x,
                                                                IEnumerable<ulong> y
                                                            )
        {
            (ulong Min, ulong Max, ulong Delta) range =
                await Task
                            .Run
                                (
                                    () => x.Range()
                                )
                            .ConfigureAwait(false);

            return range;
        }

		public async static Task<(float Min, float Max, float Delta)> RangeAsync
                                                            (
                                                                this IEnumerable<float> x,
                                                                IEnumerable<float> y
                                                            )
        {
            (float Min, float Max, float Delta) range =
                await Task
                            .Run
                                (
                                    () => x.Range()
                                )
                            .ConfigureAwait(false);

            return range;
        }

		public async static Task<(double Min, double Max, double Delta)> RangeAsync
                                                            (
                                                                this IEnumerable<double> x,
                                                                IEnumerable<double> y
                                                            )
        {
            (double Min, double Max, double Delta) range =
                await Task
                            .Run
                                (
                                    () => x.Range()
                                )
                            .ConfigureAwait(false);

            return range;
        }

		public async static Task<(decimal Min, decimal Max, decimal Delta)> RangeAsync
                                                            (
                                                                this IEnumerable<decimal> x, 
                                                                IEnumerable<decimal> y
                                                            )
        {
            (decimal Min, decimal Max, decimal Delta) range =
                await Task
                            .Run
                                (
                                    () => x.Range()
                                )
                            .ConfigureAwait(false);

            return range;
        }
        //==============================================================================================================
	}
}
