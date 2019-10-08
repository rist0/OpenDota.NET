using Newtonsoft.Json;
using System.Collections.Generic;

namespace OpenDotaDotNet.Models.Players
{
    public class PlayerCount
    {
        /// <summary>
        /// Integer describing whether or not the player left the game. 0: didn't leave. 1: left safely. 2+: Abandoned
        /// </summary>
        [JsonProperty("leaver_status")]
        public Dictionary<string, PlayerCountStats> LeaverStatus { get; set; }

        /// <summary>
        /// Integer corresponding to game mode played. List of constants can be found here: https://github.com/odota/dotaconstants/blob/master/json/game_mode.json
        /// </summary>
        [JsonProperty("game_mode")]
        public Dictionary<string, PlayerCountStats> GameMode { get; set; }

        /// <summary>
        /// Integer corresponding to lobby type of match. List of constants can be found here: https://github.com/odota/dotaconstants/blob/master/json/lobby_type.json
        /// </summary>
        [JsonProperty("lobby_type")]
        public Dictionary<string, PlayerCountStats> LobbyType { get; set; }

        /// <summary>
        /// lane_role
        /// </summary>
        [JsonProperty("lane_role")]
        public Dictionary<string, PlayerCountStats> LaneRole { get; set; }

        /// <summary>
        /// Integer corresponding to the region the game was played on
        /// </summary>
        [JsonProperty("region")]
        public Dictionary<string, PlayerCountStats> Region { get; set; }

        /// <summary>
        /// patch
        /// </summary>
        [JsonProperty("patch")]
        public Dictionary<string, PlayerCountStats> Patch { get; set; }

        /// <summary>
        /// Radiant/dire stats
        /// </summary>
        [JsonProperty("is_radiant")]
        public Dictionary<string, PlayerCountStats> IsRadiant { get; set; }
    }

    public partial class PlayerCountStats
    {
        [JsonProperty("games")]
        public long Games { get; set; }

        [JsonProperty("win")]
        public long Win { get; set; }
    }
}
