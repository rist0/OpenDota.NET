using Newtonsoft.Json;

namespace OpenDotaDotNet.Models.Heroes
{
    public class HeroMatch
    {
        /// <summary>
        /// Used to identify individual matches, e.g. 3703866531
        /// </summary>
        [JsonProperty("match_id")]
        public long MatchId { get; set; }

        /// <summary>
        /// Unix timestamp of when the match began
        /// </summary>
        [JsonProperty("start_time")]
        public long StartTime { get; set; }

        /// <summary>
        /// Length of the match
        /// </summary>
        [JsonProperty("duration")]
        public long Duration { get; set; }

        /// <summary>
        /// Whether or not the Radiant won the match
        /// </summary>
        [JsonProperty("radiant_win")]
        public bool RadiantWin { get; set; }

        /// <summary>
        /// Identifier for the league the match took place in
        /// </summary>
        [JsonProperty("leagueid")]
        public long Leagueid { get; set; }

        /// <summary>
        /// Name of league the match took place in
        /// </summary>
        [JsonProperty("league_name")]
        public string LeagueName { get; set; }

        /// <summary>
        /// Whether the team/player/hero was on Radiant
        /// </summary>
        [JsonProperty("radiant")]
        public bool Radiant { get; set; }

        /// <summary>
        /// The slot in which the hero/player was
        /// </summary>
        [JsonProperty("player_slot")]
        public long PlayerSlot { get; set; }

        /// <summary>
        /// Account id of the player playing the hero
        /// </summary>
        [JsonProperty("account_id")]
        public long AccountId { get; set; }

        /// <summary>
        /// Number of kills the hero had
        /// </summary>
        [JsonProperty("kills")]
        public long Kills { get; set; }

        /// <summary>
        /// Number of deaths the hero had
        /// </summary>
        [JsonProperty("deaths")]
        public long Deaths { get; set; }

        /// <summary>
        /// Number of assists the hero had
        /// </summary>
        [JsonProperty("assists")]
        public long Assists { get; set; }
    }
}
