using System;

using Core.LINQ.Memory;

namespace Core.Math.Statistics.Descriptive
{
    /// <summary>
    /// Correlation
    /// </summary>
    public static partial class StudenttStatisticIndependent
    {
        //==============================================================================================================
        public static double Calculate
                                    (
                                        Memory<byte> x, 
                                        Memory<byte> y
                                    )
        {
            return x.StudenttStatisticIndependent(y);
        }

        public static double Calculate
                                    (
                                        Memory<short> x, 
                                        Memory<short> y
                                    )
        {
            return x.StudenttStatisticIndependent(y);
        }

        public static double Calculate
                                    (
                                        Memory<ushort> x, 
                                        Memory<ushort> y
                                    )
        {
            return x.StudenttStatisticIndependent(y);
        }

        public static double Calculate
                                    (
                                        Memory<int> x, 
                                        Memory<int> y
                                    )
        {
            return x.StudenttStatisticIndependent(y);
        }

        public static double Calculate
                                    (
                                        Memory<uint> x, 
                                        Memory<uint> y
                                    )
        {
            return x.StudenttStatisticIndependent(y);
        }

        public static double Calculate
                                    (
                                        Memory<long> x, 
                                        Memory<long> y
                                    )
        {
            return x.StudenttStatisticIndependent(y);
        }

        public static double Calculate
                                    (
                                        Memory<ulong> x, 
                                        Memory<ulong> y
                                    )
        {
            return x.StudenttStatisticIndependent(y);
        }

        public static double Calculate
                                    (
                                        Memory<float> x, 
                                        Memory<float> y
                                    )
        {
            return x.StudenttStatisticIndependent(y);
        }

        public static double Calculate
                                    (
                                        Memory<double> x, 
                                        Memory<double> y
                                    )
        {
            return x.StudenttStatisticIndependent(y);
        }

        public static decimal Calculate
                                    (
                                        Memory<decimal> x, 
                                        Memory<decimal> y
                                    )
        {
            return x.StudenttStatisticIndependent(y);
        }
        //==============================================================================================================

    }
}
