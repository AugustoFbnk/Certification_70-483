namespace Certification70_483._02_CreateAndUseTypes._04_CreateAndImplementClassHierarchy.common
{
    public class Rectangle
    {
        public Rectangle()
        {
        }
        public virtual int Height { get; set; }
        public virtual int Width { get; set; }
        public int Area
        {
            get
            {
                return Height * Width;
            }
        }
    }
}
