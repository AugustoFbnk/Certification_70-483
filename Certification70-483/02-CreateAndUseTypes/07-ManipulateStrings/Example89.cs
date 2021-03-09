using System.IO;
using System.Xml;

namespace Certification70_483._02_CreateAndUseTypes._07_ManipulateStrings
{

    /// <summary>
    /// Using a StringWriter as the output for an XmlWriter
    /// </summary>
    public class Example89
    {
        public static void Start()
        {
            var stringWriter = new StringWriter();
            using (XmlWriter writer = XmlWriter.Create(stringWriter))
            {
                writer.WriteStartElement("book");
                writer.WriteElementString("price", "19.95");
                writer.WriteEndElement();
                writer.Flush();
            }
            string xml = stringWriter.ToString();
        }
    }
}
