using Certification70_483._04_ImplementDataAccess._04_SerializeAndDeserializeData.common;
using System.IO;
using System.Runtime.Serialization;

namespace Certification70_483._04_ImplementDataAccess._04_SerializeAndDeserializeData
{
    /// <summary>
    /// Using the DataContractSerializer
    /// </summary>
    public class Example78
    {
        public static void Start()
        {
            PersonDataContract p = new PersonDataContract
            {
                Id = 1,
                Name = "John Doe"
            };
            using (Stream stream = new FileStream("data.xml", FileMode.Create))
            {
                DataContractSerializer ser = new DataContractSerializer(typeof(PersonDataContract));
                ser.WriteObject(stream, p);
            }
            using (Stream stream = new FileStream("data.xml", FileMode.Open))
            {
                DataContractSerializer ser = new DataContractSerializer(typeof(PersonDataContract));
                PersonDataContract result = (PersonDataContract)ser.ReadObject(stream);
            }
        }
    }
}
