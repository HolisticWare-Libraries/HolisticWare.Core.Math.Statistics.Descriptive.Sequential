using System;
using System.Collections;
using System.Collections.Generic;

namespace Core.LINQ.Memory
{
    public static partial class MemoryExtensions
    {
        public static IEnumerable<TResult> Select<TSource, TResult>
                                                    (
                                                        this System.Memory<TSource> source,
                                                        Func<TSource, TResult> projection
                                                    )
        {
            return SelectImpl(source, projection);
        }

        private static IEnumerable<TResult> SelectImpl<TSource, TResult>
                                                    (
                                                        this System.Memory<TSource> source,
                                                        Func<TSource, TResult> projection
                                                    )
        {
            for (int i = 0; i <= source.Length; i++)
            {
                yield return projection(source.Span[i]);
            }
        }
    }
}
