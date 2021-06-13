using Certification70_483._04_ImplementDataAccess._03_QueryAndManipulateDataAndObjects.common;
using System.Collections.Generic;
using System.Linq;

namespace Certification70_483._04_ImplementDataAccess._03_QueryAndManipulateDataAndObjects
{
    /// <summary>
    /// Using join
    /// </summary>
    public class Example61
    {

        public static void Start()
        {
            var products = new List<Product>
            {
                new Product
                {
                    Description = "A",
                    Price = 10.0m
                },
                new Product
                {
                    Description = "B",
                    Price = 15.0m
                },
                new Product
                {
                    Description = "C",
                    Price = 30.0m
                },
            };

            string[] popularProductNames = { "A", "B" };
            var popularProducts = from p in products
                                  join n in popularProductNames on p.Description equals n
                                  select p;
        }
    }
}
