using Newtonsoft.Json;
using OpenDotaDotNet.Interfaces;
using OpenDotaDotNet.Models.HealthStatus;
using OpenDotaDotNet.Requests;
using System.Threading.Tasks;

namespace OpenDotaDotNet.Endpoints
{
    public class HealthEndpoint : IHealthEndpoint
    {
        private const string ServiceHealth = "health";

        private readonly Request _request;

        public HealthEndpoint(Request request)
        {
            _request = request;
        }

        /// <summary>
        /// Get service health data
        /// </summary>
        /// <returns></returns>
        public async Task<ServiceHealth> GetServiceHealthDataAsync()
        {
            var response = await _request.GetRequestResponseMessageAsync(ServiceHealth);

            response.EnsureSuccessStatusCode();

            var serviceHealth = JsonConvert.DeserializeObject<ServiceHealth>(await response.Content.ReadAsStringAsync());

            return serviceHealth;
        }
    }
}
