using Newtonsoft.Json;
using System.Collections.Generic;

namespace OpenDotaDotNet.Models.Matches
{
    public class Teamfight
    {
        // The time (in seconds) when the teamfight started
        [JsonProperty("start")]
        public int Start { get; set; }

        // The time (in seconds) when the teamfight ended
        [JsonProperty("end")]
        public int End { get; set; }

        // The time (in seconds) when the last death occured in the teamfight
        [JsonProperty("last_death")]
        public long LastDeath { get; set; }

        // The amount of total deaths during the teamfight
        [JsonProperty("deaths")]
        public long Deaths { get; set; }

        // Players involved in the teamfight
        [JsonProperty("players")]
        public List<TeamfightPlayer> Players { get; set; }
    }
}
