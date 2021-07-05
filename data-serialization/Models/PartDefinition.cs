using System.Collections.Generic;
using System.Xml.Serialization;

namespace data_serialization.Models
{
    public class PartDefinition
    {
        [XmlAttribute]
        public string Id { get; set; }
        
        [XmlAttribute]
        public string Name { get; set; }
        
        [XmlElement(ElementName = "Body", IsNullable = true)]
        public List<Body> Bodies { get; set; }
    }
}