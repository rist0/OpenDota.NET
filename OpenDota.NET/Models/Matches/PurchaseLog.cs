using Newtonsoft.Json;

namespace OpenDotaDotNet.Models.Matches
{
    public class PurchaseLog
    {
        // Key of the item purchased
        [JsonProperty("key")]
        public string Key { get; set; }

        // Time in seconds when the item was purchased
        [JsonProperty("time")]
        public long Time { get; set; }
    }
}
