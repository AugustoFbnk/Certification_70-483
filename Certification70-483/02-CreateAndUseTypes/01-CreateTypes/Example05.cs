using Certification70_483._02_CreateAndUseTypes._01_CreateTypes.common;
    
namespace Certification70_483._02_CreateAndUseTypes._01_CreateTypes
{
    /// <summary>
    /// Passing a complete customer to a method
    /// </summary>
    public static class Example05
    {
        public static void Start()
        {
            var customer = new Customer
            {
                Address = new Address()
            };
            CalculateDistanceTo(customer);
        }
        public static Distance CalculateDistanceTo(Customer customer)
        {
            Distance result = new Distance();// Some difficult calculation that uses customer.Address
            return result;
        }
    }
}
