using System;
using System.Collections.Generic;
using System.Linq;

namespace Core.Linq
{
    public static partial class Enumerable
    {
        //------------------------------------------------------------------------------------------------
        public static IEnumerable<byte> OddModulo(this IEnumerable<byte> x)
        {
            int n = x.Count();

            for (int i = 0; i < n; i++)
            {
                byte x_i = x.ElementAt(i);

                if (x_i % 2 != 0)
                {
                    yield return x_i;
                }
            }
        }

        public static IEnumerable<byte> OddDivision(this IEnumerable<byte> x)
        {
            int n = x.Count();

            for (int i = 0; i < n; i++)
            {
                byte x_i = x.ElementAt(i);

                if ((x_i / 2) * 2 != x_i)
                {
                    yield return x_i;
                }
            }
        }

        public static IEnumerable<byte> OddBitwiseAndOperator(this IEnumerable<byte> x)
        {
            int n = x.Count();

            for (int i = 0; i < n; i++)
            {
                byte x_i = x.ElementAt(i);

                if ( (x_i & 1) != 0)
                {
                    yield return x_i;
                }
            }
        }

        public static IEnumerable<byte> OddShiftOperators(this IEnumerable<byte> x)
        {
            int n = x.Count();

            for (int i = 0; i < n; i++)
            {
                byte x_i = x.ElementAt(i);

                if ((x_i >> 1) << 1 != x_i)
                {
                    yield return x_i;
                }
            }
        }

        public static IEnumerable<byte> Odd(this IEnumerable<byte> x)
        {
            return x.OddShiftOperators();
        }

        //------------------------------------------------------------------------------------------------

        //------------------------------------------------------------------------------------------------
        public static IEnumerable<short> OddModulo(this IEnumerable<short> x)
        {
            int n = x.Count();

            for (int i = 0; i < n; i++)
            {
                short x_i = x.ElementAt(i);

                if (x_i % 2 != 0)
                {
                    yield return x_i;
                }
            }
        }

        public static IEnumerable<short> OddDivision(this IEnumerable<short> x)
        {
            int n = x.Count();

            for (int i = 0; i < n; i++)
            {
                short x_i = x.ElementAt(i);

                if ((x_i / 2) * 2 != x_i)
                {
                    yield return x_i;
                }
            }
        }

        public static IEnumerable<short> OddBitwiseAndOperator(this IEnumerable<short> x)
        {
            int n = x.Count();

            for (int i = 0; i < n; i++)
            {
                short x_i = x.ElementAt(i);

                if ((x_i & 1) != 0)
                {
                    yield return x_i;
                }
            }
        }

        public static IEnumerable<short> OddShiftOperators(this IEnumerable<short> x)
        {
            int n = x.Count();

            for (int i = 0; i < n; i++)
            {
                short x_i = x.ElementAt(i);

                if ((x_i >> 1) << 1 != x_i)
                {
                    yield return x_i;
                }
            }
        }

        public static IEnumerable<short> Odd(this IEnumerable<short> x)
        {
            return x.OddShiftOperators();
        }
        //------------------------------------------------------------------------------------------------


        //------------------------------------------------------------------------------------------------
        public static IEnumerable<ushort> OddModulo(this IEnumerable<ushort> x)
        {
            int n = x.Count();

            for (int i = 0; i < n; i++)
            {
                ushort x_i = x.ElementAt(i);

                if (x_i % 2 != 0)
                {
                    yield return x_i;
                }
            }
        }

        public static IEnumerable<ushort> OddDivision(this IEnumerable<ushort> x)
        {
            int n = x.Count();

            for (int i = 0; i < n; i++)
            {
                ushort x_i = x.ElementAt(i);

                if ((x_i / 2) * 2 != x_i)
                {
                    yield return x_i;
                }
            }
        }

        public static IEnumerable<ushort> OddBitwiseAndOperator(this IEnumerable<ushort> x)
        {
            int n = x.Count();

            for (int i = 0; i < n; i++)
            {
                ushort x_i = x.ElementAt(i);

                if ((x_i & 1) != 0)
                {
                    yield return x_i;
                }
            }
        }

        public static IEnumerable<ushort> OddShiftOperators(this IEnumerable<ushort> x)
        {
            int n = x.Count();

            for (int i = 0; i < n; i++)
            {
                ushort x_i = x.ElementAt(i);

                if ((x_i >> 1) << 1 != x_i)
                {
                    yield return x_i;
                }
            }
        }

        public static IEnumerable<ushort> Odd(this IEnumerable<ushort> x)
        {
            return x.OddShiftOperators();
        }
        //------------------------------------------------------------------------------------------------

        //------------------------------------------------------------------------------------------------
        public static IEnumerable<int> OddModulo(this IEnumerable<int> x)
        {
            int n = x.Count();

            for (int i = 0; i < n; i++)
            {
                int x_i = x.ElementAt(i);

                if (x_i % 2 != 0)
                {
                    yield return x_i;
                }
            }
        }

        public static IEnumerable<int> OddDivision(this IEnumerable<int> x)
        {
            int n = x.Count();

            for (int i = 0; i < n; i++)
            {
                int x_i = x.ElementAt(i);

                if ((x_i / 2) * 2 != x_i)
                {
                    yield return x_i;
                }
            }
        }

