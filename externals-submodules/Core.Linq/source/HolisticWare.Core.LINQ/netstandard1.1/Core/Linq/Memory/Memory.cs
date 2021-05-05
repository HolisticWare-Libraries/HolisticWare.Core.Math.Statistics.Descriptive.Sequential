using System;
using System.Collections;
using System.Collections.Generic;

namespace Core.Linq.Memory
{
    public static partial class MemoryExtensionsExtensions
    {
        #region Select
        public static Memory<TResult> Select<TSource, TResult>
                                                        (
                                                            this Memory<TSource> source,
                                                            Func<TSource, TResult> projection
                                                        )
        {
            return SelectImpl(source, projection);
        }

        private static Memory<TResult> SelectImpl<TSource, TResult>(this Memory<TSource> source,
                                                                         Func<TSource, TResult> projection)
        {
            int n = source.Length;
            TResult[] tmp_array = new TResult[n];

            for (int i = 0; i < n; i++)
            {
                TSource item = source.Span[i];
                tmp_array[i] = projection(item);
            }

            Memory<TResult> result = new Memory<TResult>();

            return result;
        }
        #endregion

        #region Where
        public static Memory<TSource> Where<TSource>
                                                        (
                                                            this Memory<TSource> source,
                                                            Func<TSource, bool> predicate
                                                        )
        {
            int n = source.Length;
            TSource[] tmp_array = new TSource[n];

            for (int i = 0; i < n; i++)
            {
                TSource item = source.Span[i];
                if (predicate(item))
                {
                    tmp_array[i] = item;
                }
            }

            Memory<TSource> result = new Memory<TSource>();

            return result;
        }
        #endregion

        #region SelectMany
        //public static Memory<TResult> SelectMany<TSource, TSubsequence, TResult>
        //                                            (
        //                                                this Memory<TSource> source,
        //                                                Func<TSource, Memory<TSubsequence>> selector,
        //                                                Func<TSource, TSubsequence, TResult> resultSelector
        //                                            )
        //{
        //    int n = source.Length;
        //    int m = selector.Le
        //    TSource[] tmp_array = new TSource[n];

        //    for (int i = 0; i < n; i++)
        //    {
        //        TSource item = source.Span[i];

        //        for (int j = 0; i < m; i++)
        //        {
        //            TSource item = source.Span[i];

        //        }
        //    }

        //    Memory<TSource> result = new Memory<TSource>();

        //    return result;

        //    foreach (TSource item in source)
        //    {
        //        foreach (TSubsequence sub in selector(item))
        //        {
        //            yield return resultSelector(item, sub);
        //        }
        //    }
        //}                            
        #endregion

        #region ToLookup
        public static ILookup<TKey, TSource> ToLookup<TSource, TKey>
                                                            (
                                                                this Memory<TSource> source,
                                                                Func<TSource, TKey> keySelector
                                                            )
        {
            return ToLookup(source, keySelector, element => element);
        }

        public static ILookup<TKey, TElement> ToLookup<TSource, TKey, TElement>
                                                            (
                                                                this Memory<TSource> source,
                                                                Func<TSource, TKey> keySelector,
                                                                Func<TSource, TElement> elementSelector
                                                            )
        {
            Lookup<TKey, TElement> ret = new Lookup<TKey, TElement>();

            int n = source.Length;
            for(int i = 0; i < n; i ++)
            {
                TSource item = source.Span[i];
                ret.Add(keySelector(item), elementSelector(item));
            }
            //foreach (TSource item in source)
            //{
            //    ret.Add(keySelector(item), elementSelector(item));
            //}
            return ret;
        }
        #endregion

        #region Empty
        public static Memory<T> Empty<T>()
        {
            return new Memory<T>();
        }

        public static Memory<T> Empty<T>(int n)
        {
            return new Memory<T>(new T[n]);
        }
        #endregion

        #region GroupJoin
        //public static Memory<TResult> GroupJoin<TOuter, TInner, TKey, TResult>
        //                                            (
        //                                                this Memory<TOuter> outer,
        //                                                Memory<TInner> inner,
        //                                                Func<TOuter, TKey> outerKeySelector,
        //                                                Func<TInner, TKey> innerKeySelector,
        //                                                Func<TOuter, Memory<TInner>, TResult> resultSelector
        //                                            )
        //{
        //    ILookup<TKey, TInner> innerLookup = inner.ToLookup(innerKeySelector);
        //    foreach (TOuter outerElement in outer)
        //    {
        //        TKey key = outerKeySelector(outerElement);
        //        Memory<TInner> innerMatches;
        //        if (innerLookup.Contains(key))
        //        {
        //            innerMatches = innerLookup[key];
        //        }
        //        else
        //        {
        //            innerMatches = Empty<TInner>();
        //        }
        //        yield return resultSelector(outerElement, innerMatches);
        //    }
        //}
        #endregion

