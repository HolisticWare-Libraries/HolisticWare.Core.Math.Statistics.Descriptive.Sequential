using System;
using System.Collections;
using System.Collections.Generic;

namespace Core.LINQ.Memory
{
    class Grouping<TKey,TElement> : IGrouping<TKey,TElement>
    {
        Memory<TElement> elements;
        TKey key;

        internal Grouping(TKey key, Memory<TElement> elements)
        {
            this.elements = elements;
            this.key = key;
        }

        public IEnumerator<TElement> GetEnumerator()
        {
            return elements.ToEnumerable<TElement>().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public TKey Key
        {
            get
            {
                return key;
            }
        }
    }
}
