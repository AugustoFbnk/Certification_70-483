using Certification70_483._02_CreateAndUseTypes._05_FindExecuteCreateTypesAtRunTimeUsingReflection.common;
using Xunit;

namespace Certification70_483._02_CreateAndUseTypes._05_FindExecuteCreateTypesAtRunTimeUsingReflection
{
    /// <summary>
    /// Using a custom attribute
    /// </summary>
    public static class Example65
    {
        public static void Start()
        {
            var test = new Test2();
            test.MySecondUnitTest();
        }
    }

    public class Test2
    {
        [Fact]
        [UnitTest]
        public void MySecondUnitTest()
        { }
    }
}
