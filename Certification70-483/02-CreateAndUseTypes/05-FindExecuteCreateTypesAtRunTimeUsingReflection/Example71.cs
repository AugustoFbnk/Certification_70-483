using Certification70_483._02_CreateAndUseTypes._05_FindExecuteCreateTypesAtRunTimeUsingReflection.common.Interfaces;
using System;
using System.Linq;
using System.Reflection;

namespace Certification70_483._02_CreateAndUseTypes._05_FindExecuteCreateTypesAtRunTimeUsingReflection
{
    /// <summary>
    /// Inspecting an assembly for types that implement a custom interface
    /// </summary>
    public static class Example71
    {
        public static void Start()
        {
            Assembly pluginAssembly = Assembly.Load("Certification70-483");
            var plugins = from type in pluginAssembly.GetTypes()
                          where typeof(IPlugin).IsAssignableFrom(type) && !type.IsInterface
                          select type;

            foreach (Type pluginType in plugins)
            {
                IPlugin plugin = Activator.CreateInstance(pluginType) as IPlugin;
            }
        }
    }
}
