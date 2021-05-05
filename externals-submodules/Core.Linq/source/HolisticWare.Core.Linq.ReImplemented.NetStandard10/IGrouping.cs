using System.Collections.Generic;

namespace Core.Linq.ReImplemented
{
    public interface IGrouping<TKey,TElement> : IEnumerable<TElement>
    {
        TKey Key
        {
            get;
        }
    }
}
