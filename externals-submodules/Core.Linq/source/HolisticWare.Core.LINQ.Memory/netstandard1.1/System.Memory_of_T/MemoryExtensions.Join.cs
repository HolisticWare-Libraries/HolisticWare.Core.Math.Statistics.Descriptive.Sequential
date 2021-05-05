using System;
using System.Collections;
using System.Collections.Generic;

namespace Core.LINQ.Memory
{
    public static partial class MemoryExtensions
    {
        public static IEnumerable<TResult> Join<TOuter, TInner, TKey, TResult>
                                                    (
                                                        this System.Memory<TOuter> outer,
                                                        Memory<TInner> inner,
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

            foreach (Grouping<TOuter, TInner> grouping in wah)
            {
                foreach (var innerMatch in grouping)
                {
                    yield return resultSelector(grouping.Key, innerMatch);
                }
            }
        }
    }
}
