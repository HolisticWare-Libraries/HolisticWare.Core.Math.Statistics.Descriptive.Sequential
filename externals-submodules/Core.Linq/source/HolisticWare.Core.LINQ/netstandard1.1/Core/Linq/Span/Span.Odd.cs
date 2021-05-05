using System;
using System.Collections.Generic;

namespace Core.Linq.Memory
{
    public static partial class SpanExtensions

    {
        //------------------------------------------------------------------------------------------------
        public static List<byte> OddModulo(this Span<byte> x)
        {
            int n = x.Length;

            List<byte> odd_numbers = new List<byte>();
             
            for (int i = 0; i < n; i++)
            {
                byte x_i = x[i];

                if (x_i % 2 != 0)
                {
                    odd_numbers.Add(x_i);
                }
            }

            return odd_numbers;
        }

        public static List<byte> OddDivision(this Span<byte> x)
        {
            int n = x.Length;

            List<byte> odd_numbers = new List<byte>();

            for (int i = 0; i < n; i++)
            {
                byte x_i = x[i];

                if ((x_i / 2) * 2 != x_i)
                {
                    odd_numbers.Add(x_i);
                }
            }

            return odd_numbers;
        }

        public static List<byte> OddBitwiseAndOperator(this Span<byte> x)
        {
            int n = x.Length;

            List<byte> odd_numbers = new List<byte>();

            for (int i = 0; i < n; i++)
            {
                byte x_i = x[i];

                if ((x_i & 1) != 0)
                {
                    odd_numbers.Add(x_i);
                }
            }

            return odd_numbers;
        }

        public static List<byte> OddShiftOperators(this Span<byte> x)
        {
            int n = x.Length;

            List<byte> odd_numbers = new List<byte>();

            for (int i = 0; i < n; i++)
            {
                byte x_i = x[i];

                if ((x_i >> 1) << 1 != x_i)
                {
                    odd_numbers.Add(x_i);
                }
            }

            return odd_numbers;
        }

        public static List<byte> Odd(this Span<byte> x)
        {
            return x.OddShiftOperators();
        }

        //------------------------------------------------------------------------------------------------

        //------------------------------------------------------------------------------------------------
        public static List<short> OddModulo(this Span<short> x)
        {
            int n = x.Length;

            List<short> odd_numbers = new List<short>();

            for (int i = 0; i < n; i++)
            {
                short x_i = x[i];

                if (x_i % 2 != 0)
                {
                    odd_numbers.Add(x_i);
                }
            }

            return odd_numbers;
        }

        public static List<short> OddDivision(this Span<short> x)
        {
            int n = x.Length;

            List<short> odd_numbers = new List<short>();

            for (int i = 0; i < n; i++)
            {
                short x_i = x[i];

                if ((x_i / 2) * 2 != x_i)
                {
                    odd_numbers.Add(x_i);
                }
            }

            return odd_numbers;
        }

        public static List<short> OddBitwiseAndOperator(this Span<short> x)
        {
            int n = x.Length;

            List<short> odd_numbers = new List<short>();

            for (int i = 0; i < n; i++)
            {
                short x_i = x[i];

                if ((x_i & 1) != 0)
                {
                    odd_numbers.Add(x_i);
                }
            }

            return odd_numbers;
        }

        public static List<short> OddShiftOperators(this Span<short> x)
        {
            int n = x.Length;

            List<short> odd_numbers = new List<short>();

            for (int i = 0; i < n; i++)
            {
                short x_i = x[i];

                if ((x_i >> 1) << 1 != x_i)
                {
                    odd_numbers.Add(x_i);
                }
            }

            return odd_numbers;
        }

        public static List<short> Odd(this Span<short> x)
        {
            return x.OddShiftOperators();
        }
        //------------------------------------------------------------------------------------------------


        //------------------------------------------------------------------------------------------------
        public static List<ushort> OddModulo(this Span<ushort> x)
        {
            int n = x.Length;

            List<ushort> odd_numbers = new List<ushort>();

            for (int i = 0; i < n; i++)
            {
                ushort x_i = x[i];

                if (x_i % 2 != 0)
                {
                    odd_numbers.Add(x_i);
                }
            }

            return odd_numbers;
        }

