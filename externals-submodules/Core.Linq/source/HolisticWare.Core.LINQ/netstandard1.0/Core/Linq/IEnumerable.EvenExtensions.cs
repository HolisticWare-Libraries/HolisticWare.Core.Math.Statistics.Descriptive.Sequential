using System;
using System.Collections.Generic;
using System.Linq;

namespace Core.Linq
{
    public static partial class Enumerable
    {
        //------------------------------------------------------------------------------------------------
        public static IEnumerable<byte> EvenModulo(this IEnumerable<byte> x)
        {
            int n = x.Count();

            for (int i = 0; i < n; i++)
            {
                byte x_i = x.ElementAt(i);

                if (x_i % 2 == 0)
                {
                    yield return x_i;
                }
            }
        }

        public static IEnumerable<byte> EvenDivision(this IEnumerable<byte> x)
        {
            int n = x.Count();

            for (int i = 0; i < n; i++)
            {
                byte x_i = x.ElementAt(i);

                if ((x_i / 2) * 2 == x_i)
                {
                    yield return x_i;
                }
            }
        }

        public static IEnumerable<byte> EvenBitwiseAndOperator(this IEnumerable<byte> x)
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

        public static IEnumerable<byte> EvenShiftOperators(this IEnumerable<byte> x)
        {
            int n = x.Count();

            for (int i = 0; i < n; i++)
            {
                byte x_i = x.ElementAt(i);

                if ((x_i >> 1) << 1 == x_i)
                {
                    yield return x_i;
                }
            }
        }

        public static IEnumerable<byte> Even(this IEnumerable<byte> x)
        {
            return x.EvenShiftOperators();
        }

        //------------------------------------------------------------------------------------------------

        //------------------------------------------------------------------------------------------------
        public static IEnumerable<short> EvenModulo(this IEnumerable<short> x)
        {
            int n = x.Count();

            for (int i = 0; i < n; i++)
            {
                short x_i = x.ElementAt(i);

                if (x_i % 2 == 0)
                {
                    yield return x_i;
                }
            }
        }

        public static IEnumerable<short> EvenDivision(this IEnumerable<short> x)
        {
            int n = x.Count();

            for (int i = 0; i < n; i++)
            {
                short x_i = x.ElementAt(i);

                if ((x_i / 2) * 2 == x_i)
                {
                    yield return x_i;
                }
            }
        }

        public static IEnumerable<short> EvenBitwiseAndOperator(this IEnumerable<short> x)
        {
            int n = x.Count();

            for (int i = 0; i < n; i++)
            {
                short x_i = x.ElementAt(i);

                if ((x_i & 1) == 0)
                {
                    yield return x_i;
                }
            }
        }

        public static IEnumerable<short> EvenShiftOperators(this IEnumerable<short> x)
        {
            int n = x.Count();

            for (int i = 0; i < n; i++)
            {
                short x_i = x.ElementAt(i);

                if ((x_i >> 1) << 1 == x_i)
                {
                    yield return x_i;
                }
            }
        }

        public static IEnumerable<short> Even(this IEnumerable<short> x)
        {
            return x.EvenShiftOperators();
        }
        //------------------------------------------------------------------------------------------------


        //------------------------------------------------------------------------------------------------
        public static IEnumerable<ushort> EvenModulo(this IEnumerable<ushort> x)
        {
            int n = x.Count();

            for (int i = 0; i < n; i++)
            {
                ushort x_i = x.ElementAt(i);

                if (x_i % 2 == 0)
                {
                    yield return x_i;
                }
            }
        }

        public static IEnumerable<ushort> EvenDivision(this IEnumerable<ushort> x)
        {
            int n = x.Count();

            for (int i = 0; i < n; i++)
            {
                ushort x_i = x.ElementAt(i);

                if ((x_i / 2) * 2 == x_i)
                {
                    yield return x_i;
                }
            }
        }

        public static IEnumerable<ushort> EvenBitwiseAndOperator(this IEnumerable<ushort> x)
        {
            int n = x.Count();

            for (int i = 0; i < n; i++)
            {
                ushort x_i = x.ElementAt(i);

                if ((x_i & 1) == 0)
                {
                    yield return x_i;
                }
            }
        }

        public static IEnumerable<ushort> EvenShiftOperators(this IEnumerable<ushort> x)
        {
            int n = x.Count();

            for (int i = 0; i < n; i++)
            {
                ushort x_i = x.ElementAt(i);

                if ((x_i >> 1) << 1 == x_i)
                {
                    yield return x_i;
                }
            }
        }

        public static IEnumerable<ushort> Even(this IEnumerable<ushort> x)
        {
            return x.EvenShiftOperators();
        }
        //------------------------------------------------------------------------------------------------

        //------------------------------------------------------------------------------------------------
        public static IEnumerable<int> EvenModulo(this IEnumerable<int> x)
        {
            int n = x.Count();

            for (int i = 0; i < n; i++)
            {
                int x_i = x.ElementAt(i);

                if (x_i % 2 == 0)
                {
                    yield return x_i;
                }
            }
        }

        public static IEnumerable<int> EvenDivision(this IEnumerable<int> x)
        {
            int n = x.Count();

            for (int i = 0; i < n; i++)
            {
                int x_i = x.ElementAt(i);

                if ((x_i / 2) * 2 == x_i)
                {
                    yield return x_i;
                }
            }
        }

