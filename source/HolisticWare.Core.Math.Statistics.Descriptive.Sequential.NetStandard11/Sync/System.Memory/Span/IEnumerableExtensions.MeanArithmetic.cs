using System;
using System.Collections.Generic;
using System.Linq;

using Core.Math.Statistics.Descriptive.Sequential;

namespace Core.Math.Statistics.Descriptive.Sequential
{
    /// <summary>
    /// Mean (Average) Arithmetic
    /// </summary>
    /// <see cref="https://en.wikipedia.org/wiki/Average"/>
    public static partial class IEnumerableExtensionsMeanArithmetic
    {
        public static double MeanArithmetic
                                    (
                                        this Span<int> x
                                    )
        {
            return x.ToArray().Average();
        }
    }
}
