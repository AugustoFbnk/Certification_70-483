namespace Certification70_483._02_CreateAndUseTypes._03_EnforceEncapsulation
{
    /// <summary>
    /// Using access modifiers
    /// </summary>
    public static class Example31
    {
        public static void Start()
        {
            var dog = new Dog();
            dog.Bark();
        }
    }

    public class Dog
    {
        public void Bark() { }
    }
}
