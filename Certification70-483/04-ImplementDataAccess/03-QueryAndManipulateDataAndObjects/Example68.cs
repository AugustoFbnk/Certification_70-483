using Certification70_483._04_ImplementDataAccess._03_QueryAndManipulateDataAndObjects.common;
using System.Linq;
using System.Xml.Linq;

namespace Certification70_483._04_ImplementDataAccess._03_QueryAndManipulateDataAndObjects
{
    /// <summary>
    /// Updating XML in a procedural way
    /// </summary>
    public class Example68
    {
        public static void Start()
        {
            var xml = new SampleXml().ReturnSampleXml();
            XElement root = XElement.Parse(xml);
            foreach (XElement p in root.Descendants("person"))
            {
                string name = (string)p.Attribute("firstname") + (string)p.Attribute("lastname");
                p.Add(new XAttribute("IsMale", name.Contains("john")));
                XElement contactDetails = p.Element("contactdetails");
                if (!contactDetails.Descendants("phonenumber").Any())
                {
                    contactDetails.Add(new XElement("phonenumber", "001122334455"));
                }
            }
        }
    }
}
