using System;
using System.Collections;
using System.Collections.Generic;

namespace Core.LINQ.Memory
{
    public static partial class MemoryExtensions
    {
        public static int Count<TSource>(this System.Memory<TSource> source)
        {
            return source.Length;
        }
    }
}
