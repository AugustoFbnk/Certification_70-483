namespace Certification70_483._02_CreateAndUseTypes._03_EnforceEncapsulation
{
    /// <summary>
    /// Using the private access modifier
    /// </summary>
    public static class Example32
    {
        public static void Start()
        {
            var accessibility = new Accessibility();
            accessibility.MyProperty = "MyProperty";
        }
    }

    public class Accessibility
    {
        private string _myField;
        public string MyProperty
        {
            get { return _myField; }
            set { _myField = value; }
        }
    }
}
