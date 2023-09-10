using System;


namespace Core.Math.Statistics.Descriptive
{
    /// <summary>
    /// Kurtosis
    /// Sharpness of the peak of a frequency-distribution curve.
    /// </summary>
    /// <see href="https://en.wikipedia.org/wiki/Kurtosis"/>
    /// <see href="http://www.itl.nist.gov/div898/handbook/eda/section3/eda35b.htm"/>
    /// <see href="https://cran.r-project.org/web/packages/e1071/e1071.pdf"/>
    public static partial class IEnumerableExtensionsKurtosisExcess
    {
        //==============================================================================================================
        public static double KurtosisExcess
                                        (
                                            this Memory<byte> x
                                        )
        {
            return x.Kurtosis() - 3.0;
        }

        public static double KurtosisExcess
                                        (
                                            this Memory<short> x
                                        )
        {
            return x.Kurtosis() - 3.0;
        }

        public static double KurtosisExcess
                                        (
                                            this Memory<ushort> x
                                        )
        {
            return x.Kurtosis() - 3.0;
        }

        public static double KurtosisExcess
                                        (
                                            this Memory<int> x
                                        )
        {
            return x.Kurtosis() - 3.0;
        }

        public static double KurtosisExcess
                                        (
                                            this Memory<uint> x
                                        )
        {
            return x.Kurtosis() - 3.0;
        }

        public static double KurtosisExcess
                                        (
                                            this Memory<long> x
                                        )
        {
            return x.Kurtosis() - 3.0;
        }

        public static double KurtosisExcess
                                        (
                                            this Memory<ulong> x
                                        )
        {
            return x.Kurtosis() - 3.0;
        }

        public static double KurtosisExcess
                                        (
                                            this Memory<float> x
                                        )
        {
            return x.Kurtosis() - 3.0;
        }

        public static double KurtosisExcess
                                        (
                                            this Memory<double> x
                                        )
        {
            return x.Kurtosis() - 3.0;
        }

        public static decimal KurtosisExcess
                                        (
                                            this Memory<decimal> x
                                        )
        {
            return x.Kurtosis() - 3.0M;
        }
        //==============================================================================================================

    }
}
