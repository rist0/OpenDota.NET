using OpenDotaDotNet.Models.Benchmarks;
using System.Threading.Tasks;

namespace OpenDotaDotNet.Interfaces
{
    public interface IBenchmarkEndpoint
    {
        /// <summary>
        /// Benchmarks of average stat values for a hero
        /// </summary>
        /// <param name="heroId"></param>
        /// <returns></returns>
        Task<HeroBenchmark> GetHeroBenchmarkAsync(int heroId);
    }
}
