using Newtonsoft.Json;
using OpenDotaDotNet.Interfaces;
using OpenDotaDotNet.Models.ProPlayers;
using OpenDotaDotNet.Requests;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OpenDotaDotNet.Endpoints
{
    class ProPlayerEndpoint : IProPlayerEndpoint
    {
        private const string ProPlayers = "proPlayers";

        private readonly Request _request;

        public ProPlayerEndpoint(Request request)
        {
            _request = request;
        }

        /// <summary>
        /// Get list of pro players
        /// </summary>
        /// <returns></returns>
        public async Task<List<ProPlayer>> GetProPlayersAsync()
        {
            var response = await _request.GetRequestResponseMessageAsync(ProPlayers);

            response.EnsureSuccessStatusCode();

            var proPlayers = JsonConvert.DeserializeObject<List<ProPlayer>>(await response.Content.ReadAsStringAsync());

            return proPlayers;
        }
    }
}
