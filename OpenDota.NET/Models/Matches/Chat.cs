using Newtonsoft.Json;

namespace OpenDotaDotNet.Models.Matches
{
    public class Chat
    {
        // Time in seconds at which the message was said
        [JsonProperty("time")]
        public int Time { get; set; }

        // Type of message [currently known values - "chat" and "chatwheel"]
        [JsonProperty("type")]
        public string Type { get; set; }

        // The message the player sent
        [JsonProperty("key")]
        public string Key { get; set; }

        // The slot of the player
        [JsonProperty("slot")]
        public long Slot { get; set; }

        // Which slot the player is in. 0-127 are Radiant, 128-255 are Dire
        [JsonProperty("player_slot")]
        public long PlayerSlot { get; set; }

        // Name of the player who sent the message
        [JsonProperty("unit", NullValueHandling = NullValueHandling.Ignore)]
        public string Unit { get; set; }
    }
}
