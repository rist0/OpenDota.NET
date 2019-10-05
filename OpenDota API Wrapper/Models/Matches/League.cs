using Newtonsoft.Json;

namespace OpenDotaDotNet.Models.Matches
{
    public class League
    {
        // Id of league
        [JsonProperty("leagueid")]
        public long Leagueid { get; set; }

        // always null?
        // [JsonProperty("ticket")]
        // public object Ticket { get; set; }

        // Banner of the league - always returns null?
        // [JsonProperty("banner")]
        // public object Banner { get; set; }

        // League tier (amateur, professional, etc)
        [JsonProperty("tier")]
        public string Tier { get; set; }

        // Name of the league
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
