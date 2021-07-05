using System.Collections.Generic;
using System.Xml.Serialization;

namespace data_serialization.Models
{
    public class GlobalData
    {
        [XmlElement(ElementName = "ColorTable" ,IsNullable = true)]
        public ColorTable ColorTable { get; set; }
        
        [XmlElement(ElementName = "Style", IsNullable = true)]
        public List<Style> Styles { get; set; }
    }
}