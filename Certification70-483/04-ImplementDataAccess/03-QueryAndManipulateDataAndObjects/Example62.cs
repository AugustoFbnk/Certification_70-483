using Certification70_483._04_ImplementDataAccess._03_QueryAndManipulateDataAndObjects.common;
using System.Collections.Generic;
using System.Linq;

namespace Certification70_483._04_ImplementDataAccess._03_QueryAndManipulateDataAndObjects
{
    /// <summary>
    /// Using Skip and Take to implement paging
    /// </summary>
    public class Example62
    {

        public static void Start()
        {
            var productA = new Product();
            var productB = new Product();
            var productC = new Product();

            var orderLines = new List<OrderLine>();
            var orders = new List<Order>
            {
                new Order
                {
                    OrderLines = new List<OrderLine>
                    {
                        new OrderLine
                        {
                            Amount = 10,
                            Product = productA

                        },
                        new OrderLine
                        {
                            Amount = 1,
                            Product = productB

                        },
                        new OrderLine
                        {
                            Amount = 15,
                            Product = productC

                        },
                    }
                },
                new Order
                {
                    OrderLines = new List<OrderLine>
                    {
                        new OrderLine
                        {
                            Amount = 20,
                            Product = productA

                        },
                        new OrderLine
                        {
                            Amount = 2,
                            Product = productB

                        },
                        new OrderLine
                        {
                            Amount = 30,
                            Product = productC

                        },
                    }
                },
                new Order
                {
                    OrderLines = new List<OrderLine>
                    {
                        new OrderLine
                        {
                            Amount = 25,
                            Product = productA

                        },
                        new OrderLine
                        {
                            Amount = 5,
                            Product = productB

                        },
                    }
                }

            };

            var pageIndex = 1;
            var pageSize = 1;

            var pagedOrders = orders
                .Skip((pageIndex - 1) * pageSize)
                .Take(pageSize);
        }
    }
}
