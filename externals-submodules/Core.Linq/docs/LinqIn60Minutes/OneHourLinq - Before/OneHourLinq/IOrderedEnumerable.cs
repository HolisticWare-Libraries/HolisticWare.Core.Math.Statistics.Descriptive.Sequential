using System;
using System.Collections.Generic;

namespace OneHour.Linq
{
    public interface IOrderedEnumerable<TElement> : IEnumerable<TElement>
    {
        IOrderedEnumerable<TElement> CreateOrderedEnumerable<TKey>
            (Func<TElement, TKey> keySelector,
	         IComparer<TKey> comparer,
	         bool descending);
    }
}
