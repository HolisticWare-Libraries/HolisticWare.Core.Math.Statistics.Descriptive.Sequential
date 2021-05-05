using System.Collections.Generic;

namespace OneHour.Linq
{
    public interface IGrouping<TKey,TElement> : IEnumerable<TElement>
    {
        TKey Key { get; }
    }
}
