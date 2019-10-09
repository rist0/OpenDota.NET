using OpenDotaDotNet.Models.Distributions;
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
