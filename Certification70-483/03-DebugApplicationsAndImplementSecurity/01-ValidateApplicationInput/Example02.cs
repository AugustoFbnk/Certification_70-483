using Certification70_483._03_DebugApplicationsAndImplementSecurity._01_ValidateApplicationInput.common;

namespace Certification70_483._03_DebugApplicationsAndImplementSecurity._01_ValidateApplicationInput
{
    /// <summary>
    /// Saving a new customer to the database
    /// </summary>
    public class Example02
    {
        public static void Start()
        {
            using (ShopContext ctx = new ShopContext())
            {
                Address a = new Address
                {
                    AddressLine1 = "Somewhere 1",
                    AddressLine2 = "At some floor",
                    City = "SomeCity",
                    ZipCode = "1111AA"
                };
                Customer c = new Customer()
                {
                    FirstName = "John",
                    LastName = "Doe",
                    BillingAddress = a,
                    ShippingAddress = a,
                };
                ctx.Customers.Add(c);
                ctx.SaveChanges();
            }
        }
    }
}
