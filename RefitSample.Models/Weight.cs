using Newtonsoft.Json;

namespace RefitSample.Models
{
    public class Weight
    {
        [JsonProperty("imperial")]
        public string Imperial { get; set; }

        [JsonProperty("metric")]
        public string Metric { get; set; }
    }
}
