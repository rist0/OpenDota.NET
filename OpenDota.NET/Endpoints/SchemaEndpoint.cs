using Newtonsoft.Json;
using OpenDotaDotNet.Interfaces;
using OpenDotaDotNet.Models.Schema;
using OpenDotaDotNet.Requests;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OpenDotaDotNet.Endpoints
{
    public class SchemaEndpoint : ISchemaEndpoint
    {
        private const string GetDatabaseSchema = "schema";

        private readonly Request _request;

        public SchemaEndpoint(Request request)
        {
            _request = request;
        }

        /// <summary>
        /// Get database schema
        /// </summary>
        /// <returns></returns>
        public async Task<List<DatabaseSchema>> GetDatabaseSchemaAsync()
        {
            var response = await _request.GetRequestResponseMessageAsync(GetDatabaseSchema);

            response.EnsureSuccessStatusCode();

            var databaseSchema = JsonConvert.DeserializeObject<List<DatabaseSchema>>(await response.Content.ReadAsStringAsync());

            return databaseSchema;
        }
    }
}
