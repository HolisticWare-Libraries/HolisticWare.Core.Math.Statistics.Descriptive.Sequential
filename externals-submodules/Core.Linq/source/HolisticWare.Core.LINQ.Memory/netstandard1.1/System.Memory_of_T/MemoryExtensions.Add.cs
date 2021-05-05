using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Core.LINQ.Memory
{
    public static partial class MemoryExtensions
    {
        public static Memory<T> Add<T>(this System.Memory<T> memory, T item)
        {
            return memory.ToArray().Concat(new T[] { item }).ToArray().AsMemory();
        }

    }
}