        #region Join
        //public static Memory<TResult> Join<TOuter, TInner, TKey, TResult>
        //    (this Memory<TOuter> outer,
        //     Memory<TInner> inner,
        //     Func<TOuter, TKey> outerKeySelector,
        //     Func<TInner, TKey> innerKeySelector,
        //     Func<TOuter, TInner, TResult> resultSelector)
        //{
        //    var wah = outer.GroupJoin(inner, outerKeySelector, innerKeySelector, 
        //        (outerItem, sequenceOfInners) => 
        //            new Grouping<TOuter, TInner>(outerItem, sequenceOfInners));

        //    foreach (var grouping in wah)
        //    {
        //        foreach (var innerMatch in grouping)
        //        {
        //            yield return resultSelector(grouping.Key, innerMatch);
        //        }
        //    }
        //}
        #endregion

        #region ToList
        public static List<TSource> ToList<TSource>(this Memory<TSource> source)
        {
            return new List<TSource>(source.ToArray<TSource>());
        }
        #endregion

        #region GroupBy
        //public static Memory<IGrouping<TKey, TSource>> GroupBy<TSource, TKey>
        //    (this Memory<TSource> source,
        //     Func<TSource, TKey> keySelector)
        //{
        //    return source.GroupBy(keySelector, element => element);
        //}

        //public static Memory<IGrouping<TKey, TElement>> GroupBy<TSource, TKey, TElement>
        //                                                        (
        //                                                            this Memory<TSource> source,
        //                                                            Func<TSource, TKey> keySelector,
        //                                                            Func<TSource, TElement> elementSelector
        //                                                        )
        //{
        //    Need to preserve output ordering!
        //    List<TKey> keys = new List<TKey>();

        //    Lookup<TKey, TElement> ret = new Lookup<TKey, TElement>();
        //    foreach (TSource item in source)
        //    {
        //        TKey key = keySelector(item);
        //        if (ret.Add(key, elementSelector(item)))
        //        {
        //            keys.Add(key);
        //        }
        //    }
        //    foreach (TKey key in keys)
        //    {
        //        yield return new Grouping<TKey, TElement>(key, ret[key]);
        //    }
        //}
        #endregion


        #region SequenceEqual
        public static bool SequenceEqual<TSource>
                                                    (
                                                        this Memory<TSource> first,
                                                        Memory<TSource> second
                                                    )
        {
            int n = first.Length;
            int m = second.Length;

            if ( n != m )
            {
                return false;
            }

            IEqualityComparer<TSource> comparer = EqualityComparer<TSource>.Default;

            for(int i = 0; i < n; i++)
            {
               if (!comparer.Equals(first.Span[i], second.Span[i]))
                {
                    return false;
                }

            }
            //using (IEnumerator<TSource> firstIterator = first.GetEnumerator())
            //{
            //    foreach (TSource secondElement in second)
            //    {
            //        if (!firstIterator.MoveNext())
            //        {
            //            First sequence is shorter than second
            //            return false;
            //        }
            //        if (!comparer.Equals(firstIterator.Current, secondElement))
            //        {
            //            return false;
            //        }
            //    }
            //    if (firstIterator.MoveNext())
            //    {
            //        First sequence is longer than first
            //        return false;
            //    }
            //}

            return true;
        }
        #endregion

        #region Aggregate
        public static TResult Aggregate<TSource, TAccumulate, TResult>
                                                        (
                                                            this Memory<TSource> source,
                                                            TAccumulate seed,
                                                            Func<TAccumulate, TSource, TAccumulate> func,
                                                            Func<TAccumulate, TResult> resultSelector
                                                        )
        {
            TAccumulate accumulator = seed;

            int n = source.Length;

            for(int i = 0; i < n; i++)
            {
                TSource element = source.Span[i];
                accumulator = func(accumulator, element);
            }

            //foreach (TSource element in source)
            //{
            //    accumulator = func(accumulator, element);
            //}

            return resultSelector(accumulator);
        }
        #endregion

        #region Count
        public static int Count<TSource>(this Memory<TSource> source)
        {
            // Optimisation
            //IList list = source as IList;
            //if (list != null)
            //{
            //    return list.Count;
            //}
            //int count = 0;
            //foreach (TSource element in source)
            //{
            //    count++;
            //}
            return source.Length;
        }
        #endregion

        #region First/FirstOrDefault
        public static TSource First<TSource>(this Memory<TSource> source)
        {
            //foreach (TSource element in source)
            //{
            //    return element;
            //}
            if (source.Length == 0)
            {
                throw new System.InvalidOperationException("Empty sequence");
            }

            return source.Span[0];
        }

        public static TSource FirstOrDefault<TSource>(this Memory<TSource> source)
        {
            //foreach (TSource element in source)
            //{
            //    return element;
            //}
            if (source.Length == 0)
            {
                return default(TSource);
            }

            return source.Span[0];

            //return default(TSource);
        }
        #endregion

        #region ToArray
        public static TSource[] ToArray<TSource>(this Memory<TSource> source)
        {
            return source.ToArray();
            //return source.ToList().ToArray();
        }
        #endregion
    }
}
