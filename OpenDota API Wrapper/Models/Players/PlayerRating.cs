using Newtonsoft.Json;
using System;

namespace OpenDotaDotNet.Models.Players
{
    public class PlayerRating
    {
        [JsonProperty("account_id")]
        public long AccountId { get; set; }

        [JsonProperty("match_id")]
        public long? MatchId { get; set; }

        [JsonProperty("solo_competitive_rank")]
        public int? SoloCompetitiveRank { get; set; }

        [JsonProperty("competitive_rank")]
        public int? CompetitiveRank { get; set; }

        [JsonProperty("time")]
        public DateTimeOffset Time { get; set; }
    }
}
