using System;
using System.Collections;
using System.Collections.Generic;

namespace OneHour.Linq
{
    class Grouping<TKey,TElement> : IGrouping<TKey,TElement>
    {
        internal Grouping(TKey key)
        {
        }

        public IEnumerator<TElement> GetEnumerator()
        {
            return null;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public TKey Key
        {
            get { return default(TKey); }
        }
    }
}
