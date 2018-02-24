using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Core.Math.Statistics.Descriptive.Sequential
{
    public static partial class IEnumerableExtensionsStandardDeviationSample
    {
        //==============================================================================================================
        public async static Task<double> StandardDeviationSampleAsync(this IEnumerable<byte> x)
        {
            double standard_deviation =
                await Task
                            .Run
                                (
                                    () => x.StandardDeviationSample()
                                )
                            .ConfigureAwait(false);

            return standard_deviation;
        }

        public async static Task<double> StandardDeviationSampleAsync(this IEnumerable<short> x)
        {
            double standard_deviation =
                await Task
                            .Run
                                (
                                    () => x.StandardDeviationSample()
                                )
                            .ConfigureAwait(false);

            return standard_deviation;
        }

        public async static Task<double> StandardDeviationSampleAsync(this IEnumerable<ushort> x)
        {
            double standard_deviation =
                await Task
                            .Run
                                (
                                    () => x.StandardDeviationSample()
                                )
                            .ConfigureAwait(false);

            return standard_deviation;
        }

        public async static Task<double> StandardDeviationSampleAsync(this IEnumerable<int> x)
        {
            double standard_deviation =
                await Task
                            .Run
                                (
                                    () => x.StandardDeviationSample()
                                )
                            .ConfigureAwait(false);

            return standard_deviation;
        }

        public async static Task<double> StandardDeviationSampleAsync(this IEnumerable<uint> x)
        {
            double standard_deviation =
                await Task
                            .Run
                                (
                                    () => x.StandardDeviationSample()
                                )
                            .ConfigureAwait(false);

            return standard_deviation;
        }

        public async static Task<double> StandardDeviationSampleAsync(this IEnumerable<long> x)
        {
            double standard_deviation =
                await Task
                            .Run
                                (
                                    () => x.StandardDeviationSample()
                                )
                            .ConfigureAwait(false);

            return standard_deviation;
        }

        public async static Task<double> StandardDeviationSampleAsync(this IEnumerable<ulong> x)
        {
            double standard_deviation =
                await Task
                            .Run
                                (
                                    () => x.StandardDeviationSample()
                                )
                            .ConfigureAwait(false);

            return standard_deviation;
        }

        public async static Task<double> StandardDeviationSampleAsync(this IEnumerable<float> x)
        {
            double standard_deviation =
                await Task
                            .Run
                                (
                                    () => x.StandardDeviationSample()
                                )
                            .ConfigureAwait(false);

            return standard_deviation;
        }

        public async static Task<double> StandardDeviationSampleAsync(this IEnumerable<double> x)
        {
            double standard_deviation =
                await Task
                            .Run
                                (
                                    () => x.StandardDeviationSample()
                                )
                            .ConfigureAwait(false);

            return standard_deviation;
        }

        public async static Task<decimal> StandardDeviationSampleAsync(this IEnumerable<decimal> x)
        {
            decimal standard_deviation =
                await Task
                            .Run
                                (
                                    () => x.StandardDeviationSample()
                                )
                            .ConfigureAwait(false);

            return standard_deviation;
        }
        //==============================================================================================================
    }
}
