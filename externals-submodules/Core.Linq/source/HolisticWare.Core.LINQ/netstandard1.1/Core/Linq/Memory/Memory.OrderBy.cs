using System;
using System.Linq;

using Core.Linq.Memory.Util;

namespace Core.Linq.Memory
{
    public static partial class MemoryExtensions
    {
        public static IOrderedEnumerable<TSource> OrderBy<TSource, TKey>
                                                                (
                                                                    this Memory<TSource> source,
                                                                    Func<TSource, TKey> keySelector
                                                                ) {
            return new OrderedEnumerable<TSource>
                                        (
                                            source.ToList().AsEnumerable(),
                                            ProjectionComparer.Create(keySelector)
                                        );
        }

        public static IOrderedEnumerable<TSource> OrderByDescending<TSource, TKey>
                                                                (
                                                                    this Memory<TSource> source,
                                                                    Func<TSource, TKey> keySelector
                                                                )
            {
            return new OrderedEnumerable<TSource>
                                        (
                                            source.ToList().AsEnumerable(),
                                            new ReverseComparer<TSource>(ProjectionComparer.Create(keySelector))
                                        );
        }
    }
}
