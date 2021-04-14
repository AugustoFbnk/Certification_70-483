using System.Collections.Generic;
using System.Web.Script.Serialization;

namespace Certification70_483._03_DebugApplicationsAndImplementSecurity._01_ValidateApplicationInput
{

    /// <summary>
    /// Deserializing an object with the JavaScriptSerializer
    /// </summary>
    public class Example13
    {
        public static void Start()
        {
            var json = @"
            {
               a: 123,
               b: 456

            }";
            DeserializeJson(json);
        }

        public static void DeserializeJson(string input)
        {
            var serializer = new JavaScriptSerializer();
            var result = serializer.Deserialize<Dictionary<string, object>>(input);
        }
    }
}
