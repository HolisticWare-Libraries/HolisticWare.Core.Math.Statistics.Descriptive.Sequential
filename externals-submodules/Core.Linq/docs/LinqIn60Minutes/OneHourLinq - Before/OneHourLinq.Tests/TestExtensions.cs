﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace OneHourLinq.Tests
{
    static class TestExtensions
    {
        /// <summary>
        /// Just to make our testing easier, all ourselves to use the real SequenceEquals
        /// call from LINQ to Obects.
        /// </summary>
        internal static void AssertSequenceEqual<T>(this IEnumerable<T> actual, IEnumerable<T> expected)
        {
            Assert.IsTrue(System.Linq.Enumerable.SequenceEqual(actual, expected));
        }

        /// <summary>
        /// Make testing even easier - a params array makes for readable tests :)
        /// </summary>
        internal static void AssertSequenceEqual<T>(this IEnumerable<T> actual, params T[] expected)
        {
            Assert.IsTrue(System.Linq.Enumerable.SequenceEqual(actual, expected), "Expected: " +
                ",".InsertBetween(expected.Select(x => Convert.ToString(x))) + "; was: " +
                ",".InsertBetween(actual.Select(x => Convert.ToString(x))));
        }

        internal static string InsertBetween(this string delimiter, IEnumerable<string> items)
        {
            StringBuilder builder = new StringBuilder();
            foreach (string item in items)
            {
                if (builder.Length != 0)
                {
                    builder.Append(delimiter);
                }
                builder.Append(item);
            }
            return builder.ToString();
        }
    }
}
