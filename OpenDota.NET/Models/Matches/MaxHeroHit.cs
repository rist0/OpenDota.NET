using Newtonsoft.Json;

namespace OpenDotaDotNet.Models.Matches
{
    public class MaxHeroHit
    {
        // max_hero_hit
        [JsonProperty("type")]
        public string Type { get; set; }

        // Time (in seconds) when the hit occurred
        [JsonProperty("time")]
        public int Time { get; set; }

        // Whether it was a max hero hit (should be true)
        [JsonProperty("max")]
        public bool Max { get; set; }

        // The inflictor of the hit
        [JsonProperty("inflictor")]
        public string Inflictor { get; set; }

        // The unit which inflicted the hit
        [JsonProperty("unit")]
        public string Unit { get; set; }

        // The unit to which it was inflicted
        [JsonProperty("key")]
        public string Key { get; set; }

        // Damage inflicted
        [JsonProperty("value")]
        public long Value { get; set; }

        // Slot
        [JsonProperty("slot")]
        public long Slot { get; set; }

        // Slot of player
        [JsonProperty("player_slot")]
        public long PlayerSlot { get; set; }
    }
}
