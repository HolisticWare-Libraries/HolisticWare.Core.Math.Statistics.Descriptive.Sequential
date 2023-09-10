using System;
using System.Collections.Generic;
using System.Linq;

using Core.LINQ.Memory;
using Core.Math.Statistics;

namespace Core.Math.Statistics.Descriptive
{
    /// <summary>
    /// Correlation
    /// </summary>
    /// <see href="https://en.wikipedia.org/wiki/Correlation_and_dependence"/> 
    /// <see href="http://www.mathsisfun.com/data/correlation.html"/>
    public static partial class MemoryExtensionsCorrelation
    {
        //==============================================================================================================
        public static double Correlation
                                    (
                                        this Memory<byte> x, 
                                        Memory<byte> y
                                    )
        {
            double standard_deviation_x = x.StandardDeviationSample();

            if (System.Math.Abs(standard_deviation_x) < Double.Epsilon)
            {
                return 0;
            }

            double standard_deviation_y = y.StandardDeviationSample();

            if (System.Math.Abs(standard_deviation_y) < Double.Epsilon)
            {
                return 0;
            }

            double sum = 0.0;

            int n = x.Count();

            for (int i = 0; i < n; i++)
            {
                sum += x.ElementAt(i) * y.ElementAt(i);
            }

            double x_mean_average_arithmetic = x.Select(x_i => (int) x_i).Average();
            double y_mean_average_arithmetic = y.Select(x_i => (int) x_i).Average();

            return
                (sum - n * x_mean_average_arithmetic * y_mean_average_arithmetic)
                /
                ((n - 1) * standard_deviation_x * standard_deviation_y)
                ;
        }

        public static double Correlation
                                    (
                                        this Memory<short> x, 
                                        Memory<short> y
                                    )
        {
            double standard_deviation_x = x.StandardDeviationSample();

            if( System.Math.Abs(standard_deviation_x) < Double.Epsilon )
            {
                return 0;
            }

            double standard_deviation_y = y.StandardDeviationSample();

            if (System.Math.Abs(standard_deviation_y) < Double.Epsilon)
            {
                return 0;
            }

            double sum = 0.0;

            int n = x.Count();

            for (int i = 0; i < n; i++)
            {
                sum += x.ElementAt(i) * y.ElementAt(i);
            }

            double x_mean_average_arithmetic = x.Select(x_i => (int)x_i).Average();
            double y_mean_average_arithmetic = y.Select(x_i => (int)x_i).Average();

            return 
                (sum - n * x_mean_average_arithmetic * y_mean_average_arithmetic) 
                / 
                ((n - 1) * standard_deviation_x * standard_deviation_y)
                ;
        }

        public static double Correlation
                                    (
                                        this Memory<ushort> x, 
                                        Memory<ushort> y
                                    )
        {
            double standard_deviation_x = x.StandardDeviationSample();

            if (System.Math.Abs(standard_deviation_x) < Double.Epsilon)
            {
                return 0;
            }

            double standard_deviation_y = y.StandardDeviationSample();

            if (System.Math.Abs(standard_deviation_y) < Double.Epsilon)
            {
                return 0;
            }

            double sum = 0.0;

            int n = x.Count();

            for (int i = 0; i < n; i++)
            {
                sum += x.ElementAt(i) * y.ElementAt(i);
            }

            double x_mean_average_arithmetic = x.Select(x_i => (long)x_i).Average();
            double y_mean_average_arithmetic = y.Select(x_i => (long)x_i).Average();

            return
                (sum - n * x_mean_average_arithmetic * y_mean_average_arithmetic)
                /
                ((n - 1) * standard_deviation_x * standard_deviation_y)
                ;
        }

        public static double Correlation
                                    (
                                        this Memory<int> x, 
                                        Memory<int> y
                                    )
        {
            double standard_deviation_x = x.StandardDeviationSample();

            if (System.Math.Abs(standard_deviation_x) < Double.Epsilon)
            {
                return 0;
            }

            double standard_deviation_y = y.StandardDeviationSample();

            if (System.Math.Abs(standard_deviation_y) < Double.Epsilon)
            {
                return 0;
            }

            double sum = 0.0;

            int n = x.Count();

            for (int i = 0; i < n; i++)
            {
                sum += x.ElementAt(i) * y.ElementAt(i);
            }

            double x_mean_average_arithmetic = x.Average();
            double y_mean_average_arithmetic = y.Average();

            return
                (sum - n * x_mean_average_arithmetic * y_mean_average_arithmetic)
                /
                ((n - 1) * standard_deviation_x * standard_deviation_y)
                ;
        }

        public static double Correlation
                                    (
                                        this Memory<uint> x, 
                                        Memory<uint> y
                                    )
        {
            double standard_deviation_x = x.StandardDeviationSample();

            if (System.Math.Abs(standard_deviation_x) < Double.Epsilon)
            {
                return 0;
            }

            double standard_deviation_y = y.StandardDeviationSample();

            if (System.Math.Abs(standard_deviation_y) < Double.Epsilon)
            {
                return 0;
            }

            double sum = 0.0;

            int n = x.Count();

            for (int i = 0; i < n; i++)
            {
                sum += x.ElementAt(i) * y.ElementAt(i);
            }

            double x_mean_average_arithmetic = x.Select(x_i => (long)x_i).Average();
            double y_mean_average_arithmetic = y.Select(x_i => (long)x_i).Average();


            return
                (sum - n * x_mean_average_arithmetic * y_mean_average_arithmetic)
                /
                ((n - 1) * standard_deviation_x * standard_deviation_y)
                ;
        }

