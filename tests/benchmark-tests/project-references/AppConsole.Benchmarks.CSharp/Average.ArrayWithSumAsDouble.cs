    public partial class
                                        Average
    {
        [BenchmarkDotNet.Attributes.Benchmark]
        public
            double
                                        Foreach_Over_Array_Sum_As_Double
                                        (
                                        )
        {
            double sum = 0.0;

            foreach (int item in data_10)
            {
                sum += item;
            }

            double average = sum / data_10.Length;

            return average;
        }

        [BenchmarkDotNet.Attributes.Benchmark]
        public
            double
                                        For_Over_Array_Sum_As_Double_Length_Recalculated
                                        (
                                        )
        {
            double sum = 0.0;

            for(int i = 0; i < data_10.Length; i++)
            {
                sum += data_10[i];
            }

            double average = sum / data_10.Length;

            return average;

        }

    [BenchmarkDotNet.Attributes.Benchmark]
    public
        double
                                    For_Over_Array_Sum_As_Double_Length_PreCalculted_long
                                    (
                                    )
    {
        double  sum = 0.0;
        long    size = data_10.LongLength;

        for (int i = 0; i < size; i++)
        {
            sum += data_10[i];
        }

        double average = sum / data_10.Length;

        return average;

    }

    [BenchmarkDotNet.Attributes.Benchmark]
    public
        double
                                    For_Over_Array_Sum_As_Double_Length_PreCalculted_int
                                    (
                                    )
    {
        double sum = 0.0;
        int size = data_10.Length;

        for (int i = 0; i < size; i++)
        {
            sum += data_10[i];
        }

        double average = sum / data_10.Length;

        return average;

    }

    [BenchmarkDotNet.Attributes.Benchmark]
    public
        double
                                    LINQ_Method_Syntax_Over_Array
                                    (
                                    )
    {
        double average = data_10.Average();

        return average;

    }

    [BenchmarkDotNet.Attributes.Benchmark]
    public
        double
                                    LINQ_Query_Syntax_Over_Array_
                                    (
                                    )
    {
        double average =
                    (
                        from num in data_10
                            select num
                    )
                    .Average();

        return average;

    }
}
