using Certification70_483._04_ImplementDataAccess._04_SerializeAndDeserializeData.common;
using System;
using System.IO;
using System.Runtime.Serialization.Json;

namespace Certification70_483._04_ImplementDataAccess._04_SerializeAndDeserializeData
{
    /// <summary>
    /// Using the DataContractJsonSerializer
    /// </summary>
    public class Example79
    {
        public static void Start()
        {
            var p = new PersonDataContract
            {
                Id = 1,
                Name = "John Doe"
            };
            using (MemoryStream stream = new MemoryStream())
            {
                DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(PersonDataContract));
                ser.WriteObject(stream, p);
                stream.Position = 0;
                StreamReader streamReader = new StreamReader(stream);
                Console.WriteLine(streamReader.ReadToEnd()); // Displays {"Id":1,"Name":"John Doe"}
                stream.Position = 0;
                var result = (PersonDataContract)ser.ReadObject(stream);
            }
        }
    }
}
