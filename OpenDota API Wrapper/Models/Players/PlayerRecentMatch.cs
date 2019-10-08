using Newtonsoft.Json;

namespace OpenDotaDotNet.Models.Players
{
    public class PlayerRecentMatch
    {
        // The ID of the match
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

        // Start time of the match in seconds elapsed since 1970
        [JsonProperty("start_time")]
        public long StartTime { get; set; }

        // version
        [JsonProperty("version")]
        public long? Version { get; set; }

        // Total kills the player had at the end of the match
        [JsonProperty("kills")]
        public int Kills { get; set; }

        // Total deaths the player had at the end of the match
        [JsonProperty("deaths")]
        public int Deaths { get; set; }

        // Total assists the player had at the end of the match
        [JsonProperty("assists")]
        public int Assists { get; set; }

        // Skill bracket assigned by Valve (Normal, High, Very High)
        [JsonProperty("skill")]
        public int? Skill { get; set; }

        // Average experience per minute
        [JsonProperty("xp_per_min")]
        public int XpPerMin { get; set; }

        // Average gold per minute
        [JsonProperty("gold_per_min")]
        public int GoldPerMin { get; set; }

        // Total amount of hero damage dealt by the player
        [JsonProperty("hero_damage")]
        public int HeroDamage { get; set; }

        // Total amount of tower damage dealt by the player
        [JsonProperty("tower_damage")]
        public int TowerDamage { get; set; }

        // Total amount of healing provided by the player
        [JsonProperty("hero_healing")]
        public int HeroHealing { get; set; }

        // Total amounts of last hits
        [JsonProperty("last_hits")]
        public int LastHits { get; set; }

        // Integer corresponding to which lane the player laned in for the match
        [JsonProperty("lane")]
        public int? Lane { get; set; }

        // lane_role
        [JsonProperty("lane_role")]
        public int? LaneRole { get; set; }

        // Boolean describing whether or not the player roamed
        [JsonProperty("is_roaming")]
        public bool? IsRoaming { get; set; }

        // cluster
        [JsonProperty("cluster")]
        public int Cluster { get; set; }

        // Integer describing whether or not the player left the game. 0: didn't leave. 1: left safely. 2+: Abandoned
        [JsonProperty("leaver_status")]
        public int LeaverStatus { get; set; }

        // Size of the players party. If not in a party, will return 1.
        [JsonProperty("party_size")]
        public long? PartySize { get; set; }
    }
}
