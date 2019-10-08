using Newtonsoft.Json;
using System.Collections.Generic;

namespace OpenDotaDotNet.Models.Matches
{
    public class TeamfightPlayer
    {
        // Position where the hero died? Only has value if deaths is greater than 0
        [JsonProperty("deaths_pos")]
        public Dictionary<string, Dictionary<string, int>> DeathsPos { get; set; }

        // The name of abilities used and how many times they were used
        [JsonProperty("ability_uses")]
        public Dictionary<string, int> AbilityUses { get; set; }

        // NOTE: No value is returned for this param
        // [JsonProperty("ability_targets")]
        // public MyWordCounts AbilityTargets { get; set; }

        // The name of items used and how many times they were used
        [JsonProperty("item_uses")]
        public Dictionary<string, long> ItemUses { get; set; }

        // The heroes killed and how many times they were killed
        [JsonProperty("killed")]
        public Dictionary<string, long> Killed { get; set; }

        // How many deaths the player got during the teamfight
        [JsonProperty("deaths")]
        public long Deaths { get; set; }

        // If the player bought back or not
        [JsonProperty("buybacks")]
        public long Buybacks { get; set; }

        // Total amount of damage
        [JsonProperty("damage")]
        public long Damage { get; set; }

        // Total amount of healing
        [JsonProperty("healing")]
        public long Healing { get; set; }

        // Gold gained from the teamfight
        [JsonProperty("gold_delta")]
        public long GoldDelta { get; set; }

        // Experience gained from the teamfight
        [JsonProperty("xp_delta")]
        public long XpDelta { get; set; }

        [JsonProperty("xp_start")]
        public long XpStart { get; set; }

        [JsonProperty("xp_end")]
        public long XpEnd { get; set; }
    }
}
