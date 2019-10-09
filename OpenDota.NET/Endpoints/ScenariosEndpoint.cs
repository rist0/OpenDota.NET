using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;
using OpenDotaDotNet.Interfaces;
using OpenDotaDotNet.Models.Scenarios;
using OpenDotaDotNet.Requests;

namespace OpenDotaDotNet.Endpoints
{
    public class ScenariosEndpoint : IScenariosEndpoint
    {
        private const string WinrateForCertainItemTimings = "scenarios/itemTimings";
        private const string WinRateForHeroesInCertainLaneRole = "scenarios/laneRoles";
        private const string MiscellaneousTeamScenarios = "scenarios/misc";

        private readonly Request _request;

        public ScenariosEndpoint(Request request)
        {
            _request = request;
        }

        /// <summary>
        /// Win rates for certain item timings on a hero for items that cost at least 1400 gold
        /// </summary>
        /// <param name="item">Filter by item name e.g. "spirit_vessel"</param>
        /// <param name="heroId">Hero ID</param>
        /// <returns></returns>
        public async Task<List<HeroItemTiming>> GetWinRateForCertainItemTimingsOnHeroesAsync(string item = null, int? heroId = null)
        {
            var addedArguments = CreateArgumentListForScenariosRequest(item, heroId);

            var response = await _request.GetRequestResponseMessageAsync(WinrateForCertainItemTimings, addedArguments);

            response.EnsureSuccessStatusCode();

            var heroItemTimings = JsonConvert.DeserializeObject<List<HeroItemTiming>>(await response.Content.ReadAsStringAsync());

            return heroItemTimings;
        }

        /// <summary>
        /// Win rates for heroes in certain lane roles
        /// </summary>
        /// <param name="laneRole">Filter by lane role 1-4 (Safe, Mid, Off, Jungle)</param>
        /// <param name="heroId">Hero ID</param>
        /// <returns></returns>
        public async Task<List<HeroLaneRoleWinrate>> GetWinRateForHeroesInCertainLaneRolesAsync(int? laneRole = null, int? heroId = null)
        {
            var addedArguments = CreateArgumentListForScenariosRequest(null, heroId, laneRole);

            var response = await _request.GetRequestResponseMessageAsync(WinRateForHeroesInCertainLaneRole, addedArguments);

            response.EnsureSuccessStatusCode();

            var heroBenchmarks = JsonConvert.DeserializeObject<List<HeroLaneRoleWinrate>>(await response.Content.ReadAsStringAsync());

            return heroBenchmarks;
        }

        /// <summary>
        /// Miscellaneous team scenarios
        /// </summary>
        /// <param name="scenario">pos_chat_1min,neg_chat_1min,courier_kill,first_blood</param>
        public async Task<List<MiscellaneousTeamScenario>> GetMiscellaneousTeamScenariosAsync(string scenario = null)
        {
            var addedArguments = CreateArgumentListForScenariosRequest(null, null, null, scenario);

            var response = await _request.GetRequestResponseMessageAsync(MiscellaneousTeamScenarios, addedArguments);

            response.EnsureSuccessStatusCode();

            var heroBenchmarks = JsonConvert.DeserializeObject<List<MiscellaneousTeamScenario>>(await response.Content.ReadAsStringAsync());

            return heroBenchmarks;
        }

        #region Helper
        private List<string> CreateArgumentListForScenariosRequest(string item = null, int? heroId = null, int? laneRole = null, string scenario = null)
        {
            var addedArguments = new List<string>();

            if (item != null)
            {
                addedArguments.Add($@"item={item}");
            }

            if (heroId != null)
            {
                addedArguments.Add($@"hero_id={heroId}");
            }

            if (laneRole != null)
            {
                addedArguments.Add($@"lane_role={laneRole}");
            }

            if (scenario != null)
            {
                addedArguments.Add($@"scenario={scenario}");
            }

            return addedArguments;
        }
        #endregion
    }
}
