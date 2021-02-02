using System;
using System.Data.Objects;

namespace Certification70_483._02_CreateAndUseTypes._03_EnforceEncapsulation
{
    /// <summary>
    /// The IObjectContextAdapter interface
    /// </summary>
    public static class Example38
    {
        public static void Start()
        {
            var implementation = new ImplementObjectContextAdapter();
        }
    }

    public class ImplementObjectContextAdapter : IObjectContextAdapter
    {
        public ObjectContext ObjectContext => throw new NotImplementedException();
    }

    public interface IObjectContextAdapter
    {
        ObjectContext ObjectContext { get; }
    }
}