        public static List<ushort> OddDivision(this Span<ushort> x)
        {
            int n = x.Length;

            List<ushort> odd_numbers = new List<ushort>();

            for (int i = 0; i < n; i++)
            {
                ushort x_i = x[i];

                if ((x_i / 2) * 2 != x_i)
                {
                    odd_numbers.Add(x_i);
                }
            }

            return odd_numbers;
        }

        public static List<ushort> OddBitwiseAndOperator(this Span<ushort> x)
        {
            int n = x.Length;

            List<ushort> odd_numbers = new List<ushort>();

            for (int i = 0; i < n; i++)
            {
                ushort x_i = x[i];

                if ((x_i & 1) != 0)
                {
                    odd_numbers.Add(x_i);
                }
            }

            return odd_numbers;
        }

        public static List<ushort> OddShiftOperators(this Span<ushort> x)
        {
            int n = x.Length;

            List<ushort> odd_numbers = new List<ushort>();

            for (int i = 0; i < n; i++)
            {
                ushort x_i = x[i];

                if ((x_i >> 1) << 1 != x_i)
                {
                    odd_numbers.Add(x_i);
                }
            }

            return odd_numbers;
        }

        public static List<ushort> Odd(this Span<ushort> x)
        {
            return x.OddShiftOperators();
        }
        //------------------------------------------------------------------------------------------------

        //------------------------------------------------------------------------------------------------
        public static List<int> OddModulo(this Span<int> x)
        {
            int n = x.Length;

            List<int> odd_numbers = new List<int>();

            for (int i = 0; i < n; i++)
            {
                int x_i = x[i];

                if (x_i % 2 != 0)
                {
                    odd_numbers.Add(x_i);
                }
            }

            return odd_numbers;
        }

        public static List<int> OddDivision(this Span<int> x)
        {
            int n = x.Length;

            List<int> odd_numbers = new List<int>();

            for (int i = 0; i < n; i++)
            {
                int x_i = x[i];

                if ((x_i / 2) * 2 != x_i)
                {
                    odd_numbers.Add(x_i);
                }
            }

            return odd_numbers;
        }

        public static List<int> OddBitwiseAndOperator(this Span<int> x)
        {
            int n = x.Length;

            List<int> odd_numbers = new List<int>();

            for (int i = 0; i < n; i++)
            {
                int x_i = x[i];

                if ((x_i & 1) != 0)
                {
                    odd_numbers.Add(x_i);
                }
            }

            return odd_numbers;
        }

        public static List<int> OddShiftOperators(this Span<int> x)
        {
            int n = x.Length;

            List<int> odd_numbers = new List<int>();

            for (int i = 0; i < n; i++)
            {
                int x_i = x[i];

                if ((x_i >> 1) << 1 != x_i)
                {
                    odd_numbers.Add(x_i);
                }
            }

            return odd_numbers;
        }

        public static List<int> Odd(this Span<int> x)
        {
            return x.OddShiftOperators();
        }
        //------------------------------------------------------------------------------------------------

        //------------------------------------------------------------------------------------------------
        public static List<uint> OddModulo(this Span<uint> x)
        {
            int n = x.Length;

            List<uint> odd_numbers = new List<uint>();

            for (int i = 0; i < n; i++)
            {
                uint x_i = x[i];

                if (x_i % 2 != 0)
                {
                    odd_numbers.Add(x_i);
                }
            }

            return odd_numbers;
        }

        public static List<uint> OddDivision(this Span<uint> x)
        {
            int n = x.Length;

            List<uint> odd_numbers = new List<uint>();

            for (int i = 0; i < n; i++)
            {
                uint x_i = x[i];

                if ((x_i / 2) * 2 != x_i)
                {
                    odd_numbers.Add(x_i);
                }
            }

            return odd_numbers;
        }

        public static List<uint> OddBitwiseAndOperator(this Span<uint> x)
        {
            int n = x.Length;

            List<uint> odd_numbers = new List<uint>();

            for (int i = 0; i < n; i++)
            {
                uint x_i = x[i];

                if ((x_i & 1) != 0)
                {
                    odd_numbers.Add(x_i);
                }
            }

            return odd_numbers;
        }

