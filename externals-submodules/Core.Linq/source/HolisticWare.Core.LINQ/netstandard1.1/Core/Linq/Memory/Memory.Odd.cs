using System;
using System.Collections.Generic;

namespace Core.Linq.Memory
{
    public static partial class MemoryExtensions
    {
        //------------------------------------------------------------------------------------------------
        public static IEnumerable<byte> OddModulo(this Memory<byte> x)
        {
            int n = x.Length;

            for (int i = 0; i < n; i++)
            {
                byte x_i = x.Span[i];

                if (x_i % 2 != 0)
                {
                    yield return x_i;
                }
            }
        }

        public static IEnumerable<byte> OddDivision(this Memory<byte> x)
        {
            int n = x.Length;

            for (int i = 0; i < n; i++)
            {
                byte x_i = x.Span[i];

                if ((x_i / 2) * 2 != x_i)
                {
                    yield return x_i;
                }
            }
        }

        public static IEnumerable<byte> OddBitwiseAndOperator(this Memory<byte> x)
        {
            int n = x.Length;

            for (int i = 0; i < n; i++)
            {
                byte x_i = x.Span[i];

                if ((x_i & 1) != 0)
                {
                    yield return x_i;
                }
            }
        }

        public static IEnumerable<byte> OddShiftOperators(this Memory<byte> x)
        {
            int n = x.Length;

            for (int i = 0; i < n; i++)
            {
                byte x_i = x.Span[i];

                if ((x_i >> 1) << 1 != x_i)
                {
                    yield return x_i;
                }
            }
        }

        public static IEnumerable<byte> Odd(this Memory<byte> x)
        {
            return x.OddShiftOperators();
        }

        //------------------------------------------------------------------------------------------------

        //------------------------------------------------------------------------------------------------
        public static IEnumerable<short> OddModulo(this Memory<short> x)
        {
            int n = x.Length;

            for (int i = 0; i < n; i++)
            {
                short x_i = x.Span[i];

                if (x_i % 2 != 0)
                {
                    yield return x_i;
                }
            }
        }

        public static IEnumerable<short> OddDivision(this Memory<short> x)
        {
            int n = x.Length;

            for (int i = 0; i < n; i++)
            {
                short x_i = x.Span[i];

                if ((x_i / 2) * 2 != x_i)
                {
                    yield return x_i;
                }
            }
        }

        public static IEnumerable<short> OddBitwiseAndOperator(this Memory<short> x)
        {
            int n = x.Length;

            for (int i = 0; i < n; i++)
            {
                short x_i = x.Span[i];

                if ((x_i & 1) != 0)
                {
                    yield return x_i;
                }
            }
        }

        public static IEnumerable<short> OddShiftOperators(this Memory<short> x)
        {
            int n = x.Length;

            for (int i = 0; i < n; i++)
            {
                short x_i = x.Span[i];

                if ((x_i >> 1) << 1 != x_i)
                {
                    yield return x_i;
                }
            }
        }

        public static IEnumerable<short> Odd(this Memory<short> x)
        {
            return x.OddShiftOperators();
        }
        //------------------------------------------------------------------------------------------------


        //------------------------------------------------------------------------------------------------
        public static IEnumerable<ushort> OddModulo(this Memory<ushort> x)
        {
            int n = x.Length;

            for (int i = 0; i < n; i++)
            {
                ushort x_i = x.Span[i];

                if (x_i % 2 != 0)
                {
                    yield return x_i;
                }
            }
        }

        public static IEnumerable<ushort> OddDivision(this Memory<ushort> x)
        {
            int n = x.Length;

            for (int i = 0; i < n; i++)
            {
                ushort x_i = x.Span[i];

                if ((x_i / 2) * 2 != x_i)
                {
                    yield return x_i;
                }
            }
        }

        public static IEnumerable<ushort> OddBitwiseAndOperator(this Memory<ushort> x)
        {
            int n = x.Length;

            for (int i = 0; i < n; i++)
            {
                ushort x_i = x.Span[i];

                if ((x_i & 1) != 0)
                {
                    yield return x_i;
                }
            }
        }

        public static IEnumerable<ushort> OddShiftOperators(this Memory<ushort> x)
        {
            int n = x.Length;

            for (int i = 0; i < n; i++)
            {
                ushort x_i = x.Span[i];

                if ((x_i >> 1) << 1 != x_i)
                {
                    yield return x_i;
                }
            }
        }

        public static IEnumerable<ushort> Odd(this Memory<ushort> x)
        {
            return x.OddShiftOperators();
        }
        //------------------------------------------------------------------------------------------------

        //------------------------------------------------------------------------------------------------
        public static IEnumerable<int> OddModulo(this Memory<int> x)
        {
            int n = x.Length;

            for (int i = 0; i < n; i++)
            {
                int x_i = x.Span[i];

                if (x_i % 2 != 0)
                {
                    yield return x_i;
                }
            }
        }

        public static IEnumerable<int> OddDivision(this Memory<int> x)
        {
            int n = x.Length;

            for (int i = 0; i < n; i++)
            {
                int x_i = x.Span[i];

                if ((x_i / 2) * 2 != x_i)
                {
                    yield return x_i;
                }
            }
        }

