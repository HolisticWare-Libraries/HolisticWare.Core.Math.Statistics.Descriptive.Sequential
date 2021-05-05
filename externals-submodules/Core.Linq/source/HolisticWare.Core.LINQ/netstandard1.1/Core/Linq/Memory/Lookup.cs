using System;
using System.Collections;
using System.Collections.Generic;

namespace Core.Linq.Memory
{
    class Lookup<TKey, TElement> : ILookup<TKey, TElement>
    {
        Dictionary<TKey, List<TElement>> dict = new Dictionary<TKey, List<TElement>>();

        internal Lookup()
        {
        }

        /// <summary>
        /// Adds an element by key, and returns whether or not the key was new.
        /// </summary>
        internal bool Add(TKey key, TElement element)
        {
            List<TElement> elements;
            if (!dict.TryGetValue(key, out elements))
            {
                elements = new List<TElement>();
                dict[key] = elements;
                elements.Add(element);
                return true;
            }
            else
            {
                elements.Add(element);
                return false;
            }
        }

        public IEnumerator<IGrouping<TKey, TElement>> GetEnumerator()
        {
            foreach (var pair in dict)
            {
                yield return new Grouping<TKey, TElement>(pair.Key, pair.Value);
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public bool Contains(TKey key)
        {
            return dict.ContainsKey(key);
        }

        public int Count
        {
            get { return dict.Count; }
        }

        public IEnumerable<TElement> this[TKey key]
        {
            get { return dict[key]; }
        }
    }    
}
