using System;
using System.Collections;
using System.Collections.Generic;

namespace Core.Linq.ReImplemented
{
    public static partial class Enumerable
    {
        public static ILookup<TKey, TSource> ToLookup<TSource, TKey>
                                                        (
                                                            this IEnumerable<TSource> source,
                                                            Func<TSource, TKey> keySelector
                                                        )
        {
            return ToLookup(source, keySelector, element => element);
        }

        public static ILookup<TKey, TElement> ToLookup<TSource, TKey, TElement>
                                                        (
                                                            this IEnumerable<TSource> source,
                                                            Func<TSource, TKey> keySelector,
                                                            Func<TSource, TElement> elementSelector
                                                        )
        {
            Lookup<TKey, TElement> ret = new Lookup<TKey, TElement>();
            foreach (TSource item in source)
            {
                ret.Add(keySelector(item), elementSelector(item));
            }
            return ret;
        }
    }
}
