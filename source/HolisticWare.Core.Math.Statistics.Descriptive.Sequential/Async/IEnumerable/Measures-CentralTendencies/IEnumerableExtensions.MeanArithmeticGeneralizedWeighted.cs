using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Core.Math.Statistics.Descriptive.Sequential
{
    public static partial class IEnumerableExtensionsMeanArithmeticGeneralizedWeighted
    {
        //==============================================================================================================
        public async static 
            Task<double> 
                MeanArithmeticGeneralizedWeightedAsync
                                        (
                                            this IEnumerable<byte> x,
                                            IEnumerable<double> w,
                                            double power
                                        )
        {
            double mean =
                await Task
                            //.Run
                            .Factory.StartNew
                                (
                                    () => x.MeanArithmeticGeneralizedWeighted(w, power)
                                )
                            .ConfigureAwait(false);

            return mean;
        }

        public async static
            Task<double>
                MeanArithmeticGeneralizedWeightedAsync
                                        (
                                            this IEnumerable<short> x,
                                            IEnumerable<double> w,
                                            double power
                                        )
        {
            double mean =
                await Task
                            //.Run
                            .Factory.StartNew
                                (
                                    () => x.MeanArithmeticGeneralizedWeighted(w, power)
                                )
                            .ConfigureAwait(false);

            return mean;
        }


        public async static
            Task<double>
                MeanArithmeticGeneralizedWeightedAsync
                                        (
                                            this IEnumerable<ushort> x,
                                            IEnumerable<double> w,
                                            double power
                                        )
        {
            double mean =
                await Task
                            //.Run
                            .Factory.StartNew
                                (
                                    () => x.MeanArithmeticGeneralizedWeighted(w, power)
                                )
                            .ConfigureAwait(false);

            return mean;
        }


        public async static
            Task<double>
                MeanArithmeticGeneralizedWeightedAsync
                                        (
                                            this IEnumerable<int> x,
                                            IEnumerable<double> w,
                                            double power
                                        )
        {
            double mean =
                await Task
                            //.Run
                            .Factory.StartNew
                                (
                                    () => x.MeanArithmeticGeneralizedWeighted(w, power)
                                )
                            .ConfigureAwait(false);

            return mean;
        }

        public async static
            Task<double>
                MeanArithmeticGeneralizedWeightedAsync
                                        (
                                            this IEnumerable<uint> x,
                                            IEnumerable<double> w,
                                            double power
                                        )
        {
            double mean =
                await Task
                            //.Run
                            .Factory.StartNew
                                (
                                    () => x.MeanArithmeticGeneralizedWeighted(w, power)
                                )
                            .ConfigureAwait(false);

            return mean;
        }

        public async static
            Task<double>
                MeanArithmeticGeneralizedWeightedAsync
                                        (
                                            this IEnumerable<long> x,
                                            IEnumerable<double> w,
                                            double power
                                        )
        {
            double mean =
                await Task
                            //.Run
                            .Factory.StartNew
                                (
                                    () => x.MeanArithmeticGeneralizedWeighted(w, power)
                                )
                            .ConfigureAwait(false);

            return mean;
        }

        public async static
            Task<double>
                MeanArithmeticGeneralizedWeightedAsync
                                        (
                                            this IEnumerable<ulong> x,
                                            IEnumerable<double> w,
                                            double power
                                        )
        {
            double mean =
                await Task
                            //.Run
                            .Factory.StartNew
                                (
                                    () => x.MeanArithmeticGeneralizedWeighted(w, power)
                                )
                            .ConfigureAwait(false);

            return mean;
        }

        public async static
            Task<double>
                MeanArithmeticGeneralizedWeightedAsync
                                        (
                                            this IEnumerable<float> x,
                                            IEnumerable<double> w,
                                            double power
                                        )
        {
            double mean =
                await Task
                            //.Run
                            .Factory.StartNew
                                (
                                    () => x.MeanArithmeticGeneralizedWeighted(w, power)
                                )
                            .ConfigureAwait(false);

            return mean;
        }


        public async static
            Task<double>
                MeanArithmeticGeneralizedWeightedAsync
                                        (
                                            this IEnumerable<double> x,
                                            IEnumerable<double> w,
                                            double power
                                        )
        {
            double mean =
                await Task
                            //.Run
                            .Factory.StartNew
                                (
                                    () => x.MeanArithmeticGeneralizedWeighted(w, power)
                                )
                            .ConfigureAwait(false);

            return mean;
        }

        public async static
            Task<decimal>
                MeanArithmeticGeneralizedWeightedAsync
                                        (
                                            this IEnumerable<decimal> x,
                                            IEnumerable<double> w,
                                            double power
                                        )
        {
            decimal mean =
                await Task
                            //.Run
                            .Factory.StartNew
                                (
                                    () => x.MeanArithmeticGeneralizedWeighted(w, power)
                                )
                            .ConfigureAwait(false);

            return mean;
        }
        //==============================================================================================================
    }
}
