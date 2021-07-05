using System.Xml.Serialization;

namespace data_serialization.Models
{
    public class ColorTable
    {
        [XmlAttribute(AttributeName = "size")]
        public string Size { get; set; }
        
        [XmlAttribute(AttributeName = "data")]
        public string Data { get; set; }
    }
}