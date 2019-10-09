using Newtonsoft.Json;
using OpenDotaDotNet.Interfaces;
using OpenDotaDotNet.Models.FindMatches;
using OpenDotaDotNet.Requests;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OpenDotaDotNet.Endpoints
{
    public class FindMatchEndpoint : IFindMatchEndpoint
    {
        private const string FindMatchesByHeroPlayed = "findMatches";

        private readonly Request _request;

        public FindMatchEndpoint(Request request)
        {
            _request = request;
        }

        /// <summary>
        /// Finds matches by heroes played (currently includes matches played after April 2019)
        /// </summary>
        /// <param name="teamA"></param>
        /// <param name="teamB"></param>
        /// <returns></returns>
        public async Task<List<FindMatch>> FindMatchesByHeroesPlayedAsync(List<int> teamA = null, List<int> teamB = null)
        {
            var addedArguments = CreateArgumentListForFindMatchesRequest(teamA, teamB);

            var response = await _request.GetRequestResponseMessageAsync(FindMatchesByHeroPlayed, addedArguments);

            response.EnsureSuccessStatusCode();

            var findMatches = JsonConvert.DeserializeObject<List<FindMatch>>(await response.Content.ReadAsStringAsync());

            return findMatches;
        }

        #region Helper
        private List<string> CreateArgumentListForFindMatchesRequest(List<int> teamA = null, List<int> teamB = null)
        {
            var addedArguments = new List<string>();

            if (teamA != null)
            {
                foreach (var heroId in teamA)
                {
                    addedArguments.Add($@"teamA={heroId}");
                }
            }

            if (teamB != null)
            {
                foreach (var heroId in teamB)
                {
                    addedArguments.Add($@"teamB={heroId}");
                }
            }

            return addedArguments;
        }
        #endregion
    }
}
