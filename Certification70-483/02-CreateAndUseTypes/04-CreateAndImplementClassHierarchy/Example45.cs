using System.Collections.Generic;
using System.Linq;

/// <summary>
/// Creating a base class
/// </summary>
namespace Certification70_483._02_CreateAndUseTypes._04_CreateAndImplementClassHierarchy
{
    public static class Example45
    {
        public static void Start()
        {
            //Example of implementation in the next example
        }

    }

    interface IEntityExample
    {
        int Id { get; }
    }
    class RepositoryExample<T> where T : IEntityExample
    {
        protected IEnumerable<T> _elements;
        public RepositoryExample(IEnumerable<T> elements)
        {
            _elements = elements;
        }
        public T FindById(int id)
        {
            return _elements.SingleOrDefault(e => e.Id == id);
        }
    }
}
