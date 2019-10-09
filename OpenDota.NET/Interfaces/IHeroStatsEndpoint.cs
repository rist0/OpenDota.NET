using OpenDotaDotNet.Models.HeroStats;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OpenDotaDotNet.Interfaces
{
    public interface IHeroStatsEndpoint
    {
        /// <summary>
        /// Get stats about hero performance in recent matches
        /// </summary>
        /// <returns></returns>
        Task<List<HeroStats>> GetHeroStatsAsync();
    }
}
