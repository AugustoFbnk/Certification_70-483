namespace Certification70_483._02_CreateAndUseTypes._07_ManipulateStrings
{

    /// <summary>
    /// Changing a character with a StringBuilder
    /// </summary>
    public class Example87
    {

        public static void Start()
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder("A initial value");
            sb[0] = 'B';
        }
    }
}
