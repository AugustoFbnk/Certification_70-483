using Certification70_483._02_CreateAndUseTypes.CreateTypes.common;

namespace Certification70_483._02_CreateAndUseTypes.CreateTypes
{
    /// <summary>
    /// Creating an extension method
    /// </summary>
    public static class Example16
    {
        public static void Start()
        {
            var product = new Product();
            product.Price = 10;

            var calculator = new Calculator();
            calculator.CalculateDiscount(product);
        }
    }
}
