using System;
using System.Collections;
using System.Collections.Generic;

namespace Core.LINQ.Memory
{
    public static partial class MemoryExtensions
    {
        public static IEnumerable<TResult> SelectMany<TSource, TSubsequence, TResult>
                                                        (
                                                            this System.Memory<TSource> source,
                                                            Func<TSource, Memory<TSubsequence>> selector,
                                                            Func<TSource, TSubsequence, TResult> resultSelector
                                                        )
        {
            foreach (TSource item in source.ToEnumerable())
            {
                foreach (TSubsequence sub in selector(item).ToEnumerable())
                {
                    yield return resultSelector(item, sub);
                }
            }
        }                            
    }
}
