using System;
using Newtonsoft.Json;

namespace IBB.Api.Models
{
    public class AccidentLocationResponse
    {
        [JsonProperty("DTOLAYBASLANGICZAMANI")]
        public DateTime AccidentTimeStamp { get; set; }

        [JsonProperty("NBOYLAM")]
        public double Longitude { get; set; }

        [JsonProperty("NENLEM")]
        public double Latitude { get; set; }

        [JsonProperty("Tur")]
        public string Type { get; set; }
    }
}