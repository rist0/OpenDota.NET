using Newtonsoft.Json;

namespace OpenDotaDotNet.Models.Heroes
{
    public class HeroMatchup
    {
        /// <summary>
        /// Numeric identifier for the hero object
        /// </summary>
        [JsonProperty("hero_id")]
        public long HeroId { get; set; }

        /// <summary>
        /// Number of games played
        /// </summary>
        [JsonProperty("games_played")]
        public long GamesPlayed { get; set; }

        /// <summary>
        /// Number of games won
        /// </summary>
        [JsonProperty("wins")]
        public long Wins { get; set; }
    }
}
