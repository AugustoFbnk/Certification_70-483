namespace Certification70_483._02_CreateAndUseTypes.CreateTypes
{
    /// <summary>
    /// Chaining constructors
    /// </summary>
    public static class Example12
    {
        public static void Start()
        {
            var constructorWithImplicitParameter = new ConstructorChaining();
            var constructorWithExplicitParameter = new ConstructorChaining(3);
        }
    }

    class ConstructorChaining
    {
        private int _p;
        public ConstructorChaining() : this(3) { }
        public ConstructorChaining(int p)
        {
            this._p = p;
        }
    }
}
