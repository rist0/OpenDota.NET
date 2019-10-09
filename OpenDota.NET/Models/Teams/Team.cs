using Newtonsoft.Json;
using System;

namespace OpenDotaDotNet.Models.Teams
{
    public class Team
    {
        [JsonProperty("team_id")]
        public int TeamId { get; set; }

        [JsonProperty("rating")]
        public double Rating { get; set; }

        [JsonProperty("wins")]
        public int Wins { get; set; }

        [JsonProperty("losses")]
        public int Losses { get; set; }

        [JsonProperty("last_match_time")]
        public long LastMatchTime { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("tag")]
        public string Tag { get; set; }

        [JsonProperty("logo_url")]
        public Uri LogoUrl { get; set; }
    }
}
