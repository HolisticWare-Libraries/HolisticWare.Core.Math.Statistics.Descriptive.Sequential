using System;
using System.Collections;
using System.Collections.Generic;

namespace OneHour.Linq
{
    class Grouping<TKey,TElement> : IGrouping<TKey,TElement>
    {
        IEnumerable<TElement> elements;
        TKey key;

        internal Grouping(TKey key, IEnumerable<TElement> elements)
        {
            this.elements = elements;
            this.key = key;
        }

        public IEnumerator<TElement> GetEnumerator()
        {
            return elements.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public TKey Key
        {
            get { return key; }
        }
    }
}
