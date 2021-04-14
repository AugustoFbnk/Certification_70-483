using System;
using System.Xml;
using System.Xml.Schema;

namespace Certification70_483._03_DebugApplicationsAndImplementSecurity._01_ValidateApplicationInput
{
    /// <summary>
    /// Validating an XML file with a schema
    /// </summary>
    public class Example16
    {
        public static void Start()
        {
            //will look in debug path
            string xsdPath = "person.xsd";
            string xmlPath = "person.xml";

            XmlReader reader = XmlReader.Create(xmlPath);
            XmlDocument document = new XmlDocument();
            document.Schemas.Add("", xsdPath);
            document.Load(reader);
            ValidationEventHandler eventHandler =
                new ValidationEventHandler(ValidationEventHandler);
            document.Validate(eventHandler);
        }

        static void ValidationEventHandler(object sender,
            ValidationEventArgs e)
        {
            switch (e.Severity)
            {
                case XmlSeverityType.Error:
                    Console.WriteLine("Error: {0}", e.Message);
                    break;
                case XmlSeverityType.Warning:
                    Console.WriteLine("Warning {0}", e.Message);
                    break;
            }
        }
    }
}