        public static List<uint> OddShiftOperators(this Span<uint> x)
        {
            int n = x.Length;

            List<uint> odd_numbers = new List<uint>();

            for (int i = 0; i < n; i++)
            {
                uint x_i = x[i];

                if ((x_i >> 1) << 1 != x_i)
                {
                    odd_numbers.Add(x_i);
                }
            }

            return odd_numbers;
        }

        public static List<uint> Odd(this Span<uint> x)
        {
            return x.OddShiftOperators();
        }
        //------------------------------------------------------------------------------------------------

        //------------------------------------------------------------------------------------------------
        public static List<long> OddModulo(this Span<long> x)
        {
            int n = x.Length;

            List<long> odd_numbers = new List<long>();

            for (int i = 0; i < n; i++)
            {
                long x_i = x[i];

                if (x_i % 2 != 0)
                {
                    odd_numbers.Add(x_i);
                }
            }

            return odd_numbers;
        }

        public static List<long> OddDivision(this Span<long> x)
        {
            int n = x.Length;

            List<long> odd_numbers = new List<long>();

            for (int i = 0; i < n; i++)
            {
                long x_i = x[i];

                if ((x_i / 2) * 2 != x_i)
                {
                    odd_numbers.Add(x_i);
                }
            }

            return odd_numbers;
        }

        public static List<long> OddBitwiseAndOperator(this Span<long> x)
        {
            int n = x.Length;

            List<long> odd_numbers = new List<long>();

            for (int i = 0; i < n; i++)
            {
                long x_i = x[i];

                if ((x_i & 1) != 0)
                {
                    odd_numbers.Add(x_i);
                }
            }

            return odd_numbers;
        }

        public static List<long> OddShiftOperators(this Span<long> x)
        {
            int n = x.Length;

            List<long> odd_numbers = new List<long>();

            for (int i = 0; i < n; i++)
            {
                long x_i = x[i];

                if ((x_i >> 1) << 1 != x_i)
                {
                    odd_numbers.Add(x_i);
                }
            }

            return odd_numbers;
        }

        public static List<long> Odd(this Span<long> x)
        {
            return x.OddShiftOperators();
        }
        //------------------------------------------------------------------------------------------------

        //------------------------------------------------------------------------------------------------
        public static List<ulong> OddModulo(this Span<ulong> x)
        {
            int n = x.Length;

            List<ulong> odd_numbers = new List<ulong>();

            for (int i = 0; i < n; i++)
            {
                ulong x_i = x[i];

                if (x_i % 2 != 0)
                {
                    odd_numbers.Add(x_i);
                }
            }

            return odd_numbers;
        }

        public static List<ulong> OddDivision(this Span<ulong> x)
        {
            int n = x.Length;

            List<ulong> odd_numbers = new List<ulong>();

            for (int i = 0; i < n; i++)
            {
                ulong x_i = x[i];

                if ((x_i / 2) * 2 != x_i)
                {
                    odd_numbers.Add(x_i);
                }
            }

            return odd_numbers;
        }

        public static List<ulong> OddBitwiseAndOperator(this Span<ulong> x)
        {
            int n = x.Length;

            List<ulong> odd_numbers = new List<ulong>();

            for (int i = 0; i < n; i++)
            {
                ulong x_i = x[i];

                if ((x_i & 1) != 0)
                {
                    odd_numbers.Add(x_i);
                }
            }

            return odd_numbers;
        }

        public static List<ulong> OddShiftOperators(this Span<ulong> x)
        {
            int n = x.Length;

            List<ulong> odd_numbers = new List<ulong>();

            for (int i = 0; i < n; i++)
            {
                ulong x_i = x[i];

                if ((x_i >> 1) << 1 != x_i)
                {
                    odd_numbers.Add(x_i);
                }
            }

            return odd_numbers;
        }

        public static List<ulong> Odd(this Span<ulong> x)
        {
            return x.OddShiftOperators();
        }
        //------------------------------------------------------------------------------------------------

    }
}
