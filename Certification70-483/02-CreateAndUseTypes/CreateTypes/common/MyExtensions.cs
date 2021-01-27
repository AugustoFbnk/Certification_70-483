namespace Certification70_483._02_CreateAndUseTypes.CreateTypes.common
{
    public static class MyExtensions
    {
        public static decimal Discount(this Product product)
        {
            return product.Price * .9M;
        }
    }
}
