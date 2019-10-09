using OpenDotaDotNet.Models.Replays;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OpenDotaDotNet.Interfaces
{
    public interface IReplayEndpoint
    {
        /// <summary>
        /// Get data to construct a replay URL with
        /// </summary>
        /// <param name="matchIds">Match IDs (array)</param>
        /// <returns></returns>
        Task<List<Replay>> GetReplayDataAsync(List<long> matchIds);
    }
}
