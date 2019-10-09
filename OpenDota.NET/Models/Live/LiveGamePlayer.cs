using Newtonsoft.Json;

namespace OpenDotaDotNet.Models.Live
{
    public class LiveGamePlayer
    {
        [JsonProperty("account_id")]
        public long AccountId { get; set; }

        [JsonProperty("hero_id")]
        public int HeroId { get; set; }

        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        [JsonProperty("country_code", NullValueHandling = NullValueHandling.Ignore)]
        public string CountryCode { get; set; }

        [JsonProperty("fantasy_role", NullValueHandling = NullValueHandling.Ignore)]
        public long? FantasyRole { get; set; }

        [JsonProperty("team_id", NullValueHandling = NullValueHandling.Ignore)]
        public long? TeamId { get; set; }

        [JsonProperty("team_name")]
        public string TeamName { get; set; }

        [JsonProperty("team_tag")]
        public string TeamTag { get; set; }

        [JsonProperty("is_locked", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsLocked { get; set; }

        [JsonProperty("is_pro", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsPro { get; set; }

        [JsonProperty("locked_until")]
        public object LockedUntil { get; set; }
    }
}
