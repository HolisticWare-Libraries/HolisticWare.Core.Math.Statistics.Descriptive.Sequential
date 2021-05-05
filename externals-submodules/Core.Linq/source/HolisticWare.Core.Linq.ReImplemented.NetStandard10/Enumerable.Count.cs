using System;
using System.Collections;
using System.Collections.Generic;

namespace Core.Linq.ReImplemented
{
    public static partial class Enumerable
    {
        public static int Count<TSource>(this IEnumerable<TSource> source)
        {
            // Optimisation
            IList list = source as IList;
            if (list != null)
            {
                return list.Count;
            }
            int count = 0;
            foreach (TSource element in source)
            {
                count++;
            }
            return count;
        }
    }
}
