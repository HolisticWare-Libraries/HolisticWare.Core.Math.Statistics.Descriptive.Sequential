using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.LINQ.Memory
{
    public interface ILookup<TKey, TElement> : IEnumerable<IGrouping<TKey, TElement>>
    {
        bool Contains(TKey key);

        int Count
        {
            get;
        }

        Memory<TElement> this[TKey key]
        {
            get;
        }
    }
}
