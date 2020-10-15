using System;
using System.Collections.Generic;
using System.Linq;

namespace Core.Math.Statistics.Descriptive
{
    public static partial class IEnumerableExtensionsMoment
    {
        //==============================================================================================================
        /// <summary>
        /// Moment for values with m as moment ordinal and point as value around moment is calculated
        /// 
        /// Central moment   point = mean/average
        /// Raw/Crude moment point = 0.0
        /// </summary>
        /// <returns>The moment.</returns>
        /// <param name="x">The x coordinate.</param>
        /// <param name="m">M.</param>
        /// <param name="point">value about moment is calculated (mean, median or zero)</param>
        public static double Moment
                                (
                                    this IEnumerable<byte> x,
                                    double m,
                                    double? point = null
                                )
        {
            double point_about = 0;

            if (point == null)
            {
                if (System.Math.Abs(m - 1.0) <= Double.Epsilon)
                {
                    point_about = 0.0;
                }
                else
                {
                    point_about = x.Select(x_i => (int)x_i).Average();
                }
            }
            double sum = 0;

            int n = x.Count();

            for (int i = 0; i < n; i++)
            {
                sum += System.Math.Pow(x.ElementAt(i) - point_about, m);
            }

            return sum / n;
        }

        /// <summary>
        /// Moment for values with m as moment ordinal and point as value around moment is calculated
        /// 
        /// Central moment   point = mean/average
        /// Raw/Crude moment point = 0.0
        /// </summary>
        /// <returns>The moment.</returns>
        /// <param name="x">The x coordinate.</param>
        /// <param name="m">M.</param>
        /// <param name="point">value about moment is calculated (mean, median or zero)</param>
        public static double Moment
                                (
                                    this IEnumerable<short> x,
                                    double m,
                                    double? point = null
                                )
        {
            double point_about = 0;

            if (point == null)
            {
                if (System.Math.Abs(m - 1.0) <= Double.Epsilon)
                {
                    point_about = 0.0;
                }
                else
                {
                    point_about = x.Select(x_i => (int)x_i).Average();
                }
            }
            double sum = 0;

            int n = x.Count();

            for (int i = 0; i < n; i++)
            {
                sum += System.Math.Pow(x.ElementAt(i) - point_about, m);
            }

            return sum / n;
        }

        /// <summary>
        /// Moment for values with m as moment ordinal and point as value around moment is calculated
        /// 
        /// Central moment   point = mean/average
        /// Raw/Crude moment point = 0.0
        /// </summary>
        /// <returns>The moment.</returns>
        /// <param name="x">The x coordinate.</param>
        /// <param name="m">M.</param>
        /// <param name="point">value about moment is calculated (mean, median or zero)</param>
        public static double Moment
                                (
                                    this IEnumerable<ushort> x,
                                    double m,
                                    double? point = null
                                )
        {
            double point_about = 0;

            if (point == null)
            {
                if (System.Math.Abs(m - 1.0) <= Double.Epsilon)
                {
                    point_about = 0.0;
                }
                else
                {
                    point_about = x.Select(x_i => (int)x_i).Average();
                }
            }
            double sum = 0;

            int n = x.Count();

            for (int i = 0; i < n; i++)
            {
                sum += System.Math.Pow(x.ElementAt(i) - point_about, m);
            }

            return sum / n;
        }

        /// <summary>
        /// Moment for values with m as moment ordinal and point as value around moment is calculated
        /// 
        /// Central moment   point = mean/average
        /// Raw/Crude moment point = 0.0
        /// </summary>
        /// <returns>The moment.</returns>
        /// <param name="x">The x coordinate.</param>
        /// <param name="m">M.</param>
        /// <param name="point">value about moment is calculated (mean, median or zero)</param>
        public static double Moment
                                (
                                    this IEnumerable<int> x,
                                    double m,
                                    double? point = null
                                )
        {
            double point_about = 0;

            if (point == null)
            {
                if (System.Math.Abs(m - 1.0) <= Double.Epsilon)
                {
                    point_about = 0.0;
                }
                else
                {
                    point_about = x.Average();
                }
            }
            double sum = 0;

            int n = x.Count();

            for (int i = 0; i < n; i++)
            {
                sum += System.Math.Pow(x.ElementAt(i) - point_about, m);
            }

            return sum / n;
        }

        /// <summary>
        /// Moment for values with m as moment ordinal and point as value around moment is calculated
        /// 
        /// Central moment   point = mean/average
        /// Raw/Crude moment point = 0.0
        /// </summary>
        /// <returns>The moment.</returns>
        /// <param name="x">The x coordinate.</param>
        /// <param name="m">M.</param>
        /// <param name="point">value about moment is calculated (mean, median or zero)</param>
        public static double Moment
                                (
                                    this IEnumerable<uint> x,
                                    double m,
                                    double? point = null
                                )
        {
            double point_about = 0;

            if (point == null)
            {
                if (System.Math.Abs(m - 1.0) <= Double.Epsilon)
                {
                    point_about = 0.0;
                }
                else
                {
                    point_about = x.Select(x_i => (long)x_i).Average();
                }
            }
            double sum = 0;

            int n = x.Count();

            for (int i = 0; i < n; i++)
            {
                sum += System.Math.Pow(x.ElementAt(i) - point_about, m);
            }

            return sum / n;
        }

