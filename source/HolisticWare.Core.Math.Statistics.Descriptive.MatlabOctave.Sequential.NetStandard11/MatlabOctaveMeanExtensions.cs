using System;
using System.Collections.Generic;

using Core.Math.Statistics.Descriptive.Sequential;

namespace Core.Math.Statistics.Descriptive.MatlabOctave.Sequential
{
    public static partial class MatlabOctaveMeanExtensions
    {        
        /// <summary>
        /// Mean (Statistical) calculation - Matlab/Octave API mimic
        /// </summary>
        /// <returns>
        /// statistical mean based on optional argument ("a", "g", "h")
        /// </returns>
        /// <example>
        /// (new int[] { 1, 2, 3, 5, 8}).mean("a");
        /// </example>
        /// <param name="x">x - Memory collection</param>
        /// <param name="option">
        /// string textual option parameter to define mean algorithm
        /// </param>
        /// <see cref="https://www.mathworks.com/help/matlab/ref/mean.html"/>
        /// <see cref="https://octave.org/doc/v4.2.1/Descriptive-Statistics.html"/>
        public static double mean(this Memory<byte> x, string option = "a")
        {
            double retval_mean = double.NaN;

            switch(option.ToLower())
            {
                case "a":
                    retval_mean = x.MeanArithmetic();
                    break;
                case "g":
                    retval_mean = x.MeanGeometric();
                    break;
                case "h":
                    retval_mean = x.MeanHarmonic();
                    break;
                default:
                    throw new ArgumentException($"MatlabOctave.mean() unknown option {option}");
            }

            return retval_mean;    
        }

        /// <summary>
        /// Mean (Statistical) calculation - Matlab/Octave API mimic
        /// </summary>
        /// <returns>
        /// statistical mean based on optional argument ("a", "g", "h")
        /// </returns>
        /// <example>
        /// (new int[] { 1, 2, 3, 5, 8}).mean("a");
        /// </example>
        /// <param name="x">x - Memory collection</param>
        /// <param name="option">
        /// string textual option parameter to define mean algorithm
        /// </param>
        /// <see cref="https://www.mathworks.com/help/matlab/ref/mean.html"/>
        /// <see cref="https://octave.org/doc/v4.2.1/Descriptive-Statistics.html"/>
        public static double mean(this Memory<ushort> x, string option = "a")
        {
            double retval_mean = double.NaN;

            switch (option.ToLower())
            {
                case "a":
                    retval_mean = x.MeanArithmetic();
                    break;
                case "g":
                    retval_mean = x.MeanGeometric();
                    break;
                case "h":
                    retval_mean = x.MeanHarmonic();
                    break;
                default:
                    throw new ArgumentException($"MatlabOctave.mean() unknown option {option}");
            }

            return retval_mean;
        }

        /// <summary>
        /// Mean (Statistical) calculation - Matlab/Octave API mimic
        /// </summary>
        /// <returns>
        /// statistical mean based on optional argument ("a", "g", "h")
        /// </returns>
        /// <example>
        /// (new int[] { 1, 2, 3, 5, 8}).mean("a");
        /// </example>
        /// <param name="x">x - Memory collection</param>
        /// <param name="option">
        /// string textual option parameter to define mean algorithm
        /// </param>
        /// <see cref="https://www.mathworks.com/help/matlab/ref/mean.html"/>
        /// <see cref="https://octave.org/doc/v4.2.1/Descriptive-Statistics.html"/>
        public static double mean(this Memory<short> x, string option = "a")
        {
            double retval_mean = double.NaN;

            switch (option.ToLower())
            {
                case "a":
                    retval_mean = x.MeanArithmetic();
                    break;
                case "g":
                    retval_mean = x.MeanGeometric();
                    break;
                case "h":
                    retval_mean = x.MeanHarmonic();
                    break;
                default:
                    throw new ArgumentException($"MatlabOctave.mean() unknown option {option}");
            }

            return retval_mean;
        }

