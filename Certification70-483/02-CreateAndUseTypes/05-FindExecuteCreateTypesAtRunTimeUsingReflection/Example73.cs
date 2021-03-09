using System;
using System.Reflection;

namespace Certification70_483._02_CreateAndUseTypes._05_FindExecuteCreateTypesAtRunTimeUsingReflection
{
    /// <summary>
    /// Executing a method through reflection
    /// </summary>
    public class Example73
    {
        public static void Start()
        {
            int i = 42;
            //get information of CompareTo method (implemented into int type)) 
            //and call it passing value 42 as a parameter.
            MethodInfo compareToMethod = i.GetType().GetMethod("CompareTo",
                new Type[] { typeof(int) });
            int result = (int)compareToMethod.Invoke(i, new object[] { 41 });
        }
    }
}
