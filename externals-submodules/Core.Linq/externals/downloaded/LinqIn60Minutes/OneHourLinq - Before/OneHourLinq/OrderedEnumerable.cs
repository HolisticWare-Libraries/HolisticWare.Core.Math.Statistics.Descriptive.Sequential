using System;
using System.Collections;
using System.Collections.Generic;
using OneHour.Linq.Util;

namespace OneHour.Linq
{
    public static class OrderedEnumerable
    {
        //public static IOrderedEnumerable<TElement> ThenBy<TElement, TKey>
        //    (this IOrderedEnumerable<TElement> source, Func<TElement, TKey> keySelector)
        //{
        //    return null;
        //}

        //public static IOrderedEnumerable<TElement> ThenByDescending<TElement, TKey>
        //    (this IOrderedEnumerable<TElement> source, Func<TElement, TKey> keySelector)
        //{
        //    return null;
        //}
    }

    internal class OrderedEnumerable<TElement> : IOrderedEnumerable<TElement>
    {
        internal OrderedEnumerable(IEnumerable<TElement> source, IComparer<TElement> comparer)
        {
        }

        public IOrderedEnumerable<TElement> CreateOrderedEnumerable<TKey>(Func<TElement, TKey> keySelector, IComparer<TKey> keyComparer, bool descending)
        {
            return null;
        }

        public IEnumerator<TElement> GetEnumerator()
        {
            return null;            
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
