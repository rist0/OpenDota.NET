using OpenDotaDotNet.Models.Scenarios;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OpenDotaDotNet.Interfaces
{
    public interface IScenariosEndpoint
    {
        /// <summary>
        /// Win rates for certain item timings on a hero for items that cost at least 1400 gold
        /// </summary>
        /// <param name="item">Filter by item name e.g. "spirit_vessel"</param>
        /// <param name="heroId">Hero ID</param>
        /// <returns></returns>
        Task<List<HeroItemTiming>> GetWinRateForCertainItemTimingsOnHeroesAsync(string item = null, int? heroId = null);

        /// <summary>
        /// Win rates for heroes in certain lane roles
        /// </summary>
        /// <param name="laneRole">Filter by lane role 1-4 (Safe, Mid, Off, Jungle)</param>
        /// <param name="heroId">Hero ID</param>
        /// <returns></returns>
        Task<List<HeroLaneRoleWinrate>> GetWinRateForHeroesInCertainLaneRolesAsync(int? laneRole = null, int? heroId = null);

        /// <summary>
        /// Miscellaneous team scenarios
        /// </summary>
        /// <param name="scenario">pos_chat_1min,neg_chat_1min,courier_kill,first_blood</param>
        /// <returns></returns>
        Task<List<MiscellaneousTeamScenario>> GetMiscellaneousTeamScenariosAsync(string scenario = null);
    }
}