        /// <summary>
        /// Mean (Statistical) calculation - Matlab/Octave API mimic
        /// </summary>
        /// <param name="x">x - Memory collection</param>
        /// <param name="option">string textual option parameter to define mean algorithm</param>
        /// <returns>statistical mean based on optional argument ("a", "g", "h")</returns>
        /// <example>
        /// (new int[] { 1, 2, 3, 5, 8}).mean("a");
        /// </example>
        /// <see cref="https://www.mathworks.com/help/matlab/ref/mean.html"/>
        /// <see cref="https://octave.org/doc/v4.2.1/Descriptive-Statistics.html"/>

        public static double mean(this Memory<int> x, string option = "a")
        {
            double retval_mean = double.NaN;

            switch (option.ToLower())
            {
                case "a":
                    retval_mean = x.MeanArithmetic();
                    break;
                case "g":
                    retval_mean = x.MeanGeometric();
                    break;
                case "h":
                    retval_mean = x.MeanHarmonic();
                    break;
                default:
                    throw new ArgumentException($"MatlabOctave.mean() unknown option {option}");
            }

            return retval_mean;
        }

        /// <summary>
        /// Mean (Statistical) calculation - Matlab/Octave API mimic
        /// </summary>
        /// <returns>
        /// statistical mean based on optional argument ("a", "g", "h")
        /// </returns>
        /// <example>
        /// (new int[] { 1, 2, 3, 5, 8}).mean("a");
        /// </example>
        /// <param name="x">x - Memory collection</param>
        /// <param name="option">
        /// string textual option parameter to define mean algorithm
        /// </param>
        /// <see cref="https://www.mathworks.com/help/matlab/ref/mean.html"/>
        /// <see cref="https://octave.org/doc/v4.2.1/Descriptive-Statistics.html"/>
        public static double mean(this Memory<uint> x, string option = "a")
        {
            double retval_mean = double.NaN;

            switch (option.ToLower())
            {
                case "a":
                    retval_mean = x.MeanArithmetic();
                    break;
                case "g":
                    retval_mean = x.MeanGeometric();
                    break;
                case "h":
                    retval_mean = x.MeanHarmonic();
                    break;
                default:
                    throw new ArgumentException($"MatlabOctave.mean() unknown option {option}");
            }

            return retval_mean;
        }

        /// <summary>
        /// Mean (Statistical) calculation - Matlab/Octave API mimic
        /// </summary>
        /// <returns>
        /// statistical mean based on optional argument ("a", "g", "h")
        /// </returns>
        /// <example>
        /// (new int[] { 1, 2, 3, 5, 8}).mean("a");
        /// </example>
        /// <param name="x">x - Memory collection</param>
        /// <param name="option">
        /// string textual option parameter to define mean algorithm
        /// </param>
        /// <see cref="https://www.mathworks.com/help/matlab/ref/mean.html"/>
        /// <see cref="https://octave.org/doc/v4.2.1/Descriptive-Statistics.html"/>
        public static double mean(this Memory<long> x, string option = "a")
        {
            double retval_mean = double.NaN;

            switch (option.ToLower())
            {
                case "a":
                    retval_mean = x.MeanArithmetic();
                    break;
                case "g":
                    retval_mean = x.MeanGeometric();
                    break;
                case "h":
                    retval_mean = x.MeanHarmonic();
                    break;
                default:
                    throw new ArgumentException($"MatlabOctave.mean() unknown option {option}");
            }

            return retval_mean;
        }

        /// <summary>
        /// Mean (Statistical) calculation - Matlab/Octave API mimic
        /// </summary>
        /// <returns>
        /// statistical mean based on optional argument ("a", "g", "h")
        /// </returns>
        /// <example>
        /// (new int[] { 1, 2, 3, 5, 8}).mean("a");
        /// </example>
        /// <param name="x">x - Memory collection</param>
        /// <param name="option">
        /// string textual option parameter to define mean algorithm
        /// </param>
        /// <see cref="https://www.mathworks.com/help/matlab/ref/mean.html"/>
        /// <see cref="https://octave.org/doc/v4.2.1/Descriptive-Statistics.html"/>
        public static double mean(this Memory<ulong> x, string option = "a")
        {
            double retval_mean = double.NaN;

            switch (option.ToLower())
            {
                case "a":
                    retval_mean = x.MeanArithmetic();
                    break;
                case "g":
                    retval_mean = x.MeanGeometric();
                    break;
                case "h":
                    retval_mean = x.MeanHarmonic();
                    break;
                default:
                    throw new ArgumentException($"MatlabOctave.mean() unknown option {option}");
            }

            return retval_mean;
        }

