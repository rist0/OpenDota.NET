using Newtonsoft.Json;
using OpenDotaDotNet.Interfaces;
using OpenDotaDotNet.Models.Request;
using OpenDotaDotNet.Requests;
using System.Threading.Tasks;

namespace OpenDotaDotNet.Endpoints
{
    public class RequestEndpoint : IRequestEndpoint
    {
        private const string GetParseState = "request/{0}";
        private const string SubmitNewParse = "request/{0}";

        private readonly Request _request;

        public RequestEndpoint(Request request)
        {
            _request = request;
        }

        /// <summary>
        /// Get parse request state
        /// </summary>
        /// <param name="jobId"></param>
        /// <returns></returns>
        public async Task<ParseRequestState> GetParseRequestStateAsync(long jobId)
        {
            var response = await _request.GetRequestResponseMessageAsync(string.Format(GetParseState, jobId));

            response.EnsureSuccessStatusCode();

            var parseRequestState = JsonConvert.DeserializeObject<ParseRequestState>(await response.Content.ReadAsStringAsync());

            return parseRequestState;
        }

        /// <summary>
        /// Submit a new parse request
        /// </summary>
        /// <param name="matchId"></param>
        /// <returns></returns>
        public async Task<ParseRequest> SubmitNewParseRequestAsync(long matchId)
        {
            var response = await _request.PostRequest(string.Format(SubmitNewParse, matchId));

            response.EnsureSuccessStatusCode();

            var parseRequest = JsonConvert.DeserializeObject<ParseRequest>(await response.Content.ReadAsStringAsync());

            return parseRequest;
        }
    }
}