        public static double Correlation
                                    (
                                        this Memory<long> x, 
                                        Memory<long> y
                                    )
        {
            double standard_deviation_x = x.StandardDeviationSample();

            if (System.Math.Abs(standard_deviation_x) < Double.Epsilon)
            {
                return 0;
            }

            double standard_deviation_y = y.StandardDeviationSample();

            if (System.Math.Abs(standard_deviation_y) < Double.Epsilon)
            {
                return 0;
            }

            double sum = 0.0;

            int n = x.Count();

            for (int i = 0; i < n; i++)
            {
                sum += x.ElementAt(i) * y.ElementAt(i);
            }

            double x_mean_average_arithmetic = x.Average();
            double y_mean_average_arithmetic = y.Average();

            return
                (sum - n * x_mean_average_arithmetic * y_mean_average_arithmetic)
                /
                ((n - 1) * standard_deviation_x * standard_deviation_y)
                ;        
        }

        public static double Correlation
                                    (
                                        this Memory<ulong> x, 
                                        Memory<ulong> y
                                    )
        {
            double standard_deviation_x = x.StandardDeviationSample();

            if (System.Math.Abs(standard_deviation_x) < Double.Epsilon)
            {
                return 0;
            }

            double standard_deviation_y = y.StandardDeviationSample();

            if (System.Math.Abs(standard_deviation_y) < Double.Epsilon)
            {
                return 0;
            }

            double sum = 0.0;

            int n = x.Count();

            for (int i = 0; i < n; i++)
            {
                sum += x.ElementAt(i) * y.ElementAt(i);
            }

            double x_mean_average_arithmetic = x.Select(x_i => (double)x_i).Average();
            double y_mean_average_arithmetic = y.Select(x_i => (double)x_i).Average();

            return
                (sum - n * x_mean_average_arithmetic * y_mean_average_arithmetic)
                /
                ((n - 1) * standard_deviation_x * standard_deviation_y)
                ;        
        }

        public static double Correlation
                                    (
                                        this Memory<float> x, 
                                        Memory<float> y
                                    )
        {
            double standard_deviation_x = x.StandardDeviationSample();

            if (System.Math.Abs(standard_deviation_x) < Double.Epsilon)
            {
                return 0;
            }

            double standard_deviation_y = y.StandardDeviationSample();

            if (System.Math.Abs(standard_deviation_y) < Double.Epsilon)
            {
                return 0;
            }

            double sum = 0.0;

            int n = x.Count();

            for (int i = 0; i < n; i++)
            {
                sum += x.ElementAt(i) * y.ElementAt(i);
            }

            double x_mean_average_arithmetic = x.Average();
            double y_mean_average_arithmetic = y.Average();

            return
                (sum - n * x_mean_average_arithmetic * y_mean_average_arithmetic)
                /
                ((n - 1) * standard_deviation_x * standard_deviation_y)
                ;
        }

        public static double Correlation
                                    (
                                        this Memory<double> x, 
                                        Memory<double> y
                                    )
        {
            double standard_deviation_x = x.StandardDeviationSample();

            if (System.Math.Abs(standard_deviation_x) < Double.Epsilon)
            {
                return 0;
            }

            double standard_deviation_y = y.StandardDeviationSample();

            if (System.Math.Abs(standard_deviation_y) < Double.Epsilon)
            {
                return 0;
            }

            double sum = 0.0;

            int n = x.Count();

            for (int i = 0; i < n; i++)
            {
                sum += x.ElementAt(i) * y.ElementAt(i);
            }

            double x_mean_average_arithmetic = x.Average();
            double y_mean_average_arithmetic = y.Average();

            return
                (sum - n * x_mean_average_arithmetic * y_mean_average_arithmetic)
                /
                ((n - 1) * standard_deviation_x * standard_deviation_y)
                ;        
        }

        public static decimal Correlation
                                    (
                                        this Memory<decimal> x, 
                                        Memory<decimal> y
                                    )
        {
            decimal standard_deviation_x = x.StandardDeviationSample();

            if (standard_deviation_x == 0.0M)
            {
                return 0;
            }

            decimal standard_deviation_y = y.StandardDeviationSample();

            if (standard_deviation_y == 0.0M)
            {
                return 0;
            }

            decimal sum = 0.0M;

            int n = x.Count();

            for (int i = 0; i < n; i++)
            {
                sum += x.ElementAt(i) * y.ElementAt(i);
            }

            return 
                (sum - n * x.Average() * y.Average()) 
                / 
                ((n - 1) * standard_deviation_x * standard_deviation_y)
                ;
        }
        //==============================================================================================================

    }
}
