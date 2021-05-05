using System;
using System.Collections.Generic;

namespace Core.Linq.Memory
{
    public static partial class MemoryExtensions
    {
        //------------------------------------------------------------------------------------------------
        public static IEnumerable<byte> EvenModulo(this Memory<byte> x)
        {
            int n = x.Length;

            for (int i = 0; i < n; i++)
            {
                byte x_i = x.Span[i];

                if (x_i % 2 == 0)
                {
                    yield return x_i;
                }
            }
        }

        public static IEnumerable<byte> EvenDivision(this Memory<byte> x)
        {
            int n = x.Length;

            for (int i = 0; i < n; i++)
            {
                byte x_i = x.Span[i];

                if ((x_i / 2) * 2 == x_i)
                {
                    yield return x_i;
                }
            }
        }

        public static IEnumerable<byte> EvenBitwiseAndOperator(this Memory<byte> x)
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

        public static IEnumerable<byte> EvenShiftOperators(this Memory<byte> x)
        {
            int n = x.Length;

            for (int i = 0; i < n; i++)
            {
                byte x_i = x.Span[i];

                if ((x_i >> 1) << 1 == x_i)
                {
                    yield return x_i;
                }
            }
        }

        public static IEnumerable<byte> Even(this Memory<byte> x)
        {
            return x.EvenShiftOperators();
        }

        //------------------------------------------------------------------------------------------------

        //------------------------------------------------------------------------------------------------
        public static IEnumerable<short> EvenModulo(this Memory<short> x)
        {
            int n = x.Length;

            for (int i = 0; i < n; i++)
            {
                short x_i = x.Span[i];

                if (x_i % 2 == 0)
                {
                    yield return x_i;
                }
            }
        }

        public static IEnumerable<short> EvenDivision(this Memory<short> x)
        {
            int n = x.Length;

            for (int i = 0; i < n; i++)
            {
                short x_i = x.Span[i];

                if ((x_i / 2) * 2 == x_i)
                {
                    yield return x_i;
                }
            }
        }

        public static IEnumerable<short> EvenBitwiseAndOperator(this Memory<short> x)
        {
            int n = x.Length;

            for (int i = 0; i < n; i++)
            {
                short x_i = x.Span[i];

                if ((x_i & 1) == 0)
                {
                    yield return x_i;
                }
            }
        }

        public static IEnumerable<short> EvenShiftOperators(this Memory<short> x)
        {
            int n = x.Length;

            for (int i = 0; i < n; i++)
            {
                short x_i = x.Span[i];

                if ((x_i >> 1) << 1 == x_i)
                {
                    yield return x_i;
                }
            }
        }

        public static IEnumerable<short> Even(this Memory<short> x)
        {
            return x.EvenShiftOperators();
        }
        //------------------------------------------------------------------------------------------------


        //------------------------------------------------------------------------------------------------
        public static IEnumerable<ushort> EvenModulo(this Memory<ushort> x)
        {
            int n = x.Length;

            for (int i = 0; i < n; i++)
            {
                ushort x_i = x.Span[i];

                if (x_i % 2 == 0)
                {
                    yield return x_i;
                }
            }
        }

        public static IEnumerable<ushort> EvenDivision(this Memory<ushort> x)
        {
            int n = x.Length;

            for (int i = 0; i < n; i++)
            {
                ushort x_i = x.Span[i];

                if ((x_i / 2) * 2 == x_i)
                {
                    yield return x_i;
                }
            }
        }

        public static IEnumerable<ushort> EvenBitwiseAndOperator(this Memory<ushort> x)
        {
            int n = x.Length;

            for (int i = 0; i < n; i++)
            {
                ushort x_i = x.Span[i];

                if ((x_i & 1) == 0)
                {
                    yield return x_i;
                }
            }
        }

        public static IEnumerable<ushort> EvenShiftOperators(this Memory<ushort> x)
        {
            int n = x.Length;

            for (int i = 0; i < n; i++)
            {
                ushort x_i = x.Span[i];

                if ((x_i >> 1) << 1 == x_i)
                {
                    yield return x_i;
                }
            }
        }

        public static IEnumerable<ushort> Even(this Memory<ushort> x)
        {
            return x.EvenShiftOperators();
        }
        //------------------------------------------------------------------------------------------------

        //------------------------------------------------------------------------------------------------
        public static IEnumerable<int> EvenModulo(this Memory<int> x)
        {
            int n = x.Length;

            for (int i = 0; i < n; i++)
            {
                int x_i = x.Span[i];

                if (x_i % 2 == 0)
                {
                    yield return x_i;
                }
            }
        }

        public static IEnumerable<int> EvenDivision(this Memory<int> x)
        {
            int n = x.Length;

            for (int i = 0; i < n; i++)
            {
                int x_i = x.Span[i];

                if ((x_i / 2) * 2 == x_i)
                {
                    yield return x_i;
                }
            }
        }

