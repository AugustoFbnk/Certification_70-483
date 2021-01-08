using System;

namespace Certification70_483._01_ManageProgramFlow._04_CreateAndImplementEventsAndDelegates
{
    /// <summary>
    /// Custom event accessor
    /// </summary>
    public static class Example85
    {
        public static void Start()
        {
            Pub4 p = new Pub4();
            EventHandler<MyArgs2> act = (sender, e)
                => Console.WriteLine("Event raised: {0}", e.Value);
            p.OnChange += act;
            p.OnChange -= act;
            //it won't display nothing because the event are inserted and the removed
            p.Raise();
        }
    }

    public class Pub4
    {
        private event EventHandler<MyArgs2> onChange = delegate { };
        public event EventHandler<MyArgs2> OnChange
        {
            add
            {
                lock (onChange)
                {
                    onChange += value;
                }
            }
            remove
            {
                lock (onChange)
                {
                    onChange -= value;
                }
            }
        }
        public void Raise()
        {
            onChange(this, new MyArgs2(42));
        }
    }

    public class MyArgs2 : EventArgs
    {
        public MyArgs2(int value)
        {
            Value = value;
        }
        public int Value { get; set; }
    }
}
