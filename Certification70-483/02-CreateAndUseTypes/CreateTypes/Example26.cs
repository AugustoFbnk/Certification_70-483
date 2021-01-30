using System;

namespace Certification70_483._02_CreateAndUseTypes.CreateTypes
{
    /// <summary>
    /// Using the built-in Convert and Parse methods
    /// </summary>
    public static class Example26
    {
        public static void Start()
        {
            int value = Convert.ToInt32("42");
            value = int.Parse("42");
            bool success = int.TryParse("42", out value);
        }
    }
}
