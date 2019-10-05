using Newtonsoft.Json;
using System.Collections.Generic;

namespace OpenDotaDotNet.Models.Players
{
    public class PlayerWordcloud
    {
        [JsonProperty("my_word_counts")]
        public Dictionary<string, long> MyWordCounts { get; set; }

        [JsonProperty("all_word_counts")]
        public Dictionary<string, long> AllWordCounts { get; set; }
    }
}
