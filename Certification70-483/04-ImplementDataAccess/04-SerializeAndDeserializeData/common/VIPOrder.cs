using System;

namespace Certification70_483._04_ImplementDataAccess._04_SerializeAndDeserializeData.common
{
    [Serializable]
    public class VIPOrder : Order
    {
        public string Description { get; set; }
    }
}
