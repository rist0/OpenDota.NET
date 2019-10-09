using Newtonsoft.Json;
using System.Collections.Generic;

namespace OpenDotaDotNet.Models.Rankings
{
    public class HeroRanking
    {
        [JsonProperty("hero_id")]
        public long HeroId { get; set; }

        [JsonProperty("rankings")]
        public List<RankingPlayer> Rankings { get; set; }
    }
}
