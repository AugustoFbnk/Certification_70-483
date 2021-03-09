using System.Globalization;
using System.IO;
using System.Xml;

namespace Certification70_483._02_CreateAndUseTypes._07_ManipulateStrings
{

    /// <summary>
    /// Using a StringReader as the input for an XmlReader
    /// </summary>
    public class Example90
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

            var stringReader = new StringReader(xml);
            using (XmlReader reader = XmlReader.Create(stringReader))
            {
                reader.ReadToFollowing("price");
                decimal price = decimal.Parse(reader.ReadInnerXml(), new CultureInfo("en-US")); // Make sure that you read the decimal part correctly
            }
        }
    }
}
