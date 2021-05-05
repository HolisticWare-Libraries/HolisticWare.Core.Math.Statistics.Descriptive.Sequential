using System;
using System.Collections;
using System.Collections.Generic;

namespace Core.LINQ.Memory
{
    public static partial class MemoryExtensions
    {
        public static TResult Aggregate<TSource, TAccumulate, TResult>
                                                (
                                                    this System.Memory<TSource> source,
                                                    TAccumulate seed,
                                                    Func<TAccumulate, TSource, TAccumulate> func,
                                                    Func<TAccumulate, TResult> resultSelector
                                                )
        {
            TAccumulate accumulator = seed;

            foreach (TSource element in source.ToEnumerable())
            {
                accumulator = func(accumulator, element);
            }
            return resultSelector(accumulator);
        }
    }
}
