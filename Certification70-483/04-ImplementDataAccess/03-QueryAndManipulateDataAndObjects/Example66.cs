using Certification70_483._04_ImplementDataAccess._03_QueryAndManipulateDataAndObjects.common;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace Certification70_483._04_ImplementDataAccess._03_QueryAndManipulateDataAndObjects
{
    /// <summary>
    /// Using Where and OrderBy in a LINQ to XML query
    /// </summary>
    public class Example66
    {

        public static void Start()
        {
            var xml = new SampleXml().ReturnSampleXml();
            XDocument doc = XDocument.Parse(xml);
            IEnumerable<string> personNames = from p in doc.Descendants("person")
                                              where p.Descendants("phonenumber").Any()
                                              let name = (string)p.Attribute("firstname") + " " + (string)p.Attribute("lastname")
                                              orderby name
                                              select name;
        }
    }
}
