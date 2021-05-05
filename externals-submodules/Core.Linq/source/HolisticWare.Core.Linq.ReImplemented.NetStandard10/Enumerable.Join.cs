using System;
using System.Collections;
using System.Collections.Generic;

namespace Core.Linq.ReImplemented
{
    public static partial class Enumerable
    {
        public static IEnumerable<TResult> Join<TOuter, TInner, TKey, TResult>
                                                    (
                                                        this IEnumerable<TOuter> outer,
                                                        IEnumerable<TInner> inner,
                                                        Func<TOuter, TKey> outerKeySelector,
                                                        Func<TInner, TKey> innerKeySelector,
                                                        Func<TOuter, TInner, TResult> resultSelector
                                                    )
        {
            IEnumerable<Grouping<TOuter, TInner>> wah = outer.GroupJoin
                (
                    inner,
                    outerKeySelector,
                    innerKeySelector, 
                    (outerItem, sequenceOfInners)
                        => 
                        new Grouping<TOuter, TInner>(outerItem, sequenceOfInners)
                );

            foreach (var grouping in wah)
            {
                foreach (var innerMatch in grouping)
                {
                    yield return resultSelector(grouping.Key, innerMatch);
                }
            }
        }
    }
}
