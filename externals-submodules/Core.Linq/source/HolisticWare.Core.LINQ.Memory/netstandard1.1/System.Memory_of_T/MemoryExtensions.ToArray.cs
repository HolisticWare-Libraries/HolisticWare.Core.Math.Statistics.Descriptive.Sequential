using System;
using System.Linq;

namespace Core.LINQ.Memory
{
    public static partial class MemoryExtensions
    {
        public static TSource[] ToArray<TSource>(this System.Memory<TSource> source)
        {
            return source.ToEnumerable().ToArray();
        }
    }
}
