using System;
using System.IO;
using System.Xml;

namespace Certification70_483._04_ImplementDataAccess._02_ConsumeData
{
    /// <summary>
    /// Creating an XML file with XmlWriter
    /// </summary>
    public class Example44
    {

        public static void Start()
        {
            StringWriter stream = new StringWriter();
            using (XmlWriter writer = XmlWriter.Create(
                stream,
                new XmlWriterSettings() { Indent = true }))
            {
                writer.WriteStartDocument();
                writer.WriteStartElement("People");
                writer.WriteStartElement("Person");
                writer.WriteAttributeString("firstName", "John");
                writer.WriteAttributeString("lastName", "Doe");
                writer.WriteStartElement("ContactDetails");
                writer.WriteElementString("EmailAddress", "john@unknown.com");
                writer.WriteEndElement();
                writer.WriteEndElement();
                writer.Flush();
            }
            Console.WriteLine(stream.ToString());
        }
    }
}
