using Newtonsoft.Json;
using OpenDotaDotNet.Interfaces;
using OpenDotaDotNet.Models.Records;
using OpenDotaDotNet.Requests;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OpenDotaDotNet.Endpoints
{
    class RecordEndpoint : IRecordEndpoint
    {
        private const string Records = "records/{0}";

        private readonly Request _request;

        public RecordEndpoint(Request request)
        {
            _request = request;
        }

        /// <summary>
        /// Get top performances in a stat
        /// </summary>
        /// <param name="field">Field name to query</param>
        /// <returns></returns>
        public async Task<List<Record>> GetRecordsByFieldAsync(RecordField field)
        {
            var response = await _request.GetRequestResponseMessageAsync(string.Format(Records, field.Value));

            response.EnsureSuccessStatusCode();

            var records = JsonConvert.DeserializeObject<List<Record>>(await response.Content.ReadAsStringAsync());

            return records;
        }
    }
}
