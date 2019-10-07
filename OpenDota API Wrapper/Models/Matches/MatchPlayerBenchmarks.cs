using Newtonsoft.Json;
using System.Collections.Generic;

namespace OpenDotaDotNet.Models.Matches
{
    public class MatchPlayerBenchmarks
    {
        [JsonProperty("gold_per_min")]
        public Dictionary<string, double> GoldPerMin { get; set; }

        [JsonProperty("xp_per_min")]
        public Dictionary<string, double> XpPerMin { get; set; }

        [JsonProperty("kills_per_min")]
        public Dictionary<string, double> KillsPerMin { get; set; }

        [JsonProperty("last_hits_per_min")]
        public Dictionary<string, double> LastHitsPerMin { get; set; }

        [JsonProperty("hero_damage_per_min")]
        public Dictionary<string, double> HeroDamagePerMin { get; set; }

        [JsonProperty("hero_healing_per_min")]
        public Dictionary<string, double> HeroHealingPerMin { get; set; }

        [JsonProperty("tower_damage")]
        public Dictionary<string, double> TowerDamage { get; set; }

        [JsonProperty("stuns_per_min")]
        public Dictionary<string, double> StunsPerMin { get; set; }

        [JsonProperty("lhten")]
        public Dictionary<string, double> Lhten { get; set; }
    }
}
