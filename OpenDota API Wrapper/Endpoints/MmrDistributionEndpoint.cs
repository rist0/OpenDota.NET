using Newtonsoft.Json;
using OpenDotaDotNet.Interfaces;
using OpenDotaDotNet.Models.Distributions;
using OpenDotaDotNet.Requests;
using System.Threading.Tasks;

namespace OpenDotaDotNet.Endpoints
{
    public class MmrDistributionEndpoint : IMmrDistributionEndpoint
    {
        private const string MmrDistribution = "distributions";

        private readonly Request _request;

        public MmrDistributionEndpoint(Request request)
        {
            _request = request;
        }

        /// <summary>
        /// Distributions of MMR data by bracket and country
        /// </summary>
        /// <returns></returns>
        public async Task<MmrDistribution> GetMmrDistributionAsync()
        {
            var response = await _request.GetRequestResponseMessageAsync(MmrDistribution);

            response.EnsureSuccessStatusCode();

            var mmrDistribution = JsonConvert.DeserializeObject<MmrDistribution>(await response.Content.ReadAsStringAsync());

            return mmrDistribution;
        }
    }
}
