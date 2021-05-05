using System;
using System.Collections;
using System.Collections.Generic;
using Core.Linq.ReImplemented.Util;

namespace Core.Linq.ReImplemented
{
    public static partial class Enumerable
    {
        public static IOrderedEnumerable<TSource> OrderBy<TSource, TKey>
                                                        (
                                                            this IEnumerable<TSource> source,
                                                            Func<TSource, TKey> keySelector
                                                        )
        {
            return new OrderedEnumerable<TSource>
                                        (
                                            source,
                                            ProjectionComparer.Create(keySelector)
                                        );
        }

        public static IOrderedEnumerable<TSource> OrderByDescending<TSource, TKey>
                                        (
                                            this IEnumerable<TSource> source,
                                            Func<TSource, TKey> keySelector
                                        )
        {
            return new OrderedEnumerable<TSource>
                                        (
                                            source,
                                            new ReverseComparer<TSource>(ProjectionComparer.Create(keySelector))
                                        );
        }
    }
}
