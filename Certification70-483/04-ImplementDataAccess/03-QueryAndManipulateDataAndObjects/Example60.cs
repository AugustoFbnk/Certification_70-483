using Certification70_483._04_ImplementDataAccess._03_QueryAndManipulateDataAndObjects.common;
using System.Collections.Generic;
using System.Linq;

namespace Certification70_483._04_ImplementDataAccess._03_QueryAndManipulateDataAndObjects
{
    /// <summary>
    /// Using group by and projection
    /// </summary>
    public class Example60
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

            var result = from o in orders
                         from l in o.OrderLines
                         group l by l.Product into p
                         select new
                         {
                             Product = p.Key,
                             Amount = p.Sum(x => x.Amount)
                         };
        }
    }
}
