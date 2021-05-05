using System;
using System.Collections;
using System.Collections.Generic;

namespace Core.LINQ.Memory
{
    public static partial class MemoryExtensions
    {
        public static List<TSource> ToList<TSource>(this System.Memory<TSource> source)
        {
            return new List<TSource>(source.ToList());
        }
    }
}
