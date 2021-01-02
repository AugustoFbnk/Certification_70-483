using System;

namespace Certification70_483._01_ManageProgramFlow._02_ManageMultithreading
{
    /// <summary>
    /// A potential problem with multithreaded code
    /// The compiler sometimes changes the order of statements in your code. Normally, this
    /// wouldn’t be a problem in a single-threaded environment but some problems could 
    /// happen in a multithreaded environment.
    /// "Normally, if you would run Thread1 and Thread2, you would expect no output or an output of 5. 
    ///  It could be, however, that the compiler switches the two lines in Thread1. If Thread2
    ///  then executes, it could be that _flag has a value of 1 and _value has a value of 0."
    ///  
    /// ".NET Framework has an claas tha you can use to fix this problem: System.Threading.Volatile.
    ///  This class has a special Write and Read method, and methods disable the compiler optimizations 
    ///  so you can force the correct order in your code. 
    ///  Using these methods in the correct order can be quite complex, so.NET offers the
    ///  volatile keyword that you can apply to a field. You would then change the declaration of your
    ///  field to this: private static volatile int _flag = 0;
    /// </summary>
    public static class Example39
    {
        private static int _flag = 0;
        private static int _value = 0;
        public static void Thread1()
        {
            _value = 5;
            _flag = 1;
        }
        public static void Thread2()
        {
            if (_flag == 1)
                Console.WriteLine(_value);
        }

        public static void Start()
        {
            Thread1();
            Thread2();
            Console.ReadKey();
        }

    }
}
