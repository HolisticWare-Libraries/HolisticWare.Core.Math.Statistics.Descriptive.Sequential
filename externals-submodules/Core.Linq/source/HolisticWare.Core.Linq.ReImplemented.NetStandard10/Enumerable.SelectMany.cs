using System;
using System.Collections;
using System.Collections.Generic;

namespace Core.Linq.ReImplemented
{
    public static partial class Enumerable
    {
        public static IEnumerable<TResult> SelectMany<TSource, TSubsequence, TResult>
                                                        (
                                                            this IEnumerable<TSource> source,
                                                            Func<TSource, IEnumerable<TSubsequence>> selector,
                                                            Func<TSource, TSubsequence, TResult> resultSelector
                                                        )
        {
            foreach (TSource item in source)
            {
                foreach (TSubsequence sub in selector(item))
                {
                    yield return resultSelector(item, sub);
                }
            }
        }                            
    }
}
