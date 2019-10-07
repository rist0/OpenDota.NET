using Newtonsoft.Json;
using OpenDotaDotNet.Interfaces;
using OpenDotaDotNet.Models.Benchmarks;
using OpenDotaDotNet.Requests;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OpenDotaDotNet.Endpoints
{
    public class BenchmarksEndpoint : IBenchmarkEndpoint
    {
        private const string Benchmarks = "benchmarks";

        private readonly Request _request;

        public BenchmarksEndpoint(Request request)
        {
            _request = request;
        }

        public async Task<HeroBenchmark> GetHeroBenchmarkAsync(int heroId)
        {
            var addedArguments = CreateArgumentListForBenchmarksRequest(heroId);

            var response = await _request.GetRequestResponseMessageAsync(Benchmarks, addedArguments);

            response.EnsureSuccessStatusCode();

            var heroBenchmarks = JsonConvert.DeserializeObject<HeroBenchmark>(await response.Content.ReadAsStringAsync());

            return heroBenchmarks;
        }

        #region Helper
        private List<string> CreateArgumentListForBenchmarksRequest(int? heroId = null)
        {
            var addedArguments = new List<string>();

            if (heroId != null)
            {
                addedArguments.Add($@"hero_id={heroId}");
            }

            return addedArguments;
        }
        #endregion
    }
}
