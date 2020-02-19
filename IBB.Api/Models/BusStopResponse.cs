using Newtonsoft.Json;

namespace IBB.Api.Models
{
    public class BusStopResponse
    {
        [JsonProperty("SDURAKKODU")]
        public int StopId { get; set; }

        [JsonProperty("SDURAKADI")]
        public string NameOfStop { get; set; }

        [JsonProperty("KOORDINAT")]
        public string Coordinate { get; set; }

        [JsonProperty("ILCEADI")]
        public string District { get; set; }

        [JsonProperty("SYON")]
        public string Direction { get; set; }

        [JsonProperty("AKILLI")]
        public string IsSmartStop { get; set; }

        [JsonProperty("FIZIKI")]
        public string BusStopShelterType { get; set; }

        [JsonProperty("DURAK_TIPI")]
        public string BusStopType { get; set; }
    }
}