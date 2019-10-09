using OpenDotaDotNet.Models.ProPlayers;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace OpenDotaDotNet.Interfaces
{
    public interface IProPlayerEndpoint
    {
        /// <summary>
        /// Get list of pro players
        /// </summary>
        /// <returns></returns>
        Task<List<ProPlayer>> GetProPlayersAsync();
    }
}
