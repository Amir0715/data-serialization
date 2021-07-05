using System.Xml.Serialization;

namespace data_serialization.Models
{
    public class Transformation
    {
        [XmlAttribute]
        public string RelativeTransfo { get; set; }
    }
}