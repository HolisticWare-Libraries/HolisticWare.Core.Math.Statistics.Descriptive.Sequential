namespace Core.Memory
{
    public static partial class MemoryLinqExtensions
    {
        public static sbyte Sum(this System.Memory<sbyte> x)
        {
            sbyte sum = 0;

            for (int i = 0; i < x.Length; i++) 
            {
                sum += x.Span[i];
            }

            return sum;
        }

        public static byte Sum(this System.Memory<byte> x)
        {
            byte sum = 0;

            for (int i = 0; i < x.Length; i++) 
            {
                sum += x.Span[i];
            }

            return sum;
        }

        public static short Sum(this System.Memory<short> x)
        {
            short sum = 0;

            for (int i = 0; i < x.Length; i++) 
            {
                sum += x.Span[i];
            }

            return sum;
        }

        public static ushort Sum(this System.Memory<ushort> x)
        {
            ushort sum = 0;

            for (int i = 0; i < x.Length; i++)
            {
                sum += x.Span[i];
            }

            return sum;
        }

        public static int Sum(this System.Memory<int> x)
        {
            int sum = 0;

            for (int i = 0; i < x.Length; i++)
            {
                sum += x.Span[i];
            }

            return sum;
        }

        public static uint Sum(this System.Memory<uint> x)
        {
            uint sum = 0;

            for (int i = 0; i < x.Length; i++)
            {
                sum += x.Span[i];
            }

            return sum;
        }

        public static long Sum(this System.Memory<long> x)
        {
            long sum = 0;

            for (int i = 0; i < x.Length; i++)
            {
                sum += x.Span[i];
            }

            return sum;
        }

        public static ulong Sum(this System.Memory<ulong> x)
        {
            ulong sum = 0;

            for (int i = 0; i < x.Length; i++)
            {
                sum += x.Span[i];
            }

            return sum;
        }

        public static float Sum(this System.Memory<float> x)
        {
            float sum = 0;

            for (int i = 0; i < x.Length; i++)
            {
                sum += x.Span[i];
            }

            return sum;
        }

        public static double Sum(this System.Memory<double> x)
        {
            double sum = 0.0;

            for(int i = 0; i < x.Length; i++)
            {
                sum += x.Span[i];
            }

            return sum;
        }

        public static decimal Sum(this System.Memory<decimal> x)
        {
            decimal sum = 0.0M;

            for(int i = 0; i < x.Length; i++)
            {
                sum += x.Span[i];
            }

            return sum;
        }
    }
}
