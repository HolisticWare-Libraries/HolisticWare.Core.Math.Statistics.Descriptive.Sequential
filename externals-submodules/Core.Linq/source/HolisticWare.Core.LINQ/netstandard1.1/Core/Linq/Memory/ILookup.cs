using System.Collections.Generic;

namespace Core.Linq.Memory
{
    public interface ILookup<TKey, TElement> : IEnumerable<IGrouping<TKey, TElement>>
    {
        bool Contains(TKey key);
        int Count { get; }
        IEnumerable<TElement> this[TKey key] { get; }
    }
}
