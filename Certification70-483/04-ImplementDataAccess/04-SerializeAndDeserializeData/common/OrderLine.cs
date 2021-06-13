using System;
using System.Xml.Serialization;

namespace Certification70_483._04_ImplementDataAccess._04_SerializeAndDeserializeData.common
{
    [Serializable]
    public class OrderLine
    {
        [XmlAttribute]
        public int ID { get; set; }
        [XmlAttribute]
        public int Amount { get; set; }
        [XmlElement("OrderedProduct")]
        public Product Product { get; set; }
    }
}
