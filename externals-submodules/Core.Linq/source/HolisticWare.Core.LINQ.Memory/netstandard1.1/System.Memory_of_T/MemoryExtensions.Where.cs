using System;
using System.Collections;
using System.Collections.Generic;

namespace Core.LINQ.Memory
{
    public static partial class MemoryExtensions
    {
        public static IEnumerable<TSource> Where<TSource>
                                                (
                                                    this System.Memory<TSource> source,
                                                    Func<TSource, bool> predicate
                                                )
        {
            foreach (TSource item in source.ToEnumerable())
            {
                if (predicate(item))
                {
                    yield return item;
                }
            }
        }
    }
}
