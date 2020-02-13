using System;
using Newtonsoft.Json;

namespace IBB.Api.Models
{
    public class AracKonumuResponse
    {
        [JsonProperty("Operator")]
        public string Operator { get; set; }

        [JsonProperty("Garaj")]
        public string Garaj { get; set; }

        [JsonProperty("KapiNo")]
        public string KapiNo { get; set; }

        [JsonProperty("Saat")]
        public DateTime Saat { get; set; }

        [JsonProperty("Boylam")]
        public string Boylam { get; set; }

        [JsonProperty("Enlem")]
        public string Enlem { get; set; }

        [JsonProperty("Hiz")]
        public int Hiz { get; set; }

        [JsonProperty("Plaka")]
        public string Plaka { get; set; }
    }
}