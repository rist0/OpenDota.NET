using Newtonsoft.Json;
using OpenDotaDotNet.Interfaces;
using OpenDotaDotNet.Models.Leagues;
using OpenDotaDotNet.Requests;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OpenDotaDotNet.Endpoints
{
    public class LeagueEndpoint : ILeagueEndpoint
    {
        private const string Leagues = "leagues";

        private readonly Request _request;

        public LeagueEndpoint(Request request)
        {
            _request = request;
        }

        /// <summary>
        /// Get league data
        /// </summary>
        /// <returns></returns>
        public async Task<List<League>> GetLeaguesAsync()
        {
            var response = await _request.GetRequestResponseMessageAsync(Leagues);

            response.EnsureSuccessStatusCode();

            var leagues = JsonConvert.DeserializeObject<List<League>>(await response.Content.ReadAsStringAsync());

            return leagues;
        }
    }
}
