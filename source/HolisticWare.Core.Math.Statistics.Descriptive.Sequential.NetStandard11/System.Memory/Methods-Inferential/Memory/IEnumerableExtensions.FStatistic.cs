using System;
using System.Collections.Generic;
using System.Linq;

namespace Core.Math.Statistics.Descriptive.Sequential
{
    /// <summary>
    /// F-Statistics / F test
    /// A value you get when you run an ANOVA test or a regression analysis to 
    /// find out if the means between two populations are significantly 
    /// </summary>
    /// <see cref="https://en.wikipedia.org/wiki/F-test"/>
    public static partial class IEnumerableExtensionsFStatistic
    {
        //==============================================================================================================
        public static double FStatistic
                                    (
                                        this Memory<byte> x, 
                                        Memory<byte> y
                                    )
        {
            return x.VarianceSample() / y.VarianceSample();
        }

        public static double FStatistic
                                    (
                                        this Memory<short> x, 
                                        Memory<short> y
                                    )
        {
            return x.VarianceSample() / y.VarianceSample();
        }

        public static double FStatistic
                                    (
                                        this Memory<ushort> x, 
                                        Memory<ushort> y
                                    )
        {
            return x.VarianceSample() / y.VarianceSample();
        }

        public static double FStatistic
                                    (
                                        this Memory<int> x, 
                                        Memory<int> y
                                    )
        {
            return x.VarianceSample() / y.VarianceSample();
        }

        public static double FStatistic
                                    (
                                        this Memory<uint> x, 
                                        Memory<uint> y
                                    )
        {
            return x.VarianceSample() / y.VarianceSample();
        }

        public static double FStatistic
                                    (
                                        this Memory<long> x, 
                                        Memory<long> y
                                    )
        {
            return x.VarianceSample() / y.VarianceSample();
        }

        public static double FStatistic
                                    (
                                        this Memory<ulong> x, 
                                        Memory<ulong> y
                                    )
        {
            return x.VarianceSample() / y.VarianceSample();
        }

        public static double FStatistic
                                    (
                                        this Memory<float> x, 
                                        Memory<float> y
                                    )
        {
            return x.VarianceSample() / y.VarianceSample();
        }

        public static double FStatistic
                                    (
                                        this Memory<double> x, 
                                        Memory<double> y
                                    )
        {
            return x.VarianceSample() / y.VarianceSample();
        }

        public static decimal FStatistic
                                    (
                                        this Memory<decimal> x, 
                                        Memory<decimal> y
                                    )
        {
            return x.VarianceSample() / y.VarianceSample();
        }
        //==============================================================================================================
    }
}
