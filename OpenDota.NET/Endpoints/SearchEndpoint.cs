using Newtonsoft.Json;
using OpenDotaDotNet.Interfaces;
using OpenDotaDotNet.Models.Search;
using OpenDotaDotNet.Requests;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OpenDotaDotNet.Endpoints
{
    public class SearchEndpoint : ISearchEndpoint
    {
        private const string Search = "search";

        private readonly Request _request;

        public SearchEndpoint(Request request)
        {
            _request = request;
        }

        /// <summary>
        /// Search players by personaname.
        /// </summary>
        /// <param name="query"></param>
        /// <returns></returns>
        public async Task<List<SearchPlayerResponse>> GetPlayersByNameAsync(string query)
        {
            var addedArguments = CreateArgumentListForSearchPlayersRequest(query);

            var response = await _request.GetRequestResponseMessageAsync(Search, addedArguments);

            response.EnsureSuccessStatusCode();

            var players = JsonConvert.DeserializeObject<List<SearchPlayerResponse>>(await response.Content.ReadAsStringAsync());

            return players;
        }

        #region Helper
        private List<string> CreateArgumentListForSearchPlayersRequest(string query = null)
        {
            var addedArguments = new List<string>();

            if (query != null)
            {
                addedArguments.Add($@"q={query}");
            }

            return addedArguments;
        }
        #endregion
    }
}
