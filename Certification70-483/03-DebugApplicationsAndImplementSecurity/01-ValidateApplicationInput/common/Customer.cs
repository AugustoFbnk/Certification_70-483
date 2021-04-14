using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Certification70_483._03_DebugApplicationsAndImplementSecurity._01_ValidateApplicationInput.common
{
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
}
