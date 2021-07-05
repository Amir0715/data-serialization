using System.Xml.Serialization;

namespace data_serialization.Models
{
    public class Attr
    {
        [XmlAttribute]
        public string Name { get; set; }
        
        [XmlAttribute]
        public string Type { get; set; }
        
        [XmlAttribute]
        public string Value { get; set; }
    }
}