using System;
using System.Collections;
using System.Collections.Generic;

namespace OneHour.Linq
{
    class Lookup<TKey, TElement> : ILookup<TKey, TElement>
    {
        internal Lookup()
        {
        }

        public IEnumerator<IGrouping<TKey, TElement>> GetEnumerator()
        {
            return null;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public bool Contains(TKey key)
        {
            return false;
        }

        public int Count
        {
            get { return 0; }
        }

        public IEnumerable<TElement> this[TKey key]
        {
            get { return null; }
        }
    }    
}
