using Newtonsoft.Json;

namespace OpenDotaDotNet.Models.Distributions
{
    public class MmrDistribution
    {
        [JsonProperty("ranks")]
        public Mmr Ranks { get; set; }

        [JsonProperty("mmr")]
        public Mmr Mmr { get; set; }

        [JsonProperty("country_mmr")]
        public CountryMmr CountryMmr { get; set; }
    }
}
