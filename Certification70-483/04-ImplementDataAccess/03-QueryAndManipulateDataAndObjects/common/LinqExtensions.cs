using System;
using System.Collections.Generic;

namespace Certification70_483._04_ImplementDataAccess._03_QueryAndManipulateDataAndObjects.common
{
    public static class LinqExtensions
    {
        public static IEnumerable<TSource> CustonWhere<TSource>(
            this IEnumerable<TSource> source,
            Func<TSource, bool> predicate)
        {
            foreach (TSource item in source)
            {
                if (predicate(item))
                {
                    yield return item;
                }
            }
        }
    }
}
