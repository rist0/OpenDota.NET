using Newtonsoft.Json;

namespace OpenDotaDotNet.Models.ProMatches
{
    public class ProMatch
    {
        /// <summary>
        /// Used to identify individual matches, e.g. 3703866531
        /// </summary>
        [JsonProperty("match_id")]
        public long MatchId { get; set; }

        /// <summary>
        /// Length of the match
        /// </summary>
        [JsonProperty("duration")]
        public int Duration { get; set; }

        /// <summary>
        /// Unix timestamp of when the match began
        /// </summary>
        [JsonProperty("start_time")]
        public long StartTime { get; set; }

        /// <summary>
        /// The Radiant's team_id
        /// </summary>
        [JsonProperty("radiant_team_id")]
        public long? RadiantTeamId { get; set; }

        /// <summary>
        /// The Radiant's team name
        /// </summary>
        [JsonProperty("radiant_name")]
        public string RadiantName { get; set; }

        /// <summary>
        /// The Dire's team_id
        /// </summary>
        [JsonProperty("dire_team_id")]
        public long? DireTeamId { get; set; }

        /// <summary>
        /// The Dire's team name
        /// </summary>
        [JsonProperty("dire_name")]
        public string DireName { get; set; }

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
        /// Identifier for the series of the match
        /// </summary>
        [JsonProperty("series_id")]
        public long? SeriesId { get; set; }

        /// <summary>
        /// Type of series the match was
        /// </summary>
        [JsonProperty("series_type")]
        public long? SeriesType { get; set; }

        /// <summary>
        /// Number of kills the Radiant team had when the match ended
        /// </summary>
        [JsonProperty("radiant_score")]
        public int RadiantScore { get; set; }

        /// <summary>
        /// Number of kills the Dire team had when the match ended
        /// </summary>
        [JsonProperty("dire_score")]
        public int DireScore { get; set; }

        /// <summary>
        /// Whether or not the Radiant won the match
        /// </summary>
        [JsonProperty("radiant_win")]
        public bool RadiantWin { get; set; }
    }
}
