using Newtonsoft.Json;

namespace OpenDotaDotNet.Models.Distributions
{
    public class CountryMmrRow
    {
        [JsonProperty("loccountrycode")]
        public string Loccountrycode { get; set; }

        [JsonProperty("count")]
        public long Count { get; set; }

        [JsonProperty("avg")]
        public long Avg { get; set; }

        [JsonProperty("common")]
        public string Common { get; set; }
    }
}
