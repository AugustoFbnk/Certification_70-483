using System;
using System.Dynamic;

namespace Certification70_483._02_CreateAndUseTypes.CreateTypes
{
    /// <summary>
    /// Creating a custom DynamicObject
    /// </summary>
    public static class Example29
    {
        public static void Start()
        {
            dynamic obj = new SampleObject();
            Console.WriteLine(obj.SomeProperty); // Displays ‘SomeProperty’
        }

        public class SampleObject : DynamicObject
        {
            public override bool TryGetMember(GetMemberBinder binder, out object result)
            {
                result = binder.Name;
                return true;
            }
        }
    }
}
