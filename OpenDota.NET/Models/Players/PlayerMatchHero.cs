using Newtonsoft.Json;

namespace OpenDotaDotNet.Models.Players
{
    public class PlayerMatchHero
    {
        [JsonProperty("account_id")]
        public long? AccountId { get; set; }

        [JsonProperty("hero_id")]
        public long HeroId { get; set; }

        [JsonProperty("player_slot")]
        public long PlayerSlot { get; set; }
    }
}
