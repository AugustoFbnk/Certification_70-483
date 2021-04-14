using System.Data.Entity;

namespace Certification70_483._03_DebugApplicationsAndImplementSecurity._01_ValidateApplicationInput.common
{
    public class ShopContext : DbContext
    {
        public IDbSet<Customer> Customers { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // Make sure the database knows how to handle the duplicate address property
            modelBuilder.Entity<Customer>().HasRequired(bm => bm.BillingAddress)
                .WithMany().WillCascadeOnDelete(false);
        }
    }
}
