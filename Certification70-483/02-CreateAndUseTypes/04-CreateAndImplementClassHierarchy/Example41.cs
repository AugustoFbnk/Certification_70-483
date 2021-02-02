using System;

namespace Certification70_483._02_CreateAndUseTypes._04_CreateAndImplementClassHierarchy
{
    /// <summary>
    /// Creating and implementing an interface
    /// </summary>
    public static class Example41
    {
        public static void Start()
        {
            var example = new ExampleImplementation();
            var indexer = example[""];
        }
    }

    interface IExample
    {
        string GetResult();
        int Value { get; set; }
        event EventHandler ResultRetrieved;
        int this[string index] { get; set; }
    }
    class ExampleImplementation : IExample
    {
        public string GetResult()
        {
            return "result";
        }
        public int Value { get; set; }
        public event EventHandler CalculationPerformed;
        public event EventHandler ResultRetrieved;
        public int this[string index]
        {
            get
            {
                return 42;
            }
            set { }
        }
    }
}
