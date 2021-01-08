using System;
using System.Collections.Generic;
using System.Linq;

namespace Certification70_483._01_ManageProgramFlow._04_CreateAndImplementEventsAndDelegates
{
    /// <summary>
    /// Manually raising events with exception handling
    /// </summary>
    public class Example87
    {
        public static void Start()
        {
            CreateAndRaise();
        }

        public static void CreateAndRaise()
        {
            Pub6 p = new Pub6();
            p.OnChange += (sender, e)
                => Console.WriteLine("Subscriber 1 called");
            p.OnChange += (sender, e)
                =>
            { throw new Exception(); };
            p.OnChange += (sender, e)
                => Console.WriteLine("Subscriber 3 called");
            try
            {
                p.Raise();
            }
            catch (AggregateException ex)
            {
                Console.WriteLine(ex.InnerExceptions.Count);
            }
        }
    }

    public class Pub6
    {
        public event EventHandler OnChange = delegate { };
        public void Raise()
        {
            var exceptions = new List<Exception>();
            foreach (Delegate handler in OnChange.GetInvocationList())
            {
                try
                {
                    handler.DynamicInvoke(this, EventArgs.Empty);
                }
                catch (Exception ex)
                {
                    exceptions.Add(ex);
                }
            }
            if (exceptions.Any())
            {
                throw new AggregateException(exceptions);
            }
        }
    }
}
