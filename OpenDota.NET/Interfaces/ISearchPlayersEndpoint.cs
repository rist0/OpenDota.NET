using OpenDotaDotNet.Models.Search;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OpenDotaDotNet.Interfaces
{
    public interface ISearchEndpoint
    {
        /// <summary>
        /// Search players by personaname.
        /// </summary>
        /// <param name="query"></param>
        /// <returns></returns>
        Task<List<SearchPlayerResponse>> GetPlayersByNameAsync(string query);
    }
}
