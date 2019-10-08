using Newtonsoft.Json;
using OpenDotaDotNet.Interfaces;
using OpenDotaDotNet.Models.HealthStatus;
using OpenDotaDotNet.Requests;
using System.Threading.Tasks;

namespace OpenDotaDotNet.Endpoints
{
    public class StatusEndpoint : IStatusEndpoint
    {
        private const string ServiceStatistics = "status";

        private readonly Request _request;

        public StatusEndpoint(Request request)
        {
            _request = request;
        }

        /// <summary>
        /// Get current service statistics
        /// </summary>
        /// <returns></returns>
        public async Task<ServiceStatistics> GetServiceStatisticsAsync()
        {
            var response = await _request.GetRequestResponseMessageAsync(ServiceStatistics);

            response.EnsureSuccessStatusCode();

            var serviceStatistics = JsonConvert.DeserializeObject<ServiceStatistics>(await response.Content.ReadAsStringAsync());

            return serviceStatistics;
        }
    }
}
