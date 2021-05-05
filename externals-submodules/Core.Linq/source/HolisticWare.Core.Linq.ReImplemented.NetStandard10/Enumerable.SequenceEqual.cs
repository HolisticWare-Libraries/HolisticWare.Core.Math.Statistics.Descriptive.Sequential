using System;
using System.Collections;
using System.Collections.Generic;

namespace Core.Linq.ReImplemented
{
    public static partial class Enumerable
    {
        public static bool SequenceEqual<TSource>
                                        (
                                            this IEnumerable<TSource> first,
                                            IEnumerable<TSource> second
                                        )
        {
            IEqualityComparer<TSource> comparer = EqualityComparer<TSource>.Default;
            using (IEnumerator<TSource> firstIterator = first.GetEnumerator())
            {
                foreach (TSource secondElement in second)
                {
                    if (!firstIterator.MoveNext())
                    {
                        // First sequence is shorter than second
                        return false;
                    }
                    if (!comparer.Equals(firstIterator.Current, secondElement))
                    {
                        return false;
                    }
                }
                if (firstIterator.MoveNext())
                {
                    // First sequence is longer than first
                    return false;
                }
            }

            return true;
        }
    }
}
