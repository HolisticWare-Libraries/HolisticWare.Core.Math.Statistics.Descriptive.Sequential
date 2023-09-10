using System;
using System.Linq;

using Core.LINQ.Memory;

namespace Core.Math.Statistics.Descriptive
{
    /// <summary>
    /// Welch t test (statistics)
    /// </summary>
    /// TODO: Welch t test (statistics) 1. optimize/reduce redundant code (analysis needed)
    /// TODO: Welch t test (statistics) 2. async/await
    public static partial class MemoryExtensionsWelchtStatistic
    {
        //==============================================================================================================
        public static (double welch_t, double degrees_of_freedom) WelchtStatistic
                                                                        (
                                                                            this Memory<byte> x,
                                                                            Memory<byte> y
                                                                        )
        {
            // unequal variances
            double xmean = x.Select(x_i => (int)x_i).Average();
            double ymean = y.Select(x_i => (int)x_i).Average();
            double xvar = x.VarianceSample();
            double yvar = y.VarianceSample();
            int xn = x.Count();
            int yn = y.Count();
            double xvn = xvar / xn;
            double yvn = yvar / yn;
            double sxy = System.Math.Sqrt(xvn + yvn);

            double df = System.Math.Pow(xvn + yvn, 2) / (xvn * xvn / (xn - 1) + yvn * yvn / (yn - 1));
            double ws = (xmean - ymean) / sxy;

            return (ws, df);
        }

        public static (double welch_t, double degrees_of_freedom) WelchtStatistic
                                                                        (
                                                                            this Memory<short> x,
                                                                            Memory<short> y
                                                                        )
        {
            // unequal variances
            double xmean = x.Select(x_i => (int)x_i).Average();
            double ymean = y.Select(x_i => (int)x_i).Average();
            double xvar = x.VarianceSample();
            double yvar = y.VarianceSample();
            int xn = x.Count();
            int yn = y.Count();
            double xvn = xvar / xn;
            double yvn = yvar / yn;
            double sxy = System.Math.Sqrt(xvn + yvn);

            double df = System.Math.Pow(xvn + yvn, 2) / (xvn * xvn / (xn - 1) + yvn * yvn / (yn - 1));
            double ws = (xmean - ymean) / sxy;

            return (ws, df);
        }

        public static (double welch_t, double degrees_of_freedom) WelchtStatistic
                                                                        (
                                                                            this Memory<ushort> x,
                                                                            Memory<ushort> y
                                                                        )
        {
            // unequal variances
            double xmean = x.Select(x_i => (int)x_i).Average();
            double ymean = y.Select(x_i => (int)x_i).Average();
            double xvar = x.VarianceSample();
            double yvar = y.VarianceSample();
            int xn = x.Count();
            int yn = y.Count();
            double xvn = xvar / xn;
            double yvn = yvar / yn;
            double sxy = System.Math.Sqrt(xvn + yvn);

            double df = System.Math.Pow(xvn + yvn, 2) / (xvn * xvn / (xn - 1) + yvn * yvn / (yn - 1));
            double ws = (xmean - ymean) / sxy;

            return (ws, df);
        }

        public static (double welch_t, double degrees_of_freedom) WelchtStatistic
                                                                        (
                                                                            this Memory<int> x,
                                                                            Memory<int> y
                                                                        )
        {
            // unequal variances
            double xmean = x.Average();
            double ymean = y.Average();
            double xvar = x.VarianceSample();
            double yvar = y.VarianceSample();
            int xn = x.Count();
            int yn = y.Count();
            double xvn = xvar / xn;
            double yvn = yvar / yn;
            double sxy = System.Math.Sqrt(xvn + yvn);

            double df = System.Math.Pow(xvn + yvn, 2) / (xvn * xvn / (xn - 1) + yvn * yvn / (yn - 1));
            double ws = (xmean - ymean) / sxy;

            return (ws, df);
        }

        public static (double welch_t, double degrees_of_freedom) WelchtStatistic
                                                                        (
                                                                            this Memory<uint> x,
                                                                            Memory<uint> y
                                                                        )
        {
            // unequal variances
            double xmean = x.Select(x_i => (long)x_i).Average();
            double ymean = y.Select(x_i => (long)x_i).Average();
            double xvar = x.VarianceSample();
            double yvar = y.VarianceSample();
            int xn = x.Count();
            int yn = y.Count();
            double xvn = xvar / xn;
            double yvn = yvar / yn;
            double sxy = System.Math.Sqrt(xvn + yvn);

            double df = System.Math.Pow(xvn + yvn, 2) / (xvn * xvn / (xn - 1) + yvn * yvn / (yn - 1));
            double ws = (xmean - ymean) / sxy;

            return (ws, df);
        }

