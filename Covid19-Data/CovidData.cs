using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Covid19_Data
{
    class CovidData
    {
        [JsonPropertyName("countryName")]
        public string country { get; set; }
       [JsonPropertyName("confirmed")]
        public int confirmed { get; set; }
        [JsonPropertyName("deaths")]
        public int deaths { get; set; }
        [JsonPropertyName("recovered")]
        public int recovered { get; set; }
        [JsonPropertyName("dateAsOf")]
        public DateTime lastUpdated { get; set; }


    }
}
