using System.Collections.Generic;

namespace Core.LINQ.Memory
{
    public interface IGrouping<TKey,TElement> : IEnumerable<TElement>
    {
        TKey Key
        {
            get;
        }
    }
}
