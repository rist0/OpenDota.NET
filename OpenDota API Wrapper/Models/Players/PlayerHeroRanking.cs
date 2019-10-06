using Newtonsoft.Json;

namespace OpenDotaDotNet.Models.Players
{
    public class PlayerHeroRanking
    {
        [JsonProperty("hero_id")]
        public long HeroId { get; set; }

        [JsonProperty("score")]
        public double Score { get; set; }

        [JsonProperty("percent_rank")]
        public double PercentRank { get; set; }

        [JsonProperty("card")]
        public long Card { get; set; }
    }
}
