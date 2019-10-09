using System.Threading.Tasks;
using Newtonsoft.Json;
using OpenDotaDotNet.Interfaces;
using OpenDotaDotNet.Models.Matches;
using OpenDotaDotNet.Requests;

namespace OpenDotaDotNet.Endpoints
{
    public class MatchEndpoint : IMatchEndpoint
    {
        private const string MatchByIdUrl = "matches/{0}";

        private readonly Request _request;

        public MatchEndpoint(Request request)
        {
            _request = request;
        }

        public async Task<Match> GetMatchByIdAsync(long matchId)
        {
            var response = await _request.GetRequestResponseMessageAsync(string.Format(MatchByIdUrl, matchId));

            response.EnsureSuccessStatusCode();

            var matchInfo = JsonConvert.DeserializeObject<Match>(await response.Content.ReadAsStringAsync());

            return matchInfo;
        }
    }
}
