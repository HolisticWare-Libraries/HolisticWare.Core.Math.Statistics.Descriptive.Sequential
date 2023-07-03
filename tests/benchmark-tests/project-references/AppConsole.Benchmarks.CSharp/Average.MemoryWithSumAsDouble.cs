    public partial class
                                        Average
    {
        [BenchmarkDotNet.Attributes.Benchmark]
        public
        double
                                    Foreach_Over_Span_With_Sum_As_Double
                                    (
                                    )
        {
            double sum = 0.0;

            Span<int> span_data_10 = data_10.AsSpan();

            foreach (int item in span_data_10)
            {
                sum += item;
            }

            double average = sum / data_10.Length;

            return average;
        }

    [BenchmarkDotNet.Attributes.Benchmark]
    public
        double
                                    For_Over_Span_With_Sum_As_Double_Length_Recalculated
                                    (
                                    )
    {
        double sum = 0.0;

        Span<int> span_data_10 = data_10.AsSpan();

        for (int i = 0; i < span_data_10.Length; i++)
        {
            sum += span_data_10[i];
        }

        double average = sum / data_10.Length;

        return average;

    }

    [BenchmarkDotNet.Attributes.Benchmark]
    public
        double
                                    For_Over_Span_With_Sum_As_Double_Length_PreCalculted_long
                                    (
                                    )
    {
        double  sum = 0.0;
        long    size = data_10.LongLength;

        Span<int> span_data_10 = data_10.AsSpan();

        for (int i = 0; i < size; i++)
        {
            sum += span_data_10[i];
        }

        double average = sum / data_10.Length;

        return average;

    }

    [BenchmarkDotNet.Attributes.Benchmark]
    public
        double
                                    For_Over_Span_With_Sum_As_Double_Length_PreCalculted_int
                                    (
                                    )
    {
        double sum = 0.0;
        int size = data_10.Length;

        Span<int> span_data_10 = data_10.AsSpan();

        for (int i = 0; i < size; i++)
        {
            sum += span_data_10[i];
        }

        double average = sum / data_10.Length;

        return average;

    }

}
