using System.Xml.Serialization;

namespace IBB.Api.Models
{
    [XmlRoot(ElementName = "Table")]
    public class BusRouteResponse
    {
        [XmlElement(ElementName = "HATKODU")]
        public string RouteId { get; set; }

        [XmlElement(ElementName = "YON")]
        public string Direction { get; set; }

        [XmlElement(ElementName = "SIRANO")]
        public string OrderId { get; set; }

        [XmlElement(ElementName = "DURAKKODU")]
        public string StopId { get; set; }

        [XmlElement(ElementName = "DURAKADI")]
        public string NameOfStop { get; set; }

        [XmlElement(ElementName = "XKOORDINATI")]
        public string CoordinateX { get; set; }

        [XmlElement(ElementName = "YKOORDINATI")]
        public string CoordinateY { get; set; }

        public string Koordinat => $"{this.CoordinateY.Replace(",", "")} {this.CoordinateX.Replace(",", "")}";

        [XmlElement(ElementName = "DURAKTIPI")]
        public string StationType { get; set; }

        [XmlElement(ElementName = "ISLETMEBOLGE")]
        public string AdministrativeArea { get; set; }

        [XmlElement(ElementName = "ISLETMEALTBOLGE")]
        public string AdministrativeSubArea { get; set; }

        [XmlElement(ElementName = "ILCEADI")]
        public string DistrictName { get; set; }
    }
}