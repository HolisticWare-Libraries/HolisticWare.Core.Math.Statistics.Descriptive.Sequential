using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Core.Math.Statistics.Descriptive.Sequential
{
	public static partial class IEnumerableExtensionsRange
	{
        //==============================================================================================================
        public async static Task<(short min, short max)> RangeAsync(this IEnumerable<byte> x, IEnumerable<byte> y)
        {
            (short min, short max) range =
                await Task
                            .Run
                                (
                                    () => x.Range()
                                )
                            .ConfigureAwait(false);

            return range;
        }

        public async static Task<(short min, short max)> RangeAsync(this IEnumerable<short> x, IEnumerable<short> y)
        {
            (short min, short max) range = 
                await Task
                            .Run
                                (
                                    () => x.Range()
                                )
                            .ConfigureAwait(false);

            return range;
        }

        public async static Task<(ushort min, ushort max)> RangeAsync(this IEnumerable<ushort> x, IEnumerable<ushort> y)
        {
            (ushort min, ushort max) range = 
                await Task
                            .Run
                                (
                                    () => x.Range()
                                )
                            .ConfigureAwait(false);

            return range;
        }

        public async static Task<(int min, int max)> RangeAsync(this IEnumerable<int> x, IEnumerable<int> y)
        {
            (int min, int max) range = 
                await Task
                            .Run
                                (
                                    () => x.Range()
                                )
                            .ConfigureAwait(false);

            return range;
        }

        public async static Task<(uint min, uint max)> RangeAsync(this IEnumerable<uint> x, IEnumerable<uint> y)
        {
            (uint min, uint max) range = 
                await Task
                            .Run
                                (
                                    () => x.Range()
                                )
                            .ConfigureAwait(false);

            return range;
        }

        public async static Task<(long min, long max)> RangeAsync(this IEnumerable<long> x, IEnumerable<long> y)
        {
            (long min, long max) range = 
                await Task
                            .Run
                                (
                                    () => x.Range()
                                )
                            .ConfigureAwait(false);

            return range;
        }

        public async static Task<(ulong min, ulong max)> RangeAsync(this IEnumerable<ulong> x, IEnumerable<ulong> y)
        {
            (ulong min, ulong max) range = 
                await Task
                            .Run
                                (
                                    () => x.Range()
                                )
                            .ConfigureAwait(false);

            return range;
        }

        public async static Task<(float min, float max)> RangeAsync(this IEnumerable<float> x, IEnumerable<float> y)
        {
            (float min, float max) range = 
                await Task
                            .Run
                                (
                                    () => x.Range()
                                )
                            .ConfigureAwait(false);

            return range;
        }

        public async static Task<(double min, double max)> RangeAsync(this IEnumerable<double> x, IEnumerable<double> y)
        {
            (double min, double max) range = 
                await Task
                            .Run
                                (
                                    () => x.Range()
                                )
                            .ConfigureAwait(false);

            return range;
        }

        public async static Task<(decimal min, decimal max)> RangeAsync(this IEnumerable<decimal> x, IEnumerable<decimal> y)
        {
            (decimal min, decimal max) range = 
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
