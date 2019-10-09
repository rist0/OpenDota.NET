using OpenDotaDotNet.Models.Teams;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OpenDotaDotNet.Interfaces
{
    public interface ITeamEndpoint
    {
        /// <summary>
        /// Get team data
        /// </summary>
        /// <returns></returns>
        Task<List<Team>> GetTeamsAsync();

        /// <summary>
        /// Get data for a team
        /// </summary>
        /// <param name="teamId"></param>
        /// <returns></returns>
        Task<Team> GetTeamByIdAsync(int teamId);

        /// <summary>
        /// Get matches for a team
        /// </summary>
        /// <param name="teamId"></param>
        /// <returns></returns>
        Task<List<TeamMatch>> GetTeamMatchesByIdAsync(int teamId);

        /// <summary>
        /// Get players who have played for a team
        /// </summary>
        /// <param name="teamId"></param>
        /// <returns></returns>
        Task<List<TeamPlayer>> GetTeamPlayersByIdAsync(int teamId);

        /// <summary>
        /// Get heroes for a team
        /// </summary>
        /// <param name="teamId"></param>
        /// <returns></returns>
        Task<List<TeamHero>> GetTeamHeroesByIdAsync(int teamId);
    }
}
