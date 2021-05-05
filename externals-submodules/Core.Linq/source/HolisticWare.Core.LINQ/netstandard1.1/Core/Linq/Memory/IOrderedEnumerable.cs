using System;
using System.Collections.Generic;

namespace Core.Linq.Memory
{
    public interface IOrderedEnumerable<TElement> : IEnumerable<TElement>
    {
        IOrderedEnumerable<TElement> CreateOrderedEnumerable<TKey>
                                                (
                                                    Func<TElement, TKey> keySelector,
	                                                IComparer<TKey> comparer,
	                                                bool descending
                                                );
    }
}
