using System;
using System.Collections.Generic;
using System.Linq;

namespace BSharp.Extensions
{
    static class LinqExtension
    {
        public static IEnumerable<TCast> Concat<TSource, TCast>(this IEnumerable<TSource> first, IEnumerable<TCast> second)
            where TCast : TSource
        {
            return Enumerable.Concat(first.Cast<TCast>(), second);
        }

        public static int IndexOf<TSource>(this IEnumerable<TSource> sources, TSource find)
        {
            return sources.IndexOf(e => Equals(find, e));
        }

        public static int IndexOf<TSource>(this IEnumerable<TSource> sources, Func<TSource, bool> selector)
        {
            if (selector == null)
                return -1;
            
            IEnumerator<TSource> enumerator = sources.GetEnumerator();

            for (int i = 0; enumerator.MoveNext(); i++)
            {
                if (selector.Invoke(enumerator.Current))
                    return i;
            }

            return -1;
        }
    }
}