        public static IEnumerable<int> EvenBitwiseAndOperator(this Memory<int> x)
        {
            int n = x.Length;

            for (int i = 0; i < n; i++)
            {
                int x_i = x.Span[i];

                if ((x_i & 1) == 0)
                {
                    yield return x_i;
                }
            }
        }

        public static IEnumerable<int> EvenShiftOperators(this Memory<int> x)
        {
            int n = x.Length;

            for (int i = 0; i < n; i++)
            {
                int x_i = x.Span[i];

                if ((x_i >> 1) << 1 == x_i)
                {
                    yield return x_i;
                }
            }
        }

        public static IEnumerable<int> Even(this Memory<int> x)
        {
            return x.EvenShiftOperators();
        }
        //------------------------------------------------------------------------------------------------

        //------------------------------------------------------------------------------------------------
        public static IEnumerable<uint> EvenModulo(this Memory<uint> x)
        {
            int n = x.Length;

            for (int i = 0; i < n; i++)
            {
                uint x_i = x.Span[i];

                if (x_i % 2 == 0)
                {
                    yield return x_i;
                }
            }
        }

        public static IEnumerable<uint> EvenDivision(this Memory<uint> x)
        {
            int n = x.Length;

            for (int i = 0; i < n; i++)
            {
                uint x_i = x.Span[i];

                if ((x_i / 2) * 2 == x_i)
                {
                    yield return x_i;
                }
            }
        }

        public static IEnumerable<uint> EvenBitwiseAndOperator(this Memory<uint> x)
        {
            int n = x.Length;

            for (int i = 0; i < n; i++)
            {
                uint x_i = x.Span[i];

                if ((x_i & 1) == 0)
                {
                    yield return x_i;
                }
            }
        }

        public static IEnumerable<uint> EvenShiftOperators(this Memory<uint> x)
        {
            int n = x.Length;

            for (int i = 0; i < n; i++)
            {
                uint x_i = x.Span[i];

                if ((x_i >> 1) << 1 == x_i)
                {
                    yield return x_i;
                }
            }
        }

        public static IEnumerable<uint> Even(this Memory<uint> x)
        {
            return x.EvenShiftOperators();
        }
        //------------------------------------------------------------------------------------------------

        //------------------------------------------------------------------------------------------------
        public static IEnumerable<long> EvenModulo(this Memory<long> x)
        {
            int n = x.Length;

            for (int i = 0; i < n; i++)
            {
                long x_i = x.Span[i];

                if (x_i % 2 == 0)
                {
                    yield return x_i;
                }
            }
        }

        public static IEnumerable<long> EvenDivision(this Memory<long> x)
        {
            int n = x.Length;

            for (int i = 0; i < n; i++)
            {
                long x_i = x.Span[i];

                if ((x_i / 2) * 2 == x_i)
                {
                    yield return x_i;
                }
            }
        }

        public static IEnumerable<long> EvenBitwiseAndOperator(this Memory<long> x)
        {
            int n = x.Length;

            for (int i = 0; i < n; i++)
            {
                long x_i = x.Span[i];

                if ((x_i & 1) == 0)
                {
                    yield return x_i;
                }
            }
        }

        public static IEnumerable<long> EvenShiftOperators(this Memory<long> x)
        {
            int n = x.Length;

            for (int i = 0; i < n; i++)
            {
                long x_i = x.Span[i];

                if ((x_i >> 1) << 1 == x_i)
                {
                    yield return x_i;
                }
            }
        }

        public static IEnumerable<long> Even(this Memory<long> x)
        {
            return x.EvenShiftOperators();
        }
        //------------------------------------------------------------------------------------------------

        //------------------------------------------------------------------------------------------------
        public static IEnumerable<ulong> EvenModulo(this Memory<ulong> x)
        {
            int n = x.Length;

            for (int i = 0; i < n; i++)
            {
                ulong x_i = x.Span[i];

                if (x_i % 2 == 0)
                {
                    yield return x_i;
                }
            }
        }

        public static IEnumerable<ulong> EvenDivision(this Memory<ulong> x)
        {
            int n = x.Length;

            for (int i = 0; i < n; i++)
            {
                ulong x_i = x.Span[i];

                if ((x_i / 2) * 2 == x_i)
                {
                    yield return x_i;
                }
            }
        }

        public static IEnumerable<ulong> EvenBitwiseAndOperator(this Memory<ulong> x)
        {
            int n = x.Length;

            for (int i = 0; i < n; i++)
            {
                ulong x_i = x.Span[i];

                if ((x_i & 1) == 0)
                {
                    yield return x_i;
                }
            }
        }

        public static IEnumerable<ulong> EvenShiftOperators(this Memory<ulong> x)
        {
            int n = x.Length;

            for (int i = 0; i < n; i++)
            {
                ulong x_i = x.Span[i];

                if ((x_i >> 1) << 1 == x_i)
                {
                    yield return x_i;
                }
            }
        }

        public static IEnumerable<ulong> Even(this Memory<ulong> x)
        {
            return x.EvenShiftOperators();
        }
        //------------------------------------------------------------------------------------------------

    }
}
