using OpenDotaDotNet.Models.Rankings;
using System.Threading.Tasks;

namespace OpenDotaDotNet.Interfaces
{
    public interface IRankingEndpoint
    {
        /// <summary>
        /// Top players by hero
        /// </summary>
        /// <param name="heroId"></param>
        /// <returns></returns>
        Task<HeroRanking> GetHeroRankingsAsync(int heroId);
    }
}
