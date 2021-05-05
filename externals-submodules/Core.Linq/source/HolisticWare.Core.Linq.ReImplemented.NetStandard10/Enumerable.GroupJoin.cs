using System;
using System.Collections;
using System.Collections.Generic;

namespace Core.Linq.ReImplemented
{
    public static partial class Enumerable
    {
        public static IEnumerable<TResult> GroupJoin<TOuter, TInner, TKey, TResult>
            (
                this IEnumerable<TOuter> outer,
                IEnumerable<TInner> inner,
                Func<TOuter, TKey> outerKeySelector,
                Func<TInner, TKey> innerKeySelector,
                Func<TOuter, IEnumerable<TInner>, TResult> resultSelector
            )
        {
            ILookup<TKey, TInner> innerLookup = inner.ToLookup(innerKeySelector);
            foreach (TOuter outerElement in outer)
            {
                TKey key = outerKeySelector(outerElement);
                IEnumerable<TInner> innerMatches;
                if (innerLookup.Contains(key))
                {
                    innerMatches = innerLookup[key];
                }
                else
                {
                    innerMatches = Empty<TInner>();
                }
                yield return resultSelector(outerElement, innerMatches);
            }
        }
    }
}
