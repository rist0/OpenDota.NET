using OpenDotaDotNet.Models.Leagues;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OpenDotaDotNet.Interfaces
{
    public interface ILeagueEndpoint
    {
        /// <summary>
        /// Get league data
        /// </summary>
        /// <returns></returns>
        Task<List<League>> GetLeaguesAsync();
    }
}
