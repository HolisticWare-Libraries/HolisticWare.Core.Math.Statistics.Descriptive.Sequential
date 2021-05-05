using System;
using System.Collections;
using System.Collections.Generic;

namespace Core.LINQ.Memory
{
    public static partial class MemoryExtensions
    {
        public static TSource First<TSource>(this System.Memory<TSource> source)
        {
            foreach (TSource element in source.ToEnumerable())
            {
                return element;
            }
            throw new System.InvalidOperationException("Empty sequence");
        }

        public static TSource FirstOrDefault<TSource>(this System.Memory<TSource> source)
        {
            foreach (TSource element in source.ToEnumerable())
            {
                return element;
            }
            return default(TSource);
        }
    }
}
