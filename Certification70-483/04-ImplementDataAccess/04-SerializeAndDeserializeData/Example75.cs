using Certification70_483._04_ImplementDataAccess._04_SerializeAndDeserializeData.common;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace Certification70_483._04_ImplementDataAccess._04_SerializeAndDeserializeData
{

    /// <summary>
    /// Influencing serialization and deserialization
    /// </summary>
    public class Example75
    {

        public static void Start()
        {
            var p = new PersonBinarySerialization
            {
                Id = 1,
                Name = "Jon Doe"
            };

            IFormatter formatter = new BinaryFormatter();
            using (Stream stream = new FileStream("data.bin", FileMode.Create))
            {
                formatter.Serialize(stream, p);
            }
            using (Stream stream = new FileStream("data.bin", FileMode.Open))
            {
                PersonBinarySerialization dp = (PersonBinarySerialization)formatter.Deserialize(stream);
            }
        }
    }
}
