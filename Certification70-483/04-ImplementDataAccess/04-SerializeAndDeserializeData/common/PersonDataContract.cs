using System.Runtime.Serialization;

namespace Certification70_483._04_ImplementDataAccess._04_SerializeAndDeserializeData.common
{
    [DataContract]
    public class PersonDataContract
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string Name { get; set; }
        private bool isDirty = false;
    }
}
