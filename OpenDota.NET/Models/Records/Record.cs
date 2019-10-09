using Newtonsoft.Json;

namespace OpenDotaDotNet.Models.Records
{
    public class Record
    {
        [JsonProperty("match_id")]
        public string MatchId { get; set; }

        [JsonProperty("start_time")]
        public string StartTime { get; set; }

        /// <summary>
        /// The ID value of the hero played
        /// </summary>
        [JsonProperty("hero_id")]
        public int HeroId { get; set; }

        [JsonProperty("score")]
        public long Score { get; set; }
    }
}
