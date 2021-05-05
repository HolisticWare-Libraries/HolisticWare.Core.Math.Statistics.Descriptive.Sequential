using System;
using System.Collections;
using System.Collections.Generic;

namespace Core.LINQ.Memory
{
    public static partial class MemoryExtensions
    {
        public static ILookup<TKey, TSource> ToLookup<TSource, TKey>
                                                        (
                                                            this System.Memory<TSource> source,
                                                            Func<TSource, TKey> keySelector
                                                        )
        {
            return ToLookup(source, keySelector, element => element);
        }

        public static ILookup<TKey, TElement> ToLookup<TSource, TKey, TElement>
                                                        (
                                                            this System.Memory<TSource> source,
                                                            Func<TSource, TKey> keySelector,
                                                            Func<TSource, TElement> elementSelector
                                                        )
        {
            Lookup<TKey, TElement> ret = new Lookup<TKey, TElement>();
            foreach (TSource item in source.Span)
            {
                ret.Add(keySelector(item), elementSelector(item));
            }
            return ret;
        }
    }
}
