using System;
using System.Collections;
using System.Collections.Generic;

using Core.Linq.ReImplemented.Util;

namespace Core.Linq.ReImplemented
{
    public static class OrderedEnumerable
    {
        public static IOrderedEnumerable<TElement> ThenBy<TElement, TKey>
                                                            (
                                                                this IOrderedEnumerable<TElement> source,
                                                                Func<TElement, TKey> keySelector
                                                            )
        {
            return source.CreateOrderedEnumerable(keySelector, Comparer<TKey>.Default, false);
        }

        public static IOrderedEnumerable<TElement> ThenByDescending<TElement, TKey>
                                                            (
                                                                this IOrderedEnumerable<TElement> source,
                                                                Func<TElement, TKey> keySelector
                                                            )
        {
            return source.CreateOrderedEnumerable(keySelector, Comparer<TKey>.Default, true);
        }    
    }

    internal class OrderedEnumerable<TElement> : IOrderedEnumerable<TElement>
    {
        private readonly IEnumerable<TElement> source;
        private readonly IComparer<TElement> comparer;

        internal OrderedEnumerable
                                (
                                    IEnumerable<TElement> source,
                                    IComparer<TElement> comparer
                                )
        {
            this.source = source;
            this.comparer = comparer;
        }

        public IOrderedEnumerable<TElement> CreateOrderedEnumerable<TKey>
                                                        (
                                                            Func<TElement, TKey> keySelector,
                                                            IComparer<TKey> keyComparer,
                                                            bool descending
                                                        )
        {
            IComparer<TElement> extraComparer = new ProjectionComparer<TElement, TKey>(keySelector, keyComparer);
            if (descending)
            {
                extraComparer = new ReverseComparer<TElement>(extraComparer);
            }
            return new OrderedEnumerable<TElement>(source, new LinkedComparer<TElement>(comparer, extraComparer));
        }

        public IEnumerator<TElement> GetEnumerator()
        {
            // This is painfully slow, but works (and is stable)
            List<TElement> results = new List<TElement>();
            foreach (TElement element in source)
            {
                bool inserted = false;
                for (int i = 0; i < results.Count; i++)
                {
                    if (comparer.Compare(element, results[i]) < 0)
                    {
                        results.Insert(i, element);
                        inserted = true;
                        break;
                    }
                }
                if (!inserted)
                {
                    results.Add(element);
                }
            }
            // Yield to make execution deferred
            foreach (TElement element in results)
            {
                yield return element;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
