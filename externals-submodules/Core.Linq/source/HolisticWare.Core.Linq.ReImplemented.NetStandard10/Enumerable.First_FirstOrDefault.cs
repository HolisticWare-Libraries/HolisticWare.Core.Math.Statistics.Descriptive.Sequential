using System;
using System.Collections;
using System.Collections.Generic;

namespace Core.Linq.ReImplemented
{
    public static partial class Enumerable
    {
        public static TSource First<TSource>(this IEnumerable<TSource> source)
        {
            foreach (TSource element in source)
            {
                return element;
            }
            throw new System.InvalidOperationException("Empty sequence");
        }

        public static TSource FirstOrDefault<TSource>(this IEnumerable<TSource> source)
        {
            foreach (TSource element in source)
            {
                return element;
            }
            return default(TSource);
        }
    }
}
