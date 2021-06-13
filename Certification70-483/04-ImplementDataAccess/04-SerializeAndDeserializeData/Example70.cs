using Certification70_483._04_ImplementDataAccess._04_SerializeAndDeserializeData.common;
using System;
using System.IO;
using System.Xml.Serialization;

namespace Certification70_483._04_ImplementDataAccess._04_SerializeAndDeserializeData
{
    /// <summary>
    /// Serializing an object with the XmlSerializer
    /// </summary>
    public class Example70
    {
        public static void Start()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Person));
            string xml;
            using (StringWriter stringWriter = new StringWriter())
            {
                Person p = new Person
                {
                    FirstName = "John",
                    LastName = "Doe",
                    Age = 42
                };
                serializer.Serialize(stringWriter, p);
                xml = stringWriter.ToString();
            }
            Console.WriteLine(xml);
            using (StringReader stringReader = new StringReader(xml))
            {
                Person p = (Person)serializer.Deserialize(stringReader);
                Console.WriteLine("{0} {1} is {2} years old", p.FirstName, p.LastName, p.Age);
            }
        }
    }
}
