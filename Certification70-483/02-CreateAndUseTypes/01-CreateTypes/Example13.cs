using System;

namespace Certification70_483._02_CreateAndUseTypes._01_CreateTypes
{
    /// <summary>
    /// Generic Nullable<T> implementation (Simplified)
    /// 
    /// Normally, a value type would need to be boxed to be used in a nongeneric collection. 
    /// By using generics, you can avoid the performance penalty for boxing and unboxing.
    /// </summary>
    public static class Example13
    {
        public static void Start()
        {
            var intNull = new Nullable<int>();

            if (intNull.HasValue)
            {
                Console.WriteLine("Not null");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Is null");
                Console.ReadLine();
            }
        }

    }

    struct Nullable<T> where T : struct
    {
        private bool hasValue;
        private T value;
        public Nullable(T value)
        {
            this.hasValue = true;
            this.value = value;
        }
        public bool HasValue { get { return this.hasValue; } }
        public T Value
        {
            get
            {
                if (!this.HasValue) throw new ArgumentException();
                return this.value;
            }
        }
        public T GetValueOrDefault()
        {
            return this.value;
        }
    }
}
