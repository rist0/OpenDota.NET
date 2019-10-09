using Newtonsoft.Json;
using System;

namespace OpenDotaDotNet.Models.Players
{
    public class PlayerPro
    {
        [JsonProperty("account_id")]
        public long AccountId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("country_code")]
        public string CountryCode { get; set; }

        [JsonProperty("fantasy_role")]
        public long FantasyRole { get; set; }

        [JsonProperty("team_id")]
        public long TeamId { get; set; }

        [JsonProperty("team_name")]
        public string TeamName { get; set; }

        [JsonProperty("team_tag")]
        public string TeamTag { get; set; }

        [JsonProperty("is_locked")]
        public bool IsLocked { get; set; }

        [JsonProperty("is_pro")]
        public bool IsPro { get; set; }

        [JsonProperty("locked_until")]
        public object LockedUntil { get; set; }

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

        [JsonProperty("personaname")]
        public string Personaname { get; set; }

        [JsonProperty("last_login")]
        public DateTimeOffset? LastLogin { get; set; }

        [JsonProperty("full_history_time")]
        public DateTimeOffset? FullHistoryTime { get; set; }

        [JsonProperty("cheese")]
        public long Cheese { get; set; }

        [JsonProperty("fh_unavailable")]
        public bool? FhUnavailable { get; set; }

        [JsonProperty("loccountrycode")]
        public string Loccountrycode { get; set; }

        [JsonProperty("last_match_time")]
        public DateTimeOffset LastMatchTime { get; set; }

        [JsonProperty("plus")]
        public bool? Plus { get; set; }

        [JsonProperty("last_played")]
        public long LastPlayed { get; set; }

        [JsonProperty("win")]
        public long Win { get; set; }

        [JsonProperty("games")]
        public long Games { get; set; }

        [JsonProperty("with_win")]
        public long WithWin { get; set; }

        [JsonProperty("with_games")]
        public long WithGames { get; set; }

        [JsonProperty("against_win")]
        public long AgainstWin { get; set; }

        [JsonProperty("against_games")]
        public long AgainstGames { get; set; }

        [JsonProperty("with_gpm_sum")]
        public long? WithGpmSum { get; set; }

        [JsonProperty("with_xpm_sum")]
        public long? WithXpmSum { get; set; }
    }
}
