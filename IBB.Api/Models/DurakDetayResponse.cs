using System.Xml.Serialization;

namespace IBB.Api.Models
{
    [XmlRoot(ElementName = "Table")]
    public class DurakDetayResponse
    {
        [XmlElement(ElementName = "HATKODU")]
        public string HatKodu { get; set; }

        [XmlElement(ElementName = "YON")]
        public string Yon { get; set; }

        [XmlElement(ElementName = "SIRANO")]
        public string SiraNo { get; set; }

        [XmlElement(ElementName = "DURAKKODU")]
        public string DurakKodu { get; set; }

        [XmlElement(ElementName = "DURAKADI")]
        public string DurakAdi { get; set; }

        [XmlElement(ElementName = "XKOORDINATI")]
        public string KoordinatX { get; set; }

        [XmlElement(ElementName = "YKOORDINATI")]
        public string KoordinatY { get; set; }

        public string Koordinat => $"{this.KoordinatY.Replace(",", "")} {this.KoordinatX.Replace(",", "")}";

        [XmlElement(ElementName = "DURAKTIPI")]
        public string DurakTipi { get; set; }

        [XmlElement(ElementName = "ISLETMEBOLGE")]
        public string IsletmeBolge { get; set; }

        [XmlElement(ElementName = "ISLETMEALTBOLGE")]
        public string IsletmeAltBolge { get; set; }

        [XmlElement(ElementName = "ILCEADI")]
        public string IlceAdi { get; set; }
    }
}