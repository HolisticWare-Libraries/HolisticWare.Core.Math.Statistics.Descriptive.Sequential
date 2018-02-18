using System;
using System.Collections.Generic;
using System.Linq;

using Core.Math.Statistics;

namespace Core.Math.Statistics.Descriptive.Sequential
{
    /// <summary>
    /// Correlation
    /// </summary>
    public static partial class StudenttStatisticIndependent
    {
        //==============================================================================================================
        public static double Calculate(IEnumerable<short> x, IEnumerable<short> y)
        {
            return x.StudenttStatisticIndependent(y);
        }

        public static double Calculate(IEnumerable<ushort> x, IEnumerable<ushort> y)
        {
            return x.StudenttStatisticIndependent(y);
        }

        public static double Calculate(IEnumerable<int> x, IEnumerable<int> y)
        {
            return x.StudenttStatisticIndependent(y);
        }

        public static double Calculate(IEnumerable<uint> x, IEnumerable<uint> y)
        {
            return x.StudenttStatisticIndependent(y);
        }

        public static double Calculate(IEnumerable<long> x, IEnumerable<long> y)
        {
            return x.StudenttStatisticIndependent(y);
        }

        public static double Calculate(IEnumerable<ulong> x, IEnumerable<ulong> y)
        {
            return x.StudenttStatisticIndependent(y);
        }

        public static double Calculate(IEnumerable<float> x, IEnumerable<float> y)
        {
            return x.StudenttStatisticIndependent(y);
        }

        public static double Calculate(IEnumerable<double> x, IEnumerable<double> y)
        {
            return x.StudenttStatisticIndependent(y);
        }

        public static decimal Calculate(IEnumerable<decimal> x, IEnumerable<decimal> y)
        {
            return x.StudenttStatisticIndependent(y);
        }
        //==============================================================================================================

    }
}
