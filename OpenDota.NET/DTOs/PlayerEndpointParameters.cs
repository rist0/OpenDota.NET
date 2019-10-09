using System.Collections.Generic;

namespace OpenDotaDotNet.Dtos
{
    public class PlayerEndpointParameters
    {
        /// <summary>
        /// Number of matches to limit to
        /// </summary>
        public int? Limit { get; set; }

        /// <summary>
        /// Number of matches to offset start by
        /// </summary>
        public int? Offset { get; set; }

        /// <summary>
        /// Whether the player won
        /// </summary>
        public int? Win { get; set; }

        /// <summary>
        /// Patch ID
        /// </summary>
        public int? Patch { get; set; }

        /// <summary>
        /// Game Mode ID
        /// </summary>
        public int? GameMode { get; set; }

        /// <summary>
        /// Lobby type ID
        /// </summary>
        public int? LobbyType { get; set; }

        /// <summary>
        /// Region ID
        /// </summary>
        public int? Region { get; set; }

        /// <summary>
        /// Days previous
        /// </summary>
        public int? Date { get; set; }

        /// <summary>
        /// Lane Role ID
        /// </summary>
        public int? LaneRole { get; set; }

        /// <summary>
        /// Hero ID
        /// </summary>
        public int? HeroId { get; set; }

        /// <summary>
        /// Whether the player was radiant
        /// </summary>
        public int? IsRadiant { get; set; }

        /// <summary>
        /// Account IDs in the match (array)
        /// </summary>
        public List<int> IncludedAccountIds { get; set; }

        /// <summary>
        /// Account IDs not in the match (array)
        /// </summary>
        public List<int> ExcludedAccountIds { get; set; }

        /// <summary>
        /// Hero IDs on the player's team (array)
        /// </summary>
        public List<int> WithHeroIds { get; set; }

        /// <summary>
        /// Hero IDs against the player's team (array)
        /// </summary>
        public List<int> AgainstHeroIds { get; set; }

        /// <summary>
        /// Whether the match was significant for aggregation purposes. Defaults to 1 (true), set this to 0 to return data for non-standard modes/matches.
        /// </summary>
        public int? Significant { get; set; }

        /// <summary>
        /// The minimum number of games played, for filtering hero stats
        /// </summary>
        public int? Having { get; set; }

        /// <summary>
        /// The field to return matches sorted by in descending order
        /// </summary>
        public string Sort { get; set; }

        /// <summary>
        /// Fields to project (array)
        /// </summary>
        public List<string> Project { get; set; }
    }
}
