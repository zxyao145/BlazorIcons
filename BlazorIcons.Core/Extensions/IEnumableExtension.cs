using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorIcons.Extensions
{
    public static class EnumerableExtension
    {
        public static IList<T> AddIf<T>
            (this IList<T> data, bool predicate, T item)
        {
            if (predicate)
            {
                data.Add(item);
            }

            return data;
        }

        public static IList<T> AddIf<T, TInput>
            (this IList<T> data, bool predicate, 
            TInput item, Func<TInput,T> func)
        {  
            if (predicate)
            {
                data.Add(func.Invoke(item));
            }

            return data;
        }

    }
}
