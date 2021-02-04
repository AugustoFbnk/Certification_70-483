using System;
using System.Collections.Generic;

namespace Certification70_483._02_CreateAndUseTypes._04_CreateAndImplementClassHierarchy
{
    /// <summary>
    /// Syntactic sugar of the foreach statement
    /// </summary>
    public static class Example55
    {
        public static void Start()
        {
            List<int> numbers = new List<int> { 1, 2, 3, 5, 7, 9 };
            using (List<int>.Enumerator enumerator = numbers.GetEnumerator())
            {
                while (enumerator.MoveNext()) Console.WriteLine(enumerator.Current);
            }
        }
    }
}
