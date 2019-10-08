using OpenDotaDotNet.Models.ProMatches;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OpenDotaDotNet.Interfaces
{
    public interface IProMatchEndpoint
    {
        /// <summary>
        /// Get list of pro matches
        /// </summary>
        /// <param name="lessThanMatchId">Get matches with a match ID lower than this value</param>
        /// <returns></returns>
        Task<List<ProMatch>> GetProMatchesAsync(long? lessThanMatchId = null);
    }
}
