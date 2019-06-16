using System.Collections.Generic;
using Newtonsoft.Json;

namespace VaryenceInterview.Domain.Responses
{
    public class GeocodeResponse
    {
        [JsonProperty("results")]
        public List<Result> Results { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }
    }
}