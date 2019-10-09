using Newtonsoft.Json;

namespace OpenDotaDotNet.Models.Heroes
{
    public class HeroDuration
    {
        /// <summary>
        /// Lower bound of number of seconds the match lasted
        /// </summary>
        [JsonProperty("duration_bin")]
        public int DurationBin { get; set; }

        /// <summary>
        /// Number of games played
        /// </summary>
        [JsonProperty("games_played")]
        public int GamesPlayed { get; set; }

        /// <summary>
        /// Number of wins
        /// </summary>
        [JsonProperty("wins")]
        public int Wins { get; set; }
    }
}
