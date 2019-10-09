using Newtonsoft.Json;
using System.Collections.Generic;

namespace OpenDotaDotNet.Models.Live
{
    public class LiveGame
    {
        [JsonProperty("activate_time")]
        public long ActivateTime { get; set; }

        [JsonProperty("deactivate_time")]
        public long DeactivateTime { get; set; }

        [JsonProperty("server_steam_id")]
        public string ServerSteamId { get; set; }

        [JsonProperty("lobby_id")]
        public string LobbyId { get; set; }

        [JsonProperty("league_id")]
        public long LeagueId { get; set; }

        [JsonProperty("lobby_type")]
        public long LobbyType { get; set; }

        [JsonProperty("game_time")]
        public int GameTime { get; set; }

        [JsonProperty("delay")]
        public int Delay { get; set; }

        [JsonProperty("spectators")]
        public int Spectators { get; set; }

        [JsonProperty("game_mode")]
        public int GameMode { get; set; }

        [JsonProperty("average_mmr")]
        public int AverageMmr { get; set; }

        [JsonProperty("match_id")]
        public long MatchId { get; set; }

        [JsonProperty("series_id")]
        public long SeriesId { get; set; }

        [JsonProperty("sort_score")]
        public long SortScore { get; set; }

        [JsonProperty("last_update_time")]
        public long LastUpdateTime { get; set; }

        [JsonProperty("radiant_lead")]
        public int RadiantLead { get; set; }

        [JsonProperty("radiant_score")]
        public int RadiantScore { get; set; }

        [JsonProperty("dire_score")]
        public int DireScore { get; set; }

        [JsonProperty("players")]
        public List<LiveGamePlayer> Players { get; set; }

        [JsonProperty("building_state")]
        public long BuildingState { get; set; }

        [JsonProperty("team_name_radiant", NullValueHandling = NullValueHandling.Ignore)]
        public string TeamNameRadiant { get; set; }

        [JsonProperty("team_name_dire", NullValueHandling = NullValueHandling.Ignore)]
        public string TeamNameDire { get; set; }

        [JsonProperty("team_logo_radiant", NullValueHandling = NullValueHandling.Ignore)]
        public string TeamLogoRadiant { get; set; }

        [JsonProperty("team_logo_dire", NullValueHandling = NullValueHandling.Ignore)]
        public string TeamLogoDire { get; set; }

        [JsonProperty("team_id_radiant", NullValueHandling = NullValueHandling.Ignore)]
        public long? TeamIdRadiant { get; set; }

        [JsonProperty("team_id_dire", NullValueHandling = NullValueHandling.Ignore)]
        public long? TeamIdDire { get; set; }
    }
}