        public static IEnumerable<int> OddBitwiseAndOperator(this Memory<int> x)
        {
            int n = x.Length;

            for (int i = 0; i < n; i++)
            {
                int x_i = x.Span[i];

                if ((x_i & 1) != 0)
                {
                    yield return x_i;
                }
            }
        }

        public static IEnumerable<int> OddShiftOperators(this Memory<int> x)
        {
            int n = x.Length;

            for (int i = 0; i < n; i++)
            {
                int x_i = x.Span[i];

                if ((x_i >> 1) << 1 != x_i)
                {
                    yield return x_i;
                }
            }
        }

        public static IEnumerable<int> Odd(this Memory<int> x)
        {
            return x.OddShiftOperators();
        }
        //------------------------------------------------------------------------------------------------

        //------------------------------------------------------------------------------------------------
        public static IEnumerable<uint> OddModulo(this Memory<uint> x)
        {
            int n = x.Length;

            for (int i = 0; i < n; i++)
            {
                uint x_i = x.Span[i];

                if (x_i % 2 != 0)
                {
                    yield return x_i;
                }
            }
        }

        public static IEnumerable<uint> OddDivision(this Memory<uint> x)
        {
            int n = x.Length;

            for (int i = 0; i < n; i++)
            {
                uint x_i = x.Span[i];

                if ((x_i / 2) * 2 != x_i)
                {
                    yield return x_i;
                }
            }
        }

        public static IEnumerable<uint> OddBitwiseAndOperator(this Memory<uint> x)
        {
            int n = x.Length;

            for (int i = 0; i < n; i++)
            {
                uint x_i = x.Span[i];

                if ((x_i & 1) != 0)
                {
                    yield return x_i;
                }
            }
        }

        public static IEnumerable<uint> OddShiftOperators(this Memory<uint> x)
        {
            int n = x.Length;

            for (int i = 0; i < n; i++)
            {
                uint x_i = x.Span[i];

                if ((x_i >> 1) << 1 != x_i)
                {
                    yield return x_i;
                }
            }
        }

        public static IEnumerable<uint> Odd(this Memory<uint> x)
        {
            return x.OddShiftOperators();
        }
        //------------------------------------------------------------------------------------------------

        //------------------------------------------------------------------------------------------------
        public static IEnumerable<long> OddModulo(this Memory<long> x)
        {
            int n = x.Length;

            for (int i = 0; i < n; i++)
            {
                long x_i = x.Span[i];

                if (x_i % 2 != 0)
                {
                    yield return x_i;
                }
            }
        }

        public static IEnumerable<long> OddDivision(this Memory<long> x)
        {
            int n = x.Length;

            for (int i = 0; i < n; i++)
            {
                long x_i = x.Span[i];

                if ((x_i / 2) * 2 != x_i)
                {
                    yield return x_i;
                }
            }
        }

        public static IEnumerable<long> OddBitwiseAndOperator(this Memory<long> x)
        {
            int n = x.Length;

            for (int i = 0; i < n; i++)
            {
                long x_i = x.Span[i];

                if ((x_i & 1) != 0)
                {
                    yield return x_i;
                }
            }
        }

        public static IEnumerable<long> OddShiftOperators(this Memory<long> x)
        {
            int n = x.Length;

            for (int i = 0; i < n; i++)
            {
                long x_i = x.Span[i];

                if ((x_i >> 1) << 1 != x_i)
                {
                    yield return x_i;
                }
            }
        }

        public static IEnumerable<long> Odd(this Memory<long> x)
        {
            return x.OddShiftOperators();
        }
        //------------------------------------------------------------------------------------------------

        //------------------------------------------------------------------------------------------------
        public static IEnumerable<ulong> OddModulo(this Memory<ulong> x)
        {
            int n = x.Length;

            for (int i = 0; i < n; i++)
            {
                ulong x_i = x.Span[i];

                if (x_i % 2 != 0)
                {
                    yield return x_i;
                }
            }
        }

        public static IEnumerable<ulong> OddDivision(this Memory<ulong> x)
        {
            int n = x.Length;

            for (int i = 0; i < n; i++)
            {
                ulong x_i = x.Span[i];

                if ((x_i / 2) * 2 != x_i)
                {
                    yield return x_i;
                }
            }
        }

        public static IEnumerable<ulong> OddBitwiseAndOperator(this Memory<ulong> x)
        {
            int n = x.Length;

            for (int i = 0; i < n; i++)
            {
                ulong x_i = x.Span[i];

                if ((x_i & 1) != 0)
                {
                    yield return x_i;
                }
            }
        }

        public static IEnumerable<ulong> OddShiftOperators(this Memory<ulong> x)
        {
            int n = x.Length;

            for (int i = 0; i < n; i++)
            {
                ulong x_i = x.Span[i];

                if ((x_i >> 1) << 1 != x_i)
                {
                    yield return x_i;
                }
            }
        }

        public static IEnumerable<ulong> Odd(this Memory<ulong> x)
        {
            return x.OddShiftOperators();
        }
        //------------------------------------------------------------------------------------------------

    }
}