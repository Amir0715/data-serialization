using System.Xml.Serialization;

namespace data_serialization.Models
{
    public class Body
    {
        [XmlAttribute]
        public string Id { get; set; }
        
        [XmlAttribute]
        public string Name { get; set; }
        
        [XmlAttribute]
        public string Behaviour { get; set; }
    }
}