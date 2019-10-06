using OpenDotaDotNet.Models.PublicMatches;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OpenDotaDotNet.Interfaces
{
    public interface IPublicMatchEndpoint
    {
        /// <summary>
        /// Get list of randomly sampled public matches
        /// </summary>
        /// <param name="mmrAscending">Order by MMR ascending</param>
        /// <param name="mmrDescending">Order by MMR descending</param>
        /// <param name="lessThanMatchId">Get matches with a match ID lower than this value</param>
        /// <returns></returns>
        Task<List<PublicMatch>> GetPublicMatchesAsync(int? mmrAscending = null, int? mmrDescending = null, long? lessThanMatchId = null);
    }
}
