using System;
using System.Collections;
using System.Collections.Generic;

namespace Core.Linq.ReImplemented
{
    public static partial class Enumerable
    {
        public static TResult Aggregate<TSource, TAccumulate, TResult>
                                                (
                                                    this IEnumerable<TSource> source,
                                                    TAccumulate seed,
                                                    Func<TAccumulate, TSource, TAccumulate> func,
                                                    Func<TAccumulate, TResult> resultSelector
                                                )
        {
            TAccumulate accumulator = seed;

            foreach (TSource element in source)
            {
                accumulator = func(accumulator, element);
            }
            return resultSelector(accumulator);
        }
    }
}
