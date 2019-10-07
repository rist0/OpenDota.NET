using OpenDotaDotNet.Models.Live;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OpenDotaDotNet.Interfaces
{
    public interface ILiveEndpoint
    {
        /// <summary>
        /// Get top currently ongoing live games
        /// </summary>
        /// <returns></returns>
        Task<List<LiveGame>> GetTopLiveGamesAsync();
    }
}
