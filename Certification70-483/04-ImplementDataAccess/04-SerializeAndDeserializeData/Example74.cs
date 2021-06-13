using Certification70_483._04_ImplementDataAccess._04_SerializeAndDeserializeData.common;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace Certification70_483._04_ImplementDataAccess._04_SerializeAndDeserializeData
{
    /// <summary>
    /// Using attributes to control serialization
    /// </summary>
    public class Example74
    {

        public static void Start()
        {
            Person p = new Person
            {
                Id = 2,
                FirstName = "Jane",
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
