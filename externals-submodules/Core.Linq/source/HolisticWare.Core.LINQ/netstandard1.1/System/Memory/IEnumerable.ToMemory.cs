using System;
using System.Collections.Generic;

namespace Core.Memory
{
    /// <summary>
    /// 
    /// </summary>
    /// 
    public static partial class IEnumerableExtensions
    {
        public static IEnumerable<T> ToEnumerable<T>(this Memory<T> memory)
        {
            for (int i = 0; i < memory.Length; i++)
            {
                yield return memory.Span[i];
            }
        }
    }
}
