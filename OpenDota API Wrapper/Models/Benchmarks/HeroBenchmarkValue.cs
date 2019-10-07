using Newtonsoft.Json;

namespace OpenDotaDotNet.Models.Benchmarks
{
    public class HeroBenchmarkValue
    {
        [JsonProperty("percentile")]
        public double Percentile { get; set; }

        [JsonProperty("value")]
        public double? Value { get; set; }
    }
}
