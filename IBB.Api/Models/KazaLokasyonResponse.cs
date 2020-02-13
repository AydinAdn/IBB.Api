using System;
using Newtonsoft.Json;

namespace IBB.Api.Models
{
    public class KazaLokasyonResponse
    {
        [JsonProperty("DTOLAYBASLANGICZAMANI")]
        public DateTime BaslangicZamani { get; set; }

        [JsonProperty("NBOYLAM")]
        public double Boylam { get; set; }

        [JsonProperty("NENLEM")]
        public double Enlem { get; set; }

        [JsonProperty("Tur")]
        public string Tur { get; set; }
    }
}