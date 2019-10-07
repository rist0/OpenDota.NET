using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace OpenDotaDotNet.Models.Request
{
    public class ParseRequestState
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("timestamp")]
        public DateTimeOffset Timestamp { get; set; }

        [JsonProperty("attempts")]
        public int Attempts { get; set; }

        [JsonProperty("data")]
        public Data Data { get; set; }

        [JsonProperty("next_attempt_time")]
        public DateTimeOffset NextAttemptTime { get; set; }

        [JsonProperty("priority")]
        public int Priority { get; set; }

        [JsonProperty("jobId")]
        public long JobId { get; set; }
    }

    public partial class Data
    {
        [JsonProperty("match_id")]
        public long MatchId { get; set; }

        [JsonProperty("radiant_win")]
        public bool RadiantWin { get; set; }

        [JsonProperty("start_time")]
        public long StartTime { get; set; }

        [JsonProperty("duration")]
        public int Duration { get; set; }

        [JsonProperty("pgroup")]
        public Dictionary<string, Pgroup> Pgroup { get; set; }

        [JsonProperty("ability_upgrades")]
        public List<object> AbilityUpgrades { get; set; }
    }

    public partial class Pgroup
    {
        [JsonProperty("account_id")]
        public long? AccountId { get; set; }

        [JsonProperty("hero_id")]
        public int HeroId { get; set; }

        [JsonProperty("player_slot")]
        public int PlayerSlot { get; set; }
    }
}
