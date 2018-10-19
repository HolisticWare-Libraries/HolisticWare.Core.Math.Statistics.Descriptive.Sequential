using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Core.Math.Statistics.Descriptive.Sequential
{
    public static partial class IEnumerableExtensionsKurtosis
    {
        //==============================================================================================================
        public async static Task<double> KurtosisAsync(this IEnumerable<byte> x, IEnumerable<byte> y)
        {
            double kurtosis =
                await Task
                            //.Run
                            .Factory.StartNew
                                (
                                    () => x.Kurtosis()
                                )
                            .ConfigureAwait(false);

            return kurtosis;
        }

        public async static Task<double> KurtosisAsync(this IEnumerable<short> x, IEnumerable<short> y)
        {
            double kurtosis =
                await Task
                            //.Run
                            .Factory.StartNew
                                (
                                    () => x.Kurtosis()
                                )
                            .ConfigureAwait(false);

            return kurtosis;
        }

        public async static Task<double> KurtosisAsync(this IEnumerable<ushort> x, IEnumerable<ushort> y)
        {
            double kurtosis =
                await Task
                            //.Run
                            .Factory.StartNew
                                (
                                    () => x.Kurtosis()
                                )
                            .ConfigureAwait(false);

            return kurtosis;
        }

        public async static Task<double> KurtosisAsync(this IEnumerable<int> x, IEnumerable<int> y)
        {
            double kurtosis =
                await Task
                            //.Run
                            .Factory.StartNew
                                (
                                    () => x.Kurtosis()
                                )
                            .ConfigureAwait(false);

            return kurtosis;
        }

        public async static Task<double> KurtosisAsync(this IEnumerable<uint> x, IEnumerable<uint> y)
        {
            double kurtosis =
                await Task
                            //.Run
                            .Factory.StartNew
                                (
                                    () => x.Kurtosis()
                                )
                            .ConfigureAwait(false);

            return kurtosis;
        }

        public async static Task<double> KurtosisAsync(this IEnumerable<long> x, IEnumerable<long> y)
        {
            double kurtosis =
                await Task
                            //.Run
                            .Factory.StartNew
                                (
                                    () => x.Kurtosis()
                                )
                            .ConfigureAwait(false);

            return kurtosis;
        }

        public async static Task<double> KurtosisAsync(this IEnumerable<ulong> x, IEnumerable<ulong> y)
        {
            double kurtosis =
                await Task
                            //.Run
                            .Factory.StartNew
                                (
                                    () => x.Kurtosis()
                                )
                            .ConfigureAwait(false);

            return kurtosis;
        }

        public async static Task<double> KurtosisAsync(this IEnumerable<float> x, IEnumerable<float> y)
        {
            double kurtosis =
                await Task
                            //.Run
                            .Factory.StartNew
                                (
                                    () => x.Kurtosis()
                                )
                            .ConfigureAwait(false);

            return kurtosis;
        }

        public async static Task<double> KurtosisAsync(this IEnumerable<double> x, IEnumerable<double> y)
        {
            double kurtosis =
                await Task
                            //.Run
                            .Factory.StartNew
                                (
                                    () => x.Kurtosis()
                                )
                            .ConfigureAwait(false);

            return kurtosis;
        }

        public async static Task<decimal> KurtosisAsync(this IEnumerable<decimal> x, IEnumerable<decimal> y)
        {
            decimal kurtosis =
                await Task
                            //.Run
                            .Factory.StartNew
                                (
                                    () => x.Kurtosis()
                                )
                            .ConfigureAwait(false);

            return kurtosis;
        }
    }
}
