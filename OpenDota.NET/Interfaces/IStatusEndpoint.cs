using OpenDotaDotNet.Models.HealthStatus;
using System.Threading.Tasks;

namespace OpenDotaDotNet.Interfaces
{
    public interface IStatusEndpoint
    {
        /// <summary>
        /// Get current service statistics
        /// </summary>
        /// <returns></returns>
        Task<ServiceStatistics> GetServiceStatisticsAsync();
    }
}
