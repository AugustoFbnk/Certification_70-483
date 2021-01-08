using System;

namespace Certification70_483._01_ManageProgramFlow._04_CreateAndImplementEventsAndDelegates
{
    /// <summary>
    /// Using an Action to expose an event
    /// </summary>
    public static class Example82
    {
        public static void CreateAndRaise()
        {
            Pub p = new Pub();
            p.OnChange += () => Console.WriteLine("Event raised to method 1");
            p.OnChange += () => Console.WriteLine("Event raised to method 2");
            p.Raise();
        }
        public static void Start()
        {
            CreateAndRaise();
        }
    }

    public class Pub
    {
        public Action OnChange { get; set; }
        public void Raise()
        {
            if (OnChange != null)
            {
                OnChange();
            }
        }
    }

}
