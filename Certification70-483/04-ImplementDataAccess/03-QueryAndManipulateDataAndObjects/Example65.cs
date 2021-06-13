using Certification70_483._04_ImplementDataAccess._03_QueryAndManipulateDataAndObjects.common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace Certification70_483._04_ImplementDataAccess._03_QueryAndManipulateDataAndObjects
{
    /// <summary>
    /// Querying some XML by using LINQ to XML
    /// </summary>
    public class Example65
    {

        public static void Start()
        {
            var xml = new SampleXml().ReturnSampleXml();
            XDocument doc = XDocument.Parse(xml);
            IEnumerable<string> personNames = from p in doc.Descendants("person")
                                              select (string)p.Attribute("firstname") + " " + (string)p.Attribute("lastname");
            foreach (string s in personNames)
            {
                Console.WriteLine(s);
            }
            // Displays:
            // John Doe
            // Jane Doe
        }
    }
}
