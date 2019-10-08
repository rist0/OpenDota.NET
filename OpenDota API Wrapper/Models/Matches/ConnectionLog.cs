using Newtonsoft.Json;

namespace OpenDotaDotNet.Models.Matches
{
    public class ConnectionLog
    {
        // Event that occurred (connect, reconnect, disconnect)
        [JsonProperty("event")]
        public string Event { get; set; }

        // Which slot the player is in. 0-127 are Radiant, 128-255 are Dire
        [JsonProperty("player_slot")]
        public long PlayerSlot { get; set; }

        [JsonProperty("slot")]
        public long Slot { get; set; }

        // Game time in seconds the event ocurred
        [JsonProperty("time")]
        public long Time { get; set; }

        // Type of log (should always be "connection_log")
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
