namespace Certification70_483._02_CreateAndUseTypes._04_CreateAndImplementClassHierarchy.common
{

    public class Square : Rectangle
    {
        public Square()
        {
        }

        public override int Width
        {
            get
            {
                return base.Width;
            }
            set
            {
                base.Width = value;
                base.Height = value;
            }
        }
        public override int Height
        {
            get
            {
                return base.Height;
            }
            set
            {
                base.Height = value;
                base.Width = value;
            }
        }
    }
}
