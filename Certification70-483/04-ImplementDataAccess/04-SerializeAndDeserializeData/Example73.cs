using Certification70_483._04_ImplementDataAccess._04_SerializeAndDeserializeData.common;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace Certification70_483._04_ImplementDataAccess._04_SerializeAndDeserializeData
{
    /// <summary>
    /// Using binary serialization
    /// </summary>
    public class Example73
    {
        public static void Start()
        {

            Person p = new Person
            {
                Id = 1,
                FirstName = "John",
                LastName = "Doe"
            };
            IFormatter formatter = new BinaryFormatter();
            using (Stream stream = new FileStream("data.bin", FileMode.Create))
            {
                formatter.Serialize(stream, p);
            }
            using (Stream stream = new FileStream("data.bin", FileMode.Open))
            {
                Person dp = (Person)formatter.Deserialize(stream);
            }
        }
    }
}
