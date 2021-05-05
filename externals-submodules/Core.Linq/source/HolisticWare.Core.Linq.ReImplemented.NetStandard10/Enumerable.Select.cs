using System;
using System.Collections;
using System.Collections.Generic;

namespace Core.Linq.ReImplemented
{
    public static partial class Enumerable
    {
        public static IEnumerable<TResult> Select<TSource, TResult>
                                                    (
                                                        this IEnumerable<TSource> source,
                                                        Func<TSource, TResult> projection
                                                    )
        {
            if (source == null)
            {
                throw new ArgumentNullException();
            }

            return SelectImpl(source, projection);
        }

        private static IEnumerable<TResult> SelectImpl<TSource, TResult>
                                                    (
                                                        this IEnumerable<TSource> source,
                                                        Func<TSource, TResult> projection
                                                    )
        {
            foreach (TSource item in source)
            {
                yield return projection(item);
            }
        }
    }
}
