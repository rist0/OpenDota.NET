using Newtonsoft.Json;
using System.Collections.Generic;

namespace OpenDotaDotNet.Models.Players
{
    public class PlayerMatch
    {
        // Match ID
        [JsonProperty("match_id")]
        public long MatchId { get; set; }

        // Which slot the player is in. 0-127 are Radiant, 128-255 are Dire
        [JsonProperty("player_slot")]
        public int PlayerSlot { get; set; }

        // Boolean indicating whether Radiant won the match
        [JsonProperty("radiant_win")]
        public bool RadiantWin { get; set; }

        // Duration of the game in seconds
        [JsonProperty("duration")]
        public int Duration { get; set; }

        // Integer corresponding to game mode played. List of constants can be found here: https://github.com/odota/dotaconstants/blob/master/json/game_mode.json
        [JsonProperty("game_mode")]
        public int GameMode { get; set; }

        // Integer corresponding to lobby type of match. List of constants can be found here: https://github.com/odota/dotaconstants/blob/master/json/lobby_type.json
        [JsonProperty("lobby_type")]
        public int LobbyType { get; set; }

        // The ID value of the hero played
        [JsonProperty("hero_id")]
        public int HeroId { get; set; }

        // Time the game started in seconds since 1970
        [JsonProperty("start_time")]
        public long StartTime { get; set; }

        // Version
        [JsonProperty("version")]
        public int? Version { get; set; }

        // Total kills the player had at the end of the game
        [JsonProperty("kills")]
        public int Kills { get; set; }

        // Total deaths the player had at the end of the game
        [JsonProperty("deaths")]
        public int Deaths { get; set; }

        // Total assists the player had at the end of the game
        [JsonProperty("assists")]
        public int Assists { get; set; }

        // Skill bracket assigned by Valve (Normal, High, Very High)
        [JsonProperty("skill")]
        public int? Skill { get; set; }

        // Integer describing whether or not the player left the game. 0: didn't leave. 1: left safely. 2+: Abandoned
        [JsonProperty("leaver_status")]
        public int LeaverStatus { get; set; }

        // Size of the player's party
        [JsonProperty("party_size")]
        public int? PartySize { get; set; }

        // Heroes (requires ?project=heroes)
        [JsonProperty("heroes")]
        public Dictionary<string, PlayerMatchHero> Heroes { get; set; }
    }
}
