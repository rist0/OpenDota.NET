using OpenDotaDotNet.Models.HealthStatus;
using System;
using System.Collections.Generic;
using System.Text;
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
