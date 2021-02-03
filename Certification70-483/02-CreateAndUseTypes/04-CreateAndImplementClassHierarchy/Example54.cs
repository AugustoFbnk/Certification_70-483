using System;
using System.Collections.Generic;

namespace Certification70_483._02_CreateAndUseTypes._04_CreateAndImplementClassHierarchy
{
    /// <summary>
    /// Implementing the IComparable interface
    /// </summary>
    public static class Example54
    {
        public static void Start()
        {
            List<SortedOrder> orders = new List<SortedOrder>
            {
                new SortedOrder { Created = new DateTime(2012, 12, 1 )},
                new SortedOrder { Created = new DateTime(2012, 1, 6 )},
                new SortedOrder { Created = new DateTime(2012, 7, 8 )},
                new SortedOrder { Created = new DateTime(2012, 2, 20 )},
            };
            orders.Sort();
        }
    }

    class SortedOrder : IComparable
    {
        public DateTime Created { get; set; }
        public int CompareTo(object obj)
        {
            if (obj == null) return 1;
            SortedOrder o = obj as SortedOrder;
            if (o == null)
            {
                throw new ArgumentException("Object is not an SortedOrder");
            }
            return this.Created.CompareTo(o.Created);
        }
    }

}
