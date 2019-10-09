using OpenDotaDotNet.Models.Heroes;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OpenDotaDotNet.Interfaces
{
    public interface IHeroEndpoint
    {
        /// <summary>
        /// Get hero data
        /// </summary>
        /// <returns></returns>
        Task<List<Hero>> GetHeroesAsync();

        /// <summary>
        /// Get recent matches with a hero
        /// </summary>
        /// <param name="heroId"></param>
        /// <returns></returns>
        Task<List<HeroMatch>> GetHeroMatchesAsync(int heroId);

        /// <summary>
        /// Get results against other heroes for a hero
        /// </summary>
        /// <param name="heroId"></param>
        /// <returns></returns>
        Task<List<HeroMatchup>> GetHeroMatchupsAsync(int heroId);

        /// <summary>
        /// Get hero performance over a range of match durations
        /// </summary>
        /// <param name="heroId"></param>
        /// <returns></returns>
        Task<List<HeroDuration>> GetHeroDurationsAsync(int heroId);

        /// <summary>
        /// Get players who have played this hero
        /// </summary>
        /// <param name="heroId"></param>
        /// <returns></returns>
        Task<List<HeroPlayer>> GetHeroPlayersAsync(int heroId);
    }
}
