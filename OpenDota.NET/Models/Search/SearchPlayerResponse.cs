using Newtonsoft.Json;
using System;

namespace OpenDotaDotNet.Models.Search
{
    public class SearchPlayerResponse
    {
        [JsonProperty("account_id")]
        public long AccountId { get; set; }

        [JsonProperty("personaname")]
        public string Personaname { get; set; }

        [JsonProperty("avatarfull")]
        public Uri Avatarfull { get; set; }

        /// <summary>
        /// last_match_time. May not be present or null.
        /// </summary>
        [JsonProperty("last_match_time", NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? LastMatchTime { get; set; }

        [JsonProperty("similarity")]
        public double Similarity { get; set; }
    }
}
