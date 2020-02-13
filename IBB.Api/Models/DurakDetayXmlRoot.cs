using System.Collections.Generic;
using System.Xml.Serialization;

namespace IBB.Api.Models
{
    [XmlRoot(ElementName = "NewDataSet")]
    public class DurakDetayXmlRoot
    {
        [XmlElement(ElementName = "Table")]
        public List<DurakDetayResponse> Table { get; set; }

        [XmlAttribute(AttributeName = "xmlns")]
        public string Xmlns { get; set; }
    }
}