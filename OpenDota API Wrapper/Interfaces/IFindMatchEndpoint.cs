using OpenDotaDotNet.Models.FindMatches;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OpenDotaDotNet.Interfaces
{
    public interface IFindMatchEndpoint
    {
        /// <summary>
        /// Finds matches by heroes played (currently includes matches played after April 2019)
        /// </summary>
        /// <param name="teamA"></param>
        /// <param name="teamB"></param>
        /// <returns></returns>
        Task<List<FindMatch>> FindMatchesByHeroesPlayedAsync(List<int> teamA = null, List<int> teamB = null);
    }
}
