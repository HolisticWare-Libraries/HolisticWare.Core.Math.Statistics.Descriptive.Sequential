using System;
using System.Collections;
using System.Collections.Generic;

namespace Core.LINQ.Memory
{
    public static partial class MemoryExtensions
    {
        public static TSource ElementAt<TSource>(this System.Memory<TSource> source, int i)
        {
            return source.Span[i];
        }
    }
}
