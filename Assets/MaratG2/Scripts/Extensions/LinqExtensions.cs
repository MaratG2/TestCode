using System;
using System.Collections;
namespace MaratG2.Extensions
{
    public static class LinqExtensions
    {
        public static void ForEach(this IEnumerable enumerable, Action<object> action)
        {
            foreach (var num in enumerable)
                action?.Invoke(num);
        }
    }
}