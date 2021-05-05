using System;
using System.Collections;
using System.Collections.Generic;

namespace Core.LINQ.Memory
{
    public static partial class MemoryExtensions
    {
        public static IEnumerable<TResult> GroupJoin<TOuter, TInner, TKey, TResult>
                                                (
                                                    this System.Memory<TOuter> outer,
                                                    Memory<TInner> inner,
                                                    Func<TOuter, TKey> outerKeySelector,
                                                    Func<TInner, TKey> innerKeySelector,
                                                    Func<TOuter, Memory<TInner>, TResult> resultSelector
                                                )
        {
            ILookup<TKey, TInner> innerLookup = inner.ToLookup(innerKeySelector);
            foreach (TOuter outerElement in outer.ToEnumerable<TOuter>())
            {
                TKey key = outerKeySelector(outerElement);
                Memory<TInner> innerMatches;
                if (innerLookup.Contains(key))
                {
                    innerMatches = innerLookup[key];
                }
                else
                {
                    innerMatches = Memory<TInner>.Empty;
                }
                yield return resultSelector(outerElement, innerMatches);
            }
        }
    }
}