        /// <summary>
        /// Moment for values with m as moment ordinal and point as value around moment is calculated
        /// 
        /// Central moment   point = mean/average
        /// Raw/Crude moment point = 0.0
        /// </summary>
        /// <returns>The moment.</returns>
        /// <param name="x">The x coordinate.</param>
        /// <param name="m">M.</param>
        /// <param name="point">value about moment is calculated (mean, median or zero)</param>
        public static double Moment
                                (
                                    this IEnumerable<long> x,
                                    double m,
                                    double? point = null
                                )
        {
            double point_about = 0;

            if (point == null)
            {
                if (System.Math.Abs(m - 1.0) <= Double.Epsilon)
                {
                    point_about = 0.0;
                }
                else
                {
                    point_about = x.Average();
                }
            }
            double sum = 0;

            int n = x.Count();

            for (int i = 0; i < n; i++)
            {
                sum += System.Math.Pow(x.ElementAt(i) - point_about, m);
            }

            return sum / n;
        }

        /// <summary>
        /// Moment for values with m as moment ordinal and point as value around moment is calculated
        /// 
        /// Central moment   point = mean/average
        /// Raw/Crude moment point = 0.0
        /// </summary>
        /// <returns>The moment.</returns>
        /// <param name="x">The x coordinate.</param>
        /// <param name="m">M.</param>
        /// <param name="point">value about moment is calculated (mean, median or zero)</param>
        public static double Moment
                                (
                                    this IEnumerable<ulong> x,
                                    double m,
                                    double? point = null
                                )
        {
            double point_about = 0;

            if (point == null)
            {
                if (System.Math.Abs(m - 1.0) <= Double.Epsilon)
                {
                    point_about = 0.0;
                }
                else
                {
                    point_about = x.Select(x_i => (double)x_i).Average();
                }
            }
            double sum = 0;

            int n = x.Count();

            for (int i = 0; i < n; i++)
            {
                sum += System.Math.Pow(x.ElementAt(i) - point_about, m);
            }

            return sum / n;
        }

        /// <summary>
        /// Moment for values with m as moment ordinal and point as value around moment is calculated
        /// 
        /// Central moment   point = mean/average
        /// Raw/Crude moment point = 0.0
        /// </summary>
        /// <returns>The moment.</returns>
        /// <param name="x">The x coordinate.</param>
        /// <param name="m">M.</param>
        /// <param name="point">value about moment is calculated (mean, median or zero)</param>
        public static double Moment
                                (
                                    this IEnumerable<float> x,
                                    double m,
                                    double? point = null
                                )
        {
            double point_about = 0;

            if (point == null)
            {
                if (System.Math.Abs(m - 1.0) <= Double.Epsilon)
                {
                    point_about = 0.0;
                }
                else
                {
                    point_about = x.Average();
                }
            }
            double sum = 0;

            int n = x.Count();

            for (int i = 0; i < n; i++)
            {
                sum += System.Math.Pow(x.ElementAt(i) - point_about, m);
            }

            return sum / n;
        }

        /// <summary>
        /// Moment for values with m as moment ordinal and point as value around moment is calculated
        /// 
        /// Central moment   point = mean/average
        /// Raw/Crude moment point = 0.0
        /// </summary>
        /// <returns>The moment.</returns>
        /// <param name="x">The x coordinate.</param>
        /// <param name="m">M.</param>
        /// <param name="point">value about moment is calculated (mean, median or zero)</param>
        public static double Moment
                                (
                                    this IEnumerable<double> x,
                                    double m,
                                    double? point = null
                                )
        {
            double point_about = 0;

            if (point == null)
            {
                if (System.Math.Abs(m - 1.0) <= Double.Epsilon)
                {
                    point_about = 0.0;
                }
                else
                {
                    point_about = x.Average();
                }
            }
            double sum = 0;

            int n = x.Count();

            for (int i = 0; i < n; i++)
            {
                sum += System.Math.Pow(x.ElementAt(i) - point_about, m);
            }

            return sum / n;
        }

        /// <summary>
        /// Moment for values with m as moment ordinal and point as value around moment is calculated
        /// 
        /// Central moment   point = mean/average
        /// Raw/Crude moment point = 0.0
        /// </summary>
        /// <returns>The moment.</returns>
        /// <param name="x">The x coordinate.</param>
        /// <param name="m">M.</param>
        /// <param name="point">value about moment is calculated (mean, median or zero)</param>
        public static decimal Moment
                                (
                                    this IEnumerable<decimal> x,
                                    double m,
                                    decimal? point = null
                                )
        {
            decimal point_about = 0;

            if (point == null)
            {
                if (System.Math.Abs(m - 1.0) <= Double.Epsilon)
                {
                    point_about = 0.0m;
                }
                else
                {
                    point_about = x.Average();
                }
            }
            decimal sum = 0;

            int n = x.Count();

            for (int i = 0; i < n; i++)
            {
                sum += (decimal)System.Math.Pow( (double)(x.ElementAt(i) - point_about), m);
            }

            return sum / n;
        }
        //==============================================================================================================

    }
}
