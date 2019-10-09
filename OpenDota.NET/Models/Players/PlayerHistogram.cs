using Newtonsoft.Json;

namespace OpenDotaDotNet.Models.Players
{
    public class PlayerHistogram
    {
        /// <summary>
        /// The X factor of the histogram
        /// </summary>
        [JsonProperty("x")]
        public long? X { get; set; }

        [JsonProperty("games")]
        public int Games { get; set; }

        [JsonProperty("win")]
        public int Win { get; set; }
    }
}
