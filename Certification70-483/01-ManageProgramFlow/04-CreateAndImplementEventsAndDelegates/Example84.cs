using System;

namespace Certification70_483._01_ManageProgramFlow._04_CreateAndImplementEventsAndDelegates
{
    /// <summary>
    /// Custom event arguments
    /// </summary>
    public static class Example84
    {
        public static void CreateAndRaise()
        {
            Pub3 p = new Pub3();
            p.OnChange += (sender, e)
                => Console.WriteLine("Event raised: {0}", e.Value);
            p.Raise();
        }

        public static void Start()
        {
            CreateAndRaise();
        }
    }
    public class MyArgs : EventArgs
    {
        public MyArgs(int value)
        {
            Value = value;
        }
        public int Value { get; set; }
    }
    public class Pub3
    {
        public event EventHandler<MyArgs> OnChange = delegate { };
        public void Raise()
        {
            OnChange(this, new MyArgs(42));
        }
    }
}
