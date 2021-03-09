using Xunit;

namespace Certification70_483._02_CreateAndUseTypes._05_FindExecuteCreateTypesAtRunTimeUsingReflection
{
    /// <summary>
    /// Using a category attribute in xUnit
    /// </summary>
    public static class Example63
    {
        public static void Start()
        {
            var test = new TestClass();
            test.MyUnitTest();
            test.MyIntegrationTest();
        }
    }

    public class TestClass
    {
        [Fact]
        [Trait("Category", "Unit Test")]
        public void MyUnitTest()
        { }
        [Fact]
        [Trait("Category", "Integration Test")]
        public void MyIntegrationTest()
        { }
    }
}
