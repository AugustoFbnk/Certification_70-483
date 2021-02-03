using System;

namespace Certification70_483._02_CreateAndUseTypes._04_CreateAndImplementClassHierarchy
{
    /// <summary>
    /// IComparable interface    /// </summary>
    public static class Example53
    {
        public static void Start()
        {
            var comparable = new Comparable();
        }
    }

    public class Comparable : IComparable
    {
        public int CompareTo(object obj)
        {
            throw new NotImplementedException();
        }
    }
}
