using Newtonsoft.Json;

namespace OpenDotaDotNet.Models.Matches
{
    public class DraftTiming
    {
        // The order of pick
        [JsonProperty("order")]
        public int Order { get; set; }

        // Whether a hero was picked or not. True if hero was picked, false if hero was banned
        [JsonProperty("pick")]
        public bool Pick { get; set; }

        // The id of the active team doing the picking
        [JsonProperty("active_team")]
        public int ActiveTeam { get; set; }

        // The ID of the picked hero
        [JsonProperty("hero_id")]
        public int HeroId { get; set; }

        // Which slot the player playing the picked hero is in. 0-127 are Radiant, 128-255 are Dire
        [JsonProperty("player_slot")]
        public long? PlayerSlot { get; set; }

        // Extra time left
        [JsonProperty("extra_time")]
        public int ExtraTime { get; set; }

        // Total time taken to pick ther hero
        [JsonProperty("total_time_taken")]
        public int TotalTimeTaken { get; set; }
    }
}
