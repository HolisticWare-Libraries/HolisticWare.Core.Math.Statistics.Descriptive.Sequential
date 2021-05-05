using System;
using System.Collections.Generic;

namespace Core.Linq.Memory
{
    public static partial class SpanExtensions

    {
        //------------------------------------------------------------------------------------------------
        public static List<byte> EvenModulo(this Span<byte> x)
        {
            int n = x.Length;

            List<byte> even_numbers = new List<byte>();
             
            for (int i = 0; i < n; i++)
            {
                byte x_i = x[i];

                if (x_i % 2 == 0)
                {
                    even_numbers.Add(x_i);
                }
            }

            return even_numbers;
        }

        public static List<byte> EvenDivision(this Span<byte> x)
        {
            int n = x.Length;

            List<byte> even_numbers = new List<byte>();

            for (int i = 0; i < n; i++)
            {
                byte x_i = x[i];

                if ((x_i / 2) * 2 == x_i)
                {
                    even_numbers.Add(x_i);
                }
            }

            return even_numbers;
        }

        public static List<byte> EvenBitwiseAndOperator(this Span<byte> x)
        {
            int n = x.Length;

            List<byte> even_numbers = new List<byte>();

            for (int i = 0; i < n; i++)
            {
                byte x_i = x[i];

                if ((x_i & 1) != 0)
                {
                    even_numbers.Add(x_i);
                }
            }

            return even_numbers;
        }

        public static List<byte> EvenShiftOperators(this Span<byte> x)
        {
            int n = x.Length;

            List<byte> even_numbers = new List<byte>();

            for (int i = 0; i < n; i++)
            {
                byte x_i = x[i];

                if ((x_i >> 1) << 1 == x_i)
                {
                    even_numbers.Add(x_i);
                }
            }

            return even_numbers;
        }

        public static List<byte> Even(this Span<byte> x)
        {
            return x.EvenShiftOperators();
        }

        //------------------------------------------------------------------------------------------------

        //------------------------------------------------------------------------------------------------
        public static List<short> EvenModulo(this Span<short> x)
        {
            int n = x.Length;

            List<short> even_numbers = new List<short>();

            for (int i = 0; i < n; i++)
            {
                short x_i = x[i];

                if (x_i % 2 == 0)
                {
                    even_numbers.Add(x_i);
                }
            }

            return even_numbers;
        }

        public static List<short> EvenDivision(this Span<short> x)
        {
            int n = x.Length;

            List<short> even_numbers = new List<short>();

            for (int i = 0; i < n; i++)
            {
                short x_i = x[i];

                if ((x_i / 2) * 2 == x_i)
                {
                    even_numbers.Add(x_i);
                }
            }

            return even_numbers;
        }

        public static List<short> EvenBitwiseAndOperator(this Span<short> x)
        {
            int n = x.Length;

            List<short> even_numbers = new List<short>();

            for (int i = 0; i < n; i++)
            {
                short x_i = x[i];

                if ((x_i & 1) == 0)
                {
                    even_numbers.Add(x_i);
                }
            }

            return even_numbers;
        }

        public static List<short> EvenShiftOperators(this Span<short> x)
        {
            int n = x.Length;

            List<short> even_numbers = new List<short>();

            for (int i = 0; i < n; i++)
            {
                short x_i = x[i];

                if ((x_i >> 1) << 1 == x_i)
                {
                    even_numbers.Add(x_i);
                }
            }

            return even_numbers;
        }

        public static List<short> Even(this Span<short> x)
        {
            return x.EvenShiftOperators();
        }
        //------------------------------------------------------------------------------------------------


        //------------------------------------------------------------------------------------------------
        public static List<ushort> EvenModulo(this Span<ushort> x)
        {
            int n = x.Length;

            List<ushort> even_numbers = new List<ushort>();

            for (int i = 0; i < n; i++)
            {
                ushort x_i = x[i];

                if (x_i % 2 == 0)
                {
                    even_numbers.Add(x_i);
                }
            }

            return even_numbers;
        }

