using Certification70_483._02_CreateAndUseTypes._05_FindExecuteCreateTypesAtRunTimeUsingReflection.common;
using Certification70_483._02_CreateAndUseTypes._05_FindExecuteCreateTypesAtRunTimeUsingReflection.common.Interfaces;

namespace Certification70_483._02_CreateAndUseTypes._05_FindExecuteCreateTypesAtRunTimeUsingReflection
{
    /// <summary>
    /// Creating a custom plug-in class
    /// </summary>
    public static class Example70
    {
        public static void Start()
        {
            IPlugin myPlugin = new MyPlugin();
        }
    }
}
