using System;
using System.Collections.Generic;
using System.Linq;

using Core.Math.Statistics;

namespace Core.Math.Statistics.Descriptive.Sequential
{
    /// <summary>
    /// Correlation
    /// </summary>
    /// <see cref="https://en.wikipedia.org/wiki/Correlation_and_dependence"/> 
    /// <see cref="http://www.mathsisfun.com/data/correlation.html"/>
    public static partial class IEnumerableExtensionsCorrelation
    {
        //==============================================================================================================
        public static double Correlation(this IEnumerable<short?> x, IEnumerable<short?> y)
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

            double? sum = 0.0;

            int n = x.Count();

            for (int i = 0; i < n; i++)
            {
                sum += x.ElementAt(i) * y.ElementAt(i);
            }

            double x_mean_average_arithmetic = x.Cast<int>().Average();
            double y_mean_average_arithmetic = y.Cast<int>().Average();

            return
                (double)
                (sum - n * x_mean_average_arithmetic * y_mean_average_arithmetic)
                /
                ((n - 1) * standard_deviation_x * standard_deviation_y)
                ;
        }

        public static double Correlation(this IEnumerable<ushort?> x, IEnumerable<ushort?> y)
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

            double? sum = 0.0;

            int n = x.Count();

            for (int i = 0; i < n; i++)
            {
                sum += x.ElementAt(i) * y.ElementAt(i);
            }

            double x_mean_average_arithmetic = x.Cast<long>().Average();
            double y_mean_average_arithmetic = y.Cast<long>().Average();

            return
                (double)
                (sum - n * x_mean_average_arithmetic * y_mean_average_arithmetic)
                /
                ((n - 1) * standard_deviation_x * standard_deviation_y)
                ;
        }

        public static double Correlation(this IEnumerable<int?> x, IEnumerable<int?> y)
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

            double? sum = 0.0;

            int n = x.Count();

            for (int i = 0; i < n; i++)
            {
                sum += x.ElementAt(i) * y.ElementAt(i);
            }

            double? x_mean_average_arithmetic = x.Average();
            double? y_mean_average_arithmetic = y.Average();

            return
                (double)
                (sum - n * x_mean_average_arithmetic * y_mean_average_arithmetic)
                /
                ((n - 1) * standard_deviation_x * standard_deviation_y)
                ;
        }

        public static double Correlation(this IEnumerable<uint?> x, IEnumerable<uint?> y)
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

            double? sum = 0.0;

            int n = x.Count();

            for (int i = 0; i < n; i++)
            {
                sum += x.ElementAt(i) * y.ElementAt(i);
            }

            double x_mean_average_arithmetic = x.Cast<long>().Average();
            double y_mean_average_arithmetic = y.Cast<long>().Average();


            return
                (double)
                (sum - n * x_mean_average_arithmetic * y_mean_average_arithmetic)
                /
                ((n - 1) * standard_deviation_x * standard_deviation_y)
                ;
        }

        public static double Correlation(this IEnumerable<long?> x, IEnumerable<long?> y)
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

            double? sum = 0.0;

            int n = x.Count();

            for (int i = 0; i < n; i++)
            {
                sum += x.ElementAt(i) * y.ElementAt(i);
            }

            double? x_mean_average_arithmetic = x.Average();
            double? y_mean_average_arithmetic = y.Average();

            return
                (double)
                (sum - n * x_mean_average_arithmetic * y_mean_average_arithmetic)
                /
                ((n - 1) * standard_deviation_x * standard_deviation_y)
                ;
        }

        public static double Correlation(this IEnumerable<ulong?> x, IEnumerable<ulong?> y)
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

            double? sum = 0.0;

            int n = x.Count();

            for (int i = 0; i < n; i++)
            {
                sum += x.ElementAt(i) * y.ElementAt(i);
            }

            double x_mean_average_arithmetic = x.Cast<double>().Average();
            double y_mean_average_arithmetic = y.Cast<double>().Average();

            return
                (double)
                (sum - n * x_mean_average_arithmetic * y_mean_average_arithmetic)
                /
                ((n - 1) * standard_deviation_x * standard_deviation_y)
                ;
        }

        public static double Correlation(this IEnumerable<float?> x, IEnumerable<float?> y)
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

            double? sum = 0.0;

            int n = x.Count();

            for (int i = 0; i < n; i++)
            {
                sum += x.ElementAt(i) * y.ElementAt(i);
            }

            double? x_mean_average_arithmetic = x.Average();
            double? y_mean_average_arithmetic = y.Average();

            return
                (double)
                (sum - n * x_mean_average_arithmetic * y_mean_average_arithmetic)
                /
                ((n - 1) * standard_deviation_x * standard_deviation_y)
                ;
        }

        public static double Correlation(this IEnumerable<double?> x, IEnumerable<double?> y)
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

            double? sum = 0.0;

            int n = x.Count();

            for (int i = 0; i < n; i++)
            {
                sum += x.ElementAt(i) * y.ElementAt(i);
            }

            double? x_mean_average_arithmetic = x.Average();
            double? y_mean_average_arithmetic = y.Average();

            return
                (double)
                (sum - n * x_mean_average_arithmetic * y_mean_average_arithmetic)
                /
                ((n - 1) * standard_deviation_x * standard_deviation_y)
                ;
        }

        public static decimal Correlation(this IEnumerable<decimal?> x, IEnumerable<decimal?> y)
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

            decimal? sum = 0.0M;

            int n = x.Count();

            for (int i = 0; i < n; i++)
            {
                sum += x.ElementAt(i) * y.ElementAt(i);
            }

            return
                (decimal)
                (sum - n * x.Average() * y.Average())
                /
                ((n - 1) * standard_deviation_x * standard_deviation_y)
                ;
        }
        //==============================================================================================================
    }
}