        public static List<ushort> EvenDivision(this Span<ushort> x)
        {
            int n = x.Length;

            List<ushort> even_numbers = new List<ushort>();

            for (int i = 0; i < n; i++)
            {
                ushort x_i = x[i];

                if ((x_i / 2) * 2 == x_i)
                {
                    even_numbers.Add(x_i);
                }
            }

            return even_numbers;
        }

        public static List<ushort> EvenBitwiseAndOperator(this Span<ushort> x)
        {
            int n = x.Length;

            List<ushort> even_numbers = new List<ushort>();

            for (int i = 0; i < n; i++)
            {
                ushort x_i = x[i];

                if ((x_i & 1) == 0)
                {
                    even_numbers.Add(x_i);
                }
            }

            return even_numbers;
        }

        public static List<ushort> EvenShiftOperators(this Span<ushort> x)
        {
            int n = x.Length;

            List<ushort> even_numbers = new List<ushort>();

            for (int i = 0; i < n; i++)
            {
                ushort x_i = x[i];

                if ((x_i >> 1) << 1 == x_i)
                {
                    even_numbers.Add(x_i);
                }
            }

            return even_numbers;
        }

        public static List<ushort> Even(this Span<ushort> x)
        {
            return x.EvenShiftOperators();
        }
        //------------------------------------------------------------------------------------------------

        //------------------------------------------------------------------------------------------------
        public static List<int> EvenModulo(this Span<int> x)
        {
            int n = x.Length;

            List<int> even_numbers = new List<int>();

            for (int i = 0; i < n; i++)
            {
                int x_i = x[i];

                if (x_i % 2 == 0)
                {
                    even_numbers.Add(x_i);
                }
            }

            return even_numbers;
        }

        public static List<int> EvenDivision(this Span<int> x)
        {
            int n = x.Length;

            List<int> even_numbers = new List<int>();

            for (int i = 0; i < n; i++)
            {
                int x_i = x[i];

                if ((x_i / 2) * 2 == x_i)
                {
                    even_numbers.Add(x_i);
                }
            }

            return even_numbers;
        }

        public static List<int> EvenBitwiseAndOperator(this Span<int> x)
        {
            int n = x.Length;

            List<int> even_numbers = new List<int>();

            for (int i = 0; i < n; i++)
            {
                int x_i = x[i];

                if ((x_i & 1) == 0)
                {
                    even_numbers.Add(x_i);
                }
            }

            return even_numbers;
        }

        public static List<int> EvenShiftOperators(this Span<int> x)
        {
            int n = x.Length;

            List<int> even_numbers = new List<int>();

            for (int i = 0; i < n; i++)
            {
                int x_i = x[i];

                if ((x_i >> 1) << 1 == x_i)
                {
                    even_numbers.Add(x_i);
                }
            }

            return even_numbers;
        }

        public static List<int> Even(this Span<int> x)
        {
            return x.EvenShiftOperators();
        }
        //------------------------------------------------------------------------------------------------

        //------------------------------------------------------------------------------------------------
        public static List<uint> EvenModulo(this Span<uint> x)
        {
            int n = x.Length;

            List<uint> even_numbers = new List<uint>();

            for (int i = 0; i < n; i++)
            {
                uint x_i = x[i];

                if (x_i % 2 == 0)
                {
                    even_numbers.Add(x_i);
                }
            }

            return even_numbers;
        }

        public static List<uint> EvenDivision(this Span<uint> x)
        {
            int n = x.Length;

            List<uint> even_numbers = new List<uint>();

            for (int i = 0; i < n; i++)
            {
                uint x_i = x[i];

                if ((x_i / 2) * 2 == x_i)
                {
                    even_numbers.Add(x_i);
                }
            }

            return even_numbers;
        }

        public static List<uint> EvenBitwiseAndOperator(this Span<uint> x)
        {
            int n = x.Length;

            List<uint> even_numbers = new List<uint>();

            for (int i = 0; i < n; i++)
            {
                uint x_i = x[i];

                if ((x_i & 1) == 0)
                {
                    even_numbers.Add(x_i);
                }
            }

            return even_numbers;
        }

