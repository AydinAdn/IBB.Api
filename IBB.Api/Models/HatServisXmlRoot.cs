using System.Collections.Generic;
using System.Xml.Serialization;

namespace IBB.Api.Models
{
    [XmlRoot(ElementName = "NewDataSet")]
    public class HatServisXmlRoot
    {
        [XmlElement(ElementName = "Table")]
        public List<BusServiceDetailResponse> BusServiceDetailResponse { get; set; }

        [XmlAttribute(AttributeName = "xmlns")]
        public string Xmlns { get; set; }
    }
}