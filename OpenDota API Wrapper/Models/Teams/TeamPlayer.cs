using Newtonsoft.Json;

namespace OpenDotaDotNet.Models.Teams
{
    public class TeamPlayer
    {
        [JsonProperty("account_id")]
        public long AccountId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("games_played")]
        public long GamesPlayed { get; set; }

        [JsonProperty("wins")]
        public long Wins { get; set; }

        [JsonProperty("is_current_team_member")]
        public bool? IsCurrentTeamMember { get; set; }
    }
}
