using Newtonsoft.Json;

namespace OpenDotaDotNet.Models.Metadata
{
    public class Metadata
    {
        [JsonProperty("banner")]
        public object Banner { get; set; }

        [JsonProperty("cheese")]
        public Cheese Cheese { get; set; }
    }

    public partial class Cheese
    {
        [JsonProperty("cheese")]
        public int CheeseAmount { get; set; }

        [JsonProperty("goal")]
        public int Goal { get; set; }
    }
}
