using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MaratG2.Extensions
{
    public static class LinqExtensions
    {
        public static void ForEach(this IEnumerable enumerable, Action<object> action)
        {
            foreach (var num in enumerable)
            {
                action?.Invoke(num);
            }
        }
    }
}