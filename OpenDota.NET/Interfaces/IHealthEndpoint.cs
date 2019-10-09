using OpenDotaDotNet.Models.HealthStatus;
using System.Threading.Tasks;

namespace OpenDotaDotNet.Interfaces
{
    public interface IHealthEndpoint
    {
        /// <summary>
        /// Get service health data
        /// </summary>
        /// <returns></returns>
        Task<ServiceHealth> GetServiceHealthDataAsync();
    }
}
