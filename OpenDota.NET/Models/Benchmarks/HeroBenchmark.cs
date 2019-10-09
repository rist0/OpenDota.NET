using Newtonsoft.Json;

namespace OpenDotaDotNet.Models.Benchmarks
{
    public class HeroBenchmark
    {
        [JsonProperty("hero_id")]
        public long HeroId { get; set; }

        [JsonProperty("result")]
        public HeroBenchmarkResult Result { get; set; }
    }
}
