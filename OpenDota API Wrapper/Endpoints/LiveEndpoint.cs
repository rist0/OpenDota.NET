using Newtonsoft.Json;
using OpenDotaDotNet.Interfaces;
using OpenDotaDotNet.Models.Live;
using OpenDotaDotNet.Requests;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OpenDotaDotNet.Endpoints
{
    public class LiveEndpoint : ILiveEndpoint
    {
        private const string TopLiveGames = "live";

        private readonly Request _request;

        public LiveEndpoint(Request request)
        {
            _request = request;
        }

        /// <summary>
        /// Get top currently ongoing live games
        /// </summary>
        /// <returns></returns>
        public async Task<List<LiveGame>> GetTopLiveGamesAsync()
        {
            var response = await _request.GetRequestResponseMessageAsync(TopLiveGames);

            response.EnsureSuccessStatusCode();

            var topLiveGames = JsonConvert.DeserializeObject<List<LiveGame>>(await response.Content.ReadAsStringAsync());

            return topLiveGames;
        }
    }
}
