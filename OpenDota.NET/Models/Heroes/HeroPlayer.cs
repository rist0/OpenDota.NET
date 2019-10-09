using Newtonsoft.Json;

namespace OpenDotaDotNet.Models.Heroes
{
    public class HeroPlayer
    {
        /// <summary>
        /// Player's account identifier
        /// </summary>
        [JsonProperty("account_id")]
        public long AccountId { get; set; }

        /// <summary>
        /// Number of games played on the hero
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
