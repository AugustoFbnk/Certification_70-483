using System;

namespace Certification70_483._04_ImplementDataAccess._04_SerializeAndDeserializeData.common
{
    [Serializable]
    public class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        [NonSerialized]
        private bool isDirty = false;
    }
}
