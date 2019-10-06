using OpenDotaDotNet.Models.Distributions;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace OpenDotaDotNet.Interfaces
{
    public interface IMmrDistributionEndpoint
    {
        /// <summary>
        /// Distributions of MMR data by bracket and country
        /// </summary>
        /// <returns></returns>
        Task<MmrDistribution> GetMmrDistributionAsync();
    }
}
