using Newtonsoft.Json;

namespace RefitSample.Models
{
    public class Category
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
