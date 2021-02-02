namespace Certification70_483._02_CreateAndUseTypes._03_EnforceEncapsulation
{
    /// <summary>
    /// Implementing an interface explicitly 2
    /// </summary>
    public static class Example40
    {
        public static void Start()
        {
            var obj = new MoveableOject();
            ((ILeft)obj).Move();
            ((IRight)obj).Move();
        }
    }

    interface ILeft
    {
        void Move();
    }
    interface IRight
    {
        void Move();
    }
    class MoveableOject : ILeft, IRight
    {
        void ILeft.Move() { }
        void IRight.Move() { }
    }
}
