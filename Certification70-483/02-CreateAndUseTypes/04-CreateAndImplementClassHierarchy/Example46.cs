using System.Collections.Generic;
using System.Linq;

namespace Certification70_483._02_CreateAndUseTypes._04_CreateAndImplementClassHierarchy
{
    /// <summary>
    /// Inheriting from a base class
    /// </summary>
    public static class Example46
    {
        public static void Start()
        {
            var ordersMock = new List<Order>();
            var repository = new OrderRepository(ordersMock);
            repository.FindById(1);
            repository.FilterOrdersOnAmount(10.5m);
        }
    }

    interface IEntity
    {
        int Id { get; }
    }
    class Repository<T> where T : IEntity
    {
        protected IEnumerable<T> _elements;
        public Repository(IEnumerable<T> elements)
        {
            _elements = elements;
        }
        public T FindById(int id)
        {
            return _elements.SingleOrDefault(e => e.Id == id);
        }
    }

    class Order : IEntity
    {
        public int Id { get; }
        // Other implementation details omitted
        // …
    }
    class OrderRepository : Repository<Order>
    {
        public OrderRepository(IEnumerable<Order> orders)
        : base(orders) { }
        public IEnumerable<Order> FilterOrdersOnAmount(decimal amount)
        {
            List<Order> result = null;
            // Some filtering code
            return result;
        }
    }
}
