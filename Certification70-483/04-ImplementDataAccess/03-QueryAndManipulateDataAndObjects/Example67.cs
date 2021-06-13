using System.Collections.Generic;
using System.Xml.Linq;

namespace Certification70_483._04_ImplementDataAccess._03_QueryAndManipulateDataAndObjects
{
    /// <summary>
    /// Creating XML with the XElement class
    /// </summary>
    public class Example67
    {

        public static void Start()
        {
            XElement root = new XElement("Root",
            new List<XElement>
            {
                new XElement("Child1"),
                new XElement("Child2"),
                new XElement("Child3")
            },
            new XAttribute("MyAttribute", 42));
            root.Save("test.xml");

            //Outputs:
            //<Root MyAttribute="42">
            //    <Child1 /> 
            //    <Child2 /> 
            //    <Child3 /> 
            //</Root>
        }
    }
}
