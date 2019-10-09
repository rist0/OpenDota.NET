using Newtonsoft.Json;
using System;

namespace OpenDotaDotNet.Models.Players
{
    public class PlayerPeer
    {
        [JsonProperty("account_id")]
        public long AccountId { get; set; }

        [JsonProperty("last_played")]
        public long LastPlayed { get; set; }

        [JsonProperty("win")]
        public int Win { get; set; }

        [JsonProperty("games")]
        public int Games { get; set; }

        [JsonProperty("with_win")]
        public int WithWin { get; set; }

        [JsonProperty("with_games")]
        public int WithGames { get; set; }

        [JsonProperty("against_win")]
        public int AgainstWin { get; set; }

        [JsonProperty("against_games")]
        public int AgainstGames { get; set; }

        [JsonProperty("with_gpm_sum")]
        public int WithGpmSum { get; set; }

        [JsonProperty("with_xpm_sum")]
        public int WithXpmSum { get; set; }

        [JsonProperty("personaname")]
        public string Personaname { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("is_contributor")]
        public bool IsContributor { get; set; }

        [JsonProperty("last_login")]
        public DateTimeOffset? LastLogin { get; set; }

        [JsonProperty("avatar")]
        public Uri Avatar { get; set; }

        [JsonProperty("avatarfull")]
        public Uri Avatarfull { get; set; }
    }
}
