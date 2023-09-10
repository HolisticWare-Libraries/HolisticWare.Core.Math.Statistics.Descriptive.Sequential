using System;
using System.Collections.Generic;
using System.Linq;

using Core.Math.Statistics;

namespace Core.Math.Statistics.Descriptive
{
    /// <summary>
    /// Correlation
    /// </summary>
    /// <see href="https://en.wikipedia.org/wiki/Correlation_and_dependence"/> 
    /// <see href="http://www.mathsisfun.com/data/Correlation.html"/>
    public static partial class IEnumerableExtensionsCorrelation
    {
        //==============================================================================================================
        public static double CorrelationAsync
                                    (
                                        this IEnumerable<byte> x, 
                                        IEnumerable<byte> y
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

        public static double CorrelationAsync
                                    (
                                        this IEnumerable<short> x, 
                                        IEnumerable<short> y
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

        public static double CorrelationAsync
                                    (
                                        this IEnumerable<ushort> x, 
                                        IEnumerable<ushort> y
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

        public static double CorrelationAsync
                                    (
                                        this IEnumerable<int> x, 
                                        IEnumerable<int> y
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

        public static double CorrelationAsync
                                    (
                                        this IEnumerable<uint> x, 
                                        IEnumerable<uint> y
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

        public static double CorrelationAsync
                                    (
                                        this IEnumerable<long> x, 
                                        IEnumerable<long> y
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

        public static double CorrelationAsync
                                    (
                                        this IEnumerable<ulong> x, 
                                        IEnumerable<ulong> y
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

        public static double CorrelationAsync
                                    (
                                        this IEnumerable<float> x, 
                                        IEnumerable<float> y
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

            int n_x = x.Count();
            int n_y = y.Count();

            if (n_x != n_y) 
            {
                string msg = "Cannot calculate CorrelationAsync for IEnumerables of different Lengths / Counts!";
                throw new InvalidOperationException($"{msg}"); 
            }

            for (int i = 0; i < n_x; i++)
            {
                sum += x.ElementAt(i) * y.ElementAt(i);
            }

            double x_mean_average_arithmetic = x.Average();
            double y_mean_average_arithmetic = y.Average();

            return
                (sum - n_x * x_mean_average_arithmetic * y_mean_average_arithmetic)
                /
                ((n_x - 1) * standard_deviation_x * standard_deviation_y)
                ;
        }

        public static double CorrelationAsync
                                    (
                                        this IEnumerable<double> x, 
                                        IEnumerable<double> y
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
                double x_i = x.ElementAt(i);
                double y_i = y.ElementAt(i);

                sum += x_i * y_i;
            }

            double x_mean_average_arithmetic = x.Average();
            double y_mean_average_arithmetic = y.Average();

            return
                (sum - n * x_mean_average_arithmetic * y_mean_average_arithmetic)
                /
                ((n - 1) * standard_deviation_x * standard_deviation_y)
                ;        
        }

        public static decimal CorrelationAsync
                                    (
                                        this IEnumerable<decimal> x, 
                                        IEnumerable<decimal> y
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
