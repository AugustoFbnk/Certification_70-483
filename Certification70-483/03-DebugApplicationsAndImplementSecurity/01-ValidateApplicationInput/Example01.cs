using System.ComponentModel.DataAnnotations;

namespace Certification70_483._03_DebugApplicationsAndImplementSecurity._01_ValidateApplicationInput
{
    /// <summary>
    /// Customer and Address classes
    /// </summary>
    public class Example01
    {
        public static void Start()
        {
            //When saved in data base will throw an error because the FirstName is bigger than the MaxLength attribute and have some other requiser properties empty

            var custumer = new Customer
            {
                FirstName = "xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx"
            };
        }

        public class Customer
        {
            public int Id { get; set; }
            [Required, MaxLength(20)]
            public string FirstName { get; set; }
            [Required, MaxLength(20)]
            public string LastName { get; set; }
            [Required]
            public Address ShippingAddress { get; set; }
            [Required]
            public Address BillingAddress { get; set; }
        }
        public class Address
        {
            public int Id { get; set; }
            [Required, MaxLength(20)]
            public string AddressLine1 { get; set; }
            [Required, MaxLength(20)]
            public string AddressLine2 { get; set; }
            [Required, MaxLength(20)]
            public string City { get; set; }
            [RegularExpression(@"^[1-9][0-9]{3}\s?[a-zA-Z]{2}$")]
            public string ZipCode { get; set; }
        }
    }
}
