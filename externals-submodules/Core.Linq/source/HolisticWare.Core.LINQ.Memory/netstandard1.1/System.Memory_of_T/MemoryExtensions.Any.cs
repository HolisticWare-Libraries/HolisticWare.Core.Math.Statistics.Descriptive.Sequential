using System;
using System.Collections;
using System.Collections.Generic;

namespace Core.LINQ.Memory
{
    public static partial class MemoryExtensions
    {
        /// <summary>
        /// Determines whether a sequence contains any elements.
        /// </summary>
        /// <typeparam name="TSource"></typeparam>
        /// <param name="source"></param>
        /// <returns></returns>
        /// https://docs.microsoft.com/en-us/dotnet/api/system.linq.enumerable.any?view=netcore-3.1
        /// https://github.com/microsoft/referencesource/blob/master/System.Core/System/Linq/Enumerable.cs#L1288-L1294
        public static bool Any<TSource>(this System.Memory<TSource> source)
        {
            return source.Length > 0;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TSource"></typeparam>
        /// <param name="source"></param>
        /// <returns></returns>
        ///
        /// 
        public static bool Any<TSource>(this System.Memory<TSource> source, Func<TSource, bool> predicate)
        {
            if (predicate == null) throw new ArgumentNullException("predicate");
            for (int i = 0; i <= source.Length; i++)
            {
                if (predicate(source.Span[i])) return true;
            }

            return false;
        }
    }
}
