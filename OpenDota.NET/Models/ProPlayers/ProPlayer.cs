using Newtonsoft.Json;
using System;

namespace OpenDotaDotNet.Models.ProPlayers
{
    public class ProPlayer
    {
        /// <summary>
        /// Player's account identifier
        /// </summary>
        [JsonProperty("account_id")]
        public long AccountId { get; set; }

        /// <summary>
        /// Player's steam identifier
        /// </summary>
        [JsonProperty("steamid")]
        public string Steamid { get; set; }

        /// <summary>
        /// Steam picture URL (small picture)
        /// </summary>
        [JsonProperty("avatar")]
        public Uri Avatar { get; set; }

        /// <summary>
        /// Steam picture URL (medium picture)
        /// </summary>
        [JsonProperty("avatarmedium")]
        public Uri Avatarmedium { get; set; }

        /// <summary>
        /// Steam picture URL (full picture)
        /// </summary>
        [JsonProperty("avatarfull")]
        public Uri Avatarfull { get; set; }

        /// <summary>
        /// Steam profile URL
        /// </summary>
        [JsonProperty("profileurl")]
        public Uri Profileurl { get; set; }

        /// <summary>
        /// Player's Steam name
        /// </summary>
        [JsonProperty("personaname")]
        public string Personaname { get; set; }

        /// <summary>
        /// Date and time of last login to OpenDota
        /// </summary>
        [JsonProperty("last_login")]
        public DateTimeOffset? LastLogin { get; set; }

        /// <summary>
        /// Date and time of last request to refresh player's match history
        /// </summary>
        [JsonProperty("full_history_time")]
        public DateTimeOffset? FullHistoryTime { get; set; }

        /// <summary>
        /// Amount of dollars the player has donated to OpenDota
        /// </summary>
        [JsonProperty("cheese")]
        public int Cheese { get; set; }

        /// <summary>
        /// Whether the refresh of player' match history failed
        /// </summary>
        [JsonProperty("fh_unavailable")]
        public bool? FhUnavailable { get; set; }

        /// <summary>
        /// Player's country identifier, e.g. US
        /// </summary>
        [JsonProperty("loccountrycode")]
        public string Loccountrycode { get; set; }

        /// <summary>
        /// Last match time
        /// </summary>
        [JsonProperty("last_match_time")]
        public DateTimeOffset LastMatchTime { get; set; }

        /// <summary>
        /// Plus
        /// </summary>
        [JsonProperty("plus")]
        public bool? Plus { get; set; }

        /// <summary>
        /// Verified player name, e.g. 'Miracle-'
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Player's country code
        /// </summary>
        [JsonProperty("country_code")]
        public string CountryCode { get; set; }

        /// <summary>
        /// Player's ingame role (core: 1 or support: 2)
        /// </summary>
        [JsonProperty("fantasy_role")]
        public int FantasyRole { get; set; }

        /// <summary>
        /// Player's team identifier
        /// </summary>
        [JsonProperty("team_id")]
        public long TeamId { get; set; }

        /// <summary>
        /// Player's team name, e.g. 'Evil Geniuses'
        /// </summary>
        [JsonProperty("team_name")]
        public string TeamName { get; set; }

        /// <summary>
        /// Player's team shorthand tag, e.g. 'EG'
        /// </summary>
        [JsonProperty("team_tag")]
        public string TeamTag { get; set; }

        /// <summary>
        /// Whether the roster lock is active
        /// </summary>
        [JsonProperty("is_locked")]
        public bool IsLocked { get; set; }

        /// <summary>
        /// Whether the player is professional or not
        /// </summary>
        [JsonProperty("is_pro")]
        public bool IsPro { get; set; }

        // NOTE: This properly always returns null, so I have commented it out
        ///// <summary>
        ///// When the roster lock will end
        ///// </summary>
        //[JsonProperty("locked_until")]
        //public object LockedUntil { get; set; }
    }
}
