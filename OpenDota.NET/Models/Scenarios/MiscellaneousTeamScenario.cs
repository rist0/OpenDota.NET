using Newtonsoft.Json;

namespace OpenDotaDotNet.Models.Scenarios
{
    public class MiscellaneousTeamScenario
    {
        /// <summary>
        /// The scenario's name or description
        /// </summary>
        [JsonProperty("scenario")]
        public string Scenario { get; set; }

        /// <summary>
        /// Boolean indicating whether Radiant executed this scenario
        /// </summary>
        [JsonProperty("is_radiant")]
        public bool IsRadiant { get; set; }

        /// <summary>
        /// Region the game was played in
        /// </summary>
        [JsonProperty("region")]
        public int Region { get; set; }

        /// <summary>
        /// The number of games where this scenario occurred
        /// </summary>
        [JsonProperty("games")]
        public int Games { get; set; }

        /// <summary>
        /// The number of games won where this scenario occured
        /// </summary>
        [JsonProperty("wins")]
        public int Wins { get; set; }
    }
}