        /// <summary>
        /// Mean (Statistical) calculation - Matlab/Octave API mimic
        /// </summary>
        /// <returns>
        /// statistical mean based on optional argument ("a", "g", "h")
        /// </returns>
        /// <example>
        /// (new int[] { 1, 2, 3, 5, 8}).mean("a");
        /// </example>
        /// <param name="x">x - Memory collection</param>
        /// <param name="option">
        /// string textual option parameter to define mean algorithm
        /// </param>
        /// <see cref="https://www.mathworks.com/help/matlab/ref/mean.html"/>
        /// <see cref="https://octave.org/doc/v4.2.1/Descriptive-Statistics.html"/>
        public static double mean(this Memory<float> x, string option = "a")
        {
            double retval_mean = double.NaN;

            switch (option.ToLower())
            {
                case "a":
                    retval_mean = x.MeanArithmetic();
                    break;
                case "g":
                    retval_mean = x.MeanGeometric();
                    break;
                case "h":
                    retval_mean = x.MeanHarmonic();
                    break;
                default:
                    throw new ArgumentException($"MatlabOctave.mean() unknown option {option}");
            }

            return retval_mean;
        }

        /// <summary>
        /// Mean (Statistical) calculation - Matlab/Octave API mimic
        /// </summary>
        /// <returns>
        /// statistical mean based on optional argument ("a", "g", "h")
        /// </returns>
        /// <example>
        /// (new int[] { 1, 2, 3, 5, 8}).mean("a");
        /// </example>
        /// <param name="x">x - Memory collection</param>
        /// <param name="option">
        /// string textual option parameter to define mean algorithm
        /// </param>
        /// <see cref="https://www.mathworks.com/help/matlab/ref/mean.html"/>
        /// <see cref="https://octave.org/doc/v4.2.1/Descriptive-Statistics.html"/>
        public static double mean(this Memory<double> x, string option = "a")
        {
            double retval_mean = double.NaN;

            switch (option.ToLower())
            {
                case "a":
                    retval_mean = x.MeanArithmetic();
                    break;
                case "g":
                    retval_mean = x.MeanGeometric();
                    break;
                case "h":
                    retval_mean = x.MeanHarmonic();
                    break;
                default:
                    throw new ArgumentException($"MatlabOctave.mean() unknown option {option}");
            }

            return retval_mean;
        }

        /// <summary>
        /// Mean (Statistical) calculation - Matlab/Octave API mimic
        /// </summary>
        /// <returns>
        /// statistical mean based on optional argument ("a", "g", "h")
        /// </returns>
        /// <example>
        /// (new int[] { 1, 2, 3, 5, 8}).mean("a");
        /// </example>
        /// <param name="x">x - Memory collection</param>
        /// <param name="option">
        /// string textual option parameter to define mean algorithm
        /// </param>
        /// <see cref="https://www.mathworks.com/help/matlab/ref/mean.html"/>
        /// <see cref="https://octave.org/doc/v4.2.1/Descriptive-Statistics.html"/>
        public static decimal? mean(this Memory<decimal> x, string option = "a")
        {
            decimal? retval_mean = null;

            switch (option.ToLower())
            {
                case "a":
                    retval_mean = x.MeanArithmetic();
                    break;
                case "g":
                    retval_mean = x.MeanGeometric();
                    break;
                case "h":
                    retval_mean = x.MeanHarmonic();
                    break;
                default:
                    throw new ArgumentException($"MatlabOctave.mean() unknown option {option}");
            }

            return retval_mean;
        }

    }
}
