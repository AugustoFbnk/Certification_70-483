namespace Certification70_483._03_DebugApplicationsAndImplementSecurity._01_ValidateApplicationInput
{
    /// <summary>
    /// Seeing whether a string contains potential JSON data
    /// </summary>
    public class Example12
    {

        public static void Start()
        {
            var json = @"
            {
               a: 123,
               b: 456

            }";

            var isJson = IsJson(json);
        }

        public static bool IsJson(string input)
        {
            input = input.Trim();
            return input.StartsWith("{") && input.EndsWith("}")
           || input.StartsWith("[") && input.EndsWith("]");
        }
    }
}
