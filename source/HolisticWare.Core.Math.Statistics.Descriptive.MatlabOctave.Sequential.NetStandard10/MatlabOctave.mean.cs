using System;
using System.Collections.Generic;

using Core.Math.Statistics.Descriptive.Sequential;

namespace HolisticWare.Core.Math.Statistics.Descriptive.MatlabOctave.Sequential
{
    public partial class MatlabOctave
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
        /// <param name="x">x - IEnumerable collection</param>
        /// <param name="option">
        /// string textual option parameter to define mean algorithm
        /// </param>
        /// <see cref="https://www.mathworks.com/help/matlab/ref/mean.html"/>
        /// <see cref="https://octave.org/doc/v4.2.1/Descriptive-Statistics.html"/>
        public static double? mean(IEnumerable<byte> x, string option = "a")
        {
            double? retval_mean = null;

            switch(option.ToLower())
            {
                case "a":
                case "arithmetic":
                    retval_mean = x.MeanArithmetic();
                    break;
                case "g":
                case "geometric":
                    retval_mean = x.MeanGeometric();
                    break;
                case "h":
                case "harmonic":
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
        /// <param name="x">x - IEnumerable collection</param>
        /// <param name="option">
        /// string textual option parameter to define mean algorithm
        /// </param>
        /// <see cref="https://www.mathworks.com/help/matlab/ref/mean.html"/>
        /// <see cref="https://octave.org/doc/v4.2.1/Descriptive-Statistics.html"/>
        public static double? mean(IEnumerable<ushort> x, string option = "a")
        {
            double? retval_mean = null;

            switch (option.ToLower())
            {
                case "a":
                case "arithmetic":
                    retval_mean = x.MeanArithmetic();
                    break;
                case "g":
                case "geometric":
                    retval_mean = x.MeanGeometric();
                    break;
                case "h":
                case "harmonic":
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
        /// <param name="x">x - IEnumerable collection</param>
        /// <param name="option">
        /// string textual option parameter to define mean algorithm
        /// </param>
        /// <see cref="https://www.mathworks.com/help/matlab/ref/mean.html"/>
        /// <see cref="https://octave.org/doc/v4.2.1/Descriptive-Statistics.html"/>
        public static double? mean(IEnumerable<short> x, string option = "a")
        {
            double? retval_mean = null;

            switch (option.ToLower())
            {
                case "a":
                case "arithmetic":
                    retval_mean = x.MeanArithmetic();
                    break;
                case "g":
                case "geometric":
                    retval_mean = x.MeanGeometric();
                    break;
                case "h":
                case "harmonic":
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
        /// <param name="x">x - IEnumerable collection</param>
        /// <param name="option">
        /// string textual option parameter to define mean algorithm
        /// </param>
        /// <see cref="https://www.mathworks.com/help/matlab/ref/mean.html"/>
        /// <see cref="https://octave.org/doc/v4.2.1/Descriptive-Statistics.html"/>
        public static double? mean(IEnumerable<int> x, string option = "a")
        {
            double? retval_mean = null;

            switch (option.ToLower())
            {
                case "a":
                case "arithmetic":
                    retval_mean = x.MeanArithmetic();
                    break;
                case "g":
                case "geometric":
                    retval_mean = x.MeanGeometric();
                    break;
                case "h":
                case "harmonic":
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
        /// <param name="x">x - IEnumerable collection</param>
        /// <param name="option">
        /// string textual option parameter to define mean algorithm
        /// </param>
        /// <see cref="https://www.mathworks.com/help/matlab/ref/mean.html"/>
        /// <see cref="https://octave.org/doc/v4.2.1/Descriptive-Statistics.html"/>
        public static double? mean(IEnumerable<uint> x, string option = "a")
        {
            double? retval_mean = null;

            switch (option.ToLower())
            {
                case "a":
                case "arithmetic":
                    retval_mean = x.MeanArithmetic();
                    break;
                case "g":
                case "geometric":
                    retval_mean = x.MeanGeometric();
                    break;
                case "h":
                case "harmonic":
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
        /// <param name="x">x - IEnumerable collection</param>
        /// <param name="option">
        /// string textual option parameter to define mean algorithm
        /// </param>
        /// <see cref="https://www.mathworks.com/help/matlab/ref/mean.html"/>
        /// <see cref="https://octave.org/doc/v4.2.1/Descriptive-Statistics.html"/>
        public static double? mean(IEnumerable<long> x, string option = "a")
        {
            double? retval_mean = null;

            switch (option.ToLower())
            {
                case "a":
                case "arithmetic":
                    retval_mean = x.MeanArithmetic();
                    break;
                case "g":
                case "geometric":
                    retval_mean = x.MeanGeometric();
                    break;
                case "h":
                case "harmonic":
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
        /// <param name="x">x - IEnumerable collection</param>
        /// <param name="option">
        /// string textual option parameter to define mean algorithm
        /// </param>
        /// <see cref="https://www.mathworks.com/help/matlab/ref/mean.html"/>
        /// <see cref="https://octave.org/doc/v4.2.1/Descriptive-Statistics.html"/>
        public static double? mean(IEnumerable<ulong> x, string option = "a")
        {
            double? retval_mean = null;

            switch (option.ToLower())
            {
                case "a":
                case "arithmetic":
                    retval_mean = x.MeanArithmetic();
                    break;
                case "g":
                case "geometric":
                    retval_mean = x.MeanGeometric();
                    break;
                case "h":
                case "harmonic":
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
        /// <param name="x">x - IEnumerable collection</param>
        /// <param name="option">
        /// string textual option parameter to define mean algorithm
        /// </param>
        /// <see cref="https://www.mathworks.com/help/matlab/ref/mean.html"/>
        /// <see cref="https://octave.org/doc/v4.2.1/Descriptive-Statistics.html"/>
        public static double? mean(IEnumerable<float> x, string option = "a")
        {
            double? retval_mean = null;

            switch (option.ToLower())
            {
                case "a":
                case "arithmetic":
                    retval_mean = x.MeanArithmetic();
                    break;
                case "g":
                case "geometric":
                    retval_mean = x.MeanGeometric();
                    break;
                case "h":
                case "harmonic":
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
        /// <param name="x">x - IEnumerable collection</param>
        /// <param name="option">
        /// string textual option parameter to define mean algorithm
        /// </param>
        /// <see cref="https://www.mathworks.com/help/matlab/ref/mean.html"/>
        /// <see cref="https://octave.org/doc/v4.2.1/Descriptive-Statistics.html"/>
        public static double? mean(IEnumerable<double> x, string option = "a")
        {
            double? retval_mean = null;

            switch (option.ToLower())
            {
                case "a":
                case "arithmetic":
                    retval_mean = x.MeanArithmetic();
                    break;
                case "g":
                case "geometric":
                    retval_mean = x.MeanGeometric();
                    break;
                case "h":
                case "harmonic":
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
        /// <param name="x">x - IEnumerable collection</param>
        /// <param name="option">
        /// string textual option parameter to define mean algorithm
        /// </param>
        /// <see cref="https://www.mathworks.com/help/matlab/ref/mean.html"/>
        /// <see cref="https://octave.org/doc/v4.2.1/Descriptive-Statistics.html"/>
        public static decimal? mean(IEnumerable<decimal> x, string option = "a")
        {
            decimal? retval_mean = null;

            switch (option.ToLower())
            {
                case "a":
                case "arithmetic":
                    retval_mean = x.MeanArithmetic();
                    break;
                case "g":
                case "geometric":
                    retval_mean = x.MeanGeometric();
                    break;
                case "h":
                case "harmonic":
                    retval_mean = x.MeanHarmonic();
                    break;
                default:
                    throw new ArgumentException($"MatlabOctave.mean() unknown option {option}");
            }

            return retval_mean;
        }
    }
}
