using System.Text;

namespace Certification70_483._02_CreateAndUseTypes._07_ManipulateStrings
{
    /// <summary>
    /// Using a StringBuilder in a loop
    /// </summary>
    public class Example88
    {

        public static void Start()
        {
            StringBuilder sb = new StringBuilder(string.Empty);
            for (int i = 0; i < 10000; i++)
            {
                sb.Append("x");
            }
        }
    }
}
