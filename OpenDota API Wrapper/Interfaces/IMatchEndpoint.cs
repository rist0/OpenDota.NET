using OpenDotaDotNet.Models.Matches;
using System.Threading.Tasks;

namespace OpenDotaDotNet.Interfaces
{
    public interface IMatchEndpoint
    {
        /// <summary>
        /// Get match data by ID
        /// </summary>
        /// <param name="matchId">Id of the match</param>
        /// <returns></returns>
        Task<Match> GetMatchByIdAsync(long matchId);
    }
}
