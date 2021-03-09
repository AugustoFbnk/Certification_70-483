using System;
using System.Collections.Generic;

namespace Certification70_483._02_CreateAndUseTypes._06_ManageTheObjectLifeCycle
{

    /// <summary>
    /// Using WeakReference
    /// </summary>
    public class Example85
    {
        static WeakReference data;
        public static void Start()
        {
            object result = GetData();
            // GC.Collect(); Uncommenting this line will make data.Target null
            result = GetData();
        }

        private static object GetData()
        {
            if (data == null)
            {
                data = new WeakReference(LoadLargeList());
            }
            if (data.Target == null)
            {
                data.Target = LoadLargeList();
            }
            return data.Target;
        }

        private static List<string> LoadLargeList()
        {
            return new List<string>();
        }
    }
}