        public static IEnumerable<int> EvenBitwiseAndOperator(this IEnumerable<int> x)
        {
            int n = x.Count();

            for (int i = 0; i < n; i++)
            {
                int x_i = x.ElementAt(i);

                if ((x_i & 1) == 0)
                {
                    yield return x_i;
                }
            }
        }

        public static IEnumerable<int> EvenShiftOperators(this IEnumerable<int> x)
        {
            int n = x.Count();

            for (int i = 0; i < n; i++)
            {
                int x_i = x.ElementAt(i);

                if ((x_i >> 1) << 1 == x_i)
                {
                    yield return x_i;
                }
            }
        }

        public static IEnumerable<int> Even(this IEnumerable<int> x)
        {
            return x.EvenShiftOperators();
        }
        //------------------------------------------------------------------------------------------------

        //------------------------------------------------------------------------------------------------
        public static IEnumerable<uint> EvenModulo(this IEnumerable<uint> x)
        {
            int n = x.Count();

            for (int i = 0; i < n; i++)
            {
                uint x_i = x.ElementAt(i);

                if (x_i % 2 == 0)
                {
                    yield return x_i;
                }
            }
        }

        public static IEnumerable<uint> EvenDivision(this IEnumerable<uint> x)
        {
            int n = x.Count();

            for (int i = 0; i < n; i++)
            {
                uint x_i = x.ElementAt(i);

                if ((x_i / 2) * 2 == x_i)
                {
                    yield return x_i;
                }
            }
        }

        public static IEnumerable<uint> EvenBitwiseAndOperator(this IEnumerable<uint> x)
        {
            int n = x.Count();

            for (int i = 0; i < n; i++)
            {
                uint x_i = x.ElementAt(i);

                if ((x_i & 1) == 0)
                {
                    yield return x_i;
                }
            }
        }

        public static IEnumerable<uint> EvenShiftOperators(this IEnumerable<uint> x)
        {
            int n = x.Count();

            for (int i = 0; i < n; i++)
            {
                uint x_i = x.ElementAt(i);

                if ((x_i >> 1) << 1 == x_i)
                {
                    yield return x_i;
                }
            }
        }

        public static IEnumerable<uint> Even(this IEnumerable<uint> x)
        {
            return x.EvenShiftOperators();
        }
        //------------------------------------------------------------------------------------------------

        //------------------------------------------------------------------------------------------------
        public static IEnumerable<long> EvenModulo(this IEnumerable<long> x)
        {
            int n = x.Count();

            for (int i = 0; i < n; i++)
            {
                long x_i = x.ElementAt(i);

                if (x_i % 2 == 0)
                {
                    yield return x_i;
                }
            }
        }

        public static IEnumerable<long> EvenDivision(this IEnumerable<long> x)
        {
            int n = x.Count();

            for (int i = 0; i < n; i++)
            {
                long x_i = x.ElementAt(i);

                if ((x_i / 2) * 2 == x_i)
                {
                    yield return x_i;
                }
            }
        }

        public static IEnumerable<long> EvenBitwiseAndOperator(this IEnumerable<long> x)
        {
            int n = x.Count();

            for (int i = 0; i < n; i++)
            {
                long x_i = x.ElementAt(i);

                if ((x_i & 1) == 0)
                {
                    yield return x_i;
                }
            }
        }

        public static IEnumerable<long> EvenShiftOperators(this IEnumerable<long> x)
        {
            int n = x.Count();

            for (int i = 0; i < n; i++)
            {
                long x_i = x.ElementAt(i);

                if ((x_i >> 1) << 1 == x_i)
                {
                    yield return x_i;
                }
            }
        }

        public static IEnumerable<long> Even(this IEnumerable<long> x)
        {
            return x.EvenShiftOperators();
        }
        //------------------------------------------------------------------------------------------------

        //------------------------------------------------------------------------------------------------
        public static IEnumerable<ulong> EvenModulo(this IEnumerable<ulong> x)
        {
            int n = x.Count();

            for (int i = 0; i < n; i++)
            {
                ulong x_i = x.ElementAt(i);

                if (x_i % 2 == 0)
                {
                    yield return x_i;
                }
            }
        }

        public static IEnumerable<ulong> EvenDivision(this IEnumerable<ulong> x)
        {
            int n = x.Count();

            for (int i = 0; i < n; i++)
            {
                ulong x_i = x.ElementAt(i);

                if ((x_i / 2) * 2 == x_i)
                {
                    yield return x_i;
                }
            }
        }

        public static IEnumerable<ulong> EvenBitwiseAndOperator(this IEnumerable<ulong> x)
        {
            int n = x.Count();

            for (int i = 0; i < n; i++)
            {
                ulong x_i = x.ElementAt(i);

                if ((x_i & 1) == 0)
                {
                    yield return x_i;
                }
            }
        }

        public static IEnumerable<ulong> EvenShiftOperators(this IEnumerable<ulong> x)
        {
            int n = x.Count();

            for (int i = 0; i < n; i++)
            {
                ulong x_i = x.ElementAt(i);

                if ((x_i >> 1) << 1 == x_i)
                {
                    yield return x_i;
                }
            }
        }

        public static IEnumerable<ulong> Even(this IEnumerable<ulong> x)
        {
            return x.EvenShiftOperators();
        }
        //------------------------------------------------------------------------------------------------
    }
}
