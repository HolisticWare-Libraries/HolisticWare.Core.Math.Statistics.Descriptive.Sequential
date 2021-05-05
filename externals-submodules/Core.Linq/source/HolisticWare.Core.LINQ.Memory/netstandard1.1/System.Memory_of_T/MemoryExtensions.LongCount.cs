using System;
using System.Collections;
using System.Collections.Generic;

namespace Core.LINQ.Memory
{
    public static partial class MemoryExtensions
    {
        public static long LongCount<TSource>(this System.Memory<TSource> source)
        {
            return source.Length;
        }

    }
}
