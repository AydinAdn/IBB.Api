using System;
using Newtonsoft.Json;

namespace IBB.Api.Models
{
    public class VehicleLocationResponse
    {
        [JsonProperty("Operator")]
        public string OperatorCompany { get; set; }

        [JsonProperty("Garaj")]
        public string Garage { get; set; }

        [JsonProperty("KapiNo")]
        public string DoorNo { get; set; }

        [JsonProperty("Saat")]
        public DateTime LocationTimeStamp { get; set; }

        [JsonProperty("Boylam")]
        public string Longitude { get; set; }

        [JsonProperty("Enlem")]
        public string Latitude { get; set; }

        [JsonProperty("Hiz")]
        public int Speed { get; set; }

        [JsonProperty("Plaka")]
        public string NumberPlate { get; set; }
    }
}