namespace Certification70_483._02_CreateAndUseTypes._07_ManipulateStrings
{

    /// <summary>
    /// Creating a large number of strings
    /// </summary>
    public class Example86
    {

        public static void Start()
        {
            string s = string.Empty;
            for (int i = 0; i < 10000; i++)
            {
                s += "x";
            }
        }
    }
}
