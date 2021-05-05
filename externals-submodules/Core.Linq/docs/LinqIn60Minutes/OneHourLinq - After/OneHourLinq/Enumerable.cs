using System;
using System.Collections;
using System.Collections.Generic;
using OneHour.Linq.Util;

namespace OneHour.Linq
{
    public static class Enumerable
    {
        #region Select
        public static IEnumerable<TResult> Select<TSource, TResult>(this IEnumerable<TSource> source,
                                                                   Func<TSource, TResult> projection)
        {
            if (source == null)
            {
                throw new ArgumentNullException();
            }
            return SelectImpl(source, projection);
        }

        private static IEnumerable<TResult> SelectImpl<TSource, TResult>(this IEnumerable<TSource> source,
                                                                         Func<TSource, TResult> projection)
        {
            foreach (TSource item in source)
            {
                yield return projection(item);
            }
        }
        #endregion

        #region Where
        public static IEnumerable<TSource> Where<TSource>(this IEnumerable<TSource> source,
                                                          Func<TSource, bool> predicate)
        {
            foreach (TSource item in source)
            {
                if (predicate(item))
                {
                    yield return item;
                }
            }
        }
        #endregion

        #region SelectMany
        public static IEnumerable<TResult> SelectMany<TSource, TSubsequence, TResult>
            (this IEnumerable<TSource> source,
             Func<TSource, IEnumerable<TSubsequence>> selector,
             Func<TSource, TSubsequence, TResult> resultSelector)
        {
            foreach (TSource item in source)
            {
                foreach (TSubsequence sub in selector(item))
                {
                    yield return resultSelector(item, sub);
                }
            }
        }                            
        #endregion

        #region ToLookup
        public static ILookup<TKey, TSource> ToLookup<TSource, TKey>
            (this IEnumerable<TSource> source, Func<TSource, TKey> keySelector)
        {
            return ToLookup(source, keySelector, element => element);
        }

        public static ILookup<TKey, TElement> ToLookup<TSource, TKey, TElement>
            (this IEnumerable<TSource> source, Func<TSource, TKey> keySelector, Func<TSource, TElement> elementSelector)
        {
            Lookup<TKey, TElement> ret = new Lookup<TKey, TElement>();
            foreach (TSource item in source)
            {
                ret.Add(keySelector(item), elementSelector(item));
            }
            return ret;
        }
        #endregion

        #region Empty
        public static IEnumerable<T> Empty<T>()
        {
            yield break;
        }
        #endregion

        #region GroupJoin
        public static IEnumerable<TResult> GroupJoin<TOuter, TInner, TKey, TResult>
            (this IEnumerable<TOuter> outer,
             IEnumerable<TInner> inner,
             Func<TOuter, TKey> outerKeySelector,
             Func<TInner, TKey> innerKeySelector,
             Func<TOuter, IEnumerable<TInner>, TResult> resultSelector)
        {
            ILookup<TKey, TInner> innerLookup = inner.ToLookup(innerKeySelector);
            foreach (TOuter outerElement in outer)
            {
                TKey key = outerKeySelector(outerElement);
                IEnumerable<TInner> innerMatches;
                if (innerLookup.Contains(key))
                {
                    innerMatches = innerLookup[key];
                }
                else
                {
                    innerMatches = Empty<TInner>();
                }
                yield return resultSelector(outerElement, innerMatches);
            }
        }
        #endregion

        #region Join
        public static IEnumerable<TResult> Join<TOuter, TInner, TKey, TResult>
            (this IEnumerable<TOuter> outer,
             IEnumerable<TInner> inner,
             Func<TOuter, TKey> outerKeySelector,
             Func<TInner, TKey> innerKeySelector,
             Func<TOuter, TInner, TResult> resultSelector)
        {
            var wah = outer.GroupJoin(inner, outerKeySelector, innerKeySelector, 
                (outerItem, sequenceOfInners) => 
                    new Grouping<TOuter, TInner>(outerItem, sequenceOfInners));

            foreach (var grouping in wah)
            {
                foreach (var innerMatch in grouping)
                {
                    yield return resultSelector(grouping.Key, innerMatch);
                }
            }
        }
        #endregion

