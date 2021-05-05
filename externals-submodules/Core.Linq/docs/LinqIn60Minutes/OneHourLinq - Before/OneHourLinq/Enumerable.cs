using System;
using System.Collections.Generic;
using OneHour.Linq.Util;

namespace OneHour.Linq
{
    public static class Enumerable
    {
        #region Select
        //public static IEnumerable<TResult> Select<TSource, TResult>(this IEnumerable<TSource> source,
        //                                                           Func<TSource, TResult> projection)
        //{
        //    return null;
        //}

        //private static IEnumerable<TResult> SelectImpl<TSource, TResult>(this IEnumerable<TSource> source,
        //                                                                 Func<TSource, TResult> projection)
        //{
        //    return null;
        //}
        #endregion

        #region Where
        //public static IEnumerable<TSource> Where<TSource>(this IEnumerable<TSource> source,
        //                                                  Func<TSource, bool> predicate)
        //{
        //    return null;
        //}
        #endregion

        #region SelectMany
        //public static IEnumerable<TResult> SelectMany<TSource, TSubsequence, TResult>
        //    (this IEnumerable<TSource> source,
        //     Func<TSource, IEnumerable<TSubsequence>> selector,
        //     Func<TSource, TSubsequence, TResult> resultSelector)
        //{
        //    return null;
        //}                            
        #endregion

        #region ToLookup
        //public static ILookup<TKey, TSource> ToLookup<TSource, TKey>
        //    (this IEnumerable<TSource> source, Func<TSource, TKey> keySelector)
        //{
        //    return null;
        //}

        //public static ILookup<TKey, TElement> ToLookup<TSource, TKey, TElement>
        //    (this IEnumerable<TSource> source, Func<TSource, TKey> keySelector, Func<TSource, TElement> elementSelector)
        //{
        //    return null;
        //}
        #endregion

        #region Empty
        //public static IEnumerable<T> Empty<T>()
        //{
        //    return null;
        //}
        #endregion

        #region GroupJoin
        //public static IEnumerable<TResult> GroupJoin<TOuter, TInner, TKey, TResult>
        //    (this IEnumerable<TOuter> outer,
        //     IEnumerable<TInner> inner,
        //     Func<TOuter, TKey> outerKeySelector,
        //     Func<TInner, TKey> innerKeySelector,
        //     Func<TOuter, IEnumerable<TInner>, TResult> resultSelector)
        //{
        //    return null;
        //}
        #endregion

        #region Join
        //public static IEnumerable<TResult> Join<TOuter, TInner, TKey, TResult>
        //    (this IEnumerable<TOuter> outer,
        //     IEnumerable<TInner> inner,
        //     Func<TOuter, TKey> outerKeySelector,
        //     Func<TInner, TKey> innerKeySelector,
        //     Func<TOuter, TInner, TResult> resultSelector)
        //{
        //    return null;
        //}
        #endregion

        #region GroupBy
        //public static IEnumerable<IGrouping<TKey, TSource>> GroupBy<TSource, TKey>
        //    (this IEnumerable<TSource> source,
        //     Func<TSource, TKey> keySelector)
        //{
        //    return null;
        //}

        //public static IEnumerable<IGrouping<TKey, TElement>> GroupBy<TSource, TKey, TElement>
        //    (this IEnumerable<TSource> source,
        //     Func<TSource, TKey> keySelector,
        //     Func<TSource, TElement> elementSelector)
        //{
        //    return null;
        //}
        #endregion

        #region OrderBy/OrderByDescending
        //public static IOrderedEnumerable<TSource> OrderBy<TSource, TKey>
        //    (this IEnumerable<TSource> source, Func<TSource, TKey> keySelector)
        //{
        //    return null;
        //}

        //public static IOrderedEnumerable<TSource> OrderByDescending<TSource, TKey>
        //    (this IEnumerable<TSource> source, Func<TSource, TKey> keySelector)
        //{
        //    return null;
        //}
        #endregion

        #region SequenceEqual
        //public static bool SequenceEqual<TSource>(this IEnumerable<TSource> first,
        //                                          IEnumerable<TSource> second)
        //{
        //    return null;
        //}
        #endregion

        #region Aggregate
        //public static TResult Aggregate<TSource, TAccumulate, TResult>(this IEnumerable<TSource> source,
        //    TAccumulate seed, Func<TAccumulate, TSource, TAccumulate> func, Func<TAccumulate, TResult> resultSelector)
        //{
        //    return null;
        //}
        #endregion

        #region Count
        //public static int Count<TSource>(this IEnumerable<TSource> source)
        //{
        //    return null;
        //}
        #endregion

        #region First/FirstOrDefault
        //public static TSource First<TSource>(this IEnumerable<TSource> source)
        //{
        //    return null;
        //}

        //public static TSource FirstOrDefault<TSource>(this IEnumerable<TSource> source)
        //{
        //    return null;
        //}
        #endregion

        #region ToArray
        //public static TSource[] ToArray<TSource>(this IEnumerable<TSource> source)
        //{
        //    return null;
        //}
        #endregion

        #region ToList
        //public static List<TSource> ToList<TSource>(this IEnumerable<TSource> source)
        //{
        //    return null;
        //}
        #endregion
    }
}
