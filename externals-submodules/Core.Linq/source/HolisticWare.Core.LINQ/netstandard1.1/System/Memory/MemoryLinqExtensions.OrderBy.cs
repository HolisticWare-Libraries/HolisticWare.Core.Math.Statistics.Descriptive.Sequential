namespace Core.Memory
{
    public static partial class MemoryLinqExtensions
    {
        public static sbyte OrderBy(this System.Memory<sbyte> x)
        {
            sbyte sum = 0;

            for (int i = 0; i < x.Length; i++) 
            {
                sum += x.Span[i];
            }

            return sum;
        }

        public static byte OrderBy(this System.Memory<byte> x)
        {
            byte sum = 0;

            for (int i = 0; i < x.Length; i++) 
            {
                sum += x.Span[i];
            }

            return sum;
        }

        public static short OrderBy(this System.Memory<short> x)
        {
            short sum = 0;

            for (int i = 0; i < x.Length; i++) 
            {
                sum += x.Span[i];
            }

            return sum;
        }

        public static ushort OrderBy(this System.Memory<ushort> x)
        {
            ushort sum = 0;

            for (int i = 0; i < x.Length; i++)
            {
                sum += x.Span[i];
            }

            return sum;
        }

        public static int OrderBy(this System.Memory<int> x)
        {
            int sum = 0;

            for (int i = 0; i < x.Length; i++)
            {
                sum += x.Span[i];
            }

            return sum;
        }

        public static uint OrderBy(this System.Memory<uint> x)
        {
            uint sum = 0;

            for (int i = 0; i < x.Length; i++)
            {
                sum += x.Span[i];
            }

            return sum;
        }

        public static long OrderBy(this System.Memory<long> x)
        {
            long sum = 0;

            for (int i = 0; i < x.Length; i++)
            {
                sum += x.Span[i];
            }

            return sum;
        }

        public static ulong OrderBy(this System.Memory<ulong> x)
        {
            ulong sum = 0;

            for (int i = 0; i < x.Length; i++)
            {
                sum += x.Span[i];
            }

            return sum;
        }

        public static float OrderBy(this System.Memory<float> x)
        {
            float sum = 0;

            for (int i = 0; i < x.Length; i++)
            {
                sum += x.Span[i];
            }

            return sum;
        }

        public static double OrderBy(this System.Memory<double> x)
        {
            double sum = 0.0;

            for(int i = 0; i < x.Length; i++)
            {
                sum += x.Span[i];
            }

            return sum;
        }

        public static decimal OrderBy(this System.Memory<decimal> x)
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
