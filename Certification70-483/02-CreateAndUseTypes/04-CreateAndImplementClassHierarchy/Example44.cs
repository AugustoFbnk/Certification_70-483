namespace Certification70_483._02_CreateAndUseTypes._04_CreateAndImplementClassHierarchy
{
    /// <summary>
    /// Instantiating a concrete type that implements an interface
    /// </summary>
    public static class Example44
    {
        public static void Start()
        {
            IAnimal dog = new Dog();
            dog.Move();
        }
    }
    public interface IAnimal
    {
        void Move();
    }
    public class Dog : IAnimal
    {
        public void Move() { }
        public void Bark() { }
    }
}
