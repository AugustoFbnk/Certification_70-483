using Certification70_483._02_CreateAndUseTypes._05_FindExecuteCreateTypesAtRunTimeUsingReflection.common;
using Certification70_483._02_CreateAndUseTypes._05_FindExecuteCreateTypesAtRunTimeUsingReflection.common.Interfaces;
using System;

namespace Certification70_483._02_CreateAndUseTypes._05_FindExecuteCreateTypesAtRunTimeUsingReflection
{
    /// <summary>
    /// Creating an interface that can be found through reflection
    /// </summary>
    public static class Example69
    {
        public static void Start()
        {
            var plugin = new ExamplePlugin();
        }
    }

    public class ExamplePlugin : IPlugin
    {
        public string Name => throw new NotImplementedException();

        public string Description => throw new NotImplementedException();

        public bool Load(MyApplication application)
        {
            throw new NotImplementedException();
        }
    }
}
