using Certification70_483._02_CreateAndUseTypes._01_CreateTypes.common;

namespace Certification70_483._02_CreateAndUseTypes._01_CreateTypes
{
    public static class Example06
    {
        /// <summary>
        /// Passing only an address to a method
        /// </summary>
        public static void Start()
        {
            var customer = new Customer
            {
                Address = new Address()
            };
            CalculateDistanceTo(customer.Address);
        }
        public static Distance CalculateDistanceTo(Address address)
        {
            Distance result = new Distance();// Some difficult calculation that uses address
            return result;
        }
    }
}
