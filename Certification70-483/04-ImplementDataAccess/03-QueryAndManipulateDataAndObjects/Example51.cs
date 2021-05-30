using System;

namespace Certification70_483._04_ImplementDataAccess._03_QueryAndManipulateDataAndObjects
{
    /// <summary>
    ///  Using an anonymous method
    /// </summary>
    public class Example51
    {

        public static void Start()
        {
            Func<int, int> myDelegate =
                delegate (int x)
                {
                    return x * 2;
                };
            Console.WriteLine(myDelegate(21)); // Displays 42

            //using lambda:
            Func<int, int> myDelegateLambda = x => x * 2;
            Console.WriteLine(myDelegateLambda(21)); // Displays 42
        }
    }
}