        public static List<uint> EvenShiftOperators(this Span<uint> x)
        {
            int n = x.Length;

            List<uint> even_numbers = new List<uint>();

            for (int i = 0; i < n; i++)
            {
                uint x_i = x[i];

                if ((x_i >> 1) << 1 == x_i)
                {
                    even_numbers.Add(x_i);
                }
            }

            return even_numbers;
        }

        public static List<uint> Even(this Span<uint> x)
        {
            return x.EvenShiftOperators();
        }
        //------------------------------------------------------------------------------------------------

        //------------------------------------------------------------------------------------------------
        public static List<long> EvenModulo(this Span<long> x)
        {
            int n = x.Length;

            List<long> even_numbers = new List<long>();

            for (int i = 0; i < n; i++)
            {
                long x_i = x[i];

                if (x_i % 2 == 0)
                {
                    even_numbers.Add(x_i);
                }
            }

            return even_numbers;
        }

        public static List<long> EvenDivision(this Span<long> x)
        {
            int n = x.Length;

            List<long> even_numbers = new List<long>();

            for (int i = 0; i < n; i++)
            {
                long x_i = x[i];

                if ((x_i / 2) * 2 == x_i)
                {
                    even_numbers.Add(x_i);
                }
            }

            return even_numbers;
        }

        public static List<long> EvenBitwiseAndOperator(this Span<long> x)
        {
            int n = x.Length;

            List<long> even_numbers = new List<long>();

            for (int i = 0; i < n; i++)
            {
                long x_i = x[i];

                if ((x_i & 1) == 0)
                {
                    even_numbers.Add(x_i);
                }
            }

            return even_numbers;
        }

        public static List<long> EvenShiftOperators(this Span<long> x)
        {
            int n = x.Length;

            List<long> even_numbers = new List<long>();

            for (int i = 0; i < n; i++)
            {
                long x_i = x[i];

                if ((x_i >> 1) << 1 == x_i)
                {
                    even_numbers.Add(x_i);
                }
            }

            return even_numbers;
        }

        public static List<long> Even(this Span<long> x)
        {
            return x.EvenShiftOperators();
        }
        //------------------------------------------------------------------------------------------------

        //------------------------------------------------------------------------------------------------
        public static List<ulong> EvenModulo(this Span<ulong> x)
        {
            int n = x.Length;

            List<ulong> even_numbers = new List<ulong>();

            for (int i = 0; i < n; i++)
            {
                ulong x_i = x[i];

                if (x_i % 2 == 0)
                {
                    even_numbers.Add(x_i);
                }
            }

            return even_numbers;
        }

        public static List<ulong> EvenDivision(this Span<ulong> x)
        {
            int n = x.Length;

            List<ulong> even_numbers = new List<ulong>();

            for (int i = 0; i < n; i++)
            {
                ulong x_i = x[i];

                if ((x_i / 2) * 2 == x_i)
                {
                    even_numbers.Add(x_i);
                }
            }

            return even_numbers;
        }

        public static List<ulong> EvenBitwiseAndOperator(this Span<ulong> x)
        {
            int n = x.Length;

            List<ulong> even_numbers = new List<ulong>();

            for (int i = 0; i < n; i++)
            {
                ulong x_i = x[i];

                if ((x_i & 1) == 0)
                {
                    even_numbers.Add(x_i);
                }
            }

            return even_numbers;
        }

        public static List<ulong> EvenShiftOperators(this Span<ulong> x)
        {
            int n = x.Length;

            List<ulong> even_numbers = new List<ulong>();

            for (int i = 0; i < n; i++)
            {
                ulong x_i = x[i];

                if ((x_i >> 1) << 1 == x_i)
                {
                    even_numbers.Add(x_i);
                }
            }

            return even_numbers;
        }

        public static List<ulong> Even(this Span<ulong> x)
        {
            return x.EvenShiftOperators();
        }
        //------------------------------------------------------------------------------------------------

    }
}
