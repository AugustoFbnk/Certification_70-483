using Certification70_483._04_ImplementDataAccess._03_QueryAndManipulateDataAndObjects.common;

namespace Certification70_483._04_ImplementDataAccess._03_QueryAndManipulateDataAndObjects
{

    /// <summary>
    /// Using an object initializer
    /// </summary>
    public class Example49
    {

        public static void Start()
        {
            // Create and initialize a new object in one step
            Person p = new Person
            {
                FirstName = "John",
                LastName = "Doe"
            };
        }
    }
}
