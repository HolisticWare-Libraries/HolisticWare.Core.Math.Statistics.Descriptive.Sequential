using System;
using System.Collections;
using System.Collections.Generic;

namespace Core.LINQ.Memory
{
    public static partial class MemoryExtensions
    {
        public static IEnumerable<TSource> ToEnumerable<TSource>(this System.Memory<TSource> source)
        {
            for (int i = 0; i <= source.Length; i++)
            {
                yield return source.Span[i];
            }
        }
    }
}
