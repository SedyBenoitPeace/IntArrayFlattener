using System;
using System.Collections.Generic;
using System.Text;

namespace IntArrayFlattener.Extensions
{
    public static class ArrayExtensions
    {
        public static bool IsArrayOf<T>(this Type type)
        {
            return type == typeof(T[][]);
        }
    }
}
