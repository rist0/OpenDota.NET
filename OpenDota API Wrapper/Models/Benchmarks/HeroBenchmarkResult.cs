using Newtonsoft.Json;
using System.Collections.Generic;

namespace OpenDotaDotNet.Models.Benchmarks
{
    public class HeroBenchmarkResult
    {
        [JsonProperty("gold_per_min")]
        public List<HeroBenchmarkValue> GoldPerMin { get; set; }

        [JsonProperty("xp_per_min")]
        public List<HeroBenchmarkValue> XpPerMin { get; set; }

        [JsonProperty("kills_per_min")]
        public List<HeroBenchmarkValue> KillsPerMin { get; set; }

        [JsonProperty("last_hits_per_min")]
        public List<HeroBenchmarkValue> LastHitsPerMin { get; set; }

        [JsonProperty("hero_damage_per_min")]
        public List<HeroBenchmarkValue> HeroDamagePerMin { get; set; }

        [JsonProperty("hero_healing_per_min")]
        public List<HeroBenchmarkValue> HeroHealingPerMin { get; set; }

        [JsonProperty("tower_damage")]
        public List<HeroBenchmarkValue> TowerDamage { get; set; }

        [JsonProperty("stuns_per_min")]
        public List<HeroBenchmarkValue> StunsPerMin { get; set; }

        [JsonProperty("lhten")]
        public List<HeroBenchmarkValue> Lhten { get; set; }
    }
}
