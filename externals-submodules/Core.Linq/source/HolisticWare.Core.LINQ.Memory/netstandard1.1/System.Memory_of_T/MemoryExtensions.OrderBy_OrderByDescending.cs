using System;
using System.Collections;
using System.Collections.Generic;
using Core.LINQ.Memory.Util;

namespace Core.LINQ.Memory
{
    public static partial class MemoryExtensions
    {
        public static IOrderedEnumerable<TSource> OrderBy<TSource, TKey>
                                                        (
                                                            this System.Memory<TSource> source,
                                                            Func<TSource, TKey> keySelector
                                                        )
        {
            return new OrderedEnumerable<TSource>
                                        (
                                            source.ToEnumerable(),
                                            ProjectionComparer.Create(keySelector)
                                        );
        }

        public static IOrderedEnumerable<TSource> OrderByDescending<TSource, TKey>
                                                        (
                                                            this System.Memory<TSource> source,
                                                            Func<TSource, TKey> keySelector
                                                        )
        {
            return new OrderedEnumerable<TSource>
                                        (
                                            source.ToEnumerable(),
                                            new ReverseComparer<TSource>(ProjectionComparer.Create(keySelector))
                                        );
        }
    }
}
