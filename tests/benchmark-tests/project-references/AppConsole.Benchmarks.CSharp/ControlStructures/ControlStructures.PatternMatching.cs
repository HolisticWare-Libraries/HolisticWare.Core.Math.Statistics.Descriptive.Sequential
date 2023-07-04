    public partial class
                                        ControlStructures
    {
        [BenchmarkDotNet.Attributes.Benchmark]
        public
        int
                                        If_PatternMatching
                                        (
                                        )
        {
            int count = 0;

            Span<int> span_data_10 = data_10.AsSpan();

            foreach (int item in span_data_10)
            {
                if ( item is >= -3 and <= 3 )
                {
                    count++;
                }
            }

            return count;
        }

}
