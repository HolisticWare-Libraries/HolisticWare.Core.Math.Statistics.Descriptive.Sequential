    public partial class
                                        AverageMemory
                                        :
                                        Average
    {
    //[BenchmarkDotNet.Attributes.Benchmark]
    //public
    //    double
    //                                Foreach
    //                                (
    //                                )
    //{
    //    double sum = 0.0;

    //    Memory<int> memory_data_10 = data_10.AsMemory();

    //    foreach (int item in memory_data_10)
    //    {
    //        sum += item;
    //    }

    //    double average = sum / data_10.Length;

    //    return average;
    //}

    [BenchmarkDotNet.Attributes.Benchmark]
    public
        double
                                    For_Length_Recalculated_Span
                                    (
                                    )
    {
        double sum = 0.0;

        Span<int> memory_data_10 = data_10.AsSpan();

        for (int i = 0; i < memory_data_10.Length; i++)
        {
            sum += memory_data_10[i];
        }

        double average = sum / data_10.Length;

        return average;

    }

    [BenchmarkDotNet.Attributes.Benchmark]
    public
        double
                                    For_Length_PreCalculted_long_Span
                                    (
                                    )
    {
        double  sum = 0.0;
        long    size = data_10.LongLength;

        Span<int> memory_data_10 = data_10.AsSpan();

        for (int i = 0; i < size; i++)
        {
            sum += memory_data_10[i];
        }

        double average = sum / data_10.Length;

        return average;

    }

    [BenchmarkDotNet.Attributes.Benchmark]
    public
        double
                                    For_Length_PreCalculted_int_Span
                                    (
                                    )
    {
        double sum = 0.0;
        int size = data_10.Length;

        Span<int> memory_data_10 = data_10.AsSpan();

        for (int i = 0; i < size; i++)
        {
            sum += memory_data_10[i];
        }

        double average = sum / data_10.Length;

        return average;

    }

}
