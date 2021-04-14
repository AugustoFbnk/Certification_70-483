using Certification70_483._03_DebugApplicationsAndImplementSecurity._01_ValidateApplicationInput.common;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Certification70_483._03_DebugApplicationsAndImplementSecurity._01_ValidateApplicationInput
{
    /// <summary>
    /// Running manual validation
    /// </summary>
    public class Example03
    {
        public static void Start()
        {
            var entity = new Customer
            {
                FirstName = "Test"
            };

            var validations = GenericValidator<Customer>.Validate(entity);
        }

        public static class GenericValidator<T>
        {
            public static IList<ValidationResult> Validate(T entity)
            {
                var results = new List<ValidationResult>();
                var context = new ValidationContext(entity, null, null);
                Validator.TryValidateObject(entity, context, results);
                return results;
            }
        }
    }
}
