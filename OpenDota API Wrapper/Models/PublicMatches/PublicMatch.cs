using Newtonsoft.Json;

namespace OpenDotaDotNet.Models.PublicMatches
{
    public class PublicMatch
    {
        [JsonProperty("match_id")]
        public long MatchId { get; set; }

        [JsonProperty("match_seq_num")]
        public long MatchSeqNum { get; set; }

        [JsonProperty("radiant_win")]
        public bool RadiantWin { get; set; }

        [JsonProperty("start_time")]
        public long StartTime { get; set; }

        [JsonProperty("duration")]
        public int Duration { get; set; }

        [JsonProperty("avg_mmr")]
        public int? AvgMmr { get; set; }

        [JsonProperty("num_mmr")]
        public int? NumMmr { get; set; }

        [JsonProperty("lobby_type")]
        public int LobbyType { get; set; }

        [JsonProperty("game_mode")]
        public int GameMode { get; set; }

        [JsonProperty("avg_rank_tier")]
        public int AvgRankTier { get; set; }

        [JsonProperty("num_rank_tier")]
        public int NumRankTier { get; set; }

        [JsonProperty("cluster")]
        public int Cluster { get; set; }

        [JsonProperty("radiant_team")]
        public string RadiantTeam { get; set; }

        [JsonProperty("dire_team")]
        public string DireTeam { get; set; }
    }
}
