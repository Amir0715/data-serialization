using System.Xml.Serialization;

namespace data_serialization.Models
{
    public class BodyInstance
    {
        [XmlAttribute]
        public string Id { get; set; }
        
        [XmlAttribute]
        public string Name { get; set; }
        
        [XmlAttribute]
        public string Behaviour { get; set; }
        
        [XmlAttribute]
        public string BodyRef { get; set; }
        
        [XmlElement(ElementName = "Transformation", IsNullable = true)]
        public Transformation Transformation { get; set; }
    }
}