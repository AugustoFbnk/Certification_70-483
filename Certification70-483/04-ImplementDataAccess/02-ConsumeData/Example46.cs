using System;
using System.Xml;
using System.Xml.XPath;

namespace Certification70_483._04_ImplementDataAccess._02_ConsumeData
{

    /// <summary>
    /// Using an XPath query
    /// </summary>
    public class Example46
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
            XPathNavigator nav = doc.CreateNavigator();
            string query = @"//people/person[@firstName=""jane""]";
            XPathNodeIterator iterator = nav.Select(query);//not working
            Console.WriteLine(iterator.Count);
            while (iterator.MoveNext())
            {
                string firstName = iterator.Current.GetAttribute("firstName", "");
                string lastName = iterator.Current.GetAttribute("lastName", "");
                Console.WriteLine("Name: {0} {1}", firstName, lastName);
            }
        }
    }
}
