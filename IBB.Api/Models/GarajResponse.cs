using Newtonsoft.Json;

namespace IBB.Api.Models
{
    public class GarajResponse
    {
        [JsonProperty("ID")]
        public int Id { get; set; }

        [JsonProperty("GARAJ_ADI")]
        public string GarajAdi { get; set; }

        [JsonProperty("GARAJ_KODU")]
        public string GarajKodu { get; set; }

        [JsonProperty("KOORDINAT")]
        public string Koordinat { get; set; }
    }
}