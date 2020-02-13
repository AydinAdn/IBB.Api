using System.Xml.Serialization;

namespace IBB.Api.Models
{
    [XmlRoot(ElementName = "Table")]
    public class HatServisResponse
    {
        [XmlElement(ElementName = "HAT_KODU")]
        public string HatKodu { get; set; }

        [XmlElement(ElementName = "HAT_ADI")]
        public string HatAdi { get; set; }

        [XmlElement(ElementName = "TAM_HAT_ADI")]
        public string TamHatAdi { get; set; }

        [XmlElement(ElementName = "HAT_DURUMU")]
        public string HatDurumu { get; set; }

        [XmlElement(ElementName = "BOLGE")]
        public string Bolge { get; set; }
    }
}