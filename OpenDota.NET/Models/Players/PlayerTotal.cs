using Newtonsoft.Json;

namespace OpenDotaDotNet.Models.Players
{
    public class PlayerTotal
    {
        [JsonProperty("field")]
        public string Field { get; set; }

        [JsonProperty("n")]
        public long Number { get; set; }

        [JsonProperty("sum")]
        public double Sum { get; set; }
    }
}
