using System.Xml.Serialization;

namespace data_serialization.Models
{
    public class Style
    {
        [XmlAttribute(AttributeName = "ColorIndex")]
        public string ColorIndex { get; set; }
        
        [XmlAttribute(AttributeName = "Transparency")]
        public string Transparency { get; set; }
        
        [XmlAttribute(AttributeName = "Width")]
        public string Width { get; set; }
    }
}