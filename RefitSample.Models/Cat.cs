using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace RefitSample.Models
{
    public class Cat
    {
        [JsonProperty("breeds")]
        public List<Breed> Breeds { get; set; }

        [JsonProperty("categories", NullValueHandling = NullValueHandling.Ignore)]
        public List<Category> Categories { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("url")]
        public Uri Url { get; set; }

        [JsonProperty("width")]
        public long Width { get; set; }

        [JsonProperty("height")]
        public long Height { get; set; }
    }
}
