using Certification70_483._04_ImplementDataAccess._03_QueryAndManipulateDataAndObjects.common;
using System.Linq;
using System.Xml.Linq;

namespace Certification70_483._04_ImplementDataAccess._03_QueryAndManipulateDataAndObjects
{
    /// <summary>
    /// Transforming XML with functional creation
    /// </summary>
    public class Example69
    {
        public static void Start()
        {
            var xml = new SampleXml().ReturnSampleXml();
            XElement root = XElement.Parse(xml);
            XElement newTree = new XElement("people",
                from p in root.Descendants("person")
                let name = (string)p.Attribute("firstname") + (string)p.Attribute("lastname")
                let contactDetails = p.Element("contactdetails")
                select new XElement("person",
                    new XAttribute("IsMale", name.Contains("john")),
                    p.Attributes(),
                    new XElement("contactdetails",
                        contactDetails.Element("emailaddress"),
                        contactDetails.Element("phonenumber") ?? new XElement("phonenumber", "112233455"))));
        }
    }
}
