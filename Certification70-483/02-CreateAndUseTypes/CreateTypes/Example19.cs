using System;

namespace Certification70_483._02_CreateAndUseTypes.CreateTypes
{
    /// <summary>
    /// Boxing an integer value
    /// </summary>
    public static class Example19
    {
        public static void Start()
        {
            int i = 42;
            object o = i;
            int x = (int)o;
            Console.WriteLine(x);
        }
    }
}
