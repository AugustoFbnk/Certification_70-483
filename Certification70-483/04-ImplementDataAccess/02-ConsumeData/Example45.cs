using System;
using System.Xml;

namespace Certification70_483._04_ImplementDataAccess._02_ConsumeData
{

    /// <summary>
    /// Using XmlDocument
    /// </summary>
    public class Example45
    {

        public static void Start()
        {
            string xml = @"<?xml version=""1.0"" encoding=""utf-8"" ?>
                <people>
                  <person firstname=""john"" lastname=""doe"">
                    <contactdetails>
                      <emailaddress>john@unknown.com</emailaddress>
                    </contactdetails>
                  </person>
                  <person firstname=""jane"" lastname=""doe"">
                    <contactdetails>
                      <emailaddress>jane@unknown.com</emailaddress>
                      <phonenumber>001122334455</phonenumber>
                    </contactdetails>
                  </person>
                </people>";

            XmlDocument doc = new XmlDocument();
            doc.LoadXml(xml);
            XmlNodeList nodes = doc.GetElementsByTagName("Person");
            // Output the names of the people in the document
            foreach (XmlNode node in nodes)
            {
                string firstName = node.Attributes["firstName"].Value;
                string lastName = node.Attributes["lastName"].Value;
                Console.WriteLine("Name: {0} {1}", firstName, lastName);
            }
            // Start creating a new node
            XmlNode newNode = doc.CreateNode(XmlNodeType.Element, "Person", "");
            XmlAttribute firstNameAttribute = doc.CreateAttribute("firstName");
            firstNameAttribute.Value = "Foo";
            XmlAttribute lastNameAttribute = doc.CreateAttribute("lastName");
            lastNameAttribute.Value = "Bar";
            newNode.Attributes.Append(firstNameAttribute);
            newNode.Attributes.Append(lastNameAttribute);
            doc.DocumentElement.AppendChild(newNode);
            Console.WriteLine("Modified xml...");
            doc.Save(Console.Out);
            //Displays:
            //Name: john doe
            //Name: jane doe
            //Modified xml...
            //<?xml version="1.0" encoding="ibm850"?>
            //<people>
            // <person firstname="john" lastname="doe">
            // <contactdetails>
            // <emailaddress>john@unknown.com</emailaddress>
            // </contactdetails>
            // </person>
            // <person firstname="jane" lastname="doe">
            // <contactdetails>
            // <emailaddress>jane@unknown.com</emailaddress>
            // <phonenumber>001122334455</phonenumber>
            // </contactdetails>
            // </person>
            // <person firstname="Foo" lastname="Bar" />
            //</people> 
        }
    }
}
