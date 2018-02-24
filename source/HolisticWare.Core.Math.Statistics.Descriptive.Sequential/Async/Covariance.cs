using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Core.Math.Statistics.Descriptive.Sequential
{
    public static partial class Covariance
    {
        //==============================================================================================================
        public async static Task<double> CalculateAsync(IEnumerable<byte> x, IEnumerable<byte> y)
        {
            double covariance =
                await Task
                            .Run
                                (
                                    () => x.Covariance(y)
                                )
                            .ConfigureAwait(false);

            return covariance;
        }

        public async static Task<double> CalculateAsync(IEnumerable<short> x, IEnumerable<short> y)
        {
            double covariance =
                await Task
                            .Run
                                (
                                    () => x.Covariance(y)
                                )
                            .ConfigureAwait(false);

            return covariance;
        }

        public async static Task<double> CalculateAsync(IEnumerable<ushort> x, IEnumerable<ushort> y)
        {
            double covariance =
                await Task
                            .Run
                                (
                                    () => x.Covariance(y)
                                )
                            .ConfigureAwait(false);

            return covariance;
        }

        public async static Task<double> CalculateAsync(IEnumerable<int> x, IEnumerable<int> y)
        {
            double covariance =
                await Task
                            .Run
                                (
                                    () => x.Covariance(y)
                                )
                            .ConfigureAwait(false);

            return covariance;
        }

        public async static Task<double> CalculateAsync(IEnumerable<uint> x, IEnumerable<uint> y)
        {
            double covariance =
                await Task
                            .Run
                                (
                                    () => x.Covariance(y)
                                )
                            .ConfigureAwait(false);

            return covariance;
        }

        public async static Task<double> CalculateAsync(IEnumerable<long> x, IEnumerable<long> y)
        {
            double covariance =
                await Task
                            .Run
                                (
                                    () => x.Covariance(y)
                                )
                            .ConfigureAwait(false);

            return covariance;
        }

        public async static Task<double> CalculateAsync(IEnumerable<ulong> x, IEnumerable<ulong> y)
        {
            double covariance =
                await Task
                            .Run
                                (
                                    () => x.Covariance(y)
                                )
                            .ConfigureAwait(false);

            return covariance;
        }

        public async static Task<double> CalculateAsync(IEnumerable<float> x, IEnumerable<float> y)
        {
            double covariance =
                await Task
                            .Run
                                (
                                    () => x.Covariance(y)
                                )
                            .ConfigureAwait(false);

            return covariance;
        }

        public async static Task<double> CalculateAsync(IEnumerable<double> x, IEnumerable<double> y)
        {
            double covariance =
                await Task
                            .Run
                                (
                                    () => x.Covariance(y)
                                )
                            .ConfigureAwait(false);

            return covariance;
        }

        public async static Task<decimal> CalculateAsync(IEnumerable<decimal> x, IEnumerable<decimal> y)
        {
            decimal covariance =
                await Task
                            .Run
                                (
                                    () => x.Covariance(y)
                                )
                            .ConfigureAwait(false);

            return covariance;
        }
        //==============================================================================================================
    }
}
