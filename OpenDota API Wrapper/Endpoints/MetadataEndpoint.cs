using Newtonsoft.Json;
using OpenDotaDotNet.Interfaces;
using OpenDotaDotNet.Models.Metadata;
using OpenDotaDotNet.Requests;
using System.Threading.Tasks;

namespace OpenDotaDotNet.Endpoints
{
    class MetadataEndpoint : IMetadataEndpoint
    {
        private const string Metadata = "metadata";

        private readonly Request _request;

        public MetadataEndpoint(Request request)
        {
            _request = request;
        }

        /// <summary>
        /// Site metadata
        /// </summary>
        /// <returns></returns>
        public async Task<Metadata> GetMetadataAsync()
        {
            var response = await _request.GetRequestResponseMessageAsync(Metadata);

            response.EnsureSuccessStatusCode();

            var metadata = JsonConvert.DeserializeObject<Metadata>(await response.Content.ReadAsStringAsync());

            return metadata;
        }
    }
}
