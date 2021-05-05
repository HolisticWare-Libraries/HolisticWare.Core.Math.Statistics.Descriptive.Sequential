using System;
using System.Collections;
using System.Collections.Generic;

namespace Core.LINQ.Memory
{
    public static partial class MemoryExtensions
    {
        public static IEnumerable<IGrouping<TKey, TSource>> GroupBy<TSource, TKey>
                                                                (
                                                                    this System.Memory<TSource> source,
                                                                    Func<TSource, TKey> keySelector
                                                                )
        {
            return source.GroupBy(keySelector, element => element);
        }

        public static IEnumerable<IGrouping<TKey, TElement>> GroupBy<TSource, TKey, TElement>
                                                                (
                                                                    this System.Memory<TSource> source,
                                                                    Func<TSource, TKey> keySelector,
                                                                    Func<TSource, TElement> elementSelector
                                                                )
        {
            // Need to preserve output ordering!
            List<TKey> keys = new List<TKey>();

            Lookup<TKey, TElement> ret = new Lookup<TKey, TElement>();
            foreach (TSource item in source.ToEnumerable())
            {
                TKey key = keySelector(item);
                if (ret.Add(key, elementSelector(item)))
                {
                    keys.Add(key);
                }
            }
            foreach (TKey key in keys)
            {
                yield return new Grouping<TKey, TElement>(key, ret[key]);
            }
        }
    }
}
