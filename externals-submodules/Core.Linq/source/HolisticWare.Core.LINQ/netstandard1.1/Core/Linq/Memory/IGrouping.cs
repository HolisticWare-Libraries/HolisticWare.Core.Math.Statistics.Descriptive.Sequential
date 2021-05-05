using System.Collections.Generic;

namespace Core.Linq.Memory
{
    public interface IGrouping<TKey,TElement> : IEnumerable<TElement>
    {
        TKey Key { get; }
    }
}
