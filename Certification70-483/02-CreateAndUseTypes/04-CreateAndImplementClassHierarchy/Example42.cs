namespace Certification70_483._02_CreateAndUseTypes._04_CreateAndImplementClassHierarchy
{
    /// <summary>
    /// Adding a set accessor to an implemented interface property
    /// </summary>
    public static class Example42
    {
        public static void Start()
        {
            var readAndWriteImplementation = new ReadAndWriteImplementation();
            var value = readAndWriteImplementation.Value;
        }
    }

    interface IReadOnlyInterface
    {
        int Value { get; }
    }
    struct ReadAndWriteImplementation : IReadOnlyInterface
    {
        public int Value { get; set; }
    }
}