        public static (double welch_t, double degrees_of_freedom) WelchtStatistic
                                                                        (
                                                                            this Memory<long> x,
                                                                            Memory<long> y
                                                                        )
        {
            // unequal variances
            double xmean = x.Average();
            double ymean = y.Average();
            double xvar = x.VarianceSample();
            double yvar = y.VarianceSample();
            int xn = x.Count();
            int yn = y.Count();
            double xvn = xvar / xn;
            double yvn = yvar / yn;
            double sxy = System.Math.Sqrt(xvn + yvn);

            double df = System.Math.Pow(xvn + yvn, 2) / (xvn * xvn / (xn - 1) + yvn * yvn / (yn - 1));
            double ws = (xmean - ymean) / sxy;

            return (ws, df);
        }

        public static (double welch_t, double degrees_of_freedom) WelchtStatistic
                                                                        (
                                                                            this Memory<ulong> x,
                                                                            Memory<ulong> y
                                                                        )
        {
            // unequal variances
            double xmean = x.Select(x_i => (double)x_i).Average();
            double ymean = y.Select(x_i => (double)x_i).Average();
            double xvar = x.VarianceSample();
            double yvar = y.VarianceSample();
            int xn = x.Count();
            int yn = y.Count();
            double xvn = xvar / xn;
            double yvn = yvar / yn;
            double sxy = System.Math.Sqrt(xvn + yvn);

            double df = System.Math.Pow(xvn + yvn, 2) / (xvn * xvn / (xn - 1) + yvn * yvn / (yn - 1));
            double ws = (xmean - ymean) / sxy;

            return (ws, df);
        }

        public static (double welch_t, double degrees_of_freedom) WelchtStatistic
                                                                        (
                                                                            this Memory<float> x,
                                                                            Memory<float> y
                                                                        )
        {
            // unequal variances
            double xmean = x.Average();
            double ymean = y.Average();
            double xvar = x.VarianceSample();
            double yvar = y.VarianceSample();
            int xn = x.Count();
            int yn = y.Count();
            double xvn = xvar / xn;
            double yvn = yvar / yn;
            double sxy = System.Math.Sqrt(xvn + yvn);

            double df = System.Math.Pow(xvn + yvn, 2) / (xvn * xvn / (xn - 1) + yvn * yvn / (yn - 1));
            double ws = (xmean - ymean) / sxy;

            return (ws, df);
        }

        public static (double welch_t, double degrees_of_freedom) WelchtStatistic
                                                                        (
                                                                            this Memory<double> x, 
                                                                            Memory<double>  y
                                                                        )
        {
            // unequal variances
            double xmean = x.Average();
            double ymean = y.Average();
            double xvar = x.VarianceSample();
            double yvar = y.VarianceSample();
            int xn = x.Count();
            int yn = y.Count();
            double xvn = xvar / xn;
            double yvn = yvar / yn;
            double sxy = System.Math.Sqrt(xvn + yvn);

            double df = System.Math.Pow(xvn + yvn, 2) / (xvn * xvn / (xn - 1) + yvn * yvn / (yn - 1));
            double ws = (xmean - ymean) / sxy;

            return (ws, df);
        }

        public static (decimal welch_t, decimal degrees_of_freedom) WelchtStatistic
                                                                        (
                                                                            this Memory<decimal> x,
                                                                            Memory<decimal> y
                                                                        )
        {
            // unequal variances
            decimal xmean = x.Average();
            decimal ymean = y.Average();
            decimal xvar = x.VarianceSample();
            decimal yvar = y.VarianceSample();
            int xn = x.Count();
            int yn = y.Count();
            decimal xvn = xvar / xn;
            decimal yvn = yvar / yn;
            decimal sxy = (decimal) System.Math.Sqrt((double)(xvn + yvn));

            decimal df = 
                            (decimal) System.Math.Pow((double)(xvn + yvn), 2)
                            / 
                            (xvn * xvn / (xn - 1) + yvn * yvn / (yn - 1))
                            ;
            decimal ws = (xmean - ymean) / sxy;

            return (ws, df);
        }
        //==============================================================================================================

    }
}