        public static IEnumerable<int> OddBitwiseAndOperator(this IEnumerable<int> x)
        {
            int n = x.Count();

            for (int i = 0; i < n; i++)
            {
                int x_i = x.ElementAt(i);

                if ((x_i & 1) != 0)
                {
                    yield return x_i;
                }
            }
        }

        public static IEnumerable<int> OddShiftOperators(this IEnumerable<int> x)
        {
            int n = x.Count();

            for (int i = 0; i < n; i++)
            {
                int x_i = x.ElementAt(i);

                if ((x_i >> 1) << 1 != x_i)
                {
                    yield return x_i;
                }
            }
        }

        public static IEnumerable<int> Odd(this IEnumerable<int> x)
        {
            return x.OddShiftOperators();
        }
        //------------------------------------------------------------------------------------------------

        //------------------------------------------------------------------------------------------------
        public static IEnumerable<uint> OddModulo(this IEnumerable<uint> x)
        {
            int n = x.Count();

            for (int i = 0; i < n; i++)
            {
                uint x_i = x.ElementAt(i);

                if (x_i % 2 != 0)
                {
                    yield return x_i;
                }
            }
        }

        public static IEnumerable<uint> OddDivision(this IEnumerable<uint> x)
        {
            int n = x.Count();

            for (int i = 0; i < n; i++)
            {
                uint x_i = x.ElementAt(i);

                if ((x_i / 2) * 2 != x_i)
                {
                    yield return x_i;
                }
            }
        }

        public static IEnumerable<uint> OddBitwiseAndOperator(this IEnumerable<uint> x)
        {
            int n = x.Count();

            for (int i = 0; i < n; i++)
            {
                uint x_i = x.ElementAt(i);

                if ((x_i & 1) != 0)
                {
                    yield return x_i;
                }
            }
        }

        public static IEnumerable<uint> OddShiftOperators(this IEnumerable<uint> x)
        {
            int n = x.Count();

            for (int i = 0; i < n; i++)
            {
                uint x_i = x.ElementAt(i);

                if ((x_i >> 1) << 1 != x_i)
                {
                    yield return x_i;
                }
            }
        }

        public static IEnumerable<uint> Odd(this IEnumerable<uint> x)
        {
            return x.OddShiftOperators();
        }
        //------------------------------------------------------------------------------------------------

        //------------------------------------------------------------------------------------------------
        public static IEnumerable<long> OddModulo(this IEnumerable<long> x)
        {
            int n = x.Count();

            for (int i = 0; i < n; i++)
            {
                long x_i = x.ElementAt(i);

                if (x_i % 2 != 0)
                {
                    yield return x_i;
                }
            }
        }

        public static IEnumerable<long> OddDivision(this IEnumerable<long> x)
        {
            int n = x.Count();

            for (int i = 0; i < n; i++)
            {
                long x_i = x.ElementAt(i);

                if ((x_i / 2) * 2 != x_i)
                {
                    yield return x_i;
                }
            }
        }

        public static IEnumerable<long> OddBitwiseAndOperator(this IEnumerable<long> x)
        {
            int n = x.Count();

            for (int i = 0; i < n; i++)
            {
                long x_i = x.ElementAt(i);

                if ((x_i & 1) != 0)
                {
                    yield return x_i;
                }
            }
        }

        public static IEnumerable<long> OddShiftOperators(this IEnumerable<long> x)
        {
            int n = x.Count();

            for (int i = 0; i < n; i++)
            {
                long x_i = x.ElementAt(i);

                if ((x_i >> 1) << 1 != x_i)
                {
                    yield return x_i;
                }
            }
        }

        public static IEnumerable<long> Odd(this IEnumerable<long> x)
        {
            return x.OddShiftOperators();
        }
        //------------------------------------------------------------------------------------------------

        //------------------------------------------------------------------------------------------------
        public static IEnumerable<ulong> OddModulo(this IEnumerable<ulong> x)
        {
            int n = x.Count();

            for (int i = 0; i < n; i++)
            {
                ulong x_i = x.ElementAt(i);

                if (x_i % 2 != 0)
                {
                    yield return x_i;
                }
            }
        }

        public static IEnumerable<ulong> OddDivision(this IEnumerable<ulong> x)
        {
            int n = x.Count();

            for (int i = 0; i < n; i++)
            {
                ulong x_i = x.ElementAt(i);

                if ((x_i / 2) * 2 != x_i)
                {
                    yield return x_i;
                }
            }
        }

        public static IEnumerable<ulong> OddBitwiseAndOperator(this IEnumerable<ulong> x)
        {
            int n = x.Count();

            for (int i = 0; i < n; i++)
            {
                ulong x_i = x.ElementAt(i);

                if ((x_i & 1) != 0)
                {
                    yield return x_i;
                }
            }
        }

        public static IEnumerable<ulong> OddShiftOperators(this IEnumerable<ulong> x)
        {
            int n = x.Count();

            for (int i = 0; i < n; i++)
            {
                ulong x_i = x.ElementAt(i);

                if ((x_i >> 1) << 1 != x_i)
                {
                    yield return x_i;
                }
            }
        }

        public static IEnumerable<ulong> Odd(this IEnumerable<ulong> x)
        {
            return x.OddShiftOperators();
        }
        //------------------------------------------------------------------------------------------------
    }
}
