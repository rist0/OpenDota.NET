using Newtonsoft.Json;
using System;

namespace OpenDotaDotNet.Models.Players
{
    public class Player
    {
        [JsonProperty("tracked_until")]
        public string TrackedUntil { get; set; }

        [JsonProperty("solo_competitive_rank")]
        public string SoloCompetitiveRank { get; set; }

        [JsonProperty("competitive_rank")]
        public string CompetitiveRank { get; set; }

        [JsonProperty("rank_tier")]
        public int? RankTier { get; set; }

        [JsonProperty("leaderboard_rank")]
        public int? LeaderboardRank { get; set; }

        [JsonProperty("mmr_estimate")]
        public MmrEstimate MmrEstimate { get; set; }

        [JsonProperty("profile")]
        public Profile Profile { get; set; }
    }

    public class MmrEstimate
    {
        [JsonProperty("estimate")]
        public int? Estimate { get; set; }
    }

    public class Profile
    {
        [JsonProperty("account_id")]
        public long AccountId { get; set; }

        [JsonProperty("personaname")]
        public string Personaname { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("plus")]
        public bool? Plus { get; set; }

        [JsonProperty("cheese")]
        public long Cheese { get; set; }

        [JsonProperty("steamid")]
        public string Steamid { get; set; }

        [JsonProperty("avatar")]
        public Uri Avatar { get; set; }

        [JsonProperty("avatarmedium")]
        public Uri Avatarmedium { get; set; }

        [JsonProperty("avatarfull")]
        public Uri Avatarfull { get; set; }

        [JsonProperty("profileurl")]
        public Uri Profileurl { get; set; }

        [JsonProperty("last_login")]
        public DateTimeOffset? LastLogin { get; set; }

        [JsonProperty("loccountrycode")]
        public string Loccountrycode { get; set; }

        [JsonProperty("is_contributor")]
        public bool IsContributor { get; set; }
    }
}
