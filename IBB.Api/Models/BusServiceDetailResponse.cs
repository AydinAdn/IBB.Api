using System.Xml.Serialization;

namespace IBB.Api.Models
{
    [XmlRoot(ElementName = "Table")]
    public class BusServiceDetailResponse
    {
        [XmlElement(ElementName = "HAT_KODU")]
        public string RouteId { get; set; }

        [XmlElement(ElementName = "HAT_ADI")]
        public string NameOfRoute { get; set; }

        [XmlElement(ElementName = "TAM_HAT_ADI")]
        public string FullNameOfRoute { get; set; }

        [XmlElement(ElementName = "HAT_DURUMU")]
        public string RouteStatus { get; set; }

        [XmlElement(ElementName = "BOLGE")]
        public string Area { get; set; }
    }
}