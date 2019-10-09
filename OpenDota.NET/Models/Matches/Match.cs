using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace OpenDotaDotNet.Models.Matches
{
    public class Match
    {
        // The ID number of the match assigned by Valve
        [JsonProperty("match_id")]
        public long MatchId { get; set; }

        // Bitmask. An integer that represents a binary of which barracks are still standing. 63 would mean all barracks still stand at the end of the game.
        [JsonProperty("barracks_status_dire")]
        public int BarracksStatusDire { get; set; }

        // Bitmask. An integer that represents a binary of which barracks are still standing. 63 would mean all barracks still stand at the end of the game.
        [JsonProperty("barracks_status_radiant")]
        public int BarracksStatusRadiant { get; set; }

        [JsonProperty("chat")]
        public List<Chat> Chat { get; set; }

        [JsonProperty("cluster")]
        public int Cluster { get; set; }

        [JsonProperty("cosmetics")]
        public Dictionary<string, long> Cosmetics { get; set; }

        [JsonProperty("dire_score")]
        public int DireScore { get; set; }

        // The ID of dire team
        [JsonProperty("dire_team_id")]
        public int? DireTeamId { get; set; }

        // Draft (pick) timings and info
        [JsonProperty("draft_timings")]
        public List<DraftTiming> DraftTimings { get; set; }

        // Duration of the game in seconds
        [JsonProperty("duration")]
        public int Duration { get; set; }

        [JsonProperty("engine")]
        public int Engine { get; set; }

        // Time (in seconds) of game when first blood was drawn
        [JsonProperty("first_blood_time")]
        public long FirstBloodTime { get; set; }

        // Integer corresponding to game mode played. List of constants can be found here: https://github.com/odota/dotaconstants/blob/master/json/game_mode.json
        [JsonProperty("game_mode")]
        public int GameMode { get; set; }

        // Number of human players in the game
        [JsonProperty("human_players")]
        public int HumanPlayers { get; set; }

        // The ID of league
        [JsonProperty("leagueid")]
        public int Leagueid { get; set; }

        // Integer corresponding to lobby type of match. List of constants can be found here: https://github.com/odota/dotaconstants/blob/master/json/lobby_type.json
        [JsonProperty("lobby_type")]
        public long LobbyType { get; set; }

        [JsonProperty("match_seq_num")]
        public long MatchSeqNum { get; set; }

        // Number of negative votes the replay received in the in-game client
        [JsonProperty("negative_votes")]
        public long NegativeVotes { get; set; }

        // Game objectives
        [JsonProperty("objectives")]
        public List<Objective> Objectives { get; set; }

        // Object containing information on the draft. Each pick/ban contains a boolean relating to whether the choice is a pick or a ban, the hero ID, the team the picked or banned it, and the order
        [JsonProperty("picks_bans")]
        public List<PickBan> PicksBans { get; set; }

        // Number of positive votes the replay received in the in-game client
        [JsonProperty("positive_votes")]
        public int PositiveVotes { get; set; }

        // Array of the Radiant gold advantage at each minute in the game. A negative number means that Radiant is behind, and thus it is their gold disadvantage.
        [JsonProperty("radiant_gold_adv")]
        public List<int> RadiantGoldAdvantage { get; set; }

        // Final score for Radiant (number of kills on Radiant)
        [JsonProperty("radiant_score")]
        public int RadiantScore { get; set; }

        // Id of the Radiant team
        [JsonProperty("radiant_team_id")]
        public int? RadiantTeamId { get; set; }

        // Boolean indicating whether Radiant won the match
        [JsonProperty("radiant_win")]
        public bool RadiantWin { get; set; }

        // Array of the Radiant experience advantage at each minute in the game. A negative number means that Radiant is behind, and thus it is their experience disadvantage.
        [JsonProperty("radiant_xp_adv")]
        public List<int> RadiantXpAdvantage { get; set; }

        // The skill level of the game
        [JsonProperty("skill")]
        public int? Skill { get; set; }

        // The Unix timestamp at which the game started
        [JsonProperty("start_time")]
        public long StartTime { get; set; }

        // Detailed list of teamfights
        [JsonProperty("teamfights")]
        public List<Teamfight> Teamfights { get; set; }

        // Bitmask. An integer that represents a binary of which Dire towers are still standing.
        [JsonProperty("tower_status_dire")]
        public int TowerStatusDire { get; set; }

        // Bitmask. An integer that represents a binary of which Radiant towers are still standing.
        [JsonProperty("tower_status_radiant")]
        public int TowerStatusRadiant { get; set; }

        // Parse version, used internally by OpenDota
        [JsonProperty("version")]
        public int? Version { get; set; }

        // Salt of the replay file
        [JsonProperty("replay_salt")]
        public long ReplaySalt { get; set; }

        [JsonProperty("series_id")]
        public long SeriesId { get; set; }

        [JsonProperty("series_type")]
        public long SeriesType { get; set; }

        // Information about the league (if any)
        [JsonProperty("league")]
        public League League { get; set; }

        // Radiant team information
        [JsonProperty("radiant_team")]
        public MatchTeam RadiantTeam { get; set; }

        // Dire team information
        [JsonProperty("dire_team")]
        public MatchTeam DireTeam { get; set; }

        // Array of information on individual players
        [JsonProperty("players")]
        public List<MatchPlayer> Players { get; set; }

        // Information on the patch version the game is played on
        [JsonProperty("patch")]
        public int Patch { get; set; }

        // Integer corresponding to the region the game was played on
        [JsonProperty("region")]
        public int Region { get; set; }

        // Word counts of the all chat messages in the player's games (string-message, int-amount of times used)
        [JsonProperty("all_word_counts")]
        public Dictionary<string, int> AllWordCounts { get; set; }

        // Word counts of the player's all chat messages
        [JsonProperty("my_word_counts")]
        public Dictionary<string, int> MyWordCounts { get; set; }

        // Maximum gold advantage of the player's team if they lost the match
        [JsonProperty("throw")]
        public int Throw { get; set; }

        // Maximum gold disadvantage of the player's team if they won the match
        [JsonProperty("comeback")]
        public int Comeback { get; set; }

        [JsonProperty("stomp")]
        public int Stomp { get; set; }

        // Maximum gold disadvantage of the player's team if they lost the match
        [JsonProperty("loss")]
        public int Loss { get; set; }

        // Maximum gold advantage of the player's team if they won the match
        [JsonProperty("win")]
        public int Win { get; set; }

        // The url 
        [JsonProperty("replay_url")]
        public Uri ReplayUrl { get; set; }
    }
}
