using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Xml.Serialization;

namespace data_serialization.Models
{
    /// <summary>
    /// Объект сериализации корня xml-документа
    /// </summary>
    [Serializable]
    [XmlRoot(ElementName = "Root")]
    public class Root
    {

        [JsonIgnore]
        [XmlElement(ElementName = "GlobalData")]
        public GlobalData GlobalData { get; set; }
        
        [JsonPropertyName("products")]
        [XmlArray]
        public List<ProductOccurence> ModelFile { get; set; }
    }
}