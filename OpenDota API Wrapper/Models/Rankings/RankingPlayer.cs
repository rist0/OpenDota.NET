using Newtonsoft.Json;
using System;

namespace OpenDotaDotNet.Models.Rankings
{
    public class RankingPlayer
    {
        [JsonProperty("account_id")]
        public long AccountId { get; set; }

        [JsonProperty("score")]
        public double Score { get; set; }

        [JsonProperty("personaname")]
        public string Personaname { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("avatar")]
        public Uri Avatar { get; set; }

        [JsonProperty("last_login")]
        public DateTimeOffset? LastLogin { get; set; }

        [JsonProperty("rank_tier")]
        public int? RankTier { get; set; }
    }
}