        #region ToList
        public static List<TSource> ToList<TSource>(this IEnumerable<TSource> source)
        {
            return new List<TSource>(source);
        }
        #endregion

        #region GroupBy
        public static IEnumerable<IGrouping<TKey, TSource>> GroupBy<TSource, TKey>
            (this IEnumerable<TSource> source,
             Func<TSource, TKey> keySelector)
        {
            return source.GroupBy(keySelector, element => element);
        }

        public static IEnumerable<IGrouping<TKey, TElement>> GroupBy<TSource, TKey, TElement>
            (this IEnumerable<TSource> source,
             Func<TSource, TKey> keySelector,
             Func<TSource, TElement> elementSelector)
        {
            // Need to preserve output ordering!
            List<TKey> keys = new List<TKey>();

            Lookup<TKey, TElement> ret = new Lookup<TKey, TElement>();
            foreach (TSource item in source)
            {
                TKey key = keySelector(item);
                if (ret.Add(key, elementSelector(item)))
                {
                    keys.Add(key);
                }
            }
            foreach (TKey key in keys)
            {
                yield return new Grouping<TKey, TElement>(key, ret[key]);
            }
        }
        #endregion

        #region OrderBy/OrderByDescending
        public static IOrderedEnumerable<TSource> OrderBy<TSource, TKey>
            (this IEnumerable<TSource> source, Func<TSource, TKey> keySelector)
        {
            return new OrderedEnumerable<TSource>(source, ProjectionComparer.Create(keySelector));
        }

        public static IOrderedEnumerable<TSource> OrderByDescending<TSource, TKey>
            (this IEnumerable<TSource> source, Func<TSource, TKey> keySelector)
        {
            return new OrderedEnumerable<TSource>(source, new ReverseComparer<TSource>(ProjectionComparer.Create(keySelector)));
        }
        #endregion

        #region SequenceEqual
        public static bool SequenceEqual<TSource>(this IEnumerable<TSource> first,
                                                  IEnumerable<TSource> second)
        {
            IEqualityComparer<TSource> comparer = EqualityComparer<TSource>.Default;
            using (IEnumerator<TSource> firstIterator = first.GetEnumerator())
            {
                foreach (TSource secondElement in second)
                {
                    if (!firstIterator.MoveNext())
                    {
                        // First sequence is shorter than second
                        return false;
                    }
                    if (!comparer.Equals(firstIterator.Current, secondElement))
                    {
                        return false;
                    }
                }
                if (firstIterator.MoveNext())
                {
                    // First sequence is longer than first
                    return false;
                }
            }
            return true;
        }
        #endregion

        #region Aggregate
        public static TResult Aggregate<TSource, TAccumulate, TResult>(this IEnumerable<TSource> source,
            TAccumulate seed, Func<TAccumulate, TSource, TAccumulate> func, Func<TAccumulate, TResult> resultSelector)
        {
            TAccumulate accumulator = seed;

            foreach (TSource element in source)
            {
                accumulator = func(accumulator, element);
            }
            return resultSelector(accumulator);
        }
        #endregion

        #region Count
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
        #endregion

        #region First/FirstOrDefault
        public static TSource First<TSource>(this IEnumerable<TSource> source)
        {
            foreach (TSource element in source)
            {
                return element;
            }
            throw new System.InvalidOperationException("Empty sequence");
        }

        public static TSource FirstOrDefault<TSource>(this IEnumerable<TSource> source)
        {
            foreach (TSource element in source)
            {
                return element;
            }
            return default(TSource);
        }
        #endregion

        #region ToArray
        public static TSource[] ToArray<TSource>(this IEnumerable<TSource> source)
        {
            return source.ToList().ToArray();
        }
        #endregion
    }
}
