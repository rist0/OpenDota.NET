using Newtonsoft.Json;
using OpenDotaDotNet.Interfaces;
using OpenDotaDotNet.Models.HeroStats;
using OpenDotaDotNet.Requests;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OpenDotaDotNet.Endpoints
{
    public class HeroStatsEndpoint : IHeroStatsEndpoint
    {
        private const string HeroStats = "heroStats";

        private readonly Request _request;

        public HeroStatsEndpoint(Request request)
        {
            _request = request;
        }

        /// <summary>
        /// Get stats about hero performance in recent matches
        /// </summary>
        /// <returns></returns>
        public async Task<List<HeroStats>> GetHeroStatsAsync()
        {
            var response = await _request.GetRequestResponseMessageAsync(HeroStats);

            response.EnsureSuccessStatusCode();

            var heroStats = JsonConvert.DeserializeObject<List<HeroStats>>(await response.Content.ReadAsStringAsync());

            return heroStats;
        }
    }
}
