using Newtonsoft.Json;

namespace IBB.Api.Models
{
    public class BusGarageResponse
    {
        [JsonProperty("ID")]
        public int Id { get; set; }

        [JsonProperty("GARAJ_ADI")]
        public string NameOfGarage { get; set; }

        [JsonProperty("GARAJ_KODU")]
        public string GarageId { get; set; }

        [JsonProperty("KOORDINAT")]
        public string Coordinates { get; set; }
    }
}