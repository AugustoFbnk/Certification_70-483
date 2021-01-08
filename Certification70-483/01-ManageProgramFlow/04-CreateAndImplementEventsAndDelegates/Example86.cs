using System;

namespace Certification70_483._01_ManageProgramFlow._04_CreateAndImplementEventsAndDelegates
{
    /// <summary>
    /// Exception when raising an event
    /// Won't call the third subscriber because an exception is throwed first
    /// </summary>
    public static class Example86
    {
        public static void Start()
        {
            CreateAndRaise();
        }
        public static void CreateAndRaise()
        {
            Pub5 p = new Pub5();
            p.OnChange += (sender, e)
                => Console.WriteLine("Subscriber 1 called");
            p.OnChange += (sender, e)
                =>
            { throw new Exception(); };
            p.OnChange += (sender, e)
                => Console.WriteLine("Subscriber 3 called");
            p.Raise();
        }
    }

    public class Pub5
    {
        public event EventHandler OnChange = delegate { };
        public void Raise()
        {
            OnChange(this, EventArgs.Empty);
        }
    }
}
