namespace Certification70_483._02_CreateAndUseTypes._03_EnforceEncapsulation
{
    /// <summary>
    /// Changing a private field without outside users noticing
    /// </summary>
    public static class Example33
    {
        public static void Start()
        {
            var accessibility = new Accessibility2();
            var myProperty = accessibility.MyProperty;
        }
    }

    public class Accessibility2
    {
        // initialization code and error checking omitted
        private string[] _myField;
        public string MyProperty
        {
            get { return _myField[0]; }
            set { _myField[0] = value; }
        }
    }
}
