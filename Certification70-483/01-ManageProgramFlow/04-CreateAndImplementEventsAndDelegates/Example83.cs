using System;

namespace Certification70_483._01_ManageProgramFlow._04_CreateAndImplementEventsAndDelegates
{
    /// <summary>
    /// Using the event keyword
    /// "By using the event syntax, there are a couple of interesting changes. 
    ///  - First, you are no longer using a public property but a public field. Normally, this would be a step back.
    ///  However, with the event syntax, the compiler protects your field from unwanted access.
    ///  - An event cannot be directly assigned to (with the = instead of +=) operator. 
    ///  So you don’t have the risk of someone removing all previous subscriptions, as with the delegate syntax.
    ///  - Another change is that no outside users can raise your event. It can be raised only by code that’s part of the class that defined the event."
    /// </summary>
    public static class Example83
    {
        public static void Start()
        {
            Pub2 p = new Pub2();
            p.OnChange += () => Console.WriteLine("Event raised to method 1");
            p.OnChange += () => Console.WriteLine("Event raised to method 2");
            p.Raise();
        }

    }
    public class Pub2
    {
        public event Action OnChange = delegate { };
        public void Raise()
        {
            OnChange();
        }
    }
}
