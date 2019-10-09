using OpenDotaDotNet.Models.Metadata;
using System.Threading.Tasks;

namespace OpenDotaDotNet.Interfaces
{
    public interface IMetadataEndpoint
    {
        /// <summary>
        /// Site metadata
        /// </summary>
        /// <returns></returns>
        Task<Metadata> GetMetadataAsync();
    }
}
