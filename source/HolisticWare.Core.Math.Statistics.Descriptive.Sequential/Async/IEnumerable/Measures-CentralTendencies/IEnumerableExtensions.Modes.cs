using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Core.Math.Statistics.Descriptive.Sequential
{
    public static partial class IEnumerableExtensionsModes
    {
        //==============================================================================================================
        public async static Task<List<byte>> ModesAsync(this IEnumerable<byte> x)
        {
            List<byte> modes =
                await Task
                            .Run
                                (
                                    () => x.Modes()
                                )
                            .ConfigureAwait(false);

            return modes;
        }

        public async static Task<List<short>> ModesAsync(this IEnumerable<short> x)
        {
            List<short> modes =
                await Task
                            .Run
                                (
                                    () => x.Modes()
                                )
                            .ConfigureAwait(false);

            return modes;
        }

        public async static Task<List<ushort>> ModesAsync(this IEnumerable<ushort> x)
        {
            List<ushort> modes =
                await Task
                            .Run
                                (
                                    () => x.Modes()
                                )
                            .ConfigureAwait(false);

            return modes;
        }

        public async static Task<List<int>> ModesAsync(this IEnumerable<int> x)
        {
            List<int> modes =
                await Task
                            .Run
                                (
                                    () => x.Modes()
                                )
                            .ConfigureAwait(false);

            return modes;
        }

        public async static Task<List<uint>> ModesAsync(this IEnumerable<uint> x)
        {
            List<uint> modes =
                await Task
                            .Run
                                (
                                    () => x.Modes()
                                )
                            .ConfigureAwait(false);

            return modes;
        }

        public async static Task<List<long>> ModesAsync(this IEnumerable<long> x)
        {
            List<long> modes =
                await Task
                            .Run
                                (
                                    () => x.Modes()
                                )
                            .ConfigureAwait(false);

            return modes;
        }

        public async static Task<List<ulong>> ModesAsync(this IEnumerable<ulong> x)
        {
            List<ulong> modes =
                await Task
                            .Run
                                (
                                    () => x.Modes()
                                )
                            .ConfigureAwait(false);

            return modes;
        }

        public async static Task<List<float>> ModesAsync(this IEnumerable<float> x)
        {
            List<float> modes =
                await Task
                            .Run
                                (
                                    () => x.Modes()
                                )
                            .ConfigureAwait(false);

            return modes;
        }

        public async static Task<List<double>> ModesAsync(this IEnumerable<double> x)
        {
            List<double> modes =
                await Task
                            .Run
                                (
                                    () => x.Modes()
                                )
                            .ConfigureAwait(false);

            return modes;
        }

        public async static Task<List<decimal>> ModesAsync(this IEnumerable<decimal> x)
        {
            List<decimal> modes =
                await Task
                            .Run
                                (
                                    () => x.Modes()
                                )
                            .ConfigureAwait(false);

            return modes;
        }
        //==============================================================================================================
    }
}
