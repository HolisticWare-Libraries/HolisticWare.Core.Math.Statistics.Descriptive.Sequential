using System;
using System.Collections;
using System.Collections.Generic;

namespace Core.LINQ.Memory
{
    public static partial class MemoryExtensions
    {
        public static Memory<T> Empty<T>(this System.Memory<T> memory)
        {
            return Memory<T>.Empty;
        }

    }
}
