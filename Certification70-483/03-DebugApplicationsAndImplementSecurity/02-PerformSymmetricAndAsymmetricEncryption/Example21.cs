using System.Collections.Generic;

namespace Certification70_483._03_DebugApplicationsAndImplementSecurity._02_PerformSymmetricAndAsymmetricEncryption
{
    /// <summary>
    /// A naïve set implementation
    /// </summary>
    public class Example21
    {
        public static void Start()
        {
            var intList = new Set<int>();
            intList.Insert(1);
            intList.Insert(2);
            intList.Insert(3);
            intList.Insert(1);           
        }

        class Set<T>
        {
            private List<T> list = new List<T>();
            public void Insert(T item)
            {
                if (!Contains(item))
                    list.Add(item);
            }
            public bool Contains(T item)
            {
                foreach (T member in list)
                    if (member.Equals(item))
                        return true;
                return false;
            }
        }
    }
}
