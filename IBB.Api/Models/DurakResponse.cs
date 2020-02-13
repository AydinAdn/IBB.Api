using Newtonsoft.Json;

namespace IBB.Api.Models
{
    public class DurakResponse
    {
        [JsonProperty("SDURAKKODU")]
        public int DurakKodu { get; set; }

        [JsonProperty("SDURAKADI")]
        public string DurakAdi { get; set; }

        [JsonProperty("KOORDINAT")]
        public string Koordinat { get; set; }

        [JsonProperty("ILCEADI")]
        public string IlceAdi { get; set; }

        [JsonProperty("SYON")]
        public string Yon { get; set; }

        [JsonProperty("AKILLI")]
        public string Akilli { get; set; }

        [JsonProperty("FIZIKI")]
        public string Fiziki { get; set; }

        [JsonProperty("DURAK_TIPI")]
        public string DurakTipi { get; set; }
    }
}