using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Xml.Serialization;

namespace data_serialization.Models
{
    public class ProductOccurence
    {
        [XmlAttribute]
        public string Id { get; set; }
        
        [XmlAttribute]
        public string Name { get; set; }
        
        [JsonIgnore]
        [XmlAttribute]
        public string Behaviour { get; set; }
        
        [JsonIgnore]
        [XmlAttribute]
        public string Children { get; set; }
        
        [JsonIgnore]
        [XmlAttribute]
        public string Unit { get; set; }
        
        [JsonIgnore]
        [XmlAttribute]
        public string IsPart { get; set; }
        
        [JsonIgnore]
        [XmlAttribute]
        public string Style { get; set; }
        
        [JsonIgnore]
        [XmlAttribute]
        public string FilePath { get; set; }
        
        [JsonIgnore]
        [XmlAttribute]
        public string InstanceRef { get; set; }
        
        [XmlArray(ElementName = "Attributes", IsNullable = true)]
        [XmlArrayItem(ElementName = "Attr", IsNullable = true)]
        public List<Attr> Attrs { get; set; }
        
        [JsonIgnore]
        [XmlElement(IsNullable = true)]
        public Transformation Transformation { get; set; }
        
        [JsonIgnore]
        [XmlElement(ElementName = "BodyInstance", IsNullable = true)]
        public List<BodyInstance> BodyInstances { get; set; }
        
        [JsonIgnore]
        [XmlElement]
        public PartDefinition PartDefinition { get; set; }
    }
}