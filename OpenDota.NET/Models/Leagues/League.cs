using Newtonsoft.Json;
using OpenDotaDotNet.Enums;

namespace OpenDotaDotNet.Models.Leagues
{
    public class League
    {
        [JsonProperty("leagueid")]
        public long Leagueid { get; set; }

        [JsonProperty("ticket")]
        public string Ticket { get; set; }

        [JsonProperty("banner")]
        public string Banner { get; set; }

        [JsonProperty("tier")]
        public LeagueTier? Tier { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
