using Newtonsoft.Json;

namespace OpenDotaDotNet.Models.Replays
{
    public class Replay
    {
        [JsonProperty("match_id")]
        public long MatchId { get; set; }

        [JsonProperty("cluster")]
        public long Cluster { get; set; }

        [JsonProperty("replay_salt")]
        public long ReplaySalt { get; set; }

        [JsonProperty("series_id", NullValueHandling = NullValueHandling.Ignore)]
        public long? SeriesId { get; set; }

        [JsonProperty("series_type", NullValueHandling = NullValueHandling.Ignore)]
        public long? SeriesType { get; set; }
    }
}
